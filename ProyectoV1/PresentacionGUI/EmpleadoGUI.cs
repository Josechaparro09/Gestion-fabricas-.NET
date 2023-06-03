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
    public partial class EmpleadoGUI : Form
    {
        EmpleadoRepository empRep = new EmpleadoRepository(ConfigConnection.connectionString);
        int IdSeleccionado;
        bool editar;
        public EmpleadoGUI()
        {
            InitializeComponent();
        }
        void listarEmpleados()
        {
            tbEmpleados.Rows.Clear();
            var lista = empRep.GetAll();
            foreach (var emp in lista)
            {
                tbEmpleados.Rows.Add(emp.Id, emp.Cedula, emp.Nombre + " " + emp.Apellido, emp.Telefono, emp.FechaIngreso);
            }
        }
        void editarEmpleado()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas editar este empleado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var emp = new Empleado();
                emp.Cedula = txtCedulaEMp.Text;
                emp.Nombre = txtNombreEmp.Text;
                emp.Apellido = txtApellidoEmp.Text;
                emp.Telefono = txtTelefonoEmp.Text;

                var filas = empRep.Actualizar(emp, IdSeleccionado);
                if (filas == 0)
                {
                    Menu.Show(this, "Hubo un error al guardar el empleado", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
                else
                {
                    tbpMain.SelectedIndex = 0;
                    Menu.Show(this, "Empleado editado correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    LimpiarEmpleado();
                }

            }
        }
        void GuardarEmp()
        {
            if (!validarNumero(txtTelefonoEmp.Text))
            {
                Menu.Show(this, "Verifique que el telefono sea solo numeros", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else if (!validarNumero(txtCedulaEMp.Text))
            {
                Menu.Show(this, "Verifique que la cedula sea solo numeros", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else if (txtCedulaEMp.Text == "" || txtNombreEmp.Text == "" || txtApellidoEmp.Text == "" || txtTelefonoEmp.Text == "")
            {
                Menu.Show(this, "Verifique que los campos no esten vacios", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else
            {

                if (!editar)
                {
                    var emp = new Empleado();
                    emp.Cedula = txtCedulaEMp.Text;
                    emp.Nombre = txtNombreEmp.Text;
                    emp.Apellido = txtApellidoEmp.Text;
                    emp.Telefono = txtTelefonoEmp.Text;
                    empRep.Insert(emp);
                    tbpMain.SelectedIndex = 0;
                    Menu.Show(this, "Empleado registrado con exito", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    LimpiarEmpleado();
                }
                else
                {
                    editarEmpleado();
                }
            }
        }
        bool validarNumero(string cadena)
        {
            return double.TryParse(cadena, out double numero);
        }
        void LimpiarEmpleado()
        {
            txtCedulaEMp.Text = "";
            txtNombreEmp.Text = "";
            txtApellidoEmp.Text = "";
            txtTelefonoEmp.Text = "";
        }
        void eliminarEmp()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este empleado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                empRep.Eliminar(IdSeleccionado);
                listarEmpleados();
            }
        }
        void pasarEmptxt()
        {
            var emp = empRep.ObtenerPorId(IdSeleccionado);
            txtCedulaEMp.Text = emp.Cedula;
            txtNombreEmp.Text = emp.Nombre;
            txtApellidoEmp.Text = emp.Apellido;
            txtTelefonoEmp.Text = emp.Telefono;
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            editar = false;
            lblNuevoEmpl.Text = "Nuevo empleado";
            tbpMain.SelectedIndex = 1;
        }

        private void tbEmpleados_Enter(object sender, EventArgs e)
        {
            listarEmpleados();
        }

        private void tbEmpleados_MouseDown(object sender, MouseEventArgs e)
        {
            var hti = tbEmpleados.HitTest(e.X, e.Y);
            tbEmpleados.ClearSelection();

            if (hti.RowIndex >= 0)
            {
                tbEmpleados.Rows[hti.RowIndex].Selected = true;

                IdSeleccionado = (int)tbEmpleados.Rows[hti.RowIndex].Cells["IdEmp"].Value;

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblNuevoEmpl.Text = "Editar empleado";
            editar = true;
            tbpMain.SelectedIndex = 1;
            pasarEmptxt();
        }

        private void btnIngresarEmp_Click(object sender, EventArgs e)
        {
            GuardarEmp();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            eliminarEmp();
        }

        private void tbEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tbEmpleados.Columns["btnEditar"].Index && e.RowIndex >= 0)
            {


                // Se hizo clic en la imagen de editar
                int filaSeleccionada = e.RowIndex;

                // Obtener el dato a editar en base a la fila seleccionada
                IdSeleccionado = (int)tbEmpleados.Rows[filaSeleccionada].Cells["IdEmp"].Value;
                lblNuevoEmpl.Text = "Editar empleado";
                editar = true;
                tbpMain.SelectedIndex = 1;
                pasarEmptxt();


            }
            else if (e.ColumnIndex == tbEmpleados.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {
                // Se hizo clic en la imagen de eliminar
                int filaSeleccionada = e.RowIndex;

                // Obtener el dato a eliminar en base a la fila seleccionada
                IdSeleccionado = (int)tbEmpleados.Rows[filaSeleccionada].Cells["IdEmp"].Value;

                // Llamar al método para eliminar el dato
                eliminarEmp();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            var f = new RegistrosGUI();
            f.MdiParent = this.MdiParent;
            this.Close();
            f.Show();
        }

        private void btnAtrasNew_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 0;
        }

        private void metroTabPage1_Enter(object sender, EventArgs e)
        {
            listarEmpleados();
            LimpiarEmpleado();
        }
    }
}
