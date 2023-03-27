using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public Categoria CategoriaProducto { get; set; }
        public double CostoProduccion { get; set; }
        public double PrecioVenta { get; set; }

        public Producto()
        {
        }

        public Producto(string id, string nombre, Categoria categoriaProducto, double costoProduccion, double precioVenta)
        {
            Id = id;
            Nombre = nombre;
            CategoriaProducto = categoriaProducto;
            CostoProduccion = costoProduccion;
            PrecioVenta = precioVenta;
        }
    }
}
