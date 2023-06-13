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
    public class VentaRepositorio : ConnectionManager,ICRUD<Venta>
    {
        public VentaRepositorio(string connectionString) : base(connectionString)
        {
        }
        
        public int Actualizar(Venta v , int id)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"Update Ventas set FechaVenta = @FechaVenta Total = @Total WHERE Id=@Id";
                Comando.Parameters.Add("FechaVenta", SqlDbType.Int).Value = DateTime.Now;
                Comando.Parameters.Add("Total", SqlDbType.Int).Value = v.Total;
                Comando.Parameters.Add("Id", SqlDbType.DateTime).Value = id;

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
                Comando.CommandText = $"DELETE FROM Ventas WHERE Id = @id";
                //Comando.CommandText = $"Update Venta set Estado = 0 WHERE Id = @id";
                Comando.Parameters.Add("id", SqlDbType.Int).Value = id;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }



        public List<Venta> GetAll()
        {
            var v = new List<Venta>();
            var comando = _conexion.CreateCommand();
            comando.CommandText = "select * from Ventas";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                v.Add(Mapper(lector));
            }
            Close();
            return v;
        }

        public int Insert(Venta v)
        {
            var spRep = new StockProductosRepositorio(this._conexion.ConnectionString);

            int id;
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into Ventas (FechaVenta,Total)" +
                " values (@FechaVenta,@Total); SELECT SCOPE_IDENTITY();";
                Comando.Parameters.Add("FechaVenta", SqlDbType.Date).Value = DateTime.Now;
                Comando.Parameters.Add("Total", SqlDbType.Decimal).Value = v.Total;
                Open();
                id = Convert.ToInt32(Comando.ExecuteScalar());
                Close();
            }
            return id;
        }

        public Venta Mapper(SqlDataReader dataReader)
        {
            var v = new Venta();
            if (!dataReader.HasRows) return null;

            v.Id = dataReader.GetInt32(0);
            v.FechaVenta = dataReader.GetDateTime(1);
            v.Total = (double)dataReader.GetDecimal(2);

            return v;
        }

        public Venta ObtenerPorId(int id)
        {
            var v = new Venta();

            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM Ventas WHERE Id = @id ";
            comando.Parameters.Add("id", SqlDbType.Int).Value = id;
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                v = Mapper(lector);
            }
            Close();
            return v;

        }
        public Venta ObtenerPorIndex(int index)
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
                comando.CommandText = "SELECT * FROM Ventas WHERE Id = @Id ";
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
