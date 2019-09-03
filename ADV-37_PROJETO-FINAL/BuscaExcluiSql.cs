using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// =========================================== //
using System.Data;
using System.Data.SqlClient;

// Este Using é para pegar a String de Conexão No "Properties" do Namespace (Projeto).
using ADV_37_PROJETO_FINAL.Properties;

namespace Conexao_SqlServer
{
    class BuscaExcluiSql
    {
        // Define a string de conexão com Banco de Dados pegando lá de Propertiers/Settings/-->Default e o Nome ...
        public string sql = (Settings.Default.ss);

        public BuscaExcluiSql() // Construtor da Classe
        {
            // Nada Necessário.
        }
    }
}