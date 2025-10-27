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
    public partial class frmFacturas : Form
    {
        Datos datos = new Datos();

        public frmFacturas()
        {
            InitializeComponent();

        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT * from facturas ORDER BY id");
            if (ds != null)
            {
                dgvFacturas.DataSource = ds.Tables[0];
                dgvFacturas.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            mostrarDatos();
            dgvFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFacturas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 255);
            dgvFacturas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 229, 255);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarFacturas f = new frmAgregarFacturas();
            f.ShowDialog();
            if (f.IsDisposed)
            {
                mostrarDatos();
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvFacturas[0, dgvFacturas.CurrentCell.RowIndex].Value.ToString();
            frmAgregarFacturas fact = new frmAgregarFacturas(Convert.ToInt32(r));
            fact.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvFacturas[0, dgvFacturas.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (datos.ExecuteQuery("DELETE FROM facturas WHERE id=" + r))
                {
                    MessageBox.Show("Registro eliminado correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
