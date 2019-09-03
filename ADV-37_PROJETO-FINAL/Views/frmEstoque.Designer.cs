namespace ADV_37_PROJETO_FINAL.Views
{
    partial class frmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProdutos = new System.Windows.Forms.ComboBox();
            this.viewspListaProdutosEmEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsADV_vendaVarejo = new ADV_37_PROJETO_FINAL.dsADV_vendaVarejo();
            this.viewspListaProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbSaida = new System.Windows.Forms.RadioButton();
            this.rdbEntrada = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeMinimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalva = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nupQtde = new System.Windows.Forms.NumericUpDown();
            this.btnSair = new System.Windows.Forms.Button();
            this.lbl_Informacao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewspListaProdutosEmEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsADV_vendaVarejo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewspListaProdutosBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQtde)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbProdutos);
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos cadastrados";
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProdutos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProdutos.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.viewspListaProdutosEmEstoqueBindingSource, "idProduto", true));
            this.cmbProdutos.DataSource = this.viewspListaProdutosBindingSource;
            this.cmbProdutos.DisplayMember = "descricao";
            this.cmbProdutos.FormattingEnabled = true;
            this.cmbProdutos.Location = new System.Drawing.Point(23, 44);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(368, 21);
            this.cmbProdutos.TabIndex = 0;
            this.cmbProdutos.ValueMember = "id";
            // 
            // viewspListaProdutosEmEstoqueBindingSource
            // 
            this.viewspListaProdutosEmEstoqueBindingSource.DataMember = "view_spListaProdutosEmEstoque";
            this.viewspListaProdutosEmEstoqueBindingSource.DataSource = this.dsADV_vendaVarejo;
            // 
            // dsADV_vendaVarejo
            // 
            this.dsADV_vendaVarejo.DataSetName = "dsADV_vendaVarejo";
            this.dsADV_vendaVarejo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewspListaProdutosBindingSource
            // 
            this.viewspListaProdutosBindingSource.DataMember = "view_spListaProdutos";
            this.viewspListaProdutosBindingSource.DataSource = this.dsADV_vendaVarejo;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbSaida);
            this.groupBox2.Controls.Add(this.rdbEntrada);
            this.groupBox2.Location = new System.Drawing.Point(595, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de movimentação";
            // 
            // rdbSaida
            // 
            this.rdbSaida.AutoSize = true;
            this.rdbSaida.Location = new System.Drawing.Point(32, 55);
            this.rdbSaida.Name = "rdbSaida";
            this.rdbSaida.Size = new System.Drawing.Size(108, 17);
            this.rdbSaida.TabIndex = 1;
            this.rdbSaida.TabStop = true;
            this.rdbSaida.Text = "saída de estoque";
            this.rdbSaida.UseVisualStyleBackColor = true;
            this.rdbSaida.CheckedChanged += new System.EventHandler(this.rdbsMovimentacaoCheckedChanged);
            // 
            // rdbEntrada
            // 
            this.rdbEntrada.AutoSize = true;
            this.rdbEntrada.Location = new System.Drawing.Point(32, 30);
            this.rdbEntrada.Name = "rdbEntrada";
            this.rdbEntrada.Size = new System.Drawing.Size(118, 17);
            this.rdbEntrada.TabIndex = 0;
            this.rdbEntrada.TabStop = true;
            this.rdbEntrada.Text = "Entrada de estoque";
            this.rdbEntrada.UseVisualStyleBackColor = true;
            this.rdbEntrada.CheckedChanged += new System.EventHandler(this.rdbsMovimentacaoCheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produto em estoque:";
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AutoGenerateColumns = false;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.qtdeMinimaDataGridViewTextBoxColumn,
            this.qtdeDataGridViewTextBoxColumn});
            this.dgvEstoque.DataSource = this.viewspListaProdutosEmEstoqueBindingSource;
            this.dgvEstoque.Location = new System.Drawing.Point(24, 178);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.Size = new System.Drawing.Size(764, 352);
            this.dgvEstoque.TabIndex = 3;
            this.dgvEstoque.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvEstoque_DataBindingComplete);
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "idProduto";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.idProdutoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "Id Produto";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.Width = 80;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição do Produto";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.Width = 405;
            // 
            // qtdeMinimaDataGridViewTextBoxColumn
            // 
            this.qtdeMinimaDataGridViewTextBoxColumn.DataPropertyName = "qtdeMinima";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdeMinimaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.qtdeMinimaDataGridViewTextBoxColumn.HeaderText = "Qtd. Minima";
            this.qtdeMinimaDataGridViewTextBoxColumn.Name = "qtdeMinimaDataGridViewTextBoxColumn";
            // 
            // qtdeDataGridViewTextBoxColumn
            // 
            this.qtdeDataGridViewTextBoxColumn.DataPropertyName = "qtde";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.qtdeDataGridViewTextBoxColumn.HeaderText = "Qtd. Atual";
            this.qtdeDataGridViewTextBoxColumn.Name = "qtdeDataGridViewTextBoxColumn";
            // 
            // btnSalva
            // 
            this.btnSalva.BackgroundImage = global::ADV_37_PROJETO_FINAL.Properties.Resources.table_refresh;
            this.btnSalva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalva.Location = new System.Drawing.Point(734, 128);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(53, 44);
            this.btnSalva.TabIndex = 4;
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nupQtde);
            this.groupBox3.Location = new System.Drawing.Point(445, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 100);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quantidade";
            // 
            // nupQtde
            // 
            this.nupQtde.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupQtde.Location = new System.Drawing.Point(16, 44);
            this.nupQtde.Name = "nupQtde";
            this.nupQtde.Size = new System.Drawing.Size(95, 20);
            this.nupQtde.TabIndex = 0;
            this.nupQtde.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(734, 537);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(54, 23);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lbl_Informacao
            // 
            this.lbl_Informacao.AutoSize = true;
            this.lbl_Informacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Informacao.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Informacao.Location = new System.Drawing.Point(617, 143);
            this.lbl_Informacao.Name = "lbl_Informacao";
            this.lbl_Informacao.Size = new System.Drawing.Size(110, 13);
            this.lbl_Informacao.TabIndex = 13;
            this.lbl_Informacao.Text = "Atualiza Tabela ->";
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 567);
            this.Controls.Add(this.lbl_Informacao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.dgvEstoque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inclusão e Remoção de produtos ao estoque";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEstoque_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewspListaProdutosEmEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsADV_vendaVarejo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewspListaProdutosBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupQtde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProdutos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbSaida;
        private System.Windows.Forms.RadioButton rdbEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nupQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeMinimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewspListaProdutosEmEstoqueBindingSource;
        private dsADV_vendaVarejo dsADV_vendaVarejo;
        private System.Windows.Forms.BindingSource viewspListaProdutosBindingSource;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lbl_Informacao;
    }
}