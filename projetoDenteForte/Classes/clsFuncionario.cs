using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace projetoDenteForte.Classes
{
    class Funcionario
    {
        public string nomeFuncionario { get; set; }
        public string rgFuncionario { get; set; }
        public string cpfFuncionario { get; set; }
        public DateTime nascimentoFuncionario { get; set; }
        public string enderecoFuncionario { get; set; }
        public string cidadeFuncionario { get; set; }
        public string estadoFuncionario { get; set; }
        public string emailFuncionario { get; set; }
        public string telefoneFuncionario { get; set; }
        public string celularFuncionario { get; set; }
        public string sexoFuncionario { get; set; }
        public string idFuncionario { get; set; }
        public Usuario oUsuario { get; set; }

        private Conexao oConexao = new Conexao();


        public void cadastrar()
        {
            string sql = "INSERT INTO tb_funcionario (tb_funcionario_nome, tb_funcionario_rg, tb_funcionario_cpf, tb_funcionario_nascimento," +
                                                     "tb_funcionario_endereco, tb_funcionario_cidade, tb_funcionario_estado, tb_funcionario_email," +
                                                     "tb_funcionario_telefone, tb_funcionario_celular, tb_funcionario_sexo)" +
                                              "VALUES(" +
                                              "'" + this.nomeFuncionario       + "'," +
                                              "'" + this.rgFuncionario         + "'," +
                                              "'" + this.cpfFuncionario        + "'," +
                                              "'" + this.nascimentoFuncionario.ToString("yyyy-MM-dd") + "'," +
                                              "'" + this.enderecoFuncionario   + "'," +
                                              "'" + this.cidadeFuncionario     + "'," +
                                              "'" + this.estadoFuncionario     + "'," +
                                              "'" + this.emailFuncionario      + "'," +
                                              "'" + this.telefoneFuncionario   + "'," +
                                              "'" + this.celularFuncionario    + "'," +
                                              "'" + this.sexoFuncionario       + "')";
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = oConexao.conectar();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!");
                oConexao.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void atualizar()
        {
            String sql = "update tb_funcionario " +
               "set tb_funcionario_nome   = '" + this.nomeFuncionario + "', " +
               "tb_funcionario_rg         = '" + this.rgFuncionario + "', " +
               "tb_funcionario_cpf        = '" + this.cpfFuncionario + "', " +
               "tb_funcionario_nascimento = '" + this.nascimentoFuncionario.ToString("yyyy-MM-dd") + "', " +
               "tb_funcionario_endereco   = '" + this.enderecoFuncionario + "', " +
               "tb_funcionario_cidade     = '" + this.cidadeFuncionario + "', " +
               "tb_funcionario_estado     = '" + this.estadoFuncionario + "', " +
               "tb_funcionario_email      = '" + this.emailFuncionario + "', " +
               "tb_funcionario_telefone   = '" + this.telefoneFuncionario + "', " +
               "tb_funcionario_celular    = '" + this.celularFuncionario + "', " +
               "tb_funcionario_sexo       = '" + this.sexoFuncionario + "' " +
               "where tb_funcionario_id   = '" + this.idFuncionario + "'";

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
            string sql = "DELETE FROM tb_funcionario WHERE tb_funcionario_id = " + id.ToString();
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
            string sql = "SELECT tb_funcionario_nome, tb_funcionario_rg, tb_funcionario_cpf, tb_funcionario_nascimento, tb_funcionario_endereco, " +
                                                       "tb_funcionario_cidade, tb_funcionario_estado, tb_funcionario_email, tb_funcionario_telefone," +
                                                       "tb_funcionario_celular, tb_funcionario_sexo, tb_funcionario_id " +
                                                       "FROM tb_funcionario WHERE tb_funcionario_id = " + id.ToString();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = oConexao.conectar();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                this.nomeFuncionario = reader[0].ToString();
                this.rgFuncionario = reader[1].ToString();
                this.cpfFuncionario = reader[2].ToString();
                this.nascimentoFuncionario = DateTime.Parse(reader[3].ToString());
                this.enderecoFuncionario = reader[4].ToString();
                this.cidadeFuncionario = reader[5].ToString();
                this.estadoFuncionario = reader[6].ToString();
                this.emailFuncionario = reader[7].ToString();
                this.telefoneFuncionario = reader[8].ToString();
                this.celularFuncionario = reader[9].ToString();
                this.sexoFuncionario = reader[10].ToString();
                this.idFuncionario = reader[11].ToString();
                reader.Close();
                oConexao.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<Funcionario> Consultar() //retorna uma lista de objetos Funcionario
        {
            List<Funcionario> Lista = new List<Funcionario>();

            string sql = "SELECT * from tb_funcionario";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = oConexao.conectar();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Funcionario o = new Funcionario();
                    o.nomeFuncionario = reader[0].ToString();
                    o.rgFuncionario = reader[1].ToString();
                    o.cpfFuncionario = reader[2].ToString();
                    o.nascimentoFuncionario = DateTime.Parse(reader[3].ToString());
                    o.enderecoFuncionario = reader[4].ToString();
                    o.cidadeFuncionario = reader[5].ToString();
                    o.estadoFuncionario = reader[6].ToString();
                    o.emailFuncionario = reader[7].ToString();
                    o.telefoneFuncionario = reader[8].ToString();
                    o.celularFuncionario = reader[9].ToString();
                    o.sexoFuncionario = reader[10].ToString();
                    o.idFuncionario = reader[11].ToString();
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




