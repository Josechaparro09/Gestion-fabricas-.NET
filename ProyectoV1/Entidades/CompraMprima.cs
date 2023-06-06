using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CompraMprima
    {
        public int Id { get; set; }
        public double Cantidad { get; set; }
        public DateTime FCompra { get; set; }
        public double Valor { get; set; }
        public MateriaPrima MPrima { get; set; }
        public CompraMprima()
        {
            
        }

        public CompraMprima(int id, double cantidad, DateTime fCompra, double valor, MateriaPrima mPrima)
        {
            Id = id;
            Cantidad = cantidad;
            FCompra = fCompra;
            Valor = valor;
            MPrima = mPrima;
        }
    }
}
