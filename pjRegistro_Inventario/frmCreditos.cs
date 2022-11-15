using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjRegistro_Inventario
{
    public partial class frmCreditos : Form
    {
        public frmCreditos()
        {
            InitializeComponent();
        }

        private void ingresarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmInventario();
            this.Hide();
            frm.Show();
        }

        private void sacarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmRetiro();
            this.Hide();
            frm.Show();
        }

        private void inventarioTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmTotalInv();
            this.Hide();
            frm.Show();
        }
    }
}
