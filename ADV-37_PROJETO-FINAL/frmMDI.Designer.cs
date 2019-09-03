namespace ADV_37_PROJETO_FINAL
{
    partial class frmMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formaDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaDePreçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaDePreçosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeVendasTotalizadasNoPeríodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusUsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripInfo = new System.Windows.Forms.StatusStrip();
            this.menuStripPrincipal.SuspendLayout();
            this.statusStripInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.BackColor = System.Drawing.Color.Teal;
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.menuStripPrincipal.Size = new System.Drawing.Size(805, 24);
            this.menuStripPrincipal.TabIndex = 3;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.formaDePagamentoToolStripMenuItem,
            this.tabelaDePreçosToolStripMenuItem});
            this.arquivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.arquivoToolStripMenuItem.Text = "&Cadastro";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Image = global::ADV_37_PROJETO_FINAL.Properties.Resources.user;
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.usuárioToolStripMenuItem.Text = "&Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::ADV_37_PROJETO_FINAL.Properties.Resources.group;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.clientesToolStripMenuItem.Text = "&Cliente";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Image = global::ADV_37_PROJETO_FINAL.Properties.Resources.user_suit;
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.fornecedorToolStripMenuItem.Text = "&Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Image = global::ADV_37_PROJETO_FINAL.Properties.Resources.cart;
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.produtoToolStripMenuItem.Text = "&Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Image = global::ADV_37_PROJETO_FINAL.Properties.Resources.table_refresh;
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.estoqueToolStripMenuItem.Text = "&Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // formaDePagamentoToolStripMenuItem
            // 
            this.formaDePagamentoToolStripMenuItem.Image = global::ADV_37_PROJETO_FINAL.Properties.Resources.money;
            this.formaDePagamentoToolStripMenuItem.Name = "formaDePagamentoToolStripMenuItem";
            this.formaDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.formaDePagamentoToolStripMenuItem.Text = "F&orma de pagamento";
            this.formaDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.formaDePagamentoToolStripMenuItem_Click);
            // 
            // tabelaDePreçosToolStripMenuItem
            // 
            this.tabelaDePreçosToolStripMenuItem.Image = global::ADV_37_PROJETO_FINAL.Properties.Resources.table;
            this.tabelaDePreçosToolStripMenuItem.Name = "tabelaDePreçosToolStripMenuItem";
            this.tabelaDePreçosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.tabelaDePreçosToolStripMenuItem.Text = "&Tabela de preços";
            this.tabelaDePreçosToolStripMenuItem.Click += new System.EventHandler(this.tabelaDePreçosToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelaDePreçosToolStripMenuItem1,
            this.produtosToolStripMenuItem,
            this.vendasToolStripMenuItem1,
            this.relatórioDeVendasTotalizadasNoPeríodoToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.relatóriosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.relatóriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // tabelaDePreçosToolStripMenuItem1
            // 
            this.tabelaDePreçosToolStripMenuItem1.Image = global::ADV_37_PROJETO_FINAL.Properties.Resources.report;
            this.tabelaDePreçosToolStripMenuItem1.Name = "tabelaDePreçosToolStripMenuItem1";
            this.tabelaDePreçosToolStripMenuItem1.Size = new System.Drawing.Size(310, 22);
            this.tabelaDePreçosToolStripMenuItem1.Text = "&Tabela de preços";
            this.tabelaDePreçosToolStripMenuItem1.Click += new System.EventHandler(this.tabelaDePreçosToolStripMenuItem1_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Image = global::ADV_37_PROJETO_FINAL.Properties.Resources.report;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(310, 22);
            this.produtosToolStripMenuItem.Text = "&Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem1
            // 
            this.vendasToolStripMenuItem1.Image = global::ADV_37_PROJETO_FINAL.Properties.Resources.report;
            this.vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            this.vendasToolStripMenuItem1.Size = new System.Drawing.Size(310, 22);
            this.vendasToolStripMenuItem1.Text = "&Vendas Simplificado por Data";
            this.vendasToolStripMenuItem1.Click += new System.EventHandler(this.vendasToolStripMenuItem1_Click);
            // 
            // relatórioDeVendasTotalizadasNoPeríodoToolStripMenuItem
            // 
            this.relatórioDeVendasTotalizadasNoPeríodoToolStripMenuItem.Image = global::ADV_37_PROJETO_FINAL.Properties.Resources.report;
            this.relatórioDeVendasTotalizadasNoPeríodoToolStripMenuItem.Name = "relatórioDeVendasTotalizadasNoPeríodoToolStripMenuItem";
            this.relatórioDeVendasTotalizadasNoPeríodoToolStripMenuItem.Size = new System.Drawing.Size(310, 22);
            this.relatórioDeVendasTotalizadasNoPeríodoToolStripMenuItem.Text = "&Relatório de Vendas Totalizadas no Período";
            this.relatórioDeVendasTotalizadasNoPeríodoToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeVendasTotalizadasNoPeríodoToolStripMenuItem_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaVendaToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.vendaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.vendaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.vendaToolStripMenuItem.Text = "&Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // novaVendaToolStripMenuItem
            // 
            this.novaVendaToolStripMenuItem.Image = global::ADV_37_PROJETO_FINAL.Properties.Resources.cart_add;
            this.novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            this.novaVendaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.novaVendaToolStripMenuItem.Text = "&Nova venda";
            this.novaVendaToolStripMenuItem.Click += new System.EventHandler(this.novaVendaToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Image = global::ADV_37_PROJETO_FINAL.Properties.Resources.money_dollar;
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.vendasToolStripMenuItem.Text = "&Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.ajudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ajudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Image = global::ADV_37_PROJETO_FINAL.Properties.Resources.lightbulb;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.sobreToolStripMenuItem.Text = "S&obre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::ADV_37_PROJETO_FINAL.Properties.Resources.cancel;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(36, 15);
            this.toolStripStatusLabel1.Text = "Data:";
            // 
            // toolStripStatusData
            // 
            this.toolStripStatusData.AutoSize = false;
            this.toolStripStatusData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusData.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusData.Name = "toolStripStatusData";
            this.toolStripStatusData.Size = new System.Drawing.Size(200, 15);
            this.toolStripStatusData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(37, 15);
            this.toolStripStatusLabel2.Text = "Hora:";
            // 
            // toolStripStatusHora
            // 
            this.toolStripStatusHora.AutoSize = false;
            this.toolStripStatusHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusHora.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusHora.Name = "toolStripStatusHora";
            this.toolStripStatusHora.Size = new System.Drawing.Size(200, 15);
            this.toolStripStatusHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(92, 15);
            this.toolStripStatusLabel3.Text = "Usuário logado:";
            // 
            // toolStripStatusUsuarioLogado
            // 
            this.toolStripStatusUsuarioLogado.AutoSize = false;
            this.toolStripStatusUsuarioLogado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusUsuarioLogado.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusUsuarioLogado.Name = "toolStripStatusUsuarioLogado";
            this.toolStripStatusUsuarioLogado.Size = new System.Drawing.Size(200, 15);
            this.toolStripStatusUsuarioLogado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStripInfo
            // 
            this.statusStripInfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.statusStripInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusData,
            this.toolStripStatusLabel2,
            this.toolStripStatusHora,
            this.toolStripStatusLabel3,
            this.toolStripStatusUsuarioLogado});
            this.statusStripInfo.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStripInfo.Location = new System.Drawing.Point(0, 522);
            this.statusStripInfo.Name = "statusStripInfo";
            this.statusStripInfo.Size = new System.Drawing.Size(805, 20);
            this.statusStripInfo.TabIndex = 2;
            this.statusStripInfo.Text = "statusStrip1";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(805, 542);
            this.Controls.Add(this.statusStripInfo);
            this.Controls.Add(this.menuStripPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripPrincipal;
            this.MaximizeBox = false;
            this.Name = "frmMDI";
            this.Text = "Sistema de Venas no Varejo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.statusStripInfo.ResumeLayout(false);
            this.statusStripInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formaDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaDePreçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem tabelaDePreçosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusUsuarioLogado;
        private System.Windows.Forms.StatusStrip statusStripInfo;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeVendasTotalizadasNoPeríodoToolStripMenuItem;
    }
}

