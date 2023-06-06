using Entidades;
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
    public partial class ProveedorGUI : Form
    {
        ProveedorRepository provRep = new ProveedorRepository(ConfigConnection.connectionString);
        int IdSeleccionado;
        bool editar;
        public ProveedorGUI()
        {
            InitializeComponent();
            tbpProv.SelectedIndex = 0;
        }
        void TraerFormFront(Type tipo)
        {
            if (this.MdiParent is MenuPrincipalGUI formularioPrincipal)
            {
                var formularioSecundario = formularioPrincipal.GetForm(tipo);
                formularioSecundario.BringToFront();
            }
        }
        void listarProveedores()
        {
            tbProve.Rows.Clear();
            var lista = provRep.ObtenerTodos();
            foreach (var prov in lista)
            {
                tbProve.Rows.Add(prov.Id, prov.Nombre, prov.Telefono, prov.Direccion, prov.FRegistro);
            }
        }
        bool validarNumero(string cadena)
        {
            return double.TryParse(cadena, out double numero);
        }
        void editarProveedor()
        {

            var resultado = MessageBox.Show("¿Estás seguro de que deseas editar este proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var proveedor = new Proveedores();
                proveedor.Nombre = txtNombreProv.Text;
                proveedor.Telefono = txtTelefonoProv.Text;
                proveedor.Direccion = txtDireccionProv.Text;
                var filas = provRep.Actualizar(proveedor, IdSeleccionado);
                if (filas == 0)
                {
                    Menu.Show(this, "Hubo un error al guardar", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
                else
                {
                    tbpProv.SelectedIndex = 0;
                    Menu.Show(this, "Proveedor editado correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    txtNombreProv.Text = "";
                    txtTelefonoProv.Text = "";
                    txtDireccionProv.Text = "";
                }

            }

        }

        void GuardarProveedor()
        {
            if (!validarNumero(txtTelefonoProv.Text))
            {
                Menu.Show(this, "Verifique que el telefono sea solo numeros", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);

            }
            else if (txtNombreProv.Text == "" || txtTelefonoProv.Text == "" || txtDireccionProv.Text == "")
            {
                Menu.Show(this, "Verifique que los campos no esten vacios", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else
            {

                if (editar == false)
                {
                    var prov = new Proveedores();
                    prov.Nombre = txtNombreProv.Text;
                    prov.Telefono = txtTelefonoProv.Text;
                    prov.Direccion = txtDireccionProv.Text;
                    provRep.Insertar(prov);
                    tbpProv.SelectedIndex = 0;
                    Menu.Show(this, "Proveedor registrado con exito", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    LimpiarProveedores();
                }
                else
                {
                    editarProveedor();
                }
            }
        }
        void LimpiarProveedores()
        {
            txtNombreProv.Text = "";
            txtTelefonoProv.Text = "";
            txtDireccionProv.Text = "";
        }
        void eliminarProv()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                provRep.Eliminar(IdSeleccionado);
                listarProveedores();
            }
        }
        void pasarProvtxt()
        {
            var proveedor = provRep.ObtenerPorId(IdSeleccionado);
            txtNombreProv.Text = proveedor.Nombre;
            txtTelefonoProv.Text = proveedor.Telefono;
            txtDireccionProv.Text = proveedor.Direccion;
        }

        private void metroTabPage1_Enter(object sender, EventArgs e)
        {
            listarProveedores();
            LimpiarProveedores();
        }

        private void btnNuevoProv_Click(object sender, EventArgs e)
        {
            editar = false;
            lblProv.Text = "Nueva Proveedor";
            tbpProv.SelectedIndex = 1;
        }

        private void tbProve_MouseDown(object sender, MouseEventArgs e)
        {
            var hti = tbProve.HitTest(e.X, e.Y);
            tbProve.ClearSelection();

            if (hti.RowIndex >= 0)
            {
                tbProve.Rows[hti.RowIndex].Selected = true;

                IdSeleccionado = (int)tbProve.Rows[hti.RowIndex].Cells["IdProv"].Value;

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblProv.Text = "Editar proveedor";
            editar = true;
            tbpProv.SelectedIndex = 1;
            pasarProvtxt();
        }

        private void btnInngresarProv_Click(object sender, EventArgs e)
        {
            GuardarProveedor();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            eliminarProv();
        }

        private void tbProve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tbProve.Columns["btnEditar"].Index && e.RowIndex >= 0)
            {


                // Se hizo clic en la imagen de editar
                int filaSeleccionada = e.RowIndex;

                // Obtener el dato a editar en base a la fila seleccionada
                IdSeleccionado = (int)tbProve.Rows[filaSeleccionada].Cells["IdProv"].Value;
                lblProv.Text = "Editar proveedor";
                editar = true;
                tbpProv.SelectedIndex = 1;
                pasarProvtxt();


            }
            else if (e.ColumnIndex == tbProve.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {
                // Se hizo clic en la imagen de eliminar
                int filaSeleccionada = e.RowIndex;

                // Obtener el dato a eliminar en base a la fila seleccionada
                IdSeleccionado = (int)tbProve.Rows[filaSeleccionada].Cells["IdProv"].Value;

                // Llamar al método para eliminar el dato
                eliminarProv();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //var f = new RegistrosGUI();
            //f.MdiParent = this.MdiParent;
            //this.Close();
            //f.Show();
            TraerFormFront(new RegistrosGUI().GetType());
        }

        private void btnAtrasNew_Click(object sender, EventArgs e)
        {
            tbpProv.SelectedIndex = 0;
        }
    }
}
