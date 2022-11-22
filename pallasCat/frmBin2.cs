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
    public partial class frmBin2 : Form
    {
        public frmBin2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //int numero = Int32.Parse(this.txtNum.Text);
            //out es un parámetro pasado por referencia
            //TryParse devuelve true si la transformación es correcta; y false en caso contrario

            bool ifnum = Int32.TryParse(this.txtNum.Text, out int numero);
            if (!ifnum)
            {
                MessageBox.Show("Se debe ingresar un valor numérico");
                this.txtNum.Focus(); //Poner enfoque en el cuadro de textBox
                return;
            }

            if (!(numero >= 0 && numero <= 65535))
            {
                MessageBox.Show("El número está fuera de rango");
                return; //Abandonar ejecución
            }

            int[] vector = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            int i = 0;



            while (numero > 0)
            {
                int resto = numero % 2;
                vector[i] = resto;


                numero /= 2;
                i++;
            }
            lstBin.Items.Clear();

            for (int k = 15; k >= 0; k--)
            {
                this.lstBin.Items.Add(vector[k]);
            }
        }

    }
}
