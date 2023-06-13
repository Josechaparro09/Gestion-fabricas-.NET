using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleVenta
    {
        public int Id { get; set; }
        public double PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public double Subtotal { get; set; }
        public Producto Producto { get; set; }
        public Venta Venta { get; set; }

        public DetalleVenta()
        {
            
        }

        public DetalleVenta(int id, double precioUnitario, int cantidad, Producto producto, Venta venta)
        {
            Id = id;
            PrecioUnitario = precioUnitario;
            Cantidad = cantidad;
            Producto = producto;
            Venta = venta;
        }
    }
}
