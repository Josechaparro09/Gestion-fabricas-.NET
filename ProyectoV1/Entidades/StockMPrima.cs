using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class StockMPrima
    {
        public int Id { get; set; }
        public MateriaPrima Mprima { get; set; }
        public double Cantidad { get; set; }
        public DateTime FechaActualizacion { get; set; }


        public StockMPrima()
        {
            
        }

        public StockMPrima(int id, MateriaPrima mprima, double cantidad, DateTime fechaActualizacion)
        {
            Id = id;
            Mprima = mprima;
            Cantidad = cantidad;
            FechaActualizacion = fechaActualizacion;
        }
    }
}
