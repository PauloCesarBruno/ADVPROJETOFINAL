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
    public partial class frmVendas : Form
    {
        Controllers.Venda venda = new Controllers.Venda();

        private DateTime datainicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);


        public frmVendas()
        {
            InitializeComponent();
        }

        private void DeletaVenda() // Esses 2 Métodos é tipo um TRUNCATE porem isso é para tabelas C/Relação
        // =================================================================================================
        {
            try
            {
                {
                    Conexao_SqlServer.BuscaExcluiSql obj = new Conexao_SqlServer.BuscaExcluiSql();
                    SqlConnection conn = new SqlConnection(obj.sql);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE  FROM Venda", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvVendas.DataSource = (dt);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Detalhe -->> " + ex);
            }
        }
        private void ResetaChave()
        {
            try
            {
                {
                    Conexao_SqlServer.BuscaExcluiSql obj = new Conexao_SqlServer.BuscaExcluiSql();
                    SqlConnection conn = new SqlConnection(obj.sql);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DBCC CHECKIDENT('Venda', RESEED, 0)", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvVendas.DataSource = (dt);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Detalhe -->> " + ex);
            }
            // Fim dos Métodos para "TRUNCAR" Tabela Relacionada, na verdade usa-se um Delete sem WHERE e um DBCC CHECKIDENT
            // ==============================================================================================================
        }
        private void frmVendas_Load(object sender, EventArgs e)
        {

            dtpDataInicial.Text = datainicial.ToString();
            try
            {
                venda.ListaVendasEntreDatas(dsADV_vendaVarejo, dtpDataInicial.Value, dtpDataFinal.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                venda.ListaVendasEntreDatas(dsADV_vendaVarejo, dtpDataInicial.Value, dtpDataFinal.Value);
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
               dgvVendas.FirstDisplayedScrollingRowIndex = dgvVendas.RowCount - 1;

            }
            catch (Exception)
            {
                MessageBox.Show("ERRO!!!!");
            }
        }

        private void visualizarItensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int idx = 0; idx < dgvVendas.RowCount; idx++)
            {
                if (dgvVendas.Rows[idx].Selected)
                {
                    Views.frmItensDaVenda fitensVenda = new frmItensDaVenda();
                    fitensVenda.Text = "Visualizando Itens da Venda: " + dgvVendas.Rows[idx].Cells[0].Value.ToString();
                    fitensVenda.idVenda = (int)dgvVendas.Rows[idx].Cells[0].Value;
                    fitensVenda.ShowDialog();

                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calcula Valor total da coluna "Total" (Coluna 5) e Joga para o txtTotal (textBox).
            double Valor = 0;
            foreach (DataGridViewRow linha in dgvVendas.Rows)
            {
                Valor += Convert.ToDouble(linha.Cells[5].Value);
            }
            txtTotal.Text = Valor.ToString("c");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmAutorizacao autorizacao = new frmAutorizacao();

            if (autorizacao.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Operação não Autorizado, somente digitando uma senha de Administrador poderá concluir esta operação ...!!!", "Autorização Negada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult perg = MessageBox.Show("Deseja Realmente Zerar as Vendas Sim ou não ?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (perg == DialogResult.Yes)
            {
                DeletaVenda(); // Chamada dos Métodos para Zerar a tabela de Vendas como se fosse um truncate table,
                ResetaChave(); // porém por ser tabela relacionada faz-se desta maneira.

                MessageBox.Show("Operação Realizada com Sucesso !!!", "AVISO:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("OK, Mantendo Registros de Vendas", "AVISO:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
