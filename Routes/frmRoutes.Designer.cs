
namespace Routes
{
    partial class frmRoutes
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
            this.components = new System.ComponentModel.Container();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.cmbOrigin = new System.Windows.Forms.ComboBox();
            this.txtDestinationPlanet = new System.Windows.Forms.TextBox();
            this.txtOriginPlanet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCodeRuta = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDestinationPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOriginPort = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.logsTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1448, 370);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(1312, 370);
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "";
            // 
            // lblLog
            // 
            this.lblLog.Location = new System.Drawing.Point(527, 377);
            // 
            // cmbDestination
            // 
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Location = new System.Drawing.Point(257, 302);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(143, 32);
            this.cmbDestination.TabIndex = 46;
            this.cmbDestination.Tag = "idPlanetDest";
            this.cmbDestination.SelectedIndexChanged += new System.EventHandler(this.cmbDestination_SelectedIndexChanged);
            // 
            // cmbOrigin
            // 
            this.cmbOrigin.FormattingEnabled = true;
            this.cmbOrigin.Location = new System.Drawing.Point(257, 247);
            this.cmbOrigin.Name = "cmbOrigin";
            this.cmbOrigin.Size = new System.Drawing.Size(143, 32);
            this.cmbOrigin.TabIndex = 45;
            this.cmbOrigin.Tag = "idPlanetOr";
            this.cmbOrigin.SelectedIndexChanged += new System.EventHandler(this.cmbOrigin_SelectedIndexChanged);
            // 
            // txtDestinationPlanet
            // 
            this.txtDestinationPlanet.Location = new System.Drawing.Point(425, 305);
            this.txtDestinationPlanet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDestinationPlanet.MaxLength = 12;
            this.txtDestinationPlanet.Name = "txtDestinationPlanet";
            this.txtDestinationPlanet.ReadOnly = true;
            this.txtDestinationPlanet.Size = new System.Drawing.Size(305, 29);
            this.txtDestinationPlanet.TabIndex = 44;
            this.txtDestinationPlanet.Tag = ".DescPlanet";
            // 
            // txtOriginPlanet
            // 
            this.txtOriginPlanet.Location = new System.Drawing.Point(425, 250);
            this.txtOriginPlanet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOriginPlanet.MaxLength = 12;
            this.txtOriginPlanet.Name = "txtOriginPlanet";
            this.txtOriginPlanet.ReadOnly = true;
            this.txtOriginPlanet.Size = new System.Drawing.Size(305, 29);
            this.txtOriginPlanet.TabIndex = 43;
            this.txtOriginPlanet.Tag = ".DescPlanet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(113, 303);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Destination ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(161, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Origin ";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDesc.Location = new System.Drawing.Point(113, 195);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(115, 24);
            this.lblDesc.TabIndex = 40;
            this.lblDesc.Text = "Description";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCode.Location = new System.Drawing.Point(169, 143);
            this.lblCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(60, 24);
            this.lblCode.TabIndex = 39;
            this.lblCode.Text = "Code";
            // 
            // txtCodeRuta
            // 
            this.txtCodeRuta.Location = new System.Drawing.Point(257, 140);
            this.txtCodeRuta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodeRuta.MaxLength = 12;
            this.txtCodeRuta.Name = "txtCodeRuta";
            this.txtCodeRuta.Size = new System.Drawing.Size(183, 29);
            this.txtCodeRuta.TabIndex = 38;
            this.txtCodeRuta.Tag = "Code";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(257, 192);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(430, 29);
            this.txtDesc.TabIndex = 37;
            this.txtDesc.Tag = "Description";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(861, 135);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 32);
            this.cmbType.TabIndex = 53;
            this.cmbType.Tag = "idRouteType";
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(792, 305);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "Port";
            // 
            // txtDestinationPort
            // 
            this.txtDestinationPort.Location = new System.Drawing.Point(857, 298);
            this.txtDestinationPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDestinationPort.Name = "txtDestinationPort";
            this.txtDestinationPort.ReadOnly = true;
            this.txtDestinationPort.Size = new System.Drawing.Size(128, 29);
            this.txtDestinationPort.TabIndex = 51;
            this.txtDestinationPort.Tag = ".PortPlanet1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(792, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Port";
            // 
            // txtOriginPort
            // 
            this.txtOriginPort.Location = new System.Drawing.Point(857, 245);
            this.txtOriginPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOriginPort.Name = "txtOriginPort";
            this.txtOriginPort.ReadOnly = true;
            this.txtOriginPort.Size = new System.Drawing.Size(128, 29);
            this.txtOriginPort.TabIndex = 49;
            this.txtOriginPort.Tag = ".PortPlanet";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRemarks.Location = new System.Drawing.Point(776, 138);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(63, 24);
            this.lblRemarks.TabIndex = 48;
            this.lblRemarks.Text = "Type ";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(1002, 138);
            this.txtType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtType.MaxLength = 12;
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(242, 29);
            this.txtType.TabIndex = 47;
            this.txtType.Tag = ".DescRouteType";
            // 
            // logsTimer
            // 
            this.logsTimer.Interval = 2000;
            this.logsTimer.Tick += new System.EventHandler(this.logsTimer_Tick);
            // 
            // frmRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 941);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDestinationPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOriginPort);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.cmbDestination);
            this.Controls.Add(this.cmbOrigin);
            this.Controls.Add(this.txtDestinationPlanet);
            this.Controls.Add(this.txtOriginPlanet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtCodeRuta);
            this.Controls.Add(this.txtDesc);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmRoutes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmRoutes_Load);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnCreate, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblLog, 0);
            this.Controls.SetChildIndex(this.txtDesc, 0);
            this.Controls.SetChildIndex(this.txtCodeRuta, 0);
            this.Controls.SetChildIndex(this.lblCode, 0);
            this.Controls.SetChildIndex(this.lblDesc, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtOriginPlanet, 0);
            this.Controls.SetChildIndex(this.txtDestinationPlanet, 0);
            this.Controls.SetChildIndex(this.cmbOrigin, 0);
            this.Controls.SetChildIndex(this.cmbDestination, 0);
            this.Controls.SetChildIndex(this.txtType, 0);
            this.Controls.SetChildIndex(this.lblRemarks, 0);
            this.Controls.SetChildIndex(this.txtOriginPort, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtDestinationPort, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cmbType, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.ComboBox cmbOrigin;
        private System.Windows.Forms.TextBox txtDestinationPlanet;
        private System.Windows.Forms.TextBox txtOriginPlanet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCodeRuta;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDestinationPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOriginPort;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Timer logsTimer;
    }
}

