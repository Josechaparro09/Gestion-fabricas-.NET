using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CompraMPrimaRepositorio : ConnectionManager,ICRUD<CompraMprima>
    {
        public CompraMPrimaRepositorio(string connectionString) : base(connectionString)
        {
        }
        public int Actualizar(CompraMprima cmp, int id)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"Update ComprasMPrimas set Cantidad = @Cantidad, FCompra = @FCompra, Valor = @Valor, IdMPrima = @IdMPrima WHERE Id= @id";
                Comando.Parameters.Add("Cantidad", SqlDbType.Decimal).Value = cmp.Cantidad;
                Comando.Parameters.Add("FCompra", SqlDbType.DateTime).Value = DateTime.Now;
                Comando.Parameters.Add("Valor", SqlDbType.Decimal).Value = cmp.Valor;
                Comando.Parameters.Add("IdMPrima", SqlDbType.Int).Value = cmp.MPrima.Id;
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
                Comando.CommandText = $"DELETE FROM ComprasMPrimas WHERE Id = @id";
                //Comando.CommandText = $"Update RecetaProduccion set Estado = 0 WHERE Id = @id";
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

        public List<CompraMprima> GetAll()
        {
            var cmp = new List<CompraMprima>();
            var comando = _conexion.CreateCommand();
            comando.CommandText = "select * from ComprasMPrimas";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cmp.Add(Mapper(lector));
            }
            Close();
            return cmp;
        }

        public int Insert(CompraMprima cmp)
        {
            int id;
            using (var Comando = _conexion.CreateCommand())
            {
                var smpRep = new StockMPrimasRepositorio(this._conexion.ConnectionString);
                var smp = new StockMPrima();
                
                Comando.CommandText = "Insert Into ComprasMPrimas (Cantidad,FechaCompra,Valor,IdMPrima)" +
                " values (@Cantidad,@FCompra,@Valor,@IdMPrima); SELECT SCOPE_IDENTITY();";
                Comando.Parameters.Add("Cantidad", SqlDbType.Decimal).Value = cmp.Cantidad;
                Comando.Parameters.Add("FCompra", SqlDbType.DateTime).Value = DateTime.Now;
                Comando.Parameters.Add("Valor", SqlDbType.Decimal).Value = cmp.Valor;
                Comando.Parameters.Add("IdMPrima", SqlDbType.Int).Value = cmp.MPrima.Id;
                Open();
                id = Convert.ToInt32(Comando.ExecuteScalar());
                Close();
                 

            }
            return id;
        }


        public CompraMprima Mapper(SqlDataReader dataReader)
        {
            var cmp = new CompraMprima();
            var mpRep = new MPrimaRepositorio(this._conexion.ConnectionString);

            if (!dataReader.HasRows) return null;

            cmp.Id = dataReader.GetInt32(0);
            cmp.Cantidad = (double)dataReader.GetDecimal(1);
            cmp.FCompra = dataReader.GetDateTime(2);
            cmp.Valor = (double)dataReader.GetDecimal(3);
            cmp.MPrima = mpRep.ObtenerPorId(dataReader.GetInt32(4));



            return cmp;
        }

        public CompraMprima ObtenerPorId(int id)
        {
            using (var comando = _conexion.CreateCommand())
            {
                try
                {
                    var rp = new CompraMprima();

                    comando.CommandText = "SELECT * FROM ComprasMPrimas WHERE id = @id ";
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
        public CompraMprima ObtenerPorIndex(int index)
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
