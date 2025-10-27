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
    public partial class frmAgregarFacturas : Form
    {
        public int id = -1;

        public frmAgregarFacturas()
        {
            InitializeComponent();
            this.ActiveControl = txtNumero;
        }

        public frmAgregarFacturas(int id)
        {
            InitializeComponent();
            this.ActiveControl = txtNumero;
            Datos data = new Datos();
            DataSet ds = data.getAllData("SELECT * FROM \"facturas\" WHERE id=" + id);
            txtNumero.Text = ds.Tables[0].Rows[0]["numero"].ToString();
            txtCodigo.Text = ds.Tables[0].Rows[0]["codigo"].ToString();
            dtpFecha.Text = ds.Tables[0].Rows[0]["fecha"].ToString();
            dtpHora.Text = ds.Tables[0].Rows[0]["hora"].ToString();
            txtImporte.Text = ds.Tables[0].Rows[0]["importe_total"].ToString();
            this.id = id;
            btnAgregar.Text = "Actualizar";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        public void agregarDetalles()
        {
            frmAgregarDetallesFactura frd = new frmAgregarDetallesFactura(id);
            frd.ShowDialog();
            if (frd.IsDisposed)
            {
                this.Dispose();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            if (id == -1)
            {
                string query = "INSERT INTO \"facturas\" (numero, codigo, fecha, hora, importe_total) " +
                           "VALUES ('" + txtNumero.Text + "', '" + txtCodigo.Text + "', '" + dtpFecha.Value.ToString("yyyy-MM-dd") + "', '" + dtpHora.Value.ToString("HH:mm:ss") + "', '" + txtImporte.Text + "');";
                if (datos.ExecuteQuery(query))
                {
                    MessageBox.Show("Factura agregada con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult respuesta = MessageBox.Show(
                        "¿Desea agregar más detalles a la factura?",
                        "Agregar detalles",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        agregarDetalles();
                    }
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al agregar la factura", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string query = "UPDATE \"facturas\" SET " +
                           "numero='" + txtNumero.Text + "', codigo='" + txtCodigo.Text + "', fecha='" + dtpFecha.Value.ToString("yyyy-MM-dd") + "', hora='" + dtpHora.Value.ToString("HH:mm:ss") + "', importe_total='" + txtImporte.Text + "' WHERE id=" + id;
                if (datos.ExecuteQuery(query))
                {
                    MessageBox.Show("Factura actualizada con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la factura", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Dispose();
        }
    }
}
