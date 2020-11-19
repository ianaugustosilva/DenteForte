using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoDenteForte.Classes
{
    class Usuario
    {
        public string usuario { get; set; }
        public string senha { get; set; }
        public string idUsuario { get; set; }
        public Funcionario oFuncionario { get; set; }

        private Conexao oConexao = new Conexao();
        
        public void cadastrar()
        {
            string sql = "INSERT INTO tb_usuario (tb_usuario_username, tb_usuario_password) " +
                            "VALUES ('" +
                            ""+ this.usuario +"'," +
                            "'"+ this.senha +"')";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = oConexao.conectar();
                cmd.ExecuteNonQuery();
                oConexao.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void atualizar(int id)
        {
            string sql = "UPDATE tb_usuario SET " +
                            " tb_usuario_username = '"+ this.usuario +"'," +
                            " tb_usuario_password = '"+ this.senha + "'" +
                            " WHERE tb_usuario_id = '" + this.idUsuario + "'";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = oConexao.conectar();
                cmd.ExecuteNonQuery();
                oConexao.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void remover(int id)
        {
            string sql = "DELETE FROM tb_usuario WHERE tb_usuario_id = "+id.ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = oConexao.conectar();
                cmd.ExecuteNonQuery();
                oConexao.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void consultar(int id)
        {
            string sql = "SELECT tb_usuario_username, tb_usuario_password, tb_usuario_id FROM tb_usuario WHERE tb_usuario_id = " + id.ToString();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = oConexao.conectar();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                this.usuario = reader[0].ToString();
                this.senha = reader[1].ToString();
                this.idUsuario = reader[2].ToString();
                reader.Close();
                oConexao.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool consultar(string nome, string senha)
        {
            string sql = "SELECT tb_usuario_username, tb_usuario_password, tb_usuario_id FROM tb_usuario WHERE tb_usuario_username = '" + nome.ToString() + "' and tb_usuario_password = '" + senha.ToString() + "'";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = oConexao.conectar();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                this.usuario = reader[0].ToString();
                this.senha = reader[1].ToString();
                this.idUsuario = reader[2].ToString();
                reader.Close();
                oConexao.desconectar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel realizar o Login - Erro: " + ex.Message);
                return false;
            }
        }

        public List<Usuario> consultar()
        {
            List<Usuario> Lista = new List<Usuario>();

            string sql = "SELECT tb_usuario_username, tb_usuario_password, tb_usuario_id FROM tb_usuario";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = oConexao.conectar();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Usuario o = new Usuario();
                    o.usuario = reader[0].ToString();
                    o.senha = reader[1].ToString();
                    o.idUsuario = reader[2].ToString();
                    Lista.Add(o);
                }
                
                reader.Close();
                oConexao.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Lista;
        }
    }
}
