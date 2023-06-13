using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime FechaVenta { get; set; }
        public double Total { get; set; }

        public Venta()
        {
            
        }

        public Venta(int id, DateTime fechaVenta, double total)
        {
            Id = id;
            FechaVenta = fechaVenta;
            Total = total;
        }
    }
}
