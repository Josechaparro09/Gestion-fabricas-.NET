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
    public partial class MenuAcceso : Form
    {
        public MenuAcceso()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            var formulario = new Login();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            var formulario = new Register();
            
            this.Hide();
            formulario.ShowDialog();
            this.Close();
        }
    }
}
