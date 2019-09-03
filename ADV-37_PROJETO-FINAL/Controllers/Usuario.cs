using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_37_PROJETO_FINAL.Controllers
{
    class Usuario : SqlServer
    {
        //propriedades
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Adm { get; set; }


        ///<summary>
        ///Alimenta a tabela view_spListaUsuarios do Dataset
        ///recebido como parametro
        ///</summary>
        ///<param name="ds">uma instancia do dsADV_vendaVarejo</param>


        public void ListaUsuarios(dsADV_vendaVarejo ds)
        {
            //cria uma nova instancia SqlCommand
            this.cmd = new System.Data.SqlClient.SqlCommand("sp_ListaUsuarios", this.ConexaoAtiva);

            //define o tipo de comendo a ser executado
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //cria nova instancia do sqlAdapter passado como parametro
            //comando a ser adaptados
            this.adp = new System.Data.SqlClient.SqlDataAdapter(this.cmd);

            //esvazia usuarios da tabela
            ds.view_spListaUsuarios.Clear();

            //preenche a tabela com os dados vindo do banco
            this.adp.Fill(ds.view_spListaUsuarios);

        }

        ///<summary>
        ///recebe o objeto Usuario preenchido e tenta incluir no banco de dados
        ///</summary>
        ///<param name= "usuario"> Objeto usuario</param>
        ///<returns> true / false </returns>

        public bool IncluiUsuario(Usuario usuario)
        {

            this.cmd = new System.Data.SqlClient.SqlCommand("sp_IncluiUsuario", this.ConexaoAtiva);
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //adiciona os paramentros e valores
            this.cmd.Parameters.AddWithValue("@nomeComp", usuario.NomeCompleto);
            this.cmd.Parameters.AddWithValue("@login", usuario.Login);
            this.cmd.Parameters.AddWithValue("@senha", usuario.Senha);
            this.cmd.Parameters.AddWithValue("@admin", usuario.Adm);

          
            //executa o comando sql e verifica o resultado retornando false ou true
            return this.cmd.ExecuteNonQuery() > 0 ? true : false;

        }


        public bool AlteraUsuario(Usuario usuario)
        {
            this.cmd = new System.Data.SqlClient.SqlCommand("sp_alteraUsuario", this.ConexaoAtiva);
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //adiciona os paramentros com valores
            this.cmd.Parameters.AddWithValue("@nomeComp", usuario.NomeCompleto);
            this.cmd.Parameters.AddWithValue("@login", usuario.Login);
            this.cmd.Parameters.AddWithValue("@senha", usuario.Senha);
            this.cmd.Parameters.AddWithValue("@admin", usuario.Adm);
            //id que será alterado
            this.cmd.Parameters.AddWithValue("@id", usuario.Id);

            //executa e trata o retorno
            return cmd.ExecuteNonQuery() > 0 ? true : false;

        }


        ///<summary>
        ///recebe o login e senha do usuario e retorna um objeto Usuario preenchido com as informacoes
        ///</summary>
        ///<param name= "uLogin"> Login cadastrado do bd</param>
        ///<param name= "uSenha"> Senha cadastrada do bd</param>
        ///<returns> Objeto usuario</returns>
        public Usuario GetLogin(string uLogin, string uSenha)
        {
            this.cmd = new System.Data.SqlClient.SqlCommand("sp_login", this.ConexaoAtiva);
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //passa os parametros com valor
            this.cmd.Parameters.AddWithValue("@login", uLogin);
            this.cmd.Parameters.AddWithValue("@senha", uSenha);

            //atribui o resultado da query para o leitor
            this.reader = this.cmd.ExecuteReader();

            //verifica se há linhas no leitor
            if (this.reader.HasRows)
            {
                //faz a leitura da linha
                this.reader.Read();

                //alimenta o objeto usuario com os dados da linha retornada do banco de dados
                this.Id = this.reader.GetInt32(0);
                this.NomeCompleto = this.reader.GetString(1);
                this.Login = this.reader.GetString(2);
                this.Senha = this.reader.GetString(3);
                this.Adm = this.reader.GetBoolean(4);

            }
            this.reader.Close();
            return this;
        }
    }
}