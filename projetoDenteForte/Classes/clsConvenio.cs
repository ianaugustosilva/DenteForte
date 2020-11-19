using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetoDenteForte.Classes
{
    class Convenio
    {
        public string razaoSocialConvenio { get; set; }
        public string cnpjConvenio { get; set; }
        public DateTime dataContratoConvenio { get; set; }
        public string enderecoConvenio { get; set; }
        public string cidadeConvenio { get; set; }
        public string estadoConvenio { get; set; }
        public string emailConvenio { get; set; }
        public string telefoneConvenio { get; set; }
        public int idConvenio { get; set; }

        private Conexao oConexao = new Conexao();

        public void cadastrar()
        {
            string sql = "INSERT INTO tb_convenio (tb_convenio_razao_social, tb_convenio_cnpj, tb_convenio_data_contrato, tb_convenio_endereco," +
                                                   "tb_convenio_cidade, tb_convenio_estado, tb_convenio_email, tb_convenio_telefone) " +
                                                   "VALUES ('" + this.razaoSocialConvenio + "'," +
                                                   "'" + this.cnpjConvenio + "'," +
                                                   "'" + this.dataContratoConvenio.ToString("yyyy-MM-dd") + "'," +
                                                   "'" + this.enderecoConvenio + "'," +
                                                   "'" + this.cidadeConvenio + "'," +
                                                   "'" + this.estadoConvenio + "'," +
                                                   "'" + this.emailConvenio + "'," +
                                                   "'" + this.telefoneConvenio +"')";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = oConexao.conectar();
                cmd.ExecuteNonQuery();
                oConexao.desconectar();
                MessageBox.Show("Cadastro realizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void atualizar(int v)
        {
            String sql = "update tb_convenio " +
                          "set tb_convenio_razao_social ='" + this.razaoSocialConvenio + "'," +
                          "tb_convenio_cnpj             ='" + this.cnpjConvenio + "'," +
                          "tb_convenio_data_contrato    ='" + this.dataContratoConvenio.ToString("yyyy-MM-dd") + "'," +
                          "tb_convenio_cidade           ='" + this.cidadeConvenio + "'," +
                          "tb_convenio_estado           ='" + this.estadoConvenio + "'," +
                          "tb_convenio_endereco         ='" + this.enderecoConvenio + "'," +
                          "tb_convenio_email            ='" + this.emailConvenio + "'," +
                          "tb_convenio_telefone         ='" + this.telefoneConvenio + "'" +
                          "where tb_convenio_id         ='" + this.idConvenio + "'";

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
            string sql = "DELETE FROM tb_convenio WHERE tb_convenio_id = " + id.ToString();
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

        public void consultar(int idConvenio)
        {
            List<Convenio> Lista = new List<Convenio>();

            string sql = "SELECT [tb_convenio_razao_social]," +
                                "[tb_convenio_cnpj],[tb_convenio_data_contrato]," +
                                "[tb_convenio_endereco],[tb_convenio_cidade]," +
                                "[tb_convenio_estado],[tb_convenio_email]," +
                                "[tb_convenio_telefone],[tb_convenio_id]" +
                                 "FROM [tb_convenio] WHERE [tb_convenio_id] = " + idConvenio.ToString();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = oConexao.conectar();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                this.razaoSocialConvenio = reader[0].ToString();
                this.cnpjConvenio = reader[1].ToString();
                this.dataContratoConvenio = DateTime.Parse(reader[2].ToString());
                this.enderecoConvenio = reader[3].ToString();
                this.cidadeConvenio = reader[4].ToString();
                this.estadoConvenio = reader[5].ToString();
                this.emailConvenio = reader[6].ToString();
                this.telefoneConvenio = reader[7].ToString();
                this.idConvenio = Convert.ToInt32(reader[8].ToString());
                reader.Close();
                oConexao.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<Convenio> Consultar()
        {
            List<Convenio> Lista = new List<Convenio>();

            string sql = "SELECT * FROM tb_convenio";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = oConexao.conectar();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Convenio o = new Convenio();
                    o.razaoSocialConvenio = reader[0].ToString();
                    o.cnpjConvenio = reader[1].ToString();
                    o.dataContratoConvenio = DateTime.Parse(reader[2].ToString());
                    o.enderecoConvenio = reader[3].ToString();
                    o.cidadeConvenio = reader[4].ToString();
                    o.estadoConvenio = reader[5].ToString();
                    o.emailConvenio = reader[6].ToString();
                    o.telefoneConvenio = reader[7].ToString();
                    o.idConvenio = Convert.ToInt32(reader[8].ToString());
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
