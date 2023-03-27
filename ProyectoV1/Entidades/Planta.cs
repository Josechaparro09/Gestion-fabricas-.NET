using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planta
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public Empleado EmpleadoAsignado { get; set; }

        public Planta()
        {
        }

        public Planta(string id, string nombre, Empleado empleadoAsignado)
        {
            Id = id;
            Nombre = nombre;
            EmpleadoAsignado = empleadoAsignado;
        }
        public override string ToString()
        {
            return $"\nPlanta: {Id};{Nombre};{EmpleadoAsignado}";
        }
    }
}
