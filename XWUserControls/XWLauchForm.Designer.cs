namespace XWUserControls
{ 
    partial class XWLauchForm
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
            this.lblOptionName = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pctOptionIcon = new System.Windows.Forms.PictureBox();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctOptionIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOptionName
            // 
            this.lblOptionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblOptionName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionName.Location = new System.Drawing.Point(0, 190);
            this.lblOptionName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOptionName.Name = "lblOptionName";
            this.lblOptionName.Size = new System.Drawing.Size(225, 33);
            this.lblOptionName.TabIndex = 0;
            this.lblOptionName.Text = "Options";
            this.lblOptionName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pctOptionIcon);
            this.pnlMain.Controls.Add(this.lblOptionName);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(225, 225);
            this.pnlMain.TabIndex = 1;
            // 
            // pctOptionIcon
            // 
            this.pctOptionIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pctOptionIcon.ImageLocation = "";
            this.pctOptionIcon.Location = new System.Drawing.Point(23, 27);
            this.pctOptionIcon.Name = "pctOptionIcon";
            this.pctOptionIcon.Size = new System.Drawing.Size(177, 162);
            this.pctOptionIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctOptionIcon.TabIndex = 1;
            this.pctOptionIcon.TabStop = false;
            // 
            // XWLauchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XWLauchForm";
            this.Size = new System.Drawing.Size(225, 225);
            this.Load += new System.EventHandler(this.XWLauchForm_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctOptionIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOptionName;
        private System.Windows.Forms.Panel pnlMain;
        internal System.Windows.Forms.PictureBox pctOptionIcon;
    }
}
