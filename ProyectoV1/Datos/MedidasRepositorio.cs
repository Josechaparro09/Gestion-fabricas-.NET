using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class MedidasRepositorio : ConnectionManager , ICRUD<Medida>
    {
        public MedidasRepositorio(string connectionString) : base(connectionString)
        {
        }

        public int Actualizar(Medida medida, int id)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"Update Medidas set NCorto = @NCorto , NLargo = @NLargo WHERE Id= @id";
                Comando.Parameters.Add("NCorto", SqlDbType.VarChar).Value = medida.NombreCorto;
                Comando.Parameters.Add("NLargo", SqlDbType.VarChar).Value = medida.NombreLargo;
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
                //Comando.CommandText = $"DELETE FROM Medidas WHERE Id = @id";
                Comando.CommandText = $"UPDATE Medidas SET Estado = 0 WHERE Id = @id";
                Comando.Parameters.Add("id", SqlDbType.Int).Value = id;

                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public bool Existe(string NCorto)
        {
            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT COUNT(*) FROM Medidas WHERE NCorto = @NCorto ";
            comando.Parameters.Add("NCorto", SqlDbType.VarChar).Value = NCorto;
            Open();
            var contador = (int)comando.ExecuteScalar();
            Close();

            return contador == 0;

            //if (contador != 0)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
        }

        public List<Medida> GetAll()
        {
            List<Medida> medidas = new List<Medida>();
            var comando = _conexion.CreateCommand();
            comando.CommandText = "select * from Medidas WHERE Estado = 1";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                medidas.Add(Mapper(lector));
            }
            Close();
            return medidas;

        }

        public int Insert(Medida medida)
        {
            int rows;
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into Medidas (NCorto,NLargo,Estado)" +
                " values (@NCorto,@NLargo,@Estado)";
                Comando.Parameters.Add("NCorto", SqlDbType.VarChar).Value = medida.NombreCorto;
                Comando.Parameters.Add("NLargo", SqlDbType.VarChar).Value = medida.NombreLargo;
                Comando.Parameters.Add("Estado", SqlDbType.Bit).Value = true;

                Open();
                rows = Comando.ExecuteNonQuery();
                Close();
            }
            return rows;
        }

        public Medida Mapper(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Medida medida = new Medida();
            medida.Id = dataReader.GetInt32(0);
            medida.NombreCorto = dataReader.GetString(1);
            medida.NombreLargo = dataReader.GetString(2);
            medida.Estado = dataReader.GetBoolean(3);
            return medida;
        }

        public Medida ObtenerPorId(int id)
        {
            var medida = new Medida();

            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM Medidas WHERE id = @id ";
            comando.Parameters.Add("id", SqlDbType.Int).Value = id;
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                medida = Mapper(lector);
            }
            Close();
            return medida;
        }
        public Medida ObtenerPorIndex(int index)
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
