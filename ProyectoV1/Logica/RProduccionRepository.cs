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
    public class RProduccionRepository : ICRUD<RecetaDeProduccion>
    {
        RProduccionRepositorio rpRep;
        public RProduccionRepository(string conexion)
        {
            rpRep = new RProduccionRepositorio(conexion);
        }
        public int Actualizar(RecetaDeProduccion rp, int id)
        {
            return rpRep.Actualizar(rp, id);
        }

        public void Eliminar(int id)
        {
            rpRep.Eliminar(id);
        }

        public bool Existe(string nombre)
        {
            return rpRep.Existe(nombre);
        }

        public List<RecetaDeProduccion> GetAll()
        {
            return rpRep.GetAll();
        }

        public int Insert(RecetaDeProduccion rp)
        {
            return rpRep.Insert(rp);
        }

        public RecetaDeProduccion Mapper(SqlDataReader dataReader)
        {
            return rpRep.Mapper(dataReader);
        }

        public int ObtenerIndexPorId(int id)
        {
            return rpRep.ObtenerIndexPorId(id);
        }

        public RecetaDeProduccion ObtenerPorId(int id)
        {
            return rpRep.ObtenerPorId(id);
        }

        public RecetaDeProduccion ObtenerPorIndex(int index)
        {
            return rpRep.ObtenerPorIndex(index);
        }
    }
}
