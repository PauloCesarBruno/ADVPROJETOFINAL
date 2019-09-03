namespace ADV_37_PROJETO_FINAL.Views
{
    partial class frmFormaDePagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormaDePagamento));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstbFormasDePagamentos = new System.Windows.Forms.ListBox();
            this.viewspListaFormaDePagamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsADV_vendaVarejo = new ADV_37_PROJETO_FINAL.dsADV_vendaVarejo();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExclui = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewspListaFormaDePagamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsADV_vendaVarejo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(80, 14);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(252, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Formas de pagamentos cadastradas:";
            // 
            // lstbFormasDePagamentos
            // 
            this.lstbFormasDePagamentos.DataSource = this.viewspListaFormaDePagamentosBindingSource;
            this.lstbFormasDePagamentos.DisplayMember = "descricao";
            this.lstbFormasDePagamentos.FormatString = "Código:{0} Descrição: {1}";
            this.lstbFormasDePagamentos.FormattingEnabled = true;
            this.lstbFormasDePagamentos.Location = new System.Drawing.Point(18, 92);
            this.lstbFormasDePagamentos.Name = "lstbFormasDePagamentos";
            this.lstbFormasDePagamentos.Size = new System.Drawing.Size(417, 277);
            this.lstbFormasDePagamentos.TabIndex = 3;
            this.lstbFormasDePagamentos.ValueMember = "id";
            this.lstbFormasDePagamentos.SelectedIndexChanged += new System.EventHandler(this.lstbFormasDePagamentos_SelectedIndexChanged);
            // 
            // viewspListaFormaDePagamentosBindingSource
            // 
            this.viewspListaFormaDePagamentosBindingSource.DataMember = "view_spListaFormaDePagamentos";
            this.viewspListaFormaDePagamentosBindingSource.DataSource = this.dsADV_vendaVarejo;
            // 
            // dsADV_vendaVarejo
            // 
            this.dsADV_vendaVarejo.DataSetName = "dsADV_vendaVarejo";
            this.dsADV_vendaVarejo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(360, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "&Inclui";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(360, 66);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancela";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(377, 375);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(58, 36);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExclui
            // 
            this.btnExclui.Enabled = false;
            this.btnExclui.Location = new System.Drawing.Point(360, 39);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(75, 23);
            this.btnExclui.TabIndex = 7;
            this.btnExclui.Text = "&Exclui";
            this.btnExclui.UseVisualStyleBackColor = true;
            this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
            // 
            // frmFormaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 417);
            this.Controls.Add(this.btnExclui);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lstbFormasDePagamentos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFormaDePagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Edição de Formas de Pagamento";
            this.Load += new System.EventHandler(this.frmFormaDePagamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFormaDePagamento_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.viewspListaFormaDePagamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsADV_vendaVarejo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstbFormasDePagamentos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource viewspListaFormaDePagamentosBindingSource;
        private dsADV_vendaVarejo dsADV_vendaVarejo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExclui;
    }
}