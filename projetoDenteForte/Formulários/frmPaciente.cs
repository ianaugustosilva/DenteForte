using projetoDenteForte.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoDenteForte.Formulários
{
    public partial class frmPaciente : Form
    {
        public frmPaciente()
        {
            InitializeComponent();
            carregarGrid();
            carregarCbConvenio();
            carregarCbSexo();
        }

        private void carregarGrid()
        {
            Paciente oPaciente = new Paciente();
            List<Paciente> Lista = oPaciente.Consultar();

            var source = new BindingSource();
            source.DataSource = Lista;

            dtgPaciente.Columns.Clear();
            dtgPaciente.AutoGenerateColumns = false;

            dtgPaciente.Columns.Add("nome", "Nome");
            dtgPaciente.Columns[0].DataPropertyName = "nomePaciente";

            dtgPaciente.Columns.Add("rg", "RG");
            dtgPaciente.Columns[1].DataPropertyName = "rgPaciente";

            dtgPaciente.Columns.Add("cpf", "CPF");
            dtgPaciente.Columns[2].DataPropertyName = "cpfPaciente";

            dtgPaciente.Columns.Add("datanascimento", "Data de Nascimento");
            dtgPaciente.Columns[3].DataPropertyName = "nascimentoPaciente";

            dtgPaciente.Columns.Add("endereco", "Endereço");
            dtgPaciente.Columns[4].DataPropertyName = "enderecoPaciente";

            dtgPaciente.Columns.Add("cidade", "Cidade");
            dtgPaciente.Columns[5].DataPropertyName = "cidadePaciente";

            dtgPaciente.Columns.Add("estado", "Estado");
            dtgPaciente.Columns[6].DataPropertyName = "estadoPaciente";

            dtgPaciente.Columns.Add("email", "E-mail");
            dtgPaciente.Columns[7].DataPropertyName = "emailPaciente";

            dtgPaciente.Columns.Add("telefone", "Telefone");
            dtgPaciente.Columns[8].DataPropertyName = "telefonePaciente";

            dtgPaciente.Columns.Add("celular", "Celular");
            dtgPaciente.Columns[9].DataPropertyName = "celularPaciente";

            dtgPaciente.Columns.Add("sexo", "Sexo");
            dtgPaciente.Columns[10].DataPropertyName = "sexoPaciente";

            dtgPaciente.Columns.Add("convenio", "Convênio");
            dtgPaciente.Columns[11].DataPropertyName = "idPacienteConvenio";

            dtgPaciente.Columns.Add("id", "ID");
            dtgPaciente.Columns[12].DataPropertyName = "idPaciente";

            dtgPaciente.DataSource = Lista;


        }

        private void dtgPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dtgPaciente.CurrentRow.Cells[12].Value.ToString();
            Paciente oPaciente = new Paciente();
            oPaciente.consultar(Convert.ToInt32(id));

            txtNome.Text = oPaciente.nomePaciente;
            txtNome.Tag = id;

            txtRG.Text = oPaciente.rgPaciente;
            txtCpf.Text = oPaciente.cpfPaciente;
            dtpDataNascimento.Value = oPaciente.nascimentoPaciente;
            txtEndereco.Text = oPaciente.enderecoPaciente;
            txtCidade.Text = oPaciente.cidadePaciente;
            txtEstado.Text = oPaciente.estadoPaciente;
            txtTelefone.Text = oPaciente.telefonePaciente;
            txtCelular.Text = oPaciente.celularPaciente;
            txtEmail.Text = oPaciente.emailPaciente;
            cbSexo.SelectedValue = oPaciente.sexoPaciente;
            cbConvenio.SelectedValue = Convert.ToInt32(oPaciente.idPacienteConvenio);
        }


        private void btnAtualizar_Click(object sender, EventArgs e)
        {
          
            if (txtNome.Tag != null)
            {
                string id = dtgPaciente.CurrentRow.Cells[12].Value.ToString();

                Paciente o = new Paciente();
                o.nomePaciente = txtNome.Text;
                o.rgPaciente = txtRG.Text;
                o.cpfPaciente = txtCpf.Text;
                o.nascimentoPaciente = dtpDataNascimento.Value;
                o.enderecoPaciente = txtEndereco.Text;
                o.cidadePaciente = txtCidade.Text;
                o.estadoPaciente = txtEstado.Text;
                o.emailPaciente = txtEmail.Text;
                o.telefonePaciente = txtTelefone.Text;
                o.celularPaciente = txtCelular.Text;
                o.sexoPaciente = cbSexo.SelectedValue.ToString();
                o.idPacienteConvenio = cbConvenio.SelectedValue.ToString();
                o.idPaciente = txtNome.Tag.ToString();

                DialogResult result = MessageBox.Show("Deseja atualizar o registro " + id, "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    o.atualizar();
                    carregarGrid();
                }
            }   
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            string id = dtgPaciente.CurrentRow.Cells[12].Value.ToString();

            DialogResult result = MessageBox.Show("Deseja excluir o registro " + id, "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            //o.idPaciente = txtNome.Tag.ToString
            {
                Paciente oPaciente = new Paciente();
                oPaciente.remover(Convert.ToInt32(id));
                carregarGrid();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            Validacao v = new Validacao();

            if (v.campoVazio(txtNome, "\"Nome\""))
                return;
            if (v.campoVazio(txtRG, "\"RG\""))
                return;
            if (v.campoVazio(txtCpf, "\"CPF\""))
                return;
            if (v.campoVazio(txtEndereco, "\"Endereço\""))
                return;
            if (v.campoVazio(txtCidade, "\"Cidade\""))
                return;
            if (v.campoVazio(txtEstado, "\"Estado\""))
                return;
            if (v.campoVazio(txtEmail, "\"Email\""))
                return;
            if (v.campoVazio(txtTelefone, "\"Telefone\""))
                return;
            if (v.campoVazio(txtCelular, "\"Celular\""))
                return;

                Paciente p = new Paciente();
                p.nomePaciente = txtNome.Text;
                p.rgPaciente = txtRG.Text;
                p.cpfPaciente = txtCpf.Text;
                p.nascimentoPaciente = dtpDataNascimento.Value;
                p.cidadePaciente = txtCidade.Text;
                p.enderecoPaciente = txtEndereco.Text;
                p.estadoPaciente = txtEstado.Text;
                p.emailPaciente = txtEmail.Text;
                p.telefonePaciente = txtTelefone.Text;
                p.celularPaciente = txtCelular.Text;
                p.sexoPaciente = cbSexo.SelectedValue.ToString();
                p.idPacienteConvenio = cbConvenio.SelectedValue.ToString();

                p.cadastrar();
                carregarGrid();
        }
        
        private void carregarCbConvenio()
        {
            var bdSource = new BindingSource();
            Convenio o = new Convenio();
            bdSource.DataSource = o.Consultar();
            cbConvenio.DataSource = bdSource;
            cbConvenio.DisplayMember = "razaoSocialConvenio";
            cbConvenio.ValueMember = "idConvenio";
        }

        private void carregarCbSexo()
        {
            Dictionary<string, string> sexo = new Dictionary<string, string>();
            sexo.Add("M", "Masculino");
            sexo.Add("F", "Feminino");
            cbSexo.DataSource = new BindingSource(sexo, null);
            cbSexo.DisplayMember = "Value";
            cbSexo.ValueMember = "Key";
        }

        private void limpaControles()
        {
            txtNome.Text = "";
            txtNome.Tag = null;
            txtRG.Text = "";
            txtRG.Tag = null;
            txtCpf.Text = "";
            txtCpf.Tag = null;
            txtEndereco.Text = "";
            txtEndereco.Tag = null;
            txtCidade.Text = "";
            txtCidade.Tag = null;
            txtEstado.Text = "";
            txtEstado.Tag = null;
            txtEmail.Text = "";
            txtEmail.Tag = null;
            txtTelefone.Text = "";
            txtTelefone.Tag = null;
            txtCelular.Text = "";
            txtCelular.Tag = null;

        }

        private void txtbNomePesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[dtgPaciente.DataSource];

            foreach (DataGridViewRow row in dtgPaciente.Rows)
            {
                if (row.Cells["Nome"].Value.ToString().ToUpper().Contains(txtbNomePesquisa.Text.ToString().ToUpper()))
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaControles();
        }
    }
}