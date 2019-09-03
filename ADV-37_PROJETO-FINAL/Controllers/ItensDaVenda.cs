using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ADV_37_PROJETO_FINAL.Controllers
{
    class ItensDaVenda : SqlServer
    {
        // Propriedades
        public int IdVenda { get; set; }
        public int IdProduto { get; set; }
        public decimal Preco { get; set; }
        public int Qtde { get; set; }
        public decimal SubTotal { get; set; }

        // Métodos
        /// <sumary>
        /// Recebe um Objeto ItensDaVenda preenchido
        /// e inclui no Banco de Dados
        /// </sumary>
        /// <param name="item">Objeto Preenchido</param>
        /// <returns>Número de linhas afetadas </returns>
        public bool IncluiItemDaVenda(ItensDaVenda item)
        {
            // Cria uma nova Instância SqlCommand
            cmd = new SqlCommand("sp_incluiItemDaVenda", ConexaoAtiva);

            // Define o tipo de Comando
            cmd.CommandType = CommandType.StoredProcedure;

            // Adiciona os comandos com Valores
            cmd.Parameters.AddWithValue("@idVenda", item.IdVenda);
            cmd.Parameters.AddWithValue("@idProduto", item.IdProduto);
            cmd.Parameters.AddWithValue("@preco", item.Preco);
            cmd.Parameters.AddWithValue("@qtde", item.Qtde);
            cmd.Parameters.AddWithValue("@subTotal", item.SubTotal);

            // Executa e retorna o numero de linhas afetadas
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }

        public void ListaItensDaVenda(dsADV_vendaVarejo ds, int idVenda)
        {
            // Cria uma nova Instância SqlCommand
            cmd = new SqlCommand("sp_listaItensDaVenda", ConexaoAtiva);

            // Define o tipo de Comando
            cmd.CommandType = CommandType.StoredProcedure;

            // Parâmetro que identifica a linha a ser Listada

            cmd.Parameters.AddWithValue("@idVenda", idVenda);

            // Cria Uma Nova Instância SqlDataAdapter, passando o Comando SQL
            adp = new SqlDataAdapter(cmd);

            // Limpa dados da tabela
            ds.view_spListaItensDaVenda.Clear();

            // Preenche a tabela do DataSet
            adp.Fill(ds.view_spListaItensDaVenda);
        }
    }
}
