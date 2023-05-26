using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class TablaMedidas : UserControl
    {
        MedidaRepository medidaRepository = new MedidaRepository(ConfigConnection.connectionString);
        public TablaMedidas()
        {
            InitializeComponent();
            tbMedidas.DataSource = medidaRepository.ObtenerTodos();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void cambiarNombre()
        {
            
        }
    }
}
