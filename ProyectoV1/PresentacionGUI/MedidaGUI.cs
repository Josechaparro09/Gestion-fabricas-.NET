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
    public partial class MedidaGUI : Form
    {
        MedidaRepository medidaRep = new MedidaRepository(ConfigConnection.connectionString);
        bool editar;
        int IdSeleccionado;
        public MedidaGUI()
        {
            InitializeComponent();
            listarMedidas();
        }
        void listarMedidas()
        {
            tbMedidas.Rows.Clear();
            var lista = medidaRep.ObtenerTodos();
            foreach (var medida in lista)
            {
                tbMedidas.Rows.Add(medida.Id, medida.NombreCorto, medida.NombreLargo);
            }

        }
        void GuardarMedida()
        {
            if (txtNLargo.Text == "" || txtNombreCorto.Text == "")
            {
                Menu.Show(this, "Rectifique que los campos no esten vacios", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else
            {
                if (!editar)
                {
                    var medida = new Medida
                    {
                        NombreLargo = txtNLargo.Text,
                        NombreCorto = txtNombreCorto.Text
                    };

                    medidaRep.Insertar(medida);
                    tbpMedida.SelectTab(1);
                    Menu.Show(this, "Medida registrada con exito", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    LimpiarCampos();

                }
                else
                {
                    editarMedida();
                }
            }

        }
        void LimpiarCampos()
        {
            txtNombreCorto.Text = "";
            txtNLargo.Text = "";
        }
        void editarMedida()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas editar esta medida?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var medida = new Medida
                {
                    NombreCorto = txtNombreCorto.Text,
                    NombreLargo = txtNLargo.Text
                };
                var filas = medidaRep.Actualizar(medida, IdSeleccionado);
                if (filas == 0)
                {
                    Menu.Show(this, "Hubo un error al guardar la medida", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
                else
                {
                    tbpMedida.SelectedIndex = 0;
                    Menu.Show(this, "Medida editada correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    LimpiarCampos();
                    

                }

            }
        }
        void pasarMedidatxt()
        {
            var medida = medidaRep.ObtenerPorId(IdSeleccionado);
            txtNombreCorto.Text = medida.NombreCorto;
            txtNLargo.Text = medida.NombreLargo;
        }
        void eliminarMedida()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar esta medida?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                medidaRep.Eliminar(IdSeleccionado);
                listarMedidas();
            }
        }

        private void btnNuevaMedida_Click(object sender, EventArgs e)
        {
            editar = false;
            lbNuevaMedida.Text = "Nueva medida";
            tbpMedida.SelectedIndex = 1;
        }

        private void tbMedidas_MouseDown(object sender, MouseEventArgs e)
        {
            var hti = tbMedidas.HitTest(e.X, e.Y);
            tbMedidas.ClearSelection();

            if (hti.RowIndex >= 0)
            {
                tbMedidas.Rows[hti.RowIndex].Selected = true;

                IdSeleccionado = (int)tbMedidas.Rows[hti.RowIndex].Cells["IdMedida"].Value;

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbNuevaMedida.Text = "Editar medida";
            editar = true;
            tbpMedida.SelectedIndex = 1;
            pasarMedidatxt();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            GuardarMedida();
        }

        private void metroTabPage1_Enter(object sender, EventArgs e)
        {
            listarMedidas();
            LimpiarCampos();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            eliminarMedida();
            
        }

        private void tbMedidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbMedidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tbMedidas.Columns["btnEditarMed"].Index && e.RowIndex >= 0)
            {
                

                // Se hizo clic en la imagen de editar
                int filaSeleccionada = e.RowIndex;

                // Obtener el dato a editar en base a la fila seleccionada
                IdSeleccionado= (int)tbMedidas.Rows[filaSeleccionada].Cells["idMedida"].Value;
                lbNuevaMedida.Text = "Editar medida";
                editar = true;
                tbpMedida.SelectedIndex = 1;
                pasarMedidatxt();
                

            }
            else if (e.ColumnIndex == tbMedidas.Columns["btnEliminarMed"].Index && e.RowIndex >= 0)
            {
                // Se hizo clic en la imagen de eliminar
                int filaSeleccionada = e.RowIndex;

                // Obtener el dato a eliminar en base a la fila seleccionada
                IdSeleccionado= (int)tbMedidas.Rows[filaSeleccionada].Cells["idMedida"].Value;

                // Llamar al método para eliminar el dato
                eliminarMedida();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            var f = new RegistrosGUI();
            f.MdiParent = this.MdiParent;
            this.Hide();
            this.Close();
            f.Show();
        }
    }

}
