
using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RProduccionRepositorio : ConnectionManager,ICRUD<RecetaDeProduccion>
    {
        public RProduccionRepositorio(string connectionString) : base(connectionString)
        {
        }
        public int Actualizar(RecetaDeProduccion rp, int id)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"Update RecetaProduccion set Nombre = @Nombre WHERE Id= @id";
                Comando.Parameters.Add("Nombre", SqlDbType.VarChar).Value = rp.Nombre;
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
                Comando.CommandText = $"Update RecetaProduccion set Estado = 0 WHERE Id = @id";
                Comando.Parameters.Add("id", SqlDbType.Int).Value = id;

                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public bool Existe(string nombre)
        {
            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT COUNT(*) FROM RecetaProduccion WHERE Nombre = @Nombre ";
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

        public List<RecetaDeProduccion> GetAll()
        {
            var recetas = new List<RecetaDeProduccion>();
            var comando = _conexion.CreateCommand();
            comando.CommandText = "select * from RecetaProduccion WHERE Estado = 1";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                recetas.Add(Mapper(lector));
            }
            Close();
            return recetas;
        }

        public int Insert(RecetaDeProduccion rp)
        {
            int id;
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into RecetaProduccion (Nombre,Estado)" +
                " values (@Nombre, 1); SELECT SCOPE_IDENTITY();";
                Comando.Parameters.Add("Nombre", SqlDbType.VarChar).Value = rp.Nombre;
                Open();
                id = Convert.ToInt32(Comando.ExecuteScalar());
                Close();
            }
            return id;
        }
        

        public RecetaDeProduccion Mapper(SqlDataReader dataReader)
        {
            var rp = new RecetaDeProduccion();
            var mpuRep = new MPrimaUtilizadaRepositorio(this._conexion.ConnectionString);
            var ppRep = new PProducidoRepositorio(this._conexion.ConnectionString);

            if (!dataReader.HasRows) return null;
            rp.Id = dataReader.GetInt32(0);
            rp.Nombre = dataReader.GetString(1);
            
            
            return rp;
        }

        public RecetaDeProduccion ObtenerPorId(int id)
        {
            using (var comando = _conexion.CreateCommand())
            {
                try
                {
                    var rp = new RecetaDeProduccion();

                    comando.CommandText = "SELECT * FROM RecetaProduccion WHERE id = @id ";
                    comando.Parameters.Add("id", SqlDbType.Int).Value = id;
                    Open();
                    SqlDataReader lector = comando.ExecuteReader();
                    
                    while (lector.Read())
                    {
                        rp = Mapper(lector);
                    }
                    Close();
                    return rp;
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }
        public RecetaDeProduccion ObtenerPorIndex(int index)
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
