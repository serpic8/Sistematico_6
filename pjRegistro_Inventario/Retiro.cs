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
    public partial class frmRetiro : Form
    {
        public frmRetiro()
        {
            InitializeComponent();
        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmCreditos();
            this.Hide();
            frm.Show();
        }

        private void ingresarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmInventario();
            this.Hide();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRetiro_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
