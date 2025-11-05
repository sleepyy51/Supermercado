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
    public partial class frmComprasClientes : Form
    {
        int id = -1;
        Datos datos = new Datos();

        public frmComprasClientes()
        {
            InitializeComponent();
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT * from \"compras_clientes\" ORDER BY id");
            if (ds != null)
            {
                dgvCompras.DataSource = ds.Tables[0];
                dgvCompras.AutoResizeColumns();
                dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            mostrarDatos();   
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarCompras nuevo = new frmAgregarCompras();
            nuevo.ShowDialog();
            if(nuevo.IsDisposed)
            {
                mostrarDatos();
            }
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvCompras[0, dgvCompras.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("Está seguro de eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                bool resultado = datos.ExecuteQuery("DELETE FROM compras_clientes WHERE id = " + r);
                if (resultado)
                {
                    MessageBox.Show("Se elimino el registro con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostrarDatos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}