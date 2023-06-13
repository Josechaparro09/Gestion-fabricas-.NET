namespace PresentacionGUI
{
    partial class VentasGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasGUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbpMain = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnVerVentas = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnNVenta = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.lblTotal = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel14 = new Bunifu.UI.WinForms.BunifuLabel();
            this.tbDv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.txtCantProducto = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel17 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cbxProd = new Guna.UI.WinForms.GunaComboBox();
            this.btnAddProd = new Guna.UI.WinForms.GunaButton();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.btnConfirmar = new Guna.UI.WinForms.GunaButton();
            this.Menu = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.btnAtras1 = new Guna.UI.WinForms.GunaButton();
            this.tbVentas = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVer = new System.Windows.Forms.DataGridViewImageColumn();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.tbVerVenta = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalVer = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbpMain.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDv)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVentas)).BeginInit();
            this.metroTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVerVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpMain
            // 
            this.tbpMain.Controls.Add(this.metroTabPage1);
            this.tbpMain.Controls.Add(this.metroTabPage2);
            this.tbpMain.Controls.Add(this.metroTabPage3);
            this.tbpMain.Controls.Add(this.metroTabPage4);
            this.tbpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpMain.Location = new System.Drawing.Point(0, 0);
            this.tbpMain.Name = "tbpMain";
            this.tbpMain.SelectedIndex = 0;
            this.tbpMain.Size = new System.Drawing.Size(823, 700);
            this.tbpMain.TabIndex = 0;
            this.tbpMain.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnVerVentas);
            this.metroTabPage1.Controls.Add(this.btnNVenta);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(815, 658);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "metroTabPage1";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btnVerVentas
            // 
            this.btnVerVentas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVerVentas.Animated = true;
            this.btnVerVentas.AnimationHoverSpeed = 0.07F;
            this.btnVerVentas.AnimationSpeed = 0.03F;
            this.btnVerVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVerVentas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnVerVentas.BorderColor = System.Drawing.Color.Black;
            this.btnVerVentas.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnVerVentas.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnVerVentas.CheckedForeColor = System.Drawing.Color.White;
            this.btnVerVentas.CheckedImage = global::PresentacionGUI.Properties.Resources.Producto;
            this.btnVerVentas.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnVerVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerVentas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVerVentas.FocusedColor = System.Drawing.Color.Empty;
            this.btnVerVentas.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVentas.ForeColor = System.Drawing.Color.White;
            this.btnVerVentas.Image = global::PresentacionGUI.Properties.Resources.Ver_ventas;
            this.btnVerVentas.ImageSize = new System.Drawing.Size(72, 72);
            this.btnVerVentas.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnVerVentas.Location = new System.Drawing.Point(444, 224);
            this.btnVerVentas.Name = "btnVerVentas";
            this.btnVerVentas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnVerVentas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVerVentas.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVerVentas.OnHoverImage = null;
            this.btnVerVentas.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnVerVentas.OnPressedColor = System.Drawing.Color.Black;
            this.btnVerVentas.Radius = 30;
            this.btnVerVentas.Size = new System.Drawing.Size(210, 210);
            this.btnVerVentas.TabIndex = 28;
            this.btnVerVentas.Text = "Ver ventas";
            this.btnVerVentas.Click += new System.EventHandler(this.btnVerVentas_Click);
            // 
            // btnNVenta
            // 
            this.btnNVenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNVenta.Animated = true;
            this.btnNVenta.AnimationHoverSpeed = 0.07F;
            this.btnNVenta.AnimationSpeed = 0.03F;
            this.btnNVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnNVenta.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnNVenta.BorderColor = System.Drawing.Color.Black;
            this.btnNVenta.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnNVenta.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnNVenta.CheckedForeColor = System.Drawing.Color.White;
            this.btnNVenta.CheckedImage = global::PresentacionGUI.Properties.Resources.Producto;
            this.btnNVenta.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnNVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNVenta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNVenta.FocusedColor = System.Drawing.Color.Empty;
            this.btnNVenta.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVenta.ForeColor = System.Drawing.Color.White;
            this.btnNVenta.Image = global::PresentacionGUI.Properties.Resources.Venta;
            this.btnNVenta.ImageSize = new System.Drawing.Size(72, 72);
            this.btnNVenta.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnNVenta.Location = new System.Drawing.Point(161, 224);
            this.btnNVenta.Name = "btnNVenta";
            this.btnNVenta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnNVenta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNVenta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNVenta.OnHoverImage = null;
            this.btnNVenta.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnNVenta.OnPressedColor = System.Drawing.Color.Black;
            this.btnNVenta.Radius = 30;
            this.btnNVenta.Size = new System.Drawing.Size(210, 210);
            this.btnNVenta.TabIndex = 27;
            this.btnNVenta.Text = "Nueva venta";
            this.btnNVenta.Click += new System.EventHandler(this.btnNVenta_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnAtras1);
            this.metroTabPage2.Controls.Add(this.btnConfirmar);
            this.metroTabPage2.Controls.Add(this.lblTotal);
            this.metroTabPage2.Controls.Add(this.bunifuLabel14);
            this.metroTabPage2.Controls.Add(this.tbDv);
            this.metroTabPage2.Controls.Add(this.txtCantProducto);
            this.metroTabPage2.Controls.Add(this.bunifuLabel17);
            this.metroTabPage2.Controls.Add(this.cbxProd);
            this.metroTabPage2.Controls.Add(this.btnAddProd);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(815, 658);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "metroTabPage2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            this.metroTabPage2.Enter += new System.EventHandler(this.metroTabPage2_Enter);
            // 
            // lblTotal
            // 
            this.lblTotal.AllowParentOverrides = false;
            this.lblTotal.AutoEllipsis = false;
            this.lblTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotal.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTotal.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.lblTotal.Location = new System.Drawing.Point(424, 575);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotal.Size = new System.Drawing.Size(64, 42);
            this.lblTotal.TabIndex = 64;
            this.lblTotal.Text = "0000";
            this.lblTotal.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotal.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel14
            // 
            this.bunifuLabel14.AllowParentOverrides = false;
            this.bunifuLabel14.AutoEllipsis = false;
            this.bunifuLabel14.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel14.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel14.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.bunifuLabel14.Location = new System.Drawing.Point(349, 575);
            this.bunifuLabel14.Name = "bunifuLabel14";
            this.bunifuLabel14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel14.Size = new System.Drawing.Size(69, 42);
            this.bunifuLabel14.TabIndex = 63;
            this.bunifuLabel14.Text = "Total: ";
            this.bunifuLabel14.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel14.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // tbDv
            // 
            this.tbDv.AllowCustomTheming = true;
            this.tbDv.AllowUserToAddRows = false;
            this.tbDv.AllowUserToDeleteRows = false;
            this.tbDv.AllowUserToResizeColumns = false;
            this.tbDv.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            this.tbDv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.tbDv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbDv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbDv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbDv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.tbDv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbDv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.Producto,
            this.PUnitario,
            this.Cantidad,
            this.Subtotal,
            this.btnEliminar});
            this.tbDv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tbDv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbDv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbDv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbDv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tbDv.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tbDv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbDv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbDv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tbDv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tbDv.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.tbDv.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tbDv.CurrentTheme.Name = null;
            this.tbDv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tbDv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbDv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbDv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbDv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbDv.DefaultCellStyle = dataGridViewCellStyle21;
            this.tbDv.EnableHeadersVisualStyles = false;
            this.tbDv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbDv.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbDv.HeaderBgColor = System.Drawing.Color.Empty;
            this.tbDv.HeaderForeColor = System.Drawing.Color.White;
            this.tbDv.Location = new System.Drawing.Point(8, 252);
            this.tbDv.Name = "tbDv";
            this.tbDv.ReadOnly = true;
            this.tbDv.RowHeadersVisible = false;
            this.tbDv.RowTemplate.Height = 40;
            this.tbDv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbDv.Size = new System.Drawing.Size(799, 270);
            this.tbDv.TabIndex = 62;
            this.tbDv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.tbDv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbDv_CellContentClick);
            // 
            // txtCantProducto
            // 
            this.txtCantProducto.AcceptsReturn = false;
            this.txtCantProducto.AcceptsTab = false;
            this.txtCantProducto.AnimationSpeed = 200;
            this.txtCantProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCantProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCantProducto.BackColor = System.Drawing.Color.White;
            this.txtCantProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCantProducto.BackgroundImage")));
            this.txtCantProducto.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtCantProducto.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCantProducto.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtCantProducto.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtCantProducto.BorderRadius = 5;
            this.txtCantProducto.BorderThickness = 2;
            this.txtCantProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCantProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantProducto.DefaultFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantProducto.DefaultText = "";
            this.txtCantProducto.FillColor = System.Drawing.Color.White;
            this.txtCantProducto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCantProducto.HideSelection = true;
            this.txtCantProducto.IconLeft = null;
            this.txtCantProducto.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantProducto.IconPadding = 10;
            this.txtCantProducto.IconRight = null;
            this.txtCantProducto.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantProducto.Lines = new string[0];
            this.txtCantProducto.Location = new System.Drawing.Point(256, 134);
            this.txtCantProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantProducto.MaxLength = 32767;
            this.txtCantProducto.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCantProducto.Modified = false;
            this.txtCantProducto.Multiline = false;
            this.txtCantProducto.Name = "txtCantProducto";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCantProducto.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCantProducto.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCantProducto.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.SystemColors.WindowFrame;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCantProducto.OnIdleState = stateProperties12;
            this.txtCantProducto.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantProducto.PasswordChar = '\0';
            this.txtCantProducto.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCantProducto.PlaceholderText = "Cantidad";
            this.txtCantProducto.ReadOnly = false;
            this.txtCantProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantProducto.SelectedText = "";
            this.txtCantProducto.SelectionLength = 0;
            this.txtCantProducto.SelectionStart = 0;
            this.txtCantProducto.ShortcutsEnabled = true;
            this.txtCantProducto.Size = new System.Drawing.Size(260, 51);
            this.txtCantProducto.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtCantProducto.TabIndex = 61;
            this.txtCantProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCantProducto.TextMarginBottom = 0;
            this.txtCantProducto.TextMarginLeft = 3;
            this.txtCantProducto.TextMarginTop = 0;
            this.txtCantProducto.TextPlaceholder = "Cantidad";
            this.txtCantProducto.UseSystemPasswordChar = false;
            this.txtCantProducto.WordWrap = true;
            // 
            // bunifuLabel17
            // 
            this.bunifuLabel17.AllowParentOverrides = false;
            this.bunifuLabel17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel17.AutoEllipsis = false;
            this.bunifuLabel17.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel17.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel17.Font = new System.Drawing.Font("Poppins", 11F);
            this.bunifuLabel17.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuLabel17.Location = new System.Drawing.Point(351, 38);
            this.bunifuLabel17.Name = "bunifuLabel17";
            this.bunifuLabel17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel17.Size = new System.Drawing.Size(69, 26);
            this.bunifuLabel17.TabIndex = 60;
            this.bunifuLabel17.Text = "Producto";
            this.bunifuLabel17.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel17.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cbxProd
            // 
            this.cbxProd.BackColor = System.Drawing.Color.Transparent;
            this.cbxProd.BaseColor = System.Drawing.Color.White;
            this.cbxProd.BorderColor = System.Drawing.Color.Silver;
            this.cbxProd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProd.FocusedColor = System.Drawing.Color.Empty;
            this.cbxProd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxProd.ForeColor = System.Drawing.Color.Black;
            this.cbxProd.FormattingEnabled = true;
            this.cbxProd.Location = new System.Drawing.Point(256, 86);
            this.cbxProd.Name = "cbxProd";
            this.cbxProd.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxProd.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxProd.Radius = 5;
            this.cbxProd.Size = new System.Drawing.Size(260, 26);
            this.cbxProd.TabIndex = 59;
            // 
            // btnAddProd
            // 
            this.btnAddProd.Animated = true;
            this.btnAddProd.AnimationHoverSpeed = 0.07F;
            this.btnAddProd.AnimationSpeed = 0.03F;
            this.btnAddProd.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAddProd.BorderColor = System.Drawing.Color.Black;
            this.btnAddProd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddProd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddProd.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.ForeColor = System.Drawing.Color.White;
            this.btnAddProd.Image = null;
            this.btnAddProd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddProd.Location = new System.Drawing.Point(572, 111);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAddProd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddProd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddProd.OnHoverImage = null;
            this.btnAddProd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddProd.Radius = 20;
            this.btnAddProd.Size = new System.Drawing.Size(109, 42);
            this.btnAddProd.TabIndex = 58;
            this.btnAddProd.Text = "Agregar";
            this.btnAddProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.gunaButton1);
            this.metroTabPage3.Controls.Add(this.bunifuLabel1);
            this.metroTabPage3.Controls.Add(this.tbVentas);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(815, 658);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "metroTabPage3";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            this.metroTabPage3.Enter += new System.EventHandler(this.metroTabPage3_Enter);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Animated = true;
            this.btnConfirmar.AnimationHoverSpeed = 0.07F;
            this.btnConfirmar.AnimationSpeed = 0.03F;
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnConfirmar.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirmar.FocusedColor = System.Drawing.Color.Empty;
            this.btnConfirmar.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Image = null;
            this.btnConfirmar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConfirmar.Location = new System.Drawing.Point(656, 575);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnConfirmar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConfirmar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConfirmar.OnHoverImage = null;
            this.btnConfirmar.OnPressedColor = System.Drawing.Color.Black;
            this.btnConfirmar.Radius = 20;
            this.btnConfirmar.Size = new System.Drawing.Size(109, 42);
            this.btnConfirmar.TabIndex = 65;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
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
            // btnAtras1
            // 
            this.btnAtras1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAtras1.Animated = true;
            this.btnAtras1.AnimationHoverSpeed = 0.07F;
            this.btnAtras1.AnimationSpeed = 0.03F;
            this.btnAtras1.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAtras1.BorderColor = System.Drawing.Color.Black;
            this.btnAtras1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAtras1.FocusedColor = System.Drawing.Color.Empty;
            this.btnAtras1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras1.ForeColor = System.Drawing.Color.White;
            this.btnAtras1.Image = global::PresentacionGUI.Properties.Resources.Atras;
            this.btnAtras1.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAtras1.Location = new System.Drawing.Point(756, 12);
            this.btnAtras1.Name = "btnAtras1";
            this.btnAtras1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnAtras1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAtras1.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAtras1.OnHoverImage = null;
            this.btnAtras1.OnPressedColor = System.Drawing.Color.Black;
            this.btnAtras1.Radius = 20;
            this.btnAtras1.Size = new System.Drawing.Size(51, 41);
            this.btnAtras1.TabIndex = 66;
            this.btnAtras1.TextOffsetX = 10;
            this.btnAtras1.Click += new System.EventHandler(this.btnAtras1_Click);
            // 
            // tbVentas
            // 
            this.tbVentas.AllowCustomTheming = true;
            this.tbVentas.AllowUserToAddRows = false;
            this.tbVentas.AllowUserToDeleteRows = false;
            this.tbVentas.AllowUserToResizeColumns = false;
            this.tbVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            this.tbVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.tbVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.tbVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FechaVenta,
            this.Total,
            this.btnVer});
            this.tbVentas.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tbVentas.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbVentas.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbVentas.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbVentas.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tbVentas.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tbVentas.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbVentas.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbVentas.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tbVentas.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tbVentas.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.tbVentas.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tbVentas.CurrentTheme.Name = null;
            this.tbVentas.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tbVentas.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbVentas.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbVentas.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbVentas.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbVentas.DefaultCellStyle = dataGridViewCellStyle24;
            this.tbVentas.EnableHeadersVisualStyles = false;
            this.tbVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbVentas.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbVentas.HeaderBgColor = System.Drawing.Color.Empty;
            this.tbVentas.HeaderForeColor = System.Drawing.Color.White;
            this.tbVentas.Location = new System.Drawing.Point(8, 91);
            this.tbVentas.Name = "tbVentas";
            this.tbVentas.ReadOnly = true;
            this.tbVentas.RowHeadersVisible = false;
            this.tbVentas.RowTemplate.Height = 40;
            this.tbVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbVentas.Size = new System.Drawing.Size(799, 270);
            this.tbVentas.TabIndex = 63;
            this.tbVentas.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.tbVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbVentas_CellContentClick);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(292, 27);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(221, 42);
            this.bunifuLabel1.TabIndex = 64;
            this.bunifuLabel1.Text = "Ventas realizadas";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaButton1.Animated = true;
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::PresentacionGUI.Properties.Resources.Atras;
            this.gunaButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton1.Location = new System.Drawing.Point(756, 14);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(51, 41);
            this.gunaButton1.TabIndex = 67;
            this.gunaButton1.TextOffsetX = 10;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // FechaVenta
            // 
            this.FechaVenta.HeaderText = "Fecha ";
            this.FechaVenta.Name = "FechaVenta";
            this.FechaVenta.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // btnVer
            // 
            this.btnVer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnVer.HeaderText = "";
            this.btnVer.Image = global::PresentacionGUI.Properties.Resources.Ver;
            this.btnVer.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnVer.Name = "btnVer";
            this.btnVer.ReadOnly = true;
            this.btnVer.Width = 5;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.gunaButton2);
            this.metroTabPage4.Controls.Add(this.lblTotalVer);
            this.metroTabPage4.Controls.Add(this.bunifuLabel3);
            this.metroTabPage4.Controls.Add(this.tbVerVenta);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(815, 658);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "metroTabPage4";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // tbVerVenta
            // 
            this.tbVerVenta.AllowCustomTheming = true;
            this.tbVerVenta.AllowUserToAddRows = false;
            this.tbVerVenta.AllowUserToDeleteRows = false;
            this.tbVerVenta.AllowUserToResizeColumns = false;
            this.tbVerVenta.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            this.tbVerVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.tbVerVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbVerVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbVerVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbVerVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbVerVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.tbVerVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbVerVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tbVerVenta.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tbVerVenta.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbVerVenta.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbVerVenta.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbVerVenta.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tbVerVenta.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tbVerVenta.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbVerVenta.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbVerVenta.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tbVerVenta.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tbVerVenta.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.tbVerVenta.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tbVerVenta.CurrentTheme.Name = null;
            this.tbVerVenta.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tbVerVenta.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbVerVenta.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbVerVenta.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbVerVenta.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbVerVenta.DefaultCellStyle = dataGridViewCellStyle27;
            this.tbVerVenta.EnableHeadersVisualStyles = false;
            this.tbVerVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbVerVenta.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbVerVenta.HeaderBgColor = System.Drawing.Color.Empty;
            this.tbVerVenta.HeaderForeColor = System.Drawing.Color.White;
            this.tbVerVenta.Location = new System.Drawing.Point(8, 109);
            this.tbVerVenta.Name = "tbVerVenta";
            this.tbVerVenta.ReadOnly = true;
            this.tbVerVenta.RowHeadersVisible = false;
            this.tbVerVenta.RowTemplate.Height = 40;
            this.tbVerVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbVerVenta.Size = new System.Drawing.Size(799, 413);
            this.tbVerVenta.TabIndex = 63;
            this.tbVerVenta.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ProdId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "PrecioUnitario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // lblTotalVer
            // 
            this.lblTotalVer.AllowParentOverrides = false;
            this.lblTotalVer.AutoEllipsis = false;
            this.lblTotalVer.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalVer.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTotalVer.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.lblTotalVer.Location = new System.Drawing.Point(411, 552);
            this.lblTotalVer.Name = "lblTotalVer";
            this.lblTotalVer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalVer.Size = new System.Drawing.Size(64, 42);
            this.lblTotalVer.TabIndex = 66;
            this.lblTotalVer.Text = "0000";
            this.lblTotalVer.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotalVer.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.bunifuLabel3.Location = new System.Drawing.Point(336, 552);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(69, 42);
            this.bunifuLabel3.TabIndex = 65;
            this.bunifuLabel3.Text = "Total: ";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // gunaButton2
            // 
            this.gunaButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaButton2.Animated = true;
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = global::PresentacionGUI.Properties.Resources.Atras;
            this.gunaButton2.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton2.Location = new System.Drawing.Point(742, 18);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 20;
            this.gunaButton2.Size = new System.Drawing.Size(51, 41);
            this.gunaButton2.TabIndex = 68;
            this.gunaButton2.TextOffsetX = 10;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // ProdId
            // 
            this.ProdId.HeaderText = "ProdId";
            this.ProdId.Name = "ProdId";
            this.ProdId.ReadOnly = true;
            this.ProdId.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // PUnitario
            // 
            this.PUnitario.HeaderText = "PrecioUnitario";
            this.PUnitario.Name = "PUnitario";
            this.PUnitario.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.Image = global::PresentacionGUI.Properties.Resources.cancel;
            this.btnEliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Width = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 47);
            this.panel1.TabIndex = 4;
            // 
            // VentasGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentasGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VentasGUI";
            this.tbpMain.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDv)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVentas)).EndInit();
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVerVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tbpMain;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnVerVentas;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnNVenta;
        private Bunifu.UI.WinForms.BunifuTextBox txtCantProducto;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel17;
        private Guna.UI.WinForms.GunaComboBox cbxProd;
        private Guna.UI.WinForms.GunaButton btnAddProd;
        private Bunifu.UI.WinForms.BunifuDataGridView tbDv;
        private Bunifu.UI.WinForms.BunifuLabel lblTotal;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel14;
        private Guna.UI.WinForms.GunaButton btnConfirmar;
        private Bunifu.UI.WinForms.BunifuSnackbar Menu;
        private Guna.UI.WinForms.GunaButton btnAtras1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDataGridView tbVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewImageColumn btnVer;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalVer;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuDataGridView tbVerVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewImageColumn btnEliminar;
        private System.Windows.Forms.Panel panel1;
    }
}