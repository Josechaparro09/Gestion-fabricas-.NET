using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PlantaRepository : ICRUD<Planta>
    {
        PlantaRepositorio plantaRep;
        public PlantaRepository(string conexion)
        {
            plantaRep = new PlantaRepositorio(conexion);
        }
        public int Actualizar(Planta planta, int id)
        {
            return plantaRep.Actualizar(planta, id);
        }

        public void Eliminar(int id)
        {
            plantaRep.Eliminar(id);
        }

        public bool Existe(string nombre)
        {
            return plantaRep.Existe(nombre);
        }

        public List<Planta> GetAll()
        {
            return plantaRep.GetAll();
        }

        public int Insert(Planta planta)
        {
            return plantaRep.Insert(planta);
        }

        public Planta Mapper(SqlDataReader dataReader)
        {
            return plantaRep.Mapper(dataReader);
        }

        public int ObtenerIndexPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Planta ObtenerPorId(int id)
        {
            return plantaRep.ObtenerPorId(id);
        }

        public Planta ObtenerPorIndex(int index)
        {
            throw new NotImplementedException();
        }
    }
}
