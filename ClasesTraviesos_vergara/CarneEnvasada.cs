using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTraviesos_vergara
{
    public enum Categoria { Premium, Primera, Segunda, Menudencias }

    public enum TipoCarne { Vacuna, Porcina}

    public class CarneEnvasada
    {
        public string Nombre { get; set; }
        public double Pesogramos { get; set; }
        public DateTime Fechavencimiento { get; set; }
        public double PrecioVenta { get; set; }
        public Categoria categoria { get; set; }
        public Proveedor principal_proveedor { get; set; }
        public TipoCarne tipoCarne { get; set; }


        public static List<CarneEnvasada> listaCarnes = new List<CarneEnvasada>();

        public static void AgregarCarne(CarneEnvasada c)
        {
            listaCarnes.Add(c);
        }

        public static List<CarneEnvasada> ObtenerCarnes()
        {
            return listaCarnes;
        }

        public static void EliminarCarne(CarneEnvasada c)
        {
            listaCarnes.Remove(c);
        }

        public override string ToString()
        {
            return this.Nombre;
        }

    }
}
