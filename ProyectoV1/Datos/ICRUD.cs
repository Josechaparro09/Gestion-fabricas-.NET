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
        void Actualizar(T entidad, int id);
        void Eliminar(int id);
        T ObtenerPorId(int id);
        List<T> GetAll();
        bool Existe(string usuario);
    }
}
