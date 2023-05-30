using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CategoriaRepositorio : ConnectionManager, ICRUD<Categoria>
    {
        public CategoriaRepositorio(string connectionString) : base(connectionString)
        {
        }

        public int Actualizar(Categoria categoria, int id)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"Update Categorias set Nombre = @Nombre WHERE Id= @id";
                Comando.Parameters.Add("Nombre", SqlDbType.VarChar).Value = categoria.Nombre;
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
                Comando.CommandText = $"DELETE FROM Categorias WHERE Id = @id";
                Comando.Parameters.Add("id", SqlDbType.Int).Value = id;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public bool Existe(string nombre)
        {
            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT COUNT(*) FROM Categorias WHERE Nombre = @Nombre ";
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

        public List<Categoria> GetAll()
        {
            List<Categoria> categorias = new List<Categoria>();
            var comando = _conexion.CreateCommand();
            comando.CommandText = "select * from Categorias";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                categorias.Add(Mapper(lector));
            }
            Close();
            return categorias;
        }

        public int Insert(Categoria categoria)
        {
            int rows;
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into Categorias (Nombre)" +
                " values (@Nombre)";
                Comando.Parameters.Add("Nombre", SqlDbType.VarChar).Value = categoria.Nombre;
                Open();
                rows = Comando.ExecuteNonQuery();
                Close();
            }
            return rows;
        }

        public Categoria Mapper(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Categoria categoria = new Categoria();
            categoria.Id = dataReader.GetInt32(0);
            categoria.Nombre = dataReader.GetString(1);
            return categoria;
        }

        public Categoria ObtenerPorId(int id)
        {

            var categoria = new Categoria();

            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM Categorias WHERE id = @id ";
            comando.Parameters.Add("id", SqlDbType.Int).Value = id;
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                categoria = Mapper(lector);
            }
            Close();
            return categoria;
        }
        public Categoria ObtenerPorIndex(int index)
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
