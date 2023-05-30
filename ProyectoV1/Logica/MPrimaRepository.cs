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
    public class MPrimaRepository : ICRUD<MateriaPrima>
    {
        MPrimaRepositorio mprimaRep;
        public MPrimaRepository(string conexion)
        {
            mprimaRep = new MPrimaRepositorio(conexion);
        }
        public int Actualizar(MateriaPrima mprima, int id)
        {
            return mprimaRep.Actualizar(mprima, id);
        }

        public void Eliminar(int id)
        {
            mprimaRep.Eliminar(id);
        }

        public bool Existe(string nombre)
        {
            return mprimaRep.Existe(nombre);
        }

        public List<MateriaPrima> GetAll()
        {
            return mprimaRep.GetAll();
        }

        public int Insert(MateriaPrima mprima)
        {
            return mprimaRep.Insert(mprima);
        }

        public MateriaPrima Mapper(SqlDataReader dataReader)
        {
            return mprimaRep.Mapper(dataReader);
        }

        public int ObtenerIndexPorId(int id)
        {
            return mprimaRep.ObtenerIndexPorId(id);
        }

        public MateriaPrima ObtenerPorId(int id)
        {
            return mprimaRep.ObtenerPorId(id);
        }

        public MateriaPrima ObtenerPorIndex(int index)
        {
            return mprimaRep.ObtenerPorIndex(index);
        }
    }
}
