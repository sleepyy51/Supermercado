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
    public partial class frmAgregarCompras : Form
    {
        Datos datos = new Datos();
        int id = -1;
        public frmAgregarCompras()
        {
            InitializeComponent();
        }

        public frmAgregarCompras(int id)
        {
            InitializeComponent();
            DataSet ds = datos.getAllData("SELECT * FROM \"clientes_compras\" WHERE id=" + id);
            cmbVenta.SelectedValue = ds.Tables[0].Rows[0]["id_venta"].ToString();
            cmbCliente.SelectedValue = ds.Tables[0].Rows[0]["id_cliente"].ToString();
            this.id = id;
            btnAgregar.Text = "Actualizar";
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT id as ID FROM \"ventas\" ORDER BY id");
            DataSet ds2 = datos.getAllData("SELECT id as ID, nombre AS Nombre, apellido as Apellido FROM \"clientes\" ORDER BY id");
            if (ds != null)
            {
                dgvVenta.DataSource = ds.Tables[0];
                dgvVenta.AutoResizeColumns();
                dgvCliente.DataSource = ds2.Tables[0];
                dgvCliente.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fmrAgregarCompras_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            if (id == -1)
            {
                string query = "INSERT INTO compras_clientes " +
                    "(id_venta, id_cliente) VALUES (" +
                    "" + cmbVenta.Text + "," + cmbCliente.Text + ")";
                if (datos.ExecuteQuery(query))
                {
                    MessageBox.Show("Compra agregada con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al agregar la compra", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
