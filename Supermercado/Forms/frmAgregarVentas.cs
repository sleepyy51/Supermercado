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
    public partial class frmAgregarVentas : Form
    {
        Datos datos = new Datos();

        public int id = -1;

        public frmAgregarVentas()
        {
            InitializeComponent();
        }

        public frmAgregarVentas(int id)
        {
            InitializeComponent();
            Datos data = new Datos();
            DataSet ds = data.getAllData("SELECT * FROM \"ventas\" WHERE id=" + id);
            cbEmpleado.SelectedValue = ds.Tables[0].Rows[0]["id_empleado"].ToString();
            cbFactura.SelectedValue = ds.Tables[0].Rows[0]["id_factura"].ToString();
            this.id = id;
            btnAgregar.Text = "Actualizar";
        }


        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT id as ID, numero as Numero FROM \"facturas\" ORDER BY id");
            DataSet ds2 = datos.getAllData("SELECT id as ID, nombre AS Nombre, apellido as Apellido FROM \"empleados\" ORDER BY id");
            if (ds != null)
            {
                dgvEmpleado.DataSource = ds.Tables[0];
                dgvEmpleado.AutoResizeColumns();
                dgvFactura.DataSource = ds2.Tables[0];
                dgvFactura.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregarDatos()
        {
            DataSet ds = datos.getAllData("SELECT id FROM \"facturas\" ORDER BY id");
            DataSet ds2 = datos.getAllData("SELECT id FROM \"empleados\" ORDER BY id");
            try
            {
                cbEmpleado.DataSource = ds2.Tables[0];
                cbFactura.DataSource = ds.Tables[0];
                cbEmpleado.DisplayMember = "id";
                cbEmpleado.ValueMember = "id";
                cbFactura.DisplayMember = "id";
                cbFactura.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar los datos: " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmAgregarVentas_Load(object sender, EventArgs e)
        {
            mostrarDatos();
            agregarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            if (id == -1)
            {
                string query = "INSERT INTO \"ventas\" (id_empleado, id_factura) " +
                           "VALUES ('" + Convert.ToInt32(cbEmpleado.SelectedValue) + "', '" + Convert.ToInt32(cbFactura.SelectedValue) + "');";
                if (datos.ExecuteQuery(query))
                {
                    MessageBox.Show("Venta agregada con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al agregar la venta", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string query = "UPDATE \"ventas\" SET " +
                           "id_empleado='" + Convert.ToInt32(cbEmpleado.SelectedValue) + "', id_factura='" + Convert.ToInt32(cbFactura.SelectedValue) +  "' WHERE id=" + id + ";";
                if (datos.ExecuteQuery(query))
                {
                    MessageBox.Show("Venta agregada con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al agregar la venta", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Dispose();
        }
    }
}
