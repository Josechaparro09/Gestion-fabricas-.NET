using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Empleado EmpleadoAsignado { get; set; }
        public bool Estado { get; set; }

        public Planta()
        {
        }

        public Planta(int id, string nombre, Empleado empleadoAsignado, bool estado)
        {
            Id = id;
            Nombre = nombre;
            EmpleadoAsignado = empleadoAsignado;
            Estado = estado;
        }

        public override string ToString()
        {
            return $"\nPlanta: {Id};{Nombre};{EmpleadoAsignado}";
        }
    }
}
