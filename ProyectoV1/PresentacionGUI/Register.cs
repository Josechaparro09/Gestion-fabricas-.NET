using Bunifu.UI.WinForms;
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
    public partial class Register : Form
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
        public Register()
        {
            InitializeComponent();
        }
        void vacio(BunifuTextBox txt)
        {

            if (txt.Text != "")
            {

                txt.PasswordChar = '•';
            }
            else
            {
                txt.PasswordChar = '\0';
            }

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            var formulario = new MenuAcceso();
            this.Hide();
            formulario.ShowDialog();
            this.Close();


        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            vacio(txtContra);
        }

        private void txtReContra_TextChanged(object sender, EventArgs e)
        {
            vacio(txtReContra);
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        private void bunifuFormDock1_FormDragging(object sender, BunifuFormDock.FormDraggingEventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Guardar();
            
        }
        void Guardar()
        {
            if (!Existe())
            {
                MessageBox.Show("El usuario ya esta registrado");
                return;
            }
            else
            {
                if (ValidarCamposVacios() && ValidarContraseñaIgual())
                {
                    var usuario = new Usuario();
                    usuario.Nombre = txtNombre.Text;
                    usuario.NUsuario = txtUsuario.Text;
                    usuario.Contrasenia = txtContra.Text;
                    usuario.FRegistro = new DateTime();
                    usuarioRep.Insertar(usuario);
                    MessageBox.Show("Usuario registrado con exito");
                    var f = new MenuAcceso();
                    this.Hide();
                    f.ShowDialog();
                    
                    this.Close();
                    //BarraNotificacion.Show(f,"Usuario registrado con exito");
                }
                
            }
        }
        bool ValidarContraseñaIgual()
        {
            if (txtContra.Text == txtReContra.Text)
            {
                
                return true;
            }
            MessageBox.Show("La contraseña no coincide");
            return false;
        }
        bool longitudMinima()
        {
            var minima = 8;
            if (txtNombre.Text.Length == minima || txtUsuario.Text.Length == minima || txtContra.TextLength == minima || txtReContra.TextLength == minima)
            {
                MessageBox.Show("La longitud minima para los campos es de 8 caracteres");
                return false;
            }
            return true;
        }
        bool ValidarCamposVacios()
        {
            if (txtNombre.Text == "" || txtUsuario.Text == "" || txtContra.Text == "" || txtReContra.Text == "")
            {
                MessageBox.Show("Rectifique que los campos no esten vacios");
                return false;
            }
            return true;
            
        }
        bool Existe()
        {
            return usuarioRep.Existe(txtUsuario.Text);
        }
        void limpiarCampos()
        {
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtContra.Text = "";
            txtReContra.Text = "";
        }
        void MostrarFormulario(Form f)
        {
            this.Hide();
            f.ShowDialog();
            this.Close();

        }
        
    }
}
