using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NUsuario { get; set; }
        public string Contrasenia { get; set; }
        public DateTime FRegistro { get; set; }

        public Usuario()
        {
            
        }

        public Usuario(int id, string nombre, string nUsuario, string contrasenia, DateTime fRegistro)
        {
            Id = id;
            Nombre = nombre;
            NUsuario = nUsuario;
            Contrasenia = contrasenia;
            FRegistro = fRegistro;
        }
    }
}
