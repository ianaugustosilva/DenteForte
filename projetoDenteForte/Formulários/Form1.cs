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

namespace projetoDenteForte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Usuario oUsuario = new Usuario();
            List<Usuario> Lista = oUsuario.consultar();

            // Como alimentar uma listbox
            lstUsuario.Items.Clear();
            foreach (Usuario o in Lista) {
                lstUsuario.Items.Add(o.usuario+"|"+o.senha+"|"+o.idUsuario);
            }

            // Como alimentar uma datagrid
            var source = new BindingSource();
            source.DataSource = Lista;
            dtgUsuario.AutoGenerateColumns = false;

            dtgUsuario.Columns.Add("id","id");
            dtgUsuario.Columns[0].DataPropertyName = "idUsuario";

            dtgUsuario.Columns.Add("usuario","Usuário");
            dtgUsuario.Columns[1].DataPropertyName = "usuario";

            dtgUsuario.Columns.Add("senha","Senha");
            dtgUsuario.Columns[2].DataPropertyName = "senha";

            dtgUsuario.DataSource = Lista;
        }
    }
}
