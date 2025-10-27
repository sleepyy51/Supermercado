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
    public partial class frmAgregarClientes : Form
    {
        public int id = -1;

        public frmAgregarClientes()
        {
            InitializeComponent();
        }

        public frmAgregarClientes(int id)
        {
            InitializeComponent();
            Datos data = new Datos();
            DataSet ds = data.getAllData("SELECT * FROM \"clientes\" WHERE id=" + id);
            txtNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
            txtApellido.Text = ds.Tables[0].Rows[0]["apellido"].ToString();
            txtTipoDoc.Text = ds.Tables[0].Rows[0]["tipo_doc"].ToString();
            txtNumDoc.Text = ds.Tables[0].Rows[0]["nro_doc"].ToString();
            txtTelefono.Text = ds.Tables[0].Rows[0]["nro_tel_princ"].ToString();
            txtTelefonoSec.Text = ds.Tables[0].Rows[0]["nro_tel_sec"].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
            this.id = id;
            btnAgregar.Text = "Actualizar";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            if(id == -1)
            {
                string query = "INSERT INTO \"clientes\" (nombre, apellido, tipo_doc, nro_doc, nro_tel_princ, nro_tel_sec, email) " +
                           "VALUES ('" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtTipoDoc.Text + "', '" + txtNumDoc.Text + "', '" + txtTelefono.Text + "', '" + txtTelefonoSec.Text + "', '" + txtEmail.Text + "');";
                if (datos.ExecuteQuery(query))
                {
                    MessageBox.Show("Cliente agregado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al agregar el cliente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string query = "UPDATE \"clientes\" SET " +
                           "nombre='" + txtNombre.Text + "', apellido='" + txtApellido.Text + "', tipo_doc='" + txtTipoDoc.Text + "', nro_doc='" + txtNumDoc.Text + "', nro_tel_princ='" + txtTelefono.Text + "', nro_tel_sec='" + txtTelefonoSec.Text + "', email='" + txtEmail.Text +"' WHERE id="+ id + ";";
                if (datos.ExecuteQuery(query))
                {
                    MessageBox.Show("Cliente actualizado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el cliente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Dispose();
        }
    }
}
