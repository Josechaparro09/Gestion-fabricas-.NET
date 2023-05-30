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
    public class ProveedorRepositorio : ConnectionManager, ICRUD<Proveedores>
    {
        public ProveedorRepositorio(string connectionString) : base(connectionString)
        {
        }

        public int Actualizar(Proveedores proveedor, int id)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"Update Proveedores set Nombre = @Nombre , Telefono = @Telefono , Direccion = @Direccion WHERE Id= @id";
                Comando.Parameters.Add("Nombre", SqlDbType.VarChar).Value = proveedor.Nombre;
                Comando.Parameters.Add("Telefono", SqlDbType.VarChar).Value = proveedor.Telefono;
                Comando.Parameters.Add("Direccion", SqlDbType.VarChar).Value = proveedor.Direccion;
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
                Comando.CommandText = $"DELETE FROM Proveedores WHERE Id = @id";
                Comando.Parameters.Add("id", SqlDbType.Int).Value = id;

                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public bool Existe(string nombre)
        {
            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT COUNT(*) FROM Proveedores WHERE Nombre = @Nombre ";
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

        public List<Proveedores> GetAll()
        {
            var proveedores = new List<Proveedores>();
            var comando = _conexion.CreateCommand();
            comando.CommandText = "select * from Proveedores";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                proveedores.Add(Mapper(lector));
            }
            Close();
            return proveedores;
        }

        public int Insert(Proveedores proveedor)
        {
            int rows;
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into Proveedores (Nombre,Telefono,Direccion,FRegistro)" +
                " values (@Nombre,@Telefono,@Direccion,@FRegistro)";
                Comando.Parameters.Add("Nombre", SqlDbType.VarChar).Value = proveedor.Nombre;
                Comando.Parameters.Add("Telefono", SqlDbType.VarChar).Value = proveedor.Telefono;
                Comando.Parameters.Add("Direccion", SqlDbType.VarChar).Value = proveedor.Direccion;
                Comando.Parameters.Add("FRegistro", SqlDbType.DateTime).Value = DateTime.Now;

                Open();
                rows = Comando.ExecuteNonQuery();
                Close();
            }
            return rows;
        }

        public Proveedores Mapper(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            var proveedor = new Proveedores();
            proveedor.Id = dataReader.GetInt32(0);
            proveedor.Nombre = dataReader.GetString(1);
            proveedor.Telefono = dataReader.GetString(2);
            proveedor.Direccion = dataReader.GetString(3);
            proveedor.FRegistro = dataReader.GetDateTime(4);
            return proveedor;
        }

        public Proveedores ObtenerPorId(int id)
        {
            var proveedor = new Proveedores();

            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM Proveedores WHERE id = @id ";
            comando.Parameters.Add("id", SqlDbType.Int).Value = id;
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                proveedor = Mapper(lector);
            }
            Close();
            return proveedor;
        }

        public Proveedores ObtenerPorIndex(int index)
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
