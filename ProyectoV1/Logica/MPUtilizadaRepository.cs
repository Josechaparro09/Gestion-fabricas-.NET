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
    public class MPUtilizadaRepository : ICRUD<MateriaPrimaUtilizada>
    {
        MPrimaUtilizadaRepositorio mpRep;
        public MPUtilizadaRepository(string conexion)
        {
            mpRep = new MPrimaUtilizadaRepositorio(conexion);
        }
        public int Actualizar(MateriaPrimaUtilizada mpu, int id)
        {
            return mpRep.Actualizar(mpu, id);
        }

        public void Eliminar(int id)
        {
            mpRep.Eliminar(id);
        }

        public bool Existe(string nombre)
        {
            return mpRep.Existe(nombre);
        }

        public List<MateriaPrimaUtilizada> GetAll()
        {
            return mpRep.GetAll();
        }

        public int Insert(MateriaPrimaUtilizada mpu)
        {
            return mpRep.Insert(mpu);
        }

        public MateriaPrimaUtilizada Mapper(SqlDataReader dataReader)
        {
            return mpRep.Mapper(dataReader);
        }

        public int ObtenerIndexPorId(int id)
        {
            return mpRep.ObtenerIndexPorId(id);
        }

        public MateriaPrimaUtilizada ObtenerPorId(int id)
        {
            return mpRep.ObtenerPorId(id);
        }

        public MateriaPrimaUtilizada ObtenerPorIndex(int index)
        {
            return mpRep.ObtenerPorIndex(index);
        }
        public List<MateriaPrimaUtilizada> GetMPPorIdReceta(int id)
        {
            return mpRep.GetMPPorIdReceta(id);
        }
        public bool ExisteId(int id)
        {
            return mpRep.ExisteId(id);
        }
    }
}
