using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ADV_37_PROJETO_FINAL.Controllers
{
    class FormaDePagamento:SqlServer 
    {
        // Propriedades
        public int Id {get; set;}
        public string Descricao {get; set;}

        /// <sumary>
        /// Recebe uma Instância do dsADV_vendaVarejo
        /// e preenche a tabela views_spListaFormaDePagamentos
        /// </sumary>
        /// <param name="ds">dsADV_vendaVarejo</param>
        public void ListaFormaDePagamentos(dsADV_vendaVarejo ds)
        {
            // Cria uma nova Instância SqlCommand
            cmd = new SqlCommand("sp_listaFormaDePagamentos", ConexaoAtiva);

            this.adp = new System.Data.SqlClient.SqlDataAdapter(this.cmd);

            // Define o tipo de Comando
            cmd.CommandType = CommandType.StoredProcedure;


            // Limpa dados da tabela
            ds.view_spListaFormaDePagamentos .Clear();

            // Preenche a tabela do DataSet
            adp.Fill(ds.view_spListaFormaDePagamentos);
        }

        /// <sumary>
        /// Recebe o Objeto preenchido e adiciona
        /// no Banco de Dados 
        /// </sumary>
        /// <param name="formaPagamento">Objeto da FormaDePagamento</param>
        /// <returns>true/false</returns>
        public bool IncluiFormaDePagamento(FormaDePagamento formaPagamento)
        {
            // Cria uma nova Instância SqlCommand
            cmd = new SqlCommand("sp_incluiFormaDePagamento", ConexaoAtiva);

            // Define o tipo de Comando
            cmd.CommandType = CommandType.StoredProcedure;

            // Adiciona Parâmetro com valor
            cmd.Parameters.AddWithValue("@Desc", formaPagamento.Descricao);


            // Executa o comando e trata o retorno
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }

        /// <sumary>
        /// Recebe o Objeto preenchido e utiliza
        /// o registro do Banco de Dados identificado pela propriedade Id do Objeto 
        /// </sumary>
        /// <param name="formaPagamento">Objeto da Classe FormaDePagamento</param>
        /// <returns>true/false</returns>
        public bool AlteraFormaDePagamento(FormaDePagamento formaPagamento)
        {
            // Cria uma nova Instância SqlCommand
            cmd = new SqlCommand("sp_AlteraFormaDePagamento", ConexaoAtiva);

            // Define o tipo de Comando
            cmd.CommandType = CommandType.StoredProcedure;

            // Adiciona o Parâmetro com Valor
            cmd.Parameters.AddWithValue("@desc", formaPagamento.Descricao);

            cmd.Parameters.AddWithValue("@id", formaPagamento.Id);

            // Executa o comando e trata o retorno
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
    }
}
