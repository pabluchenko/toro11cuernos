using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTraviesos_vergara
{
    public class PedidoProveedor
    {
        public CarneEnvasada carne { get; set; }
        public Proveedor proveedor { get; set; }
        public double cantidad { get; set; }
        public DateTime FechaLLegadaAproximada { get; set; }

        public static List<PedidoProveedor> lista_Pedidos_Proveedor = new List<PedidoProveedor>();

        public static void AgregarPedido(PedidoProveedor pedido)
        {
            lista_Pedidos_Proveedor.Add(pedido);
        }

        public static void EliminarPedido(PedidoProveedor pedido)
        {
            lista_Pedidos_Proveedor.Remove(pedido);     
        }

        public static List<PedidoProveedor> ObtenerListaPedidosProveedor()
        {
            return lista_Pedidos_Proveedor;
        }

        public override string ToString()
        {
            return this.carne.Nombre + this.proveedor.RazonSocial + this.cantidad + this.FechaLLegadaAproximada;
        }


    }
}
