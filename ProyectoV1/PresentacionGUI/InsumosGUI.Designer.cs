﻿namespace PresentacionGUI
{
    partial class InsumosGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsumosGUI));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.tbpMain = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnAtrasMain = new Guna.UI.WinForms.GunaButton();
            this.gunaAdvenceTileButton9 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaAdvenceTileButton1 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnAtras = new Guna.UI.WinForms.GunaButton();
            this.tbMPrima = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.IdMprima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FCompraInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FExpiracionMPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMedMPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMedMPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProvMPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProvMprima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.MOInsumos = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.MObtnEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.MObtnEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuLabel13 = new Bunifu.UI.WinForms.BunifuLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.btnAtrasNew = new Guna.UI.WinForms.GunaButton();
            this.bunifuLabel12 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel9 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cbxProveedorInsumo = new Guna.UI.WinForms.GunaComboBox();
            this.bunifuLabel10 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cbxMedidaInsumo = new Guna.UI.WinForms.GunaComboBox();
            this.lblNuevoInsumo = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnIngresarInsumo = new Guna.UI.WinForms.GunaButton();
            this.dpFExpiracionInsumo = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.txtNombreInsumo = new Bunifu.UI.WinForms.BunifuTextBox();
            this.Menu = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.tbpMain.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMPrima)).BeginInit();
            this.MOInsumos.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpMain
            // 
            this.tbpMain.Controls.Add(this.metroTabPage1);
            this.tbpMain.Controls.Add(this.metroTabPage2);
            this.tbpMain.Controls.Add(this.metroTabPage3);
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
            this.metroTabPage1.Controls.Add(this.btnAtrasMain);
            this.metroTabPage1.Controls.Add(this.gunaAdvenceTileButton9);
            this.metroTabPage1.Controls.Add(this.gunaAdvenceTileButton1);
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
            // btnAtrasMain
            // 
            this.btnAtrasMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAtrasMain.Animated = true;
            this.btnAtrasMain.AnimationHoverSpeed = 0.07F;
            this.btnAtrasMain.AnimationSpeed = 0.03F;
            this.btnAtrasMain.BackColor = System.Drawing.Color.Transparent;
            this.btnAtrasMain.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAtrasMain.BorderColor = System.Drawing.Color.Black;
            this.btnAtrasMain.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAtrasMain.FocusedColor = System.Drawing.Color.Empty;
            this.btnAtrasMain.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrasMain.ForeColor = System.Drawing.Color.White;
            this.btnAtrasMain.Image = global::PresentacionGUI.Properties.Resources.Atras;
            this.btnAtrasMain.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAtrasMain.Location = new System.Drawing.Point(756, 12);
            this.btnAtrasMain.Name = "btnAtrasMain";
            this.btnAtrasMain.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnAtrasMain.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAtrasMain.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAtrasMain.OnHoverImage = null;
            this.btnAtrasMain.OnPressedColor = System.Drawing.Color.Black;
            this.btnAtrasMain.Radius = 20;
            this.btnAtrasMain.Size = new System.Drawing.Size(51, 41);
            this.btnAtrasMain.TabIndex = 31;
            this.btnAtrasMain.TextOffsetX = 10;
            this.btnAtrasMain.Click += new System.EventHandler(this.btnAtrasMain_Click);
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
            this.gunaAdvenceTileButton9.Location = new System.Drawing.Point(444, 224);
            this.gunaAdvenceTileButton9.Name = "gunaAdvenceTileButton9";
            this.gunaAdvenceTileButton9.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.gunaAdvenceTileButton9.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton9.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton9.OnHoverImage = null;
            this.gunaAdvenceTileButton9.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton9.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton9.Radius = 30;
            this.gunaAdvenceTileButton9.Size = new System.Drawing.Size(210, 210);
            this.gunaAdvenceTileButton9.TabIndex = 16;
            this.gunaAdvenceTileButton9.Text = "Ver insumos";
            this.gunaAdvenceTileButton9.Click += new System.EventHandler(this.gunaAdvenceTileButton9_Click);
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
            this.gunaAdvenceTileButton1.Location = new System.Drawing.Point(160, 224);
            this.gunaAdvenceTileButton1.Name = "gunaAdvenceTileButton1";
            this.gunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.gunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.OnHoverImage = null;
            this.gunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.Radius = 30;
            this.gunaAdvenceTileButton1.Size = new System.Drawing.Size(210, 210);
            this.gunaAdvenceTileButton1.TabIndex = 15;
            this.gunaAdvenceTileButton1.Text = "Agregar insumo";
            this.gunaAdvenceTileButton1.Click += new System.EventHandler(this.gunaAdvenceTileButton1_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnAtras);
            this.metroTabPage2.Controls.Add(this.tbMPrima);
            this.metroTabPage2.Controls.Add(this.bunifuLabel13);
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
            this.btnAtras.Location = new System.Drawing.Point(748, 9);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnAtras.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAtras.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAtras.OnHoverImage = null;
            this.btnAtras.OnPressedColor = System.Drawing.Color.Black;
            this.btnAtras.Radius = 20;
            this.btnAtras.Size = new System.Drawing.Size(51, 41);
            this.btnAtras.TabIndex = 42;
            this.btnAtras.TextOffsetX = 10;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // tbMPrima
            // 
            this.tbMPrima.AllowCustomTheming = true;
            this.tbMPrima.AllowUserToAddRows = false;
            this.tbMPrima.AllowUserToDeleteRows = false;
            this.tbMPrima.AllowUserToResizeColumns = false;
            this.tbMPrima.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tbMPrima.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbMPrima.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbMPrima.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMPrima.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbMPrima.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbMPrima.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tbMPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbMPrima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMprima,
            this.NombreMPrima,
            this.FCompraInsumo,
            this.FExpiracionMPrima,
            this.IdMedMPrima,
            this.NombreMedMPrima,
            this.IdProvMPrima,
            this.NombreProvMprima,
            this.btnEditar,
            this.btnEliminar});
            this.tbMPrima.ContextMenuStrip = this.MOInsumos;
            this.tbMPrima.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tbMPrima.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbMPrima.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbMPrima.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbMPrima.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tbMPrima.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tbMPrima.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbMPrima.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbMPrima.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tbMPrima.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tbMPrima.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.tbMPrima.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tbMPrima.CurrentTheme.Name = null;
            this.tbMPrima.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tbMPrima.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbMPrima.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbMPrima.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbMPrima.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbMPrima.DefaultCellStyle = dataGridViewCellStyle3;
            this.tbMPrima.EnableHeadersVisualStyles = false;
            this.tbMPrima.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbMPrima.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbMPrima.HeaderBgColor = System.Drawing.Color.Empty;
            this.tbMPrima.HeaderForeColor = System.Drawing.Color.White;
            this.tbMPrima.Location = new System.Drawing.Point(15, 67);
            this.tbMPrima.Name = "tbMPrima";
            this.tbMPrima.ReadOnly = true;
            this.tbMPrima.RowHeadersVisible = false;
            this.tbMPrima.RowTemplate.Height = 40;
            this.tbMPrima.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbMPrima.Size = new System.Drawing.Size(784, 569);
            this.tbMPrima.TabIndex = 40;
            this.tbMPrima.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.tbMPrima.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbMPrima_CellContentClick);
            this.tbMPrima.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbMPrima_MouseDown);
            // 
            // IdMprima
            // 
            this.IdMprima.HeaderText = "Id";
            this.IdMprima.Name = "IdMprima";
            this.IdMprima.ReadOnly = true;
            this.IdMprima.Visible = false;
            // 
            // NombreMPrima
            // 
            this.NombreMPrima.HeaderText = "Nombre";
            this.NombreMPrima.Name = "NombreMPrima";
            this.NombreMPrima.ReadOnly = true;
            // 
            // FCompraInsumo
            // 
            this.FCompraInsumo.HeaderText = "Fecha de Compra";
            this.FCompraInsumo.Name = "FCompraInsumo";
            this.FCompraInsumo.ReadOnly = true;
            this.FCompraInsumo.Visible = false;
            // 
            // FExpiracionMPrima
            // 
            this.FExpiracionMPrima.HeaderText = "Fecha de expiracion";
            this.FExpiracionMPrima.Name = "FExpiracionMPrima";
            this.FExpiracionMPrima.ReadOnly = true;
            // 
            // IdMedMPrima
            // 
            this.IdMedMPrima.HeaderText = "Id Medida";
            this.IdMedMPrima.Name = "IdMedMPrima";
            this.IdMedMPrima.ReadOnly = true;
            this.IdMedMPrima.Visible = false;
            // 
            // NombreMedMPrima
            // 
            this.NombreMedMPrima.HeaderText = "Medida";
            this.NombreMedMPrima.Name = "NombreMedMPrima";
            this.NombreMedMPrima.ReadOnly = true;
            // 
            // IdProvMPrima
            // 
            this.IdProvMPrima.HeaderText = "Id Proveedor";
            this.IdProvMPrima.Name = "IdProvMPrima";
            this.IdProvMPrima.ReadOnly = true;
            this.IdProvMPrima.Visible = false;
            // 
            // NombreProvMprima
            // 
            this.NombreProvMprima.HeaderText = "Proveedor";
            this.NombreProvMprima.Name = "NombreProvMprima";
            this.NombreProvMprima.ReadOnly = true;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnEditar.HeaderText = "";
            this.btnEditar.Image = global::PresentacionGUI.Properties.Resources.edit;
            this.btnEditar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Width = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.Image = global::PresentacionGUI.Properties.Resources.cancel1;
            this.btnEliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Width = 5;
            // 
            // MOInsumos
            // 
            this.MOInsumos.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MOInsumos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MObtnEditar,
            this.MObtnEliminar});
            this.MOInsumos.Name = "MenuOpciones";
            this.MOInsumos.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.MOInsumos.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.MOInsumos.RenderStyle.ColorTable = null;
            this.MOInsumos.RenderStyle.RoundedEdges = true;
            this.MOInsumos.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.MOInsumos.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MOInsumos.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MOInsumos.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.MOInsumos.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.MOInsumos.Size = new System.Drawing.Size(148, 68);
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
            // bunifuLabel13
            // 
            this.bunifuLabel13.AllowParentOverrides = false;
            this.bunifuLabel13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel13.AutoEllipsis = false;
            this.bunifuLabel13.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel13.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel13.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.bunifuLabel13.Location = new System.Drawing.Point(354, 23);
            this.bunifuLabel13.Name = "bunifuLabel13";
            this.bunifuLabel13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel13.Size = new System.Drawing.Size(105, 42);
            this.bunifuLabel13.TabIndex = 41;
            this.bunifuLabel13.Text = "Insumos";
            this.bunifuLabel13.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel13.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.btnAtrasNew);
            this.metroTabPage3.Controls.Add(this.bunifuLabel12);
            this.metroTabPage3.Controls.Add(this.bunifuLabel9);
            this.metroTabPage3.Controls.Add(this.cbxProveedorInsumo);
            this.metroTabPage3.Controls.Add(this.bunifuLabel10);
            this.metroTabPage3.Controls.Add(this.cbxMedidaInsumo);
            this.metroTabPage3.Controls.Add(this.lblNuevoInsumo);
            this.metroTabPage3.Controls.Add(this.btnIngresarInsumo);
            this.metroTabPage3.Controls.Add(this.dpFExpiracionInsumo);
            this.metroTabPage3.Controls.Add(this.txtNombreInsumo);
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
            this.btnAtrasNew.Location = new System.Drawing.Point(756, 12);
            this.btnAtrasNew.Name = "btnAtrasNew";
            this.btnAtrasNew.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnAtrasNew.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAtrasNew.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAtrasNew.OnHoverImage = null;
            this.btnAtrasNew.OnPressedColor = System.Drawing.Color.Black;
            this.btnAtrasNew.Radius = 20;
            this.btnAtrasNew.Size = new System.Drawing.Size(51, 41);
            this.btnAtrasNew.TabIndex = 54;
            this.btnAtrasNew.TextOffsetX = 10;
            this.btnAtrasNew.Click += new System.EventHandler(this.btnAtrasNew_Click);
            // 
            // bunifuLabel12
            // 
            this.bunifuLabel12.AllowParentOverrides = false;
            this.bunifuLabel12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel12.AutoEllipsis = false;
            this.bunifuLabel12.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel12.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel12.Font = new System.Drawing.Font("Poppins", 11F);
            this.bunifuLabel12.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuLabel12.Location = new System.Drawing.Point(331, 407);
            this.bunifuLabel12.Name = "bunifuLabel12";
            this.bunifuLabel12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel12.Size = new System.Drawing.Size(152, 26);
            this.bunifuLabel12.TabIndex = 53;
            this.bunifuLabel12.Text = "Fecha de expiracion";
            this.bunifuLabel12.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel12.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel9
            // 
            this.bunifuLabel9.AllowParentOverrides = false;
            this.bunifuLabel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel9.AutoEllipsis = false;
            this.bunifuLabel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel9.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel9.Font = new System.Drawing.Font("Poppins", 11F);
            this.bunifuLabel9.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuLabel9.Location = new System.Drawing.Point(369, 315);
            this.bunifuLabel9.Name = "bunifuLabel9";
            this.bunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel9.Size = new System.Drawing.Size(77, 26);
            this.bunifuLabel9.TabIndex = 51;
            this.bunifuLabel9.Text = "Proveedor";
            this.bunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cbxProveedorInsumo
            // 
            this.cbxProveedorInsumo.BackColor = System.Drawing.Color.Transparent;
            this.cbxProveedorInsumo.BaseColor = System.Drawing.Color.White;
            this.cbxProveedorInsumo.BorderColor = System.Drawing.Color.Silver;
            this.cbxProveedorInsumo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxProveedorInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProveedorInsumo.FocusedColor = System.Drawing.Color.Empty;
            this.cbxProveedorInsumo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxProveedorInsumo.ForeColor = System.Drawing.Color.Black;
            this.cbxProveedorInsumo.FormattingEnabled = true;
            this.cbxProveedorInsumo.Location = new System.Drawing.Point(277, 361);
            this.cbxProveedorInsumo.Name = "cbxProveedorInsumo";
            this.cbxProveedorInsumo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxProveedorInsumo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxProveedorInsumo.Radius = 5;
            this.cbxProveedorInsumo.Size = new System.Drawing.Size(260, 26);
            this.cbxProveedorInsumo.TabIndex = 50;
            // 
            // bunifuLabel10
            // 
            this.bunifuLabel10.AllowParentOverrides = false;
            this.bunifuLabel10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel10.AutoEllipsis = false;
            this.bunifuLabel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel10.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel10.Font = new System.Drawing.Font("Poppins", 11F);
            this.bunifuLabel10.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuLabel10.Location = new System.Drawing.Point(379, 223);
            this.bunifuLabel10.Name = "bunifuLabel10";
            this.bunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel10.Size = new System.Drawing.Size(56, 26);
            this.bunifuLabel10.TabIndex = 49;
            this.bunifuLabel10.Text = "Medida";
            this.bunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cbxMedidaInsumo
            // 
            this.cbxMedidaInsumo.BackColor = System.Drawing.Color.Transparent;
            this.cbxMedidaInsumo.BaseColor = System.Drawing.Color.White;
            this.cbxMedidaInsumo.BorderColor = System.Drawing.Color.Silver;
            this.cbxMedidaInsumo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMedidaInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMedidaInsumo.FocusedColor = System.Drawing.Color.Empty;
            this.cbxMedidaInsumo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxMedidaInsumo.ForeColor = System.Drawing.Color.Black;
            this.cbxMedidaInsumo.FormattingEnabled = true;
            this.cbxMedidaInsumo.Location = new System.Drawing.Point(277, 269);
            this.cbxMedidaInsumo.Name = "cbxMedidaInsumo";
            this.cbxMedidaInsumo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxMedidaInsumo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxMedidaInsumo.Radius = 5;
            this.cbxMedidaInsumo.Size = new System.Drawing.Size(260, 26);
            this.cbxMedidaInsumo.TabIndex = 48;
            // 
            // lblNuevoInsumo
            // 
            this.lblNuevoInsumo.AllowParentOverrides = false;
            this.lblNuevoInsumo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNuevoInsumo.AutoEllipsis = false;
            this.lblNuevoInsumo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNuevoInsumo.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNuevoInsumo.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.lblNuevoInsumo.Location = new System.Drawing.Point(319, 90);
            this.lblNuevoInsumo.Name = "lblNuevoInsumo";
            this.lblNuevoInsumo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNuevoInsumo.Size = new System.Drawing.Size(176, 42);
            this.lblNuevoInsumo.TabIndex = 47;
            this.lblNuevoInsumo.Text = "Nuevo insumo";
            this.lblNuevoInsumo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNuevoInsumo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnIngresarInsumo
            // 
            this.btnIngresarInsumo.Animated = true;
            this.btnIngresarInsumo.AnimationHoverSpeed = 0.07F;
            this.btnIngresarInsumo.AnimationSpeed = 0.03F;
            this.btnIngresarInsumo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnIngresarInsumo.BorderColor = System.Drawing.Color.Black;
            this.btnIngresarInsumo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIngresarInsumo.FocusedColor = System.Drawing.Color.Empty;
            this.btnIngresarInsumo.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarInsumo.ForeColor = System.Drawing.Color.White;
            this.btnIngresarInsumo.Image = null;
            this.btnIngresarInsumo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnIngresarInsumo.Location = new System.Drawing.Point(331, 526);
            this.btnIngresarInsumo.Name = "btnIngresarInsumo";
            this.btnIngresarInsumo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnIngresarInsumo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIngresarInsumo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnIngresarInsumo.OnHoverImage = null;
            this.btnIngresarInsumo.OnPressedColor = System.Drawing.Color.Black;
            this.btnIngresarInsumo.Size = new System.Drawing.Size(160, 42);
            this.btnIngresarInsumo.TabIndex = 46;
            this.btnIngresarInsumo.Text = "Ingresar";
            this.btnIngresarInsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIngresarInsumo.Click += new System.EventHandler(this.btnIngresarInsumo_Click);
            // 
            // dpFExpiracionInsumo
            // 
            this.dpFExpiracionInsumo.BackColor = System.Drawing.Color.Transparent;
            this.dpFExpiracionInsumo.BorderRadius = 5;
            this.dpFExpiracionInsumo.CalendarFont = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFExpiracionInsumo.Color = System.Drawing.Color.Silver;
            this.dpFExpiracionInsumo.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.dpFExpiracionInsumo.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dpFExpiracionInsumo.DisabledColor = System.Drawing.Color.Gray;
            this.dpFExpiracionInsumo.DisplayWeekNumbers = false;
            this.dpFExpiracionInsumo.DPHeight = 0;
            this.dpFExpiracionInsumo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dpFExpiracionInsumo.FillDatePicker = false;
            this.dpFExpiracionInsumo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFExpiracionInsumo.ForeColor = System.Drawing.Color.Black;
            this.dpFExpiracionInsumo.Icon = ((System.Drawing.Image)(resources.GetObject("dpFExpiracionInsumo.Icon")));
            this.dpFExpiracionInsumo.IconColor = System.Drawing.Color.Gray;
            this.dpFExpiracionInsumo.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dpFExpiracionInsumo.LeftTextMargin = 5;
            this.dpFExpiracionInsumo.Location = new System.Drawing.Point(277, 453);
            this.dpFExpiracionInsumo.MinimumSize = new System.Drawing.Size(4, 32);
            this.dpFExpiracionInsumo.Name = "dpFExpiracionInsumo";
            this.dpFExpiracionInsumo.Size = new System.Drawing.Size(260, 32);
            this.dpFExpiracionInsumo.TabIndex = 52;
            // 
            // txtNombreInsumo
            // 
            this.txtNombreInsumo.AcceptsReturn = false;
            this.txtNombreInsumo.AcceptsTab = false;
            this.txtNombreInsumo.AnimationSpeed = 200;
            this.txtNombreInsumo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombreInsumo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombreInsumo.BackColor = System.Drawing.Color.White;
            this.txtNombreInsumo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNombreInsumo.BackgroundImage")));
            this.txtNombreInsumo.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtNombreInsumo.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNombreInsumo.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtNombreInsumo.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtNombreInsumo.BorderRadius = 5;
            this.txtNombreInsumo.BorderThickness = 2;
            this.txtNombreInsumo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreInsumo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreInsumo.DefaultFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreInsumo.DefaultText = "";
            this.txtNombreInsumo.FillColor = System.Drawing.Color.White;
            this.txtNombreInsumo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombreInsumo.HideSelection = true;
            this.txtNombreInsumo.IconLeft = null;
            this.txtNombreInsumo.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreInsumo.IconPadding = 10;
            this.txtNombreInsumo.IconRight = null;
            this.txtNombreInsumo.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreInsumo.Lines = new string[0];
            this.txtNombreInsumo.Location = new System.Drawing.Point(277, 152);
            this.txtNombreInsumo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreInsumo.MaxLength = 32767;
            this.txtNombreInsumo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNombreInsumo.Modified = false;
            this.txtNombreInsumo.Multiline = false;
            this.txtNombreInsumo.Name = "txtNombreInsumo";
            stateProperties17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombreInsumo.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNombreInsumo.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombreInsumo.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.SystemColors.WindowFrame;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombreInsumo.OnIdleState = stateProperties20;
            this.txtNombreInsumo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreInsumo.PasswordChar = '\0';
            this.txtNombreInsumo.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNombreInsumo.PlaceholderText = "Nombre";
            this.txtNombreInsumo.ReadOnly = false;
            this.txtNombreInsumo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreInsumo.SelectedText = "";
            this.txtNombreInsumo.SelectionLength = 0;
            this.txtNombreInsumo.SelectionStart = 0;
            this.txtNombreInsumo.ShortcutsEnabled = true;
            this.txtNombreInsumo.Size = new System.Drawing.Size(260, 51);
            this.txtNombreInsumo.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtNombreInsumo.TabIndex = 45;
            this.txtNombreInsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreInsumo.TextMarginBottom = 0;
            this.txtNombreInsumo.TextMarginLeft = 3;
            this.txtNombreInsumo.TextMarginTop = 0;
            this.txtNombreInsumo.TextPlaceholder = "Nombre";
            this.txtNombreInsumo.UseSystemPasswordChar = false;
            this.txtNombreInsumo.WordWrap = true;
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
            // InsumosGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 700);
            this.Controls.Add(this.tbpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsumosGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "InsumosGUI";
            this.tbpMain.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMPrima)).EndInit();
            this.MOInsumos.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tbpMain;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private Bunifu.UI.WinForms.BunifuDataGridView tbMPrima;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel13;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel12;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel9;
        private Guna.UI.WinForms.GunaComboBox cbxProveedorInsumo;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel10;
        private Guna.UI.WinForms.GunaComboBox cbxMedidaInsumo;
        private Bunifu.UI.WinForms.BunifuLabel lblNuevoInsumo;
        private Guna.UI.WinForms.GunaButton btnIngresarInsumo;
        private Bunifu.UI.WinForms.BunifuDatePicker dpFExpiracionInsumo;
        private Bunifu.UI.WinForms.BunifuTextBox txtNombreInsumo;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton9;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton1;
        private Guna.UI.WinForms.GunaContextMenuStrip MOInsumos;
        private System.Windows.Forms.ToolStripMenuItem MObtnEditar;
        private System.Windows.Forms.ToolStripMenuItem MObtnEliminar;
        private Bunifu.UI.WinForms.BunifuSnackbar Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMprima;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn FCompraInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FExpiracionMPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMedMPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMedMPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProvMPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProvMprima;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnEliminar;
        private Guna.UI.WinForms.GunaButton btnAtrasMain;
        private Guna.UI.WinForms.GunaButton btnAtras;
        private Guna.UI.WinForms.GunaButton btnAtrasNew;
    }
}