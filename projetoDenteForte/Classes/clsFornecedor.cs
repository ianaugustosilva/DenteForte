using projetoDenteForte.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoDenteForte
{
    public class Fornecedor
    {
        public string razaoSocialFornecedor { get; set; }
        public string cnpjFornecedor { get; set; }
        public DateTime dataContratoFornecedor { get; set; }
        public string enderecoFornecedor { get; set; }
        public string cidadeFornecedor { get; set; }
        public string estadoFornecedor { get; set; }
        public string emailFornecedor { get; set; }
        public string telefoneFornecedor { get; set; }
        public string tipoFornecedor { get; set; }
        public string idFornecedor { get; set; }

        private Conexao oConexao = new Conexao();

        public void cadastrar()
        {
            string sql = "INSERT INTO tb_fornecedor (tb_fornecedor_razao_social, tb_fornecedor_cnpj, tb_fornecedor_data_contrato, tb_fornecedor_endereco," +
                                                    "tb_fornecedor_cidade, tb_fornecedor_estado, tb_fornecedor_email, tb_fornecedor_telefone," +
                                                    "tb_fornecedor_tipo_fornecimento)" +
                                                    "VALUES ('" + this.razaoSocialFornecedor + "'," +
                                                            "'" + this.cnpjFornecedor + "'," +
                                                            "'" + this.dataContratoFornecedor.ToString("yyyy-MM-dd") + "'," +
                                                            "'" + this.enderecoFornecedor + "'," +
                                                            "'" + this.cidadeFornecedor + "'," +
                                                            "'" + this.estadoFornecedor + "'," +
                                                            "'" + this.emailFornecedor + "'," +
                                                            "'" + this.telefoneFornecedor + "'," +
                                                            "'" + this.tipoFornecedor + "')";
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

        public void atualizar(int v)
        {
            string sql = "UPDATE tb_fornecedor " +
              "SET tb_fornecedor_razao_social   = '" + this.razaoSocialFornecedor + "'," +
              "tb_fornecedor_cnpj               = '" + this.cnpjFornecedor + "'," +
              "tb_fornecedor_data_contrato      = '" + this.dataContratoFornecedor.ToString("yyyy-MM-dd") + "'," +
              "tb_fornecedor_endereco           = '" + this.enderecoFornecedor + "'," +
              "tb_fornecedor_cidade             = '" + this.cidadeFornecedor + "'," +
              "tb_fornecedor_estado             = '" + this.estadoFornecedor + "'," +
              "tb_fornecedor_email              = '" + this.emailFornecedor + "'," +
              "tb_fornecedor_telefone           = '" + this.telefoneFornecedor + "'," +
              "tb_fornecedor_tipo_fornecimento  = '" + this.tipoFornecedor + "'" +
              "where tb_fornecedor_id           = '" + this.idFornecedor + "'";

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
            string sql = "DELETE FROM tb_fornecedor WHERE tb_fornecedor_id = " + id.ToString();
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
            List<Fornecedor> Lista = new List<Fornecedor>();

            string sql = "SELECT [tb_fornecedor_razao_social]," +
                                "[tb_fornecedor_cnpj],[tb_fornecedor_data_contrato]," +
                                "[tb_fornecedor_endereco], [tb_fornecedor_cidade], " +
                                "[tb_fornecedor_estado], [tb_fornecedor_email]," +
                                "[tb_fornecedor_telefone], [tb_fornecedor_tipo_fornecimento]," +
                                "[tb_fornecedor_id]" +
                                "FROM [tb_fornecedor] WHERE [tb_fornecedor_id] = " + id.ToString();
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = oConexao.conectar();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                this.razaoSocialFornecedor = reader[0].ToString();
                this.cnpjFornecedor = reader[1].ToString();
                this.dataContratoFornecedor = DateTime.Parse(reader[2].ToString());
                this.enderecoFornecedor = reader[3].ToString();
                this.cidadeFornecedor = reader[4].ToString();
                this.estadoFornecedor = reader[5].ToString();
                this.emailFornecedor = reader[6].ToString();
                this.telefoneFornecedor = reader[7].ToString();
                this.tipoFornecedor = reader[8].ToString();
                this.idFornecedor = reader[9].ToString();
                reader.Close();
                oConexao.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<Fornecedor> Consultar()
        {
            List<Fornecedor> Lista = new List<Fornecedor>();
            string sql = "SELECT * FROM tb_fornecedor";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;

            try
            {
                cmd.Connection = oConexao.conectar();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Fornecedor f = new Fornecedor();
                    f.razaoSocialFornecedor = reader[0].ToString();
                    f.cnpjFornecedor = reader[1].ToString();
                    f.dataContratoFornecedor = DateTime.Parse(reader[2].ToString());
                    f.enderecoFornecedor = reader[3].ToString();
                    f.cidadeFornecedor = reader[4].ToString();
                    f.estadoFornecedor = reader[5].ToString();
                    f.emailFornecedor = reader[6].ToString();
                    f.telefoneFornecedor = reader[7].ToString();
                    f.tipoFornecedor = reader[8].ToString();                    
                    f.idFornecedor = reader[9].ToString();
                    Lista.Add(f);
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
