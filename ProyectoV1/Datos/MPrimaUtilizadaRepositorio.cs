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
    public class MPrimaUtilizadaRepositorio : ConnectionManager,ICRUD<MateriaPrimaUtilizada>
    {
        public MPrimaUtilizadaRepositorio(string connectionString) : base(connectionString)
        {
        }
        public int Actualizar(MateriaPrimaUtilizada mp, int id)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"Update MPrimaUtilizada set CantUtilizada = @CantUtilizada , IdMPrima = @IdMPrima , Id_Receta = @Id_Receta WHERE Id= @id";
                Comando.Parameters.Add("CantUtilizada", SqlDbType.Decimal).Value = mp.CantUtilizada;
                Comando.Parameters.Add("IdMPrima", SqlDbType.Int).Value = mp.MPrimaUtilizada.Id;
                Comando.Parameters.Add("Id_Receta", SqlDbType.Int).Value = mp.IdReceta;

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
                Comando.CommandText = $"Update MPrimaUtilizada set Estado = 0 WHERE Id = @id";
                Comando.Parameters.Add("id", SqlDbType.Int).Value = id;

                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public bool Existe(string nombre)
        {
            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT COUNT(*) FROM MPrimaUtilizada WHERE Nombre = @Nombre ";
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

        public List<MateriaPrimaUtilizada> GetAll()
        {
            var mp = new List<MateriaPrimaUtilizada>();
            var comando = _conexion.CreateCommand();
            comando.CommandText = "select * from MPrimaUtilizada WHERE Estado = 1";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                mp.Add(Mapper(lector));
            }
            Close();
            return mp;
        }

        public int Insert(MateriaPrimaUtilizada mp)
        {
            int rows;
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into MPrimaUtilizada (CantUtilizada,IdMPrima,Id_Receta,Estado)" +
                " values (@CantUtilizada,@IdMPrima,@Id_Receta,1)";
                Comando.Parameters.Add("CantUtilizada", SqlDbType.Decimal).Value = mp.CantUtilizada;
                Comando.Parameters.Add("IdMPrima", SqlDbType.Int).Value = mp.MPrimaUtilizada.Id;
                Comando.Parameters.Add("Id_Receta", SqlDbType.Int).Value = mp.IdReceta;

                Open();
                rows = Comando.ExecuteNonQuery();
                Close();
            }
            return rows;
        }

        public MateriaPrimaUtilizada Mapper(SqlDataReader dataReader)
        {
            var mpRep = new MPrimaRepositorio(this._conexion.ConnectionString);
            var rpRep = new RProduccionRepositorio(this._conexion.ConnectionString);
            var mpu = new MateriaPrimaUtilizada();
            if (!dataReader.HasRows) return null;

            mpu.Id = dataReader.GetInt32(0);
            mpu.CantUtilizada = (double)dataReader.GetDecimal(1);
            mpu.MPrimaUtilizada = mpRep.ObtenerPorId(dataReader.GetInt32(2));
            mpu.IdReceta = rpRep.ObtenerPorId(dataReader.GetInt32(3)).Id;


            return mpu;
        }

        public MateriaPrimaUtilizada ObtenerPorId(int id)
        {
            var mpu = new MateriaPrimaUtilizada();

            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM MPrimaUtilizada WHERE id = @id ";
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
        public MateriaPrimaUtilizada ObtenerPorIndex(int index)
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
        public List<MateriaPrimaUtilizada> GetMPPorIdReceta(int id)
        {
            var mp = new List<MateriaPrimaUtilizada>();
            try
            {
                
                var comando = _conexion.CreateCommand();
                comando.CommandText = "select * from MPrimaUtilizada WHERE Estado = 1 AND Id_Receta = @Id_Receta ";
                comando.Parameters.Add("Id_Receta", SqlDbType.Int).Value = id;
                Open();

                SqlDataReader lector = comando.ExecuteReader();
                
                while (lector.Read())
                {
                    mp.Add(Mapper(lector));
                }
                Close();
                return mp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return mp;
        }
        public bool ExisteId(int id)
        {
            using (var comando = _conexion.CreateCommand())
            {
                comando.CommandText = "SELECT * FROM MPrimaUtilizada WHERE Id = @Id ";
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
