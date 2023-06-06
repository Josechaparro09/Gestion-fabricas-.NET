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
    public partial class ProduccionGUI : Form
    {
        RProduccionRepository rpRep = new RProduccionRepository(ConfigConnection.connectionString);
        StockProductosRepository spRep = new StockProductosRepository(ConfigConnection.connectionString);
        StockMPrimaRepository smpRep = new StockMPrimaRepository(ConfigConnection.connectionString);
        PProducidoRepository ppRep = new PProducidoRepository(ConfigConnection.connectionString);
        MPUtilizadaRepository mpuRep = new MPUtilizadaRepository(ConfigConnection.connectionString);
        ProduccionRepository pRep = new ProduccionRepository(ConfigConnection.connectionString);
        public ProduccionGUI()
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
        void listarRecetacbx(GunaComboBox cbx)
        {
            cbx.Items.Clear();
            var lista = rpRep.GetAll();
            foreach (var rp in lista)
            {
                cbx.Items.Add(rp.Nombre);
            }
        }
        void LimpiarCampos()
        {
            cbxReceta.SelectedIndex = -1;
            txtCantProducciones.Text = "";
        }
        bool puedeProducir(List<MateriaPrimaUtilizada> mpu)
        {
            foreach (var item in mpu)
            {
                if (!smpRep.PuedeProducir(item))
                {
                    return false;
                }
            }
            return true;
        }
        void listarProducciones()
        {
            tbProducciones.Rows.Clear();
            var lista = pRep.GetAll();
            foreach (var produccion in lista)
            {
                tbProducciones.Rows.Add(produccion.Id,produccion.RProduccion,produccion.RProduccion.Nombre,produccion.cantidadProducida,produccion.FechaProduccion);
            }
        }
        void GuardarProduccion()
        {
            var producc = new Produccion();
            var rp = rpRep.ObtenerPorIndex(cbxReceta.SelectedIndex);
            var pps = ppRep.GetPPPorIdReceta(rp.Id);
            var mpus = mpuRep.GetMPPorIdReceta(rp.Id);
            var producir = puedeProducir(mpus);
            if (txtCantProducciones.Text =="")
            {
                Menu.Show(this, "No se ha ingresado la cantidad", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);

            }
            else if (!validarNumero(txtCantProducciones.Text))
            {
                Menu.Show(this, "Verifique que la cantidad sea numerica entera", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
            else if (cbxReceta.SelectedIndex == -1)
            {
                Menu.Show(this, "No se ha seleccionado ninguna receta", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
            else if (!producir)
            {
                Menu.Show(this, "No hay materia prima suficiente para producir,", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);

            }
            else
            {
                var resultado = MessageBox.Show("¿Estás seguro de deseas realizar esta produccion?", "Confirmar produccion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    producc.cantidadProducida = int.Parse(txtCantProducciones.Text);
                    producc.FechaProduccion = DateTime.Now;
                    producc.RProduccion = rpRep.ObtenerPorIndex(cbxReceta.SelectedIndex);
                    producc.Id = pRep.Insert(producc);

                    foreach (var item in pps)
                    {
                        var sp = new StockProductos();
                        if (!spRep.ExisteIdProd(item.Producto.Id))
                        {
                            sp.producto = item.Producto;
                            sp.Cantidad = item.CantidadProducto * int.Parse(txtCantProducciones.Text);
                            sp.FActualizacion = DateTime.Now;
                            sp.receta = producc.RProduccion;
                            spRep.Insert(sp);
                        }
                        else
                        {
                            sp.producto = item.Producto;
                            sp.Cantidad = item.CantidadProducto * int.Parse(txtCantProducciones.Text);
                            sp.FActualizacion = DateTime.Now;
                            sp.receta = producc.RProduccion;
                            spRep.Actualizar(sp);
                        }
                    }
                    foreach (var item in mpus)
                    {
                        var smp = new StockMPrima();
                        if (!smpRep.ExisteIdMprima(item.MPrimaUtilizada.Id))
                        {

                            smp.Mprima = item.MPrimaUtilizada;
                            smp.Cantidad = item.CantUtilizada * int.Parse(txtCantProducciones.Text);
                            smp.FechaActualizacion = DateTime.Now;
                            smpRep.Insert(smp);
                        }
                        else
                        {
                            smp.Mprima = item.MPrimaUtilizada;
                            smp.Cantidad = item.CantUtilizada * int.Parse(txtCantProducciones.Text);
                            smp.FechaActualizacion = DateTime.Now;
                            smpRep.Actualizar(smp);
                        }
                    }

                    Menu.Show(this, "Produccion realizada correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);

                }
            }
        }
        bool validarNumero(string cadena)
        {
            return int.TryParse(cadena, out int numero);
        }

        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {
            TraerFormFront(new RecetaProduccionGUI().GetType());
        }

        private void gunaAdvenceTileButton3_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 1;
        }

        private void btnProducir_Click(object sender, EventArgs e)
        {
            GuardarProduccion();
            tbpMain.SelectedIndex = 1;
        }

        private void gunaAdvenceTileButton4_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 2;
        }

        private void metroTabPage3_Enter(object sender, EventArgs e)
        {
            listarRecetacbx(cbxReceta);
        }

        private void metroTabPage4_Enter(object sender, EventArgs e)
        {
            listarProducciones();
        }

        private void btnAtras3_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 1;
        }

        private void btnAtras2_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 0;
        }

        private void btnAtras1_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 0;
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 3;
        }
    }
}
