using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Categoria CategoriaProducto { get; set; }
        public Medida MedidaProducto { get; set; }
        public string Presentacion { get; set; }
        public double CostoProduccion { get; set; }
        public double PrecioVenta { get; set; }
        public double Ganancia { get; set; }

        public Producto()
        {
        }

        public Producto(int id, string nombre, Categoria categoriaProducto, Medida medidaProducto, string presentacion, double costoProduccion, double precioVenta)
        {
            Id = id;
            Nombre = nombre;
            CategoriaProducto = categoriaProducto;
            MedidaProducto = medidaProducto;
            Presentacion = presentacion;
            CostoProduccion = costoProduccion;
            PrecioVenta = precioVenta;
            Ganancia = precioVenta-costoProduccion;
        }

        public override string ToString()
        {
            return $"\nProducto: {Id};{Nombre};{CategoriaProducto};{MedidaProducto};{Presentacion};{CostoProduccion};{PrecioVenta}";
        }
    }
}
