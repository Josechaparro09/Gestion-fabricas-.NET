using Bunifu.UI.WinForms;
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
    public partial class RecetaProduccionGUI : Form
    {
        RProduccionRepository rpRep = new RProduccionRepository(ConfigConnection.connectionString);
        ProductoRepository prodRep = new ProductoRepository(ConfigConnection.connectionString);
        MPrimaRepository mpRep = new MPrimaRepository(ConfigConnection.connectionString);
        PProducidoRepository ppRep = new PProducidoRepository(ConfigConnection.connectionString);
        MPUtilizadaRepository mpuRep = new MPUtilizadaRepository(ConfigConnection.connectionString);
        List<ProductoProducido> pps = new List<ProductoProducido>();
        List<ProductoProducido> ppsEli = new List<ProductoProducido>();
        List<MateriaPrimaUtilizada> mpus = new List<MateriaPrimaUtilizada>();
        List<MateriaPrimaUtilizada> mpusEli = new List<MateriaPrimaUtilizada>();
        int IdSeleccionado;
        bool? editar;
        public RecetaProduccionGUI()
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
        void listarProdCbx(GunaComboBox cbx)
        {
            cbx.Items.Clear();
            var lista = prodRep.GetAll();
            foreach (var prod in lista)
            {
                cbx.Items.Add(prod.Nombre);
            }
        }
        void listarInsumoCbx(GunaComboBox cbx)
        {
            cbx.Items.Clear();
            var lista = mpRep.GetAll();
            foreach (var mp in lista)
            {
                cbx.Items.Add(mp.Nombre);
            }
        }
        bool validarNumero(string cadena)
        {
            return double.TryParse(cadena, out double numero);
        }
        void limpiarCbx(GunaComboBox cbx)
        {
            cbx.SelectedIndex = -1;

        }
        void limpiarCampos()
        {
            txtNombre.Text = "";
            limpiarCbx(cbxInsumo);
            limpiarCbx(cbxProd);

        }
        void ListarInsumos(List<MateriaPrimaUtilizada> mpus)
        {
            tbMPrima.Rows.Clear();
            var lista = mpus;
            foreach (var mp in lista)
            {
                tbMPrima.Rows.Add(mp.MPrimaUtilizada.Id, mp.MPrimaUtilizada.Nombre, mp.MPrimaUtilizada.Medida.Id, mp.MPrimaUtilizada.Medida.NombreCorto, mp.MPrimaUtilizada.Proveedor.Id, mp.MPrimaUtilizada.Proveedor.Nombre, mp.CantUtilizada);
            }
        }
        void ListarProductos(List<ProductoProducido> pps)
        {
            tbProd.Rows.Clear();
            var lista = pps;
            //name cag pre cant
            foreach (var mp in lista)
            {
                tbProd.Rows.Add(mp.Producto.Id, mp.Producto.Nombre, mp.Producto.CategoriaProducto.Id, mp.Producto.CategoriaProducto.Nombre, mp.Producto.Presentacion, mp.CantidadProducto);
            }
        }
        void ListarRecetas()
        {
            tbRecetas.Rows.Clear();
            var lista = rpRep.GetAll();

            foreach (var rp in lista)
            {
                tbRecetas.Rows.Add(rp.Id, rp.Nombre);
            }
        }
        void ListarNombreReceta(string nombre)
        {
            txtNombre.Text = nombre;
        }
        void agregarInsumo()
        {

            if (!validarNumero(txtCantInsumo.Text))
            {
                Menu.Show(this, "Verifique que la cantidad del insumo sea numerica", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
            else
            {

                var mp = mpRep.ObtenerPorIndex(cbxInsumo.SelectedIndex);
                var mpu = new MateriaPrimaUtilizada();
                mpu.MPrimaUtilizada = mp;
                mpu.CantUtilizada = double.Parse(txtCantInsumo.Text);
                mpus.Add(mpu);
                limpiarCbx(cbxInsumo);
                txtCantInsumo.Text = "";
                lblMedInsumo.Visible = false;
                Menu.Show(this, "Insumo agregado correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);

            }

        }
        void agregarProducto()
        {

            if (!validarNumero(txtCantProducto.Text))
            {
                Menu.Show(this, "Verifique que la cantidad del producto sea numerica", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
            else
            {

                var prod = prodRep.ObtenerPorIndex(cbxProd.SelectedIndex);
                var pp = new ProductoProducido();
                pp.Producto = prod;
                pp.CantidadProducto = int.Parse(txtCantProducto.Text);
                pps.Add(pp);
                limpiarCbx(cbxProd);
                txtCantProducto.Text = "";
                Menu.Show(this, "Insumo agregado correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);

            }

        }
        void GuardarReceta()
        {
            //insert de receta y asigna receta a insumo y productos 

            if (editar == false)
            {
                var r = new RecetaDeProduccion();
                r.Nombre = txtNombre.Text;
                r.Id = rpRep.Insert(r);
                foreach (var i in mpus)
                {
                    i.IdReceta = r.Id;
                    mpuRep.Insert(i);
                }
                foreach (var pp in pps)
                {
                    pp.IdReceta = r.Id;
                    ppRep.Insert(pp);
                }
                
                tbpMain.SelectedIndex = 0;
                Menu.Show(this, "Receta agregada correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                BorrarListas();
            }
            else
            {
                EditarReceta();
            }
        }
        void EditarReceta()
        {
            var resultado = MessageBox.Show("¿Estás seguro de deseas editar esta receta?", "Confirmar edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                var r = new RecetaDeProduccion();
                r.Id = IdSeleccionado;
                r.Nombre = txtNombre.Text;

                rpRep.Actualizar(r, r.Id);

                foreach (var i in mpus)
                {
                    i.IdReceta = r.Id;
                    if (mpuRep.ExisteId(i.Id))
                    {
                        mpuRep.Actualizar(i, i.Id);
                    }
                    else
                    {
                        mpuRep.Insert(i);
                    }
                    
                }
                foreach (var pp in pps)
                {
                    pp.IdReceta = r.Id;
                    if (ppRep.ExisteId(pp.Id))
                    {
                        ppRep.Actualizar(pp, pp.Id);
                    }
                    else
                    {
                        ppRep.Insert(pp);
                    }
                    
                    
                }
                foreach (var item in ppsEli)
                {
                    ppRep.Eliminar(item.Id);
                }
                foreach (var item in mpusEli)
                {
                    mpuRep.Eliminar(item.Id);
                }
                tbpMain.SelectedIndex = 3;
                Menu.Show(this, "Receta editada correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                BorrarListas();
            }

        }
        void BorrarListas()
        {
            pps.Clear();
            mpus.Clear();
            mpusEli.Clear();
            ppsEli.Clear();
        }
        void PasarInfoReceta(int id)
        {
            pps = ppRep.GetPPPorIdReceta(id);
            mpus = mpuRep.GetMPPorIdReceta(id);
            txtNombre.Text = rpRep.ObtenerPorId(id).Nombre;
            lblNombre.Text = "Receta: " + txtNombre.Text;
            ListarProductos(pps);
            ListarInsumos(mpus);


        }
        void eliminarProd(int index)
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                pps.RemoveAt(index);
                ListarProductos(pps);
            }
        }
        void eliminarReceta(int id)
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar esta receta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                rpRep.Eliminar(id);
                ListarRecetas();
            }
        }
        void eliminarInsumo(int index)
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este insumo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                mpus.RemoveAt(index);
                ListarInsumos(mpus);
            }
        }
        private void lblMedInsumo_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceTileButton5_Click(object sender, EventArgs e)
        {
            editar = false;
            tbpMain.SelectedIndex = 1;
            limpiarCampos();
            BorrarListas();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                Menu.Show(this, "Verifique que el nombre no este vacio", BunifuSnackbar.MessageTypes.Error);
            }
            else
            {
                lblNombre.Text = "Receta: " + txtNombre.Text;
                tbpMain.SelectedIndex = 2;
                tbProd.Columns["btnEliminarProd"].Visible = true;
                tbMPrima.Columns["btnEliminarInsumo"].Visible = true;
                btnGuardar.Visible = true;
                btnAgregar.Visible = true;

            }

        }

        private void btnAddInsumo_Click(object sender, EventArgs e)
        {
            agregarInsumo();
        }

        
        private void metroTabPage2_Enter(object sender, EventArgs e)
        {
            listarInsumoCbx(cbxInsumo);
            listarProdCbx(cbxProd);
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            agregarProducto();
        }

        private void cbxInsumo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxInsumo.SelectedIndex != -1)
            {
                lblMedInsumo.Visible = true;
                var mp = mpRep.ObtenerPorIndex(cbxInsumo.SelectedIndex);
                lblMedInsumo.Text = mp.Medida.NombreCorto;
            }
        }

        private void btnSig_Click(object sender, EventArgs e)
        {

            GuardarReceta();

        }

        private void metroTabPage3_Enter(object sender, EventArgs e)
        {
            ListarInsumos(mpus);
            ListarProductos(pps);
        }

        private void metroTabPage4_Enter(object sender, EventArgs e)
        {
            ListarRecetas();
        }

        private void gunaAdvenceTileButton4_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 3;
        }

        private void tbRecetas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tbRecetas.Columns["btnEditarReceta"].Index && e.RowIndex >= 0)
            {
                editar = true;

                // Se hizo clic en la imagen de editar
                int filaSeleccionada = e.RowIndex;

                // Obtener el dato a editar en base a la fila seleccionada
                IdSeleccionado = (int)tbRecetas.Rows[filaSeleccionada].Cells["IdReceta"].Value;
                tbProd.Columns["btnEliminarProd"].Visible = true;
                tbMPrima.Columns["btnEliminarInsumo"].Visible = true;
                PasarInfoReceta(IdSeleccionado);

                btnAgregar.Visible = true;
                btnGuardar.Visible = true;

                tbpMain.SelectedIndex = 2;



            }
            else if (e.ColumnIndex == tbRecetas.Columns["btnEliminarReceta"].Index && e.RowIndex >= 0)
            {
                // Se hizo clic en la imagen de eliminar
                int filaSeleccionada = e.RowIndex;

                // Obtener el dato a eliminar en base a la fila seleccionada
                IdSeleccionado = (int)tbRecetas.Rows[filaSeleccionada].Cells["IdReceta"].Value;

                // Llamar al método para eliminar el dato
                eliminarReceta(IdSeleccionado);
            } else if (e.ColumnIndex == tbRecetas.Columns["btnVerReceta"].Index && e.RowIndex >= 0){
                editar = null;
                int filaSeleccionada = e.RowIndex;
                IdSeleccionado = (int)tbRecetas.Rows[filaSeleccionada].Cells["IdReceta"].Value;
                tbProd.Columns["btnEliminarProd"].Visible = false;
                tbMPrima.Columns["btnEliminarInsumo"].Visible = false;
                PasarInfoReceta(IdSeleccionado);
                tbpMain.SelectedIndex = 2;
                btnGuardar.Visible = false;
                btnAgregar.Visible = false;



            }
        }
        
        private void tbProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tbProd.Columns["btnEliminarProd"].Index && e.RowIndex >= 0)
            {
                // Se hizo clic en la imagen de eliminar
                int filaSeleccionada = e.RowIndex;
                // Obtener el dato a eliminar en base a la fila seleccionada

                // Llamar al método para eliminar el dato
                ppsEli.Add(pps[filaSeleccionada]);
                eliminarProd(filaSeleccionada);
                
            }
        }

        private void btnAtrasNR_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 0;
            
        }

        private void btnAtrasR_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 1;
            if (editar == true)
            {
                var nombre = rpRep.ObtenerPorId(IdSeleccionado);
                ListarNombreReceta(nombre.Nombre);
            }
        }

        private void tbMPrima_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tbMPrima.Columns["btnEliminarInsumo"].Index && e.RowIndex >= 0)
            {
                // Se hizo clic en la imagen de eliminar
                int filaSeleccionada = e.RowIndex;
                // Obtener el dato a eliminar en base a la fila seleccionada

                // Llamar al método para eliminar el dato
                mpusEli.Add(mpus[filaSeleccionada]);
                eliminarInsumo(filaSeleccionada);

            }
        }

        private void btnAtrasVP_Click(object sender, EventArgs e)
        {
            if (editar == null || editar == true)
            {
                tbpMain.SelectedIndex = 3;
            }
            else
            {
                tbpMain.SelectedIndex = 1;
            }
        }

        private void btnAtrasProducciones_Click(object sender, EventArgs e)
        {
            //var f = new ProduccionGUI();
            //f.MdiParent = this.MdiParent;
            //this.Hide();
            //this.Close();
            //f.Show();
            TraerFormFront(new ProduccionGUI().GetType());
        }
    }
}
