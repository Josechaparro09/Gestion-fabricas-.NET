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
            this.Close();
            f.Show();
        }

        void TraerFormFront(Type tipo)
        {
            //OcultarTodos();
            if (this.MdiParent is MenuPrincipalGUI formularioPrincipal)
            {
                var formularioSecundario = formularioPrincipal.GetForm(tipo); 
                formularioSecundario.BringToFront();
            }
        }
        void OcultarTodos()
        {
            foreach (var item in this.MdiChildren)
            {
                item.Hide();
            }
        }
        
        private void btnMedidas_Click(object sender, EventArgs e)
        {
            //MostrarForm(new MedidaGUI());
            TraerFormFront(new MedidaGUI().GetType());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            TraerFormFront(new CategoriaGUI().GetType());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            TraerFormFront(new ProveedorGUI().GetType());
        }

        private void btnPlantas_Click(object sender, EventArgs e)
        {
            TraerFormFront(new PlantaGUI().GetType());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            TraerFormFront(new EmpleadoGUI().GetType());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            TraerFormFront(new ProductoGUI().GetType());
        }
    }
}
