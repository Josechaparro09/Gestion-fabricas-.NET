using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medida
    {
        public int Id { get; set; }
        public string NombreCorto { get; set; }
        public string NombreLargo { get; set; }
        public bool Estado { get; set; }

        public Medida()
        {
        }

        public Medida(int id, string nombreCorto, string nombreLargo, bool estado)
        {
            Id = id;
            NombreCorto = nombreCorto;
            NombreLargo = nombreLargo;
            Estado = estado;
        }

        public override string ToString()
        {
            return $"\nMedida: {Id};{NombreCorto};{NombreLargo}";
        }
    }
}
