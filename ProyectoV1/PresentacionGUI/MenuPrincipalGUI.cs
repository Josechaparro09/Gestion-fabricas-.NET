using Entidades;
using Guna.UI.WinForms;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class MenuPrincipalGUI : Form
    {
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

        

        public string Usuario { get; set; }
        List<Form> forms;
        public MenuPrincipalGUI(string usuario)
        {
            InitializeComponent();
            Usuario = usuario;
            //CargarBienvenida();
            forms = CargarTodosForm();
            AbrirForm(new BienvenidaGUI("Bienvenid@ " + this.Usuario));
            

        }
       

        public bool VerificarFormAbierto(Type tipoFormulario)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == tipoFormulario)
                {
                    return true;
                }
            }

            return false;
        }
        Form AbrirForm(Form f)
        {
            //bool formularioCargado = false;
            //foreach (Form form in this.MdiChildren)
            //{
            //    if (form.GetType() == f.GetType())
            //    {
            //        formularioCargado = true;
            //        form.BringToFront();
            //        break;
            //    }
            //}

            f.MdiParent = this;
            f.Show();
            return f;
        }
        List<Form> CargarTodosForm()
        {
            var lista = new List<Form>
            {
                AbrirForm(new RegistrosGUI()),
                AbrirForm(new CategoriaGUI()),
                AbrirForm(new EmpleadoGUI()),
                AbrirForm(new InsumosGUI()),
                AbrirForm(new MedidaGUI()),
                AbrirForm(new PlantaGUI()),
                AbrirForm(new ProduccionGUI()),
                AbrirForm(new ProductoGUI()),
                AbrirForm(new ProveedorGUI()),
                AbrirForm(new RecetaProduccionGUI())
            };
            return lista;

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

        

        //void mostrarTablaMedidas()
        //{

        //    if (!tbMedida.Controls.Contains(tabla))
        //    {
        //        tbMedida.Controls.Add(tabla);
        //    }
        //}

        private void tbMedida_Click(object sender, EventArgs e)
        {

        }

        



        private void btnProductos_Click(object sender, EventArgs e)
        {
 
        }

        
        void CerrarFormularios()
        {
            foreach (Form formulario in this.MdiChildren)
            {
                formulario.Close();
            }
        }

        public Form GetForm(Type tipo)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == tipo)
                {
                    return form;
                }
            }

            return null; // Si no se encuentra el formulario secundario, devolver null o manejarlo según tus necesidades
        }
        void ocultarTodos()
        {
            foreach (var item in forms)
            {
                item.Hide();
            }
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {


            //tbpMain.SelectedIndex = 0;
            //ocultarTodos();
            forms[0].BringToFront();
            

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            //ocultarTodos();
            forms[6].BringToFront();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            //ocultarTodos();
            forms[3].BringToFront();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {

        }



        //_validaciones








        

        

        

        



       

        

        




        //MOCag Editar
        
        //MOCag Eliminar









        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {

            forms[9].BringToFront();
        }

        private void gunaControlBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
