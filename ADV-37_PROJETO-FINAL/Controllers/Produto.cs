using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ADV_37_PROJETO_FINAL.Controllers
{

    // Dispoe duas (02) ações para o estoque
    enum Estoque 
    {
        Saida,Entrada
    }

    class Produto:SqlServer 
    {
        // Propriedades
        public int Id {get; set;}
        public int IdFornecedor {get; set;}
        public string Descricao {get; set;}
        public int QtdMinima {get; set;}
        public string imgNome {get; set;}

        /// <sumary>
        /// Lista os Produtos Cadastrados filtrando pela Descrição pssaa
        /// passe"" para retornar todos
        /// </sumary>
        /// <param name="ds"></param>
        public void ListaProdutos(dsADV_vendaVarejo ds, string descricao)
        {
            // Cria uma nova Instância SqlCommand
            cmd = new SqlCommand("sp_listaProdutos", ConexaoAtiva);

            // Define o tipo de comando a ser executado
            cmd.CommandType = CommandType.StoredProcedure;

            // Adiciona Parâmetro com Valor
            cmd.Parameters .AddWithValue ("@descricao", descricao);

            // Cria uma nova Instância SqlDataAdapter
            adp = new SqlDataAdapter(cmd);

            // Limpa os Dados da Tabela
            ds.view_spListaProdutos.Clear();

            // Preenche a tabela do DataSet com os dados retornados do Banco de Dados
            adp.Fill(ds.view_spListaProdutos);
        }

        /// <sumary>
        /// Recebe um Objeto Produto Preenchido
        /// e inclui no Banco de Dados
        /// </sumary>
        /// <param name="produto">Objeto Preenchido</param>
        /// <returns>true/false</returns>
        public bool IncluiProduto(Produto produto)
        {
            // Cria uma nova Instância SqlCommand 
            cmd = new SqlCommand("sp_incluiProduto", ConexaoAtiva);

            // Define o tipo de comando a ser executado
            cmd.CommandType = CommandType.StoredProcedure;

            // Adiciona os comandos com Valores
            cmd.Parameters.AddWithValue("@idFornecedor", produto.IdFornecedor);
            cmd.Parameters.AddWithValue("@desc", produto.Descricao);
            cmd.Parameters.AddWithValue("@qtdeMinima", produto.QtdMinima);
            cmd.Parameters.AddWithValue("@imgNome", produto.imgNome == null ? "Não Informado": produto .imgNome);

            // Executa o comando e trata o retorno
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }

        /// <sumary>
        /// Recebe um Objeto Produto Preenchido
        /// e altera a linha do Banco de Dados identificada pela propriedade "Id"
        /// </sumary>
        /// <param name="produto"></param>
        /// <returns></returns>
        public bool AlteraProduto(Produto produto)
        {
            // Cria uma nova Instância SqlCommand 
            cmd = new SqlCommand("sp_alteraProduto", ConexaoAtiva);

            // Define o tipo de comando a ser executado
            cmd.CommandType = CommandType.StoredProcedure;

            // Adiciona os comandos com Valores
            cmd.Parameters.AddWithValue("@idFornecedor", produto.IdFornecedor);
            cmd.Parameters.AddWithValue("@desc", produto.Descricao);
            cmd.Parameters.AddWithValue("@qtdeMinima", produto.QtdMinima);
            cmd.Parameters.AddWithValue("@imgNome", produto.imgNome == null ? "Não Informado" : produto.imgNome);

            // Adiciona Parâmetro que identifica a linha a ser alterada
            cmd.Parameters.AddWithValue("@id", produto.Id);

            // Executa o comando e trata o retorno
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }

        /// <sumary>
        /// Recebe o id do produto, quantidade e inclui no Estoque
        /// se não existir e se existir altera a quantidade para (+) ou (-)
        /// </sumary>
        /// <param name="idProduto"> Id do Produto </param>
        /// <returns> true/ false </returns>
        /// 
        public bool IncluiProdutoEmEstoque(int idProduto, int qtde)
        {
            // Cria uma nova Instância SqlCommand, passando o comando e a conexão ativa
            cmd = new SqlCommand("sp_incluiProdutoEstoque", ConexaoAtiva);

            // Define o Tipo de Comando
            cmd.CommandType = CommandType.StoredProcedure;

            // Adiciona Parametros com valores 
            cmd.Parameters.AddWithValue("@idProduto", idProduto);
            cmd.Parameters.AddWithValue("@qtde", qtde);

            // Executa o Comando e trata o retorno
            return this.cmd.ExecuteNonQuery() > 0 ? true : false;
        }

        /// <sumary>
        /// Recebe uma Instância do DataSet ADV_vendaVarejo e
        /// preenche a tabela view_splistaProdutosEmEstoque com os produtos
        /// que estão no estoque
        /// </sumary>
        /// <param name="ds"></param>
        public void ListaProdutosEmEstoque(dsADV_vendaVarejo ds)
        {
            // Cria uma nova Instância SqlCommand 
            cmd = new SqlCommand("sp_listaProdutosEmEstoque", ConexaoAtiva);

            // Define o tipo de comando a ser executado
            cmd.CommandType = CommandType.StoredProcedure;

            // Cria Uma Nova Instância SqlDataAdapter, passando o Comando SQL
            adp = new SqlDataAdapter(cmd);

            // Limpa Dados da Tabela
            ds.view_spListaProdutosEmEstoque.Clear();

            // Preenche a tabela do DataSet
            adp.Fill(ds.view_spListaProdutosEmEstoque);
        }
    }
}
