using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pallasCat
{
    public partial class frmPotencia2 : Form
    {
        public frmPotencia2()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int base1 = Convert.ToInt32(this.txtBase.Text);
            int exponente = Convert.ToInt32(this.txtExponente.Text);
            int i = 1; int resultado = 1;

            do
            {
                i++;
                resultado *= base1;
            }
            while (i <= exponente);
            this.txtResultado.Text = resultado.ToString();
        }
    }
}
