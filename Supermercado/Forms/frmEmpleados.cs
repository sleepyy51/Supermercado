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
    public partial class frmEmpleados : Form
    {
        Datos datos = new Datos();
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT * from empleados ORDER BY id");
            if (ds != null)
            {
                dgvEmpleados.DataSource = ds.Tables[0];
                dgvEmpleados.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarEmpleados agregar = new frmAgregarEmpleados();
            agregar.ShowDialog();
            if (agregar.IsDisposed)
            {
                mostrarDatos();
            }
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvEmpleados[0, dgvEmpleados.CurrentCell.RowIndex].Value.ToString();
            frmAgregarEmpleados emp = new frmAgregarEmpleados(Convert.ToInt32(r));
            emp.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvEmpleados[0, dgvEmpleados.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (datos.ExecuteQuery("DELETE FROM empleados WHERE id=" + r))
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
            DataSet ds = datos.getAllData("SELECT * FROM \"empleados\" Where nombre ilike '" + txtBuscar.Text + "%' OR apellido ilike '" + txtBuscar.Text + "' OR email ilike '" + txtBuscar.Text + "%';");
            if (ds != null)
            {
                dgvEmpleados.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
