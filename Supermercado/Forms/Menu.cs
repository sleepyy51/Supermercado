using Supermercado.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            labFecha.Text = DateTime.Now.ToString("D");
            labHora.Text = DateTime.Now.ToString("t");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmClientes c = new frmClientes();
            c.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados emp = new frmEmpleados();
            emp.ShowDialog();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            frmFacturas f = new frmFacturas();
            f.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores p = new frmProveedores();
            p.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas v = new frmVentas();
            v.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos p = new frmProductos();
            p.ShowDialog();
        }
    }
}
