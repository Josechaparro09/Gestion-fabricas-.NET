using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmpleadoDTO
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string FRegistro { get; set; }

        public EmpleadoDTO()
        {
            
        }

        public EmpleadoDTO(string iD, string nombre, string telefono, string fRegistro)
        {
            ID = iD;
            Nombre = nombre;
            Telefono = telefono;
            FRegistro = fRegistro;
        }
    }
}
