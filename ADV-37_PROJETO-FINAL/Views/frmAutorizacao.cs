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
    public partial class frmAutorizacao : Form
    {
        public frmAutorizacao()
        {
            InitializeComponent();
        }
        private Controllers.Usuario usuario;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //cria uma nova instancia
                this.usuario = new Controllers.Usuario();

                //faz o login e verifica se é administrador
                this.usuario = this.usuario.GetLogin(txtLogin.Text, txtSenha.Text);
                if (usuario.Adm)
                {
                    //se ok para o formulario que abriu
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }

                else
                {
                    lblAviso.Visible = true;
                    txtLogin.Text = string.Empty;
                    txtSenha.Text = string.Empty;
                    btnSair.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAutorizacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}

