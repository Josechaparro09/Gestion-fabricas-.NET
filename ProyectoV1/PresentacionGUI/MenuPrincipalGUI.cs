using Entidades;
using Guna.UI.WinForms;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class MenuPrincipalGUI : Form
    {
        TablaMedidas tabla = new TablaMedidas();
        #region 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Rectangle sizeGripRectangle;
        bool inSizeDrag = false;
        const int GRIP_SIZE = 15;

        int w = 0;
        int h = 0;
        #endregion
        int IdSeleccionado;
        bool editar;
        MedidaRepository medidaRep = new MedidaRepository(ConfigConnection.connectionString);
        CategoriaRepository categoriaRep = new CategoriaRepository(ConfigConnection.connectionString);
        ProveedorRepository provRep = new ProveedorRepository(ConfigConnection.connectionString);
        EmpleadoRepository empRep = new EmpleadoRepository(ConfigConnection.connectionString);
        PlantaRepository plantaRep = new PlantaRepository(ConfigConnection.connectionString);
        ProductoRepository prodRep = new ProductoRepository(ConfigConnection.connectionString);
        MPrimaRepository mprimaRep = new MPrimaRepository(ConfigConnection.connectionString);
        
        public MenuPrincipalGUI(string usuario)
        {
            InitializeComponent();
            this.lblNombre.Text = usuario;
            this.tbpMain.ShowToolTips = true;

        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuPrincipalGUI_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usuarios.Users' Puede moverla o quitarla según sea necesario.


        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {



        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMedidas_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 4;
            listarMedidas();
        }

        //void mostrarTablaMedidas()
        //{

        //    if (!tbMedida.Controls.Contains(tabla))
        //    {
        //        tbMedida.Controls.Add(tabla);
        //    }
        //}

        private void tbMedida_Click(object sender, EventArgs e)
        {

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 5;
            //var tabla = new Tabla_Categorias();

            //if (!tbCategorias.Controls.Contains(tabla))
            //{
            //    tbCategorias.Controls.Add(tabla);
            //}
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 6;
            //var tabla = new TablaProveedores();

            //if (!tbProveedores.Controls.Contains(tabla))
            //{
            //    tbProveedores.Controls.Add(tabla);
            //}
        }

        private void btnPlantas_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 7;
            //var tabla = new TablaPlantas();

            //if (!tbPlantas.Controls.Contains(tabla))
            //{
            //    tbPlantas.Controls.Add(tabla);
            //}
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 8;
            //var tabla = new TablaProductos();

            //if (!tbProductos.Controls.Contains(tabla))
            //{
            //    tbProductos.Controls.Add(tabla);
            //}
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            tbpMain.SelectTab(11);
            editar = false;
            LimpiarProveedores();
        }
        void CerrarFormularios()
        {
            foreach (Form formulario in this.MdiChildren)
            {
                formulario.Close();
            }
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {

            CerrarFormularios();
            //tbpMain.SelectedIndex = 0;
            var f = new RegistrosGUI();
            if (f.MdiParent!=this)
            {
                f.MdiParent = this;
                f.Show();
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 1;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            //tbpMain.SelectedIndex = 2;
            CerrarFormularios();
            var f = new InsumosGUI();
            if (f.MdiParent != this)
            {
                f.MdiParent = this;
                f.Show();
            }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 3;
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            GuardarMedida();
        }
        //_validaciones

        bool validarVaciosMedida()
        {
            if (txtNLargo.Text == "" || txtNombreCorto.Text == "")
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        bool validarNumero(string cadena)
        {
            return double.TryParse(cadena , out double numero);
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            tbpMain.SelectTab(9);
            editar = false;
            LimpiarMedida();
        }

        private void tbMedida_Enter(object sender, EventArgs e)
        {
            listarMedidas();
        }

        private void tbCategorias_Enter(object sender, EventArgs e)
        {
            listarCategorias();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            //10
            editar = false;
            tbpMain.SelectTab(10);
            LimpiarCategoria();

        }

        private void btnIngresarCategoria_Click(object sender, EventArgs e)
        {
            GuardarCategoria();
        }

        #region _Guardar
        void GuardarMedida()
        {
            if (validarVaciosMedida())
            {
                Menu.Show(this, "Rectifique los campos", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else
            {
                if (!editar)
                {
                    var medida = new Medida();
                    medida.NombreLargo = txtNLargo.Text;
                    medida.NombreCorto = txtNombreCorto.Text;
                    medidaRep.Insertar(medida);
                    tbpMain.SelectTab(4);
                    Menu.Show(this, "Medida registrada con exito", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    txtNLargo.Text = "";
                    txtNombreCorto.Text = "";
                }
                else
                {
                    editarMedida();
                }
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
                    tbpMain.SelectedIndex = 5;
                    Menu.Show(this, "Categoria agregada correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                }
                else
                {
                    editarCategoria();
                }
            }
        }
        void GuardarProveedor()
        {
            if (!validarNumero(txtTelefonoProv.Text))
            {
                Menu.Show(this, "Verifique que el telefono sea solo numeros", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);

            }else if (txtNombreProv.Text == "" || txtTelefonoProv.Text == "" || txtDireccionProv.Text == "")
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
                    tbpMain.SelectedIndex = 6;
                    Menu.Show(this, "Proveedor registrado con exito", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                }
                else
                {
                    editarProveedor();
                }
            }
        }
        void GuardarEmp()
        {
            if (!validarNumero(txtTelefonoEmp.Text))
            {
                Menu.Show(this, "Verifique que el telefono sea solo numeros", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }else if (!validarNumero(txtCedulaEMp.Text))
            {
                Menu.Show(this, "Verifique que la cedula sea solo numeros", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }else if (txtCedulaEMp.Text == "" || txtNombreEmp.Text == "" || txtApellidoEmp.Text == "" || txtTelefonoEmp.Text == "")
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
                    tbpMain.SelectedIndex = 12;
                    Menu.Show(this, "Empleado registrado con exito", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                }
                else
                {
                    editarEmpleado();
                }
            }
        }
        void GuardarPlanta()
        {
            if (txtNombrePlanta.Text == "")
            {
                Menu.Show(this, "El campo nombre esta vacio", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }else if (cbxEmpPlanta.SelectedIndex == -1)
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
                    tbpMain.SelectedIndex = 7;
                    Menu.Show(this, "Planta agregada correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                }
                else
                {
                    editarPlanta();
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
                    prod.CategoriaProducto = categoriaRep.ObtenerPorIndex(cbxCategoriaProd.SelectedIndex);
                    prod.MedidaProducto = medidaRep.ObtenerPorIndex(cbxMedidaProd.SelectedIndex);
                    prod.CostoProduccion = double.Parse(txtCProduccionProd.Text);
                    prod.PrecioVenta = double.Parse(txtPVentaProd.Text);
                    prod.Presentacion = txtPresentacionProd.Text;
                    prodRep.Insert(prod);
                    tbpMain.SelectedIndex = 8;
                    Menu.Show(this, "Producto agregado correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                }
                else
                {
                    editarProd();
                }
            }
        }
        void GuardarMPrima()
        {
            if (txtNombreInsumo.Text == "" )
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
                    tbpMain.SelectedIndex = 2;
                    Menu.Show(this, "Insumo agregado correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                }
                else
                {
                    editarMPrima();
                }
            }
        }
        #endregion
        private void tbProveedores_Enter(object sender, EventArgs e)
        {
            listarProveedores();
        }

        #region _Listar
        void listarProveedores()
        {
            tbProve.Rows.Clear();
            var lista = provRep.ObtenerTodos();
            foreach (var prov in lista)
            {
                tbProve.Rows.Add(prov.Id, prov.Nombre, prov.Telefono, prov.Direccion, prov.FRegistro);
            }
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
        void listarCategorias()
        {
            tbCag.Rows.Clear();
            var lista = categoriaRep.ObtenerTodos();
            foreach (var cat in lista)
            {
                tbCag.Rows.Add(cat.Id, cat.Nombre);
            }
        }
        void listarEmpleados()
        {
            tbEmpleados.Rows.Clear();
            var lista = empRep.GetAll();
            foreach (var emp in lista)
            {
                tbEmpleados.Rows.Add(emp.Id, emp.Cedula, emp.Nombre, emp.Apellido, emp.Telefono, emp.FechaIngreso);
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
        void listarProd()
        {
            tbProd.Rows.Clear();
            var lista = prodRep.GetAll();
            foreach (var prod in lista)
            {
                tbProd.Rows.Add(prod.Id, prod.Nombre, prod.MedidaProducto.Id,prod.MedidaProducto.NombreCorto, prod.CategoriaProducto.Id, prod.CategoriaProducto.Nombre, prod.Presentacion, prod.CostoProduccion, prod.PrecioVenta, prod.Ganancia);
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
        #endregion

        #region _listarCbx
        void listarEmpCbx(GunaComboBox cbx)
        {
            cbx.Items.Clear();
            var lista = empRep.GetAll();
            foreach (var emp in lista)
            {
                cbx.Items.Add(emp.Nombre);
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
        void listarCagCbx(GunaComboBox cbx)
        {
            cbx.Items.Clear();
            var lista = categoriaRep.ObtenerTodos();
            foreach (var cag in lista)
            {
                cbx.Items.Add(cag.Nombre);
            }
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
        #endregion

        #region _Limpiar
        void LimpiarMedida()
        {
            txtNombreCorto.Text = "";
            txtNLargo.Text = "";
        }
        void LimpiarCategoria()
        {
            txtNombreCategoria.Text = "";
        }
        void LimpiarProveedores()
        {
            txtNombreProv.Text = "";
            txtTelefonoProv.Text = "";
            txtDireccionProv.Text = "";
        }
        void LimpiarEmpleado()
        {
            txtCedulaEMp.Text = "";
            txtNombreEmp.Text = "";
            txtApellidoEmp.Text = "";
            txtTelefonoEmp.Text = "";
        }
        void LimpiarPlanta()
        {
            txtNombrePlanta.Text = "";
            cbxEmpPlanta.SelectedIndex = -1;
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
        void LimpiarMPrima()
        {
            txtNombreInsumo.Text = "";
            cbxMedidaInsumo.SelectedIndex = -1;
            cbxProveedorInsumo.SelectedIndex = -1;
            dpFExpiracionInsumo.Value = DateTime.Now;
        }
        #endregion
        private void btnInngresarProv_Click(object sender, EventArgs e)
        {
            GuardarProveedor();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editar = true;
            tbpMain.SelectedIndex = 11;
            pasarProvtxt();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarProv();
        }

        #region _eliminar
        void eliminarProv()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                provRep.Eliminar(IdSeleccionado);
                listarProveedores();
            }
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
        void eliminarCag()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar esta categoria?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                categoriaRep.Eliminar(IdSeleccionado);
                listarCategorias();
            }
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
        void eliminarPlanta()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar esta planta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                plantaRep.Eliminar(IdSeleccionado);
                listarPlantas();
            }
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
        void eliminarMPrima()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este insumo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                mprimaRep.Eliminar(IdSeleccionado);
                listarMPrima();
            }
        }
        #endregion

        #region _pasarTxt
        void pasarProvtxt()
        {
            var proveedor = provRep.ObtenerPorId(IdSeleccionado);
            txtNombreProv.Text = proveedor.Nombre;
            txtTelefonoProv.Text = proveedor.Telefono;
            txtDireccionProv.Text = proveedor.Direccion;
        }
        void pasarMedidatxt()
        {
            var medida = medidaRep.ObtenerPorId(IdSeleccionado);
            txtNombreCorto.Text = medida.NombreCorto;
            txtNLargo.Text = medida.NombreLargo;
        }
        void pasarCagtxt()
        {
            var cag = categoriaRep.ObtenerPorId(IdSeleccionado);
            txtNombreCategoria.Text = cag.Nombre;
        }
        void pasarEmptxt()
        {
            var emp = empRep.ObtenerPorId(IdSeleccionado);
            txtCedulaEMp.Text = emp.Cedula;
            txtNombreEmp.Text = emp.Nombre;
            txtApellidoEmp.Text = emp.Apellido;
            txtTelefonoEmp.Text = emp.Telefono;
        }
        void pasarPlanta()
        {

            var planta = plantaRep.ObtenerPorId(IdSeleccionado);
            txtNombrePlanta.Text = planta.Nombre;
            var idEmpleado = int.Parse(tbPlanta.CurrentRow.Cells["IdEmp"].Value.ToString());
            cbxEmpPlanta.SelectedIndex = empRep.ObtenerIndexPorId(idEmpleado);
            
            
        }
        void pasarProdtxt()
        {
            var prod = prodRep.ObtenerPorId(IdSeleccionado);
            txtNombreProd.Text = prod.Nombre;

            var idCag = int.Parse(tbProd.CurrentRow.Cells["IdCat"].Value.ToString());
            var idMed = int.Parse(tbProd.CurrentRow.Cells["IdMed"].Value.ToString());

            cbxCategoriaProd.SelectedIndex = categoriaRep.ObtenerIndexPorId(idCag);
            cbxMedidaProd.SelectedIndex = medidaRep.ObtenerIndexPorId(idMed);

            txtPresentacionProd.Text = prod.Presentacion;
            txtCProduccionProd.Text = prod.CostoProduccion.ToString();
            txtPVentaProd.Text = prod.PrecioVenta.ToString();

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

            dpFExpiracionInsumo.Value= mprima.FechaExpiracion;

        }
        #endregion

        #region _editar
        void editarProveedor()
        {
            
            var resultado = MessageBox.Show("¿Estás seguro de que deseas editar este proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado== DialogResult.Yes)
            {
                var proveedor = new Proveedores();
                proveedor.Nombre = txtNombreProv.Text;
                proveedor.Telefono = txtTelefonoProv.Text;
                proveedor.Direccion = txtDireccionProv.Text;
                var filas = provRep.Actualizar(proveedor,IdSeleccionado);
                if (filas==0)
                {
                    Menu.Show(this, "Hubo un error al guardar", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
                else
                {
                    tbpMain.SelectedIndex = 6;
                    Menu.Show(this, "Proveedor editado correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    txtNombreProv.Text = "";
                    txtTelefonoProv.Text = "";
                    txtDireccionProv.Text = "";
                }
                
            }

        }
        void editarMedida()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas editar esta medida?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var medida = new Medida();
                medida.NombreCorto = txtNombreCorto.Text;
                medida.NombreLargo = txtNLargo.Text;
                var filas = medidaRep.Actualizar(medida, IdSeleccionado);
                if (filas == 0)
                {
                    Menu.Show(this, "Hubo un error al guardar la medida", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
                else
                {
                    tbpMain.SelectedIndex = 4;
                    Menu.Show(this, "Medida editada correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    txtNombreCorto.Text = "";
                    txtNLargo.Text = "";
                }

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
                    tbpMain.SelectedIndex = 5;
                    Menu.Show(this, "Categoria editada correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    txtNombreCategoria.Text = "";
                }

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
                    tbpMain.SelectedIndex = 12;
                    Menu.Show(this, "Empleado editada correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    LimpiarEmpleado();
                }

            }
        }
        void editarPlanta()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas editar esta planta?", "Confirmar edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var planta = new Planta();
                planta.Nombre = txtNombrePlanta.Text;
                planta.EmpleadoAsignado = empRep.ObtenerPorIndex(cbxEmpPlanta.SelectedIndex);

                var filas = plantaRep.Actualizar(planta, IdSeleccionado);
                if (filas == 0)
                {
                    Menu.Show(this, "Hubo un error al guardar la planta", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
                else
                {
                    tbpMain.SelectedIndex = 7;
                    Menu.Show(this, "Planta editada correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    LimpiarEmpleado();
                }
            }   
        }
        void editarProd()
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas editar este producto?", "Confirmar edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var prod = new Producto();
                prod.Nombre = txtNombreProd.Text;
                prod.CategoriaProducto = categoriaRep.ObtenerPorIndex(cbxCategoriaProd.SelectedIndex);
                prod.MedidaProducto = medidaRep.ObtenerPorIndex(cbxMedidaProd.SelectedIndex);
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
                    tbpMain.SelectedIndex = 8;
                    Menu.Show(this, "Producto editado correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    LimpiarProd();
                }
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
                    tbpMain.SelectedIndex = 2;
                    Menu.Show(this, "Insumo editado correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    LimpiarMPrima();
                }
            }
        }
        #endregion


        private void tbProve_MouseDown(object sender, MouseEventArgs e)
        {
            var hti = tbProve.HitTest(e.X, e.Y);
            tbProve.ClearSelection();

            if (hti.RowIndex >= 0)
            {
                tbProve.Rows[hti.RowIndex].Selected = true;

                // Obtener el ID del elemento seleccionado
                IdSeleccionado = (int)tbProve.Rows[hti.RowIndex].Cells["IdProv"].Value;

            }
        }

        private void tbMedidas_MouseDown(object sender, MouseEventArgs e)
        {
            var hti = tbMedidas.HitTest(e.X, e.Y);
            tbMedidas.ClearSelection();

            if (hti.RowIndex >= 0)
            {
                tbMedidas.Rows[hti.RowIndex].Selected = true;
                // Obtener el ID del elemento seleccionado
                IdSeleccionado = (int)tbMedidas.Rows[hti.RowIndex].Cells["IdMedida"].Value;

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editar = true;
            tbpMain.SelectedIndex = 9;
            pasarMedidatxt();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            eliminarMedida();
        }

        private void tbCag_MouseDown(object sender, MouseEventArgs e)
        {
            var hti = tbCag.HitTest(e.X, e.Y);
            tbCag.ClearSelection();

            if (hti.RowIndex >= 0)
            {
                tbCag.Rows[hti.RowIndex].Selected = true;

                // Obtener el ID del elemento seleccionado
                IdSeleccionado = (int)tbCag.Rows[hti.RowIndex].Cells["IdCag"].Value;

            }
        }

        //MOCag Editar
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            editar = true;
            tbpMain.SelectedIndex = 10;
            pasarCagtxt();

        }
        //MOCag Eliminar
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            eliminarCag();
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 13;
            LimpiarEmpleado();
        }

        private void tbEmpleados_MouseDown(object sender, MouseEventArgs e)
        {
            var hti = tbEmpleados.HitTest(e.X, e.Y);
            tbEmpleados.ClearSelection();

            if (hti.RowIndex >= 0)
            {
                tbEmpleados.Rows[hti.RowIndex].Selected = true;

                // Obtener el ID del elemento seleccionado
                IdSeleccionado = (int)tbEmpleados.Rows[hti.RowIndex].Cells["IdEmp"].Value;

            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            editar = true;
            tbpMain.SelectedIndex = 13;
            pasarEmptxt();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            eliminarEmp();
        }

        private void btnIngresarEmp_Click(object sender, EventArgs e)
        {
            GuardarEmp();
        }

        private void tbpEmp_Enter(object sender, EventArgs e)
        {
            listarEmpleados();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 12;
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            LimpiarPlanta();
            editar = false;
            tbpMain.SelectedIndex = 15;
            listarEmpCbx(cbxEmpPlanta);
        }

        private void btnIngresarPlanta_Click(object sender, EventArgs e)
        {
            GuardarPlanta();
        }

        private void tbPlanta_MouseDown(object sender, MouseEventArgs e)
        {
            var hti = tbPlanta.HitTest(e.X, e.Y);
            tbPlanta.ClearSelection();

            if (hti.RowIndex >= 0)
            {
                tbPlanta.Rows[hti.RowIndex].Selected = true;

                // Obtener el ID del elemento seleccionado
                IdSeleccionado = (int)tbPlanta.Rows[hti.RowIndex].Cells["IdPlanta"].Value;

            }
        }

        private void tbPlantas_Enter(object sender, EventArgs e)
        {
            listarPlantas();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            editar = true;
            tbpMain.SelectedIndex = 15;
            pasarPlanta();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            eliminarPlanta();
        }

        private void metroTabPage3_Enter(object sender, EventArgs e)
        {
            listarEmpCbx(cbxEmpPlanta);
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            LimpiarProd();
            editar = false;
            tbpMain.SelectedIndex = 14;
            listarCagCbx(cbxCategoriaProd);
            listarMedCbx(cbxMedidaProd);

        }

        private void tbProductos_Enter(object sender, EventArgs e)
        {
            listarProd();
        }

        private void metroTabPage5_Enter(object sender, EventArgs e)
        {
            listarCagCbx(cbxCategoriaProd);
            listarMedCbx(cbxMedidaProd);
        }

        private void btnIngresarProd_Click(object sender, EventArgs e)
        {
            GuardarProd();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            editar = true;
            tbpMain.SelectedIndex = 14;
            pasarProdtxt();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            eliminarProd();
        }

        private void tbProd_MouseLeave(object sender, EventArgs e)
        {

        }

        private void tbProd_MouseDown(object sender, MouseEventArgs e)
        {
            var hti = tbProd.HitTest(e.X, e.Y);
            tbProd.ClearSelection();

            if (hti.RowIndex >= 0)
            {
                tbProd.Rows[hti.RowIndex].Selected = true;

                // Obtener el ID del elemento seleccionado
                IdSeleccionado = (int)tbProd.Rows[hti.RowIndex].Cells["IdProd"].Value;

            }
        }

        private void btnIngresarInsumo_Click(object sender, EventArgs e)
        {

            GuardarMPrima();
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            //16
            LimpiarMPrima();
            editar = false;
            tbpMain.SelectedIndex = 16;
            listarMedCbx(cbxMedidaInsumo);
            listarProvCbx(cbxProveedorInsumo);
 
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            pasarMPrimatxt();
            editar = true;
            tbpMain.SelectedIndex = 16;
            

        }

        private void MOMPrima_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            eliminarMPrima();
        }

        private void metroTabPage7_Enter(object sender, EventArgs e)
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

                // Obtener el ID del elemento seleccionado
                IdSeleccionado = (int)tbMPrima.Rows[hti.RowIndex].Cells["IdMprima"].Value;

            }
        }

        private void gunaAdvenceTileButton9_Click(object sender, EventArgs e)
        {
            tbpMain.SelectedIndex = 17;
        }
    }
}
