using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Logica;

namespace PresentacionGUI
{
    public partial class Login : Form
    {
        UsuarioRepository usuarioRep = new UsuarioRepository(ConfigConnection.connectionString);
        #region 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        const int GRIP_SIZE = 15;

        int w = 0;
        int h = 0;
        #endregion

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usuarios.Users' Puede moverla o quitarla según sea necesario.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connectionString = "Data source= ManueCoronel\\SQL; Initial Catalog=DB; Integrated Security = True;";
            //string queryString = "SELECT * FROM users";
           
            //SqlConnection connection = new SqlConnection(connectionString);
            //SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);

            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //grilleusers.DataSource = dataTable;
        }
   
        

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            var formulario = new MenuAcceso();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
        }

        private void bunifuTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
        }
        void vacio()
        {

            if (txtContra.Text != "")
            {
                
                txtContra.PasswordChar = '•';
            }
            else
            {
                txtContra.PasswordChar = '\0';
            }
            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void txtContra_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void txtContra_TextChange(object sender, EventArgs e)
        {
            vacio();
            
        }
        void IniciarSesion()
        {
            var nombre  = usuarioRep.ValidarUsuario(txtUsuario.Text, txtContra.Text);
            if (nombre!=null)
            {
                var formulario = new MenuPrincipalGUI(nombre);
                this.Hide();
                formulario.ShowDialog();
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Los datos ingresados no son correctos");
                BarraNotificacion.Show(this , "Los datos ingresados no son correctos");
            }
        }
    }
}
