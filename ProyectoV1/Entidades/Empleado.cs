using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        public string Cedula { get; set; }
        public string PNombre { get; set; }
        public string SNombre { get; set; }
        public string PApellido { get; set; }
        public string SApellido { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Empleado()
        {
        }

        public Empleado(string cedula, string pNombre, string sNombre, string pApellido, string sApellido, string telefono, DateTime fechaIngreso)
        {
            Cedula = cedula;
            PNombre = pNombre;
            SNombre = sNombre;
            PApellido = pApellido;
            SApellido = sApellido;
            Telefono = telefono;
            FechaIngreso = fechaIngreso;
        }
    }
}
