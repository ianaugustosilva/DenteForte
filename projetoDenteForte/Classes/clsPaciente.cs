using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoDenteForte.Classes
{
    public class Paciente
    {
        public string nomePaciente { get; set; }
        public string rgPaciente { get; set; }
        public string cpfPaciente { get; set; }
        public DateTime nascimentoPaciente { get; set; }
        public string enderecoPaciente { get; set; }
        public string cidadePaciente { get; set; }
        public string estadoPaciente { get; set; }
        public string emailPaciente { get; set; }
        public string telefonePaciente { get; set; }
        public string celularPaciente { get; set; }
        public string sexoPaciente { get; set; }
        public string idPacienteConvenio { get; set; }
        public string idPaciente { get; set; }

        private Conexao oConexao = new Conexao();

        public void cadastrar()
        {
            
            string sql = "INSERT INTO tb_paciente (tb_paciente_nome, tb_paciente_rg, tb_paciente_cpf, tb_paciente_nascimento, tb_paciente_endereco, " +
                                                  "tb_paciente_cidade, tb_paciente_estado, tb_paciente_email, tb_paciente_telefone, tb_paciente_celular," +
                                                  "tb_paciente_sexo, tb_paciente_id_convenio) " +
                                                  "VALUES ('" + this.nomePaciente + "'," +
                                                  "'" + this.rgPaciente + "'," +
                                                  "'" + this.cpfPaciente + "'," +
                                                  "'" + this.nascimentoPaciente.ToString("yyyy-MM-dd") + "'," +
                                                  "'" + this.enderecoPaciente + "'," +
                                                  "'" + this.cidadePaciente + "'," +
                                                  "'" + this.estadoPaciente + "'," +
                                                  "'" + this.emailPaciente + "'," +
                                                  "'" + this.telefonePaciente + "'," +
                                                  "'" + this.celularPaciente + "'," +
                                                  "'" + this.sexoPaciente + "'," +
                                                  "'" + this.idPacienteConvenio + "')";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = oConexao.conectar();
                cmd.ExecuteNonQuery();
                oConexao.desconectar();
                MessageBox.Show("Registro cadastrado", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void atualizar()
        {
            string sql = "update tb_paciente " +
                "set tb_paciente_nome   = '"+ this.nomePaciente+"', " +
                "tb_paciente_rg         = '"+ this.rgPaciente+"', " +
                "tb_paciente_cpf        = '"+ this.cpfPaciente+"', " +
                "tb_paciente_nascimento = '"+ this.nascimentoPaciente.ToString("yyyy-MM-dd")+"', " +
                "tb_paciente_endereco   = '"+ this.enderecoPaciente+"', " +
                "tb_paciente_cidade     = '"+ this.cidadePaciente+"', " +
                "tb_paciente_estado     = '"+ this.estadoPaciente+"', " +
                "tb_paciente_email      = '"+ this.emailPaciente+"', " +
                "tb_paciente_telefone   = '"+ this.telefonePaciente+"', " +
                "tb_paciente_celular    = '"+ this.celularPaciente+"', " +
                "tb_paciente_sexo       = '"+ this.sexoPaciente+"', " +
                "tb_paciente_id_convenio ='"+ this.idPacienteConvenio+"' " +
                "where tb_paciente_id    ='"+ this.idPaciente+"'";

            
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
            string sql = "DELETE FROM tb_paciente WHERE tb_paciente_id = " + id.ToString();
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
            string sql = "SELECT tb_paciente_nome, tb_paciente_rg, tb_paciente_cpf, tb_paciente_nascimento, tb_paciente_endereco, " +
                                                  " tb_paciente_cidade, tb_paciente_estado, tb_paciente_email, tb_paciente_telefone," +
                                                  " tb_paciente_celular, tb_paciente_sexo, tb_paciente_id_convenio " +
                                                  " FROM tb_paciente WHERE tb_paciente_id = " + id.ToString();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = oConexao.conectar();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                this.nomePaciente = reader[0].ToString();
                this.rgPaciente = reader[1].ToString();
                this.cpfPaciente = reader[2].ToString();
                this.nascimentoPaciente = DateTime.Parse(reader[3].ToString());
                this.enderecoPaciente = reader[4].ToString();
                this.cidadePaciente = reader[5].ToString();
                this.estadoPaciente = reader[6].ToString();
                this.emailPaciente = reader[7].ToString();
                this.telefonePaciente = reader[8].ToString();
                this.celularPaciente = reader[9].ToString();
                this.sexoPaciente = reader[10].ToString();
                this.idPacienteConvenio = reader[11].ToString();

                reader.Close();
                oConexao.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Paciente> Consultar()
        {
            List<Paciente> Lista = new List<Paciente>();

            string sql = "SELECT * from tb_paciente";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = oConexao.conectar();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Paciente o = new Paciente();
                    o.nomePaciente = reader[0].ToString();
                    o.rgPaciente = reader[1].ToString();
                    o.cpfPaciente = reader[2].ToString();
                    o.nascimentoPaciente = DateTime.Parse(reader[3].ToString());
                    o.enderecoPaciente = reader[4].ToString();
                    o.cidadePaciente = reader[5].ToString();
                    o.estadoPaciente = reader[6].ToString();
                    o.emailPaciente = reader[7].ToString();
                    o.telefonePaciente = reader[8].ToString();
                    o.celularPaciente = reader[9].ToString();
                    o.sexoPaciente = reader[10].ToString();
                    o.idPacienteConvenio = reader[11].ToString();
                    o.idPaciente = reader[12].ToString();
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