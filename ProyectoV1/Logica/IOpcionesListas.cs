using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IOpcionesListas<T>
    {
        bool Add(T clase);
        bool Remove(T clase);
        List<T> GetAll();
        bool Update(T aModificar , T modificado);
        bool Exist(T clase);
    }
}
