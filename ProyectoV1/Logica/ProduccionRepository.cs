using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ProduccionRepository
    {
        ProduccionRepositorio pRep;
        public ProduccionRepository(string conexion)
        {
            pRep = new ProduccionRepositorio(conexion);
        }
        public int Actualizar(Produccion p, int id)
        {
            return pRep.Actualizar(p, id);
        }

        public void Eliminar(int id)
        {
            pRep.Eliminar(id);
        }
        public void DescontarProductos(int idpp, int cant)
        {
            pRep.DescontarProductos(idpp, cant);
        }
        public void RestaurarMprima(double idmpu, int cant)
        {
                pRep.RestaurarMprima(idmpu, cant);
        }

        public List<Produccion> GetAll()
        {
            return pRep.GetAll();
        }

        public int Insert(Produccion p)
        {
            return pRep.Insert(p);
        }

        public Produccion Mapper(SqlDataReader dataReader)
        {
            return pRep.Mapper(dataReader);
        }

        public Produccion ObtenerPorId(int id)
        {
            return pRep.ObtenerPorId(id);
        }
        public Produccion ObtenerPorIndex(int index)
        {
            return pRep.ObtenerPorIndex(index);
        }
        public int ObtenerIndexPorId(int id)
        {
            return pRep.ObtenerIndexPorId(id);
        }

        public bool ExisteId(int id)
        {
            return pRep.ExisteId(id);
        }
    }
}
