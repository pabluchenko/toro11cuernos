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
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            //Validar Ingreso (que no este vacio, que sea un numero si debe ser un numero, etc..)

            Proveedor p = new Proveedor();
            p.RazonSocial = txtRazonSocial.Text;
            p.Direccion = txtDireccion.Text;
            p.Contacto = txtContacto.Text;
            p.Email = txtEmail.Text;


            Proveedor.AgregarProveedor(p);
            


        }

        private void lstProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProveedores.SelectedItem != null)
            {
                Proveedor proveedorSeleccionado = (Proveedor)lstProveedores.SelectedItem;

                txtRazonSocial.Text = proveedorSeleccionado.RazonSocial;
                txtContacto.Text = proveedorSeleccionado.Contacto;
                txtDireccion.Text = proveedorSeleccionado.Direccion;
                txtEmail.Text = proveedorSeleccionado.Email;
            }
        }

        private void Limpiar()
        {
            txtRazonSocial.Text = string.Empty;
            txtContacto.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtEmail.Text = string.Empty;

            txtRazonSocial.Focus();         
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstProveedores.SelectedItem != null)
            {
                Proveedor proveedorSeleccionado = (Proveedor)lstProveedores.SelectedItem;

                proveedorSeleccionado.RazonSocial = txtRazonSocial.Text;
                proveedorSeleccionado.Direccion = txtDireccion.Text;
                proveedorSeleccionado.Contacto = txtContacto.Text;
                proveedorSeleccionado.Email = txtEmail.Text;

                ActualizarListaProveedores();
            }
        }

        private void ActualizarListaProveedores()
        {
            lstProveedores.DataSource = null;
            lstProveedores.DataSource = Proveedor.ObtenerProveedores();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstProveedores.SelectedItem != null)
            {
                Proveedor proveedorSeleccionado = (Proveedor)lstProveedores.SelectedItem;

                Proveedor.EliminarProveedor(proveedorSeleccionado);
                ActualizarListaProveedores();
            }
        }
    }
}
