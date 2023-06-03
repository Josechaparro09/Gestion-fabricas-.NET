namespace PresentacionGUI
{
    partial class PlantaGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlantaGUI));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.tbpMain = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tbPlanta = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.IdPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.MOPlanta = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.MObtnEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.MObtnEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAtras = new Guna.UI.WinForms.GunaButton();
            this.gunaButton8 = new Guna.UI.WinForms.GunaButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnAtrasNew = new Guna.UI.WinForms.GunaButton();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cbxEmpPlanta = new Guna.UI.WinForms.GunaComboBox();
            this.lblNuevaPlanta = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnIngresarPlanta = new Guna.UI.WinForms.GunaButton();
            this.txtNombrePlanta = new Bunifu.UI.WinForms.BunifuTextBox();
            this.Menu = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbpMain.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPlanta)).BeginInit();
            this.MOPlanta.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpMain
            // 
            this.tbpMain.Controls.Add(this.metroTabPage1);
            this.tbpMain.Controls.Add(this.metroTabPage2);
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
            this.metroTabPage1.Controls.Add(this.tbPlanta);
            this.metroTabPage1.Controls.Add(this.btnAtras);
            this.metroTabPage1.Controls.Add(this.gunaButton8);
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
            // tbPlanta
            // 
            this.tbPlanta.AllowCustomTheming = true;
            this.tbPlanta.AllowUserToAddRows = false;
            this.tbPlanta.AllowUserToDeleteRows = false;
            this.tbPlanta.AllowUserToResizeColumns = false;
            this.tbPlanta.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tbPlanta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbPlanta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbPlanta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPlanta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbPlanta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbPlanta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tbPlanta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbPlanta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPlanta,
            this.dataGridViewTextBoxColumn6,
            this.IdEmp,
            this.dataGridViewTextBoxColumn8,
            this.btnEditar,
            this.btnEliminar});
            this.tbPlanta.ContextMenuStrip = this.MOPlanta;
            this.tbPlanta.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tbPlanta.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbPlanta.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbPlanta.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbPlanta.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tbPlanta.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tbPlanta.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbPlanta.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbPlanta.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tbPlanta.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tbPlanta.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.tbPlanta.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tbPlanta.CurrentTheme.Name = null;
            this.tbPlanta.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tbPlanta.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbPlanta.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbPlanta.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbPlanta.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbPlanta.DefaultCellStyle = dataGridViewCellStyle3;
            this.tbPlanta.EnableHeadersVisualStyles = false;
            this.tbPlanta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbPlanta.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbPlanta.HeaderBgColor = System.Drawing.Color.Empty;
            this.tbPlanta.HeaderForeColor = System.Drawing.Color.White;
            this.tbPlanta.Location = new System.Drawing.Point(50, 149);
            this.tbPlanta.Name = "tbPlanta";
            this.tbPlanta.ReadOnly = true;
            this.tbPlanta.RowHeadersVisible = false;
            this.tbPlanta.RowTemplate.Height = 40;
            this.tbPlanta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbPlanta.Size = new System.Drawing.Size(712, 438);
            this.tbPlanta.TabIndex = 30;
            this.tbPlanta.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.tbPlanta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbPlanta_CellContentClick);
            this.tbPlanta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbPlanta_MouseDown);
            // 
            // IdPlanta
            // 
            this.IdPlanta.HeaderText = "Id";
            this.IdPlanta.Name = "IdPlanta";
            this.IdPlanta.ReadOnly = true;
            this.IdPlanta.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // IdEmp
            // 
            this.IdEmp.HeaderText = "IdEmpleado";
            this.IdEmp.Name = "IdEmp";
            this.IdEmp.ReadOnly = true;
            this.IdEmp.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Empleado asignado";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
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
            // MOPlanta
            // 
            this.MOPlanta.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MOPlanta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MObtnEditar,
            this.MObtnEliminar});
            this.MOPlanta.Name = "MenuOpciones";
            this.MOPlanta.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.MOPlanta.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.MOPlanta.RenderStyle.ColorTable = null;
            this.MOPlanta.RenderStyle.RoundedEdges = true;
            this.MOPlanta.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.MOPlanta.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MOPlanta.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MOPlanta.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.MOPlanta.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.MOPlanta.Size = new System.Drawing.Size(148, 68);
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
            this.btnAtras.Location = new System.Drawing.Point(756, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnAtras.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAtras.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAtras.OnHoverImage = null;
            this.btnAtras.OnPressedColor = System.Drawing.Color.Black;
            this.btnAtras.Radius = 20;
            this.btnAtras.Size = new System.Drawing.Size(51, 41);
            this.btnAtras.TabIndex = 29;
            this.btnAtras.TextOffsetX = 10;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
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
            this.gunaButton8.Location = new System.Drawing.Point(299, 60);
            this.gunaButton8.Name = "gunaButton8";
            this.gunaButton8.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.gunaButton8.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton8.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton8.OnHoverImage = null;
            this.gunaButton8.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton8.Radius = 20;
            this.gunaButton8.Size = new System.Drawing.Size(234, 62);
            this.gunaButton8.TabIndex = 23;
            this.gunaButton8.Text = "Nueva planta";
            this.gunaButton8.TextOffsetX = 10;
            this.gunaButton8.Click += new System.EventHandler(this.gunaButton8_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnAtrasNew);
            this.metroTabPage2.Controls.Add(this.bunifuLabel5);
            this.metroTabPage2.Controls.Add(this.cbxEmpPlanta);
            this.metroTabPage2.Controls.Add(this.lblNuevaPlanta);
            this.metroTabPage2.Controls.Add(this.btnIngresarPlanta);
            this.metroTabPage2.Controls.Add(this.txtNombrePlanta);
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
            this.btnAtrasNew.Location = new System.Drawing.Point(756, 13);
            this.btnAtrasNew.Name = "btnAtrasNew";
            this.btnAtrasNew.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnAtrasNew.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAtrasNew.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAtrasNew.OnHoverImage = null;
            this.btnAtrasNew.OnPressedColor = System.Drawing.Color.Black;
            this.btnAtrasNew.Radius = 20;
            this.btnAtrasNew.Size = new System.Drawing.Size(51, 41);
            this.btnAtrasNew.TabIndex = 34;
            this.btnAtrasNew.TextOffsetX = 10;
            this.btnAtrasNew.Click += new System.EventHandler(this.btnAtrasNew_Click);
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.Font = new System.Drawing.Font("Poppins", 11F);
            this.bunifuLabel5.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuLabel5.Location = new System.Drawing.Point(331, 354);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(152, 26);
            this.bunifuLabel5.TabIndex = 33;
            this.bunifuLabel5.Text = "Empleado asignado";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cbxEmpPlanta
            // 
            this.cbxEmpPlanta.BackColor = System.Drawing.Color.Transparent;
            this.cbxEmpPlanta.BaseColor = System.Drawing.Color.White;
            this.cbxEmpPlanta.BorderColor = System.Drawing.Color.Silver;
            this.cbxEmpPlanta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxEmpPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmpPlanta.FocusedColor = System.Drawing.Color.Empty;
            this.cbxEmpPlanta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxEmpPlanta.ForeColor = System.Drawing.Color.Black;
            this.cbxEmpPlanta.FormattingEnabled = true;
            this.cbxEmpPlanta.Location = new System.Drawing.Point(277, 382);
            this.cbxEmpPlanta.Name = "cbxEmpPlanta";
            this.cbxEmpPlanta.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxEmpPlanta.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxEmpPlanta.Radius = 5;
            this.cbxEmpPlanta.Size = new System.Drawing.Size(260, 26);
            this.cbxEmpPlanta.TabIndex = 32;
            // 
            // lblNuevaPlanta
            // 
            this.lblNuevaPlanta.AllowParentOverrides = false;
            this.lblNuevaPlanta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNuevaPlanta.AutoEllipsis = false;
            this.lblNuevaPlanta.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNuevaPlanta.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNuevaPlanta.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaPlanta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.lblNuevaPlanta.Location = new System.Drawing.Point(324, 152);
            this.lblNuevaPlanta.Name = "lblNuevaPlanta";
            this.lblNuevaPlanta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNuevaPlanta.Size = new System.Drawing.Size(166, 42);
            this.lblNuevaPlanta.TabIndex = 31;
            this.lblNuevaPlanta.Text = "Nueva planta";
            this.lblNuevaPlanta.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNuevaPlanta.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnIngresarPlanta
            // 
            this.btnIngresarPlanta.Animated = true;
            this.btnIngresarPlanta.AnimationHoverSpeed = 0.07F;
            this.btnIngresarPlanta.AnimationSpeed = 0.03F;
            this.btnIngresarPlanta.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnIngresarPlanta.BorderColor = System.Drawing.Color.Black;
            this.btnIngresarPlanta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIngresarPlanta.FocusedColor = System.Drawing.Color.Empty;
            this.btnIngresarPlanta.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarPlanta.ForeColor = System.Drawing.Color.White;
            this.btnIngresarPlanta.Image = null;
            this.btnIngresarPlanta.ImageSize = new System.Drawing.Size(20, 20);
            this.btnIngresarPlanta.Location = new System.Drawing.Point(327, 465);
            this.btnIngresarPlanta.Name = "btnIngresarPlanta";
            this.btnIngresarPlanta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnIngresarPlanta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIngresarPlanta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnIngresarPlanta.OnHoverImage = null;
            this.btnIngresarPlanta.OnPressedColor = System.Drawing.Color.Black;
            this.btnIngresarPlanta.Size = new System.Drawing.Size(160, 42);
            this.btnIngresarPlanta.TabIndex = 30;
            this.btnIngresarPlanta.Text = "Ingresar";
            this.btnIngresarPlanta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIngresarPlanta.Click += new System.EventHandler(this.btnIngresarPlanta_Click);
            // 
            // txtNombrePlanta
            // 
            this.txtNombrePlanta.AcceptsReturn = false;
            this.txtNombrePlanta.AcceptsTab = false;
            this.txtNombrePlanta.AnimationSpeed = 200;
            this.txtNombrePlanta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombrePlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombrePlanta.BackColor = System.Drawing.Color.White;
            this.txtNombrePlanta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNombrePlanta.BackgroundImage")));
            this.txtNombrePlanta.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtNombrePlanta.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNombrePlanta.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtNombrePlanta.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtNombrePlanta.BorderRadius = 5;
            this.txtNombrePlanta.BorderThickness = 2;
            this.txtNombrePlanta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombrePlanta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombrePlanta.DefaultFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePlanta.DefaultText = "";
            this.txtNombrePlanta.FillColor = System.Drawing.Color.White;
            this.txtNombrePlanta.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombrePlanta.HideSelection = true;
            this.txtNombrePlanta.IconLeft = null;
            this.txtNombrePlanta.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombrePlanta.IconPadding = 10;
            this.txtNombrePlanta.IconRight = null;
            this.txtNombrePlanta.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombrePlanta.Lines = new string[0];
            this.txtNombrePlanta.Location = new System.Drawing.Point(277, 240);
            this.txtNombrePlanta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombrePlanta.MaxLength = 32767;
            this.txtNombrePlanta.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNombrePlanta.Modified = false;
            this.txtNombrePlanta.Multiline = false;
            this.txtNombrePlanta.Name = "txtNombrePlanta";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombrePlanta.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNombrePlanta.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombrePlanta.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombrePlanta.OnIdleState = stateProperties4;
            this.txtNombrePlanta.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombrePlanta.PasswordChar = '\0';
            this.txtNombrePlanta.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNombrePlanta.PlaceholderText = "Nombre";
            this.txtNombrePlanta.ReadOnly = false;
            this.txtNombrePlanta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombrePlanta.SelectedText = "";
            this.txtNombrePlanta.SelectionLength = 0;
            this.txtNombrePlanta.SelectionStart = 0;
            this.txtNombrePlanta.ShortcutsEnabled = true;
            this.txtNombrePlanta.Size = new System.Drawing.Size(260, 51);
            this.txtNombrePlanta.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtNombrePlanta.TabIndex = 29;
            this.txtNombrePlanta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombrePlanta.TextMarginBottom = 0;
            this.txtNombrePlanta.TextMarginLeft = 3;
            this.txtNombrePlanta.TextMarginTop = 0;
            this.txtNombrePlanta.TextPlaceholder = "Nombre";
            this.txtNombrePlanta.UseSystemPasswordChar = false;
            this.txtNombrePlanta.WordWrap = true;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 47);
            this.panel1.TabIndex = 2;
            // 
            // PlantaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlantaGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PlantaGUI";
            this.tbpMain.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbPlanta)).EndInit();
            this.MOPlanta.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tbpMain;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private Guna.UI.WinForms.GunaButton gunaButton8;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Guna.UI.WinForms.GunaComboBox cbxEmpPlanta;
        private Bunifu.UI.WinForms.BunifuLabel lblNuevaPlanta;
        private Guna.UI.WinForms.GunaButton btnIngresarPlanta;
        private Bunifu.UI.WinForms.BunifuTextBox txtNombrePlanta;
        private Guna.UI.WinForms.GunaButton btnAtras;
        private Guna.UI.WinForms.GunaButton btnAtrasNew;
        private Bunifu.UI.WinForms.BunifuSnackbar Menu;
        private Guna.UI.WinForms.GunaContextMenuStrip MOPlanta;
        private System.Windows.Forms.ToolStripMenuItem MObtnEditar;
        private System.Windows.Forms.ToolStripMenuItem MObtnEliminar;
        private Bunifu.UI.WinForms.BunifuDataGridView tbPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnEliminar;
        private System.Windows.Forms.Panel panel1;
    }
}