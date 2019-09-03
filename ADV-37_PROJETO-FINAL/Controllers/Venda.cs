using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ADV_37_PROJETO_FINAL.Controllers
{
    class Venda:SqlServer 
    {
        // Propriedades
        public int Id {get; set;}
        public int IdUsuario {get; set;}
        public int IdCliente {get; set;}
        public int IdFormaDePagamento {get; set;}
        public DateTime DataVenda {get; set;}
        public decimal Total {get; set;}

        // Métodos
        public int IncluiVenda(Venda venda)
        {
               // Cria uma nova Instância SqlCommand
            cmd = new SqlCommand("sp_incluiVenda", ConexaoAtiva);

            // Define o tipo de Comando
            cmd.CommandType = CommandType.StoredProcedure;

            // Adiciona: Parâmetro e Valor
            cmd.Parameters.AddWithValue("@idUsuario", venda.IdUsuario);
            cmd.Parameters.AddWithValue("@idCliente", venda.IdCliente);
            cmd.Parameters.AddWithValue("@idFormaDePagamento", venda.IdFormaDePagamento);
            cmd.Parameters.AddWithValue("@dataVenda", venda.DataVenda);
            cmd.Parameters.AddWithValue("@total", venda.Total);

            // Pega o id da venda retornado do Bancio de Dados
            cmd.Parameters.AddWithValue("@idVenda", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();

            // Traz o id da venda retornado pelo Banco de Dados
            return (int)cmd.Parameters["@idVenda"].Value;
           }

        public void ListaVendasEntreDatas(dsADV_vendaVarejo ds, DateTime dataInicial, DateTime dataFinal)
        {

            // Cria uma nova Instância SqlCommand
            cmd = new SqlCommand("sp_listaVendasEntreDatas", ConexaoAtiva);

            // Define o tipo de Comando
            cmd.CommandType = CommandType.StoredProcedure;

            // Adiciona: Parâmetro e Valor
            cmd.Parameters.AddWithValue("@dataInicial", dataInicial);
            cmd.Parameters.AddWithValue("@dataFinal", dataFinal);

            // Cria uma nova Instância SqlDataAdapter
            adp = new SqlDataAdapter(cmd);

            // Limpa Tabela
            ds.view_spListaVendasEntreDatas.Clear();

            // Preenche Tabela
            adp.Fill(ds.view_spListaVendasEntreDatas);
        }
    }
}
