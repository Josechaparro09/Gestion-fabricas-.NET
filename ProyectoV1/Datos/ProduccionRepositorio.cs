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
    public class ProduccionRepositorio : ConnectionManager, ICRUD<Produccion>
    {
        public ProduccionRepositorio(string connectionString) : base(connectionString)
        {
        }
        public int Actualizar(Produccion p, int id)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"Update DetallesProduccion set Cantidad = @Cantidad , FProduccion = @FProduccion , IdReceta = @IdReceta WHERE Id= @id";
                Comando.Parameters.Add("Cantidad", SqlDbType.Decimal).Value = p.cantidadProducida;
                Comando.Parameters.Add("FProduccion", SqlDbType.Int).Value = DateTime.Now;
                Comando.Parameters.Add("IdReceta", SqlDbType.Int).Value = p.RProduccion.Id;

                Comando.Parameters.Add("id", SqlDbType.Int).Value = id;

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
                Comando.CommandText = $"DELETE FROM DetallesProduccion WHERE Id = @id";
                //Comando.CommandText = $"Update DetallesProduccion set Estado = 0 WHERE Id = @id";
                Comando.Parameters.Add("id", SqlDbType.Int).Value = id;

                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }
        public void DescontarProductos(int idpp , int cant)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                //Comando.CommandText = $"DELETE FROM Productos WHERE Id = @id";
                Comando.CommandText = $"Update StockProductos set Cantidad == Cantidad - @cant WHERE ProductoID = @idpp";
                Comando.Parameters.Add("cant", SqlDbType.Int).Value = cant;
                Comando.Parameters.Add("idpp", SqlDbType.Int).Value = idpp;


                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }
        public void RestaurarMprima(double idmpu , int cant )
        {
            using (var Comando = _conexion.CreateCommand())
            {
                //Comando.CommandText = $"DELETE FROM Productos WHERE Id = @id";
                Comando.CommandText = $"Update StockMateriasPrimas set Cantidad == Cantidad + @cant WHERE MateriaPrimaId = @idmpu";
                Comando.Parameters.Add("cant", SqlDbType.Decimal).Value = cant;
                Comando.Parameters.Add("idmpu", SqlDbType.Int).Value = idmpu;


                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public bool Existe(string nombre)
        {
            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT COUNT(*) FROM DetallesProduccion WHERE Nombre = @Nombre ";
            comando.Parameters.Add("Nombre", SqlDbType.VarChar).Value = nombre;
            Open();
            var contador = (int)comando.ExecuteScalar();
            Close();
            if (contador != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Produccion> GetAll()
        {
            var mp = new List<Produccion>();
            var comando = _conexion.CreateCommand();
            comando.CommandText = "select * from DetallesProduccion";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                mp.Add(Mapper(lector));
            }
            Close();
            return mp;
        }

        public int Insert(Produccion p)
        {
            int id;
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into DetallesProduccion (Cantidad,FProduccion,IdReceta)" +
                " values (@Cantidad,@FProduccion,@IdReceta); SELECT SCOPE_IDENTITY();";
                Comando.Parameters.Add("Cantidad", SqlDbType.Int).Value = p.cantidadProducida;
                Comando.Parameters.Add("FProduccion", SqlDbType.DateTime).Value = DateTime.Now;
                Comando.Parameters.Add("IdReceta", SqlDbType.Int).Value = p.RProduccion.Id;

                Open();
                id = Convert.ToInt32(Comando.ExecuteScalar());
                Close();
            }
            return id;
        }

        public Produccion Mapper(SqlDataReader dataReader)
        {
            var rpRep = new RProduccionRepositorio(this._conexion.ConnectionString);
            var p = new Produccion();
            if (!dataReader.HasRows) return null;

            p.Id = dataReader.GetInt32(0);
            p.cantidadProducida = dataReader.GetInt32(1);
            p.FechaProduccion = dataReader.GetDateTime(2);
            p.RProduccion = rpRep.ObtenerPorId(dataReader.GetInt32(3));


            return p;
        }

        public Produccion ObtenerPorId(int id)
        {
            var mpu = new Produccion();

            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM DetallesProduccion WHERE id = @id ";
            comando.Parameters.Add("id", SqlDbType.Int).Value = id;
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                mpu = Mapper(lector);
            }
            Close();
            return mpu;
        }
        public Produccion ObtenerPorIndex(int index)
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
        
        public bool ExisteId(int id)
        {
            using (var comando = _conexion.CreateCommand())
            {
                comando.CommandText = "SELECT * FROM DetallesProduccion WHERE Id = @Id ";
                comando.Parameters.Add("Id", SqlDbType.VarChar).Value = id;
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
