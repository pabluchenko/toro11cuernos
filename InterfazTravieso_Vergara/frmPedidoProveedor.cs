using ClasesTraviesos_vergara;
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
    public partial class frmPedidoProveedor : Form
    {
        public frmPedidoProveedor()
        {
            InitializeComponent();
        }

        private void frmPedidoProveedor_Load(object sender, EventArgs e)
        {
            lstCarnes.DataSource = CarneEnvasada.ObtenerCarnes();
            cboProveedores.DataSource = Proveedor.ObtenerProveedores();
            ActualizarListaPedidos();
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            PedidoProveedor pp = new PedidoProveedor();
            pp.carne = (CarneEnvasada)lstCarnes.SelectedItem;
            pp.proveedor = (Proveedor)cboProveedores.SelectedItem;
            pp.cantidad = int.Parse(txtCantidad.Text);
            pp.FechaLLegadaAproximada = dtpFechaAprox.Value;

            PedidoProveedor.AgregarPedido(pp);
            ActualizarListaPedidos();

        }

        public void ActualizarListaPedidos()
        {
            lstPedidos.DataSource = null;
            lstPedidos.DataSource = PedidoProveedor.ObtenerListaPedidosProveedor();
        }

        private void lstPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPedidos.SelectedItem != null)
            {
                PedidoProveedor pedidoSeleccionado = (PedidoProveedor)lstPedidos.SelectedItem;

                lstCarnes.SelectedItem = pedidoSeleccionado.carne;
                cboProveedores.SelectedItem = pedidoSeleccionado.proveedor;
                txtCantidad.Text = pedidoSeleccionado.cantidad.ToString();
                dtpFechaAprox.Value = pedidoSeleccionado.FechaLLegadaAproximada;

            }
        }

        public void Limpiar()
        {
            txtCantidad.Text = string.Empty;
            dtpFechaAprox.Value = DateTime.Now;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstPedidos.SelectedItem != null)
            {
                PedidoProveedor pedidoSeleccionado = (PedidoProveedor)lstPedidos.SelectedItem;

                pedidoSeleccionado.carne = (CarneEnvasada)lstCarnes.SelectedItem;
                pedidoSeleccionado.proveedor = (Proveedor)cboProveedores.SelectedItem;
                pedidoSeleccionado.cantidad = int.Parse(txtCantidad.Text);
                pedidoSeleccionado.FechaLLegadaAproximada = dtpFechaAprox.Value;

                ActualizarListaPedidos();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstPedidos.SelectedItem != null)
            {
                PedidoProveedor pedidoSeleccionado = (PedidoProveedor)lstPedidos.SelectedItem;
                PedidoProveedor.EliminarPedido(pedidoSeleccionado);
                ActualizarListaPedidos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
