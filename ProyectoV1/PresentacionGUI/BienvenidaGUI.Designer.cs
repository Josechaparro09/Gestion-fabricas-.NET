namespace PresentacionGUI
{
    partial class BienvenidaGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BienvenidaGUI));
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblUsuario = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::PresentacionGUI.Properties.Resources.Logo;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 40;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(404, 473);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(444, 513);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(186, 47);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = false;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(444, 513);
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 40;
            this.bunifuImageButton1.ZoomSpeed = 10;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AllowParentOverrides = false;
            this.lblUsuario.AutoEllipsis = false;
            this.lblUsuario.AutoSize = false;
            this.lblUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUsuario.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblUsuario.EllipsisFormat = Bunifu.UI.WinForms.Ellipsis.EllipsisFormat.None;
            this.lblUsuario.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.lblUsuario.Location = new System.Drawing.Point(3, 566);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUsuario.Size = new System.Drawing.Size(823, 71);
            this.lblUsuario.TabIndex = 51;
            this.lblUsuario.Text = "Bienvenid@";
            this.lblUsuario.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsuario.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BienvenidaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(823, 700);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.bunifuImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BienvenidaGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BienvenidaGUI";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuLabel lblUsuario;
    }
}