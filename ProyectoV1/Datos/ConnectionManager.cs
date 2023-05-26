using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class ConnectionManager
    {
        protected SqlConnection _conexion;

        public ConnectionManager(string connectionString)
        {
            _conexion = new SqlConnection(connectionString);
        }
        public void Open()
        {
            try
            {
                _conexion.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }
        public void Close()
        {
            try
            {
                _conexion.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }
    }
}
