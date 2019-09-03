using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//
using System.Data.SqlClient;

namespace ADV_37_PROJETO_FINAL.Views
{
    public partial class frmFormaDePagamento : Form
    {
        Controllers.FormaDePagamento fpagamento = new Controllers.FormaDePagamento();
        public frmFormaDePagamento()
        {
            InitializeComponent();
        }
        private void DeletaForma()
        {
            try
            {
                {
                    // Instancio a Classe StrCon Onde esta a String de Conexão:
                    Conexao_SqlServer.BuscaExcluiSql obj = new Conexao_SqlServer.BuscaExcluiSql();
                    // Cria um Novo objeto SqlConnection object usando a string de conexão 
                    SqlConnection conn = new SqlConnection(obj.sql);
                    // abre Conexão
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM FormaDePagamento WHERE Id= '" + fpagamento.Id  + "'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    lstbFormasDePagamentos.DataSource = (dt);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Detalhe -->> " + ex);
            }
        }
        private void lstbFormasDePagamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbFormasDePagamentos.SelectedIndex >= 0)
            {
                fpagamento.Id = (int)lstbFormasDePagamentos.SelectedValue;
                txtDescricao.Text = lstbFormasDePagamentos.Text;
                btnCancelar.Enabled = true;
                btnExclui.Enabled = true;
                btnSalvar.Text = "Altera";
            }
        }

        private void reset()
        {
            fpagamento.Id = 0;
            txtDescricao.Text = string.Empty;
            btnSalvar.Text = "Inclui";
            btnCancelar.Enabled = false;
            btnExclui.Enabled = false;
            fpagamento.ListaFormaDePagamentos(dsADV_vendaVarejo);
            txtDescricao.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text.Length == 0)
            {
                MessageBox.Show("Preencha a descrição da forma de pagamento", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
               
            }
            
            
            fpagamento.Descricao = txtDescricao.Text;

            bool result;

            if (fpagamento.Id == 0)
            {
                result = fpagamento.IncluiFormaDePagamento(fpagamento);
            }
            else
            {
                result = fpagamento.AlteraFormaDePagamento(fpagamento);
            }

            if (result)
            {
                reset();
            }
        }

        private void frmFormaDePagamento_Load(object sender, EventArgs e)
        {
            fpagamento.ListaFormaDePagamentos(dsADV_vendaVarejo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFormaDePagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            frmAutorizacao autorizacao = new frmAutorizacao();

            if (autorizacao.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Exclusão não Autorizado, somente digitando uma senha de Administrador poderá concluir esta operação ...!!!", "Autorização Negada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult perg = MessageBox.Show("Deseja Realmente excluir este Registro Sim ou não ?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (perg == DialogResult.Yes)
            {
                DeletaForma();
                MessageBox.Show("Registro Exluido com Êxito...", "AVISO:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("OK, Mantendo Registro", "AVISO:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
