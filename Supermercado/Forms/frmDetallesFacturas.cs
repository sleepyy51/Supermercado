using Supermercado.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercado.Forms
{
    public partial class frmDetallesFacturas : Form
    {
        Datos datos = new Datos();

        public frmDetallesFacturas()
        {
            InitializeComponent();
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT * FROM \"facturas_detalles\" ORDER BY id");
            if (ds != null)
            {
                dgvDetallesFacturas.DataSource = ds.Tables[0];
                dgvDetallesFacturas.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvDetallesFacturas[0, dgvDetallesFacturas.CurrentCell.RowIndex].Value.ToString();
            frmAgregarDetallesFactura df = new frmAgregarDetallesFactura(Convert.ToInt32(r));
            df.ShowDialog();
            if (df.IsDisposed)
            {
                mostrarDatos();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvDetallesFacturas[0, dgvDetallesFacturas.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (datos.ExecuteQuery("DELETE FROM facturas_detalles WHERE id=" + r))
                {
                    MessageBox.Show("Registro eliminado correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostrarDatos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = datos.getAllData("SELECT * FROM facturas_detalles Where " +
            "descr_factura like '" + txtBuscar.Text + "%' OR " +
            "descr_pago like '" + txtBuscar.Text + "%';");
            if (ds != null)
            {
                dgvDetallesFacturas.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos");
            }
        }

        private void frmDetallesFacturas_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }
    }
}
