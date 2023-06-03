using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class MPrimaRepositorio : ConnectionManager,ICRUD<MateriaPrima>
    {
        public MPrimaRepositorio(string connectionString) : base(connectionString)
        {
        }
        public int Actualizar(MateriaPrima mprima, int id)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"Update MateriasPrimas set Nombre = @Nombre , FechaExpiracion = @FExpiracion , IdMedida = @IdMedida , IdProveedor = @IdProveedor WHERE Id= @id";
                Comando.Parameters.Add("Nombre", SqlDbType.VarChar).Value = mprima.Nombre;
                Comando.Parameters.Add("FExpiracion", SqlDbType.DateTime).Value = mprima.FechaExpiracion;
                Comando.Parameters.Add("IdMedida", SqlDbType.Int).Value = mprima.Medida.Id;
                Comando.Parameters.Add("IdProveedor", SqlDbType.Int).Value = mprima.Proveedor.Id;

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
                //Comando.CommandText = $"DELETE FROM MateriasPrimas WHERE Id = @id";
                Comando.CommandText = $"Update MateriasPrimas set Estado = 0 WHERE Id = @id";

                Comando.Parameters.Add("id", SqlDbType.Int).Value = id;

                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public bool Existe(string nombre)
        {
            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT COUNT(*) FROM MateriasPrimas WHERE Nombre = @Nombre ";
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

        public List<MateriaPrima> GetAll()
        {
            var mprima = new List<MateriaPrima>();
            var comando = _conexion.CreateCommand();
            comando.CommandText = "select * from MateriasPrimas WHERE Estado = 1";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                mprima.Add(Mapper(lector));
            }
            Close();
            return mprima;
        }

        public int Insert(MateriaPrima mprima)
        {
            int rows;
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into MateriasPrimas (Nombre,FechaCompra,FechaExpiracion,IdMedida,IdProveedor,Estado)" +
                " values (@Nombre,@FCompra,@FExpiracion,@IdMedida,@IdProveedor,1)";
                Comando.Parameters.Add("Nombre", SqlDbType.VarChar).Value = mprima.Nombre;
                Comando.Parameters.Add("FCompra", SqlDbType.DateTime).Value = DateTime.Now;
                Comando.Parameters.Add("FExpiracion", SqlDbType.DateTime).Value = mprima.FechaExpiracion;
                Comando.Parameters.Add("IdMedida", SqlDbType.Int).Value = mprima.Medida.Id;
                Comando.Parameters.Add("IdProveedor", SqlDbType.Int).Value = mprima.Proveedor.Id;

                Open();

                rows = Comando.ExecuteNonQuery();
                Close();
            }
            return rows;
        }

        public MateriaPrima Mapper(SqlDataReader dataReader)
        {
            var provRep = new ProveedorRepositorio(ConfigurationManager.ConnectionStrings["ProyectoConnection"].ConnectionString);
            var medRep = new MedidasRepositorio(ConfigurationManager.ConnectionStrings["ProyectoConnection"].ConnectionString);
            var mprima = new MateriaPrima();
            if (!dataReader.HasRows) return null;

            mprima.Id = dataReader.GetInt32(0);
            mprima.Nombre = dataReader.GetString(1);
            mprima.FechaCompra = dataReader.GetDateTime(2);
            mprima.FechaExpiracion = dataReader.GetDateTime(3);
            mprima.Medida = medRep.ObtenerPorId(dataReader.GetInt32(4));
            mprima.Proveedor = provRep.ObtenerPorId(dataReader.GetInt32(5));
            mprima.Estado = dataReader.GetBoolean(6);

            return mprima;
        }

        public MateriaPrima ObtenerPorId(int id)
        {
            var mprima = new MateriaPrima();

            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM MateriasPrimas WHERE id = @id ";
            comando.Parameters.Add("id", SqlDbType.Int).Value = id;
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                mprima = Mapper(lector);
            }
            Close();
            return mprima;
        }
        public MateriaPrima ObtenerPorIndex(int index)
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
