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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
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
                    SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE Id= '" + usuario.Id + "'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUsuarios.DataSource = (dt);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Detalhe -->> " + ex);
            }
        }

        // Criando nova Instância da Classe
        private Controllers.Usuario usuario = new Controllers.Usuario();

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                // Lista os Usuários Cadastrados
                this.usuario.ListaUsuarios(dsADV_vendaVarejo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalhe do Erro:" + ex, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Reset()
        {
            // Zera o Id do objeto Usuario
            this.usuario.Id = 0;

            // Limpa os Controles
            txtNome.Text = string.Empty;
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
            chkADM.Checked = false;

            // Volta o Nome do Botão Inclui
            btnSalvar.Text = "Inclui";
            // Desabilita o Botão Cancelar
            btnCancela.Enabled = false;
            txtNome.Focus();
        }

        private bool CamposPreenchidos()
        {
            // Msg Vazia
            string msg = string.Empty;

            foreach (object item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    if (txt.Text == string.Empty)
                    {
                        switch (txt.Name)
                        {
                            case "txtNome":
                                msg += "\nPreencha o Campo: Nome";
                                break;
                            case "txtLogin":
                                msg += "\nPreencha o Campo: Login";
                                break;
                            case "txtSenha":
                                msg += "\nPreencha o Campo: Senha";
                                break;
                        }
                    }
                }
            }
            if (msg != string.Empty)
            {
                MessageBox.Show(msg, " Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se Usuario Clicou na Linha
            if (e.RowIndex >= 0)
            {
                // Pega dados da linha
                usuario.Id = (int)dgvUsuarios[0, e.RowIndex].Value;
                txtNome.Text = dgvUsuarios[1, e.RowIndex].Value.ToString();
                txtLogin.Text = dgvUsuarios[2, e.RowIndex].Value.ToString();
                txtSenha.Text = dgvUsuarios[3, e.RowIndex].Value.ToString();
                chkADM.Checked = (bool)dgvUsuarios[4, e.RowIndex].Value;

                // Muda o Nome do Botão para "Altera"
                btnSalvar.Text = "Altera";
                // Habilita Botão Cancela
                btnCancela.Enabled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            frmAutorizacao autorizacao = new frmAutorizacao();

            if (autorizacao.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Vc. Não Forneceu a SENHA de administrador (Mesmo no caso de já ser um Administrador, o fornecimento da Senha é Obrigatorio), ou fechou a caixa de diálogo clicando no(x)... Alteração / Inclusão Não Autorizada", "Autorização Negada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Text = string.Empty;
                txtSenha.Text = string.Empty;
                btnSair.Focus();
                return;
            }
            // Caso os campos não estiverem preenchidos
            if (!this.CamposPreenchidos())

                return;
            bool result;
            try
            {
                // Preenche o objeto Usuário
                usuario.NomeCompleto = txtNome.Text;
                usuario.Login = txtLogin.Text;
                usuario.Senha = txtSenha.Text;
                usuario.Adm = chkADM.Checked;

                // Verifica as ações Insert e Update
                if (usuario.Id == 0)
                    result = usuario.IncluiUsuario(usuario);
                else
                    result = usuario.AlteraUsuario(usuario);
                if (result)
                {
                    // Atualiza os dados no Grid
                    usuario.ListaUsuarios(dsADV_vendaVarejo);

                    // Volta ao Estado Padrão
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalhe do Erro:" + ex, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            // Volta ao Resultado Padrão
            Reset();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAutorizacao autorizacao = new frmAutorizacao();

            if (autorizacao.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Operação não Autorizado, somente Digitando uma senha de Administrador poderá concluir esta operação ...!!!", "Autorização Negada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult perg = MessageBox.Show("Deseja Realmente excluir este Registro Sim ou não ?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (perg == DialogResult.Yes)
            {
                Deleta();
                MessageBox.Show("Usuário(a) Exluido(a) co Êxito...", "AVISO:", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        
    
