using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medida
    {
        public string Id { get; set; }
        public string NombreCorto { get; set; }
        public string NombreLargo { get; set; }

        public Medida()
        {
        }

        public Medida(string id, string nombreCorto, string nombreLargo)
        {
            Id = id;
            NombreCorto = nombreCorto;
            NombreLargo = nombreLargo;
        }
        public override string ToString()
        {
            return $"\nMedida: {Id};{NombreCorto};{NombreLargo}";
        }
    }
}
