using Entidades;
using Guna.UI.WinForms;
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
    public partial class PlantaGUI : Form
    {
        PlantaRepository plantaRep = new PlantaRepository(ConfigConnection.connectionString);
        EmpleadoRepository empRep = new EmpleadoRepository(ConfigConnection.connectionString);
        int IdSeleccionado;
        bool editar;

        public PlantaGUI()
        {
            InitializeComponent();
            listarPlantas();
            tbpMain.SelectedIndex = 0;
        }
        void TraerFormFront(Type tipo)
        {
            if (this.MdiParent is MenuPrincipalGUI formularioPrincipal)
            {
                var formularioSecundario = formularioPrincipal.GetForm(tipo);
                formularioSecundario.BringToFront();
            }
        }
        void listarPlantas()
        {
            tbPlanta.Rows.Clear();
            var lista = plantaRep.GetAll();
            foreach (var planta in lista)
            {
                tbPlanta.Rows.Add(planta.Id, planta.Nombre, planta.EmpleadoAsignado.Id, planta.EmpleadoAsignado.Nombre);
            }
        }
        void editarPlanta()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas editar esta planta?", "Confirmar edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var planta = new Planta
                {
                    Nombre = txtNombrePlanta.Text,
                    EmpleadoAsignado = empRep.ObtenerPorIndex(cbxEmpPlanta.SelectedIndex)
                };

                var filas = plantaRep.Actualizar(planta, IdSeleccionado);
                if (filas == 0)
                {
                    Menu.Show(this, "Hubo un error al guardar la planta", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
                else
                {
                    tbpMain.SelectedIndex = 0;
                    Menu.Show(this, "Planta editada correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    LimpiarPlanta();
                }
            }
        }
        void GuardarPlanta()
        {
            if (txtNombrePlanta.Text == "")
            {
                Menu.Show(this, "El campo nombre esta vacio", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else if (cbxEmpPlanta.SelectedIndex == -1)
            {
                Menu.Show(this, "No se ha seleccionado ningun empleado", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else
            {
                if (!editar)
                {
                    //obtener a partir de index
                    var planta = new Planta();
                    planta.Nombre = txtNombrePlanta.Text;
                    planta.EmpleadoAsignado = empRep.ObtenerPorIndex(cbxEmpPlanta.SelectedIndex);
                    plantaRep.Insert(planta);
                    tbpMain.SelectedIndex = 0;
                    Menu.Show(this, "Planta agregada correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                }
                else
                {
                    editarPlanta();
                }
            }
        }
        void LimpiarPlanta()
        {
            txtNombrePlanta.Text = "";
            cbxEmpPlanta.SelectedIndex = -1;
        }
        void listarEmpCbx(GunaComboBox cbx)
        {
            cbx.Items.Clear();
            var lista = empRep.GetAll();
            foreach (var emp in lista)
            {
                cbx.Items.Add(emp.Nombre);
            }
        }
        void eliminarPlanta()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar esta planta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                plantaRep.Eliminar(IdSeleccionado);
                listarPlantas();
            }
        }
        void pasarPlanta()
        {

            var planta = plantaRep.ObtenerPorId(IdSeleccionado);
            txtNombrePlanta.Text = planta.Nombre;
            var idEmpleado = int.Parse(tbPlanta.CurrentRow.Cells["IdEmp"].Value.ToString());
            cbxEmpPlanta.SelectedIndex = empRep.ObtenerIndexPorId(idEmpleado);


        }

        private void tbPlanta_MouseDown(object sender, MouseEventArgs e)
        {
            var hti = tbPlanta.HitTest(e.X, e.Y);
            tbPlanta.ClearSelection();

            if (hti.RowIndex >= 0)
            {
                tbPlanta.Rows[hti.RowIndex].Selected = true;

                IdSeleccionado = (int)tbPlanta.Rows[hti.RowIndex].Cells["IdPlanta"].Value;

            }
        }

        private void MObtnEditar_Click(object sender, EventArgs e)
        {
            lblNuevaPlanta.Text = "Editar Planta";
            editar = true;
            tbpMain.SelectedIndex = 1;
            pasarPlanta();
        }

        private void btnIngresarPlanta_Click(object sender, EventArgs e)
        {
            GuardarPlanta();
        }

        private void MObtnEliminar_Click(object sender, EventArgs e)
        {
            eliminarPlanta();
        }

        private void tbPlanta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tbPlanta.Columns["btnEditar"].Index && e.RowIndex >= 0)
            {


                // Se hizo clic en la imagen de editar
                int filaSeleccionada = e.RowIndex;

                // Obtener el dato a editar en base a la fila seleccionada
                IdSeleccionado = (int)tbPlanta.Rows[filaSeleccionada].Cells["IdPlanta"].Value;
                lblNuevaPlanta.Text = "Editar planta";
                editar = true;
                tbpMain.SelectedIndex = 1;
                pasarPlanta();


            }
            else if (e.ColumnIndex == tbPlanta.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {
                // Se hizo clic en la imagen de eliminar
                int filaSeleccionada = e.RowIndex;

                // Obtener el dato a eliminar en base a la fila seleccionada
                IdSeleccionado = (int)tbPlanta.Rows[filaSeleccionada].Cells["IdPlanta"].Value;

                // Llamar al método para eliminar el dato
                eliminarPlanta();
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
            tbpMain.SelectedIndex = 0;
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            editar = false;
            lblNuevaPlanta.Text = "Nueva Planta";
            tbpMain.SelectedIndex = 1;
        }

        private void metroTabPage2_Enter(object sender, EventArgs e)
        {
            listarEmpCbx(cbxEmpPlanta);
        }

        private void metroTabPage1_Enter(object sender, EventArgs e)
        {
            listarPlantas();
            LimpiarPlanta();
        }
    }
}
