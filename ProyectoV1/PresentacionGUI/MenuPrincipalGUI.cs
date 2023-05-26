using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class MenuPrincipalGUI : Form
    {
        TablaMedidas tabla = new TablaMedidas();
        #region 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Rectangle sizeGripRectangle;
        bool inSizeDrag = false;
        const int GRIP_SIZE = 15;

        int w = 0;
        int h = 0;
        #endregion
        MedidaRepository medidaRep = new MedidaRepository(ConfigConnection.connectionString);
        public MenuPrincipalGUI(string usuario)
        {
            InitializeComponent();
            this.lblNombre.Text = usuario;
      
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void MenuPrincipalGUI_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usuarios.Users' Puede moverla o quitarla según sea necesario.


        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            
            

        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMedidas_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 4;
            tbMedidas.DataSource = medidaRep.ObtenerTodos();
        }
        void mostrarTablaMedidas()
        {
            
            if (!tbMedida.Controls.Contains(tabla))
            {
                tbMedida.Controls.Add(tabla);
            }
        }

        private void tbMedida_Click(object sender, EventArgs e)
        {

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 5;
            var tabla = new Tabla_Categorias();

            if (!tbCategorias.Controls.Contains(tabla))
            {
                tbCategorias.Controls.Add(tabla);
            }
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 6;
            var tabla = new TablaProveedores();

            if (!tbProveedores.Controls.Contains(tabla))
            {
                tbProveedores.Controls.Add(tabla);
            }
        }

        private void btnPlantas_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 7;
            var tabla = new TablaPlantas();

            if (!tbPlantas.Controls.Contains(tabla))
            {
                tbPlantas.Controls.Add(tabla);
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 8;
            var tabla = new TablaProductos();

            if (!tbProductos.Controls.Contains(tabla))
            {
                tbProductos.Controls.Add(tabla);
            }
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 0;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 1;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 2;
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 3;
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            GuardarMedida();
        }

        bool validarVaciosMedida()
        {
            if (txtNLargo.Text == "" || txtNombreCorto.Text == "")
            {
                
                return true;
            }
            else
            {
                return false;
            }
        }
        void GuardarMedida()
        {
            if (validarVaciosMedida())
            {
                Menu.Show(this, "Rectifique los campos");
            }
            else
            {
                Medida medida = new Medida();
                medida.NombreLargo = txtNLargo.Text;
                medida.NombreCorto = txtNombreCorto.Text;
                medidaRep.Insertar(medida);
                tbpMain.SelectTab(4);
                Menu.Show(this, "Medida registrada con exito");
                txtNLargo.Text = "";
                txtNombreCorto.Text = "";
            }
            
        }


        private void gunaButton5_Click(object sender, EventArgs e)
        {
            tbpMain.SelectTab(9);
        }

        private void tbMedida_Enter(object sender, EventArgs e)
        {
            tbMedidas.DataSource = medidaRep.ObtenerTodos();
        }
    }
}
