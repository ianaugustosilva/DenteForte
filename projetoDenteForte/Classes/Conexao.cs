using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace projetoDenteForte.Classes
{
    class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            var servidor = ConfigurationManager.AppSettings["db_server"];
            var database = ConfigurationManager.AppSettings["db_database"];
            var usuario = ConfigurationManager.AppSettings["db_user"];
            var senha = ConfigurationManager.AppSettings["db_pass"];
            con.ConnectionString = @"Data Source="+servidor+";Initial Catalog="+database+";Persist Security Info=True;User ID="+usuario+";Password="+senha;
        }

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            { 
                con.Open(); // abre conexão
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            { 
                con.Close(); //fecha conexão
            }
        }
    }
}
