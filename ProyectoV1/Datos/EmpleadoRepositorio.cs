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
    public class EmpleadoRepositorio : ConnectionManager,ICRUD<Empleado>
    {
        public EmpleadoRepositorio(string connectionString) : base(connectionString)
        {
        }

        public int Actualizar(Empleado empleado, int id)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"Update Empleados set Cedula = @Cedula , Nombre = @Nombre , Apellido = @Apellido , Telefono = @Telefono WHERE Id= @id";
                Comando.Parameters.Add("Cedula", SqlDbType.VarChar).Value = empleado.Cedula;
                Comando.Parameters.Add("Nombre", SqlDbType.VarChar).Value = empleado.Nombre;
                Comando.Parameters.Add("Apellido", SqlDbType.VarChar).Value = empleado.Apellido;
                Comando.Parameters.Add("Telefono", SqlDbType.VarChar).Value = empleado.Telefono;
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
                Comando.CommandText = $"DELETE FROM Empleados WHERE Id = @id";
                Comando.Parameters.Add("id", SqlDbType.Int).Value = id;

                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public bool Existe(string nombre)
        {
            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT COUNT(*) FROM Empleados WHERE Nombre = @Nombre ";
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

        public List<Empleado> GetAll()
        {
            var empleados = new List<Empleado>();
            var comando = _conexion.CreateCommand();
            comando.CommandText = "select * from Empleados";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                empleados.Add(Mapper(lector));
            }
            Close();
            return empleados;
        }

        public int Insert(Empleado empleado)
        {
            int rows;
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into Empleados (Cedula,Nombre,Apellido,Telefono,FIngreso)" +
                " values (@Cedula,@Nombre,@Apellido,@Telefono,@FIngreso)";
                Comando.Parameters.Add("Cedula", SqlDbType.VarChar).Value = empleado.Cedula;
                Comando.Parameters.Add("Nombre", SqlDbType.VarChar).Value = empleado.Nombre;
                Comando.Parameters.Add("Apellido", SqlDbType.VarChar).Value = empleado.Apellido;
                Comando.Parameters.Add("Telefono", SqlDbType.VarChar).Value = empleado.Telefono;
                Comando.Parameters.Add("FIngreso", SqlDbType.DateTime).Value = DateTime.Now;

                Open();
                rows = Comando.ExecuteNonQuery();
                Close();
            }
            return rows;
        }

        public Empleado Mapper(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            var empleado = new Empleado();
            empleado.Id = dataReader.GetInt32(0);
            empleado.Cedula = dataReader.GetString(1);
            empleado.Nombre = dataReader.GetString(2);
            empleado.Apellido = dataReader.GetString(3);
            empleado.Telefono = dataReader.GetString(4);
            empleado.FechaIngreso = dataReader.GetDateTime(5);

            return empleado;
        }

        public Empleado ObtenerPorId(int id)
        {
            var empleado = new Empleado();

            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM Empleados WHERE id = @id ";
            comando.Parameters.Add("id", SqlDbType.Int).Value = id;
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                empleado = Mapper(lector);
            }
            Close();
            return empleado;
        }
        public Empleado ObtenerPorIndex(int index)
        {
            var lista = GetAll();

            return lista[index];
        }
        public int ObtenerIndexPorId(int id)
        {
            var lista = GetAll();
            int cont=0;
            foreach (var item in lista)
            {
                
                if (item.Id==id)
                {
                    return cont;
                }
                cont++;
            }
            return -1;
        }
    }
}
