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
    public partial class frmAgregarVentasProductos : Form
    {
        Datos datos = new Datos();
        public frmAgregarVentasProductos()
        {
            InitializeComponent();
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT id as ID FROM \"ventas\" ORDER BY id");
            DataSet ds2 = datos.getAllData("SELECT id as ID, nombre AS Nombre, marca as Marca FROM \"productos\" ORDER BY id");
            if (ds != null)
            {
                dgvVentas.DataSource = ds.Tables[0];
                dgvVentas.AutoResizeColumns();
                dgvProductos.DataSource = ds2.Tables[0];
                dgvProductos.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAgregarVentasProductos_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            string query = "INSERT INTO ventas_productos " +
                    "(id_venta, id_producto, cantidad) VALUES (" +
                    "" + cmbVentas.Text + "," + cmbProductos.Text + "," + txtCantidad.Text.ToString() + ")";
            if (datos.ExecuteQuery(query))
            {
                MessageBox.Show("Producto agregado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error al agregar el producto", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
