using projetoDenteForte.Classes;
using System;
using System.CodeDom;
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
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
            carregarGrid();
            carregarCbNomePaciente();
            carregarCbNomeFuncionario();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Agenda ag = new Agenda();
            ag.idPaciente = Convert.ToInt32(cbPaciente.SelectedValue.ToString());
            ag.idFuncionario = Convert.ToInt32(cbFuncionario.SelectedValue.ToString());
            ag.data = dtpData.Value;
            ag.hora = dtpHora.Value;
            ag.observacao = txtObservacao.Text;
            ag.cadastrar();
            carregarGrid();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (cbPaciente.Tag != null)
            {
                Agenda ag = new Agenda();

                ag.idFuncionario = Convert.ToInt32(cbFuncionario.SelectedValue.ToString());
                ag.idPaciente = Convert.ToInt32(cbPaciente.SelectedValue.ToString());
                ag.data = dtpData.Value;
                ag.hora = dtpHora.Value;
                ag.observacao = txtObservacao.Text;
                ag.idAgenda = cbPaciente.Tag.ToString();
                ag.atualizar();
                carregarGrid();
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            string id = dtgAgenda.CurrentRow.Cells[5].Value.ToString();
            DialogResult result = MessageBox.Show("Deseja excluir o registro " + id, "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Agenda oAgenda = new Agenda();
                oAgenda.remover(Convert.ToInt32(id));
                carregarGrid();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
           limparControles();
        }

        private void dtgAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dtgAgenda.CurrentRow.Cells[5].Value.ToString();
            Agenda oAgenda = new Agenda();
            oAgenda.consultar(Convert.ToInt32(id));
            
            cbPaciente.SelectedValue = oAgenda.idPaciente.ToString();
            cbFuncionario.SelectedValue = oAgenda.idFuncionario.ToString();

            dtpData.Value = oAgenda.data;
            dtpHora.Value = oAgenda.hora;
            txtObservacao.Text = oAgenda.observacao;

            cbPaciente.Tag = id;

        }
        private void carregarGrid()
        {
            Agenda oAgenda = new Agenda();
            List<Agenda> Lista = oAgenda.Consultar();

            var source = new BindingSource();
            source.DataSource = Lista;

            dtgAgenda.Columns.Clear();
            dtgAgenda.AutoGenerateColumns = false;

            dtgAgenda.Columns.Add("data", "Data da Consulta");
            dtgAgenda.Columns[0].DataPropertyName = "data";

            dtgAgenda.Columns.Add("hora", "Hora da Consulta");
            dtgAgenda.Columns[1].DataPropertyName = "hora";
            dtgAgenda.Columns[1].DefaultCellStyle.Format = "HH:mm";

            dtgAgenda.Columns.Add("paciente", "Nome do Paciente");
            dtgAgenda.Columns[2].DataPropertyName = "nomePaciente";

            dtgAgenda.Columns.Add("funcionario", "Nome do Funcionario");
            dtgAgenda.Columns[3].DataPropertyName = "nomeFuncionario";


            dtgAgenda.Columns.Add("observacao", "Observação");
            dtgAgenda.Columns[4].DataPropertyName = "observacao";

            dtgAgenda.Columns.Add("id", "ID Agenda");
            dtgAgenda.Columns[5].DataPropertyName = "idAgenda";
            
            dtgAgenda.DataSource = Lista;
        }

        private void carregarCbNomePaciente()
        {
            var bdSource = new BindingSource();
            Paciente p = new Paciente();
            bdSource.DataSource = p.Consultar();
            cbPaciente.DataSource = bdSource;
            cbPaciente.DisplayMember = "nomePaciente";
            cbPaciente.ValueMember = "idPaciente";
        }

        private void carregarCbNomeFuncionario()
        {
            var bdSource = new BindingSource();
            Funcionario p = new Funcionario();
            bdSource.DataSource = p.Consultar();
            cbFuncionario.DataSource = bdSource;
            cbFuncionario.DisplayMember = "nomeFuncionario";
            cbFuncionario.ValueMember = "idFuncionario";
        }
        public void limparControles()
        {
            txtObservacao.Text = "";
            txtObservacao.Tag = null;
            cbPaciente.Tag = null;

        }

        private void filtrarCampos()
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[dtgAgenda.DataSource];

            foreach (DataGridViewRow row in dtgAgenda.Rows)
            {
                if (row.Cells["data"].Value.ToString().ToUpper().Contains(txtDataFiltro.Text.ToUpper()) &&
                    row.Cells["hora"].Value.ToString().ToUpper().Contains(txtHoraFiltro.Text.ToUpper()) &&
                    row.Cells["funcionario"].Value.ToString().ToUpper().Contains(txtFuncionarioFiltro.Text.ToUpper()) &&
                    row.Cells["paciente"].Value.ToString().ToUpper().Contains(txtPacienteFiltro.Text.ToUpper())) 
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

        private void txtDataFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrarCampos();
        }

        private void txtHoraFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrarCampos();
        }

        private void txtFuncionarioFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrarCampos();
        }

        private void txtPacienteFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrarCampos();
        }
    }
}
