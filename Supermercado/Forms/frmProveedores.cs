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
    public partial class frmProveedores : Form
    {
        Datos datos = new Datos();

        public frmProveedores()
        {
            InitializeComponent();
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT * FROM \"proveedores\" ORDER BY id");
            if (ds != null)
            {
                dgvProveedores.DataSource = ds.Tables[0];
                dgvProveedores.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarProveedores prov = new frmAgregarProveedores();
            prov.ShowDialog();
            if (prov.IsDisposed)
            {
                mostrarDatos();
            }
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvProveedores[0, dgvProveedores.CurrentCell.RowIndex].Value.ToString();
            frmAgregarProveedores prov = new frmAgregarProveedores(Convert.ToInt32(r));
            prov.ShowDialog();
            if (prov.IsDisposed)
            {
                mostrarDatos();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvProveedores[0, dgvProveedores.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (datos.ExecuteQuery("DELETE FROM proveedores WHERE id=" + r))
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
