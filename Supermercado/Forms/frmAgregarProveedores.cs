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
    public partial class frmAgregarProveedores : Form
    {
        public int id = -1;

        public frmAgregarProveedores()
        {
            InitializeComponent();
        }

        public frmAgregarProveedores(int id)
        {
            InitializeComponent();
            Datos data = new Datos();
            DataSet ds = data.getAllData("SELECT * FROM \"proveedores\" WHERE id=" + id);
            txtEmpresa.Text = ds.Tables[0].Rows[0]["empresa"].ToString();
            txtProducto.Text = ds.Tables[0].Rows[0]["tipo_producto"].ToString();
            txtDireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
            txtTelefono.Text = ds.Tables[0].Rows[0]["nro_tel_princ"].ToString();
            txtTelSec.Text = ds.Tables[0].Rows[0]["nro_tel_sec"].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
            this.id = id;
            btnAgregar.Text = "Actualizar";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            if (id == -1)
            {
                string query = "INSERT INTO \"proveedores\" (empresa, tipo_producto, direccion, nro_tel_princ, nro_tel_sec, email) " +
                           "VALUES ('" + txtEmpresa.Text + "', '" + txtProducto.Text + "', '" + txtDireccion.Text + "', '"  + txtTelefono.Text + "', '" + txtTelSec.Text + "', '" + txtEmail.Text + "');";
                if (datos.ExecuteQuery(query))
                {
                    MessageBox.Show("Proveedor agregado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al agregar al proveedor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string query = "UPDATE \"proveedores\" SET " +
                           "empresa='" + txtEmpresa.Text + "', tipo_producto='" + txtProducto.Text + "', direccion='" + txtDireccion.Text + "', nro_tel_princ='" + txtTelefono.Text + "', nro_tel_sec='" + txtTelSec.Text + "', email='" + txtEmail.Text + "' WHERE id=" + id + ";";
                if (datos.ExecuteQuery(query))
                {
                    MessageBox.Show("Proveedor actualizado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al actualizar al proveedor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
