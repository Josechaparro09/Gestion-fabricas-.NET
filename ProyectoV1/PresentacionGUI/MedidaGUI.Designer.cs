namespace PresentacionGUI
{
    partial class MedidaGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedidaGUI));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.tbpMedida = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnAtras = new Guna.UI.WinForms.GunaButton();
            this.tbMedidas = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.IdMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCortoMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NLargoMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditarMed = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEliminarMed = new System.Windows.Forms.DataGridViewImageColumn();
            this.MOMedidas = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNuevaMedida = new Guna.UI.WinForms.GunaButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.lbNuevaMedida = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnIngresar = new Guna.UI.WinForms.GunaButton();
            this.txtNLargo = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtNombreCorto = new Bunifu.UI.WinForms.BunifuTextBox();
            this.Menu = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbpMedida.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMedidas)).BeginInit();
            this.MOMedidas.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpMedida
            // 
            this.tbpMedida.Controls.Add(this.metroTabPage1);
            this.tbpMedida.Controls.Add(this.metroTabPage2);
            this.tbpMedida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpMedida.Location = new System.Drawing.Point(0, 0);
            this.tbpMedida.Name = "tbpMedida";
            this.tbpMedida.SelectedIndex = 0;
            this.tbpMedida.Size = new System.Drawing.Size(823, 700);
            this.tbpMedida.TabIndex = 0;
            this.tbpMedida.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnAtras);
            this.metroTabPage1.Controls.Add(this.tbMedidas);
            this.metroTabPage1.Controls.Add(this.btnNuevaMedida);
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
            this.btnAtras.TabIndex = 18;
            this.btnAtras.TextOffsetX = 10;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // tbMedidas
            // 
            this.tbMedidas.AllowCustomTheming = true;
            this.tbMedidas.AllowUserToAddRows = false;
            this.tbMedidas.AllowUserToDeleteRows = false;
            this.tbMedidas.AllowUserToResizeColumns = false;
            this.tbMedidas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tbMedidas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbMedidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbMedidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMedidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbMedidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbMedidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tbMedidas.ColumnHeadersHeight = 40;
            this.tbMedidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tbMedidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMedida,
            this.NCortoMedida,
            this.NLargoMedida,
            this.btnEditarMed,
            this.btnEliminarMed});
            this.tbMedidas.ContextMenuStrip = this.MOMedidas;
            this.tbMedidas.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tbMedidas.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbMedidas.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbMedidas.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbMedidas.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tbMedidas.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tbMedidas.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbMedidas.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbMedidas.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tbMedidas.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tbMedidas.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.tbMedidas.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tbMedidas.CurrentTheme.Name = null;
            this.tbMedidas.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tbMedidas.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbMedidas.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbMedidas.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tbMedidas.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbMedidas.DefaultCellStyle = dataGridViewCellStyle3;
            this.tbMedidas.EnableHeadersVisualStyles = false;
            this.tbMedidas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tbMedidas.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbMedidas.HeaderBgColor = System.Drawing.Color.Empty;
            this.tbMedidas.HeaderForeColor = System.Drawing.Color.White;
            this.tbMedidas.Location = new System.Drawing.Point(51, 157);
            this.tbMedidas.MultiSelect = false;
            this.tbMedidas.Name = "tbMedidas";
            this.tbMedidas.ReadOnly = true;
            this.tbMedidas.RowHeadersVisible = false;
            this.tbMedidas.RowTemplate.Height = 40;
            this.tbMedidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbMedidas.Size = new System.Drawing.Size(712, 438);
            this.tbMedidas.TabIndex = 17;
            this.tbMedidas.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.tbMedidas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbMedidas_CellClick);
            this.tbMedidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbMedidas_CellContentClick);
            this.tbMedidas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbMedidas_MouseDown);
            // 
            // IdMedida
            // 
            this.IdMedida.HeaderText = "Id";
            this.IdMedida.Name = "IdMedida";
            this.IdMedida.ReadOnly = true;
            this.IdMedida.Visible = false;
            // 
            // NCortoMedida
            // 
            this.NCortoMedida.FillWeight = 118.8818F;
            this.NCortoMedida.HeaderText = "Nombre corto";
            this.NCortoMedida.Name = "NCortoMedida";
            this.NCortoMedida.ReadOnly = true;
            // 
            // NLargoMedida
            // 
            this.NLargoMedida.FillWeight = 118.8818F;
            this.NLargoMedida.HeaderText = "Nombre largo";
            this.NLargoMedida.Name = "NLargoMedida";
            this.NLargoMedida.ReadOnly = true;
            // 
            // btnEditarMed
            // 
            this.btnEditarMed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnEditarMed.FillWeight = 15F;
            this.btnEditarMed.HeaderText = "";
            this.btnEditarMed.Image = global::PresentacionGUI.Properties.Resources.edit;
            this.btnEditarMed.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnEditarMed.Name = "btnEditarMed";
            this.btnEditarMed.ReadOnly = true;
            this.btnEditarMed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnEliminarMed
            // 
            this.btnEliminarMed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnEliminarMed.FillWeight = 15F;
            this.btnEliminarMed.HeaderText = "";
            this.btnEliminarMed.Image = global::PresentacionGUI.Properties.Resources.cancel;
            this.btnEliminarMed.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnEliminarMed.Name = "btnEliminarMed";
            this.btnEliminarMed.ReadOnly = true;
            this.btnEliminarMed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MOMedidas
            // 
            this.MOMedidas.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MOMedidas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.MOMedidas.Name = "MenuOpciones";
            this.MOMedidas.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.MOMedidas.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.MOMedidas.RenderStyle.ColorTable = null;
            this.MOMedidas.RenderStyle.RoundedEdges = true;
            this.MOMedidas.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.MOMedidas.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MOMedidas.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MOMedidas.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.MOMedidas.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.MOMedidas.Size = new System.Drawing.Size(148, 68);
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
            // btnNuevaMedida
            // 
            this.btnNuevaMedida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNuevaMedida.Animated = true;
            this.btnNuevaMedida.AnimationHoverSpeed = 0.07F;
            this.btnNuevaMedida.AnimationSpeed = 0.03F;
            this.btnNuevaMedida.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevaMedida.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnNuevaMedida.BorderColor = System.Drawing.Color.Black;
            this.btnNuevaMedida.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNuevaMedida.FocusedColor = System.Drawing.Color.Empty;
            this.btnNuevaMedida.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaMedida.ForeColor = System.Drawing.Color.White;
            this.btnNuevaMedida.Image = global::PresentacionGUI.Properties.Resources.Registros;
            this.btnNuevaMedida.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNuevaMedida.Location = new System.Drawing.Point(299, 64);
            this.btnNuevaMedida.Name = "btnNuevaMedida";
            this.btnNuevaMedida.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(179)))));
            this.btnNuevaMedida.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNuevaMedida.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNuevaMedida.OnHoverImage = null;
            this.btnNuevaMedida.OnPressedColor = System.Drawing.Color.Black;
            this.btnNuevaMedida.Radius = 20;
            this.btnNuevaMedida.Size = new System.Drawing.Size(234, 62);
            this.btnNuevaMedida.TabIndex = 16;
            this.btnNuevaMedida.Text = "Nueva medida";
            this.btnNuevaMedida.TextOffsetX = 10;
            this.btnNuevaMedida.Click += new System.EventHandler(this.btnNuevaMedida_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.lbNuevaMedida);
            this.metroTabPage2.Controls.Add(this.btnIngresar);
            this.metroTabPage2.Controls.Add(this.txtNLargo);
            this.metroTabPage2.Controls.Add(this.txtNombreCorto);
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
            // lbNuevaMedida
            // 
            this.lbNuevaMedida.AllowParentOverrides = false;
            this.lbNuevaMedida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNuevaMedida.AutoEllipsis = false;
            this.lbNuevaMedida.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbNuevaMedida.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbNuevaMedida.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuevaMedida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.lbNuevaMedida.Location = new System.Drawing.Point(319, 174);
            this.lbNuevaMedida.Name = "lbNuevaMedida";
            this.lbNuevaMedida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbNuevaMedida.Size = new System.Drawing.Size(177, 42);
            this.lbNuevaMedida.TabIndex = 24;
            this.lbNuevaMedida.Text = "Nueva Medida";
            this.lbNuevaMedida.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbNuevaMedida.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Animated = true;
            this.btnIngresar.AnimationHoverSpeed = 0.07F;
            this.btnIngresar.AnimationSpeed = 0.03F;
            this.btnIngresar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnIngresar.BorderColor = System.Drawing.Color.Black;
            this.btnIngresar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIngresar.FocusedColor = System.Drawing.Color.Empty;
            this.btnIngresar.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Image = null;
            this.btnIngresar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnIngresar.Location = new System.Drawing.Point(327, 442);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnIngresar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIngresar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnIngresar.OnHoverImage = null;
            this.btnIngresar.OnPressedColor = System.Drawing.Color.Black;
            this.btnIngresar.Size = new System.Drawing.Size(160, 42);
            this.btnIngresar.TabIndex = 23;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtNLargo
            // 
            this.txtNLargo.AcceptsReturn = false;
            this.txtNLargo.AcceptsTab = false;
            this.txtNLargo.AnimationSpeed = 200;
            this.txtNLargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNLargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNLargo.BackColor = System.Drawing.SystemColors.Window;
            this.txtNLargo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNLargo.BackgroundImage")));
            this.txtNLargo.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtNLargo.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNLargo.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtNLargo.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtNLargo.BorderRadius = 5;
            this.txtNLargo.BorderThickness = 2;
            this.txtNLargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNLargo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNLargo.DefaultFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNLargo.DefaultText = "";
            this.txtNLargo.FillColor = System.Drawing.SystemColors.Window;
            this.txtNLargo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNLargo.HideSelection = true;
            this.txtNLargo.IconLeft = null;
            this.txtNLargo.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNLargo.IconPadding = 10;
            this.txtNLargo.IconRight = null;
            this.txtNLargo.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNLargo.Lines = new string[0];
            this.txtNLargo.Location = new System.Drawing.Point(277, 335);
            this.txtNLargo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNLargo.MaxLength = 32767;
            this.txtNLargo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNLargo.Modified = false;
            this.txtNLargo.Multiline = false;
            this.txtNLargo.Name = "txtNLargo";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNLargo.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNLargo.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNLargo.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties4.FillColor = System.Drawing.SystemColors.Window;
            stateProperties4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNLargo.OnIdleState = stateProperties4;
            this.txtNLargo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNLargo.PasswordChar = '\0';
            this.txtNLargo.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNLargo.PlaceholderText = "Nombre largo";
            this.txtNLargo.ReadOnly = false;
            this.txtNLargo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNLargo.SelectedText = "";
            this.txtNLargo.SelectionLength = 0;
            this.txtNLargo.SelectionStart = 0;
            this.txtNLargo.ShortcutsEnabled = true;
            this.txtNLargo.Size = new System.Drawing.Size(260, 51);
            this.txtNLargo.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtNLargo.TabIndex = 25;
            this.txtNLargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNLargo.TextMarginBottom = 0;
            this.txtNLargo.TextMarginLeft = 3;
            this.txtNLargo.TextMarginTop = 0;
            this.txtNLargo.TextPlaceholder = "Nombre largo";
            this.txtNLargo.UseSystemPasswordChar = false;
            this.txtNLargo.WordWrap = true;
            // 
            // txtNombreCorto
            // 
            this.txtNombreCorto.AcceptsReturn = false;
            this.txtNombreCorto.AcceptsTab = false;
            this.txtNombreCorto.AnimationSpeed = 200;
            this.txtNombreCorto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombreCorto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombreCorto.BackColor = System.Drawing.Color.White;
            this.txtNombreCorto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNombreCorto.BackgroundImage")));
            this.txtNombreCorto.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtNombreCorto.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNombreCorto.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtNombreCorto.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtNombreCorto.BorderRadius = 5;
            this.txtNombreCorto.BorderThickness = 2;
            this.txtNombreCorto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreCorto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCorto.DefaultFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCorto.DefaultText = "";
            this.txtNombreCorto.FillColor = System.Drawing.Color.White;
            this.txtNombreCorto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombreCorto.HideSelection = true;
            this.txtNombreCorto.IconLeft = null;
            this.txtNombreCorto.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCorto.IconPadding = 10;
            this.txtNombreCorto.IconRight = null;
            this.txtNombreCorto.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCorto.Lines = new string[0];
            this.txtNombreCorto.Location = new System.Drawing.Point(277, 260);
            this.txtNombreCorto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreCorto.MaxLength = 32767;
            this.txtNombreCorto.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNombreCorto.Modified = false;
            this.txtNombreCorto.Multiline = false;
            this.txtNombreCorto.Name = "txtNombreCorto";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombreCorto.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNombreCorto.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombreCorto.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombreCorto.OnIdleState = stateProperties8;
            this.txtNombreCorto.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreCorto.PasswordChar = '\0';
            this.txtNombreCorto.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNombreCorto.PlaceholderText = "Nombre corto";
            this.txtNombreCorto.ReadOnly = false;
            this.txtNombreCorto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreCorto.SelectedText = "";
            this.txtNombreCorto.SelectionLength = 0;
            this.txtNombreCorto.SelectionStart = 0;
            this.txtNombreCorto.ShortcutsEnabled = true;
            this.txtNombreCorto.Size = new System.Drawing.Size(260, 51);
            this.txtNombreCorto.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtNombreCorto.TabIndex = 22;
            this.txtNombreCorto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreCorto.TextMarginBottom = 0;
            this.txtNombreCorto.TextMarginLeft = 3;
            this.txtNombreCorto.TextMarginTop = 0;
            this.txtNombreCorto.TextPlaceholder = "Nombre corto";
            this.txtNombreCorto.UseSystemPasswordChar = false;
            this.txtNombreCorto.WordWrap = true;
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
            this.dataGridViewImageColumn1.FillWeight = 14.2132F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::PresentacionGUI.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 25;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 16.88978F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::PresentacionGUI.Properties.Resources.cancel;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 47);
            this.panel1.TabIndex = 2;
            // 
            // MedidaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbpMedida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedidaGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Medida";
            this.tbpMedida.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbMedidas)).EndInit();
            this.MOMedidas.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tbpMedida;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private Bunifu.UI.WinForms.BunifuDataGridView tbMedidas;
        private Guna.UI.WinForms.GunaButton btnNuevaMedida;
        private Bunifu.UI.WinForms.BunifuLabel lbNuevaMedida;
        private Guna.UI.WinForms.GunaButton btnIngresar;
        private Bunifu.UI.WinForms.BunifuTextBox txtNLargo;
        private Bunifu.UI.WinForms.BunifuTextBox txtNombreCorto;
        private Guna.UI.WinForms.GunaContextMenuStrip MOMedidas;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private Bunifu.UI.WinForms.BunifuSnackbar Menu;
        private Guna.UI.WinForms.GunaButton btnAtras;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCortoMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn NLargoMedida;
        private System.Windows.Forms.DataGridViewImageColumn btnEditarMed;
        private System.Windows.Forms.DataGridViewImageColumn btnEliminarMed;
        private System.Windows.Forms.Panel panel1;
    }
}