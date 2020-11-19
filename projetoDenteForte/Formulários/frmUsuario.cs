using projetoDenteForte.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoDenteForte
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
            carregarGrid();
        }
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario o = new Usuario();
            o.usuario = txtUsuario.Text;
            o.senha = txtSenha.Text;
            o.cadastrar();
            carregarGrid();
        }

        private void carregarGrid() {
            Usuario oUsuario = new Usuario();
            List<Usuario> Lista = oUsuario.consultar();

            // Como alimentar uma datagrid
            var source = new BindingSource();
            source.DataSource = Lista;
            dtgUsuario.Columns.Clear();
            dtgUsuario.AutoGenerateColumns = false;

            dtgUsuario.Columns.Add("id", "id");
            dtgUsuario.Columns[0].DataPropertyName = "idUsuario";

            dtgUsuario.Columns.Add("usuario", "Usuário");
            dtgUsuario.Columns[1].DataPropertyName = "usuario";

            dtgUsuario.DataSource = Lista;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string id = dtgUsuario.CurrentRow.Cells[0].Value.ToString();

            DialogResult result = MessageBox.Show("Deseja excluir o registro " + id, "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Usuario oUsuario = new Usuario();
                oUsuario.remover(Convert.ToInt32(id));
                carregarGrid();
            }            
        }

        private void dtgUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dtgUsuario.CurrentRow.Cells[0].Value.ToString();
            Usuario oUsuario = new Usuario();
            oUsuario.consultar(Convert.ToInt32(id));

            txtUsuario.Text = oUsuario.usuario;
            txtUsuario.Tag = oUsuario.idUsuario;
            txtSenha.Text = oUsuario.senha;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Tag != null){

                string id = dtgUsuario.CurrentRow.Cells[0].Value.ToString();

                Usuario o = new Usuario();
                o.usuario = txtUsuario.Text;
                o.senha = txtSenha.Text;
                o.idUsuario = txtUsuario.Tag.ToString();

                DialogResult result = MessageBox.Show("Deseja atualizar o registro " + id, "Confirmation", MessageBoxButtons.YesNo);
                if(result ==DialogResult.Yes)
                {
                    o.atualizar(Convert.ToInt32(id));
                    carregarGrid();
                }
            }
        }
    }
}
