using appLoop;
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
    public partial class frmMenu : Form
    {
        private int childFormNumber = 0;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            //declaro frm1 de tipo frmBinario
            frmBin2 frm1 = new frmBin2();

            //el formulario menú es el formulario contenedor (frm padre)
            frm1.MdiParent = this;
            
            //mostrar el formulario
            frm1.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            frmPotencia2 frm2 = new frmPotencia2();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void tablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTabla frm3 = new frmTabla();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWhileLoop frm4 = new frmWhileLoop();
            frm4.MdiParent = this;
            frm4.Show();
        }

        private void binario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBinario frm5 = new frmBinario();
            frm5.MdiParent = this;
            frm5.Show();
        }

        private void decimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDecimal frm6 = new frmDecimal();
            frm6.MdiParent = this;
            frm6.Show();
        }

        private void windowsMenu_Click(object sender, EventArgs e)
        {

        }

        private void cambiarTamañoFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeSize frm7 = new frmChangeSize();
            frm7.MdiParent = this;
            frm7.Show();
        }
    }
}
