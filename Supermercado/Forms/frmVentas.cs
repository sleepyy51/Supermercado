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
    public partial class frmVentas : Form
    {
        Datos datos = new Datos();

        public frmVentas()
        {
            InitializeComponent();
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT * FROM \"ventas\" ORDER BY id");
            if (ds != null)
            {
                dgvVentas.DataSource = ds.Tables[0];
                dgvVentas.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarVentas av = new frmAgregarVentas();
            av.ShowDialog();
            if (av.IsDisposed)
            {
                mostrarDatos();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvVentas[0, dgvVentas.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (datos.ExecuteQuery("DELETE FROM ventas WHERE id=" + r))
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
