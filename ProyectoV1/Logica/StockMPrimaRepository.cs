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
    public class StockMPrimaRepository : ICRUD<StockMPrima>
    {
        StockMPrimasRepositorio stockmp;
        public StockMPrimaRepository(string conexion)
        {
            stockmp = new StockMPrimasRepositorio(conexion);
        }
        public int Actualizar(StockMPrima entidad, int id)
        {
            return stockmp.Actualizar(entidad, id);
        }
        public int Actualizar(StockMPrima mp)
        {
            return stockmp.Actualizar(mp);
        }

        public void Eliminar(int id)
        {
            stockmp.Eliminar(id);
        }

        public bool Existe(string usuario)
        {
            throw new NotImplementedException();
        }

        public List<StockMPrima> GetAll()
        {
            return stockmp.GetAll();
        }

        public int Insert(StockMPrima entidad)
        {
            return stockmp.Insert(entidad);
        }

        public StockMPrima Mapper(SqlDataReader dataReader)
        {
            return stockmp.Mapper(dataReader);
        }

        public int ObtenerIndexPorId(int id)
        {
            return stockmp.ObtenerIndexPorId(id);
        }

        public StockMPrima ObtenerPorId(int id)
        {
            return stockmp.ObtenerPorId(id);
        }

        public StockMPrima ObtenerPorIndex(int index)
        {
            return stockmp.ObtenerPorIndex(index);
        }
        public bool ExisteId(int id)
        {
            return stockmp.ExisteId(id);
        }
        public bool ExisteIdMprima(int id)
        {
            return stockmp.ExisteIdMprima(id);
        }
        public bool PuedeProducir(MateriaPrimaUtilizada mpu)
        {
            return stockmp.PuedeProducir(mpu);
        }
        public int ComprarMPrima(double cantidad, int idMPrima)
        {
            return stockmp.ComprarMPrima(cantidad, idMPrima);
        }
    }
}
