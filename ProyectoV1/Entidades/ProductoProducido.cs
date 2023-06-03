using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoProducido
    {
        public int Id { get; set; }
        public Producto Producto { get; set; }
        public int CantidadProducto { get; set; }

        public ProductoProducido()
        {
            
        }
        public ProductoProducido(int id, Producto producto, int cantidadProducto)
        {
            Id = id;
            Producto = producto;
            CantidadProducto = cantidadProducto;

        }
    }
}
