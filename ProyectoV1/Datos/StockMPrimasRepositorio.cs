using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class StockMPrimasRepositorio : ConnectionManager,ICRUD<StockMPrima>
    {
        public StockMPrimasRepositorio(string connectionString) : base(connectionString)
        {
        }
        public int Actualizar(StockMPrima stockmp , int id)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"Update StockMateriasPrimas set Cantidad = cantidad - @Cantidad , FechaActualizacion = @FechaActualizacion WHERE MateriaPrimaId = @MateriaPrimaId";
                Comando.Parameters.Add("MateriaPrimaId", SqlDbType.Int).Value = stockmp.Mprima.Id;
                Comando.Parameters.Add("Cantidad", SqlDbType.Decimal).Value = stockmp.Cantidad;
                Comando.Parameters.Add("FechaActualizacion", SqlDbType.DateTime).Value = DateTime.Now;

                Open();
                var filas = Comando.ExecuteNonQuery();
                Close();
                return filas;
            }
        }
        public int Actualizar(StockMPrima stockmp)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"Update StockMateriasPrimas set Cantidad = cantidad - @Cantidad , FechaActualizacion = @FechaActualizacion WHERE MateriaPrimaId = @MateriaPrimaId";
                Comando.Parameters.Add("MateriaPrimaId", SqlDbType.Int).Value = stockmp.Mprima.Id;
                Comando.Parameters.Add("Cantidad", SqlDbType.Decimal).Value = stockmp.Cantidad;
                Comando.Parameters.Add("FechaActualizacion", SqlDbType.DateTime).Value = DateTime.Now;

                Open();
                var filas = Comando.ExecuteNonQuery();
                Close();
                return filas;
            }
        }
        public int ComprarMPrima(double cantidad, int idMPrima)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                int filas = 0;
                if (ExisteIdMprima(idMPrima))
                {
                    Comando.CommandText = $"Update StockMateriasPrimas set Cantidad = cantidad + @Cantidad , FechaActualizacion = @FechaActualizacion WHERE MateriaPrimaId = @MateriaPrimaId";
                    Comando.Parameters.Add("MateriaPrimaId", SqlDbType.Int).Value = idMPrima;
                    Comando.Parameters.Add("Cantidad", SqlDbType.Decimal).Value = cantidad;
                    Comando.Parameters.Add("FechaActualizacion", SqlDbType.DateTime).Value = DateTime.Now;
                    Open();
                     filas = Comando.ExecuteNonQuery();
                    Close();
                }
                else
                {
                    var mpRep = new MPrimaRepositorio(this._conexion.ConnectionString);
                    var smp = new StockMPrima()
                    {
                        Cantidad = cantidad,
                        FechaActualizacion = DateTime.Now,
                        Mprima = mpRep.ObtenerPorId(idMPrima)
                    };


                    Insert(smp);
                }
                

                
                return filas;
            }
        }

        public void Eliminar(int id)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"DELETE FROM StockMateriasPrimas WHERE StockMateriaPrimaID = @id";
                //Comando.CommandText = $"Update StockProductos set Estado = 0 WHERE Id = @id";
                Comando.Parameters.Add("id", SqlDbType.Int).Value = id;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }



        public List<StockMPrima> GetAll()
        {
            var stockmp = new List<StockMPrima>();
            var comando = _conexion.CreateCommand();
            comando.CommandText = "select * from StockMateriasPrimas";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                stockmp.Add(Mapper(lector));
            }
            Close();
            return stockmp;
        }

        public int Insert(StockMPrima stockmp)
        {
            int rows;
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into StockMateriasPrimas (MateriaPrimaID,Cantidad,FechaActualizacion)" +
                " values (@MateriaPrimaID,@Cantidad,@FechaActualizacion)";
                Comando.Parameters.Add("MateriaPrimaID", SqlDbType.Int).Value = stockmp.Mprima.Id;
                Comando.Parameters.Add("Cantidad", SqlDbType.Int).Value = stockmp.Cantidad;
                Comando.Parameters.Add("FechaActualizacion", SqlDbType.DateTime).Value = DateTime.Now;
                Open();
                rows = Comando.ExecuteNonQuery();
                Close();
            }
            return rows;
        }

        public StockMPrima Mapper(SqlDataReader dataReader)
        {
            var mpRep = new MPrimaRepositorio(this._conexion.ConnectionString);
            var stockmp = new StockMPrima();
            if (!dataReader.HasRows) return null;

            stockmp.Id = dataReader.GetInt32(0);
            stockmp.Mprima = mpRep.ObtenerPorId(dataReader.GetInt32(1));
            stockmp.Cantidad = (double)dataReader.GetDecimal(2);
            stockmp.FechaActualizacion = dataReader.GetDateTime(3);

            return stockmp;
        }

        public StockMPrima ObtenerPorId(int id)
        {
            var stockmp = new StockMPrima();

            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM StockMateriasPrimas WHERE StockMateriaPrimaID = @id ";
            comando.Parameters.Add("id", SqlDbType.Int).Value = id;
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                stockmp = Mapper(lector);
            }
            Close();
            return stockmp;

        }
        //public List<MateriaPrimaUtilizada> GetMPbyIdReceta(int id)
        //{
        //    var smp = new List<MateriaPrimaUtilizada>();
        //    try
        //    {

        //        var comando = _conexion.CreateCommand();
        //        comando.CommandText = "select * from StockMateriasPrimas WHERE IdReceta = @Id ";
        //        comando.Parameters.Add("Id", SqlDbType.Int).Value = id;
        //        Open();
        //        SqlDataReader lector = comando.ExecuteReader();

        //        while (lector.Read())
        //        {
        //            smp.Add(Mapper(lector));
        //        }
        //        Close();

        //        return smp;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }

        //    return smp;
        //}
        public bool PuedeProducir(MateriaPrimaUtilizada mpu)
        {
            using (var comando = _conexion.CreateCommand())
            {
                comando.CommandText = "SELECT Cantidad FROM StockMateriasPrimas WHERE MateriaPrimaId = @MateriaPrimaId";
                comando.Parameters.Add("MateriaPrimaId", SqlDbType.VarChar).Value = mpu.MPrimaUtilizada.Id;
                Open();
                var cantDisponible = Convert.ToInt32(comando.ExecuteScalar());
                Close();

                if (cantDisponible>=mpu.CantUtilizada)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        public StockMPrima ObtenerPorIndex(int index)
        {
            var lista = GetAll();

            return lista[index];
        }
        public int ObtenerIndexPorId(int id)
        {
            var lista = GetAll();
            int cont = 0;
            foreach (var item in lista)
            {

                if (item.Id == id)
                {
                    return cont;
                }
                cont++;
            }
            return -1;
        }

        public bool Existe(string usuario)
        {
            throw new NotImplementedException();
        }
        public bool ExisteId(int id)
        {
            using (var comando = _conexion.CreateCommand())
            {
                comando.CommandText = "SELECT * FROM StockMateriasPrimas WHERE StockMateriaPrimaID = @Id ";
                comando.Parameters.Add("Id", SqlDbType.Int).Value = id;
                Open();
                var lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    Close();
                    return true;
                }
                else
                {
                    Close();
                    return false;
                }

            }

        }
        public bool ExisteIdMprima(int id)
        {
            using (var comando = _conexion.CreateCommand())
            {
                comando.CommandText = "SELECT * FROM StockMateriasPrimas WHERE MateriaPrimaID = @Id ";
                comando.Parameters.Add("Id", SqlDbType.Int).Value = id;
                Open();
                var lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    Close();
                    return true;
                }
                else
                {
                    Close();
                    return false;
                }

            }

        }
    }
}
