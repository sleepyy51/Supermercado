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
    }
}
