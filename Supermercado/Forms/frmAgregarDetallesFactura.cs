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
    public partial class frmAgregarDetallesFactura : Form
    {
        public int id = -1;
        public frmAgregarDetallesFactura()
        {
            InitializeComponent();
        }

        public frmAgregarDetallesFactura(int id)
        {
            InitializeComponent();
            Datos data = new Datos();
            DataSet ds = data.getAllData("SELECT * FROM \"facturas_detalles\" WHERE id=" + id);
            txtFactId.Text = ds.Tables[0].Rows[0]["id_factura"].ToString();
            txtTipoFac.Text = ds.Tables[0].Rows[0]["tipo"].ToString();
            txtDesc.Text = ds.Tables[0].Rows[0]["descr_factura"].ToString();
            txtCostoAsc.Text = ds.Tables[0].Rows[0]["costo_asoc"].ToString();
            txtIva.Text = ds.Tables[0].Rows[0]["iva"].ToString();
            txtPago.Text = ds.Tables[0].Rows[0]["medio_de_pago"].ToString();
            txtDesPago.Text = ds.Tables[0].Rows[0]["descr_pago"].ToString();
            this.id = id;
            btnAgregar.Text = "Actualizar";
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            if (id == -1)
            {
                string query = "INSERT INTO \"facturas_detalles\" (id_factura, tipo, descr_factura, costo_asoc, iva, medio_pago, descr_pago) " +
                           "VALUES ('" + txtFactId.Text + "', '" + txtTipoFac.Text + "', '" + txtDesc.Text + "', '" + txtCostoAsc.Text + "', '" + txtIva.Text + "', '" + txtPago.Text + "', '" + txtDesPago.Text + "');";
                if (datos.ExecuteQuery(query))
                {
                    MessageBox.Show("Detallles agregados con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al agregar los detalles", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string query = "UPDATE \"facturas_detalles\" SET " +
                           "factura_id='" + txtFactId.Text + "', tipo='" + txtTipoFac + "', descr_factura='" + txtDesc.Text + "', costo_asoc='" + txtCostoAsc.Text + "', iva='" + txtIva.Text + "', medio_pago='" + txtPago.Text + "', descr_pago='" + txtDesPago.Text + "', '" + "' WHERE id=" + id + ";";
                if (datos.ExecuteQuery(query))
                {
                    MessageBox.Show("Detallles agregados con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al agregar los detalles", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Dispose();
        }
    }
}
