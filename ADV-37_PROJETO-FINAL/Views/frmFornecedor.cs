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
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }
        private void DeletaFornec()
        {
            try
            {
                {
                    Conexao_SqlServer.BuscaExcluiSql obj = new Conexao_SqlServer.BuscaExcluiSql();
                    SqlConnection conn = new SqlConnection(obj.sql);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Fornecedor WHERE Id= '" + txtCodigo.Text + "'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvFornecedores.DataSource = (dt);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Detalhe -->> " + ex);
            }
        }
        private void BuscaNomeFornec()
        {
            try
            {
                {
                    Conexao_SqlServer.BuscaExcluiSql obj = new Conexao_SqlServer.BuscaExcluiSql();
                    SqlConnection conn = new SqlConnection(obj.sql);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT id,razaoSocial,nomeFantasia,contato,ddd,telefone1,telefone2 FROM Fornecedor WHERE razaoSocial LIKE '%" + txtBuscaNome.Text + "%'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvFornecedores.DataSource = (dt);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Detalhe -->> " + ex);
            }
        }


        private Controllers.Fornecedor fornecedor = new Controllers.Fornecedor();

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            try
            {
                // Lista os Fornecedores Cadastrados
                fornecedor.ListaFornecedores(dsADV_vendaVarejo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Erro Detalhe: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool camposPreenchidos()
        {
            // String Vazia
            string msg = string.Empty;

            if (txtRsocial.Text.Length == 0) // Se Tamanho ... (Length) = 0 
                msg += "Informe a Razão Social";
            if (txtNfantasia.Text.Length == 0)
                msg += "\nInforme o Nome de Fantasia";
            if (txtContato.Text.Length == 0)
                msg += "\nInforme o Contato";
            if (cmbDDD.Text.Length == 0)
                msg += "\nInforme o DDD";
            if (mskTel1.Text.Length == 0)
                msg += "\nInforme o Telefone 01";
            if (mskTel2.Text.Length == 0)
                msg += "\nInforme oTelefone 02";

            if (msg != string.Empty)
            {
                MessageBox.Show("Campos Obrigatórios!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void reset()
        {
            // Zera o Id 
            fornecedor.Id = 0;
            // Reseta os valores
            txtCodigo.Text = string.Empty;
            txtRsocial.Text = string.Empty;
            txtNfantasia.Text = string.Empty;
            txtContato.Text = string.Empty;
            cmbDDD.Text = string.Empty;
            mskTel1.Text = string.Empty;
            mskTel2.Text = string.Empty;
            btnExclui.Enabled = false;

            // Volta os Botões para o estado Default
            btnCancelar.Enabled = false;
            btnSalvar.Text = "Inclui";
            txtRsocial.Focus();
        }

        private void dgvFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnExclui.Enabled = true;
            // Se o Usuário Clicou na Linha do Grid
            if (e.RowIndex >= 0)
            {
                // Alimenta o Id do objeto
                fornecedor.Id = (int)dgvFornecedores[0, e.RowIndex].Value;
                txtCodigo.Text = dgvFornecedores[0, e.RowIndex].Value.ToString();
                txtRsocial.Text = dgvFornecedores[1, e.RowIndex].Value.ToString();
                txtNfantasia.Text = dgvFornecedores[2, e.RowIndex].Value.ToString();
                txtContato.Text = dgvFornecedores[3, e.RowIndex].Value.ToString();
                cmbDDD.Text = dgvFornecedores[4, e.RowIndex].Value.ToString();
                mskTel1.Text = dgvFornecedores[5, e.RowIndex].Value.ToString();
                mskTel2.Text = dgvFornecedores[6, e.RowIndex].Value.ToString();

                // Habilita o Botão Cancelar
                btnCancelar.Enabled = true;
                // Altera o texto do botão Salvar
                btnSalvar.Text = "Altera";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool result;

            // Se os Campos não estiverem preenchidos

            if (!this.camposPreenchidos())
                return;

            // Alimenta o objeto com os dados do controle do formulário
            fornecedor.RazaoSocial = txtRsocial.Text;
            fornecedor.NomeFantasia = txtNfantasia.Text;
            fornecedor.Contato = txtContato.Text;
            fornecedor.DDD = int.Parse(cmbDDD.Text);
            fornecedor.Telefone1 = Convert.ToInt32(mskTel1.Text);
            fornecedor.Telefone2 = mskTel2.Text.Length > 0 ? Convert.ToInt32(mskTel2.Text) : 0; // Operador Ternário

            // Verifica Ação
            if (fornecedor.Id == 0)
                result = fornecedor.IncluiFornecedor(fornecedor);
            else
                result = fornecedor.AlteraFornecedor(fornecedor);

            // Se a Exec~ção retornou TRUE então lista os fornecedores
            // e da um Reset nos controles
            if (result)
            {
                fornecedor.ListaFornecedores(dsADV_vendaVarejo);
                reset();
                txtRsocial.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Executa Método Reset 
            reset();
            try
            {
                // Lista os Fornecedores Cadastrados
                fornecedor.ListaFornecedores(dsADV_vendaVarejo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Erro Detalhe: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtRsocial.Focus();
            txtBuscaNome.Text = string.Empty;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFornecedor_KeyDown(object sender, KeyEventArgs e)
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
                try
                {
                    // Lista os Fornecedores Cadastrados
                    fornecedor.ListaFornecedores(dsADV_vendaVarejo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Erro Detalhe: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reset();
                return;
            }
            DialogResult pergunta = MessageBox.Show("Deseja Realmente excluir este Registro Sim ou não ?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pergunta == DialogResult.Yes)
            {
                DeletaFornec();
                MessageBox.Show("Fornecedor Exluido(a) com Êxito...", "AVISO:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("OK, Mantendo Registro", "AVISO:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    // Lista os Fornecedores Cadastrados
                    fornecedor.ListaFornecedores(dsADV_vendaVarejo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Erro Detalhe: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reset();
                return;
            }
        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            BuscaNomeFornec();
        }
    }
}