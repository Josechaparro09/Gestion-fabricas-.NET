namespace PresentacionGUI
{
    partial class ProveedorGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedorGUI));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.tbpProv = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnAtras = new Guna.UI.WinForms.GunaButton();
            this.tbProve = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.IdProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FRegistroProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.MOProv = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNuevoProv = new Guna.UI.WinForms.GunaButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnAtrasNew = new Guna.UI.WinForms.GunaButton();
            this.lblProv = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnInngresarProv = new Guna.UI.WinForms.GunaButton();
            this.txtDireccionProv = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtTelefonoProv = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtNombreProv = new Bunifu.UI.WinForms.BunifuTextBox();
            this.Menu = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbpProv.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProve)).BeginInit();
            this.MOProv.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpProv
            // 
            this.tbpProv.Controls.Add(this.metroTabPage1);
            this.tbpProv.Controls.Add(this.metroTabPage2);
            this.tbpProv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpProv.Location = new System.Drawing.Point(0, 0);
            this.tbpProv.Name = "tbpProv";
            this.tbpProv.SelectedIndex = 0;
            this.tbpProv.Size = new System.Drawing.Size(823, 700);
            this.tbpProv.TabIndex = 0;
            this.tbpProv.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnAtras);
            this.metroTabPage1.Controls.Add(this.tbProve);
            this.metroTabPage1.Controls.Add(this.btnNuevoProv);
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
            this.btnAtras.Location = new System.Drawing.Point(756, 16);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnAtras.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAtras.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAtras.OnHoverImage = null;
            this.btnAtras.OnPressedColor = System.Drawing.Color.Black;
            this.btnAtras.Radius = 20;
            this.btnAtras.Size = new System.Drawing.Size(51, 41);
            this.btnAtras.TabIndex = 28;
            this.btnAtras.TextOffsetX = 10;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // tbProve
            // 
            this.tbProve.AllowCustomTheming = true;
            this.tbProve.AllowUserToAddRows = false;
            this.tbProve.AllowUserToDeleteRows = false;
            this.tbProve.AllowUserToResizeColumns = false;
            this.tbProve.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tbProve.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbProve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbProve.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProve.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbProve.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbProve.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tbProve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbProve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProv,
            this.NombreProv,
            this.TelefonoProv,
            this.DireccionProv,
            this.FRegistroProv,
            this.btnEditar,
            this.btnEliminar});
            this.tbProve.ContextMenuStrip = this.MOProv;
            this.tbProve.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tbProve.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbProve.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbProve.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbProve.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tbProve.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tbProve.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbProve.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbProve.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tbProve.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tbProve.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.tbProve.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tbProve.CurrentTheme.Name = null;
            this.tbProve.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tbProve.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbProve.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbProve.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbProve.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbProve.DefaultCellStyle = dataGridViewCellStyle3;
            this.tbProve.EnableHeadersVisualStyles = false;
            this.tbProve.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbProve.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbProve.HeaderBgColor = System.Drawing.Color.Empty;
            this.tbProve.HeaderForeColor = System.Drawing.Color.White;
            this.tbProve.Location = new System.Drawing.Point(51, 155);
            this.tbProve.Name = "tbProve";
            this.tbProve.ReadOnly = true;
            this.tbProve.RowHeadersVisible = false;
            this.tbProve.RowTemplate.Height = 40;
            this.tbProve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbProve.Size = new System.Drawing.Size(712, 438);
            this.tbProve.TabIndex = 19;
            this.tbProve.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.tbProve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbProve_CellContentClick);
            this.tbProve.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbProve_MouseDown);
            // 
            // IdProv
            // 
            this.IdProv.HeaderText = "Id";
            this.IdProv.Name = "IdProv";
            this.IdProv.ReadOnly = true;
            this.IdProv.Visible = false;
            // 
            // NombreProv
            // 
            this.NombreProv.HeaderText = "Nombre";
            this.NombreProv.Name = "NombreProv";
            this.NombreProv.ReadOnly = true;
            // 
            // TelefonoProv
            // 
            this.TelefonoProv.HeaderText = "Telefono";
            this.TelefonoProv.Name = "TelefonoProv";
            this.TelefonoProv.ReadOnly = true;
            // 
            // DireccionProv
            // 
            this.DireccionProv.HeaderText = "Direccion";
            this.DireccionProv.Name = "DireccionProv";
            this.DireccionProv.ReadOnly = true;
            // 
            // FRegistroProv
            // 
            this.FRegistroProv.HeaderText = "Fecha de registro";
            this.FRegistroProv.Name = "FRegistroProv";
            this.FRegistroProv.ReadOnly = true;
            this.FRegistroProv.Visible = false;
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
            this.btnEliminar.Image = global::PresentacionGUI.Properties.Resources.cancel;
            this.btnEliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Width = 5;
            // 
            // MOProv
            // 
            this.MOProv.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MOProv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.MOProv.Name = "MenuOpciones";
            this.MOProv.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.MOProv.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.MOProv.RenderStyle.ColorTable = null;
            this.MOProv.RenderStyle.RoundedEdges = true;
            this.MOProv.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.MOProv.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MOProv.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MOProv.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.MOProv.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.MOProv.Size = new System.Drawing.Size(148, 68);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::PresentacionGUI.Properties.Resources.edit;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 32);
            this.toolStripMenuItem1.Text = "Editar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::PresentacionGUI.Properties.Resources.cancel1;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(147, 32);
            this.toolStripMenuItem2.Text = "Eliminar";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // btnNuevoProv
            // 
            this.btnNuevoProv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNuevoProv.Animated = true;
            this.btnNuevoProv.AnimationHoverSpeed = 0.07F;
            this.btnNuevoProv.AnimationSpeed = 0.03F;
            this.btnNuevoProv.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoProv.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnNuevoProv.BorderColor = System.Drawing.Color.Black;
            this.btnNuevoProv.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNuevoProv.FocusedColor = System.Drawing.Color.Empty;
            this.btnNuevoProv.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProv.ForeColor = System.Drawing.Color.White;
            this.btnNuevoProv.Image = global::PresentacionGUI.Properties.Resources.Registros;
            this.btnNuevoProv.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNuevoProv.Location = new System.Drawing.Point(299, 66);
            this.btnNuevoProv.Name = "btnNuevoProv";
            this.btnNuevoProv.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnNuevoProv.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNuevoProv.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNuevoProv.OnHoverImage = null;
            this.btnNuevoProv.OnPressedColor = System.Drawing.Color.Black;
            this.btnNuevoProv.Radius = 20;
            this.btnNuevoProv.Size = new System.Drawing.Size(234, 62);
            this.btnNuevoProv.TabIndex = 18;
            this.btnNuevoProv.Text = "Nuevo proveedor";
            this.btnNuevoProv.TextOffsetX = 10;
            this.btnNuevoProv.Click += new System.EventHandler(this.btnNuevoProv_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnAtrasNew);
            this.metroTabPage2.Controls.Add(this.lblProv);
            this.metroTabPage2.Controls.Add(this.btnInngresarProv);
            this.metroTabPage2.Controls.Add(this.txtDireccionProv);
            this.metroTabPage2.Controls.Add(this.txtTelefonoProv);
            this.metroTabPage2.Controls.Add(this.txtNombreProv);
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
            this.btnAtrasNew.Location = new System.Drawing.Point(756, 13);
            this.btnAtrasNew.Name = "btnAtrasNew";
            this.btnAtrasNew.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnAtrasNew.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAtrasNew.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAtrasNew.OnHoverImage = null;
            this.btnAtrasNew.OnPressedColor = System.Drawing.Color.Black;
            this.btnAtrasNew.Radius = 20;
            this.btnAtrasNew.Size = new System.Drawing.Size(51, 41);
            this.btnAtrasNew.TabIndex = 32;
            this.btnAtrasNew.TextOffsetX = 10;
            this.btnAtrasNew.Click += new System.EventHandler(this.btnAtrasNew_Click);
            // 
            // lblProv
            // 
            this.lblProv.AllowParentOverrides = false;
            this.lblProv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProv.AutoEllipsis = false;
            this.lblProv.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblProv.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblProv.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.lblProv.Location = new System.Drawing.Point(302, 132);
            this.lblProv.Name = "lblProv";
            this.lblProv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProv.Size = new System.Drawing.Size(210, 42);
            this.lblProv.TabIndex = 29;
            this.lblProv.Text = "Nuevo Proveedor";
            this.lblProv.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblProv.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnInngresarProv
            // 
            this.btnInngresarProv.Animated = true;
            this.btnInngresarProv.AnimationHoverSpeed = 0.07F;
            this.btnInngresarProv.AnimationSpeed = 0.03F;
            this.btnInngresarProv.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnInngresarProv.BorderColor = System.Drawing.Color.Black;
            this.btnInngresarProv.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInngresarProv.FocusedColor = System.Drawing.Color.Empty;
            this.btnInngresarProv.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInngresarProv.ForeColor = System.Drawing.Color.White;
            this.btnInngresarProv.Image = null;
            this.btnInngresarProv.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInngresarProv.Location = new System.Drawing.Point(327, 484);
            this.btnInngresarProv.Name = "btnInngresarProv";
            this.btnInngresarProv.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnInngresarProv.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInngresarProv.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInngresarProv.OnHoverImage = null;
            this.btnInngresarProv.OnPressedColor = System.Drawing.Color.Black;
            this.btnInngresarProv.Size = new System.Drawing.Size(160, 42);
            this.btnInngresarProv.TabIndex = 28;
            this.btnInngresarProv.Text = "Ingresar";
            this.btnInngresarProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInngresarProv.Click += new System.EventHandler(this.btnInngresarProv_Click);
            // 
            // txtDireccionProv
            // 
            this.txtDireccionProv.AcceptsReturn = false;
            this.txtDireccionProv.AcceptsTab = false;
            this.txtDireccionProv.AnimationSpeed = 200;
            this.txtDireccionProv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDireccionProv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDireccionProv.BackColor = System.Drawing.Color.White;
            this.txtDireccionProv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDireccionProv.BackgroundImage")));
            this.txtDireccionProv.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtDireccionProv.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDireccionProv.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtDireccionProv.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtDireccionProv.BorderRadius = 5;
            this.txtDireccionProv.BorderThickness = 2;
            this.txtDireccionProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDireccionProv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccionProv.DefaultFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionProv.DefaultText = "";
            this.txtDireccionProv.FillColor = System.Drawing.Color.White;
            this.txtDireccionProv.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDireccionProv.HideSelection = true;
            this.txtDireccionProv.IconLeft = null;
            this.txtDireccionProv.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccionProv.IconPadding = 10;
            this.txtDireccionProv.IconRight = null;
            this.txtDireccionProv.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccionProv.Lines = new string[0];
            this.txtDireccionProv.Location = new System.Drawing.Point(277, 371);
            this.txtDireccionProv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccionProv.MaxLength = 32767;
            this.txtDireccionProv.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtDireccionProv.Modified = false;
            this.txtDireccionProv.Multiline = false;
            this.txtDireccionProv.Name = "txtDireccionProv";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDireccionProv.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDireccionProv.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDireccionProv.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDireccionProv.OnIdleState = stateProperties4;
            this.txtDireccionProv.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccionProv.PasswordChar = '\0';
            this.txtDireccionProv.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDireccionProv.PlaceholderText = "Direccion";
            this.txtDireccionProv.ReadOnly = false;
            this.txtDireccionProv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDireccionProv.SelectedText = "";
            this.txtDireccionProv.SelectionLength = 0;
            this.txtDireccionProv.SelectionStart = 0;
            this.txtDireccionProv.ShortcutsEnabled = true;
            this.txtDireccionProv.Size = new System.Drawing.Size(260, 51);
            this.txtDireccionProv.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtDireccionProv.TabIndex = 31;
            this.txtDireccionProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDireccionProv.TextMarginBottom = 0;
            this.txtDireccionProv.TextMarginLeft = 3;
            this.txtDireccionProv.TextMarginTop = 0;
            this.txtDireccionProv.TextPlaceholder = "Direccion";
            this.txtDireccionProv.UseSystemPasswordChar = false;
            this.txtDireccionProv.WordWrap = true;
            // 
            // txtTelefonoProv
            // 
            this.txtTelefonoProv.AcceptsReturn = false;
            this.txtTelefonoProv.AcceptsTab = false;
            this.txtTelefonoProv.AnimationSpeed = 200;
            this.txtTelefonoProv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTelefonoProv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTelefonoProv.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefonoProv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTelefonoProv.BackgroundImage")));
            this.txtTelefonoProv.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTelefonoProv.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTelefonoProv.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTelefonoProv.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtTelefonoProv.BorderRadius = 5;
            this.txtTelefonoProv.BorderThickness = 2;
            this.txtTelefonoProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefonoProv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefonoProv.DefaultFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoProv.DefaultText = "";
            this.txtTelefonoProv.FillColor = System.Drawing.SystemColors.Window;
            this.txtTelefonoProv.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTelefonoProv.HideSelection = true;
            this.txtTelefonoProv.IconLeft = null;
            this.txtTelefonoProv.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefonoProv.IconPadding = 10;
            this.txtTelefonoProv.IconRight = null;
            this.txtTelefonoProv.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefonoProv.Lines = new string[0];
            this.txtTelefonoProv.Location = new System.Drawing.Point(277, 286);
            this.txtTelefonoProv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefonoProv.MaxLength = 32767;
            this.txtTelefonoProv.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTelefonoProv.Modified = false;
            this.txtTelefonoProv.Multiline = false;
            this.txtTelefonoProv.Name = "txtTelefonoProv";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTelefonoProv.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTelefonoProv.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTelefonoProv.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties8.FillColor = System.Drawing.SystemColors.Window;
            stateProperties8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTelefonoProv.OnIdleState = stateProperties8;
            this.txtTelefonoProv.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefonoProv.PasswordChar = '\0';
            this.txtTelefonoProv.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTelefonoProv.PlaceholderText = "Telefono";
            this.txtTelefonoProv.ReadOnly = false;
            this.txtTelefonoProv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefonoProv.SelectedText = "";
            this.txtTelefonoProv.SelectionLength = 0;
            this.txtTelefonoProv.SelectionStart = 0;
            this.txtTelefonoProv.ShortcutsEnabled = true;
            this.txtTelefonoProv.Size = new System.Drawing.Size(260, 51);
            this.txtTelefonoProv.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtTelefonoProv.TabIndex = 30;
            this.txtTelefonoProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefonoProv.TextMarginBottom = 0;
            this.txtTelefonoProv.TextMarginLeft = 3;
            this.txtTelefonoProv.TextMarginTop = 0;
            this.txtTelefonoProv.TextPlaceholder = "Telefono";
            this.txtTelefonoProv.UseSystemPasswordChar = false;
            this.txtTelefonoProv.WordWrap = true;
            // 
            // txtNombreProv
            // 
            this.txtNombreProv.AcceptsReturn = false;
            this.txtNombreProv.AcceptsTab = false;
            this.txtNombreProv.AnimationSpeed = 200;
            this.txtNombreProv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombreProv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombreProv.BackColor = System.Drawing.Color.White;
            this.txtNombreProv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNombreProv.BackgroundImage")));
            this.txtNombreProv.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtNombreProv.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNombreProv.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtNombreProv.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtNombreProv.BorderRadius = 5;
            this.txtNombreProv.BorderThickness = 2;
            this.txtNombreProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreProv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreProv.DefaultFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProv.DefaultText = "";
            this.txtNombreProv.FillColor = System.Drawing.Color.White;
            this.txtNombreProv.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombreProv.HideSelection = true;
            this.txtNombreProv.IconLeft = null;
            this.txtNombreProv.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreProv.IconPadding = 10;
            this.txtNombreProv.IconRight = null;
            this.txtNombreProv.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreProv.Lines = new string[0];
            this.txtNombreProv.Location = new System.Drawing.Point(277, 201);
            this.txtNombreProv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreProv.MaxLength = 32767;
            this.txtNombreProv.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNombreProv.Modified = false;
            this.txtNombreProv.Multiline = false;
            this.txtNombreProv.Name = "txtNombreProv";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombreProv.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNombreProv.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombreProv.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.SystemColors.WindowFrame;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombreProv.OnIdleState = stateProperties12;
            this.txtNombreProv.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreProv.PasswordChar = '\0';
            this.txtNombreProv.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNombreProv.PlaceholderText = "Nombre";
            this.txtNombreProv.ReadOnly = false;
            this.txtNombreProv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreProv.SelectedText = "";
            this.txtNombreProv.SelectionLength = 0;
            this.txtNombreProv.SelectionStart = 0;
            this.txtNombreProv.ShortcutsEnabled = true;
            this.txtNombreProv.Size = new System.Drawing.Size(260, 51);
            this.txtNombreProv.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtNombreProv.TabIndex = 27;
            this.txtNombreProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreProv.TextMarginBottom = 0;
            this.txtNombreProv.TextMarginLeft = 3;
            this.txtNombreProv.TextMarginTop = 0;
            this.txtNombreProv.TextPlaceholder = "Nombre";
            this.txtNombreProv.UseSystemPasswordChar = false;
            this.txtNombreProv.WordWrap = true;
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
            // ProveedorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbpProv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProveedorGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.tbpProv.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbProve)).EndInit();
            this.MOProv.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tbpProv;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private Bunifu.UI.WinForms.BunifuDataGridView tbProve;
        private Guna.UI.WinForms.GunaButton btnNuevoProv;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private Bunifu.UI.WinForms.BunifuLabel lblProv;
        private Guna.UI.WinForms.GunaButton btnInngresarProv;
        private Bunifu.UI.WinForms.BunifuTextBox txtDireccionProv;
        private Bunifu.UI.WinForms.BunifuTextBox txtTelefonoProv;
        private Bunifu.UI.WinForms.BunifuTextBox txtNombreProv;
        private Guna.UI.WinForms.GunaButton btnAtras;
        private Guna.UI.WinForms.GunaButton btnAtrasNew;
        private Guna.UI.WinForms.GunaContextMenuStrip MOProv;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private Bunifu.UI.WinForms.BunifuSnackbar Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn FRegistroProv;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnEliminar;
        private System.Windows.Forms.Panel panel1;
    }
}