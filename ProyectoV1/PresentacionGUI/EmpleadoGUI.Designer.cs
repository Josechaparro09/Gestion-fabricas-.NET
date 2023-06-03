namespace PresentacionGUI
{
    partial class EmpleadoGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadoGUI));
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.tbpMain = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnAtras = new Guna.UI.WinForms.GunaButton();
            this.tbEmpleados = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.IdEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.MOEmp = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNuevoEmpleado = new Guna.UI.WinForms.GunaButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.txtCedulaEMp = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblNuevoEmpl = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnIngresarEmp = new Guna.UI.WinForms.GunaButton();
            this.txtTelefonoEmp = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtApellidoEmp = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtNombreEmp = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnAtrasNew = new Guna.UI.WinForms.GunaButton();
            this.Menu = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbpMain.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpleados)).BeginInit();
            this.MOEmp.SuspendLayout();
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
            this.metroTabPage1.Controls.Add(this.btnAtras);
            this.metroTabPage1.Controls.Add(this.tbEmpleados);
            this.metroTabPage1.Controls.Add(this.btnNuevoEmpleado);
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
            this.btnAtras.Location = new System.Drawing.Point(756, 13);
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
            // tbEmpleados
            // 
            this.tbEmpleados.AllowCustomTheming = true;
            this.tbEmpleados.AllowUserToAddRows = false;
            this.tbEmpleados.AllowUserToDeleteRows = false;
            this.tbEmpleados.AllowUserToResizeColumns = false;
            this.tbEmpleados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tbEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tbEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmp,
            this.CedulaEmpleado,
            this.NombreEmpleado,
            this.TelefonoEmpleado,
            this.dataGridViewTextBoxColumn5,
            this.btnEditar,
            this.btnEliminar});
            this.tbEmpleados.ContextMenuStrip = this.MOEmp;
            this.tbEmpleados.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tbEmpleados.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbEmpleados.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbEmpleados.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbEmpleados.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tbEmpleados.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tbEmpleados.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbEmpleados.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbEmpleados.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tbEmpleados.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tbEmpleados.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.tbEmpleados.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tbEmpleados.CurrentTheme.Name = null;
            this.tbEmpleados.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tbEmpleados.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbEmpleados.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbEmpleados.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbEmpleados.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbEmpleados.DefaultCellStyle = dataGridViewCellStyle3;
            this.tbEmpleados.EnableHeadersVisualStyles = false;
            this.tbEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbEmpleados.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbEmpleados.HeaderBgColor = System.Drawing.Color.Empty;
            this.tbEmpleados.HeaderForeColor = System.Drawing.Color.White;
            this.tbEmpleados.Location = new System.Drawing.Point(51, 155);
            this.tbEmpleados.Name = "tbEmpleados";
            this.tbEmpleados.ReadOnly = true;
            this.tbEmpleados.RowHeadersVisible = false;
            this.tbEmpleados.RowTemplate.Height = 40;
            this.tbEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbEmpleados.Size = new System.Drawing.Size(712, 438);
            this.tbEmpleados.TabIndex = 21;
            this.tbEmpleados.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.tbEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbEmpleados_CellContentClick);
            this.tbEmpleados.Enter += new System.EventHandler(this.tbEmpleados_Enter);
            this.tbEmpleados.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbEmpleados_MouseDown);
            // 
            // IdEmp
            // 
            this.IdEmp.HeaderText = "Id";
            this.IdEmp.Name = "IdEmp";
            this.IdEmp.ReadOnly = true;
            this.IdEmp.Visible = false;
            // 
            // CedulaEmpleado
            // 
            this.CedulaEmpleado.HeaderText = "Cedula";
            this.CedulaEmpleado.Name = "CedulaEmpleado";
            this.CedulaEmpleado.ReadOnly = true;
            // 
            // NombreEmpleado
            // 
            this.NombreEmpleado.HeaderText = "Nombre";
            this.NombreEmpleado.Name = "NombreEmpleado";
            this.NombreEmpleado.ReadOnly = true;
            // 
            // TelefonoEmpleado
            // 
            this.TelefonoEmpleado.HeaderText = "Telefono";
            this.TelefonoEmpleado.Name = "TelefonoEmpleado";
            this.TelefonoEmpleado.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Fecha de registro";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
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
            // MOEmp
            // 
            this.MOEmp.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MOEmp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.MOEmp.Name = "MenuOpciones";
            this.MOEmp.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.MOEmp.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.MOEmp.RenderStyle.ColorTable = null;
            this.MOEmp.RenderStyle.RoundedEdges = true;
            this.MOEmp.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.MOEmp.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MOEmp.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MOEmp.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.MOEmp.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.MOEmp.Size = new System.Drawing.Size(148, 68);
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
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNuevoEmpleado.Animated = true;
            this.btnNuevoEmpleado.AnimationHoverSpeed = 0.07F;
            this.btnNuevoEmpleado.AnimationSpeed = 0.03F;
            this.btnNuevoEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoEmpleado.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnNuevoEmpleado.BorderColor = System.Drawing.Color.Black;
            this.btnNuevoEmpleado.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNuevoEmpleado.FocusedColor = System.Drawing.Color.Empty;
            this.btnNuevoEmpleado.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnNuevoEmpleado.Image = global::PresentacionGUI.Properties.Resources.Registros;
            this.btnNuevoEmpleado.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(299, 66);
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnNuevoEmpleado.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNuevoEmpleado.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNuevoEmpleado.OnHoverImage = null;
            this.btnNuevoEmpleado.OnPressedColor = System.Drawing.Color.Black;
            this.btnNuevoEmpleado.Radius = 20;
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(234, 62);
            this.btnNuevoEmpleado.TabIndex = 20;
            this.btnNuevoEmpleado.Text = "Nuevo empleado";
            this.btnNuevoEmpleado.TextOffsetX = 10;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.txtCedulaEMp);
            this.metroTabPage2.Controls.Add(this.lblNuevoEmpl);
            this.metroTabPage2.Controls.Add(this.btnIngresarEmp);
            this.metroTabPage2.Controls.Add(this.txtTelefonoEmp);
            this.metroTabPage2.Controls.Add(this.txtApellidoEmp);
            this.metroTabPage2.Controls.Add(this.txtNombreEmp);
            this.metroTabPage2.Controls.Add(this.btnAtrasNew);
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
            // txtCedulaEMp
            // 
            this.txtCedulaEMp.AcceptsReturn = false;
            this.txtCedulaEMp.AcceptsTab = false;
            this.txtCedulaEMp.AnimationSpeed = 200;
            this.txtCedulaEMp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCedulaEMp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCedulaEMp.BackColor = System.Drawing.Color.White;
            this.txtCedulaEMp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCedulaEMp.BackgroundImage")));
            this.txtCedulaEMp.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtCedulaEMp.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCedulaEMp.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtCedulaEMp.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtCedulaEMp.BorderRadius = 5;
            this.txtCedulaEMp.BorderThickness = 2;
            this.txtCedulaEMp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCedulaEMp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCedulaEMp.DefaultFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaEMp.DefaultText = "";
            this.txtCedulaEMp.FillColor = System.Drawing.Color.White;
            this.txtCedulaEMp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCedulaEMp.HideSelection = true;
            this.txtCedulaEMp.IconLeft = null;
            this.txtCedulaEMp.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCedulaEMp.IconPadding = 10;
            this.txtCedulaEMp.IconRight = null;
            this.txtCedulaEMp.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCedulaEMp.Lines = new string[0];
            this.txtCedulaEMp.Location = new System.Drawing.Point(277, 165);
            this.txtCedulaEMp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCedulaEMp.MaxLength = 32767;
            this.txtCedulaEMp.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCedulaEMp.Modified = false;
            this.txtCedulaEMp.Multiline = false;
            this.txtCedulaEMp.Name = "txtCedulaEMp";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCedulaEMp.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCedulaEMp.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCedulaEMp.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCedulaEMp.OnIdleState = stateProperties4;
            this.txtCedulaEMp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCedulaEMp.PasswordChar = '\0';
            this.txtCedulaEMp.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCedulaEMp.PlaceholderText = "Cedula";
            this.txtCedulaEMp.ReadOnly = false;
            this.txtCedulaEMp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCedulaEMp.SelectedText = "";
            this.txtCedulaEMp.SelectionLength = 0;
            this.txtCedulaEMp.SelectionStart = 0;
            this.txtCedulaEMp.ShortcutsEnabled = true;
            this.txtCedulaEMp.Size = new System.Drawing.Size(260, 51);
            this.txtCedulaEMp.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtCedulaEMp.TabIndex = 39;
            this.txtCedulaEMp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCedulaEMp.TextMarginBottom = 0;
            this.txtCedulaEMp.TextMarginLeft = 3;
            this.txtCedulaEMp.TextMarginTop = 0;
            this.txtCedulaEMp.TextPlaceholder = "Cedula";
            this.txtCedulaEMp.UseSystemPasswordChar = false;
            this.txtCedulaEMp.WordWrap = true;
            // 
            // lblNuevoEmpl
            // 
            this.lblNuevoEmpl.AllowParentOverrides = false;
            this.lblNuevoEmpl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNuevoEmpl.AutoEllipsis = false;
            this.lblNuevoEmpl.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNuevoEmpl.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNuevoEmpl.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoEmpl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.lblNuevoEmpl.Location = new System.Drawing.Point(307, 86);
            this.lblNuevoEmpl.Name = "lblNuevoEmpl";
            this.lblNuevoEmpl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNuevoEmpl.Size = new System.Drawing.Size(209, 42);
            this.lblNuevoEmpl.TabIndex = 36;
            this.lblNuevoEmpl.Text = "Nuevo empleado";
            this.lblNuevoEmpl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNuevoEmpl.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnIngresarEmp
            // 
            this.btnIngresarEmp.Animated = true;
            this.btnIngresarEmp.AnimationHoverSpeed = 0.07F;
            this.btnIngresarEmp.AnimationSpeed = 0.03F;
            this.btnIngresarEmp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnIngresarEmp.BorderColor = System.Drawing.Color.Black;
            this.btnIngresarEmp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIngresarEmp.FocusedColor = System.Drawing.Color.Empty;
            this.btnIngresarEmp.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarEmp.ForeColor = System.Drawing.Color.White;
            this.btnIngresarEmp.Image = null;
            this.btnIngresarEmp.ImageSize = new System.Drawing.Size(20, 20);
            this.btnIngresarEmp.Location = new System.Drawing.Point(327, 531);
            this.btnIngresarEmp.Name = "btnIngresarEmp";
            this.btnIngresarEmp.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnIngresarEmp.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIngresarEmp.OnHoverForeColor = System.Drawing.Color.White;
            this.btnIngresarEmp.OnHoverImage = null;
            this.btnIngresarEmp.OnPressedColor = System.Drawing.Color.Black;
            this.btnIngresarEmp.Size = new System.Drawing.Size(160, 42);
            this.btnIngresarEmp.TabIndex = 35;
            this.btnIngresarEmp.Text = "Ingresar";
            this.btnIngresarEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIngresarEmp.Click += new System.EventHandler(this.btnIngresarEmp_Click);
            // 
            // txtTelefonoEmp
            // 
            this.txtTelefonoEmp.AcceptsReturn = false;
            this.txtTelefonoEmp.AcceptsTab = false;
            this.txtTelefonoEmp.AnimationSpeed = 200;
            this.txtTelefonoEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTelefonoEmp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTelefonoEmp.BackColor = System.Drawing.Color.White;
            this.txtTelefonoEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTelefonoEmp.BackgroundImage")));
            this.txtTelefonoEmp.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTelefonoEmp.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTelefonoEmp.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTelefonoEmp.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtTelefonoEmp.BorderRadius = 5;
            this.txtTelefonoEmp.BorderThickness = 2;
            this.txtTelefonoEmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefonoEmp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefonoEmp.DefaultFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoEmp.DefaultText = "";
            this.txtTelefonoEmp.FillColor = System.Drawing.Color.White;
            this.txtTelefonoEmp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTelefonoEmp.HideSelection = true;
            this.txtTelefonoEmp.IconLeft = null;
            this.txtTelefonoEmp.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefonoEmp.IconPadding = 10;
            this.txtTelefonoEmp.IconRight = null;
            this.txtTelefonoEmp.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefonoEmp.Lines = new string[0];
            this.txtTelefonoEmp.Location = new System.Drawing.Point(277, 418);
            this.txtTelefonoEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefonoEmp.MaxLength = 32767;
            this.txtTelefonoEmp.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTelefonoEmp.Modified = false;
            this.txtTelefonoEmp.Multiline = false;
            this.txtTelefonoEmp.Name = "txtTelefonoEmp";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTelefonoEmp.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTelefonoEmp.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTelefonoEmp.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTelefonoEmp.OnIdleState = stateProperties8;
            this.txtTelefonoEmp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefonoEmp.PasswordChar = '\0';
            this.txtTelefonoEmp.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTelefonoEmp.PlaceholderText = "Telefono";
            this.txtTelefonoEmp.ReadOnly = false;
            this.txtTelefonoEmp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefonoEmp.SelectedText = "";
            this.txtTelefonoEmp.SelectionLength = 0;
            this.txtTelefonoEmp.SelectionStart = 0;
            this.txtTelefonoEmp.ShortcutsEnabled = true;
            this.txtTelefonoEmp.Size = new System.Drawing.Size(260, 51);
            this.txtTelefonoEmp.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtTelefonoEmp.TabIndex = 38;
            this.txtTelefonoEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefonoEmp.TextMarginBottom = 0;
            this.txtTelefonoEmp.TextMarginLeft = 3;
            this.txtTelefonoEmp.TextMarginTop = 0;
            this.txtTelefonoEmp.TextPlaceholder = "Telefono";
            this.txtTelefonoEmp.UseSystemPasswordChar = false;
            this.txtTelefonoEmp.WordWrap = true;
            // 
            // txtApellidoEmp
            // 
            this.txtApellidoEmp.AcceptsReturn = false;
            this.txtApellidoEmp.AcceptsTab = false;
            this.txtApellidoEmp.AnimationSpeed = 200;
            this.txtApellidoEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtApellidoEmp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtApellidoEmp.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellidoEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtApellidoEmp.BackgroundImage")));
            this.txtApellidoEmp.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtApellidoEmp.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtApellidoEmp.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtApellidoEmp.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtApellidoEmp.BorderRadius = 5;
            this.txtApellidoEmp.BorderThickness = 2;
            this.txtApellidoEmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtApellidoEmp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoEmp.DefaultFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoEmp.DefaultText = "";
            this.txtApellidoEmp.FillColor = System.Drawing.SystemColors.Window;
            this.txtApellidoEmp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtApellidoEmp.HideSelection = true;
            this.txtApellidoEmp.IconLeft = null;
            this.txtApellidoEmp.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoEmp.IconPadding = 10;
            this.txtApellidoEmp.IconRight = null;
            this.txtApellidoEmp.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoEmp.Lines = new string[0];
            this.txtApellidoEmp.Location = new System.Drawing.Point(277, 333);
            this.txtApellidoEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellidoEmp.MaxLength = 32767;
            this.txtApellidoEmp.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtApellidoEmp.Modified = false;
            this.txtApellidoEmp.Multiline = false;
            this.txtApellidoEmp.Name = "txtApellidoEmp";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtApellidoEmp.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtApellidoEmp.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtApellidoEmp.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties12.FillColor = System.Drawing.SystemColors.Window;
            stateProperties12.ForeColor = System.Drawing.SystemColors.WindowFrame;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtApellidoEmp.OnIdleState = stateProperties12;
            this.txtApellidoEmp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellidoEmp.PasswordChar = '\0';
            this.txtApellidoEmp.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtApellidoEmp.PlaceholderText = "Apellido";
            this.txtApellidoEmp.ReadOnly = false;
            this.txtApellidoEmp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellidoEmp.SelectedText = "";
            this.txtApellidoEmp.SelectionLength = 0;
            this.txtApellidoEmp.SelectionStart = 0;
            this.txtApellidoEmp.ShortcutsEnabled = true;
            this.txtApellidoEmp.Size = new System.Drawing.Size(260, 51);
            this.txtApellidoEmp.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtApellidoEmp.TabIndex = 37;
            this.txtApellidoEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApellidoEmp.TextMarginBottom = 0;
            this.txtApellidoEmp.TextMarginLeft = 3;
            this.txtApellidoEmp.TextMarginTop = 0;
            this.txtApellidoEmp.TextPlaceholder = "Apellido";
            this.txtApellidoEmp.UseSystemPasswordChar = false;
            this.txtApellidoEmp.WordWrap = true;
            // 
            // txtNombreEmp
            // 
            this.txtNombreEmp.AcceptsReturn = false;
            this.txtNombreEmp.AcceptsTab = false;
            this.txtNombreEmp.AnimationSpeed = 200;
            this.txtNombreEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombreEmp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombreEmp.BackColor = System.Drawing.Color.White;
            this.txtNombreEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNombreEmp.BackgroundImage")));
            this.txtNombreEmp.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtNombreEmp.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNombreEmp.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtNombreEmp.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtNombreEmp.BorderRadius = 5;
            this.txtNombreEmp.BorderThickness = 2;
            this.txtNombreEmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreEmp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreEmp.DefaultFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmp.DefaultText = "";
            this.txtNombreEmp.FillColor = System.Drawing.Color.White;
            this.txtNombreEmp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombreEmp.HideSelection = true;
            this.txtNombreEmp.IconLeft = null;
            this.txtNombreEmp.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreEmp.IconPadding = 10;
            this.txtNombreEmp.IconRight = null;
            this.txtNombreEmp.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreEmp.Lines = new string[0];
            this.txtNombreEmp.Location = new System.Drawing.Point(277, 248);
            this.txtNombreEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreEmp.MaxLength = 32767;
            this.txtNombreEmp.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNombreEmp.Modified = false;
            this.txtNombreEmp.Multiline = false;
            this.txtNombreEmp.Name = "txtNombreEmp";
            stateProperties13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombreEmp.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNombreEmp.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombreEmp.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.SystemColors.WindowFrame;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombreEmp.OnIdleState = stateProperties16;
            this.txtNombreEmp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreEmp.PasswordChar = '\0';
            this.txtNombreEmp.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNombreEmp.PlaceholderText = "Nombre";
            this.txtNombreEmp.ReadOnly = false;
            this.txtNombreEmp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreEmp.SelectedText = "";
            this.txtNombreEmp.SelectionLength = 0;
            this.txtNombreEmp.SelectionStart = 0;
            this.txtNombreEmp.ShortcutsEnabled = true;
            this.txtNombreEmp.Size = new System.Drawing.Size(260, 51);
            this.txtNombreEmp.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtNombreEmp.TabIndex = 34;
            this.txtNombreEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreEmp.TextMarginBottom = 0;
            this.txtNombreEmp.TextMarginLeft = 3;
            this.txtNombreEmp.TextMarginTop = 0;
            this.txtNombreEmp.TextPlaceholder = "Nombre";
            this.txtNombreEmp.UseSystemPasswordChar = false;
            this.txtNombreEmp.WordWrap = true;
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
            this.btnAtrasNew.TabIndex = 33;
            this.btnAtrasNew.TextOffsetX = 10;
            this.btnAtrasNew.Click += new System.EventHandler(this.btnAtrasNew_Click);
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
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 47);
            this.panel1.TabIndex = 2;
            // 
            // EmpleadoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpleadoGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EmpleadoGUI";
            this.tbpMain.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpleados)).EndInit();
            this.MOEmp.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tbpMain;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private Bunifu.UI.WinForms.BunifuDataGridView tbEmpleados;
        private Guna.UI.WinForms.GunaButton btnNuevoEmpleado;
        private Guna.UI.WinForms.GunaContextMenuStrip MOEmp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private Bunifu.UI.WinForms.BunifuSnackbar Menu;
        private Guna.UI.WinForms.GunaButton btnAtras;
        private Guna.UI.WinForms.GunaButton btnAtrasNew;
        private Bunifu.UI.WinForms.BunifuTextBox txtCedulaEMp;
        private Bunifu.UI.WinForms.BunifuLabel lblNuevoEmpl;
        private Guna.UI.WinForms.GunaButton btnIngresarEmp;
        private Bunifu.UI.WinForms.BunifuTextBox txtTelefonoEmp;
        private Bunifu.UI.WinForms.BunifuTextBox txtApellidoEmp;
        private Bunifu.UI.WinForms.BunifuTextBox txtNombreEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnEliminar;
        private System.Windows.Forms.Panel panel1;
    }
}