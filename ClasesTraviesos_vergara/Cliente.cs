using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTraviesos_vergara
{    
    public class Cliente
    {
        string Nombre { get; set; }
        string ruc { get; set; }
        string direccion { get; set; }
        string Telefono { get; set; }

        public static List<Cliente> clientes = new List<Cliente>();

        public void AgregarCliente(Cliente c)
        {
            clientes.Add(c);
        }


    }
}
