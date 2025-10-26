using ImageMagick.Drawing;
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
    public partial class frmClientes : Form
    {
        Datos datos = new Datos();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT * FROM \"clientes\" ORDER BY id");
            if (ds != null)
            {
                dgvClientes.DataSource = ds.Tables[0];
                dgvClientes.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = datos.getAllData("SELECT * FROM \"clientes\" Where nombre ilike '" + txtBuscar.Text + "%' OR apellido ilike '" + txtBuscar.Text + "' OR email ilike '" + txtBuscar.Text + "%';");
            if (ds != null)
            {
                dgvClientes.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarClientes agregar = new frmAgregarClientes();
            agregar.ShowDialog();
            if(agregar.IsDisposed)
            {
                mostrarDatos();
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvClientes[0, dgvClientes.CurrentCell.RowIndex].Value.ToString();
            frmAgregarClientes box = new frmAgregarClientes(Convert.ToInt32(r));
            box.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvClientes[0, dgvClientes.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (datos.ExecuteQuery("DELETE FROM clientes WHERE id=" + r))
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
