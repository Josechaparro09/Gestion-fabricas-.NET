using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess;

using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using Datos;
using Oracle.DataAccess.Client;
using System.Data.SqlClient;

namespace @as
{
    public partial class Form1 : Form
    {
        Conetion db = new Conetion();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

          

        }
        void conectar()
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        void ListarConsulta()
        {
            var connection = new Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1522/xe;TNS_ADMIN=C:\\Users\\Yurainis\\Oracle\\network\\admin;PASSWORD=admin;USER ID=JOSE";);
            connection.Open();
            var sql = "SELECT * FROM users";
            var dt = new DataTable();
            var adapter = new Oracle.ManagedDataAccess.Client.OracleDataAdapter(sql,connection.Open());
            

        }
    }
}
