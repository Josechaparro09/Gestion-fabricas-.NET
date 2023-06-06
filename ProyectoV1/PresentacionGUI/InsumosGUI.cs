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
    public partial class InsumosGUI : Form
    {
        MPrimaRepository mprimaRep = new MPrimaRepository(ConfigConnection.connectionString);
        ProveedorRepository provRep = new ProveedorRepository(ConfigConnection.connectionString);
        MedidaRepository medidaRep = new MedidaRepository(ConfigConnection.connectionString);
        StockMPrimaRepository smpRep = new StockMPrimaRepository(ConfigConnection.connectionString);
        CompraMPrimaRepository cmpRep = new CompraMPrimaRepository(ConfigConnection.connectionString);
        int IdSeleccionado;
        bool editar;
        public InsumosGUI()
        {
            InitializeComponent();
            tbpMain.SelectedIndex = 0;
        }
        void listarProvCbx(GunaComboBox cbx)
        {
            cbx.Items.Clear();
            var lista = provRep.ObtenerTodos();
            foreach (var prov in lista)
            {
                cbx.Items.Add(prov.Nombre);
            }
        }
        void TraerFormFront(Type tipo)
        {
            //OcultarTodos();
            if (this.MdiParent is MenuPrincipalGUI formularioPrincipal)
            {
                var formularioSecundario = formularioPrincipal.GetForm(tipo);
                formularioSecundario.BringToFront();
            }
        }
        void listarMedCbx(GunaComboBox cbx)
        {
            cbx.Items.Clear();
            var lista = medidaRep.ObtenerTodos();
            foreach (var med in lista)
            {
                cbx.Items.Add(med.NombreCorto);
            }
        }
        void listarMPrima()
        {
            tbMPrima.Rows.Clear();
            var lista = mprimaRep.GetAll();
            foreach (var mprima in lista)
            {
                tbMPrima.Rows.Add(mprima.Id, mprima.Nombre, mprima.FechaCompra, mprima.FechaExpiracion, mprima.Medida.Id, mprima.Medida.NombreCorto, mprima.Proveedor.Id, mprima.Proveedor.Nombre);
            }
        }
        void listarInsumos()
        {
            tbCInsumo.Rows.Clear();
            var lista = cmpRep.GetAll();
            foreach (var compra in lista)
            {
                tbCInsumo.Rows.Add(compra.Id,compra.MPrima.Id,compra.MPrima.Nombre,compra.Cantidad,compra.Valor,compra.FCompra);
            }
        }
        void editarMPrima()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas editar este insumo?", "Confirmar edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var mprima = new MateriaPrima();
                mprima.Nombre = txtNombreInsumo.Text;
                mprima.FechaExpiracion = dpFExpiracionInsumo.Value;
                mprima.Proveedor = provRep.ObtenerPorIndex(cbxProveedorInsumo.SelectedIndex); ;
                mprima.Medida = medidaRep.ObtenerPorIndex(cbxMedidaInsumo.SelectedIndex);
                var filas = mprimaRep.Actualizar(mprima, IdSeleccionado);
                if (filas == 0)
                {
                    Menu.Show(this, "Hubo un error al guardar el insumo", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
                else
                {
                    tbpMain.SelectedIndex = 1;
                    Menu.Show(this, "Insumo editado correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    LimpiarMPrima();
                }
            }
        }
        void GuardarMPrima()
        {
            if (txtNombreInsumo.Text == "")
            {
                Menu.Show(this, "Verifique que el nombre no este vacio", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else if (cbxMedidaInsumo.SelectedIndex == -1)
            {
                Menu.Show(this, "No se ha seleccionado ninguna medida", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else if (cbxProveedorInsumo.SelectedIndex == -1)
            {
                Menu.Show(this, "No se ha seleccionado ningun proveedor", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else
            {
                if (!editar)
                {
                    //obtener a partir de index
                    var mprima = new MateriaPrima();
                    mprima.Nombre = txtNombreInsumo.Text;
                    mprima.Medida = medidaRep.ObtenerPorIndex(cbxMedidaInsumo.SelectedIndex);
                    mprima.Proveedor = provRep.ObtenerPorIndex(cbxProveedorInsumo.SelectedIndex);
                    mprima.FechaExpiracion = dpFExpiracionInsumo.Value;
                    mprimaRep.Insert(mprima);
                    tbpMain.SelectedIndex = 1;
                    Menu.Show(this, "Insumo agregado correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    LimpiarMPrima();
                }
                else
                {
                    editarMPrima();
                }
            }
        }
        void LimpiarMPrima()
        {
            txtNombreInsumo.Text = "";
            cbxMedidaInsumo.SelectedIndex = -1;
            cbxProveedorInsumo.SelectedIndex = -1;
            dpFExpiracionInsumo.Value = DateTime.Now;
        }
        void eliminarMPrima()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este insumo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                mprimaRep.Eliminar(IdSeleccionado);
                listarMPrima();
            }
        }
        void listarInsumoCbx(GunaComboBox cbx)
        {
            cbx.Items.Clear();
            var lista = mprimaRep.GetAll();
            foreach (var mp in lista)
            {
                cbx.Items.Add(mp.Nombre);
            }
        }
        bool validarNumero(string cadena)
        {
            return double.TryParse(cadena, out double numero);
        }

        void ComprarInsumo()
        {
            if (cbxInsumo.SelectedIndex ==-1)
            {
                Menu.Show(this, "No se ha seleccionado ningun insumo", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);

            }
            else if (txtCantInsumo.Text == "")
            {
                Menu.Show(this, "El campo cantidad esta vacio", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);

            }
            else if (!validarNumero(txtCantInsumo.Text))
            {
                Menu.Show(this, "Verifique que la cantidad sea numerica", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);

            }
            else
            {
                
                var cant = double.Parse(txtCantInsumo.Text);
                var idmp = mprimaRep.ObtenerPorIndex(cbxInsumo.SelectedIndex);
                smpRep.ComprarMPrima(cant,idmp.Id);
                var compra = new CompraMprima()
                {
                    Cantidad = cant,
                    Valor = double.Parse(txtValor.Text),
                    MPrima = idmp
                
                };
                cmpRep.Insert(compra);
                
                Menu.Show(this, "Compra agregada correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);

            }
        }
        void pasarMPrimatxt()
        {
            listarMedCbx(cbxMedidaInsumo);
            listarProvCbx(cbxProveedorInsumo);
            var mprima = mprimaRep.ObtenerPorId(IdSeleccionado);
            txtNombreInsumo.Text = mprima.Nombre;

            var idProv = int.Parse(tbMPrima.CurrentRow.Cells["IdProvMPrima"].Value.ToString());
            var idMed = int.Parse(tbMPrima.CurrentRow.Cells["IdMedMPrima"].Value.ToString());

            cbxProveedorInsumo.SelectedIndex = provRep.ObtenerIndexPorId(idProv);
            cbxMedidaInsumo.SelectedIndex = medidaRep.ObtenerIndexPorId(idMed);

            dpFExpiracionInsumo.Value = mprima.FechaExpiracion;

        }



        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            
            editar = false;
            lblNuevoInsumo.Text = "Nuevo insumo";
            tbpMain.SelectedIndex = 2;
        }

        private void gunaAdvenceTileButton9_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 1;
        }

        private void metroTabPage2_Enter(object sender, EventArgs e)
        {
            listarMPrima();
        }

        private void tbMPrima_MouseDown(object sender, MouseEventArgs e)
        {
            var hti = tbMPrima.HitTest(e.X, e.Y);
            tbMPrima.ClearSelection();

            if (hti.RowIndex >= 0)
            {
                tbMPrima.Rows[hti.RowIndex].Selected = true;

                IdSeleccionado = (int)tbMPrima.Rows[hti.RowIndex].Cells["IdMPrima"].Value;

            }
        }

        private void MObtnEditar_Click(object sender, EventArgs e)
        {
            lblNuevoInsumo.Text = "Editar insumo";
            editar = true;
            tbpMain.SelectedIndex = 2;
            pasarMPrimatxt();
        }

        private void btnIngresarInsumo_Click(object sender, EventArgs e)
        {
            GuardarMPrima();
        }

        private void MObtnEliminar_Click(object sender, EventArgs e)
        {
            eliminarMPrima();
        }

        private void tbMPrima_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tbMPrima.Columns["btnEditar"].Index && e.RowIndex >= 0)
            {


                // Se hizo clic en la imagen de editar
                int filaSeleccionada = e.RowIndex;

                // Obtener el dato a editar en base a la fila seleccionada
                IdSeleccionado = (int)tbMPrima.Rows[filaSeleccionada].Cells["IdMPrima"].Value;
                lblNuevoInsumo.Text = "Editar insumo";
                editar = true;
                tbpMain.SelectedIndex = 2;
                pasarMPrimatxt();


            }
            else if (e.ColumnIndex == tbMPrima.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {
                // Se hizo clic en la imagen de eliminar
                int filaSeleccionada = e.RowIndex;

                // Obtener el dato a eliminar en base a la fila seleccionada
                IdSeleccionado = (int)tbMPrima.Rows[filaSeleccionada].Cells["IdMPrima"].Value;

                // Llamar al método para eliminar el dato
                eliminarMPrima();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 0;
        }

        private void btnAtrasNew_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 0;
        }

        private void metroTabPage3_Enter(object sender, EventArgs e)
        {
            listarProvCbx(cbxProveedorInsumo);
            listarMedCbx(cbxMedidaInsumo);
        }

        private void metroTabPage1_Enter(object sender, EventArgs e)
        {
            LimpiarMPrima();
        }

        private void btnAtrasMain_Click(object sender, EventArgs e)
        {

            TraerFormFront(new RegistrosGUI().GetType());
        }

        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 3;
        }

        private void metroTabPage4_Enter(object sender, EventArgs e)
        {
            listarInsumoCbx(cbxInsumo);
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            ComprarInsumo();
        }

        private void metroTabPage5_Enter(object sender, EventArgs e)
        {
            listarInsumos();
        }

        private void btnAtrasNCompra_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 0;
        }

        private void btnAtrasTb_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 0;
        }

        private void gunaAdvenceTileButton3_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 4;
        }
    }
}
