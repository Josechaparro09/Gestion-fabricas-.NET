using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public string Id { get; set; }
        public string Nombre { get; set; }

        public Categoria()
        {
        }

        public Categoria(string id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
