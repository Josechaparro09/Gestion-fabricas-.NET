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
    public class StockProductosRepositorio : ConnectionManager,ICRUD<StockProductos>
    {
        public StockProductosRepositorio(string connectionString) : base(connectionString)
        {
        }
        public int Actualizar(StockProductos stockp, int id)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"Update StockProductos set Cantidad = Cantidad + @Cantidad , FechaActualizacion = @FechaActualizacion WHERE ProductoId=@ProductoId";
                Comando.Parameters.Add("ProductoId", SqlDbType.Int).Value = stockp.producto.Id;
                Comando.Parameters.Add("Cantidad", SqlDbType.Int).Value = stockp.Cantidad;
                Comando.Parameters.Add("FechaActualizacion", SqlDbType.DateTime).Value = DateTime.Now;
                Comando.Parameters.Add("id", SqlDbType.Int).Value = id;

                Open();
                var filas = Comando.ExecuteNonQuery();
                Close();
                return filas;
            }
        }
        public int Actualizar(StockProductos stockp)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"Update StockProductos set Cantidad = Cantidad + @Cantidad , FechaActualizacion = @FechaActualizacion WHERE ProductoId=@ProductoId";
                Comando.Parameters.Add("ProductoId", SqlDbType.Int).Value = stockp.producto.Id;
                Comando.Parameters.Add("Cantidad", SqlDbType.Int).Value = stockp.Cantidad;
                Comando.Parameters.Add("FechaActualizacion", SqlDbType.DateTime).Value = DateTime.Now;

                Open();
                var filas = Comando.ExecuteNonQuery();
                Close();
                return filas;
            }
        }

        public void Eliminar(int id)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"DELETE FROM StockProductos WHERE StockProductoID = @id";
                //Comando.CommandText = $"Update StockProductos set Estado = 0 WHERE Id = @id";
                Comando.Parameters.Add("id", SqlDbType.Int).Value = id;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        

        public List<StockProductos> GetAll()
        {
            var stockp = new List<StockProductos>();
            var comando = _conexion.CreateCommand();
            comando.CommandText = "select * from StockProductos";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                stockp.Add(Mapper(lector));
            }
            Close();
            return stockp;
        }

        public int Insert(StockProductos stockp)
        {
            int rows;
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into StockProductos (ProductoId,Cantidad,FechaActualizacion)" +
                " values (@ProductoId,@Cantidad,@FechaActualizacion)";
                Comando.Parameters.Add("ProductoId", SqlDbType.Int).Value = stockp.producto.Id;
                Comando.Parameters.Add("Cantidad", SqlDbType.Int).Value = stockp.Cantidad;
                Comando.Parameters.Add("FechaActualizacion", SqlDbType.DateTime).Value = DateTime.Now;
                Open();
                rows = Comando.ExecuteNonQuery();
                Close();
            }
            return rows;
        }

        public StockProductos Mapper(SqlDataReader dataReader)
        {
            var prodRed = new ProductoRepositorio(this._conexion.ConnectionString);
            var stockP = new StockProductos();
            var re = new RProduccionRepositorio(this._conexion.ConnectionString);
            if (!dataReader.HasRows) return null;

            stockP.Id = dataReader.GetInt32(0);
            stockP.producto = prodRed.ObtenerPorId(dataReader.GetInt32(1));
            stockP.Cantidad = dataReader.GetInt32(2);
            stockP.FActualizacion = dataReader.GetDateTime(3);

            return stockP;
        }

        public StockProductos ObtenerPorId(int id)
        {
            var stockp = new StockProductos();
            
            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM StockProductos WHERE StockProductoID = @id ";
            comando.Parameters.Add("id", SqlDbType.Int).Value = id;
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                stockp = Mapper(lector);
            }
            Close();
            return stockp;

        }
        public StockProductos ObtenerPorIndex(int index)
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
                comando.CommandText = "SELECT * FROM StockProductos WHERE StockProductoID = @Id ";
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
        public bool ExisteIdProd(int id)
        {
            using (var comando = _conexion.CreateCommand())
            {
                comando.CommandText = "SELECT * FROM StockProductos WHERE ProductoID = @Id ";
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
