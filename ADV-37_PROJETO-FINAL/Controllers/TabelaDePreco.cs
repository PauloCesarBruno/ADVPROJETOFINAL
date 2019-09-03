using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_37_PROJETO_FINAL.Controllers
{
    enum Acao { inclui, altera }

    class TabelaDePreco : SqlServer
    {
        //Propriedades
        public int IdProduto { get; set; }
        public decimal Preco { get; set; }

        public void ListaPrecos(dsADV_vendaVarejo ds)
        {
            this.cmd = new System.Data.SqlClient.SqlCommand("sp_listaTebelaDePreco", this.ConexaoAtiva);
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            this.adp = new System.Data.SqlClient.SqlDataAdapter(this.cmd);
           
            ds.view_spListaTabelaDePrecos.Clear();

           this.adp.Fill(ds.view_spListaTabelaDePrecos);

        }


        public bool IncluiPreco(TabelaDePreco tabelaDePreco)
        {
            this.cmd = new System.Data.SqlClient.SqlCommand("sp_incluiPreco", this.ConexaoAtiva);
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            this.cmd.Parameters.AddWithValue("@idProduto", tabelaDePreco.IdProduto);
            this.cmd.Parameters.AddWithValue("@preco", tabelaDePreco.Preco);

            return this.cmd.ExecuteNonQuery() > 0 ? true : false;


        }

        public bool alteraPreco(TabelaDePreco tabelaDePreco)
        {
            this.cmd = new System.Data.SqlClient.SqlCommand("sp_alteraPreco", this.ConexaoAtiva);
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            this.cmd.Parameters.AddWithValue("@idProduto", tabelaDePreco.IdProduto);
            this.cmd.Parameters.AddWithValue("@preco", tabelaDePreco.Preco);

            return this.cmd.ExecuteNonQuery() > 0 ? true : false;
        }
    }
}

