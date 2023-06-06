using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class PlantaRepositorio : ConnectionManager,ICRUD<Planta>
    {
        public PlantaRepositorio(string connectionString) : base(connectionString)
        {
        }

        public int Actualizar(Planta planta, int id)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"Update Plantas set Nombre = @Nombre , idEmpleado = @idEmpleado WHERE Id= @id";
                Comando.Parameters.Add("Nombre", SqlDbType.VarChar).Value = planta.Nombre;
                Comando.Parameters.Add("IdEmpleado", SqlDbType.VarChar).Value = planta.EmpleadoAsignado.Id;
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
                //Comando.CommandText = $"DELETE FROM Plantas WHERE Id = @id";
                Comando.CommandText = $"Update Plantas set Estado = 0 WHERE Id = @id";

                Comando.Parameters.Add("id", SqlDbType.Int).Value = id;

                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public bool Existe(string nombre)
        {
            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT COUNT(*) FROM Plantas WHERE Nombre = @Nombre ";
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

        public List<Planta> GetAll()
        {
            var plantas = new List<Planta>();
            var comando = _conexion.CreateCommand();
            comando.CommandText = "select * from Plantas WHERE Estado = 1";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                plantas.Add(Mapper(lector));
            }
            Close();
            return plantas;
        }

        public int Insert(Planta planta)
        {
            int rows;
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into Plantas (Nombre,IdEmpleado,Estado)" +
                " values (@Nombre,@IdEmpleado,1)";
                Comando.Parameters.Add("Nombre", SqlDbType.VarChar).Value = planta.Nombre;
                Comando.Parameters.Add("IdEmpleado", SqlDbType.VarChar).Value = planta.EmpleadoAsignado.Id;
                Open();
                rows = Comando.ExecuteNonQuery();
                Close();
            }
            return rows;
        }

        public Planta Mapper(SqlDataReader dataReader)
        {
            var empRep = new EmpleadoRepositorio(this._conexion.ConnectionString);
            var emp = new Empleado();
            if (!dataReader.HasRows) return null;
            var planta = new Planta();
            planta.Id = dataReader.GetInt32(0);
            planta.Nombre = dataReader.GetString(1);
            planta.EmpleadoAsignado = empRep.ObtenerPorId(dataReader.GetInt32(2));
            planta.Estado = dataReader.GetBoolean(3);

            return planta;
        }

        public int ObtenerIndexPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Planta ObtenerPorId(int id)
        {
            var planta = new Planta();

            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM Plantas WHERE id = @id ";
            comando.Parameters.Add("id", SqlDbType.Int).Value = id;
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                planta = Mapper(lector);
            }
            Close();
            return planta;
        }

        public Planta ObtenerPorIndex(int index)
        {
            throw new NotImplementedException();
        }
    }
}
