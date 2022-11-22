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
    public partial class frmTabla : Form
    {
        public frmTabla()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            int tabla = Convert.ToInt32(this.txtTabla.Text);
            string aux = "";
            lstTabla.Items.Clear();
            for (int i = 0; i <= 12; i++)
            {
                string cad = $"{tabla} x {i} = {tabla * i}\r\n";
                aux += cad;
                aux += "";
                this.txtResultado.Text = aux;
                lstTabla.Items.Add(cad);
            }
        }
    }
}
