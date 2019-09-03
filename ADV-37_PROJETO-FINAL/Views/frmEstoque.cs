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
    public partial class frmEstoque : Form
    {
        // Cria Nova Instância dfa Classe Produto
        private Controllers.Produto produto = new Controllers.Produto();

        // Atributo do Tipo ENUM Estoque, Iniciado como entrada
        private Controllers.Estoque acao = Controllers.Estoque.Entrada;

        public frmEstoque()
        {
            InitializeComponent();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
          try
            {
                // Lista todos os produtos cadastrados
                produto.ListaProdutos(dsADV_vendaVarejo, "");

                //  Lista os produtos em estoque
                produto.ListaProdutosEmEstoque(dsADV_vendaVarejo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Erro Detalhe: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método Usado pelos dois RadioButtons (rdbEntra, rdbSaida)
        private void rdbsMovimentacaoCheckedChanged(object sender, EventArgs e)
        {
            // Define Ação
            if (rdbSaida.Checked)
            {
                //Saida
                acao = Controllers.Estoque.Saida;
            }
            else
            {
                // Entrada
                acao = Controllers.Estoque.Entrada;
            }
        }

        private void dgvEstoque_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Toda vez que o DGV sofrer uma colagem de dados, Faz um Loop em todas as Linhas
            try
            {
                for (int idx = 0; idx < dgvEstoque.RowCount; idx++)
                {
                    /* Se a quantidade for menor ou igual à quantidade mínima
                     * pinta o fundo da linha com a cor vermelha*/
                    if (int.Parse(dgvEstoque[2, idx].Value.ToString()) >= int.Parse(dgvEstoque[3, idx].Value.ToString()))
                    {
                        dgvEstoque.Rows[idx].DefaultCellStyle.BackColor = Color.FromArgb(205, 85, 85);
                    }
                    else
                    {
                        dgvEstoque.Rows[idx].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
            catch
            {
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            try
            {
                // Pega os Valores dos controles
                int idProduto = int.Parse(cmbProdutos.SelectedValue.ToString());
                int qtde = int.Parse(nupQtde.Value.ToString());

                // Se Acão for de SAIDA, passa o valor para Negativo
                if (acao == Controllers.Estoque.Saida)
                {
                    qtde = -(qtde);
                }

                // Tenta Incluir ou Atualizar o Estoque
                if (produto.IncluiProdutoEmEstoque(idProduto, qtde))
                {
                    // Lista os Produtos em estoque
                    produto.ListaProdutosEmEstoque(dsADV_vendaVarejo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Erro Detalhe: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            nupQtde.Value = 1;
            cmbProdutos.Text = string.Empty;
            cmbProdutos.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}

