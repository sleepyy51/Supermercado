using ImageMagick;
using ImageMagick.Drawing;
using Supermercado.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Supermercado.Forms
{
    public partial class frmAgregarProductos : Form
    {
        Datos datos = new Datos();
        public int id = -1;

        public frmAgregarProductos()
        {
            InitializeComponent();
        }

        public frmAgregarProductos(int id_producto)
        {
            InitializeComponent();
            id = id_producto;
            Datos datos = new Datos();
            DataSet ds = datos.getAllData("SELECT * FROM productos WHERE id = " + id);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                try
                {
                    DataRow row = ds.Tables[0].Rows[0];
                    cbProveedor.Text = row["id_proveedor"].ToString();
                    txtCodigo.Text = row["codigo"].ToString();
                    txtImagen.Text = row["imagen"].ToString();
                    txtNombre.Text = row["nombre"].ToString();
                    txtMarca.Text = row["marca"].ToString();
                    txtTipo.Text = row["tipo"].ToString();
                    txtGrupo.Text = row["grupo"].ToString();
                    txtPeso.Text = row["peso"].ToString();
                    txtPrecioUnidad.Text = row["precio_unidad"].ToString();
                    txtStock.Text = row["stock"].ToString();
                    String img = datos.GetValue("SELECT imagen FROM productos WHERE id =" + id);
                    using (var image = new MagickImage(img))
                    {
                        using (var ms = new System.IO.MemoryStream(image.ToByteArray(MagickFormat.Bmp)))
                        {
                            pbImagen.Image = new Bitmap(ms);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos del producto: " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void agregarDatos()
        {
            DataSet ds = datos.getAllData("SELECT id FROM \"proveedores\" ORDER BY id");
            try
            {
                cbProveedor.DataSource = ds.Tables[0];
                cbProveedor.DisplayMember = "id";
                cbProveedor.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar los datos: " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            if (id == -1)
            {
                string query = "INSERT INTO productos " +
                    "(id_proveedor, codigo, imagen, nombre, marca, tipo, grupo, peso, precio_unidad, stock) VALUES (" +
                    "" + cbProveedor.Text + "," +
                    "'" + txtCodigo.Text + "'," +
                    "'" + txtImagen.Text + "'," +
                    "'" + txtNombre.Text + "'," +
                    "'" + txtMarca.Text + "'," +
                    "'" + txtTipo.Text + "'," +
                    "'" + txtGrupo.Text + "'," +
                    "" + txtPeso.Text + "," +
                    "" + txtPrecioUnidad.Text + "," +
                    "" + txtStock.Text + ")";

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
            else
            {
                string query = "UPDATE productos SET " +
                    "id_proveedor = " + cbProveedor.Text + ", " +
                    "codigo = '" + txtCodigo.Text + "', " +
                    "imagen = '" + txtImagen.Text + "', " +
                    "nombre = '" + txtNombre.Text + "', " +
                    "marca = '" + txtMarca.Text + "', " +
                    "tipo = '" + txtTipo.Text + "', " +
                    "grupo = '" + txtGrupo.Text + "', " +
                    "peso = " + txtPeso.Text + ", " +
                    "precio_unidad = " + txtPrecioUnidad.Text + ", " +
                    "stock = " + txtStock.Text + " " +
                    "WHERE id = " + id;

                if (datos.ExecuteQuery(query))
                {
                    MessageBox.Show("Producto actualizado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el producto", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmAgregarProductos_Load(object sender, EventArgs e)
        {
            agregarDatos();
        }
    }
}
