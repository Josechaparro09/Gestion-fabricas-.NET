using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface ICRUD<T>
    {
        int Insertar(T entidad);
        void Actualizar(T entidad, int id);
        void Eliminar(int id);
        T ObtenerPorId(int id);
        List<T> ObtenerTodos();
        bool Existe(string usuario);
    }
}
