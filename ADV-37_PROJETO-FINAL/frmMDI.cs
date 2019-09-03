using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//-------------------------------------------------------------------------------------------

namespace ADV_37_PROJETO_FINAL
{
    public partial class frmMDI : Form
    {
        // Travar O Form
        //=================================================== 
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }
        // Fim do Trava Form
        //===================================================
        public frmMDI()
        {
            InitializeComponent();
            // Background (configuração de fundo) Form MDI
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = Color.FromArgb(237, 237, 237);
                    ctlMDI.BackgroundImage = Properties.Resources.logo;
                }
            }// Fim do Loop
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.frmUsuario frUsuario = new Views.frmUsuario();
            frUsuario.MdiParent = this;
            frUsuario.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.frmCliente frCliente = new Views.frmCliente();
            frCliente.MdiParent = this; // Seta que o Form e Parente do MDI
            frCliente.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.frmFornecedor fornecedor = new Views.frmFornecedor();
            fornecedor.MdiParent = this;
            fornecedor.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.frmProduto produto = new Views.frmProduto();
            produto.MdiParent = this;
            produto.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.frmEstoque estoque = new Views.frmEstoque();
            estoque.MdiParent = this;
            estoque.Show();
        }

        private void formaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.frmFormaDePagamento fpagamento = new Views.frmFormaDePagamento();
            fpagamento.MdiParent = this;
            fpagamento.Show();
        }

        private void tabelaDePreçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.frmTabelaDePrecos fnVenda = new Views.frmTabelaDePrecos();
            fnVenda.MdiParent = this;
            fnVenda.Show();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {

            Views.frmLogin frLogin = new Views.frmLogin();

            if (frLogin.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                Close();
                return;
            }
            toolStripStatusUsuarioLogado.Text = Controllers.UsuarioLogado.usuario.NomeCompleto;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //data atual
            this.toolStripStatusData.Text = DateTime.Now.ToShortDateString();

            //hora atual
            this.toolStripStatusHora.Text = DateTime.Now.ToLongTimeString();

        }

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.frmNovaVenda fnVenda = new Views.frmNovaVenda();
            fnVenda.MdiParent = this;
            fnVenda.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /**/
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.frmVendas vendas = new Views.frmVendas();
            vendas.MdiParent = this;
            vendas.Show();
        }

        private void tabelaDePreçosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reporting.frmTabelaDePrecos tPreco = new Reporting.frmTabelaDePrecos();
            tPreco.MdiParent = this;
            tPreco.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporting.frmProdutos relProdutos = new Reporting.frmProdutos();
            relProdutos.MdiParent = this;
            relProdutos.Show();
        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dialog.frmGeraRelatorioVendas fPrepare = new Dialog.frmGeraRelatorioVendas();
            fPrepare.MdiParent = this;
            fPrepare.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialog.Sobre sobre = new Dialog.Sobre();
            sobre.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void relatórioDeVendasTotalizadasNoPeríodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporting.Vtotal vendasTotal = new Reporting.Vtotal();
            vendasTotal.MdiParent = this;
            vendasTotal.Show();
        }
    }
}