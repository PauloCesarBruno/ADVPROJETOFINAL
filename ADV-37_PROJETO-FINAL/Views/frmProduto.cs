using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Add
using System.IO; // Entrada /Saioda (Imput/Output)
//
using System.Data.SqlClient;

namespace ADV_37_PROJETO_FINAL.Views
{
    public partial class frmProduto : Form
    {
        // Atributo com Path (Caminho) para as fotos
        private string pathIMG = Path.GetFullPath(@"FotoProduto\");

        // O Path para a criação do diretório de fotos
        private DirectoryInfo dir = new DirectoryInfo(Path.GetFullPath("FotoProduto"));

        // Cria uma nova Instância da Classe Fornecedor
        private Controllers.Fornecedor fornecedor = new Controllers.Fornecedor();

        // Cria uma nova Instância da Classe Produto
        private Controllers.Produto produto = new Controllers.Produto();


        public frmProduto()
        {
            InitializeComponent();
        }
        private void DeletaProduto()
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
                    SqlCommand cmd = new SqlCommand("DELETE FROM Produto WHERE Id= '" + produto .Id  + "'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgvProdutos.DataSource = (dt);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Detalhe -->> " + ex);
            }
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            try
            {
                // Lista os Fornecedore
                fornecedor.ListaFornecedores(dsADV_vendaVarejo);

                // Lista os Produtos Cadastrados, filtrando pelo texto contido no txtDescrição
                produto.ListaProdutos(dsADV_vendaVarejo, txtDescricao.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe: " + ex.Message, "ERRO:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscaFoto_Click(object sender, EventArgs e)
        {
            // Cria Uma nova Instância da Classe Open FileDialog
            OpenFileDialog openFile = new OpenFileDialog();

            // Define o Título da Janela
            openFile.Title = "Selecionar a Imagem do Produto";
            openFile.Multiselect = false;

            // Filtra os artquivos do diretório selecionado
            openFile.Filter = "Imagem (*.jpg)|*.jpg|Imagem (*.png)|*.png| All files (*.*)|*.*";

            // Se o usuario selecionou uma imagem
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Atribui a Imagem Selecionada ao PictureBox
                ptbImgProduto.Image = Image.FromFile(openFile.FileName);

                // Alimenta a Propriedade imgNome do objeto Produto
                produto.imgNome = openFile.SafeFileName;
            }
        }

        private void dtgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnExclui.Enabled = true;
            // Verifica se o Usuário Clicou na Linha do Grid
            if (e.RowIndex >= 0)
            {
                // Pega os Valores da Linha Atual
                produto.Id = int.Parse(dtgvProdutos[0, e.RowIndex].Value.ToString());
                txtDescricao.Text = dtgvProdutos[1, e.RowIndex].Value.ToString();

                //Seleciona o Fornecedor no ComboBox
                foreach (DataRowView rowView in cmbFornecedor.Items)
                {
                    if (rowView.Row.ItemArray[2].ToString() == dtgvProdutos[2, e.RowIndex].Value.ToString())
                    {
                        cmbFornecedor.SelectedItem = rowView;
                        break; // Sai do Loop
                    }
                }

                nupQtdeMinima.Value = Convert.ToDecimal(dtgvProdutos[3, e.RowIndex].Value.ToString());

                // Verifica se Imagem existe no diretorio de fotos
                if (File.Exists(pathIMG + dtgvProdutos[4, e.RowIndex].Value.ToString()))
                {
                    ptbImgProduto.Image = Image.FromFile(pathIMG + dtgvProdutos[4, e.RowIndex].Value.ToString());
                    produto.imgNome = dtgvProdutos[4, e.RowIndex].Value.ToString();
                }
                else
                {
                    produto.imgNome = null;
                }

                // Altera o Texto do Botão Salvar
                btnSalvar.Text = "Altera";

                // Habilita o Botão Cancelar
                btnCancelar.Enabled = true;
            }
        }

        private void reset()
        {
            // Zera a propriedade Id do objeto Produto
            produto.Id = 0;

            // Limpa Valores dos Controles
            txtDescricao.Text = string.Empty;
            nupQtdeMinima.Value = 1;
            cmbFornecedor.SelectedIndex = 0;
            cmbFornecedor .Text =string .Empty ;
            ptbImgProduto.Image = null;

            // Volta o Texto do Botão Salvar
            btnSalvar.Text = "Inclui";

            // Desabilita o Botão Cancelar
            btnCancelar.Enabled = false;

            // Lista todos os produtos
            produto.ListaProdutos(dsADV_vendaVarejo, "");
            txtDescricao.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se o Usuário preencheu a descrição
                if (txtDescricao.Text.Length == 0)
                {
                    MessageBox.Show("Preencha a Descrição do Produto... ", "CAMPO OBRIGATÓRIO:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescricao.Focus();
                    return;
                }

                // Armazena o Resultado
                bool result;

                // Preenche o objeto
                produto.Descricao = this.txtDescricao.Text;
                produto.IdFornecedor = int.Parse (cmbFornecedor.SelectedValue.ToString ());
                produto.QtdMinima = int.Parse  (nupQtdeMinima.Value.ToString ());

                // Verifica a Ação
                if (produto.Id == 0)
                {
                    // Insert
                    result = produto.IncluiProduto(produto);
                }
                else
                {
                    result = produto.AlteraProduto(produto);
                }

                // Se o result for True
                if (result)
                {
                    // Se caso o diretório não existir, será criado
                    if (!dir.Exists)
                        dir.Create();

                    // Se o Arquivo não existir ...
                    if (!File.Exists(pathIMG + produto.imgNome) && produto.imgNome != null)
                    {
                        // Salva a Imagem que está no PictureBox
                        ptbImgProduto.Image.Save(pathIMG + produto.imgNome);
                    }

                    // Volta para o estado Default
                    reset();
                }
            }
                catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe: " + ex.Message, "ERRO:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            reset();
            btnExclui.Enabled = false;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
           btnCancelar.Enabled = true;
            try
            {
                /* Filtra os produtos que começam com as letras informadas no TextBox
                 * (txtdescricao) e deixa a propriedade Text vazia; Para exibir todos os produtos.*/
                produto.ListaProdutos(dsADV_vendaVarejo, txtDescricao.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe: " + ex.Message, "ERRO:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProduto_KeyDown(object sender, KeyEventArgs e)
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
                DeletaProduto();
                MessageBox.Show("Produto Exluido com Êxito...", "AVISO:", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
