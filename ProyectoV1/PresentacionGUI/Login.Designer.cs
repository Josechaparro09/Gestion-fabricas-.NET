namespace PresentacionGUI
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txtUsuario = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtContra = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnIngresar = new Guna.UI.WinForms.GunaButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnCerrar = new Guna.UI.WinForms.GunaCircleButton();
            this.lblIniciarSesion = new Bunifu.UI.WinForms.BunifuLabel();
            this.BarraNotificacion = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "Users";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AcceptsReturn = false;
            this.txtUsuario.AcceptsTab = false;
            this.txtUsuario.AnimationSpeed = 200;
            this.txtUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUsuario.BackgroundImage")));
            this.txtUsuario.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtUsuario.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUsuario.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtUsuario.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtUsuario.BorderRadius = 5;
            this.txtUsuario.BorderThickness = 2;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.DefaultText = "";
            this.txtUsuario.FillColor = System.Drawing.Color.White;
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsuario.HideSelection = true;
            this.txtUsuario.IconLeft = null;
            this.txtUsuario.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.IconPadding = 10;
            this.txtUsuario.IconRight = null;
            this.txtUsuario.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(96, 225);
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
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.OnIdleState = stateProperties4;
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.PlaceholderText = "Ingresa tu usuario";
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(260, 51);
            this.txtUsuario.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.TextMarginBottom = 0;
            this.txtUsuario.TextMarginLeft = 3;
            this.txtUsuario.TextMarginTop = 0;
            this.txtUsuario.TextPlaceholder = "Ingresa tu usuario";
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.WordWrap = true;
            this.txtUsuario.TextChanged += new System.EventHandler(this.bunifuTextBox1_TextChanged_1);
            // 
            // txtContra
            // 
            this.txtContra.AcceptsReturn = false;
            this.txtContra.AcceptsTab = false;
            this.txtContra.AnimationSpeed = 200;
            this.txtContra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtContra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtContra.BackColor = System.Drawing.Color.White;
            this.txtContra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtContra.BackgroundImage")));
            this.txtContra.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtContra.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtContra.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtContra.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtContra.BorderRadius = 5;
            this.txtContra.BorderThickness = 2;
            this.txtContra.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtContra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContra.DefaultFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.DefaultText = "";
            this.txtContra.FillColor = System.Drawing.Color.White;
            this.txtContra.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtContra.HideSelection = true;
            this.txtContra.IconLeft = null;
            this.txtContra.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContra.IconPadding = 10;
            this.txtContra.IconRight = null;
            this.txtContra.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContra.Lines = new string[0];
            this.txtContra.Location = new System.Drawing.Point(96, 314);
            this.txtContra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContra.MaxLength = 32767;
            this.txtContra.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtContra.Modified = false;
            this.txtContra.Multiline = false;
            this.txtContra.Name = "txtContra";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtContra.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtContra.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtContra.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtContra.OnIdleState = stateProperties8;
            this.txtContra.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContra.PasswordChar = '\0';
            this.txtContra.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtContra.PlaceholderText = "Ingresa tu contraseña";
            this.txtContra.ReadOnly = false;
            this.txtContra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContra.SelectedText = "";
            this.txtContra.SelectionLength = 0;
            this.txtContra.SelectionStart = 0;
            this.txtContra.ShortcutsEnabled = true;
            this.txtContra.Size = new System.Drawing.Size(260, 51);
            this.txtContra.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtContra.TabIndex = 1;
            this.txtContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContra.TextMarginBottom = 0;
            this.txtContra.TextMarginLeft = 3;
            this.txtContra.TextMarginTop = 0;
            this.txtContra.TextPlaceholder = "Ingresa tu contraseña";
            this.txtContra.UseSystemPasswordChar = false;
            this.txtContra.WordWrap = true;
            this.txtContra.TextChange += new System.EventHandler(this.txtContra_TextChange);
            this.txtContra.TextChanged += new System.EventHandler(this.txtContra_TextChanged);
            this.txtContra.Enter += new System.EventHandler(this.txtContra_Enter);
            this.txtContra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtContra_MouseDown);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Animated = true;
            this.btnIngresar.AnimationHoverSpeed = 0.07F;
            this.btnIngresar.AnimationSpeed = 0.03F;
            this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnIngresar.BorderColor = System.Drawing.Color.Black;
            this.btnIngresar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIngresar.FocusedColor = System.Drawing.Color.Empty;
            this.btnIngresar.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Image = null;
            this.btnIngresar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnIngresar.Location = new System.Drawing.Point(146, 470);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnIngresar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIngresar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnIngresar.OnHoverImage = null;
            this.btnIngresar.OnPressedColor = System.Drawing.Color.Black;
            this.btnIngresar.Radius = 20;
            this.btnIngresar.Size = new System.Drawing.Size(160, 42);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIngresar.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AnimationHoverSpeed = 0.07F;
            this.btnCerrar.AnimationSpeed = 0.03F;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCerrar.BorderColor = System.Drawing.Color.Black;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnCerrar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = null;
            this.btnCerrar.ImageSize = new System.Drawing.Size(52, 52);
            this.btnCerrar.Location = new System.Drawing.Point(420, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCerrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCerrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCerrar.OnHoverImage = null;
            this.btnCerrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "x";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AllowParentOverrides = false;
            this.lblIniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIniciarSesion.AutoEllipsis = false;
            this.lblIniciarSesion.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblIniciarSesion.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.lblIniciarSesion.Location = new System.Drawing.Point(146, 119);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIniciarSesion.Size = new System.Drawing.Size(162, 42);
            this.lblIniciarSesion.TabIndex = 17;
            this.lblIniciarSesion.Text = "Iniciar sesion";
            this.lblIniciarSesion.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblIniciarSesion.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BarraNotificacion
            // 
            this.BarraNotificacion.AllowDragging = false;
            this.BarraNotificacion.AllowMultipleViews = true;
            this.BarraNotificacion.ClickToClose = true;
            this.BarraNotificacion.DoubleClickToClose = true;
            this.BarraNotificacion.DurationAfterIdle = 3000;
            this.BarraNotificacion.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BarraNotificacion.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BarraNotificacion.ErrorOptions.ActionBorderRadius = 1;
            this.BarraNotificacion.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.BarraNotificacion.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.BarraNotificacion.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.BarraNotificacion.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.BarraNotificacion.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.BarraNotificacion.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.BarraNotificacion.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.BarraNotificacion.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.BarraNotificacion.ErrorOptions.IconLeftMargin = 12;
            this.BarraNotificacion.FadeCloseIcon = false;
            this.BarraNotificacion.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.BarraNotificacion.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BarraNotificacion.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BarraNotificacion.InformationOptions.ActionBorderRadius = 1;
            this.BarraNotificacion.InformationOptions.ActionFont = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarraNotificacion.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.BarraNotificacion.InformationOptions.BackColor = System.Drawing.Color.White;
            this.BarraNotificacion.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.BarraNotificacion.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.BarraNotificacion.InformationOptions.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarraNotificacion.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.BarraNotificacion.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.BarraNotificacion.InformationOptions.IconLeftMargin = 12;
            this.BarraNotificacion.Margin = 10;
            this.BarraNotificacion.MaximumSize = new System.Drawing.Size(0, 0);
            this.BarraNotificacion.MaximumViews = 7;
            this.BarraNotificacion.MessageRightMargin = 15;
            this.BarraNotificacion.MinimumSize = new System.Drawing.Size(0, 0);
            this.BarraNotificacion.ShowBorders = false;
            this.BarraNotificacion.ShowCloseIcon = false;
            this.BarraNotificacion.ShowIcon = true;
            this.BarraNotificacion.ShowShadows = true;
            this.BarraNotificacion.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BarraNotificacion.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BarraNotificacion.SuccessOptions.ActionBorderRadius = 1;
            this.BarraNotificacion.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.BarraNotificacion.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.BarraNotificacion.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.BarraNotificacion.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.BarraNotificacion.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.BarraNotificacion.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.BarraNotificacion.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.BarraNotificacion.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.BarraNotificacion.SuccessOptions.IconLeftMargin = 12;
            this.BarraNotificacion.ViewsMargin = 7;
            this.BarraNotificacion.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BarraNotificacion.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BarraNotificacion.WarningOptions.ActionBorderRadius = 1;
            this.BarraNotificacion.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.BarraNotificacion.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.BarraNotificacion.WarningOptions.BackColor = System.Drawing.Color.White;
            this.BarraNotificacion.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.BarraNotificacion.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.BarraNotificacion.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.BarraNotificacion.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.BarraNotificacion.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.BarraNotificacion.WarningOptions.IconLeftMargin = 12;
            this.BarraNotificacion.ZoomCloseIcon = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 663);
            this.Controls.Add(this.lblIniciarSesion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private Bunifu.UI.WinForms.BunifuTextBox txtUsuario;
        private Bunifu.UI.WinForms.BunifuTextBox txtContra;
        private Guna.UI.WinForms.GunaButton btnIngresar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Guna.UI.WinForms.GunaCircleButton btnCerrar;
        private Bunifu.UI.WinForms.BunifuLabel lblIniciarSesion;
        private Bunifu.UI.WinForms.BunifuSnackbar BarraNotificacion;
    }
}

