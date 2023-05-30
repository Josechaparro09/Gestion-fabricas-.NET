using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Datos
{
    public class ProductoRepositorio : ConnectionManager,ICRUD<Producto>
    {
        public ProductoRepositorio(string connectionString) : base(connectionString)
        {
        }
        public int Actualizar(Producto producto, int id)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"Update Productos set Nombre = @Nombre , Presentacion = @Presentacion , CostoProduccion = @CostoProduccion , PrecioVenta = @PrecioVenta , IdCategoria = @IdCategoria , IdMedida = @IdMedida , Ganancia = @Ganancia WHERE Id= @id";
                Comando.Parameters.Add("Nombre", SqlDbType.VarChar).Value = producto.Nombre;
                Comando.Parameters.Add("Presentacion", SqlDbType.VarChar).Value = producto.Presentacion;
                Comando.Parameters.Add("CostoProduccion", SqlDbType.VarChar).Value = producto.CostoProduccion;
                Comando.Parameters.Add("PrecioVenta", SqlDbType.VarChar).Value = producto.PrecioVenta;
                Comando.Parameters.Add("IdCategoria", SqlDbType.VarChar).Value = producto.CategoriaProducto.Id;
                Comando.Parameters.Add("IdMedida", SqlDbType.VarChar).Value = producto.MedidaProducto.Id;
                Comando.Parameters.Add("Ganancia", SqlDbType.VarChar).Value = producto.Ganancia;

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
                Comando.CommandText = $"DELETE FROM Productos WHERE Id = @id";
                Comando.Parameters.Add("id", SqlDbType.Int).Value = id;

                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public bool Existe(string nombre)
        {
            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT COUNT(*) FROM Productos WHERE Nombre = @Nombre ";
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

        public List<Producto> GetAll()
        {
            var productos = new List<Producto>();
            var comando = _conexion.CreateCommand();
            comando.CommandText = "select * from Productos";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                productos.Add(Mapper(lector));
            }
            Close();
            return productos;
        }

        public int Insert(Producto producto)
        {
            int rows;
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into Productos (Nombre,Presentacion,CostoProduccion,PrecioVenta,IdCategoria,IdMedida,Ganancia)" +
                " values (@Nombre,@Presentacion,@CostoProduccion,@PrecioVenta,@IdCategoria,@IdMedida,@Ganancia)";
                Comando.Parameters.Add("Nombre", SqlDbType.VarChar).Value = producto.Nombre;
                Comando.Parameters.Add("Presentacion", SqlDbType.VarChar).Value = producto.Presentacion;
                Comando.Parameters.Add("CostoProduccion", SqlDbType.VarChar).Value = producto.CostoProduccion;
                Comando.Parameters.Add("PrecioVenta", SqlDbType.VarChar).Value = producto.PrecioVenta;
                Comando.Parameters.Add("IdCategoria", SqlDbType.VarChar).Value = producto.CategoriaProducto.Id;
                Comando.Parameters.Add("IdMedida", SqlDbType.VarChar).Value = producto.MedidaProducto.Id;
                producto.Ganancia = producto.PrecioVenta-producto.CostoProduccion;
                Comando.Parameters.Add("Ganancia", SqlDbType.VarChar).Value = producto.Ganancia;

                Open();
                rows = Comando.ExecuteNonQuery();
                Close();
            }
            return rows;
        }

        public Producto Mapper(SqlDataReader dataReader)
        {
            var catRep = new CategoriaRepositorio(ConfigurationManager.ConnectionStrings["ProyectoConnection"].ConnectionString);
            var medRep = new MedidasRepositorio(ConfigurationManager.ConnectionStrings["ProyectoConnection"].ConnectionString);
            var prod = new Producto();
            if (!dataReader.HasRows) return null;
            
            prod.Id = dataReader.GetInt32(0);
            prod.Nombre = dataReader.GetString(1);
            prod.Presentacion = dataReader.GetString(2);
            prod.CostoProduccion = (double)dataReader.GetDecimal(3);
            prod.PrecioVenta = (double)dataReader.GetDecimal(4);
            prod.CategoriaProducto = catRep.ObtenerPorId(dataReader.GetInt32(5));
            prod.MedidaProducto = medRep.ObtenerPorId(dataReader.GetInt32(6));
            prod.Ganancia = (double)dataReader.GetDecimal(7);

            return prod;
        }

        public Producto ObtenerPorId(int id)
        {
            var producto = new Producto();

            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM Productos WHERE id = @id ";
            comando.Parameters.Add("id", SqlDbType.Int).Value = id;
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                producto = Mapper(lector);
            }
            Close();
            return producto;
        }
        public Producto ObtenerPorIndex(int index)
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
    }
}
