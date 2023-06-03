using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public Categoria()
        {
        }

        public Categoria(int id, string nombre, bool estado)
        {
            Id = id;
            Nombre = nombre;
            Estado = estado;
        }

        public override string ToString()
        {
            return $"\nCategoria:{Id};{Nombre}";

        }
    }
}
