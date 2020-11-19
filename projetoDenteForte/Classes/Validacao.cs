using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoDenteForte.Classes
{
    public class Validacao
    {
        public bool campoVazio (Control controle, string campo)
        {
            if (string.IsNullOrEmpty(controle.Text))
            {
                MessageBox.Show($"O campo {campo} não pode estar vazio.");
                controle.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}