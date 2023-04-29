using Bunifu.UI.WinForms;
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
            this.Dispose();
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
            MessageBox.Show("Hola");
        }
    }
}
