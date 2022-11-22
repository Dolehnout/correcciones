using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appLoop
{
    public partial class frmDecimal : Form
    {
        public frmDecimal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int suma = 0;
            if (chk1.Checked)
            {
                suma += 1;
            }
            if (chk2.Checked)
            {
                suma += 2;
            }
            if (chk3.Checked)
            {
                suma += 4;
            }
            if (chk4.Checked)
            {
                suma += 8;
            }
            if (chk5.Checked)
            {
                suma += 16;
            }
            if (chk6.Checked)
            {
                suma += 32;
            }
            if (chk7.Checked)
            {
                suma += 64;
            }
            if (chk8.Checked)
            {
                suma += 128;
            }
            this.txtDecimal.Text = suma.ToString();
        }
    }
}
