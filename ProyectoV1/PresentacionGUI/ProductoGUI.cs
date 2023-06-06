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
    public partial class ProductoGUI : Form
    {
        ProductoRepository prodRep = new ProductoRepository(ConfigConnection.connectionString);
        CategoriaRepository cagRep = new CategoriaRepository(ConfigConnection.connectionString);
        MedidaRepository medRep = new MedidaRepository(ConfigConnection.connectionString);
        int IdSeleccionado;
        bool editar;
        public ProductoGUI()
        {
            InitializeComponent();
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
        void listarCagCbx(GunaComboBox cbx)
        {
            cbx.Items.Clear();
            var lista = cagRep.ObtenerTodos();
            foreach (var cag in lista)
            {
                cbx.Items.Add(cag.Nombre);
            }
        }
        void listarMedCbx(GunaComboBox cbx)
        {
            cbx.Items.Clear();
            var lista = medRep.ObtenerTodos();
            foreach (var med in lista)
            {
                cbx.Items.Add(med.NombreCorto);
            }
        }
        void listarProd()
        {
            tbProd.Rows.Clear();
            var lista = prodRep.GetAll();
            foreach (var prod in lista)
            {
                tbProd.Rows.Add(prod.Id, prod.Nombre, prod.MedidaProducto.Id, prod.MedidaProducto.NombreCorto, prod.CategoriaProducto.Id, prod.CategoriaProducto.Nombre, prod.Presentacion, prod.CostoProduccion, prod.PrecioVenta, prod.Ganancia);
            }
        }
        bool validarNumero(string cadena)
        {
            return double.TryParse(cadena, out double numero);
        }
        void editarProd()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas editar este producto?", "Confirmar edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var prod = new Producto();
                prod.Nombre = txtNombreProd.Text;
                prod.CategoriaProducto = cagRep.ObtenerPorIndex(cbxCategoriaProd.SelectedIndex);
                prod.MedidaProducto = medRep.ObtenerPorIndex(cbxMedidaProd.SelectedIndex);
                prod.Presentacion = txtPresentacionProd.Text;
                prod.CostoProduccion = double.Parse(txtCProduccionProd.Text);
                prod.PrecioVenta = double.Parse(txtPVentaProd.Text);
                var filas = prodRep.Actualizar(prod, IdSeleccionado);
                if (filas == 0)
                {
                    Menu.Show(this, "Hubo un error al guardar el producto", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
                else
                {
                    tbpMain.SelectedIndex = 0;
                    Menu.Show(this, "Producto editado correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    LimpiarProd();
                }
            }
        }
        void GuardarProd()
        {
            if (txtNombreProd.Text == "" || txtPresentacionProd.Text == "" || txtCProduccionProd.Text == "" || txtPVentaProd.Text == "")
            {
                Menu.Show(this, "Verifique que los campos no esten vacios", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else if (cbxCategoriaProd.SelectedIndex == -1)
            {
                Menu.Show(this, "No se ha seleccionado ninguna categoria", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else if (cbxMedidaProd.SelectedIndex == -1)
            {
                Menu.Show(this, "No se ha seleccionado ninguna medida", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else if (!validarNumero(txtCProduccionProd.Text))
            {
                Menu.Show(this, "Verifique que el costo de produccion sea numerico", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else if (!validarNumero(txtPVentaProd.Text))
            {
                Menu.Show(this, "Verifique que el precio de venta sea numerico", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else
            {
                if (!editar)
                {
                    //obtener a partir de index
                    var prod = new Producto();
                    prod.Nombre = txtNombreProd.Text;
                    prod.CategoriaProducto = cagRep.ObtenerPorIndex(cbxCategoriaProd.SelectedIndex);
                    prod.MedidaProducto = medRep.ObtenerPorIndex(cbxMedidaProd.SelectedIndex);
                    prod.CostoProduccion = double.Parse(txtCProduccionProd.Text);
                    prod.PrecioVenta = double.Parse(txtPVentaProd.Text);
                    prod.Presentacion = txtPresentacionProd.Text;
                    prodRep.Insert(prod);
                    tbpMain.SelectedIndex = 0;
                    Menu.Show(this, "Producto agregado correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    LimpiarProd();
                }
                else
                {
                    editarProd();
                }
            }
        }
        void LimpiarProd()
        {
            txtNombreProd.Text = "";
            txtCProduccionProd.Text = "";
            txtPresentacionProd.Text = "";
            txtPVentaProd.Text = "";
            cbxMedidaProd.SelectedIndex = -1;
            cbxCategoriaProd.SelectedIndex = -1;
        }
        void eliminarProd()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                prodRep.Eliminar(IdSeleccionado);
                listarProd();
            }
        }
        void pasarProdtxt()
        {
            var prod = prodRep.ObtenerPorId(IdSeleccionado);
            txtNombreProd.Text = prod.Nombre;

            var idCag = int.Parse(tbProd.CurrentRow.Cells["IdCat"].Value.ToString());
            var idMed = int.Parse(tbProd.CurrentRow.Cells["IdMed"].Value.ToString());

            cbxCategoriaProd.SelectedIndex = cagRep.ObtenerIndexPorId(idCag);
            cbxMedidaProd.SelectedIndex = medRep.ObtenerIndexPorId(idMed);

            txtPresentacionProd.Text = prod.Presentacion;
            txtCProduccionProd.Text = prod.CostoProduccion.ToString();
            txtPVentaProd.Text = prod.PrecioVenta.ToString();

        }

        private void metroTabPage1_Enter(object sender, EventArgs e)
        {
            listarProd();
            LimpiarProd();
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            editar = false;
            lblNuevoProd.Text = "Nuevo Producto";
            tbpMain.SelectedIndex = 1;
        }

        private void tbProd_MouseDown(object sender, MouseEventArgs e)
        {
            var hti = tbProd.HitTest(e.X, e.Y);
            tbProd.ClearSelection();

            if (hti.RowIndex >= 0)
            {
                tbProd.Rows[hti.RowIndex].Selected = true;

                IdSeleccionado = (int)tbProd.Rows[hti.RowIndex].Cells["IdProd"].Value;

            }
        }

        private void MObtnEditar_Click(object sender, EventArgs e)
        {
            lblNuevoProd.Text = "Editar producto";
            editar = true;
            tbpMain.SelectedIndex = 1;
            pasarProdtxt();
        }

        private void btnIngresarProd_Click(object sender, EventArgs e)
        {
            GuardarProd();
        }

        private void MObtnEliminar_Click(object sender, EventArgs e)
        {
            eliminarProd();
        }

        private void tbProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tbProd.Columns["btnEditar"].Index && e.RowIndex >= 0)
            {


                // Se hizo clic en la imagen de editar
                int filaSeleccionada = e.RowIndex;

                // Obtener el dato a editar en base a la fila seleccionada
                IdSeleccionado = (int)tbProd.Rows[filaSeleccionada].Cells["IdProd"].Value;
                lblNuevoProd.Text = "Editar producto";
                editar = true;
                tbpMain.SelectedIndex = 1;
                pasarProdtxt();


            }
            else if (e.ColumnIndex == tbProd.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {
                // Se hizo clic en la imagen de eliminar
                int filaSeleccionada = e.RowIndex;

                // Obtener el dato a eliminar en base a la fila seleccionada
                IdSeleccionado = (int)tbProd.Rows[filaSeleccionada].Cells["IdProd"].Value;

                // Llamar al método para eliminar el dato
                eliminarProd();
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

        private void metroTabPage2_Enter(object sender, EventArgs e)
        {
            listarCagCbx(cbxCategoriaProd);
            listarMedCbx(cbxMedidaProd);
        }
    }
}
