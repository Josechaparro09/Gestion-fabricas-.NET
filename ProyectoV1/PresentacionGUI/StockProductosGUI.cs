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
    public partial class StockProductosGUI : Form
    {
        StockProductosRepository sprodRep = new StockProductosRepository(ConfigConnection.connectionString);
        StockMPrimaRepository smpRep = new StockMPrimaRepository(ConfigConnection.connectionString);

        public StockProductosGUI()
        {
            InitializeComponent();
            tbpMain.SelectedIndex = 2;
        }
        void listarSProd()
        {
            tbStock.Rows.Clear();
            var lista = sprodRep.GetAll();
            foreach (var sprod in lista)
            {
                tbStock.Rows.Add(sprod.Id,sprod.producto.Id,sprod.producto.Nombre,sprod.Cantidad);
            }
        }
        void listarSMP()
        {
            tbSMP.Rows.Clear();
            var lista = smpRep.GetAll();
            foreach (var smp in lista)
            {
                tbSMP.Rows.Add(smp.Id, smp.Mprima.Id, smp.Mprima.Nombre,smp.Cantidad);
            }
        }

        private void metroTabPage1_Enter(object sender, EventArgs e)
        {
            listarSProd();
        }

        private void metroTabPage2_Enter(object sender, EventArgs e)
        {
            listarSMP();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 2;
        }

        private void btnSMP_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 1;
        }

        private void btnAtras1_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 2;
        }

        private void btnSProd_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 0;
        }
    }
}
