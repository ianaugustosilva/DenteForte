using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetoDenteForte.Classes
{
    class Agenda
    {
        public DateTime data { get; set; }
        public DateTime hora { get; set; }
        public int idPaciente { get; set; }
        public int idFuncionario { get; set; }
        public string idAgenda { get; set; }
        public string observacao { get; set; }
        public Paciente oPaciente { get; set; }
        public Funcionario oFuncionario { get; set; }
        public string nomePaciente { get; set; }
        public string nomeFuncionario { get; set; }
        
        private Conexao oConexao = new Conexao();

      
        public void cadastrar()
        {
            string sql = "INSERT INTO tb_agenda (tb_agenda_data, tb_agenda_hora, tb_agenda_id_paciente, tb_agenda_id_funcionario, tb_agenda_observacao)" +
                                                  "VALUES ('" + this.data.ToString("yyyy-MM-dd") + "'," +
                                                 "'" + this.hora.ToString("HH:mm") + "'," +
                                                 "'" + this.idPaciente + "'," +
                                                 "'" + this.idFuncionario + "'," + 
                                                 "'" + this.observacao + "')";
            
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

        public void atualizar()
        {
            String sql = "update tb_agenda " +
                     "set tb_agenda_data   = '"    + this.data.ToString("yyyy-MM-dd") + "', " +
                     "tb_agenda_hora       = '"    + this.hora.ToString("HH:mm") + "', " +
                     "tb_agenda_id_paciente = '"   + this.idPaciente.ToString() + "'," +
                     "tb_agenda_id_funcionario = '"   + this.idFuncionario.ToString() + "'," +
                     "tb_agenda_observacao = '"    + this.observacao.ToString() + "'" +
                     "where tb_agenda_id = '"      + this.idAgenda + "'";

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
            string sql = "DELETE FROM tb_agenda WHERE tb_agenda_id = " + id.ToString();
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
            string sql = "SELECT [tb_agenda_data], " +
                                "[tb_agenda_hora]," +
                                "[tb_agenda_id_paciente]," +
                                "[tb_agenda_id_funcionario], " +
                                "[tb_agenda_observacao]," +
                                "[tb_agenda_id]" +
                                "FROM tb_agenda WHERE tb_agenda_id = " + id.ToString();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = oConexao.conectar();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                this.data = DateTime.Parse(reader["tb_agenda_data"].ToString());
                this.hora = DateTime.Parse(reader["tb_agenda_hora"].ToString());
                this.idPaciente = Convert.ToInt32(reader["tb_agenda_id_paciente"].ToString());
                this.idFuncionario = Convert.ToInt32(reader["tb_agenda_id_funcionario"].ToString());
                this.observacao = reader["tb_agenda_observacao"].ToString();
                this.idAgenda = reader["tb_agenda_id"].ToString();

                reader.Close();
                oConexao.desconectar();

                // Carregar Fornecedor
                //this.oFornecedor = new Fornecedor();
                //this.oFornecedor.consultar(Convert.ToInt32(this.idFornecedor));
                //this.fornecedorProduto = this.oFornecedor.razaoSocialFornecedor; // Carrega informações para a grid.

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public  List<Agenda> Consultar()
        {
            List<Agenda> Lista = new List<Agenda>();
            SqlDataReader reader = null;
            string sql = "SELECT * from tb_agenda";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = oConexao.conectar();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Agenda ag = new Agenda();
                    ag.data = DateTime.Parse(reader["tb_agenda_data"].ToString()); //COLOCAR NOME DA coluna da tabela também funciona
                    ag.hora = DateTime.Parse(reader["tb_agenda_hora"].ToString());
                    ag.idPaciente = Convert.ToInt32(reader["tb_agenda_id_paciente"].ToString());
                    ag.idFuncionario = Convert.ToInt32(reader["tb_agenda_id_funcionario"].ToString());
                    ag.observacao = reader["tb_agenda_observacao"].ToString();
                    ag.idAgenda = reader["tb_agenda_id"].ToString();

                    // Carregar Funcionario
                    Funcionario oF = new Funcionario();
                    oF.consultar(Convert.ToInt32(ag.idFuncionario));
                    ag.nomeFuncionario = oF.nomeFuncionario; // Carrega informações para a grid.


                    // Carregar Paciente ...
                    Paciente oP = new Paciente();
                    oP.consultar(Convert.ToInt32(ag.idPaciente));
                    ag.nomePaciente = oP.nomePaciente; // Carrega informações para a grid.

                    Lista.Add(ag);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader?.Close();
                oConexao?.desconectar();
            }
            return Lista;
        }
    }
}
