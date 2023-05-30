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
        public string Nombre { get; set; }
        public int cantidadProducida { get; set; }
        public Medida MedidaProduccion { get; set; }
        public Planta PlantaEncargada { get; set; }
        public List<ProductoProducido> ProductosProducidos { get; set; }
        public List<MateriaPrimaUtilizada> MateriaPrimaUtilizada { get; set; }
        public DateTime FechaProduccion { get; set; }

        public Produccion()
        {
        }

        public Produccion(int id, string nombre, int cantidadProducida, Medida medidaProduccion, Planta plantaEncargada, List<ProductoProducido> productosProducidos, List<MateriaPrimaUtilizada> materiaPrimaUtilizada, DateTime fechaProduccion)
        {
            Id = id;
            Nombre = nombre;
            this.cantidadProducida = cantidadProducida;
            MedidaProduccion = medidaProduccion;
            PlantaEncargada = plantaEncargada;
            ProductosProducidos = productosProducidos;
            MateriaPrimaUtilizada = materiaPrimaUtilizada;
            FechaProduccion = fechaProduccion;
        }

        //public override string ToString()
        //{
        //    return $"\nProduccion: {Id};{Nombre};{cantidadProducida};{MedidaProduccion};{PlantaEncargada};{ProductoProducido};{MateriaPrimaUtilizada};{FechaProduccion.ToShortDateString()}";
        //}
    }
}
