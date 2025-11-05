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
    public partial class frmVentasProductos : Form
    {
        Datos datos = new Datos();
        public frmVentasProductos()
        {
            InitializeComponent();
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT * from ventas_productos ORDER BY id");
            if (ds != null)
            {
                dgvVentasProductos.DataSource = ds.Tables[0];
                dgvVentasProductos.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVentasProductos_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarVentasProductos agv = new frmAgregarVentasProductos();
            agv.ShowDialog();
            if(agv.IsDisposed)
            {
                mostrarDatos();
            }
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvVentasProductos[0, dgvVentasProductos.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("Está seguro de eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                bool resultado = datos.ExecuteQuery("DELETE FROM ventas_productos WHERE id = " + r);
                if (resultado)
                {
                    MessageBox.Show("Se elimino el registro con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
