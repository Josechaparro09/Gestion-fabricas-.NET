using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Produccion
    {
        public int Id { get; set; }
        public int cantidadProducida { get; set; }
        public RecetaDeProduccion RProduccion { get; set; }
        public DateTime FechaProduccion { get; set; }


        public Produccion()
        {
        }

        public Produccion(int id, int cantidadProducida, RecetaDeProduccion rProduccion, DateTime fechaProduccion)
        {
            Id = id;
            this.cantidadProducida = cantidadProducida;
            RProduccion = rProduccion;
            FechaProduccion = fechaProduccion;
        }





        //public override string ToString()
        //{
        //    return $"\nProduccion: {Id};{Nombre};{cantidadProducida};{MedidaProduccion};{PlantaEncargada};{ProductoProducido};{MateriaPrimaUtilizada};{FechaProduccion.ToShortDateString()}";
        //}
    }
}
