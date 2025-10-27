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
    public partial class frmAgregarEmpleados : Form
    {
        public int id = -1;
        public frmAgregarEmpleados()
        {
            InitializeComponent();
        }

        public frmAgregarEmpleados(int id)
        {
            InitializeComponent();
            Datos data = new Datos();
            DataSet ds = data.getAllData("SELECT * FROM empleados WHERE id=" + id);
            txtNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
            txtApellido.Text = ds.Tables[0].Rows[0]["apellido"].ToString();
            txtEdad.Text = ds.Tables[0].Rows[0]["edad"].ToString();
            dtpFechaNac.Text = ds.Tables[0].Rows[0]["fecha_nac"].ToString();
            txtDoc.Text = ds.Tables[0].Rows[0]["tipo_doc"].ToString();
            txtNumDoc.Text = ds.Tables[0].Rows[0]["nro_doc"].ToString();
            txtCuil.Text = ds.Tables[0].Rows[0]["cuil"].ToString();
            txtDireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
            txtTelefono.Text = ds.Tables[0].Rows[0]["nro_tel_princ"].ToString();
            txtTelSec.Text = ds.Tables[0].Rows[0]["nro_tel_sec"].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
            txtCargo.Text = ds.Tables[0].Rows[0]["cargo"].ToString();
            txtAntiguedad.Text = ds.Tables[0].Rows[0]["antiguedad"].ToString();
            dtpFechaIng.Text = ds.Tables[0].Rows[0]["fecha_ingreso"].ToString();
            txtSalario.Text = ds.Tables[0].Rows[0]["salario_anual"].ToString();
            this.id = id;
            btnAgregar.Text = "Actualizar";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            if (id == -1)
            {
                string query = "INSERT INTO \"empleados\" (nombre, apellido, edad, fecha_nac, tipo_doc, nro_doc, cuil, direccion, nro_tel_princ, nro_tel_sec, email, cargo, antiguedad, fecha_ingreso, salario_anual) " +
                           "VALUES ('" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtEdad.Text + "', '" + dtpFechaNac.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + txtDoc.Text + "', '" + txtNumDoc.Text + "', '"+ txtCuil.Text + "', '"+ txtDireccion.Text + "', '" + txtTelefono.Text + "', '" + txtTelSec.Text + "', '" + txtEmail.Text + "', '" + txtCargo.Text+ "', '"+ txtAntiguedad.Text + "', '" + dtpFechaIng.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', '"+ txtSalario.Text + "');";
                if (datos.ExecuteQuery(query))
                {
                    MessageBox.Show("Empleado agregado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al agregar el empleado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string query = "UPDATE \"empleados\" SET " +
                           "nombre='" + txtNombre.Text + "', apellido='" + txtApellido.Text + "', edad='"+txtEdad.Text +"', fecha_nac='" + dtpFechaNac.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', tipo_doc='" + txtDoc.Text + "', nro_doc='" + txtNumDoc.Text + "', cuil='"+txtCuil.Text+ "', direccion='"+ txtDireccion.Text + "', nro_tel_princ='" + txtTelefono.Text + "', nro_tel_sec='" + txtTelSec.Text + "', email='" + txtEmail.Text+ "', cargo='"+txtCargo.Text+ "', antiguedad='"+txtAntiguedad.Text+"', fecha_ingreso='"+ dtpFechaIng.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', salario_anual='" + txtSalario.Text + "' WHERE id=" + id;
                if (datos.ExecuteQuery(query))
                {
                    MessageBox.Show("Empleado actualizado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el empleado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
