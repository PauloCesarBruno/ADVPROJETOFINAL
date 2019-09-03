namespace ADV_37_PROJETO_FINAL.Views
{
    partial class frmNovaVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovaVenda));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.viewspListaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsADV_vendaVarejo = new ADV_37_PROJETO_FINAL.dsADV_vendaVarejo();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbFormasDePagamento = new System.Windows.Forms.ComboBox();
            this.viewspListaFormaDePagamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvItensDaVenda = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewspListaItensDaVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.cmbProdutos = new System.Windows.Forms.ComboBox();
            this.viewspListaTabelaDePrecosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdicionaItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnSalvaVenda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblLembrente_INVISIVEL = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewspListaClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsADV_vendaVarejo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewspListaFormaDePagamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensDaVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewspListaItensDaVendaBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewspListaTabelaDePrecosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbClientes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // cmbClientes
            // 
            this.cmbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClientes.DataSource = this.viewspListaClientesBindingSource;
            this.cmbClientes.DisplayMember = "nomeCompleto";
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(9, 19);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(403, 21);
            this.cmbClientes.TabIndex = 0;
            this.cmbClientes.ValueMember = "id";
            // 
            // viewspListaClientesBindingSource
            // 
            this.viewspListaClientesBindingSource.DataMember = "view_spListaClientes";
            this.viewspListaClientesBindingSource.DataSource = this.dsADV_vendaVarejo;
            // 
            // dsADV_vendaVarejo
            // 
            this.dsADV_vendaVarejo.DataSetName = "dsADV_vendaVarejo";
            this.dsADV_vendaVarejo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbFormasDePagamento);
            this.groupBox2.Location = new System.Drawing.Point(539, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forma de pagamento";
            // 
            // cmbFormasDePagamento
            // 
            this.cmbFormasDePagamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFormasDePagamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFormasDePagamento.DataSource = this.viewspListaFormaDePagamentosBindingSource;
            this.cmbFormasDePagamento.DisplayMember = "descricao";
            this.cmbFormasDePagamento.FormattingEnabled = true;
            this.cmbFormasDePagamento.Location = new System.Drawing.Point(12, 20);
            this.cmbFormasDePagamento.Name = "cmbFormasDePagamento";
            this.cmbFormasDePagamento.Size = new System.Drawing.Size(253, 21);
            this.cmbFormasDePagamento.TabIndex = 0;
            this.cmbFormasDePagamento.ValueMember = "id";
            // 
            // viewspListaFormaDePagamentosBindingSource
            // 
            this.viewspListaFormaDePagamentosBindingSource.DataMember = "view_spListaFormaDePagamentos";
            this.viewspListaFormaDePagamentosBindingSource.DataSource = this.dsADV_vendaVarejo;
            // 
            // dgvItensDaVenda
            // 
            this.dgvItensDaVenda.AllowUserToAddRows = false;
            this.dgvItensDaVenda.AutoGenerateColumns = false;
            this.dgvItensDaVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensDaVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.qtdDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn});
            this.dgvItensDaVenda.DataSource = this.viewspListaItensDaVendaBindingSource;
            this.dgvItensDaVenda.Location = new System.Drawing.Point(12, 143);
            this.dgvItensDaVenda.Name = "dgvItensDaVenda";
            this.dgvItensDaVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensDaVenda.Size = new System.Drawing.Size(804, 393);
            this.dgvItensDaVenda.TabIndex = 2;
            this.dgvItensDaVenda.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvItensDaVenda_CellBeginEdit);
            this.dgvItensDaVenda.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItensDaVenda_CellEndEdit);
            this.dgvItensDaVenda.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvItensDaVenda_RowsAdded);
            this.dgvItensDaVenda.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvItensDaVenda_RowsRemoved);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id Produto";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição do Produto";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.Width = 345;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.precoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preço Unitário";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // qtdDataGridViewTextBoxColumn
            // 
            this.qtdDataGridViewTextBoxColumn.DataPropertyName = "qtd";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.qtdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.qtdDataGridViewTextBoxColumn.HeaderText = "Qtde.";
            this.qtdDataGridViewTextBoxColumn.Name = "qtdDataGridViewTextBoxColumn";
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "subTotal";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.subTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            // 
            // viewspListaItensDaVendaBindingSource
            // 
            this.viewspListaItensDaVendaBindingSource.DataMember = "view_spListaItensDaVenda";
            this.viewspListaItensDaVendaBindingSource.DataSource = this.dsADV_vendaVarejo;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblVendedor);
            this.groupBox3.Location = new System.Drawing.Point(539, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 64);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vendedor";
            // 
            // lblVendedor
            // 
            this.lblVendedor.BackColor = System.Drawing.Color.White;
            this.lblVendedor.Location = new System.Drawing.Point(12, 25);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(253, 23);
            this.lblVendedor.TabIndex = 0;
            this.lblVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblLembrente_INVISIVEL);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtQtde);
            this.groupBox4.Controls.Add(this.cmbProdutos);
            this.groupBox4.Location = new System.Drawing.Point(12, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(423, 64);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantidade";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(360, 26);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(56, 20);
            this.txtQtde.TabIndex = 1;
            this.txtQtde.Text = "1";
            this.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtde.TextChanged += new System.EventHandler(this.txtQtde_TextChanged);
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProdutos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProdutos.DataSource = this.viewspListaTabelaDePrecosBindingSource;
            this.cmbProdutos.DisplayMember = "descricao";
            this.cmbProdutos.FormattingEnabled = true;
            this.cmbProdutos.Location = new System.Drawing.Point(11, 25);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(336, 21);
            this.cmbProdutos.TabIndex = 0;
            this.cmbProdutos.ValueMember = "idProduto";
            this.cmbProdutos.SelectedIndexChanged += new System.EventHandler(this.cmbProdutos_SelectedIndexChanged);
            this.cmbProdutos.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbProdutos_Format);
            // 
            // viewspListaTabelaDePrecosBindingSource
            // 
            this.viewspListaTabelaDePrecosBindingSource.DataMember = "view_spListaTabelaDePrecos";
            this.viewspListaTabelaDePrecosBindingSource.DataSource = this.dsADV_vendaVarejo;
            // 
            // btnAdicionaItem
            // 
            this.btnAdicionaItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionaItem.Image = global::ADV_37_PROJETO_FINAL.Properties.Resources.cart_put;
            this.btnAdicionaItem.Location = new System.Drawing.Point(446, 93);
            this.btnAdicionaItem.Name = "btnAdicionaItem";
            this.btnAdicionaItem.Size = new System.Drawing.Size(39, 40);
            this.btnAdicionaItem.TabIndex = 5;
            this.btnAdicionaItem.UseVisualStyleBackColor = true;
            this.btnAdicionaItem.Click += new System.EventHandler(this.btnAdicionaItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sub-Total R$:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(203, 546);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(119, 26);
            this.txtSubTotal.TabIndex = 7;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Desconto R$:";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(457, 547);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(119, 26);
            this.txtDesconto.TabIndex = 9;
            this.txtDesconto.Text = "0,00";
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(582, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Blue;
            this.txtTotal.Location = new System.Drawing.Point(639, 546);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(119, 26);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalvaVenda
            // 
            this.btnSalvaVenda.Image = global::ADV_37_PROJETO_FINAL.Properties.Resources.disk;
            this.btnSalvaVenda.Location = new System.Drawing.Point(765, 542);
            this.btnSalvaVenda.Name = "btnSalvaVenda";
            this.btnSalvaVenda.Size = new System.Drawing.Size(50, 33);
            this.btnSalvaVenda.TabIndex = 12;
            this.btnSalvaVenda.UseVisualStyleBackColor = true;
            this.btnSalvaVenda.Click += new System.EventHandler(this.btnSalvaVenda_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(12, 546);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(59, 29);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblLembrente_INVISIVEL
            // 
            this.lblLembrente_INVISIVEL.AutoSize = true;
            this.lblLembrente_INVISIVEL.ForeColor = System.Drawing.Color.Red;
            this.lblLembrente_INVISIVEL.Location = new System.Drawing.Point(8, 13);
            this.lblLembrente_INVISIVEL.Name = "lblLembrente_INVISIVEL";
            this.lblLembrente_INVISIVEL.Size = new System.Drawing.Size(324, 13);
            this.lblLembrente_INVISIVEL.TabIndex = 3;
            this.lblLembrente_INVISIVEL.Text = "Comentários no Código Sobre Auto Listagem  evento deste Combo.";
            this.lblLembrente_INVISIVEL.Visible = false;
            // 
            // frmNovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 584);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvaVenda);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdicionaItem);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvItensDaVenda);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNovaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de venda";
            this.Load += new System.EventHandler(this.frmNovaVenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNovaVenda_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewspListaClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsADV_vendaVarejo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewspListaFormaDePagamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensDaVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewspListaItensDaVendaBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewspListaTabelaDePrecosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbFormasDePagamento;
        private System.Windows.Forms.DataGridView dgvItensDaVenda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.ComboBox cmbProdutos;
        private System.Windows.Forms.Button btnAdicionaItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnSalvaVenda;
        private System.Windows.Forms.BindingSource viewspListaItensDaVendaBindingSource;
        private dsADV_vendaVarejo dsADV_vendaVarejo;
        private System.Windows.Forms.BindingSource viewspListaClientesBindingSource;
        private System.Windows.Forms.BindingSource viewspListaTabelaDePrecosBindingSource;
        private System.Windows.Forms.BindingSource viewspListaFormaDePagamentosBindingSource;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblLembrente_INVISIVEL;
    }
}