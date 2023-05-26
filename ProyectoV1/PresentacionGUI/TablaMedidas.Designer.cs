namespace PresentacionGUI
{
    partial class TablaMedidas
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbMedidas = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.medidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medidasTableAdapter = new PresentacionGUI.FabricaDBDataSetTableAdapters.MedidasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbMedidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidasBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tbMedidas.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.tbMedidas.Location = new System.Drawing.Point(3, 3);
            this.tbMedidas.MultiSelect = false;
            this.tbMedidas.Name = "tbMedidas";
            this.tbMedidas.RowHeadersVisible = false;
            this.tbMedidas.RowTemplate.Height = 40;
            this.tbMedidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbMedidas.Size = new System.Drawing.Size(712, 438);
            this.tbMedidas.TabIndex = 0;
            this.tbMedidas.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.tbMedidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellContentClick);
            // 
            // medidasTableAdapter
            // 
            this.medidasTableAdapter.ClearBeforeFill = true;
            // 
            // TablaMedidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tbMedidas);
            this.Location = new System.Drawing.Point(65, 95);
            this.Name = "TablaMedidas";
            this.Size = new System.Drawing.Size(718, 444);
            ((System.ComponentModel.ISupportInitialize)(this.tbMedidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView tbMedidas;
        private System.Windows.Forms.BindingSource medidasBindingSource;
        private FabricaDBDataSetTableAdapters.MedidasTableAdapter medidasTableAdapter;
    }
}
