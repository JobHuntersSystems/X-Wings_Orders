
namespace FormsProcessEDI
{
    partial class frmProcessEDI
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
        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.xwCloseButton = new XWInheritedControls.XWCloseButton();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOpenCristal = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xwCloseButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(404, 67);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(1482, 41);
            this.txtPath.TabIndex = 1;
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbStatus.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.lbStatus.FormattingEnabled = true;
            this.lbStatus.ItemHeight = 32;
            this.lbStatus.Location = new System.Drawing.Point(27, 25);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(852, 362);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.SelectedIndexChanged += new System.EventHandler(this.lbStatus_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlTop);
            this.panel1.Controls.Add(this.btnProcess);
            this.panel1.Controls.Add(this.btnSelectPath);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 199);
            this.panel1.TabIndex = 6;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnlTop.Controls.Add(this.xwCloseButton);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1924, 40);
            this.pnlTop.TabIndex = 7;
            // 
            // xwCloseButton
            // 
            this.xwCloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.xwCloseButton.HoverIconPath = "resources\\png\\CloseButtonShinyYellow.png";
            this.xwCloseButton.ImageLocation = "C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Community\\Common7\\IDE\\resourc" +
    "es\\png\\CloseButtonYellow.png";
            this.xwCloseButton.Location = new System.Drawing.Point(1884, 0);
            this.xwCloseButton.MainIconPath = "resources\\png\\CloseButtonYellow.png";
            this.xwCloseButton.Name = "xwCloseButton";
            this.xwCloseButton.Size = new System.Drawing.Size(40, 40);
            this.xwCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xwCloseButton.TabIndex = 1;
            this.xwCloseButton.TabStop = false;
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProcess.Location = new System.Drawing.Point(27, 140);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(6);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(345, 40);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Process EDI";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelectPath.Location = new System.Drawing.Point(27, 69);
            this.btnSelectPath.Margin = new System.Windows.Forms.Padding(6);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(345, 40);
            this.btnSelectPath.TabIndex = 5;
            this.btnSelectPath.Text = "Select EDI";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.lbStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panel2.Size = new System.Drawing.Size(1924, 412);
            this.panel2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(911, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(986, 362);
            this.textBox1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(879, 25);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(32, 362);
            this.panel5.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnOpenCristal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 611);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1924, 116);
            this.panel3.TabIndex = 8;
            // 
            // btnOpenCristal
            // 
            this.btnOpenCristal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCristal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOpenCristal.Location = new System.Drawing.Point(27, 28);
            this.btnOpenCristal.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenCristal.Name = "btnOpenCristal";
            this.btnOpenCristal.Size = new System.Drawing.Size(345, 40);
            this.btnOpenCristal.TabIndex = 8;
            this.btnOpenCristal.Text = "Process EDI";
            this.btnOpenCristal.UseVisualStyleBackColor = true;
            this.btnOpenCristal.Click += new System.EventHandler(this.btnOpenCristal_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 199);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1924, 412);
            this.panel4.TabIndex = 9;
            // 
            // frmProcessEDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1924, 727);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProcessEDI";
            this.Text = "frmEDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xwCloseButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ListBox lbStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        protected System.Windows.Forms.Button btnSelectPath;
        protected System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Panel pnlTop;
        protected System.Windows.Forms.Button btnOpenCristal;
        private XWInheritedControls.XWCloseButton xwCloseButton;
    }
}

