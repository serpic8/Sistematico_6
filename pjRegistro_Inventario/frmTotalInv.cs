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
    public partial class frmTotalInv : Form
    {
        public frmTotalInv()
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

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmCreditos();
            this.Hide();
            frm.Show();
        }

        
    }
}
