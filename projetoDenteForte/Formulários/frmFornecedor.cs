using projetoDenteForte.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace projetoDenteForte.Formulários
{
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
            carregarGrid();
        }

        private void carregarGrid()
        {
            Fornecedor oFornecedor = new Fornecedor();
            List<Fornecedor> Lista = oFornecedor.Consultar();

            var source = new BindingSource();
            source.DataSource = Lista;

            dtgFornecedor.Columns.Clear();
            dtgFornecedor.AutoGenerateColumns = false;


            dtgFornecedor.Columns.Add("razao", "Razão Social");
            dtgFornecedor.Columns[0].DataPropertyName = "razaoSocialFornecedor";

            dtgFornecedor.Columns.Add("cnpj", "CNPJ");
            dtgFornecedor.Columns[1].DataPropertyName = "cnpjFornecedor";

            dtgFornecedor.Columns.Add("dataContrato", "Data Contrato");
            dtgFornecedor.Columns[2].DataPropertyName = "dataContratoFornecedor";

            dtgFornecedor.Columns.Add("endereco", "Endereço");
            dtgFornecedor.Columns[3].DataPropertyName = "enderecoFornecedor";

            dtgFornecedor.Columns.Add("cidade", "Cidade");
            dtgFornecedor.Columns[4].DataPropertyName = "cidadeFornecedor";

            dtgFornecedor.Columns.Add("estado", "Estado");
            dtgFornecedor.Columns[5].DataPropertyName = "estadoFornecedor";

            dtgFornecedor.Columns.Add("email", "Email");
            dtgFornecedor.Columns[6].DataPropertyName = "emailFornecedor";

            dtgFornecedor.Columns.Add("telefone", "Telefone");
            dtgFornecedor.Columns[7].DataPropertyName = "telefoneFornecedor";

            dtgFornecedor.Columns.Add("tipo", "Tipo Fornecedor");
            dtgFornecedor.Columns[8].DataPropertyName = "tipoFornecedor";

            dtgFornecedor.Columns.Add("id", "ID");
            dtgFornecedor.Columns[9].DataPropertyName = "idFornecedor";

            dtgFornecedor.DataSource = Lista;
        }
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Validacao v = new Validacao();
            if (v.campoVazio(txtRazaoSocial, "\"Razão Social \""))
                return;
            if (v.campoVazio(txtCnpj, "\"CNPJ\""))
                return;
            if (v.campoVazio(txtTelefoneFornecedor, "\"Telefone\""))
                return;
            if (v.campoVazio(txtEnderecoFornecedor, "\"Endereo\""))
                return;
            if (v.campoVazio(txtCidadeFornecedor, "\"Cidade\""))
                return;
            if (v.campoVazio(txtEstadoFornecedor, "\"Estado\""))
                return;
            if (v.campoVazio(txtEmailFornecedor, "\"Email\""))
                return;
            if (v.campoVazio(txtTipoFornecedor, "\"Tipo\""))
                return;

            Fornecedor f = new Fornecedor();
            f.razaoSocialFornecedor = txtRazaoSocial.Text;
            f.cnpjFornecedor = txtCnpj.Text;
            f.dataContratoFornecedor = dtpDataContratoFornecedor.Value;
            f.telefoneFornecedor = txtTelefoneFornecedor.Text;
            f.enderecoFornecedor = txtEnderecoFornecedor.Text;
            f.cidadeFornecedor = txtCidadeFornecedor.Text;
            f.estadoFornecedor = txtEstadoFornecedor.Text;
            f.emailFornecedor = txtEmailFornecedor.Text;
            f.tipoFornecedor = txtTipoFornecedor.Text;

            f.cadastrar();
            carregarGrid();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            if (txtRazaoSocial.Tag != null)
            {
                string id = dtgFornecedor.CurrentRow.Cells[9].Value.ToString();

                Fornecedor o = new Fornecedor();
                o.razaoSocialFornecedor = txtRazaoSocial.Text;
                o.cnpjFornecedor = txtCnpj.Text;
                o.dataContratoFornecedor = dtpDataContratoFornecedor.Value;
                o.telefoneFornecedor = txtTelefoneFornecedor.Text;
                o.enderecoFornecedor = txtEnderecoFornecedor.Text;
                o.cidadeFornecedor = txtCidadeFornecedor.Text;
                o.estadoFornecedor = txtEstadoFornecedor.Text;
                o.emailFornecedor = txtEmailFornecedor.Text;
                o.tipoFornecedor = txtTipoFornecedor.Text;
                o.idFornecedor = txtRazaoSocial.Tag.ToString();

                DialogResult result = MessageBox.Show("Deseja atualizar esse registro " + id, "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    o.atualizar(Convert.ToInt32(id));
                    carregarGrid();
                }
            }
        }
        private void btRemover_Click(object sender, EventArgs e)
        {
            string id = dtgFornecedor.CurrentRow.Cells[9].Value.ToString();

            DialogResult result = MessageBox.Show("Deseja excluir o registro " + id, "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Fornecedor oFornecedor = new Fornecedor();
                oFornecedor.remover(Convert.ToInt32(id));
                carregarGrid();
            }
        }
        
        private void dtgFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dtgFornecedor.CurrentRow.Cells[9].Value.ToString();
            Fornecedor oFornecedor = new Fornecedor();
            oFornecedor.consultar(Convert.ToInt32(id));

            txtRazaoSocial.Text = oFornecedor.razaoSocialFornecedor;
            txtRazaoSocial.Tag = oFornecedor.idFornecedor.ToString();
            txtCnpj.Text = oFornecedor.cnpjFornecedor;
            dtpDataContratoFornecedor.Value = oFornecedor.dataContratoFornecedor;
            txtEnderecoFornecedor.Text = oFornecedor.enderecoFornecedor;
            txtCidadeFornecedor.Text = oFornecedor.cidadeFornecedor;
            txtEstadoFornecedor.Text = oFornecedor.estadoFornecedor;
            txtTelefoneFornecedor.Text = oFornecedor.telefoneFornecedor;
            txtEmailFornecedor.Text = oFornecedor.emailFornecedor;
            txtTipoFornecedor.Text = oFornecedor.tipoFornecedor;
        }

        private void txtbNomePesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[dtgFornecedor.DataSource];

            foreach (DataGridViewRow row in dtgFornecedor.Rows)
            {
                if (row.Cells["razao"].Value.ToString().ToUpper().Contains(txtbNomePesquisa.Text.ToString().ToUpper()))
                {
                    row.Visible = true;
                }
                else
                {
                    cm.SuspendBinding();
                    row.Visible = false;
                    cm.ResumeBinding();
                }
            }
        }
        public void limpaControles()
        {
            txtRazaoSocial.Text = "";
            txtRazaoSocial.Tag = null;
            txtCnpj.Text = "";
            txtCnpj.Tag = null;
            txtEnderecoFornecedor.Text = "";
            txtEnderecoFornecedor.Tag = null;
            txtCidadeFornecedor.Text = "";
            txtCidadeFornecedor.Tag = null;
            txtEstadoFornecedor.Text = "";
            txtEstadoFornecedor.Tag = null;
            txtTelefoneFornecedor.Text = "";
            txtEmailFornecedor.Text = "";
            txtTipoFornecedor.Text = "";
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaControles();
        }
    }
}
