using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RecetaDeProduccion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        //public Medida MedidaProduccion { get; set; }
        public Planta PlantaEncargada { get; set; }
        public List<ProductoProducido> ProductosProducidos { get; set; }
        public List<MateriaPrimaUtilizada> MateriasPrimasUtilizadas { get; set; }
        public DateTime Fecha { get; set; }

        public RecetaDeProduccion()
        {
            
        }

        public RecetaDeProduccion(int id, string nombre, Planta plantaEncargada, List<ProductoProducido> productosProducidos, List<MateriaPrimaUtilizada> materiasPrimasUtilizadas, DateTime fecha)
        {
            Id = id;
            Nombre = nombre;
            PlantaEncargada = plantaEncargada;
            ProductosProducidos = productosProducidos;
            MateriasPrimasUtilizadas = materiasPrimasUtilizadas;
            Fecha = fecha;
        }

    }
}
