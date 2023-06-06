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
    public class StockProductosRepository : ICRUD<StockProductos>
    {
        StockProductosRepositorio stockpRep;
        public StockProductosRepository(string conexion)
        {
            stockpRep = new StockProductosRepositorio(conexion);
        }
        public int Actualizar(StockProductos stockp, int id)
        {
            return stockpRep.Actualizar(stockp,id);
        }
        public int Actualizar(StockProductos sp)
        {
            return stockpRep.Actualizar(sp);
        }

        public void Eliminar(int id)
        {
            stockpRep.Eliminar(id);
        }

        public bool Existe(string usuario)
        {
            throw new NotImplementedException();
        }

        public List<StockProductos> GetAll()
        {
            return stockpRep.GetAll();
        }

        public int Insert(StockProductos stockp)
        {
            return stockpRep.Insert(stockp);
        }

        public StockProductos Mapper(SqlDataReader dataReader)
        {
            return stockpRep.Mapper(dataReader);
        }

        public int ObtenerIndexPorId(int id)
        {
            return stockpRep.ObtenerIndexPorId(id);
        }

        public StockProductos ObtenerPorId(int id)
        {
            return stockpRep.ObtenerPorId(id);
        }

        public StockProductos ObtenerPorIndex(int index)
        {
            return stockpRep.ObtenerPorIndex(index);
        }
        public bool ExisteId(int id)
        {
            return stockpRep.ExisteId(id);
        }
        public bool ExisteIdProd(int id)
        {
            return stockpRep.ExisteIdProd(id);
        }
    }
}
