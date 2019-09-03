using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ADV_37_PROJETO_FINAL.Controllers
{
    class Fornecedor:SqlServer 
    {
        // Propriedades
        public int Id {get; set;}
        public string RazaoSocial {get; set;}
        public string NomeFantasia {get; set;}
        public string Contato {get; set;}
        public int DDD {get; set;}
        public int Telefone1 {get; set;}
        public int Telefone2 {get; set;}

        /// <sumary>
        /// Preenche a tabela do DataSet recebido por Parâmetro
        /// </sumary>
        /// <param name="ds">DataSet: dsADV_vendaVarejo</param>
        public void ListaFornecedores(dsADV_vendaVarejo ds)
        {
            // Cria uma nova Instância SqlCommand
            cmd = new SqlCommand("sp_listaFornecedores", ConexaoAtiva);

            // Define o tipo de Comando
            cmd.CommandType = CommandType.StoredProcedure;

            // Cria uma nova Instância DataAdapter e passa o comando no Construtor
            adp = new SqlDataAdapter(cmd);

            // Limpa dados da tabela
            ds.view_spListaFornecedores.Clear();

            // Preenche a tabela do DataSet
            adp.Fill(ds.view_spListaFornecedores);
        }

        /// <sumary>
        /// Recebe um Objeto Fornecedor preenchido e 
        /// inclui no Banco de Dados
        /// </sumary>
        /// <param name="fornecedor">Objeto Fornecedor</param>
        /// <returns>true/false</returns>
        public bool IncluiFornecedor(Fornecedor fornecedor)
        {
            // Cria Uma nova Instância SqlCommand
            cmd = new SqlCommand("sp_incluiFornecedor", ConexaoAtiva);

            // Define o tipo de comando que é (STORE PROCEDURE)
            // Poderia ser texto...
            cmd.CommandType = CommandType.StoredProcedure;

            // Adiciona os Parâmetros com Valores
            cmd.Parameters.AddWithValue("@rSocial", fornecedor.RazaoSocial);
            cmd.Parameters.AddWithValue("@nFantasia", fornecedor.NomeFantasia);
            cmd.Parameters.AddWithValue("@contato", fornecedor.Contato);
            cmd.Parameters.AddWithValue("@ddd", fornecedor.DDD);
            cmd.Parameters.AddWithValue("@tel1", fornecedor.Telefone1);
            cmd.Parameters.AddWithValue("@tel2", fornecedor.Telefone2);

            // Executa o comando e verifica o Retorno
            return cmd.ExecuteNonQuery () > 0 ? true:false;
        }

        /// <sumary>
        /// Recebe um Objeto Fornecedor preenchido e 
        /// atualiza o registro no Banco de Dados
        /// </sumary>
        /// <param name="fornecedor">Objeto Fornecedor</param>
        /// <returns>true/false</returns>
        public bool AlteraFornecedor(Fornecedor fornecedor)
        {
            // Cria Uma nova Instância SqlCommand
            cmd = new SqlCommand("sp_alteraFornecedor", ConexaoAtiva);

            // Define o tipo de comando que é (STORE PROCEDURE)
            // Poderia ser texto...
            cmd.CommandType = CommandType.StoredProcedure;

            // Adiciona os Parâmetros com Valores
            cmd.Parameters.AddWithValue("@rSocial", fornecedor.RazaoSocial);
            cmd.Parameters.AddWithValue("@nFantasia", fornecedor.NomeFantasia);
            cmd.Parameters.AddWithValue("@contato", fornecedor.Contato);
            cmd.Parameters.AddWithValue("@ddd", fornecedor.DDD);
            cmd.Parameters.AddWithValue("@tel1", fornecedor.Telefone1);
            cmd.Parameters.AddWithValue("@tel2", fornecedor.Telefone2);

            // Parâmetro que identifica a linha a ser atualizada

            cmd.Parameters.AddWithValue("@id", fornecedor.Id);

            // Executa o comando e verifica o Retorno
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
    }
}
