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
    public partial class frmBinario : Form
    {
        public frmBinario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = Int32.Parse(this.txtNum.Text);

            //Se utiliza el bucle while para realizar las diviones sucesivas para 2

            int[] vector = { 0, 0, 0, 0, 0, 0, 0, 0 };
            int i = 0;
            while (numero > 0)
            {
                int resto = numero % 2;
                vector[i] = resto; 

               
                numero /= 2;
                i++;

                Console.WriteLine($"{resto}");
            }
            //Encender | Apagar los checkbox
                this.chk1.Checked = (vector[0] == 1) ? true : false;
                this.chk2.Checked = (vector[1] == 1) ? true : false;
                this.chk3.Checked = (vector[2] == 1) ? true : false;
                this.chk4.Checked = (vector[3] == 1) ? true : false;
                this.chk5.Checked = (vector[4] == 1) ? true : false;
                this.chk6.Checked = (vector[5] == 1) ? true : false;
                this.chk7.Checked = (vector[6] == 1) ? true : false;
                this.chk8.Checked = (vector[7] == 1) ? true : false;
        }
    }
}
