using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetoDenteForte.Classes
{
    class Produto
    {
        public string nomeProduto { get; set; }
        public string tipoProduto { get; set; }
        public string classificacaoProduto { get; set; }
        public string descricaoProduto { get; set; }
        public DateTime validadeProduto { get; set; }
        public int quantidadeProduto { get; set; }
        public DateTime dataMovimentacaoProduto { get; set; }
        public string tipoMovimentacaoProduto { get; set; }
        public string idProduto { get; set; }
        public string idFornecedor { get; set; }

        public string fornecedorProduto { get; set; }

        public Fornecedor oFornecedor { get; set; }
        public Produto oProduto { get; set; }

        private Conexao oConexao = new Conexao();

        public void cadastrar()
        {
            string sql = "INSERT INTO tb_produto (tb_produto_nome, tb_produto_tipo, tb_produto_classificacao, tb_produto_descricao," +
                                                 "tb_produto_validade, tb_produto_quantidade, tb_produto_tipo_movimentacao, tb_produto_data_movimentacao," +
                                                 "tb_produto_id_fornecedor)" +
                                                  "VALUES ('" + this.nomeProduto + "'," +
                                                 "'" + this.tipoProduto + "'," +
                                                 "'" + this.classificacaoProduto + "'," +
                                                 "'" + this.descricaoProduto + "'," +
                                                 "'" + this.validadeProduto.ToString("yyyy-MM-dd") + "'," +
                                                 "'" + this.quantidadeProduto.ToString() + "'," +
                                                 "'" + this.tipoMovimentacaoProduto + "'," +
                                                 "'" + this.dataMovimentacaoProduto.ToString("yyyy-MM-dd") + "'," +
                                                 "'" + this.idFornecedor + "')";


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
            string sql = "update tb_produto " +
                    "set tb_produto_nome           = '" + this.nomeProduto + "', " +
                    "tb_produto_tipo               = '" + this.tipoProduto + "', " +
                    "tb_produto_classificacao      = '" + this.classificacaoProduto + "'," +
                    "tb_produto_validade           = '" + this.validadeProduto.ToString("yyyy-MM-dd") + "'," +
                    "tb_produto_quantidade         = '" + this.quantidadeProduto.ToString() + "'," +
                    "tb_produto_tipo_movimentacao  = '" + this.tipoMovimentacaoProduto + "'," +
                    "tb_produto_data_movimentacao  = '" + this.dataMovimentacaoProduto.ToString("yyyy-MM-dd") + "'," +
                    "tb_produto_id_fornecedor      = '" + this.idFornecedor + "'" +
                    "where tb_produto_id           = '" + this.idProduto + "'";

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
            string sql = "DELETE FROM tb_produto WHERE tb_produto_id = " + id.ToString();
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
            string sql = "SELECT tb_produto_nome, " +
                            "tb_produto_tipo," +
                            "tb_produto_classificacao," +
                            "tb_produto_validade, " +
                            "tb_produto_quantidade," +
                            "tb_produto_tipo_movimentacao, " +
                            "tb_produto_data_movimentacao, " +
                            "tb_produto_id_fornecedor, " +
                            "tb_produto_descricao " +
                        " FROM tb_produto WHERE tb_produto_id = " + id.ToString();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            try
            {
                cmd.Connection = oConexao.conectar();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                this.nomeProduto             = reader[0].ToString();
                this.tipoProduto             = reader[1].ToString();
                this.classificacaoProduto    = reader[2].ToString();
                this.validadeProduto         = DateTime.Parse(reader[3].ToString());
                this.quantidadeProduto       = Convert.ToInt32(reader[4].ToString());
                this.tipoMovimentacaoProduto = reader[5].ToString();
                this.dataMovimentacaoProduto = DateTime.Parse(reader[6].ToString());
                this.idFornecedor            = reader[7].ToString();
                this.descricaoProduto        = reader[8].ToString();
                this.idProduto               = id.ToString();

                reader.Close();
                oConexao.desconectar();

                // Carregar Fornecedor
                this.oFornecedor = new Fornecedor();
                this.oFornecedor.consultar(Convert.ToInt32(this.idFornecedor));
                this.fornecedorProduto = this.oFornecedor.razaoSocialFornecedor; // Carrega informações para a grid.

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<Produto> Consultar()
            {
                List<Produto> Lista = new List<Produto>();
                SqlDataReader reader = null;
                string sql = "SELECT * from tb_produto";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                try
                {
                    cmd.Connection = oConexao.conectar();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Produto o = new Produto();
                        o.nomeProduto = reader["tb_produto_nome"].ToString(); //COLOCAR NOME DA coluna da tabela também funciona
                        o.tipoProduto = reader["tb_produto_tipo"].ToString();
                        o.classificacaoProduto = reader["tb_produto_classificacao"].ToString();
                        o.validadeProduto = DateTime.Parse(reader["tb_produto_validade"].ToString());
                        o.quantidadeProduto = Convert.ToInt32(reader["tb_produto_quantidade"].ToString());
                        o.tipoMovimentacaoProduto = reader["tb_produto_tipo_movimentacao"].ToString();
                        o.dataMovimentacaoProduto = DateTime.Parse(reader["tb_produto_data_movimentacao"].ToString());
                        o.idProduto = reader["tb_produto_id"].ToString();
                        o.idFornecedor = reader["tb_produto_id_fornecedor"].ToString();
                        o.descricaoProduto = reader["tb_produto_descricao"].ToString();

                    // Carregar Fornecedor
                    Fornecedor oF = new Fornecedor();
                        oF.consultar(Convert.ToInt32(o.idFornecedor));
                        o.fornecedorProduto = oF.razaoSocialFornecedor; // Carrega informações para a grid.

                        Lista.Add(o);
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

