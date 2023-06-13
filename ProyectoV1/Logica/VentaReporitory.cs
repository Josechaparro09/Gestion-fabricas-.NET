using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VentaReporitory
    {
        VentaRepositorio vRep;
        public VentaReporitory(string conexion)
        {
            vRep = new VentaRepositorio(conexion);
        }
        public int Actualizar(Venta v, int id)
        {
            return vRep.Actualizar(v, id);
        }

        public void Eliminar(int id)
        {
            vRep.Eliminar(id);
        }



        public List<Venta> GetAll()
        {
            return vRep.GetAll();
        }

        public int Insert(Venta v)
        {
            return vRep.Insert(v);
        }

        

        public Venta ObtenerPorId(int id)
        {
            return vRep.ObtenerPorId(id);

        }
        public Venta ObtenerPorIndex(int index)
        {
            return vRep.ObtenerPorIndex(index);
        }
        public int ObtenerIndexPorId(int id)
        {
            return vRep.ObtenerIndexPorId(id);
        }

        public bool Existe(string usuario)
        {
            throw new NotImplementedException();
        }

        public bool ExisteId(int id)
        {
           return vRep.ExisteId(id);

        }
    }
}
