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
    public partial class frmCarnesEnvasadas : Form
    {
        public frmCarnesEnvasadas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CarneEnvasada carne = new CarneEnvasada();

            carne.Nombre = txtNombre.Text;
            carne.Pesogramos = double.Parse(txtPeso.Text);
            carne.Fechavencimiento = dtpfechavencimiento.Value;
            carne.PrecioVenta = double.Parse(txtPrecio.Text);
            carne.categoria = (Categoria)cboCategoria.SelectedValue;
            carne.principal_proveedor = (Proveedor)cboProveedor.SelectedValue;
            
            if (rdbVacuno.Checked)
                carne.tipoCarne = TipoCarne.Vacuna;
            else
                carne.tipoCarne = TipoCarne.Porcina;

            CarneEnvasada.AgregarCarne(carne);

            lstCarnes.DataSource = null;
            lstCarnes.DataSource = CarneEnvasada.ObtenerCarnes();
        }

        private void frmCarnesEnvasadas_Load(object sender, EventArgs e)
        {
            cboCategoria.DataSource = Enum.GetValues(typeof(Categoria));
            cboProveedor.DataSource = Proveedor.ObtenerProveedores();
            lstCarnes.DataSource = CarneEnvasada.ObtenerCarnes();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstCarnes.SelectedItem != null)
            {
                CarneEnvasada carneSeleccionada = (CarneEnvasada)lstCarnes.SelectedItem;

                carneSeleccionada.Nombre = txtNombre.Text;
                carneSeleccionada.Pesogramos = double.Parse(txtPeso.Text);
                carneSeleccionada.Fechavencimiento = dtpfechavencimiento.Value;
                carneSeleccionada.PrecioVenta = double.Parse(txtPrecio.Text);
                carneSeleccionada.categoria = (Categoria)cboCategoria.SelectedValue;
                carneSeleccionada.principal_proveedor = (Proveedor)cboProveedor.SelectedValue;

                if (rdbVacuno.Checked)
                    carneSeleccionada.tipoCarne = TipoCarne.Vacuna;
                else
                    carneSeleccionada.tipoCarne = TipoCarne.Porcina;
                
                lstCarnes.DataSource = null;
                lstCarnes.DataSource = CarneEnvasada.ObtenerCarnes();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCarnes.SelectedItem != null)
            {
                CarneEnvasada carneSeleccionada = (CarneEnvasada)lstCarnes.SelectedItem;

                txtNombre.Text = carneSeleccionada.Nombre;
                txtPeso.Text = carneSeleccionada.Pesogramos.ToString();
                dtpfechavencimiento.Value = carneSeleccionada.Fechavencimiento;
                txtPrecio.Text = carneSeleccionada.PrecioVenta.ToString();
                cboCategoria.SelectedItem = carneSeleccionada.categoria;
                cboProveedor.SelectedItem = carneSeleccionada.principal_proveedor;

                rdbVacuno.Checked = carneSeleccionada.tipoCarne.Equals(TipoCarne.Vacuna) ? true : false;
                rdbPorcino.Checked = carneSeleccionada.tipoCarne.Equals(TipoCarne.Porcina) ? true : false;
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtPeso.Text = string.Empty;
            dtpfechavencimiento.Value = DateTime.Now;
            txtPrecio.Text = string.Empty;
            cboCategoria.SelectedIndex = 0;
            cboProveedor.SelectedIndex = 0;

            rdbVacuno.Checked = true;

            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstCarnes.SelectedItem != null)
            {
                CarneEnvasada carneSeleccionada = (CarneEnvasada)lstCarnes.SelectedItem;
                CarneEnvasada.EliminarCarne(carneSeleccionada);

                lstCarnes.DataSource = null;
                lstCarnes.DataSource = CarneEnvasada.ObtenerCarnes();
            }
        }

        private void btnLimipiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
