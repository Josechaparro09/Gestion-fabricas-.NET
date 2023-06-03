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
    public partial class CategoriaGUI : Form
    {
        CategoriaRepository categoriaRep = new CategoriaRepository(ConfigConnection.connectionString);
        bool editar;
        int IdSeleccionado;
        public CategoriaGUI()
        {
            InitializeComponent();
        }
        void listarCategorias()
        {
            tbCag.Rows.Clear();
            var lista = categoriaRep.ObtenerTodos();
            foreach (var cat in lista)
            {
                tbCag.Rows.Add(cat.Id, cat.Nombre);
            }
        }
        void editarCategoria()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas editar esta categoria?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var cag = new Categoria();
                cag.Nombre = txtNombreCategoria.Text;
                var filas = categoriaRep.Actualizar(cag, IdSeleccionado);
                if (filas == 0)
                {
                    Menu.Show(this, "Hubo un error al guardar la categoria", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
                else
                {
                    tbpCag.SelectedIndex = 0;
                    Menu.Show(this, "Categoria editada correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    LimpiarCategoria();
                }

            }
        }
        void eliminarCag()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar esta categoria?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                categoriaRep.Eliminar(IdSeleccionado);
                listarCategorias();
            }
        }

        void GuardarCategoria()
        {
            if (txtNombreCategoria.Text == "")
            {
                Menu.Show(this, "Los campos estan vacios", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else
            {
                if (!editar)
                {
                    var categoria = new Categoria();
                    categoria.Nombre = txtNombreCategoria.Text;
                    categoriaRep.Insertar(categoria);
                    tbpCag.SelectedIndex = 0;
                    Menu.Show(this, "Categoria agregada correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    LimpiarCategoria();
                }
                else
                {
                    editarCategoria();
                }
            }
        }
        void pasarCagtxt()
        {
            var cag = categoriaRep.ObtenerPorId(IdSeleccionado);
            txtNombreCategoria.Text = cag.Nombre;
        }
        void LimpiarCategoria()
        {
            txtNombreCategoria.Text = "";
        }

        private void btnNuevaCag_Click(object sender, EventArgs e)
        {
            editar = false;
            lblNuevaCag.Text = "Nueva Categoria";
            tbpCag.SelectedIndex = 1;
        }

        private void tbCag_MouseDown(object sender, MouseEventArgs e)
        {
            var hti = tbCag.HitTest(e.X, e.Y);
            tbCag.ClearSelection();

            if (hti.RowIndex >= 0)
            {
                tbCag.Rows[hti.RowIndex].Selected = true;

                IdSeleccionado = (int)tbCag.Rows[hti.RowIndex].Cells["IdCag"].Value;

            }
        }

        private void MObtnEditar_Click(object sender, EventArgs e)
        {
            lblNuevaCag.Text = "Editar Categoria";
            editar = true;
            tbpCag.SelectedIndex = 1;
            pasarCagtxt();
        }

        private void btnIngresarCategoria_Click(object sender, EventArgs e)
        {
            GuardarCategoria();
        }

        private void tbpCag_Enter(object sender, EventArgs e)
        {
            
        }

        private void MObtnEliminar_Click(object sender, EventArgs e)
        {
            eliminarCag();
        }

        private void tbCag_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tbCag.Columns["btnEditar"].Index && e.RowIndex >= 0)
            {


                // Se hizo clic en la imagen de editar
                int filaSeleccionada = e.RowIndex;

                // Obtener el dato a editar en base a la fila seleccionada
                IdSeleccionado = (int)tbCag.Rows[filaSeleccionada].Cells["IdCag"].Value;
                lblNuevaCag.Text = "Editar Categoria";
                editar = true;
                tbpCag.SelectedIndex = 1;
                pasarCagtxt();


            }
            else if (e.ColumnIndex == tbCag.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {
                // Se hizo clic en la imagen de eliminar
                int filaSeleccionada = e.RowIndex;

                // Obtener el dato a eliminar en base a la fila seleccionada
                IdSeleccionado = (int)tbCag.Rows[filaSeleccionada].Cells["IdCag"].Value;

                // Llamar al método para eliminar el dato
                eliminarCag();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            var f = new RegistrosGUI();
            f.MdiParent = this.MdiParent;
            this.Close();
            f.Show();
        }

        private void metroTabPage1_Enter(object sender, EventArgs e)
        {
            listarCategorias();
            LimpiarCategoria();
        }

        private void btnAtrasNew_Click(object sender, EventArgs e)
        {
            tbpCag.SelectedIndex = 0;
        }
    }
}
