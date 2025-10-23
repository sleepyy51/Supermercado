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
            DataSet ds = datos.getAllData("SELECT * ORDER BY id");
            if (ds != null)
            {
                dgvClientes.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = datos.getAllData("SELECT * FROM \"Clientes\" Where nombre ilike '" + txtBuscar.Text + "%' OR apellido ilike '" + txtBuscar.Text + "' OR direccion ilike '" + txtBuscar.Text + "%' OR telefono ilike '" + txtBuscar.Text + "%';");
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
    }
}
