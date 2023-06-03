namespace PresentacionGUI
{
    partial class CategoriaGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriaGUI));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.tbpCag = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnAtras = new Guna.UI.WinForms.GunaButton();
            this.tbCag = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.IdCag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnELiminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnNuevaCag = new Guna.UI.WinForms.GunaButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnAtrasNew = new Guna.UI.WinForms.GunaButton();
            this.lblNuevaCag = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnIngresarCategoria = new Guna.UI.WinForms.GunaButton();
            this.txtNombreCategoria = new Bunifu.UI.WinForms.BunifuTextBox();
            this.MOCag = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.MObtnEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.MObtnEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbpCag.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCag)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.MOCag.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpCag
            // 
            this.tbpCag.Controls.Add(this.metroTabPage1);
            this.tbpCag.Controls.Add(this.metroTabPage2);
            this.tbpCag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpCag.Location = new System.Drawing.Point(0, 0);
            this.tbpCag.Name = "tbpCag";
            this.tbpCag.SelectedIndex = 0;
            this.tbpCag.Size = new System.Drawing.Size(823, 700);
            this.tbpCag.TabIndex = 0;
            this.tbpCag.UseSelectable = true;
            this.tbpCag.Enter += new System.EventHandler(this.tbpCag_Enter);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnAtras);
            this.metroTabPage1.Controls.Add(this.tbCag);
            this.metroTabPage1.Controls.Add(this.btnNuevaCag);
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
            this.metroTabPage1.Enter += new System.EventHandler(this.metroTabPage1_Enter);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAtras.Animated = true;
            this.btnAtras.AnimationHoverSpeed = 0.07F;
            this.btnAtras.AnimationSpeed = 0.03F;
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAtras.BorderColor = System.Drawing.Color.Black;
            this.btnAtras.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAtras.FocusedColor = System.Drawing.Color.Empty;
            this.btnAtras.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.Image = global::PresentacionGUI.Properties.Resources.Atras;
            this.btnAtras.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAtras.Location = new System.Drawing.Point(736, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnAtras.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAtras.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAtras.OnHoverImage = null;
            this.btnAtras.OnPressedColor = System.Drawing.Color.Black;
            this.btnAtras.Radius = 20;
            this.btnAtras.Size = new System.Drawing.Size(51, 41);
            this.btnAtras.TabIndex = 19;
            this.btnAtras.TextOffsetX = 10;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // tbCag
            // 
            this.tbCag.AllowCustomTheming = true;
            this.tbCag.AllowUserToAddRows = false;
            this.tbCag.AllowUserToDeleteRows = false;
            this.tbCag.AllowUserToResizeColumns = false;
            this.tbCag.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tbCag.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbCag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbCag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCag.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbCag.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbCag.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tbCag.ColumnHeadersHeight = 40;
            this.tbCag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tbCag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCag,
            this.NombreCag,
            this.btnEditar,
            this.btnELiminar});
            this.tbCag.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tbCag.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbCag.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbCag.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbCag.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tbCag.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tbCag.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbCag.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbCag.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tbCag.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tbCag.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.tbCag.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tbCag.CurrentTheme.Name = null;
            this.tbCag.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tbCag.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbCag.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbCag.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbCag.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbCag.DefaultCellStyle = dataGridViewCellStyle3;
            this.tbCag.EnableHeadersVisualStyles = false;
            this.tbCag.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbCag.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbCag.HeaderBgColor = System.Drawing.Color.Empty;
            this.tbCag.HeaderForeColor = System.Drawing.Color.White;
            this.tbCag.Location = new System.Drawing.Point(51, 155);
            this.tbCag.Name = "tbCag";
            this.tbCag.RowHeadersVisible = false;
            this.tbCag.RowTemplate.Height = 40;
            this.tbCag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbCag.Size = new System.Drawing.Size(712, 438);
            this.tbCag.TabIndex = 18;
            this.tbCag.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.tbCag.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbCag_CellContentClick);
            this.tbCag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbCag_MouseDown);
            // 
            // IdCag
            // 
            this.IdCag.HeaderText = "Id";
            this.IdCag.Name = "IdCag";
            this.IdCag.Visible = false;
            // 
            // NombreCag
            // 
            this.NombreCag.FillWeight = 112.2661F;
            this.NombreCag.HeaderText = "Nombre";
            this.NombreCag.Name = "NombreCag";
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnEditar.FillWeight = 36.61727F;
            this.btnEditar.HeaderText = "";
            this.btnEditar.Image = global::PresentacionGUI.Properties.Resources.edit;
            this.btnEditar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnEditar.Name = "btnEditar";
            // 
            // btnELiminar
            // 
            this.btnELiminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnELiminar.FillWeight = 31.45665F;
            this.btnELiminar.HeaderText = "";
            this.btnELiminar.Image = global::PresentacionGUI.Properties.Resources.cancel;
            this.btnELiminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnELiminar.Name = "btnELiminar";
            // 
            // btnNuevaCag
            // 
            this.btnNuevaCag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNuevaCag.Animated = true;
            this.btnNuevaCag.AnimationHoverSpeed = 0.07F;
            this.btnNuevaCag.AnimationSpeed = 0.03F;
            this.btnNuevaCag.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevaCag.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnNuevaCag.BorderColor = System.Drawing.Color.Black;
            this.btnNuevaCag.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNuevaCag.FocusedColor = System.Drawing.Color.Empty;
            this.btnNuevaCag.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCag.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCag.Image = global::PresentacionGUI.Properties.Resources.Registros;
            this.btnNuevaCag.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNuevaCag.Location = new System.Drawing.Point(299, 66);
            this.btnNuevaCag.Name = "btnNuevaCag";
            this.btnNuevaCag.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnNuevaCag.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNuevaCag.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNuevaCag.OnHoverImage = null;
            this.btnNuevaCag.OnPressedColor = System.Drawing.Color.Black;
            this.btnNuevaCag.Radius = 20;
            this.btnNuevaCag.Size = new System.Drawing.Size(234, 62);
            this.btnNuevaCag.TabIndex = 17;
            this.btnNuevaCag.Text = "Nueva categoria";
            this.btnNuevaCag.TextOffsetX = 10;
            this.btnNuevaCag.Click += new System.EventHandler(this.btnNuevaCag_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnAtrasNew);
            this.metroTabPage2.Controls.Add(this.lblNuevaCag);
            this.metroTabPage2.Controls.Add(this.btnIngresarCategoria);
            this.metroTabPage2.Controls.Add(this.txtNombreCategoria);
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
            // 
            // btnAtrasNew
            // 
            this.btnAtrasNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAtrasNew.Animated = true;
            this.btnAtrasNew.AnimationHoverSpeed = 0.07F;
            this.btnAtrasNew.AnimationSpeed = 0.03F;
            this.btnAtrasNew.BackColor = System.Drawing.Color.Transparent;
            this.btnAtrasNew.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAtrasNew.BorderColor = System.Drawing.Color.Black;
            this.btnAtrasNew.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAtrasNew.FocusedColor = System.Drawing.Color.Empty;
            this.btnAtrasNew.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrasNew.ForeColor = System.Drawing.Color.White;
            this.btnAtrasNew.Image = global::PresentacionGUI.Properties.Resources.Atras;
            this.btnAtrasNew.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAtrasNew.Location = new System.Drawing.Point(731, 16);
            this.btnAtrasNew.Name = "btnAtrasNew";
            this.btnAtrasNew.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnAtrasNew.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAtrasNew.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAtrasNew.OnHoverImage = null;
            this.btnAtrasNew.OnPressedColor = System.Drawing.Color.Black;
            this.btnAtrasNew.Radius = 20;
            this.btnAtrasNew.Size = new System.Drawing.Size(51, 41);
            this.btnAtrasNew.TabIndex = 27;
            this.btnAtrasNew.TextOffsetX = 10;
            this.btnAtrasNew.Click += new System.EventHandler(this.btnAtrasNew_Click);
            // 
            // lblNuevaCag
            // 
            this.lblNuevaCag.AllowParentOverrides = false;
            this.lblNuevaCag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNuevaCag.AutoEllipsis = false;
            this.lblNuevaCag.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNuevaCag.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNuevaCag.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaCag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.lblNuevaCag.Location = new System.Drawing.Point(303, 205);
            this.lblNuevaCag.Name = "lblNuevaCag";
            this.lblNuevaCag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNuevaCag.Size = new System.Drawing.Size(208, 42);
            this.lblNuevaCag.TabIndex = 26;
            this.lblNuevaCag.Text = "Nueva Categoria";
            this.lblNuevaCag.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNuevaCag.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnIngresarCategoria
            // 
            this.btnIngresarCategoria.Animated = true;
            this.btnIngresarCategoria.AnimationHoverSpeed = 0.07F;
            this.btnIngresarCategoria.AnimationSpeed = 0.03F;
            this.btnIngresarCategoria.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnIngresarCategoria.BorderColor = System.Drawing.Color.Black;
            this.btnIngresarCategoria.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIngresarCategoria.FocusedColor = System.Drawing.Color.Empty;
            this.btnIngresarCategoria.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnIngresarCategoria.Image = null;
            this.btnIngresarCategoria.ImageSize = new System.Drawing.Size(20, 20);
            this.btnIngresarCategoria.Location = new System.Drawing.Point(327, 411);
            this.btnIngresarCategoria.Name = "btnIngresarCategoria";
            this.btnIngresarCategoria.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnIngresarCategoria.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIngresarCategoria.OnHoverForeColor = System.Drawing.Color.White;
            this.btnIngresarCategoria.OnHoverImage = null;
            this.btnIngresarCategoria.OnPressedColor = System.Drawing.Color.Black;
            this.btnIngresarCategoria.Size = new System.Drawing.Size(160, 42);
            this.btnIngresarCategoria.TabIndex = 25;
            this.btnIngresarCategoria.Text = "Ingresar";
            this.btnIngresarCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIngresarCategoria.Click += new System.EventHandler(this.btnIngresarCategoria_Click);
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.AcceptsReturn = false;
            this.txtNombreCategoria.AcceptsTab = false;
            this.txtNombreCategoria.AnimationSpeed = 200;
            this.txtNombreCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombreCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombreCategoria.BackColor = System.Drawing.Color.White;
            this.txtNombreCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNombreCategoria.BackgroundImage")));
            this.txtNombreCategoria.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtNombreCategoria.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNombreCategoria.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtNombreCategoria.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtNombreCategoria.BorderRadius = 5;
            this.txtNombreCategoria.BorderThickness = 2;
            this.txtNombreCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCategoria.DefaultFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCategoria.DefaultText = "";
            this.txtNombreCategoria.FillColor = System.Drawing.Color.White;
            this.txtNombreCategoria.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombreCategoria.HideSelection = true;
            this.txtNombreCategoria.IconLeft = null;
            this.txtNombreCategoria.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCategoria.IconPadding = 10;
            this.txtNombreCategoria.IconRight = null;
            this.txtNombreCategoria.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCategoria.Lines = new string[0];
            this.txtNombreCategoria.Location = new System.Drawing.Point(277, 291);
            this.txtNombreCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreCategoria.MaxLength = 32767;
            this.txtNombreCategoria.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNombreCategoria.Modified = false;
            this.txtNombreCategoria.Multiline = false;
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombreCategoria.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNombreCategoria.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombreCategoria.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombreCategoria.OnIdleState = stateProperties4;
            this.txtNombreCategoria.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreCategoria.PasswordChar = '\0';
            this.txtNombreCategoria.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNombreCategoria.PlaceholderText = "Nombre";
            this.txtNombreCategoria.ReadOnly = false;
            this.txtNombreCategoria.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreCategoria.SelectedText = "";
            this.txtNombreCategoria.SelectionLength = 0;
            this.txtNombreCategoria.SelectionStart = 0;
            this.txtNombreCategoria.ShortcutsEnabled = true;
            this.txtNombreCategoria.Size = new System.Drawing.Size(260, 51);
            this.txtNombreCategoria.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtNombreCategoria.TabIndex = 24;
            this.txtNombreCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreCategoria.TextMarginBottom = 0;
            this.txtNombreCategoria.TextMarginLeft = 3;
            this.txtNombreCategoria.TextMarginTop = 0;
            this.txtNombreCategoria.TextPlaceholder = "Nombre";
            this.txtNombreCategoria.UseSystemPasswordChar = false;
            this.txtNombreCategoria.WordWrap = true;
            // 
            // MOCag
            // 
            this.MOCag.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MOCag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MObtnEditar,
            this.MObtnEliminar});
            this.MOCag.Name = "MenuOpciones";
            this.MOCag.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.MOCag.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.MOCag.RenderStyle.ColorTable = null;
            this.MOCag.RenderStyle.RoundedEdges = true;
            this.MOCag.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.MOCag.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MOCag.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MOCag.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.MOCag.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.MOCag.Size = new System.Drawing.Size(148, 68);
            // 
            // MObtnEditar
            // 
            this.MObtnEditar.Image = global::PresentacionGUI.Properties.Resources.edit;
            this.MObtnEditar.Name = "MObtnEditar";
            this.MObtnEditar.Size = new System.Drawing.Size(147, 32);
            this.MObtnEditar.Text = "Editar";
            this.MObtnEditar.Click += new System.EventHandler(this.MObtnEditar_Click);
            // 
            // MObtnEliminar
            // 
            this.MObtnEliminar.Image = global::PresentacionGUI.Properties.Resources.cancel1;
            this.MObtnEliminar.Name = "MObtnEliminar";
            this.MObtnEliminar.Size = new System.Drawing.Size(147, 32);
            this.MObtnEliminar.Text = "Eliminar";
            this.MObtnEliminar.Click += new System.EventHandler(this.MObtnEliminar_Click);
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.FillWeight = 36.61727F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::PresentacionGUI.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn2.FillWeight = 31.45665F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::PresentacionGUI.Properties.Resources.cancel;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 44);
            this.panel1.TabIndex = 2;
            // 
            // CategoriaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbpCag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoriaGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CategoriaGUI";
            this.tbpCag.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbCag)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.MOCag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tbpCag;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private Bunifu.UI.WinForms.BunifuDataGridView tbCag;
        private Guna.UI.WinForms.GunaButton btnNuevaCag;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private Guna.UI.WinForms.GunaButton btnAtras;
        private Guna.UI.WinForms.GunaButton btnAtrasNew;
        private Bunifu.UI.WinForms.BunifuLabel lblNuevaCag;
        private Guna.UI.WinForms.GunaButton btnIngresarCategoria;
        private Bunifu.UI.WinForms.BunifuTextBox txtNombreCategoria;
        private Guna.UI.WinForms.GunaContextMenuStrip MOCag;
        private System.Windows.Forms.ToolStripMenuItem MObtnEditar;
        private System.Windows.Forms.ToolStripMenuItem MObtnEliminar;
        private Bunifu.UI.WinForms.BunifuSnackbar Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCag;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCag;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnELiminar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panel1;
    }
}