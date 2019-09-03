namespace ADV_37_PROJETO_FINAL.Views
{
    partial class frmProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nupQtdeMinima = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.viewspListaFornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsADV_vendaVarejo = new ADV_37_PROJETO_FINAL.dsADV_vendaVarejo();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvProdutos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeMinimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewspListaProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptbImgProduto = new System.Windows.Forms.PictureBox();
            this.btnBuscaFoto = new System.Windows.Forms.Button();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lbkFiltra = new System.Windows.Forms.Label();
            this.btnExclui = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupQtdeMinima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewspListaFornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsADV_vendaVarejo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewspListaProdutosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição do prouto:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(16, 31);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(366, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Qtde Mínima:";
            // 
            // nupQtdeMinima
            // 
            this.nupQtdeMinima.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupQtdeMinima.Location = new System.Drawing.Point(16, 81);
            this.nupQtdeMinima.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupQtdeMinima.Name = "nupQtdeMinima";
            this.nupQtdeMinima.Size = new System.Drawing.Size(66, 20);
            this.nupQtdeMinima.TabIndex = 3;
            this.nupQtdeMinima.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fornecedor:";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.DataSource = this.viewspListaFornecedoresBindingSource;
            this.cmbFornecedor.DisplayMember = "razaoSocial";
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(101, 83);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(281, 21);
            this.cmbFornecedor.TabIndex = 5;
            this.cmbFornecedor.ValueMember = "id";
            // 
            // viewspListaFornecedoresBindingSource
            // 
            this.viewspListaFornecedoresBindingSource.DataMember = "view_spListaFornecedores";
            this.viewspListaFornecedoresBindingSource.DataSource = this.dsADV_vendaVarejo;
            // 
            // dsADV_vendaVarejo
            // 
            this.dsADV_vendaVarejo.DataSetName = "dsADV_vendaVarejo";
            this.dsADV_vendaVarejo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Produtos cadastrados:";
            // 
            // dtgvProdutos
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvProdutos.AutoGenerateColumns = false;
            this.dtgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.fornecedorDataGridViewTextBoxColumn,
            this.qtdeMinimaDataGridViewTextBoxColumn,
            this.imgNomeDataGridViewTextBoxColumn});
            this.dtgvProdutos.DataSource = this.viewspListaProdutosBindingSource;
            this.dtgvProdutos.Location = new System.Drawing.Point(15, 190);
            this.dtgvProdutos.Name = "dtgvProdutos";
            this.dtgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProdutos.Size = new System.Drawing.Size(765, 303);
            this.dtgvProdutos.TabIndex = 10;
            this.dtgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProdutos_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Blue;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.idDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.Width = 270;
            // 
            // fornecedorDataGridViewTextBoxColumn
            // 
            this.fornecedorDataGridViewTextBoxColumn.DataPropertyName = "fornecedor";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fornecedorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.fornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor (Nome Fantasia)";
            this.fornecedorDataGridViewTextBoxColumn.Name = "fornecedorDataGridViewTextBoxColumn";
            this.fornecedorDataGridViewTextBoxColumn.Width = 170;
            // 
            // qtdeMinimaDataGridViewTextBoxColumn
            // 
            this.qtdeMinimaDataGridViewTextBoxColumn.DataPropertyName = "qtdeMinima";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdeMinimaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.qtdeMinimaDataGridViewTextBoxColumn.HeaderText = "Qtd. Mimima";
            this.qtdeMinimaDataGridViewTextBoxColumn.Name = "qtdeMinimaDataGridViewTextBoxColumn";
            // 
            // imgNomeDataGridViewTextBoxColumn
            // 
            this.imgNomeDataGridViewTextBoxColumn.DataPropertyName = "imgNome";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgNomeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.imgNomeDataGridViewTextBoxColumn.HeaderText = "Nome da Imagem";
            this.imgNomeDataGridViewTextBoxColumn.Name = "imgNomeDataGridViewTextBoxColumn";
            this.imgNomeDataGridViewTextBoxColumn.Width = 130;
            // 
            // viewspListaProdutosBindingSource
            // 
            this.viewspListaProdutosBindingSource.DataMember = "view_spListaProdutos";
            this.viewspListaProdutosBindingSource.DataSource = this.dsADV_vendaVarejo;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(101, 133);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "&Inclui";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(406, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "&Cancela";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptbImgProduto);
            this.groupBox1.Controls.Add(this.btnBuscaFoto);
            this.groupBox1.Location = new System.Drawing.Point(524, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 165);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foto do produto";
            // 
            // ptbImgProduto
            // 
            this.ptbImgProduto.BackColor = System.Drawing.SystemColors.Control;
            this.ptbImgProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImgProduto.Location = new System.Drawing.Point(29, 19);
            this.ptbImgProduto.Name = "ptbImgProduto";
            this.ptbImgProduto.Size = new System.Drawing.Size(180, 140);
            this.ptbImgProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImgProduto.TabIndex = 7;
            this.ptbImgProduto.TabStop = false;
            // 
            // btnBuscaFoto
            // 
            this.btnBuscaFoto.BackgroundImage = global::ADV_37_PROJETO_FINAL.Properties.Resources.camera_add;
            this.btnBuscaFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscaFoto.Location = new System.Drawing.Point(215, 135);
            this.btnBuscaFoto.Name = "btnBuscaFoto";
            this.btnBuscaFoto.Size = new System.Drawing.Size(35, 24);
            this.btnBuscaFoto.TabIndex = 8;
            this.btnBuscaFoto.UseVisualStyleBackColor = true;
            this.btnBuscaFoto.Click += new System.EventHandler(this.btnBuscaFoto_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackgroundImage = global::ADV_37_PROJETO_FINAL.Properties.Resources.find;
            this.btnFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFiltro.Location = new System.Drawing.Point(484, 28);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(33, 23);
            this.btnFiltro.TabIndex = 15;
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(724, 495);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 23);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lbkFiltra
            // 
            this.lbkFiltra.AutoSize = true;
            this.lbkFiltra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkFiltra.ForeColor = System.Drawing.Color.Red;
            this.lbkFiltra.Location = new System.Drawing.Point(388, 34);
            this.lbkFiltra.Name = "lbkFiltra";
            this.lbkFiltra.Size = new System.Drawing.Size(93, 13);
            this.lbkFiltra.TabIndex = 17;
            this.lbkFiltra.Text = "Filtra P/ Nome:";
            // 
            // btnExclui
            // 
            this.btnExclui.Enabled = false;
            this.btnExclui.Location = new System.Drawing.Point(252, 133);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(75, 23);
            this.btnExclui.TabIndex = 18;
            this.btnExclui.Text = "&Exclui";
            this.btnExclui.UseVisualStyleBackColor = true;
            this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 520);
            this.Controls.Add(this.btnExclui);
            this.Controls.Add(this.lbkFiltra);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtgvProdutos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nupQtdeMinima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Edição de Produtos";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProduto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nupQtdeMinima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewspListaFornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsADV_vendaVarejo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewspListaProdutosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImgProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupQtdeMinima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvProdutos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ptbImgProduto;
        private System.Windows.Forms.Button btnBuscaFoto;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeMinimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewspListaProdutosBindingSource;
        private dsADV_vendaVarejo dsADV_vendaVarejo;
        private System.Windows.Forms.BindingSource viewspListaFornecedoresBindingSource;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lbkFiltra;
        private System.Windows.Forms.Button btnExclui;
    }
}