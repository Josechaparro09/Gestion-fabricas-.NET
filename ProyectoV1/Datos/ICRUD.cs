using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface ICRUD<T>
    {
        T Mapper(SqlDataReader dataReader);
        int Insert(T entidad);
        int Actualizar(T entidad, int id);
        void Eliminar(int id);
        T ObtenerPorId(int id);
        List<T> GetAll();
        bool Existe(string usuario);
        T ObtenerPorIndex(int index);
        int ObtenerIndexPorId(int id);

    }
}
