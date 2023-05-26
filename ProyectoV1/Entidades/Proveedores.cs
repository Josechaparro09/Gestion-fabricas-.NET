using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedores
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FRegistro { get; set; }

        public Proveedores()
        {
        }

        public Proveedores(int id, string nombre, string telefono, string direccion, DateTime fregistro)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
            FRegistro = fregistro;
        }
    }
}
