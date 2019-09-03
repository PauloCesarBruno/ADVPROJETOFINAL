using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ADV_37_PROJETO_FINAL.Views
{
    public partial class frmNovaVenda : Form
    {
        private Controllers.Cliente cliente = new Controllers.Cliente();
        private Controllers.FormaDePagamento fPagamento = new Controllers.FormaDePagamento();
        private Controllers.TabelaDePreco tPreco = new Controllers.TabelaDePreco();

        private int antQtde, novaQtde;

        private Controllers.Venda venda;
        private Controllers.ItensDaVenda item;
        public frmNovaVenda()
        {
            InitializeComponent();
        }

        private void frmNovaVenda_Load(object sender, EventArgs e)
        {           
            try
            {
                cliente.ListaClientes(dsADV_vendaVarejo, "");
                fPagamento.ListaFormaDePagamentos(dsADV_vendaVarejo);
                tPreco.ListaPrecos(dsADV_vendaVarejo);

                lblVendedor.Text = Controllers.UsuarioLogado.usuario.NomeCompleto;
                cmbProdutos.Text = string.Empty; // Como esta em modo AutoComplete - Começa Vazio.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Erro Detalhe: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <sumary>
        /// Calcula o Subtotal dos Itens adicionados
        /// </sumary>
        private void calculaSubTotaAndTotal()
        {
            decimal subTotal = 0.00M;

            for (int i = 0; i < dgvItensDaVenda.RowCount; i++)
            {
                subTotal += (decimal)dgvItensDaVenda[4, i].Value;
            }

            txtSubTotal.Text = string.Format("{0:0.00}", subTotal);
            txtTotal.Text = string.Format("{0:0.00}", subTotal - decimal.Parse(txtDesconto.Text));
        }

        private void cmbProdutos_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRowView drView = (DataRowView)e.ListItem;
            e.Value = string.Format("{0}-> R$ {1}", drView.Row.ItemArray[1], string.Format("{0:0.00}", drView.Row.ItemArray[2]));
        }

        private void txtQtde_TextChanged(object sender, EventArgs e)
        {
            if (txtQtde.Text.Length == 0)
                txtQtde.Text = "1";
            try
            {
                if (int.Parse(txtQtde.Text) <= 0)
                    txtQtde.Text = "1";
            }
            catch (FormatException)
            {
                txtQtde.Text = "1";
            }
            catch (OverflowException)
            {
                MessageBox.Show("A Quantidade informada excedeu o limite", "Quantidade não Permitida:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtde.Text = "1";
            }
        }

        private void btnAdicionaItem_Click(object sender, EventArgs e)
        {
            DataRow newRow = this.dsADV_vendaVarejo.view_spListaItensDaVenda.NewRow();

            DataRowView rvProdutoSelecionado = (DataRowView)cmbProdutos.SelectedItem;
            try
            {
                newRow[0] = rvProdutoSelecionado[0];
                newRow[1] = rvProdutoSelecionado[1];
                newRow[2] = string.Format("{0:0.00}", rvProdutoSelecionado[2]);
                newRow[3] = txtQtde.Text;
                newRow[4] = string.Format("{0:0.00}", (int.Parse(txtQtde.Text) * (decimal)newRow[2]));

                dsADV_vendaVarejo.view_spListaItensDaVenda.Rows.Add(newRow);
                calculaSubTotaAndTotal();
            }
            catch (System.Data.ConstraintException)
            {
                MessageBox.Show("O Produto: " + newRow[1].ToString() + " Já foi adicionado.\n Você pode editar a quantidade direto no grid de itens!!!", "Produto já Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Erro Detalhe: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvItensDaVenda_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            antQtde = int.Parse(dgvItensDaVenda[e.ColumnIndex, e.RowIndex].Value.ToString());
        }

        private void dgvItensDaVenda_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                novaQtde = int.Parse(dgvItensDaVenda[e.ColumnIndex, e.RowIndex].Value.ToString());
                if (novaQtde <= 0)

                    throw new FormatException();
                dgvItensDaVenda[4, e.RowIndex].Value = string.Format("{0:0.00}", this.novaQtde * (decimal)dgvItensDaVenda[2, e.RowIndex].Value);
                calculaSubTotaAndTotal();

            }
            catch (FormatException)
            {
                MessageBox.Show("A Quantidade será retornada para o último valor válido", "Quantidade Inválisa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvItensDaVenda[e.ColumnIndex, e.RowIndex].Value = antQtde;
            }
        }

        private void dgvItensDaVenda_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowCount > 0)
            {
                btnSalvaVenda.Enabled = true;
            }
        }

        private void dgvItensDaVenda_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calculaSubTotaAndTotal();
            if (dgvItensDaVenda.RowCount == 0)
            {
                btnSalvaVenda.Enabled = false;
            }
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDesconto.Text.Length == 0)
                    throw new FormatException();

                txtTotal.Text = string.Format("{0:0.00}", decimal.Parse(txtSubTotal.Text) - decimal.Parse(txtDesconto.Text));


            }
            catch (FormatException)
            {
                txtDesconto.Text = "0,00";
                txtDesconto.SelectAll();
            }
        }

        private void btnSalvaVenda_Click(object sender, EventArgs e)
        {
            int idVenda, nLinhas = 0;

            try
            {
                if (txtSubTotal.Text != txtTotal.Text)
                {
                    frmAutorizacao autorizacao = new frmAutorizacao();

                    if (autorizacao.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    {
                        MessageBox.Show("Desconto não Autorizado", "Autorização Negada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                venda = new Controllers.Venda
                {
                    IdUsuario = Controllers.UsuarioLogado.usuario.Id,
                    IdCliente = (int)cmbClientes.SelectedValue,
                    IdFormaDePagamento = (int)cmbFormasDePagamento.SelectedValue,
                    DataVenda = DateTime.Now,
                    Total = decimal.Parse(txtTotal.Text)
                };

                idVenda = venda.IncluiVenda(venda);

                if (idVenda > 0)
                {
                    for (int i = 0; i < dgvItensDaVenda.RowCount; i++)
                    {
                        item = new Controllers.ItensDaVenda
                        {
                            IdVenda = idVenda,
                            IdProduto = int.Parse(dgvItensDaVenda.Rows[i].Cells[0].Value.ToString()),
                            Preco = (decimal)dgvItensDaVenda.Rows[i].Cells[2].Value,
                            Qtde = int.Parse(dgvItensDaVenda.Rows[i].Cells[3].Value.ToString()),
                            SubTotal = (decimal)dgvItensDaVenda.Rows[i].Cells[4].Value
                        };

                        if (item.IncluiItemDaVenda(item))
                            nLinhas++;
                    }

                    if (nLinhas == dgvItensDaVenda.RowCount)
                        MessageBox.Show("Venda Concluida com Sucesso !!!", "Venda Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Houverão erros na inclusão dos itens da Venda. ", " ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Houve Erro ao Incluir a venda !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dsADV_vendaVarejo.view_spListaItensDaVenda.Clear();
                btnSalvaVenda.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Erro Detalhe: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtDesconto.Text = "0,00";
            cmbProdutos.Text = string.Empty;
            cmbFormasDePagamento.Text = string.Empty;
            cmbProdutos.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNovaVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void cmbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Informações para auto Preenchimento de um ComboBox:
            // Em propriedades: -> AutoCompleteSource = ListItems.
            // Em Propriedades: -> AutoCompleteMode = Suggest.
            //
            // No Form_Load Inciciar com o ComboBox.Text = String.Empty;
            // Ou seja: VAZIO.
        }
    }
}