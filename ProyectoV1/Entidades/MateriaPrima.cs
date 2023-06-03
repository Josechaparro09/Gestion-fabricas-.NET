using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MateriaPrima
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        //public int Unidades { get; set; }
        //public double Cantidad { get; set; }
        public Medida Medida { get; set; }
        public Proveedores Proveedor { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public bool Estado { get; set; }


        public MateriaPrima()
        {
        }

        public MateriaPrima(int id, string nombre, Medida medida, Proveedores proveedor, DateTime fechaCompra, DateTime fechaExpiracion, bool estado)
        {
            Id = id;
            Nombre = nombre;
            Medida = medida;
            Proveedor = proveedor;
            FechaCompra = fechaCompra;
            FechaExpiracion = fechaExpiracion;
            Estado = estado;
        }





        //public override string ToString()
        //{
        //    return $"\nMateria Prima: {Id};{Name};{Unidades};{Cantidad};{Medida};{FechaCompra.ToShortDateString()};{FechaExpiracion.ToShortDateString()}";
        //}

    }
}
