using projetoDenteForte.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoDenteForte.Formulários
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
            carregarGrid();
            carregarCbSexo();
        }

        private void carregarGrid()
        {
            Funcionario oFuncionario = new Funcionario();
            List<Funcionario> Lista = oFuncionario.Consultar();

            var source = new BindingSource();
            source.DataSource = Lista;
            dtgFuncionario.AutoGenerateColumns = false;

            dtgFuncionario.Columns.Add("nome", "Nome");
            dtgFuncionario.Columns[0].DataPropertyName = "nomeFuncionario";

            dtgFuncionario.Columns.Add("rg", "RG");
            dtgFuncionario.Columns[1].DataPropertyName = "rgFuncionario";

            dtgFuncionario.Columns.Add("cpf", "CPF");
            dtgFuncionario.Columns[2].DataPropertyName = "cpfFuncionario";

            dtgFuncionario.Columns.Add("datanascimento", "Data Nascimento");
            dtgFuncionario.Columns[3].DataPropertyName = "nascimentoFuncionario";

            dtgFuncionario.Columns.Add("endereco", "Endereco");
            dtgFuncionario.Columns[4].DataPropertyName = "enderecoFuncionario";

            dtgFuncionario.Columns.Add("cidade", "Cidade");
            dtgFuncionario.Columns[5].DataPropertyName = "cidadeFuncionario";

            dtgFuncionario.Columns.Add("estado", "Estado");
            dtgFuncionario.Columns[6].DataPropertyName = "estadoFuncionario";

            dtgFuncionario.Columns.Add("email", "Email");
            dtgFuncionario.Columns[7].DataPropertyName = "emailFuncionario";

            dtgFuncionario.Columns.Add("telefone", "Telefone");
            dtgFuncionario.Columns[8].DataPropertyName = "telefoneFuncionario";

            dtgFuncionario.Columns.Add("celular", "Celular");
            dtgFuncionario.Columns[9].DataPropertyName = "celularFuncionario";

            dtgFuncionario.Columns.Add("sexo", "Sexo");
            dtgFuncionario.Columns[10].DataPropertyName = "sexoFuncionario";

            dtgFuncionario.Columns.Add("id", "ID");
            dtgFuncionario.Columns[11].DataPropertyName = "idFuncionario";

            dtgFuncionario.DataSource = Lista;

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario fun = new Funcionario();
            fun.nomeFuncionario = txtNomeFuncionario.Text;
            fun.rgFuncionario = txtRGFuncionario.Text;
            fun.cpfFuncionario = txtCpfFuncionario.Text;
            fun.nascimentoFuncionario = dtpDataNascimentoFuncionario.Value;
            fun.enderecoFuncionario = txtEnderecoFuncionario.Text;
            fun.cidadeFuncionario = txtCidadeFuncionario.Text;
            fun.estadoFuncionario = txtEstadoFuncionario.Text;
            fun.emailFuncionario = txtEmailFuncionario.Text;
            fun.telefoneFuncionario = txtTelefoneFuncionario.Text;
            fun.celularFuncionario = txtCelularFuncionario.Text;
            fun.sexoFuncionario = cbSexo.SelectedValue.ToString();
            fun.cadastrar();
            carregarGrid();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtNomeFuncionario.Tag != null)
            {
                string id = dtgFuncionario.CurrentRow.Cells[11].Value.ToString();

                Funcionario o = new Funcionario();
                o.nomeFuncionario = txtNomeFuncionario.Text;
                o.rgFuncionario = txtRGFuncionario.Text;
                o.cpfFuncionario = txtCpfFuncionario.Text;
                o.nascimentoFuncionario = dtpDataNascimentoFuncionario.Value;
                o.enderecoFuncionario = txtEnderecoFuncionario.Text;
                o.cidadeFuncionario = txtCidadeFuncionario.Text;
                o.estadoFuncionario = txtEstadoFuncionario.Text;
                o.emailFuncionario = txtEmailFuncionario.Text;
                o.telefoneFuncionario = txtTelefoneFuncionario.Text;
                o.celularFuncionario = txtCelularFuncionario.Text;
                o.sexoFuncionario = cbSexo.SelectedValue.ToString();
                o.idFuncionario = txtNomeFuncionario.Tag.ToString();

                DialogResult result = MessageBox.Show("Deseja atualizar o registro " + id, "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Funcionario oFuncionario = new Funcionario();
                    oFuncionario.remover(Convert.ToInt32(id));
                    carregarGrid();
                }
            }
        }
        private void btRemover_Click(object sender, EventArgs e)
        {
            string id = dtgFuncionario.CurrentRow.Cells[11].Value.ToString();

            DialogResult result = MessageBox.Show("Deseja excluir o registro " + id, "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Funcionario oFuncionario = new Funcionario();
                oFuncionario.remover(Convert.ToInt32(id));
                carregarGrid();
            }

        }

        private void dtgFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dtgFuncionario.CurrentRow.Cells[11].Value.ToString();
            Funcionario oFuncionario = new Funcionario();
            oFuncionario.consultar(Convert.ToInt32(id));

            txtNomeFuncionario.Text = oFuncionario.nomeFuncionario;
            txtNomeFuncionario.Tag = id;

            txtRGFuncionario.Text = oFuncionario.rgFuncionario;
            txtCpfFuncionario.Text = oFuncionario.cpfFuncionario;
            dtpDataNascimentoFuncionario.Value = oFuncionario.nascimentoFuncionario;
            txtEnderecoFuncionario.Text = oFuncionario.enderecoFuncionario;
            txtCidadeFuncionario.Text = oFuncionario.cidadeFuncionario;
            txtEstadoFuncionario.Text = oFuncionario.estadoFuncionario;
            txtTelefoneFuncionario.Text = oFuncionario.telefoneFuncionario;
            txtCelularFuncionario.Text = oFuncionario.celularFuncionario;
            txtEmailFuncionario.Text = oFuncionario.emailFuncionario;
            cbSexo.SelectedValue = oFuncionario.sexoFuncionario;
            
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
        public void limparControles()
        {
            txtNomeFuncionario.Text = "";
            txtNomeFuncionario.Tag = null;
            txtRGFuncionario.Text = "";
            txtRGFuncionario.Tag = null;
            txtCpfFuncionario.Text = "";
            dtpDataNascimentoFuncionario.Text = "";
            dtpDataNascimentoFuncionario.Tag = null;
            txtEnderecoFuncionario.Text = "";
            txtEnderecoFuncionario.Tag = null;
            txtCidadeFuncionario.Text = "";
            txtCidadeFuncionario.Tag = null;
            txtEstadoFuncionario.Text = "";
            txtEstadoFuncionario.Tag = null;
            txtTelefoneFuncionario.Text = "";
            txtCelularFuncionario.Text = "";
            txtEmailFuncionario.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparControles();
        }

        private void txtbFuncionarioPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[dtgFuncionario.DataSource];

            foreach (DataGridViewRow row in dtgFuncionario.Rows)
            {
                if (row.Cells["Nome"].Value.ToString().ToUpper().Contains(txtbFuncionarioPesquisar.Text.ToString().ToUpper()))
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