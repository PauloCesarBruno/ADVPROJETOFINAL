using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;


namespace ADV_37_PROJETO_FINAL.Controllers
{
    class Cliente:SqlServer 
    {
        // Propriedades
        public int Id { get; set;}
        public string NomeCompleto { get; set;}
        public DateTime DataNascimento { get; set;}
        public string Email { get; set;}
        public int DDD { get; set;}
        public int Telefone { get; set;}

        /// <sumary>
        /// Recebe um Objeto Cliente Alimentado
        /// e adiciona ao Banco de Dados
        /// </sumary>
        /// <param name="cliente">Objeto Alimentado</param>
        /// <returns>true/false</returns>
        public bool IncluiCliente(Cliente cliente)
        {
            // Cria uma nova Instância SQLCommand e passa para o Construtor
            // o nome da procedure e a Conexão Ativa
            cmd=new SqlCommand ("sp_incluiCliente", ConexaoAtiva);
            cmd.CommandType =CommandType .StoredProcedure ;

            // Adiciona Parâmetro VALOR
            cmd.Parameters .AddWithValue ("@nomeComp",cliente.NomeCompleto);
            cmd.Parameters .AddWithValue ("@dataNascimento",cliente.DataNascimento);
            cmd.Parameters .AddWithValue ("@email",cliente.Email);
            cmd.Parameters .AddWithValue ("@ddd",cliente.DDD);
            cmd.Parameters .AddWithValue ("@tel",cliente.Telefone);

            //Executa NonQuery Usado para INSERT, UPDATE e DELETE
            //Retorna o numero de linhas afetadas
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }

        /// <sumary>
        /// Recebe um Objeto Cliente Preenchido
        /// e atualiza a linha do Banco de Dados
        /// identificada pelo Id do Objeto recebido
        /// </sumary>
        /// <param name="cliente">Objeto Preenchido</param>
        /// <returns>true/false</returns>
        public bool AlteraCliente(Cliente cliente)
        {
            // Cria uma nova Instância SQLCommand e passa para o Construtor
            // o nome da procedure e a Conexão Ativa
            cmd = new SqlCommand("sp_alteraCliente", ConexaoAtiva);
            cmd.CommandType = CommandType.StoredProcedure;

            // Adiciona Parâmetro VALOR
            cmd.Parameters.AddWithValue("@nomeComp", cliente.NomeCompleto);
            cmd.Parameters.AddWithValue("@dataNascimento", cliente.DataNascimento);
            cmd.Parameters.AddWithValue("@email", cliente.Email);
            cmd.Parameters.AddWithValue("@ddd", cliente.DDD);
            cmd.Parameters.AddWithValue("@tel", cliente.Telefone);

            // Id a ser Alterado
            cmd.Parameters.AddWithValue("@id", cliente.Id);

            //Executa NonQuery Usado para INSERT, UPDATE e DELETE
            //Retorna o numero de linhas afetadas
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }

        /// <sumary>
        /// Retorna os Clientes Cadastrados
        /// </sumary>
        /// <param name="ds">Pesquisa Letra +*</param>
        public void ListaClientes(dsADV_vendaVarejo ds, string nome)
        {
            cmd = new SqlCommand("sp_listaClientes", ConexaoAtiva);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nome", nome);

            // Cria uma nova instância SqlDataAdapter e passa o comando
            adp = new SqlDataAdapter(cmd);

            ds.view_spListaClientes.Clear();

            // Preenche a tabela do DataSet
            adp.Fill(ds.view_spListaClientes);
        }
    }
}
