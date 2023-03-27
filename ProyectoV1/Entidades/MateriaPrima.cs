using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MateriaPrima
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Unidades { get; set; }
        public double Cantidad { get; set; }
        public Medida Medida { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaExpiracion { get; set; }

        public MateriaPrima()
        {
        }

        public MateriaPrima(string id, string name, int unidades, double cantidad, Medida medida, DateTime fechaCompra, DateTime fechaExpiracion)
        {
            Id = id;
            Name = name;
            Unidades = unidades;
            Cantidad = cantidad;
            Medida = medida;
            FechaCompra = fechaCompra;
            FechaExpiracion = fechaExpiracion;
        }

        public override string ToString()
        {
            return $"\nMateria Prima: {Id};{Name};{Unidades};{Cantidad};{Medida};{FechaCompra.ToShortDateString()};{FechaExpiracion.ToShortDateString()}";
        }

    }
}
