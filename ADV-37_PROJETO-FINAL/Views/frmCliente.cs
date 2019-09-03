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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void Deleta()
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
                    SqlCommand cmd = new SqlCommand("DELETE FROM Cliente WHERE Id= '" + txtId.Text + "'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvClientes.DataSource = (dt);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Detalhe -->> " + ex);
            }
        }

        private Controllers.Cliente cliente = new Controllers.Cliente();


        private void frmCliente_Load(object sender, EventArgs e)
        {
            try
            {
                // Lista os Clientes Já Cadastrados
                cliente.ListaClientes(dsADV_vendaVarejo, txtNome.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Erro Detalhe: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Reset()
        {
            // Zera o Id do objeto Cliente
            cliente.Id = 0;
            // Reseta os valores
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            dtpDataNascimento.Value = DateTime.Now;
            cmbDDD.Text = string.Empty;
            mskTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            // Desabilita o Botão Cancelar
            btnCancelar.Enabled = false;

            // Volta o Texto do Botão Salvar para Inclui
            btnSalvar.Text = "Inclui";
            cliente.ListaClientes(dsADV_vendaVarejo, txtNome.Text); //Dá Tipo um Refreach no DGV
            txtNome.Focus();
        }
        private bool camposPreenchidos()
        {
            // String Vazia
            string msg = string.Empty;

            if (txtNome.Text.Length == 0) // Se Tamanho ... (Length) = 0 
                msg += "Informe o Nome";
            if (cmbDDD.Text.Length == 0)
                msg += "\nInforme o DDD";
            if (mskTelefone.Text.Length == 0)
                msg += "\nInforme o Número do Telefone";
            if (txtEmail.Text.Length == 0)
                msg += "\nInforme o E-Mail";
            if (msg != string.Empty)
            {
                MessageBox.Show("Campos Obrigatórios!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se Usuário Clicou na Linha
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Alimenta o Id do objeto
                    cliente.Id = (int)dgvClientes[0, e.RowIndex].Value;

                    // Alimenta os Controles do Formulário
                    txtId.Text = dgvClientes[0, e.RowIndex].Value.ToString();
                    txtNome.Text = dgvClientes[1, e.RowIndex].Value.ToString();
                    dtpDataNascimento.Value = DateTime.Parse(dgvClientes[2, e.RowIndex].Value.ToString());
                    txtEmail.Text = dgvClientes[3, e.RowIndex].Value.ToString();
                    cmbDDD.Text = dgvClientes[4, e.RowIndex].Value.ToString();
                    mskTelefone.Text = dgvClientes[5, e.RowIndex].Value.ToString();

                    // Habilita o Botão Canceloar
                    btnCancelar.Enabled = true;
                    // Altera o Texto do Botão Salvar
                    btnSalvar.Text = "Altera";
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!this.camposPreenchidos())
                return;

            // Se Continuar
            bool result;
            try
            {
                cliente.NomeCompleto = txtNome.Text;
                cliente.DataNascimento = dtpDataNascimento.Value;
                cliente.DDD = int.Parse(cmbDDD.Text);
                cliente.Telefone = int.Parse(mskTelefone.Text);
                cliente.Email = txtEmail.Text;

                // Verifica Ação
                if (cliente.Id == 0)
                {
                    // Insert
                    result = cliente.IncluiCliente(cliente);
                    Reset();
                }
                else
                {
                    // Update
                    result = cliente.AlteraCliente(cliente);
                    Reset();
                }

                // Caso haja Alteração no Banco de Dados atualiza o Grid
                if (result)
                    cliente.ListaClientes(dsADV_vendaVarejo, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Detalhe: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Reset();
        }



        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCliente_KeyDown(object sender, KeyEventArgs e)
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
                Deleta();
                MessageBox.Show("Cliente Exluido(a) com Êxito...", "AVISO:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("OK, Mantendo Registro", "AVISO:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }


        private void btnBuscaNome_Click(object sender, EventArgs e)
        {
            // Filtra por Nome
            btnCancelar.Enabled = true;
            try
            {
                cliente.ListaClientes(dsADV_vendaVarejo, txtNome.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Erro Detalhe: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
        }
    }
}
