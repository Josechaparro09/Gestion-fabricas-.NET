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
using TheArtOfDev.HtmlRenderer.Adapters;

namespace PresentacionGUI
{
    public partial class VentasGUI : Form
    {
        ProductoRepository prodRep = new ProductoRepository(ConfigConnection.connectionString);
        DetalleVentaRepository dvRep = new DetalleVentaRepository(ConfigConnection.connectionString);
        VentaReporitory vRep = new VentaReporitory(ConfigConnection.connectionString);
        StockProductosRepository sProd = new StockProductosRepository (ConfigConnection.connectionString);
        List<DetalleVenta> dvs = new List<DetalleVenta>();
        int IdSeleccionado;
        public VentasGUI()
        {
            InitializeComponent();
            tbpMain.SelectedIndex = 0;
        }
        
        void listarProductoscbx()
        {
            cbxProd.Items.Clear();
            var lista = prodRep.GetAll();
            foreach (var prod in lista)
            {
                cbxProd.Items.Add(prod.Nombre);
            }
        }
        void addDvTb(DetalleVenta dv)
        {

            tbDv.Rows.Add(dv.Producto.Id,dv.Producto.Nombre,dv.PrecioUnitario,dv.Cantidad,dv.Subtotal);

        }
        void listarVentas()
        {
            tbVentas.Rows.Clear();
            var lista = vRep.GetAll();
            foreach (var item in lista)
            {
                tbVentas.Rows.Add(item.Id,item.FechaVenta,item.Total);
            }
        }
        void limpiarCampos()
        {
            
            txtCantProducto.Text = "";
            cbxProd.SelectedIndex = -1;


        }
        bool verificarNumerico(string num)
        {
            return  int.TryParse(num , out int result);
        }
        void agregarProdLista()
        {
            if (cbxProd.SelectedIndex == -1)
            {
                Menu.Show(this, "No se ha seleccionado ningun producto", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);

            }
            else if (txtCantProducto.Text == "")
            {
                Menu.Show(this, "Rectifique que la cantidad no sea vacia", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else if (!verificarNumerico(txtCantProducto.Text))
            {
                Menu.Show(this, "Rectifique que la cantidad sea numerica", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);

            }
            else
            {
                if (!sProd.verificarCantidad(prodRep.ObtenerPorIndex(cbxProd.SelectedIndex).Id, int.Parse(txtCantProducto.Text)))
                {
                    Menu.Show(this, "No hay productos en el stock para agregar a la venta ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                }
                else
                {
                    var prod = prodRep.ObtenerPorIndex(cbxProd.SelectedIndex);
                    var dv = new DetalleVenta()
                    {
                        Producto = prod,
                        Cantidad = int.Parse(txtCantProducto.Text),
                        PrecioUnitario = prod.PrecioVenta,
                        Subtotal = prod.PrecioVenta * int.Parse(txtCantProducto.Text)
                    };
                    dvs.Add(dv);
                    addDvTb(dv);
                    lblTotal.Text = CalcularTotal().ToString();
                    Menu.Show(this, "Producto agregado ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    limpiarCampos();
                }
                

            }
        }
        double CalcularTotal()
        {
            double total=0;
            foreach (var item in dvs)
            {
                total += item.Subtotal;
            }
            return total;
        }
        void GuardarVenta()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas hacer la venta?", "Confirmar venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                var venta = new Venta()
                {
                    FechaVenta = DateTime.Now,
                    Total = CalcularTotal()
                };
                var id = vRep.Insert(venta);
                foreach (var item in dvs)
                {
                    sProd.RestarCantidad(item.Producto.Id,item.Cantidad);
                    item.Venta = vRep.ObtenerPorId(id);
                    dvRep.Insert(item);
                }
                limpiarCampos();
                Menu.Show(this, "Venta realizada", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                dvs.Clear();
                tbDv.Rows.Clear();
                lblTotal.Text = "";
            }
        }

        private void btnNVenta_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            tbpMain.SelectedIndex = 1;
        }

        private void btnVerVentas_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 2;
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            agregarProdLista();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            GuardarVenta();
        }

        private void metroTabPage2_Enter(object sender, EventArgs e)
        {
            listarProductoscbx();
        }

        private void btnAtras1_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 0;

        }

        private void metroTabPage3_Enter(object sender, EventArgs e)
        {
            listarVentas();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 0;
        }
        void listarVentatb()
        {
            tbVerVenta.Rows.Clear();
            var lista = dvRep.GetAllByIdVenta(IdSeleccionado);
            foreach (var item in lista)
            {
                tbVerVenta.Rows.Add(item.Producto.Id, item.Producto.Nombre, item.PrecioUnitario, item.Cantidad, item.Subtotal);
            }

        }

        private void tbVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tbVentas.Columns["btnVer"].Index && e.RowIndex >= 0)
            {


                // Se hizo clic en la imagen de editar
                int filaSeleccionada = e.RowIndex;

                // Obtener el dato a editar en base a la fila seleccionada
                IdSeleccionado = (int)tbVentas.Rows[filaSeleccionada].Cells["Id"].Value;
                tbpMain.SelectedIndex = 3;
                listarVentatb();
                lblTotalVer.Text = vRep.ObtenerPorId(IdSeleccionado).Total.ToString();




            }
        }

        private void tbDv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tbDv.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {


                // Se hizo clic en la imagen de editar
                int filaSeleccionada = e.RowIndex;

                // Obtener el dato a editar en base a la fila seleccionada
                dvs.RemoveAt(filaSeleccionada);
                tbDv.Rows.RemoveAt(filaSeleccionada);
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 2;
        }
    }
}
