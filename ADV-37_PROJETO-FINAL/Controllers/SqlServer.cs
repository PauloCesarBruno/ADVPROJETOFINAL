using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// SQL
using System.Data;
using System.Data.SqlClient;

namespace ADV_37_PROJETO_FINAL.Controllers
{
    /// <summary>
    /// adstract: Não Permite Criar Novas instâncias da Classe, apenas Herânça
    /// </summary>
    abstract class SqlServer
    {
        // Atributos Privados
        private SqlConnection sqlConn;

        // Atributos Protegidos

        // SqlCommand é a Classe responsavel por enviar e receber comandos
        // Requer uma Conexão Ativa
        protected SqlCommand cmd;

        // SqlDataAdapter é a Classe que recebe o comando Sql e adapta
        // ao Banco de Dados (insert,Update,delete e select)
        // Usarei para Select
        protected SqlDataAdapter adp;

        // SqlDataReader é a Classe que faz a leitura linha-a-linha
        // dos dados retornados pela execução do comando SqlCommand.ExecuteReader()
        protected SqlDataReader reader;

        // DataTable é a Classe usada para criar tabelas
        protected DataTable tb;

        // Construtor Padrão
        protected SqlServer()
        {
            // Cria uma nova Instância SqlConection
            this.sqlConn = new SqlConnection(Properties.Settings.Default.ss);
        }

        // Construtor Customizado
        protected SqlServer(string strHost)
        {
            // Cria uma nova Instância SqlConection
            this.sqlConn = new SqlConnection(strHost);
        }

        //Propriedade de Somente Leitura
        protected SqlConnection ConexaoAtiva
        {
            get
            {
                // Se a Conexão estiver fechada .... Abre.
                if (this.sqlConn.State == ConnectionState.Closed)

                    this.sqlConn.Open();

                // Retorna Conexão
                return this.sqlConn;
            }
        }
    }
}