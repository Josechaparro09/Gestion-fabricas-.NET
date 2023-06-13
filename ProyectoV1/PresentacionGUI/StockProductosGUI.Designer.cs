namespace PresentacionGUI
{
    partial class StockProductosGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockProductosGUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbpMain = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnAtras1 = new Guna.UI.WinForms.GunaButton();
            this.lblNuevoProd = new Bunifu.UI.WinForms.BunifuLabel();
            this.tbStock = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.tbSMP = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.IdSMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MPId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.btnSProd = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnSMP = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbpMain.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbStock)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSMP)).BeginInit();
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
            this.metroTabPage1.Controls.Add(this.btnAtras1);
            this.metroTabPage1.Controls.Add(this.lblNuevoProd);
            this.metroTabPage1.Controls.Add(this.tbStock);
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
            this.btnAtras1.Location = new System.Drawing.Point(757, 12);
            this.btnAtras1.Name = "btnAtras1";
            this.btnAtras1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnAtras1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAtras1.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAtras1.OnHoverImage = null;
            this.btnAtras1.OnPressedColor = System.Drawing.Color.Black;
            this.btnAtras1.Radius = 20;
            this.btnAtras1.Size = new System.Drawing.Size(51, 41);
            this.btnAtras1.TabIndex = 43;
            this.btnAtras1.TextOffsetX = 10;
            this.btnAtras1.Click += new System.EventHandler(this.btnAtras1_Click);
            // 
            // lblNuevoProd
            // 
            this.lblNuevoProd.AllowParentOverrides = false;
            this.lblNuevoProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNuevoProd.AutoEllipsis = false;
            this.lblNuevoProd.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNuevoProd.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNuevoProd.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.lblNuevoProd.Location = new System.Drawing.Point(291, 35);
            this.lblNuevoProd.Name = "lblNuevoProd";
            this.lblNuevoProd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNuevoProd.Size = new System.Drawing.Size(234, 42);
            this.lblNuevoProd.TabIndex = 42;
            this.lblNuevoProd.Text = "Productos en stock";
            this.lblNuevoProd.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNuevoProd.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // tbStock
            // 
            this.tbStock.AllowCustomTheming = true;
            this.tbStock.AllowUserToAddRows = false;
            this.tbStock.AllowUserToDeleteRows = false;
            this.tbStock.AllowUserToResizeColumns = false;
            this.tbStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.tbStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tbStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tbStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProdId,
            this.Producto,
            this.Cantidad});
            this.tbStock.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tbStock.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbStock.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbStock.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbStock.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tbStock.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tbStock.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbStock.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbStock.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tbStock.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tbStock.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.tbStock.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tbStock.CurrentTheme.Name = null;
            this.tbStock.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tbStock.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbStock.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbStock.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbStock.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbStock.DefaultCellStyle = dataGridViewCellStyle9;
            this.tbStock.EnableHeadersVisualStyles = false;
            this.tbStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbStock.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbStock.HeaderBgColor = System.Drawing.Color.Empty;
            this.tbStock.HeaderForeColor = System.Drawing.Color.White;
            this.tbStock.Location = new System.Drawing.Point(9, 105);
            this.tbStock.Name = "tbStock";
            this.tbStock.ReadOnly = true;
            this.tbStock.RowHeadersVisible = false;
            this.tbStock.RowTemplate.Height = 40;
            this.tbStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbStock.Size = new System.Drawing.Size(799, 438);
            this.tbStock.TabIndex = 26;
            this.tbStock.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
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
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad actual";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.gunaButton1);
            this.metroTabPage2.Controls.Add(this.bunifuLabel1);
            this.metroTabPage2.Controls.Add(this.tbSMP);
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
            this.gunaButton1.Location = new System.Drawing.Point(756, 13);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(51, 41);
            this.gunaButton1.TabIndex = 46;
            this.gunaButton1.TextOffsetX = 10;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(300, 36);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(214, 42);
            this.bunifuLabel1.TabIndex = 45;
            this.bunifuLabel1.Text = "Insumos en stock";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // tbSMP
            // 
            this.tbSMP.AllowCustomTheming = true;
            this.tbSMP.AllowUserToAddRows = false;
            this.tbSMP.AllowUserToDeleteRows = false;
            this.tbSMP.AllowUserToResizeColumns = false;
            this.tbSMP.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.tbSMP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.tbSMP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbSMP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSMP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbSMP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbSMP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.tbSMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbSMP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSMP,
            this.MPId,
            this.MP,
            this.CantMP});
            this.tbSMP.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tbSMP.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbSMP.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbSMP.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbSMP.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tbSMP.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tbSMP.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbSMP.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbSMP.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tbSMP.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tbSMP.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.tbSMP.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tbSMP.CurrentTheme.Name = null;
            this.tbSMP.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tbSMP.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbSMP.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbSMP.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbSMP.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbSMP.DefaultCellStyle = dataGridViewCellStyle12;
            this.tbSMP.EnableHeadersVisualStyles = false;
            this.tbSMP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbSMP.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbSMP.HeaderBgColor = System.Drawing.Color.Empty;
            this.tbSMP.HeaderForeColor = System.Drawing.Color.White;
            this.tbSMP.Location = new System.Drawing.Point(8, 106);
            this.tbSMP.Name = "tbSMP";
            this.tbSMP.ReadOnly = true;
            this.tbSMP.RowHeadersVisible = false;
            this.tbSMP.RowTemplate.Height = 40;
            this.tbSMP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbSMP.Size = new System.Drawing.Size(799, 438);
            this.tbSMP.TabIndex = 44;
            this.tbSMP.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // IdSMP
            // 
            this.IdSMP.HeaderText = "Id";
            this.IdSMP.Name = "IdSMP";
            this.IdSMP.ReadOnly = true;
            this.IdSMP.Visible = false;
            // 
            // MPId
            // 
            this.MPId.HeaderText = "MPId";
            this.MPId.Name = "MPId";
            this.MPId.ReadOnly = true;
            this.MPId.Visible = false;
            // 
            // MP
            // 
            this.MP.HeaderText = "Insumo";
            this.MP.Name = "MP";
            this.MP.ReadOnly = true;
            // 
            // CantMP
            // 
            this.CantMP.HeaderText = "Cantidad actual";
            this.CantMP.Name = "CantMP";
            this.CantMP.ReadOnly = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.btnSProd);
            this.metroTabPage3.Controls.Add(this.btnSMP);
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
            // 
            // btnSProd
            // 
            this.btnSProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSProd.Animated = true;
            this.btnSProd.AnimationHoverSpeed = 0.07F;
            this.btnSProd.AnimationSpeed = 0.03F;
            this.btnSProd.BackColor = System.Drawing.Color.Transparent;
            this.btnSProd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSProd.BorderColor = System.Drawing.Color.Black;
            this.btnSProd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSProd.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSProd.CheckedForeColor = System.Drawing.Color.White;
            this.btnSProd.CheckedImage = global::PresentacionGUI.Properties.Resources.Producto;
            this.btnSProd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSProd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSProd.FocusedColor = System.Drawing.Color.Empty;
            this.btnSProd.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSProd.ForeColor = System.Drawing.Color.White;
            this.btnSProd.Image = global::PresentacionGUI.Properties.Resources.Producto;
            this.btnSProd.ImageSize = new System.Drawing.Size(72, 72);
            this.btnSProd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSProd.Location = new System.Drawing.Point(434, 178);
            this.btnSProd.Name = "btnSProd";
            this.btnSProd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnSProd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSProd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSProd.OnHoverImage = null;
            this.btnSProd.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSProd.OnPressedColor = System.Drawing.Color.Black;
            this.btnSProd.Radius = 30;
            this.btnSProd.Size = new System.Drawing.Size(210, 210);
            this.btnSProd.TabIndex = 23;
            this.btnSProd.Text = "Stock de productos";
            this.btnSProd.Click += new System.EventHandler(this.btnSProd_Click);
            // 
            // btnSMP
            // 
            this.btnSMP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSMP.Animated = true;
            this.btnSMP.AnimationHoverSpeed = 0.07F;
            this.btnSMP.AnimationSpeed = 0.03F;
            this.btnSMP.BackColor = System.Drawing.Color.Transparent;
            this.btnSMP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSMP.BorderColor = System.Drawing.Color.Black;
            this.btnSMP.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSMP.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSMP.CheckedForeColor = System.Drawing.Color.White;
            this.btnSMP.CheckedImage = global::PresentacionGUI.Properties.Resources.Planta;
            this.btnSMP.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSMP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSMP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSMP.FocusedColor = System.Drawing.Color.Empty;
            this.btnSMP.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSMP.ForeColor = System.Drawing.Color.White;
            this.btnSMP.Image = global::PresentacionGUI.Properties.Resources.Planta;
            this.btnSMP.ImageSize = new System.Drawing.Size(72, 72);
            this.btnSMP.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSMP.Location = new System.Drawing.Point(165, 178);
            this.btnSMP.Name = "btnSMP";
            this.btnSMP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnSMP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSMP.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSMP.OnHoverImage = null;
            this.btnSMP.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSMP.OnPressedColor = System.Drawing.Color.Black;
            this.btnSMP.Radius = 30;
            this.btnSMP.Size = new System.Drawing.Size(210, 210);
            this.btnSMP.TabIndex = 24;
            this.btnSMP.Text = "Stock de insumos";
            this.btnSMP.Click += new System.EventHandler(this.btnSMP_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 47);
            this.panel1.TabIndex = 3;
            // 
            // StockProductosGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockProductosGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StockProductosGUI";
            this.tbpMain.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbStock)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSMP)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tbpMain;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private Bunifu.UI.WinForms.BunifuDataGridView tbStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private Bunifu.UI.WinForms.BunifuLabel lblNuevoProd;
        private Guna.UI.WinForms.GunaButton btnAtras1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDataGridView tbSMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MPId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantMP;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnSProd;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnSMP;
        private System.Windows.Forms.Panel panel1;
    }
}