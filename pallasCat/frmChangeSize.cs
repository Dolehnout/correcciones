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
    public partial class frmChangeSize : Form
    {
        public frmChangeSize()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string text = this.txtText.Text;

            int size = Convert.ToInt32(this.txtSize.Text);

            string fuente = cmbTipo.Text;

            lblResultado.Text = text;
            lblResultado.Font = new Font($"{fuente}", size);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
