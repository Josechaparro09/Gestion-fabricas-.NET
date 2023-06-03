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
    public partial class RegistrosGUI : Form
    {
        public RegistrosGUI()
        {
            InitializeComponent();
        }
        void MostrarForm(Form f)
        {
            f.MdiParent = this.MdiParent;
            this.Hide();
            this.Close();
            f.Show();
        }
        private void btnMedidas_Click(object sender, EventArgs e)
        {
            MostrarForm(new MedidaGUI());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            MostrarForm(new CategoriaGUI());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            MostrarForm(new ProveedorGUI());
        }

        private void btnPlantas_Click(object sender, EventArgs e)
        {
            MostrarForm(new PlantaGUI());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            MostrarForm(new EmpleadoGUI());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            MostrarForm(new ProductoGUI());
        }
    }
}
