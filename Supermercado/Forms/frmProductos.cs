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
    public partial class frmProductos : Form
    {
        Datos datos = new Datos();
        public frmProductos()
        {
            InitializeComponent();
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT * FROM \"productos\" ORDER BY id");
            if (ds != null)
            {
                dgvProductos.DataSource = ds.Tables[0];
                dgvProductos.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            DataSet ds = datos.getAllData("SELECT * FROM \"productos\" Where nombre ilike '" + txtBuscar.Text + "%' OR categoria ilike '" + txtBuscar.Text + "%';");
            if (ds != null)
            {
                dgvProductos.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarProductos agp = new frmAgregarProductos();
            agp.ShowDialog();
            if(agp.IsDisposed)
            {
                mostrarDatos();
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvProductos[0, dgvProductos.CurrentCell.RowIndex].Value.ToString();
            frmAgregarProductos agp = new frmAgregarProductos(Convert.ToInt32(r));
            agp.ShowDialog();
            if (agp.IsDisposed)
            {
                mostrarDatos();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvProductos[0, dgvProductos.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (datos.ExecuteQuery("DELETE FROM productos WHERE id=" + r))
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
    }
}
