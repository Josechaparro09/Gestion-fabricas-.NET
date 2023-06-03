using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }

        public Empleado()
        {
           
        }

        public Empleado(int id, string cedula, string nombre, string apellido, string telefono, DateTime fechaIngreso, bool estado)
        {
            Id = id;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            FechaIngreso = fechaIngreso;
            Estado = estado;
        }

        public override string ToString()
        {
            return $"\nEmpleado:{Cedula};{Telefono};{FechaIngreso.ToShortDateString()}";
        }
    }
}
