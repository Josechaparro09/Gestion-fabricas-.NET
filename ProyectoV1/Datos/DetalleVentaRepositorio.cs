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
    public class DetalleVentaRepositorio : ConnectionManager
    {
        public DetalleVentaRepositorio(string connectionString) : base(connectionString)
        {
        }
        public int Actualizar(DetalleVenta dv, int id)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"Update DetalleVentas set PrecioUnitario = @PUnitario, Cantidad = @Cantidad, Subtotal = @Subtotal IdProducto = @IdProducto , IdVenta = @IdVenta WHERE Id=@Id";
                Comando.Parameters.Add("PUnitario", SqlDbType.Decimal).Value = dv.PrecioUnitario;
                Comando.Parameters.Add("Cantidad", SqlDbType.Int).Value = dv.Cantidad;
                Comando.Parameters.Add("Subtotal", SqlDbType.Decimal).Value = dv.Cantidad * dv.PrecioUnitario;
                Comando.Parameters.Add("IdProducto", SqlDbType.Int).Value = dv.Producto.Id;
                Comando.Parameters.Add("IdVenta", SqlDbType.Int).Value = dv.Venta.Id;

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
                Comando.CommandText = $"DELETE FROM DetalleVentas WHERE Id = @id";
                //Comando.CommandText = $"Update DetalleVenta set Estado = 0 WHERE Id = @id";
                Comando.Parameters.Add("id", SqlDbType.Int).Value = id;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }



        public List<DetalleVenta> GetAll()
        {
            var v = new List<DetalleVenta>();
            var comando = _conexion.CreateCommand();
            comando.CommandText = "select * from DetalleVentas";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                v.Add(Mapper(lector));
            }
            Close();
            return v;
        }
        public List<DetalleVenta> GetAllByIdVenta(int id)
        {
            var v = new List<DetalleVenta>();
            var comando = _conexion.CreateCommand();
            comando.CommandText = "select * from DetalleVentas WHERE IdVenta= @Id";
            comando.Parameters.Add("Id", SqlDbType.Int).Value =id;
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                v.Add(Mapper(lector));
            }
            Close();
            return v;

        }

        public int Insert(DetalleVenta dv)
        {
            int rows;
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into DetalleVentas (PrecioUnitario,Cantidad,Subtotal,IdProducto,IdVenta)" +
                " values (@PUnitario,@Cantidad,@Subtotal,@IdProducto,@IdVenta)";
                Comando.Parameters.Add("PUnitario", SqlDbType.Decimal).Value = dv.PrecioUnitario;
                Comando.Parameters.Add("Cantidad", SqlDbType.Int).Value = dv.Cantidad;
                Comando.Parameters.Add("Subtotal", SqlDbType.Decimal).Value = dv.Cantidad*dv.PrecioUnitario;
                Comando.Parameters.Add("IdProducto", SqlDbType.Int).Value = dv.Producto.Id;
                Comando.Parameters.Add("IdVenta", SqlDbType.Int).Value = dv.Venta.Id;
                Open();
                rows = Comando.ExecuteNonQuery();
                Close();
            }
            return rows;
        }

        public DetalleVenta Mapper(SqlDataReader dataReader)
        {
            var dv = new DetalleVenta();
            if (!dataReader.HasRows) return null;
            var prodRep = new ProductoRepositorio(this._conexion.ConnectionString);
            var ventaRep = new VentaRepositorio(this._conexion.ConnectionString);
            dv.Id = dataReader.GetInt32(0);
            dv.PrecioUnitario = (double)dataReader.GetDecimal(1);
            dv.Cantidad = dataReader.GetInt32(2);
            dv.Subtotal = (double)dataReader.GetDecimal(3);
            dv.Producto = prodRep.ObtenerPorId(dataReader.GetInt32(4));
            dv.Venta = ventaRep.ObtenerPorId(dataReader.GetInt32(5));

            return dv;
        }

        public DetalleVenta ObtenerPorId(int id)
        {
            var v = new DetalleVenta();

            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM DetalleVentas WHERE Id = @id ";
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
        public DetalleVenta ObtenerPorIndex(int index)
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
                comando.CommandText = "SELECT * FROM DetalleVentas WHERE Id = @Id ";
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
