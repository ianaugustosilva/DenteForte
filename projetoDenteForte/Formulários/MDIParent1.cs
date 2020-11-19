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
    public partial class mdiMain : Form
    {
        
        public mdiMain()
        {
            InitializeComponent();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show
            this.Close();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgenda agn = new frmAgenda();
            agn.Show();
        }

        private void convênioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConvenio conv = new frmConvenio();
            conv.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor forn = new frmFornecedor();
            forn.Show();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaciente pac = new frmPaciente();
            pac.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto pro = new frmProduto();
            pro.Show();
        }
        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario user = new frmUsuario();
            user.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario x = new frmFuncionario();
            x.Show();
        }

        private void mdiMain_Load(object sender, EventArgs e)
        {
            using (frmLogin Form = new frmLogin())
            {
                Form.ShowDialog();
                if (Form.DialogResult != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutBox frm = new frmAboutBox();
            frm.ShowDialog();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            frmAboutBox frm = new frmAboutBox();
            frm.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutBox frm = new frmAboutBox();
            frm.ShowDialog();
        }

       private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgenda frm = new frmAgenda();
            frm.ShowDialog();
        }

        private void convenioMenu_Click(object sender, EventArgs e)
        {
            frmConvenio frm = new frmConvenio();
            frm.ShowDialog();
        }

        private void funcionarioMenu_Click(object sender, EventArgs e)
        {
            frmFuncionario frm = new frmFuncionario();
            frm.ShowDialog();
        }

        private void fornecedorMenu_Click(object sender, EventArgs e)
        {
            frmFornecedor frm = new frmFornecedor();
            frm.ShowDialog();
        }

        private void pacienteMenu_Click(object sender, EventArgs e)
        {
            frmPaciente frm = new frmPaciente();
            frm.ShowDialog();
        }

        private void produtoMenu_Click(object sender, EventArgs e)
        {
            frmProduto frm = new frmProduto();
            frm.ShowDialog();
        }

        private void usuarioMenu_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();
            frm.ShowDialog();
        }
    }
}
