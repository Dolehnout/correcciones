using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appLoop
{
    public partial class frmWhileLoop : Form
    {
        public frmWhileLoop()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Recuperar el valor ingresado por el usuario en txtNúmero
            int numero = Int32.Parse(this.txtNumero.Text);
            int fact = 1;
            int i = 1;

            while (i <= numero )
            {
                fact *= i;
                i++;
            }
            this.txtResultado.Text = fact.ToString();

        }
    }
}
