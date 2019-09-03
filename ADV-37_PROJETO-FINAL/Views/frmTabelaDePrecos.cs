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
    public partial class frmTabelaDePrecos : Form
    {
        //atributo que controla a ação
        Controllers.Acao acao;
        //nova instancia da classe produto
        private Controllers.Produto produto = new Controllers.Produto();
        //cria uma nova instancia da classe Tabela preco
        private Controllers.TabelaDePreco tpreco = new Controllers.TabelaDePreco();


        public frmTabelaDePrecos()
        {
            InitializeComponent();
        }

        private void frmTabelaDePrecos_Load(object sender, EventArgs e)
        {
            try
            {
                this.produto.ListaProdutosEmEstoque(dsADV_vendaVarejo);

                this.tpreco.ListaPrecos(dsADV_vendaVarejo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO");
            }

        }

        private void reset()
        {
            this.acao = Controllers.Acao.inclui;

            txtPreco.Text = string.Empty;

            this.btnSalvar.Text = "Inclui";

            this.btnCancelar.Enabled = false;

        }

        private void dgvPrecos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtPreco.Text = string.Format("{0:0.00}", dgvPrecos[2, e.RowIndex].Value);
                this.acao = Controllers.Acao.altera;

                this.btnSalvar.Text = "Altera";

                this.btnCancelar.Enabled = true;


            }
        }

        private void dgvPrecos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvPrecos.RowCount; i++)
            {
                dgvPrecos.Rows[i].Cells[2].Value = string.Format("{0:0.00}", dgvPrecos.Rows[i].Cells[2].Value);
                //ou
                //dgvPrecos[i,2].Value =
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.reset();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPreco.Text.Length == 0)
                {
                    MessageBox.Show("Insira um preço");
                    txtPreco.Focus();
                    return;

                }

                this.tpreco.IdProduto = int.Parse(cmbProdutos.SelectedValue.ToString());
                this.tpreco.Preco = decimal.Parse(txtPreco.Text);

                bool result;

                if (this.acao == Controllers.Acao.inclui)
                {
                    result = this.tpreco.IncluiPreco(tpreco);

                }

                else
                {

                    result = this.tpreco.alteraPreco(tpreco);
                }

                if (result)
                {
                    this.tpreco.ListaPrecos(dsADV_vendaVarejo);
                    this.reset();
                }
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                //violacao de chave primaria
                if (sqlEx.Number == 2627)
                {
                    MessageBox.Show("O produto" + cmbProdutos.Text + "já existe na tabela de preços\n para  altera-lo selecione-o na tabela abaixo", "Produto Já Incluso");

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show("ERRo : " + Ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTabelaDePrecos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}