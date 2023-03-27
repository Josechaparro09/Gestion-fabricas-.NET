using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Produccion
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int cantidadProducida { get; set; }
        public Medida MedidaProduccion { get; set; }
        public Planta PlantaEncargada { get; set; }
        public Producto ProductoProducido { get; set; }
        public MateriaPrima MateriaPrimaUtilizada { get; set; }
        public DateTime FechaProduccion { get; set; }

        public Produccion()
        {
        }

        public Produccion(string id, string nombre, int cantidadProducida, Medida medidaProduccion, Planta plantaEncargada, Producto productoProducido, MateriaPrima materiaPrimaUtilizada, DateTime fechaProduccion)
        {
            Id = id;
            Nombre = nombre;
            this.cantidadProducida = cantidadProducida;
            MedidaProduccion = medidaProduccion;
            PlantaEncargada = plantaEncargada;
            ProductoProducido = productoProducido;
            MateriaPrimaUtilizada = materiaPrimaUtilizada;
            FechaProduccion = fechaProduccion;
        }
    }
}
