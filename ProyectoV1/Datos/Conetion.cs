using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Datos
{
    public class Conetion
    {
        OracleConnection conexion;
        readonly string constring = "Data source: ManueCoronel\\SQL; Initial Catalog=DB; Integrated Security = True";
        public SqlConnection conectardb = new SqlConnection();
        
       
        public Conetion()
        {
            conexion = new OracleConnection(constring);
        }
        public OracleConnection Open()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }
        public void Close()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
        public SqlDataReader ExecuteQuery(string sql)
        {
            SqlCommand command = new SqlCommand(sql, conectardb);
            command.CommandType = CommandType.Text;

            

            SqlDataReader reader = command.ExecuteReader();

            return reader;
        }
        public SqlConnection establecerConexion()
        {
            try
            {
                conectardb.ConnectionString = constring;
                conectardb.Open();
                MessageBox.Show("Conexion realizada correctamente");
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se logro conectar a la base de datos " + e.ToString());

                throw;
            }
            return conectardb;
        }
        public int ExecuteNonQuery(string sql)
        {
            SqlCommand command = new SqlCommand(sql, establecerConexion());
            command.CommandType = CommandType.Text;

            

            int result = command.ExecuteNonQuery();

            Close();

            return result;
        }
    }
}
