using projetoDenteForte.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoDenteForte.Formulários
{
    public partial class frmConvenio : Form
    {
        public frmConvenio()
        {
            InitializeComponent();
            carregarGrid();
        }

        private void carregarGrid()
        {
            Convenio oConvenio = new Convenio();
            List<Convenio> Lista = oConvenio.Consultar();

            var source = new BindingSource();
            source.DataSource = Lista;

            dtgConvenio.Columns.Clear();
            dtgConvenio.AutoGenerateColumns = false;

            dtgConvenio.Columns.Add("id", "id");
            dtgConvenio.Columns[0].DataPropertyName = "idConvenio";

            dtgConvenio.Columns.Add("razãoSocial", "Razão Social");
            dtgConvenio.Columns[1].DataPropertyName = "razaoSocialConvenio";

            dtgConvenio.Columns.Add("cnpjConvenio", "CNPJ Convênio");
            dtgConvenio.Columns[2].DataPropertyName = "cnpjConvenio";

            dtgConvenio.Columns.Add("dataContrato", "Data Contrato");
            dtgConvenio.Columns[3].DataPropertyName = "dataContratoConvenio";

            dtgConvenio.Columns.Add("enderecoConvenio", "Endereço Convênio");
            dtgConvenio.Columns[4].DataPropertyName = "enderecoConvenio";

            dtgConvenio.Columns.Add("cidadeConvenio", "Cidade Convênio");
            dtgConvenio.Columns[5].DataPropertyName = "cidadeConvenio";

            dtgConvenio.Columns.Add("estadoConvenio", "Estado Convênio");
            dtgConvenio.Columns[6].DataPropertyName = "estadoConvenio";

            dtgConvenio.Columns.Add("emailConvenio", "Email Convenio");
            dtgConvenio.Columns[7].DataPropertyName = "emailConvenio";

            dtgConvenio.Columns.Add("telefoneConvenio", "Telefone Convenio");
            dtgConvenio.Columns[8].DataPropertyName = "telefoneConvenio";

            dtgConvenio.DataSource = Lista;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Validacao v = new Validacao();
            if (v.campoVazio(txtRazaoSocial, "\"Razão Social\""))
                return;
            if (v.campoVazio(txtCnpj, "\"CNPJ\""))
                return;
            if (v.campoVazio(txtEnderecoConvenio, "\"Endereço\"")) 
            return;
            if (v.campoVazio(txtCidadeConvenio, "\"Cidade\""))
                return;
            if (v.campoVazio(txtEstadoConvenio, "\"Estado\""))
                return;
            if (v.campoVazio(txtEmailConvenio, "\"Email\""))
                return;
            if (v.campoVazio(txtTelefoneConvenio, "\"Telefone\""))
                return;
            
            Convenio c = new Convenio();
            c.razaoSocialConvenio = txtRazaoSocial.Text;
            c.cnpjConvenio = txtCnpj.Text;
            c.dataContratoConvenio = dtpContrato.Value;
            c.enderecoConvenio = txtEnderecoConvenio.Text;
            c.cidadeConvenio = txtCidadeConvenio.Text;
            c.estadoConvenio = txtEstadoConvenio.Text;
            c.emailConvenio = txtEmailConvenio.Text;
            c.telefoneConvenio = txtTelefoneConvenio.Text; 
            
            c.cadastrar();
            carregarGrid();
          
           
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            
            if (txtRazaoSocial.Tag != null)
            {
                string id = dtgConvenio.CurrentRow.Cells[0].Value.ToString();

                Convenio c = new Convenio();
                c.razaoSocialConvenio = txtRazaoSocial.Text;
                c.cnpjConvenio = txtCnpj.Text;
                c.dataContratoConvenio = dtpContrato.Value;
                c.enderecoConvenio = txtEnderecoConvenio.Text;
                c.cidadeConvenio = txtCidadeConvenio.Text;
                c.estadoConvenio = txtEstadoConvenio.Text;
                c.emailConvenio = txtEmailConvenio.Text;
                c.telefoneConvenio = txtTelefoneConvenio.Text;
                c.idConvenio = Convert.ToInt32(txtRazaoSocial.Tag.ToString());


                DialogResult result = MessageBox.Show("Deseja atualizar esse registro " + id, "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    c.atualizar(Convert.ToInt32(id));
                    carregarGrid();
                }
            }
        }
        private void btRemover_Click(object sender, EventArgs e)
        {
            string id = dtgConvenio.CurrentRow.Cells[0].Value.ToString();

            DialogResult result = MessageBox.Show("Deseja excluir o registro " + id, "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Convenio oConvenio = new Convenio();
                oConvenio.remover(Convert.ToInt32(id));
                carregarGrid();
            }
        }

       private void dtgConvenio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dtgConvenio.CurrentRow.Cells[0].Value.ToString();
            Convenio oConvenio = new Convenio();
            oConvenio.consultar(Convert.ToInt32(id));

            txtRazaoSocial.Text = oConvenio.razaoSocialConvenio;
            txtRazaoSocial.Tag = oConvenio.idConvenio.ToString();
            txtCnpj.Text = oConvenio.cnpjConvenio;
            dtpContrato.Value = oConvenio.dataContratoConvenio;
            txtEnderecoConvenio.Text = oConvenio.enderecoConvenio;
            txtCidadeConvenio.Text = oConvenio.cidadeConvenio;
            txtEstadoConvenio.Text = oConvenio.estadoConvenio;
            txtEmailConvenio.Text = oConvenio.emailConvenio;
            txtTelefoneConvenio.Text = oConvenio.telefoneConvenio;
        }

        public void limparControles()
        {
            txtRazaoSocial.Text = "";
            txtRazaoSocial.Tag = null;
            txtCnpj.Text = "";
            txtCnpj.Tag = null;
            dtpContrato.Text = "";
            dtpContrato.Tag = null;
            txtEnderecoConvenio.Text = "";
            txtEnderecoConvenio.Tag = null;
            txtCidadeConvenio.Text = "";
            txtCidadeConvenio.Tag = null;
            txtEstadoConvenio.Text = "";
            txtEstadoConvenio.Tag = null;
            txtTelefoneConvenio.Text = "";
            txtEmailConvenio.Text = "";
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparControles();
        }

        private void txtbRazaoSocialPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[dtgConvenio.DataSource];

            foreach (DataGridViewRow row in dtgConvenio.Rows)
            {
                if (row.Cells["razãoSocial"].Value.ToString().ToUpper().Contains(txtbRazaoSocialPesquisar.Text.ToString().ToUpper()))
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
    }
}

