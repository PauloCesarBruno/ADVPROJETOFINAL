using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//--------------------------------------------------------------------------------------------
using System.Runtime.InteropServices; // 1ª Passo para desabilitar o "X" do Fechar Formulario.
using System.Windows.Forms;
//-------------------------------------------------------------------------------------------

namespace ADV_37_PROJETO_FINAL.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Length == 0 || txtSenha.Text.Length == 0)
            {
                MessageBox.Show("Por Favor, informe o Canmpo Login e a Senha", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Text = string.Empty;
                txtSenha.Text = string.Empty;
                txtLogin.Focus();
                return;
            }

            Controllers.Usuario U = new Controllers.Usuario();

            Controllers.UsuarioLogado.usuario = U.GetLogin(txtLogin.Text, txtSenha.Text);


            if (Controllers.UsuarioLogado.usuario.Id == 0)
            {
                if (MessageBox.Show("Não foi possivel realizar o login com os dados informados \n\n Deseja tentar novamente ?", "Login incorreto", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
                {
                    DialogResult = System.Windows.Forms.DialogResult.No;
                    MessageBox.Show("Ok, Saindo... Se esqueceu seu Login e/ou Senha Fale com seu(ua) Gerente...", "LOGIN:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtLogin.Focus();
        }


        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            {
                FormCloseButtonDisabler // esta é a Classe Criada La embaixo e Chamada no Load para desabilitar o "X".
                    // 2º Passo Para desabilitar o "X".
               .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult perg = MessageBox.Show("Deseja Realmente sair do Sistema ?", "SAÍDA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (perg != DialogResult.Yes)
            {
                MessageBox.Show("OK, Mantendo !!!", "SAIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Ok, Até a Próxima !!!", "SAIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
        // ==========================================================================================================
        public class FormCloseButtonDisabler // 3º Paaso -  Classe Criada para desabilitar o "X" de fechar formulário.
        {
            private const int MF_BYPOSITION = 0x400;
            private const int MF_REMOVE = 0x1000;
            private const int MF_DISABLED = 0x2;
            [DllImport("user32.dll", EntryPoint = "DrawMenuBar")]
            static extern Int32 DrawMenuBar(
            Int32 hWnd
            );
            [DllImport("user32.dll", EntryPoint = "GetMenuItemCount")]
            static extern Int32 GetMenuItemCount(
            Int32 hMenu
            );
            [DllImport("user32.dll", EntryPoint = "GetSystemMenu")]
            static extern Int32 GetSystemMenu(
            Int32 hWnd,
            bool bRevert
            );
            [DllImport("user32.dll", EntryPoint = "RemoveMenu")]
            static extern Int32 RemoveMenu(
            Int32 hMenu,
            Int32 nPosition,
            Int32 wFlags
            );
            public static void DisableCloseButton(int hWnd)
            {
                int hMenu;
                int menuItemCount;
                hMenu = GetSystemMenu(hWnd, false);
                menuItemCount = GetMenuItemCount(hMenu);
                RemoveMenu(hMenu, menuItemCount - 1, MF_DISABLED | MF_BYPOSITION);
                RemoveMenu(hMenu, menuItemCount - 2, MF_DISABLED | MF_BYPOSITION);
                DrawMenuBar(hWnd);
            }
        }
        // Fim da Classe (3º Passo) para desabilitar o "X" do fchar Form.
        // Fim da dos 3 Passos para desabilitar o "X" do Form.
    }
}