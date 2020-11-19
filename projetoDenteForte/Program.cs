using DenteForte_v2.Apresentacao;
using projetoDenteForte.Formulários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoDenteForte
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSplash());
            Application.Run(new mdiMain());
            //Application.Run(new frmAgenda());
            //Application.Run(new frmUsuario());
            //Application.Run(new frmPaciente());
            //Application.Run(new frmConvenio());
            //Application.Run(new frmFuncionario()); 
            //Application.Run(new frmProduto());
            //Application.Run(new frmFornecedor());

        }
    }
}
