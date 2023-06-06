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
    public class PProducidoRepository : ICRUD<ProductoProducido>
    {
        PProducidoRepositorio ppRep;
        public PProducidoRepository(string conexion)
        {
            ppRep = new PProducidoRepositorio(conexion);
        }
        public int Actualizar(ProductoProducido pp, int id)
        {
            return ppRep.Actualizar(pp,id);
        }

        public void Eliminar(int id)
        {
            ppRep.Eliminar(id);
        }

        public bool Existe(string nombre)
        {
            return ppRep.Existe(nombre);
        }

        public List<ProductoProducido> GetAll()
        {
            return ppRep.GetAll();
        }

        public int Insert(ProductoProducido pp)
        {
            return ppRep.Insert(pp);
        }

        public ProductoProducido Mapper(SqlDataReader dataReader)
        {
            return ppRep.Mapper(dataReader);
        }

        public int ObtenerIndexPorId(int id)
        {
            return ppRep.ObtenerIndexPorId(id);
        }

        public ProductoProducido ObtenerPorId(int id)
        {
            return ppRep.ObtenerPorId(id);
        }

        public ProductoProducido ObtenerPorIndex(int index)
        {
            return ppRep.ObtenerPorIndex(index);
        }
        public List<ProductoProducido> GetPPPorIdReceta(int id)
        {
            return ppRep.GetPPPorIdReceta(id);
        }
        public bool ExisteId(int id)
        {
            return ppRep.ExisteId(id);
        }
    }
}
