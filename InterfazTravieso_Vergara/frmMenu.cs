using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazTravieso_Vergara
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void carnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarnesEnvasadas formulario = new frmCarnesEnvasadas();
            formulario.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedor form = new frmProveedor();
            form.Show();
        }

        private void pedidoAProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidoProveedor formulario = new frmPedidoProveedor();
            formulario.Show();
        }
    }
}
