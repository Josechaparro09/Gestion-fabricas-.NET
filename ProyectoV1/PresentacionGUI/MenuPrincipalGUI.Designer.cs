namespace PresentacionGUI
{
    partial class MenuPrincipalGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalGUI));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tbpMain = new MetroFramework.Controls.MetroTabControl();
            this.tbRegistros = new MetroFramework.Controls.MetroTabPage();
            this.btnProductos = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnPlantas = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnProveedores = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnCategorias = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnMedidas = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.txtUsuario = new Bunifu.UI.WinForms.BunifuTextBox();
            this.tbProduccion = new MetroFramework.Controls.MetroTabPage();
            this.gunaAdvenceTileButton3 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaAdvenceTileButton2 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.tbInsumos = new MetroFramework.Controls.MetroTabPage();
            this.gunaAdvenceTileButton9 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaAdvenceTileButton1 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.tbVentas = new MetroFramework.Controls.MetroTabPage();
            this.gunaAdvenceTileButton10 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaAdvenceTileButton11 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.tbMedida = new MetroFramework.Controls.MetroTabPage();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.tbCategorias = new MetroFramework.Controls.MetroTabPage();
            this.gunaButton6 = new Guna.UI.WinForms.GunaButton();
            this.tbProveedores = new MetroFramework.Controls.MetroTabPage();
            this.gunaButton7 = new Guna.UI.WinForms.GunaButton();
            this.tbPlantas = new MetroFramework.Controls.MetroTabPage();
            this.gunaButton8 = new Guna.UI.WinForms.GunaButton();
            this.tbProductos = new MetroFramework.Controls.MetroTabPage();
            this.gunaButton9 = new Guna.UI.WinForms.GunaButton();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.pnlMenu = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNombre = new Bunifu.UI.WinForms.BunifuLabel();
            this.Menu = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.tbpMain.SuspendLayout();
            this.tbRegistros.SuspendLayout();
            this.tbProduccion.SuspendLayout();
            this.tbInsumos.SuspendLayout();
            this.tbVentas.SuspendLayout();
            this.tbMedida.SuspendLayout();
            this.tbCategorias.SuspendLayout();
            this.tbProveedores.SuspendLayout();
            this.tbPlantas.SuspendLayout();
            this.tbProductos.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1075, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // tbpMain
            // 
            this.tbpMain.AllowDrop = true;
            this.tbpMain.Controls.Add(this.tbRegistros);
            this.tbpMain.Controls.Add(this.tbProduccion);
            this.tbpMain.Controls.Add(this.tbInsumos);
            this.tbpMain.Controls.Add(this.tbVentas);
            this.tbpMain.Controls.Add(this.tbMedida);
            this.tbpMain.Controls.Add(this.tbCategorias);
            this.tbpMain.Controls.Add(this.tbProveedores);
            this.tbpMain.Controls.Add(this.tbPlantas);
            this.tbpMain.Controls.Add(this.tbProductos);
            this.tbpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpMain.Location = new System.Drawing.Point(252, 24);
            this.tbpMain.Multiline = true;
            this.tbpMain.Name = "tbpMain";
            this.tbpMain.SelectedIndex = 0;
            this.tbpMain.Size = new System.Drawing.Size(823, 604);
            this.tbpMain.TabIndex = 6;
            this.tbpMain.TabStop = false;
            this.tbpMain.UseSelectable = true;
            this.tbpMain.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // tbRegistros
            // 
            this.tbRegistros.Controls.Add(this.btnProductos);
            this.tbRegistros.Controls.Add(this.btnPlantas);
            this.tbRegistros.Controls.Add(this.btnProveedores);
            this.tbRegistros.Controls.Add(this.btnCategorias);
            this.tbRegistros.Controls.Add(this.btnMedidas);
            this.tbRegistros.Controls.Add(this.txtUsuario);
            this.tbRegistros.HorizontalScrollbarBarColor = true;
            this.tbRegistros.HorizontalScrollbarHighlightOnWheel = false;
            this.tbRegistros.HorizontalScrollbarSize = 10;
            this.tbRegistros.Location = new System.Drawing.Point(4, 38);
            this.tbRegistros.Name = "tbRegistros";
            this.tbRegistros.Size = new System.Drawing.Size(815, 562);
            this.tbRegistros.TabIndex = 0;
            this.tbRegistros.Text = "Registros";
            this.tbRegistros.VerticalScrollbarBarColor = true;
            this.tbRegistros.VerticalScrollbarHighlightOnWheel = false;
            this.tbRegistros.VerticalScrollbarSize = 10;
            // 
            // btnProductos
            // 
            this.btnProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnProductos.Animated = true;
            this.btnProductos.AnimationHoverSpeed = 0.07F;
            this.btnProductos.AnimationSpeed = 0.03F;
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnProductos.BorderColor = System.Drawing.Color.Black;
            this.btnProductos.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnProductos.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnProductos.CheckedForeColor = System.Drawing.Color.White;
            this.btnProductos.CheckedImage = global::PresentacionGUI.Properties.Resources.Producto;
            this.btnProductos.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProductos.FocusedColor = System.Drawing.Color.Empty;
            this.btnProductos.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = global::PresentacionGUI.Properties.Resources.Producto;
            this.btnProductos.ImageSize = new System.Drawing.Size(72, 72);
            this.btnProductos.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnProductos.Location = new System.Drawing.Point(299, 308);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnProductos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnProductos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnProductos.OnHoverImage = null;
            this.btnProductos.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnProductos.OnPressedColor = System.Drawing.Color.Black;
            this.btnProductos.Radius = 30;
            this.btnProductos.Size = new System.Drawing.Size(210, 210);
            this.btnProductos.TabIndex = 13;
            this.btnProductos.Text = "Productos";
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnPlantas
            // 
            this.btnPlantas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPlantas.Animated = true;
            this.btnPlantas.AnimationHoverSpeed = 0.07F;
            this.btnPlantas.AnimationSpeed = 0.03F;
            this.btnPlantas.BackColor = System.Drawing.Color.Transparent;
            this.btnPlantas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPlantas.BorderColor = System.Drawing.Color.Black;
            this.btnPlantas.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPlantas.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPlantas.CheckedForeColor = System.Drawing.Color.White;
            this.btnPlantas.CheckedImage = global::PresentacionGUI.Properties.Resources.Planta;
            this.btnPlantas.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPlantas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlantas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlantas.FocusedColor = System.Drawing.Color.Empty;
            this.btnPlantas.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlantas.ForeColor = System.Drawing.Color.White;
            this.btnPlantas.Image = global::PresentacionGUI.Properties.Resources.Planta;
            this.btnPlantas.ImageSize = new System.Drawing.Size(72, 72);
            this.btnPlantas.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPlantas.Location = new System.Drawing.Point(30, 308);
            this.btnPlantas.Name = "btnPlantas";
            this.btnPlantas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnPlantas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPlantas.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPlantas.OnHoverImage = null;
            this.btnPlantas.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPlantas.OnPressedColor = System.Drawing.Color.Black;
            this.btnPlantas.Radius = 30;
            this.btnPlantas.Size = new System.Drawing.Size(210, 210);
            this.btnPlantas.TabIndex = 13;
            this.btnPlantas.Text = "Plantas";
            this.btnPlantas.Click += new System.EventHandler(this.btnPlantas_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnProveedores.Animated = true;
            this.btnProveedores.AnimationHoverSpeed = 0.07F;
            this.btnProveedores.AnimationSpeed = 0.03F;
            this.btnProveedores.BackColor = System.Drawing.Color.Transparent;
            this.btnProveedores.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnProveedores.BorderColor = System.Drawing.Color.Black;
            this.btnProveedores.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnProveedores.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnProveedores.CheckedForeColor = System.Drawing.Color.White;
            this.btnProveedores.CheckedImage = global::PresentacionGUI.Properties.Resources.Proveedor;
            this.btnProveedores.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProveedores.FocusedColor = System.Drawing.Color.Empty;
            this.btnProveedores.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Image = global::PresentacionGUI.Properties.Resources.Proveedor;
            this.btnProveedores.ImageSize = new System.Drawing.Size(72, 72);
            this.btnProveedores.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnProveedores.Location = new System.Drawing.Point(575, 47);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnProveedores.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnProveedores.OnHoverForeColor = System.Drawing.Color.White;
            this.btnProveedores.OnHoverImage = null;
            this.btnProveedores.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnProveedores.OnPressedColor = System.Drawing.Color.Black;
            this.btnProveedores.Radius = 30;
            this.btnProveedores.Size = new System.Drawing.Size(210, 210);
            this.btnProveedores.TabIndex = 13;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCategorias.Animated = true;
            this.btnCategorias.AnimationHoverSpeed = 0.07F;
            this.btnCategorias.AnimationSpeed = 0.03F;
            this.btnCategorias.BackColor = System.Drawing.Color.Transparent;
            this.btnCategorias.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCategorias.BorderColor = System.Drawing.Color.Black;
            this.btnCategorias.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCategorias.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCategorias.CheckedForeColor = System.Drawing.Color.White;
            this.btnCategorias.CheckedImage = global::PresentacionGUI.Properties.Resources.Categorias;
            this.btnCategorias.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCategorias.FocusedColor = System.Drawing.Color.Empty;
            this.btnCategorias.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.Image = global::PresentacionGUI.Properties.Resources.Categorias;
            this.btnCategorias.ImageSize = new System.Drawing.Size(72, 72);
            this.btnCategorias.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCategorias.Location = new System.Drawing.Point(299, 47);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnCategorias.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCategorias.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCategorias.OnHoverImage = null;
            this.btnCategorias.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCategorias.OnPressedColor = System.Drawing.Color.Black;
            this.btnCategorias.Radius = 30;
            this.btnCategorias.Size = new System.Drawing.Size(210, 210);
            this.btnCategorias.TabIndex = 13;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnMedidas
            // 
            this.btnMedidas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMedidas.Animated = true;
            this.btnMedidas.AnimationHoverSpeed = 0.07F;
            this.btnMedidas.AnimationSpeed = 0.03F;
            this.btnMedidas.BackColor = System.Drawing.Color.Transparent;
            this.btnMedidas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnMedidas.BorderColor = System.Drawing.Color.Black;
            this.btnMedidas.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnMedidas.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnMedidas.CheckedForeColor = System.Drawing.Color.White;
            this.btnMedidas.CheckedImage = global::PresentacionGUI.Properties.Resources.Medida;
            this.btnMedidas.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnMedidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedidas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMedidas.FocusedColor = System.Drawing.Color.Empty;
            this.btnMedidas.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedidas.ForeColor = System.Drawing.Color.White;
            this.btnMedidas.Image = global::PresentacionGUI.Properties.Resources.Medida;
            this.btnMedidas.ImageSize = new System.Drawing.Size(72, 72);
            this.btnMedidas.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMedidas.Location = new System.Drawing.Point(30, 47);
            this.btnMedidas.Name = "btnMedidas";
            this.btnMedidas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnMedidas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMedidas.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMedidas.OnHoverImage = null;
            this.btnMedidas.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMedidas.OnPressedColor = System.Drawing.Color.Black;
            this.btnMedidas.Radius = 30;
            this.btnMedidas.Size = new System.Drawing.Size(210, 210);
            this.btnMedidas.TabIndex = 13;
            this.btnMedidas.Text = "Medidas";
            this.btnMedidas.Click += new System.EventHandler(this.btnMedidas_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.AcceptsReturn = false;
            this.txtUsuario.AcceptsTab = false;
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.AnimationSpeed = 200;
            this.txtUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUsuario.BackgroundImage")));
            this.txtUsuario.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtUsuario.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUsuario.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtUsuario.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtUsuario.BorderRadius = 10;
            this.txtUsuario.BorderThickness = 0;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.DefaultText = "";
            this.txtUsuario.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsuario.HideSelection = true;
            this.txtUsuario.IconLeft = null;
            this.txtUsuario.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.IconPadding = 10;
            this.txtUsuario.IconRight = null;
            this.txtUsuario.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(582, 21);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUsuario.Modified = false;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties4.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.OnIdleState = stateProperties4;
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.PlaceholderText = "Buscar";
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(215, 35);
            this.txtUsuario.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtUsuario.TabIndex = 7;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.TextMarginBottom = 0;
            this.txtUsuario.TextMarginLeft = 3;
            this.txtUsuario.TextMarginTop = 0;
            this.txtUsuario.TextPlaceholder = "Buscar";
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.Visible = false;
            this.txtUsuario.WordWrap = true;
            // 
            // tbProduccion
            // 
            this.tbProduccion.Controls.Add(this.gunaAdvenceTileButton3);
            this.tbProduccion.Controls.Add(this.gunaAdvenceTileButton2);
            this.tbProduccion.HorizontalScrollbarBarColor = true;
            this.tbProduccion.HorizontalScrollbarHighlightOnWheel = false;
            this.tbProduccion.HorizontalScrollbarSize = 10;
            this.tbProduccion.Location = new System.Drawing.Point(4, 38);
            this.tbProduccion.Name = "tbProduccion";
            this.tbProduccion.Size = new System.Drawing.Size(815, 562);
            this.tbProduccion.TabIndex = 1;
            this.tbProduccion.Text = "Produccion";
            this.tbProduccion.VerticalScrollbarBarColor = true;
            this.tbProduccion.VerticalScrollbarHighlightOnWheel = false;
            this.tbProduccion.VerticalScrollbarSize = 10;
            // 
            // gunaAdvenceTileButton3
            // 
            this.gunaAdvenceTileButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaAdvenceTileButton3.Animated = true;
            this.gunaAdvenceTileButton3.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton3.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton3.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton3.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton3.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton3.CheckedImage = global::PresentacionGUI.Properties.Resources.Produccion;
            this.gunaAdvenceTileButton3.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceTileButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton3.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceTileButton3.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton3.Image = global::PresentacionGUI.Properties.Resources.Produccion;
            this.gunaAdvenceTileButton3.ImageSize = new System.Drawing.Size(72, 72);
            this.gunaAdvenceTileButton3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton3.Location = new System.Drawing.Point(450, 128);
            this.gunaAdvenceTileButton3.Name = "gunaAdvenceTileButton3";
            this.gunaAdvenceTileButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.gunaAdvenceTileButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton3.OnHoverImage = null;
            this.gunaAdvenceTileButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton3.Radius = 30;
            this.gunaAdvenceTileButton3.Size = new System.Drawing.Size(210, 210);
            this.gunaAdvenceTileButton3.TabIndex = 12;
            this.gunaAdvenceTileButton3.Text = "Producciones";
            // 
            // gunaAdvenceTileButton2
            // 
            this.gunaAdvenceTileButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaAdvenceTileButton2.Animated = true;
            this.gunaAdvenceTileButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton2.CheckedImage = global::PresentacionGUI.Properties.Resources.Receta;
            this.gunaAdvenceTileButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceTileButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton2.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceTileButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton2.Image = global::PresentacionGUI.Properties.Resources.Receta;
            this.gunaAdvenceTileButton2.ImageSize = new System.Drawing.Size(72, 72);
            this.gunaAdvenceTileButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton2.Location = new System.Drawing.Point(166, 128);
            this.gunaAdvenceTileButton2.Name = "gunaAdvenceTileButton2";
            this.gunaAdvenceTileButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.gunaAdvenceTileButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton2.OnHoverImage = null;
            this.gunaAdvenceTileButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.Radius = 30;
            this.gunaAdvenceTileButton2.Size = new System.Drawing.Size(210, 210);
            this.gunaAdvenceTileButton2.TabIndex = 12;
            this.gunaAdvenceTileButton2.Text = "Recetas de produccion";
            // 
            // tbInsumos
            // 
            this.tbInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.tbInsumos.Controls.Add(this.gunaAdvenceTileButton9);
            this.tbInsumos.Controls.Add(this.gunaAdvenceTileButton1);
            this.tbInsumos.HorizontalScrollbarBarColor = true;
            this.tbInsumos.HorizontalScrollbarHighlightOnWheel = false;
            this.tbInsumos.HorizontalScrollbarSize = 10;
            this.tbInsumos.Location = new System.Drawing.Point(4, 38);
            this.tbInsumos.Name = "tbInsumos";
            this.tbInsumos.Size = new System.Drawing.Size(815, 562);
            this.tbInsumos.TabIndex = 2;
            this.tbInsumos.Text = "Insumos";
            this.tbInsumos.VerticalScrollbarBarColor = true;
            this.tbInsumos.VerticalScrollbarHighlightOnWheel = false;
            this.tbInsumos.VerticalScrollbarSize = 10;
            // 
            // gunaAdvenceTileButton9
            // 
            this.gunaAdvenceTileButton9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaAdvenceTileButton9.Animated = true;
            this.gunaAdvenceTileButton9.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton9.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton9.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton9.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton9.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton9.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton9.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton9.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton9.CheckedImage = global::PresentacionGUI.Properties.Resources.Ver_insumos;
            this.gunaAdvenceTileButton9.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceTileButton9.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton9.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton9.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceTileButton9.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton9.Image = global::PresentacionGUI.Properties.Resources.Ver_insumos;
            this.gunaAdvenceTileButton9.ImageSize = new System.Drawing.Size(72, 72);
            this.gunaAdvenceTileButton9.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton9.Location = new System.Drawing.Point(450, 128);
            this.gunaAdvenceTileButton9.Name = "gunaAdvenceTileButton9";
            this.gunaAdvenceTileButton9.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.gunaAdvenceTileButton9.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton9.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton9.OnHoverImage = null;
            this.gunaAdvenceTileButton9.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton9.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton9.Radius = 30;
            this.gunaAdvenceTileButton9.Size = new System.Drawing.Size(210, 210);
            this.gunaAdvenceTileButton9.TabIndex = 14;
            this.gunaAdvenceTileButton9.Text = "Ver insumos";
            // 
            // gunaAdvenceTileButton1
            // 
            this.gunaAdvenceTileButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaAdvenceTileButton1.Animated = true;
            this.gunaAdvenceTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.CheckedImage = global::PresentacionGUI.Properties.Resources.Insumos;
            this.gunaAdvenceTileButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceTileButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.Image = global::PresentacionGUI.Properties.Resources.Insumos;
            this.gunaAdvenceTileButton1.ImageSize = new System.Drawing.Size(72, 72);
            this.gunaAdvenceTileButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.Location = new System.Drawing.Point(166, 128);
            this.gunaAdvenceTileButton1.Name = "gunaAdvenceTileButton1";
            this.gunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.gunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.OnHoverImage = null;
            this.gunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.Radius = 30;
            this.gunaAdvenceTileButton1.Size = new System.Drawing.Size(210, 210);
            this.gunaAdvenceTileButton1.TabIndex = 13;
            this.gunaAdvenceTileButton1.Text = "Agregar insumo";
            // 
            // tbVentas
            // 
            this.tbVentas.Controls.Add(this.gunaAdvenceTileButton10);
            this.tbVentas.Controls.Add(this.gunaAdvenceTileButton11);
            this.tbVentas.HorizontalScrollbarBarColor = true;
            this.tbVentas.HorizontalScrollbarHighlightOnWheel = false;
            this.tbVentas.HorizontalScrollbarSize = 10;
            this.tbVentas.Location = new System.Drawing.Point(4, 38);
            this.tbVentas.Name = "tbVentas";
            this.tbVentas.Size = new System.Drawing.Size(815, 562);
            this.tbVentas.TabIndex = 3;
            this.tbVentas.Text = "Ventas";
            this.tbVentas.VerticalScrollbarBarColor = true;
            this.tbVentas.VerticalScrollbarHighlightOnWheel = false;
            this.tbVentas.VerticalScrollbarSize = 10;
            // 
            // gunaAdvenceTileButton10
            // 
            this.gunaAdvenceTileButton10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaAdvenceTileButton10.Animated = true;
            this.gunaAdvenceTileButton10.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton10.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton10.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton10.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton10.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton10.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton10.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton10.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton10.CheckedImage = global::PresentacionGUI.Properties.Resources.Ver_ventas;
            this.gunaAdvenceTileButton10.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceTileButton10.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton10.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton10.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceTileButton10.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton10.Image = global::PresentacionGUI.Properties.Resources.Ver_ventas;
            this.gunaAdvenceTileButton10.ImageSize = new System.Drawing.Size(72, 72);
            this.gunaAdvenceTileButton10.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton10.Location = new System.Drawing.Point(450, 128);
            this.gunaAdvenceTileButton10.Name = "gunaAdvenceTileButton10";
            this.gunaAdvenceTileButton10.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.gunaAdvenceTileButton10.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton10.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton10.OnHoverImage = null;
            this.gunaAdvenceTileButton10.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton10.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton10.Radius = 30;
            this.gunaAdvenceTileButton10.Size = new System.Drawing.Size(210, 210);
            this.gunaAdvenceTileButton10.TabIndex = 16;
            this.gunaAdvenceTileButton10.Text = "Ver Ventas";
            // 
            // gunaAdvenceTileButton11
            // 
            this.gunaAdvenceTileButton11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaAdvenceTileButton11.Animated = true;
            this.gunaAdvenceTileButton11.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton11.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton11.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton11.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton11.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton11.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton11.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton11.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton11.CheckedImage = global::PresentacionGUI.Properties.Resources.Nueva_venta;
            this.gunaAdvenceTileButton11.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceTileButton11.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton11.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton11.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceTileButton11.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton11.Image = global::PresentacionGUI.Properties.Resources.Nueva_venta;
            this.gunaAdvenceTileButton11.ImageSize = new System.Drawing.Size(72, 72);
            this.gunaAdvenceTileButton11.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton11.Location = new System.Drawing.Point(166, 128);
            this.gunaAdvenceTileButton11.Name = "gunaAdvenceTileButton11";
            this.gunaAdvenceTileButton11.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.gunaAdvenceTileButton11.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton11.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton11.OnHoverImage = null;
            this.gunaAdvenceTileButton11.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton11.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton11.Radius = 30;
            this.gunaAdvenceTileButton11.Size = new System.Drawing.Size(210, 210);
            this.gunaAdvenceTileButton11.TabIndex = 15;
            this.gunaAdvenceTileButton11.Text = "Nueva venta";
            // 
            // tbMedida
            // 
            this.tbMedida.Controls.Add(this.gunaButton5);
            this.tbMedida.HorizontalScrollbarBarColor = true;
            this.tbMedida.HorizontalScrollbarHighlightOnWheel = false;
            this.tbMedida.HorizontalScrollbarSize = 10;
            this.tbMedida.Location = new System.Drawing.Point(4, 38);
            this.tbMedida.Name = "tbMedida";
            this.tbMedida.Size = new System.Drawing.Size(815, 562);
            this.tbMedida.TabIndex = 4;
            this.tbMedida.Text = "Medidas";
            this.tbMedida.VerticalScrollbarBarColor = true;
            this.tbMedida.VerticalScrollbarHighlightOnWheel = false;
            this.tbMedida.VerticalScrollbarSize = 10;
            this.tbMedida.Click += new System.EventHandler(this.tbMedida_Click);
            // 
            // gunaButton5
            // 
            this.gunaButton5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaButton5.Animated = true;
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton5.ForeColor = System.Drawing.Color.White;
            this.gunaButton5.Image = global::PresentacionGUI.Properties.Resources.Registros;
            this.gunaButton5.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton5.Location = new System.Drawing.Point(304, 12);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Radius = 20;
            this.gunaButton5.Size = new System.Drawing.Size(234, 62);
            this.gunaButton5.TabIndex = 14;
            this.gunaButton5.Text = "Nueva medida";
            this.gunaButton5.TextOffsetX = 10;
            // 
            // tbCategorias
            // 
            this.tbCategorias.Controls.Add(this.gunaButton6);
            this.tbCategorias.HorizontalScrollbarBarColor = true;
            this.tbCategorias.HorizontalScrollbarHighlightOnWheel = false;
            this.tbCategorias.HorizontalScrollbarSize = 10;
            this.tbCategorias.Location = new System.Drawing.Point(4, 38);
            this.tbCategorias.Name = "tbCategorias";
            this.tbCategorias.Size = new System.Drawing.Size(815, 562);
            this.tbCategorias.TabIndex = 5;
            this.tbCategorias.Text = "Categorias";
            this.tbCategorias.VerticalScrollbarBarColor = true;
            this.tbCategorias.VerticalScrollbarHighlightOnWheel = false;
            this.tbCategorias.VerticalScrollbarSize = 10;
            // 
            // gunaButton6
            // 
            this.gunaButton6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaButton6.Animated = true;
            this.gunaButton6.AnimationHoverSpeed = 0.07F;
            this.gunaButton6.AnimationSpeed = 0.03F;
            this.gunaButton6.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton6.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton6.ForeColor = System.Drawing.Color.White;
            this.gunaButton6.Image = global::PresentacionGUI.Properties.Resources.Registros;
            this.gunaButton6.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton6.Location = new System.Drawing.Point(304, 12);
            this.gunaButton6.Name = "gunaButton6";
            this.gunaButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.gunaButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton6.OnHoverImage = null;
            this.gunaButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton6.Radius = 20;
            this.gunaButton6.Size = new System.Drawing.Size(234, 62);
            this.gunaButton6.TabIndex = 15;
            this.gunaButton6.Text = "Nueva categoria";
            this.gunaButton6.TextOffsetX = 10;
            // 
            // tbProveedores
            // 
            this.tbProveedores.Controls.Add(this.gunaButton7);
            this.tbProveedores.HorizontalScrollbarBarColor = true;
            this.tbProveedores.HorizontalScrollbarHighlightOnWheel = false;
            this.tbProveedores.HorizontalScrollbarSize = 10;
            this.tbProveedores.Location = new System.Drawing.Point(4, 38);
            this.tbProveedores.Name = "tbProveedores";
            this.tbProveedores.Size = new System.Drawing.Size(815, 562);
            this.tbProveedores.TabIndex = 6;
            this.tbProveedores.Text = "Proveedores";
            this.tbProveedores.VerticalScrollbarBarColor = true;
            this.tbProveedores.VerticalScrollbarHighlightOnWheel = false;
            this.tbProveedores.VerticalScrollbarSize = 10;
            // 
            // gunaButton7
            // 
            this.gunaButton7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaButton7.Animated = true;
            this.gunaButton7.AnimationHoverSpeed = 0.07F;
            this.gunaButton7.AnimationSpeed = 0.03F;
            this.gunaButton7.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton7.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton7.BorderColor = System.Drawing.Color.Black;
            this.gunaButton7.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton7.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton7.ForeColor = System.Drawing.Color.White;
            this.gunaButton7.Image = global::PresentacionGUI.Properties.Resources.Registros;
            this.gunaButton7.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton7.Location = new System.Drawing.Point(304, 12);
            this.gunaButton7.Name = "gunaButton7";
            this.gunaButton7.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.gunaButton7.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton7.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton7.OnHoverImage = null;
            this.gunaButton7.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton7.Radius = 20;
            this.gunaButton7.Size = new System.Drawing.Size(234, 62);
            this.gunaButton7.TabIndex = 16;
            this.gunaButton7.Text = "Nuevo proveedor";
            this.gunaButton7.TextOffsetX = 10;
            this.gunaButton7.Click += new System.EventHandler(this.gunaButton7_Click);
            // 
            // tbPlantas
            // 
            this.tbPlantas.Controls.Add(this.gunaButton8);
            this.tbPlantas.HorizontalScrollbarBarColor = true;
            this.tbPlantas.HorizontalScrollbarHighlightOnWheel = false;
            this.tbPlantas.HorizontalScrollbarSize = 10;
            this.tbPlantas.Location = new System.Drawing.Point(4, 38);
            this.tbPlantas.Name = "tbPlantas";
            this.tbPlantas.Size = new System.Drawing.Size(815, 562);
            this.tbPlantas.TabIndex = 7;
            this.tbPlantas.Text = "Plantas";
            this.tbPlantas.VerticalScrollbarBarColor = true;
            this.tbPlantas.VerticalScrollbarHighlightOnWheel = false;
            this.tbPlantas.VerticalScrollbarSize = 10;
            // 
            // gunaButton8
            // 
            this.gunaButton8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaButton8.Animated = true;
            this.gunaButton8.AnimationHoverSpeed = 0.07F;
            this.gunaButton8.AnimationSpeed = 0.03F;
            this.gunaButton8.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton8.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton8.BorderColor = System.Drawing.Color.Black;
            this.gunaButton8.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton8.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton8.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton8.ForeColor = System.Drawing.Color.White;
            this.gunaButton8.Image = global::PresentacionGUI.Properties.Resources.Registros;
            this.gunaButton8.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton8.Location = new System.Drawing.Point(304, 12);
            this.gunaButton8.Name = "gunaButton8";
            this.gunaButton8.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.gunaButton8.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton8.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton8.OnHoverImage = null;
            this.gunaButton8.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton8.Radius = 20;
            this.gunaButton8.Size = new System.Drawing.Size(234, 62);
            this.gunaButton8.TabIndex = 16;
            this.gunaButton8.Text = "Nueva planta";
            this.gunaButton8.TextOffsetX = 10;
            // 
            // tbProductos
            // 
            this.tbProductos.Controls.Add(this.gunaButton9);
            this.tbProductos.HorizontalScrollbarBarColor = true;
            this.tbProductos.HorizontalScrollbarHighlightOnWheel = false;
            this.tbProductos.HorizontalScrollbarSize = 10;
            this.tbProductos.Location = new System.Drawing.Point(4, 38);
            this.tbProductos.Name = "tbProductos";
            this.tbProductos.Size = new System.Drawing.Size(815, 562);
            this.tbProductos.TabIndex = 8;
            this.tbProductos.Text = "Productos";
            this.tbProductos.VerticalScrollbarBarColor = true;
            this.tbProductos.VerticalScrollbarHighlightOnWheel = false;
            this.tbProductos.VerticalScrollbarSize = 10;
            // 
            // gunaButton9
            // 
            this.gunaButton9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaButton9.Animated = true;
            this.gunaButton9.AnimationHoverSpeed = 0.07F;
            this.gunaButton9.AnimationSpeed = 0.03F;
            this.gunaButton9.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton9.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton9.BorderColor = System.Drawing.Color.Black;
            this.gunaButton9.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton9.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton9.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton9.ForeColor = System.Drawing.Color.White;
            this.gunaButton9.Image = global::PresentacionGUI.Properties.Resources.Registros;
            this.gunaButton9.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton9.Location = new System.Drawing.Point(304, 12);
            this.gunaButton9.Name = "gunaButton9";
            this.gunaButton9.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.gunaButton9.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton9.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton9.OnHoverImage = null;
            this.gunaButton9.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton9.Radius = 20;
            this.gunaButton9.Size = new System.Drawing.Size(234, 62);
            this.gunaButton9.TabIndex = 16;
            this.gunaButton9.Text = "Nuevo producto";
            this.gunaButton9.TextOffsetX = 10;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(87)))));
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1030, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(87)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 14;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(87)))));
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(979, 0);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(87)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 15;
            // 
            // gunaControlBox3
            // 
            this.gunaControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox3.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox3.AnimationSpeed = 0.03F;
            this.gunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(87)))));
            this.gunaControlBox3.IconSize = 15F;
            this.gunaControlBox3.Location = new System.Drawing.Point(928, 0);
            this.gunaControlBox3.Name = "gunaControlBox3";
            this.gunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(87)))));
            this.gunaControlBox3.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox3.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox3.TabIndex = 16;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(87)))));
            this.pnlMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenu.BackgroundImage")));
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.BorderColor = System.Drawing.Color.Transparent;
            this.pnlMenu.BorderRadius = 3;
            this.pnlMenu.BorderThickness = 1;
            this.pnlMenu.Controls.Add(this.bunifuPictureBox1);
            this.pnlMenu.Controls.Add(this.lblNombre);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 24);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.ShowBorders = true;
            this.pnlMenu.Size = new System.Drawing.Size(252, 604);
            this.pnlMenu.TabIndex = 2;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 50;
            this.bunifuPictureBox1.Image = global::PresentacionGUI.Properties.Resources.Logo;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(73, 21);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 2;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.gunaButton4);
            this.panel1.Controls.Add(this.gunaButton3);
            this.panel1.Controls.Add(this.gunaButton2);
            this.panel1.Controls.Add(this.gunaButton1);
            this.panel1.Location = new System.Drawing.Point(5, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 438);
            this.panel1.TabIndex = 0;
            // 
            // gunaButton4
            // 
            this.gunaButton4.Animated = true;
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(87)))));
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaButton4.Image = global::PresentacionGUI.Properties.Resources.Venta;
            this.gunaButton4.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton4.Location = new System.Drawing.Point(3, 207);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(117)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Radius = 20;
            this.gunaButton4.Size = new System.Drawing.Size(234, 62);
            this.gunaButton4.TabIndex = 13;
            this.gunaButton4.Text = "Ventas";
            this.gunaButton4.TextOffsetX = 10;
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // gunaButton3
            // 
            this.gunaButton3.Animated = true;
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(87)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = global::PresentacionGUI.Properties.Resources.Insumo_saco;
            this.gunaButton3.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton3.Location = new System.Drawing.Point(3, 139);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(117)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 20;
            this.gunaButton3.Size = new System.Drawing.Size(234, 62);
            this.gunaButton3.TabIndex = 13;
            this.gunaButton3.Text = "Insumos";
            this.gunaButton3.TextOffsetX = 10;
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.Animated = true;
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(87)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = global::PresentacionGUI.Properties.Resources.Produccion;
            this.gunaButton2.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton2.Location = new System.Drawing.Point(3, 71);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(117)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 20;
            this.gunaButton2.Size = new System.Drawing.Size(234, 62);
            this.gunaButton2.TabIndex = 13;
            this.gunaButton2.Text = "Produccion";
            this.gunaButton2.TextOffsetX = 10;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.Animated = true;
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(87)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::PresentacionGUI.Properties.Resources.Registros;
            this.gunaButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton1.Location = new System.Drawing.Point(3, 3);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(117)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(234, 62);
            this.gunaButton1.TabIndex = 13;
            this.gunaButton1.Text = "Registros";
            this.gunaButton1.TextOffsetX = 10;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(256, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 26);
            this.panel2.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AllowParentOverrides = false;
            this.lblNombre.AutoEllipsis = false;
            this.lblNombre.CursorType = null;
            this.lblNombre.Font = new System.Drawing.Font("Poppins Medium", 15.14F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(84, 127);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNombre.Size = new System.Drawing.Size(79, 34);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Usuario";
            this.lblNombre.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNombre.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Menu
            // 
            this.Menu.AllowDragging = false;
            this.Menu.AllowMultipleViews = true;
            this.Menu.ClickToClose = true;
            this.Menu.DoubleClickToClose = true;
            this.Menu.DurationAfterIdle = 3000;
            this.Menu.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Menu.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Menu.ErrorOptions.ActionBorderRadius = 1;
            this.Menu.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Menu.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Menu.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.Menu.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.Menu.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.Menu.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Menu.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.Menu.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.Menu.ErrorOptions.IconLeftMargin = 12;
            this.Menu.FadeCloseIcon = false;
            this.Menu.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.Menu.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Menu.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Menu.InformationOptions.ActionBorderRadius = 1;
            this.Menu.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Menu.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Menu.InformationOptions.BackColor = System.Drawing.Color.White;
            this.Menu.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.Menu.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.Menu.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Menu.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.Menu.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.Menu.InformationOptions.IconLeftMargin = 12;
            this.Menu.Margin = 10;
            this.Menu.MaximumSize = new System.Drawing.Size(0, 0);
            this.Menu.MaximumViews = 7;
            this.Menu.MessageRightMargin = 15;
            this.Menu.MinimumSize = new System.Drawing.Size(0, 0);
            this.Menu.ShowBorders = false;
            this.Menu.ShowCloseIcon = false;
            this.Menu.ShowIcon = true;
            this.Menu.ShowShadows = true;
            this.Menu.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Menu.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Menu.SuccessOptions.ActionBorderRadius = 1;
            this.Menu.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Menu.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Menu.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.Menu.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.Menu.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.Menu.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Menu.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.Menu.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.Menu.SuccessOptions.IconLeftMargin = 12;
            this.Menu.ViewsMargin = 7;
            this.Menu.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Menu.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Menu.WarningOptions.ActionBorderRadius = 1;
            this.Menu.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Menu.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Menu.WarningOptions.BackColor = System.Drawing.Color.White;
            this.Menu.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.Menu.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.Menu.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Menu.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.Menu.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.Menu.WarningOptions.IconLeftMargin = 12;
            this.Menu.ZoomCloseIcon = true;
            // 
            // MenuPrincipalGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 628);
            this.Controls.Add(this.gunaControlBox3);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbpMain);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipalGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipalGUI";
            this.Load += new System.EventHandler(this.MenuPrincipalGUI_Load);
            this.tbpMain.ResumeLayout(false);
            this.tbRegistros.ResumeLayout(false);
            this.tbProduccion.ResumeLayout(false);
            this.tbInsumos.ResumeLayout(false);
            this.tbVentas.ResumeLayout(false);
            this.tbMedida.ResumeLayout(false);
            this.tbCategorias.ResumeLayout(false);
            this.tbProveedores.ResumeLayout(false);
            this.tbPlantas.ResumeLayout(false);
            this.tbProductos.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private Bunifu.UI.WinForms.BunifuPanel pnlMenu;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl tbpMain;
        private MetroFramework.Controls.MetroTabPage tbRegistros;
        private MetroFramework.Controls.MetroTabPage tbProduccion;
        private MetroFramework.Controls.MetroTabPage tbInsumos;
        private MetroFramework.Controls.MetroTabPage tbVentas;
        private Bunifu.UI.WinForms.BunifuTextBox txtUsuario;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton3;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton2;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnProductos;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnProveedores;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnCategorias;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnMedidas;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnPlantas;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton9;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton1;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton10;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton11;
        private MetroFramework.Controls.MetroTabPage tbMedida;
        private MetroFramework.Controls.MetroTabPage tbCategorias;
        private MetroFramework.Controls.MetroTabPage tbProveedores;
        private MetroFramework.Controls.MetroTabPage tbPlantas;
        private MetroFramework.Controls.MetroTabPage tbProductos;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaButton gunaButton6;
        private Guna.UI.WinForms.GunaButton gunaButton7;
        private Guna.UI.WinForms.GunaButton gunaButton8;
        private Guna.UI.WinForms.GunaButton gunaButton9;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuLabel lblNombre;
        private Bunifu.UI.WinForms.BunifuSnackbar Menu;
    }
}