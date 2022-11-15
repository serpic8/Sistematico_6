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
    public partial class frmInventario : Form
    {
        int num=1000230;
        ListViewItem item;
        public frmInventario()
        { 
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            num++;
            lblN_Entrega.Text = num.ToString("D5");
            lblFecha.Text= DateTime.Now.ToShortDateString();
        }

        public void CapturaDatos()
        {
            Propiedades.id=int.Parse(txtId.Text);
            Propiedades.nombre = txtNombre.Text;
            Propiedades.tipo = cboTipo.Text;
            Propiedades.color = cboColor.Text;
            Propiedades.unidad = int.Parse(txtUnidad.Text);
            Propiedades.precio = int.Parse(txtPrecio.Text);
            Propiedades.tamaño = cboTamaño.Text;

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            if (Valida() == "")
            {
                ListViewItem fila = new ListViewItem();
                fila.SubItems.Add(txtId.Text);
                fila.SubItems.Add(txtNombre.Text);
                fila.SubItems.Add(txtUnidad.Text);
                fila.SubItems.Add(cboTipo.Text);
                fila.SubItems.Add(cboColor.Text);
                fila.SubItems.Add(cboTamaño.Text);
                fila.SubItems.Add(txtPrecio.Text);
                lvEntregas.Items.Add(fila);
                Limpiar();
            }else MessageBox.Show("El error se encuentra en " + Valida());
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
        public string Valida()
        {
            if (txtId.Text.Trim().Length == 0)
            {
                txtId.Focus();
                return "ID";
            }
            else if (txtNombre.Text.Trim().Length == 0)
            {
                txtNombre.Focus();
                return "Nombre";
            }
            else if (cboTipo.SelectedIndex == -1)
            {
                cboTipo.Focus();
                return "Tipo objeto";
            }
            else if (cboColor.SelectedIndex == -1)
            {
                cboColor.Focus();
                return "Color";
            }
            else if (txtUnidad.Text.Trim().Length == 0)
            {
                txtUnidad.Focus();
                return "Unidad";
            }
            else if (txtPrecio.Text.Trim().Length == 0)
            {
                txtPrecio.Focus();
                return "Precio";
            }
            else if (cboTamaño.SelectedIndex == -1)
            {
                cboTamaño.Focus();
                return "Tamaño";
            }
            else if (txtId.Text.Trim().Length == 0 && txtNombre.Text.Trim().Length == 0 && cboTipo.SelectedIndex == -1
              && cboColor.SelectedIndex == -1 && txtUnidad.Text.Trim().Length == 0 && txtPrecio.Text.Trim().Length == 0
              && cboTamaño.SelectedIndex == -1)
            {
                return "Todos los campos";
            }
            return "";
        }

        private void Limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtUnidad.Clear();
            txtPrecio.Clear();
            cboColor.Text = "(Seleccione)";
            cboTamaño.Text = "(Seleccione)";
            cboTipo.Text = "(Seleccione)";

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            pgProgreso.Value = 10;
            pgProgreso.Value = 36;
            pgProgreso.Value = 50;
            pgProgreso.Value = 78;
            pgProgreso.Value = 80;
            pgProgreso.Value = 100;
            lvEntregas.Clear();
        }

        private void lvEntregas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
