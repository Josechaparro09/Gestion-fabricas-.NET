using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class StockProductos
    {
        public int Id { get; set; }
        public Producto producto { get; set; }
        public int Cantidad { get; set; }
        public DateTime FActualizacion { get; set; }
        public RecetaDeProduccion receta { get; set; }

        public StockProductos()
        {
            
        }

        public StockProductos(int id, Producto producto, int cantidad, DateTime fActualizacion, RecetaDeProduccion receta)
        {
            Id = id;
            this.producto = producto;
            Cantidad = cantidad;
            FActualizacion = fActualizacion;
            this.receta = receta;
        }
    }
}
