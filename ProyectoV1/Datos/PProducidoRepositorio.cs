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
    public class PProducidoRepositorio : ConnectionManager,ICRUD<ProductoProducido>
    {
        public PProducidoRepositorio(string connectionString) : base(connectionString)
        {
        }
        public int Actualizar(ProductoProducido pp, int id)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"Update ProductosProducidos set Cantidad = @CantUtilizada , IdProducto = @IdProducto , Id_Receta = @Id_Receta WHERE Id= @id";
                Comando.Parameters.Add("CantUtilizada", SqlDbType.Int).Value = pp.CantidadProducto;
                Comando.Parameters.Add("IdProducto", SqlDbType.Int).Value = pp.Producto.Id;
                Comando.Parameters.Add("Id_Receta", SqlDbType.Int).Value = pp.IdReceta;

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
                //Comando.CommandText = $"DELETE FROM Productos WHERE Id = @id";
                Comando.CommandText = $"Update ProductosProducidos set Estado = 0 WHERE Id = @id";
                Comando.Parameters.Add("id", SqlDbType.Int).Value = id;

                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public bool Existe(string nombre)
        {
            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT COUNT(*) FROM ProductosProducidos WHERE Nombre = @Nombre ";
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
        public bool ExisteId(int id)
        {
            using (var comando = _conexion.CreateCommand())
            {
                comando.CommandText = "SELECT * FROM ProductosProducidos WHERE Id = @Id ";
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

        public List<ProductoProducido> GetAll()
        {
            var pp = new List<ProductoProducido>();
            var comando = _conexion.CreateCommand();
            comando.CommandText = "select * from ProductosProducidos WHERE Estado = 1";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                pp.Add(Mapper(lector));
            }
            Close();
            return pp;
        }

        public int Insert(ProductoProducido pp)
        {
            int rows;
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into ProductosProducidos (Cantidad,IdProducto,Id_Receta,Estado)" +
                " values (@CantUtilizada,@IdProducto,@Id_Receta,1)";
                Comando.Parameters.Add("CantUtilizada", SqlDbType.Int).Value = pp.CantidadProducto;
                Comando.Parameters.Add("IdProducto", SqlDbType.Int).Value = pp.Producto.Id;
                Comando.Parameters.Add("Id_Receta", SqlDbType.Int).Value = pp.IdReceta;

                Open();
                rows = Comando.ExecuteNonQuery();
                Close();
            }
            return rows;
        }

        public ProductoProducido Mapper(SqlDataReader dataReader)
        {
            var ppRep = new ProductoRepositorio(this._conexion.ConnectionString);
            var rpRep = new RProduccionRepositorio(this._conexion.ConnectionString);
            var pp = new ProductoProducido();
            if (!dataReader.HasRows) return null;

            pp.Id = dataReader.GetInt32(0);
            pp.CantidadProducto = dataReader.GetInt32(1);
            pp.Producto = ppRep.ObtenerPorId(dataReader.GetInt32(2));
            pp.IdReceta = rpRep.ObtenerPorId(dataReader.GetInt32(3)).Id;


            return pp;
        }

        public ProductoProducido ObtenerPorId(int id)
        {
            var ppu = new ProductoProducido();
            try
            {

                var comando = _conexion.CreateCommand();
                comando.CommandText = "SELECT * FROM ProductosProducidos WHERE id = @id ";
                comando.Parameters.Add("id", SqlDbType.Int).Value = id;
                Open();
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    ppu = Mapper(lector);
                }
                
                return ppu;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Close();
            }
            return ppu;
        }
        public ProductoProducido ObtenerPorIndex(int index)
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
        public List<ProductoProducido> GetPPPorIdReceta(int id)
        {
            var pp = new List<ProductoProducido>();
            try
            {
                
                var comando = _conexion.CreateCommand();
                comando.CommandText = "select * from ProductosProducidos WHERE Estado = 1 AND Id_Receta = @Id_Receta ";
                comando.Parameters.Add("Id_Receta", SqlDbType.Int).Value = id;
                Open();
                SqlDataReader lector = comando.ExecuteReader();
                
                while (lector.Read())
                {
                    pp.Add(Mapper(lector));
                }
                Close();

                return pp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return pp;
        }
    }
}
