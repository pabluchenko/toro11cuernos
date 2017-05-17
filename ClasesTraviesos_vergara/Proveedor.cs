using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTraviesos_vergara
{
    public class Proveedor
    {
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Contacto { get; set; }
        public string Email { get; set; }
        public DateTime FechaEjemplo { get; set; }

        public static List<Proveedor> listaProveedores = new List<Proveedor>();

        //Solo la firma, dejamos listo para implementar aqui la logica para hacerlo directamente Base Datos.
        public static void AgregarProveedor(Proveedor p)
        {
           //NADA TODAVIA 
        }

        public static void EliminarProveedor(Proveedor p)
        {
            listaProveedores.Remove(p);
        }

        public static List<Proveedor> ObtenerProveedores()
        {
            return listaProveedores;
        }

        public override string ToString()
        {
            return this.FechaEjemplo.ToString();
        }

    }
}
