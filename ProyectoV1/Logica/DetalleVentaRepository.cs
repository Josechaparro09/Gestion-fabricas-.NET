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
    public class DetalleVentaRepository
    {
        DetalleVentaRepositorio dvRep;
        public DetalleVentaRepository(string conexion)
        {
            dvRep = new DetalleVentaRepositorio(conexion);
        }
        public int Actualizar(DetalleVenta dv, int id)
        {
            return dvRep.Actualizar(dv, id);
        }

        public void Eliminar(int id)
        {
            dvRep.Eliminar(id);

        }



        public List<DetalleVenta> GetAll()
        {
            return dvRep.GetAll();
        }
        public List<DetalleVenta> GetAllByIdVenta(int id)
        {
            return dvRep.GetAllByIdVenta(id);
        }
        public int Insert(DetalleVenta dv)
        {
            return dvRep.Insert(dv);
        }

        public DetalleVenta ObtenerPorId(int id)
        {
            return dvRep.ObtenerPorId(id);

        }
        public DetalleVenta ObtenerPorIndex(int index)
        {
            return dvRep.ObtenerPorIndex(index);
        }
        public int ObtenerIndexPorId(int id)
        {
            return dvRep.ObtenerIndexPorId(id);
        }

        public bool Existe(string usuario)
        {
            throw new NotImplementedException();
        }

        public bool ExisteId(int id)
        {

            return dvRep.ExisteId(id);
        }
    }
}
