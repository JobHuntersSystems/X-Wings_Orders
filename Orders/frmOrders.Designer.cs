
namespace Orders
{
    partial class frmOrders
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
            this.lblCodeOrder = new System.Windows.Forms.Label();
            this.txtCodeOrder = new System.Windows.Forms.TextBox();
            this.txtDateOrder = new System.Windows.Forms.TextBox();
            this.lblDateOrder = new System.Windows.Forms.Label();
            this.txtFactory = new System.Windows.Forms.TextBox();
            this.lblFactory = new System.Windows.Forms.Label();
            this.txtPriority = new System.Windows.Forms.TextBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.cmbFactory = new System.Windows.Forms.ComboBox();
            this.logsTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "";
            // 
            // lblCodeOrder
            // 
            this.lblCodeOrder.AutoSize = true;
            this.lblCodeOrder.Location = new System.Drawing.Point(113, 126);
            this.lblCodeOrder.Name = "lblCodeOrder";
            this.lblCodeOrder.Size = new System.Drawing.Size(60, 24);
            this.lblCodeOrder.TabIndex = 5;
            this.lblCodeOrder.Text = "Code";
            // 
            // txtCodeOrder
            // 
            this.txtCodeOrder.Location = new System.Drawing.Point(199, 126);
            this.txtCodeOrder.Name = "txtCodeOrder";
            this.txtCodeOrder.Size = new System.Drawing.Size(275, 29);
            this.txtCodeOrder.TabIndex = 6;
            this.txtCodeOrder.Tag = "codeOrder";
            // 
            // txtDateOrder
            // 
            this.txtDateOrder.Location = new System.Drawing.Point(199, 195);
            this.txtDateOrder.Name = "txtDateOrder";
            this.txtDateOrder.Size = new System.Drawing.Size(275, 29);
            this.txtDateOrder.TabIndex = 8;
            this.txtDateOrder.Tag = "dateOrder";
            // 
            // lblDateOrder
            // 
            this.lblDateOrder.AutoSize = true;
            this.lblDateOrder.Location = new System.Drawing.Point(121, 198);
            this.lblDateOrder.Name = "lblDateOrder";
            this.lblDateOrder.Size = new System.Drawing.Size(52, 24);
            this.lblDateOrder.TabIndex = 7;
            this.lblDateOrder.Text = "Date";
            // 
            // txtFactory
            // 
            this.txtFactory.Location = new System.Drawing.Point(491, 332);
            this.txtFactory.Name = "txtFactory";
            this.txtFactory.Size = new System.Drawing.Size(378, 29);
            this.txtFactory.TabIndex = 12;
            this.txtFactory.Tag = "cmbFactory.idFactory";
            // 
            // lblFactory
            // 
            this.lblFactory.AutoSize = true;
            this.lblFactory.Location = new System.Drawing.Point(94, 335);
            this.lblFactory.Name = "lblFactory";
            this.lblFactory.Size = new System.Drawing.Size(79, 24);
            this.lblFactory.TabIndex = 11;
            this.lblFactory.Text = "Factory";
            // 
            // txtPriority
            // 
            this.txtPriority.Location = new System.Drawing.Point(367, 263);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(275, 29);
            this.txtPriority.TabIndex = 10;
            this.txtPriority.Tag = "cmbPriority.idPriority";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(99, 266);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(74, 24);
            this.lblPriority.TabIndex = 9;
            this.lblPriority.Text = "Priority";
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(199, 261);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(151, 32);
            this.cmbPriority.TabIndex = 13;
            this.cmbPriority.Tag = "Priority.IdPriority";
            // 
            // cmbFactory
            // 
            this.cmbFactory.FormattingEnabled = true;
            this.cmbFactory.Location = new System.Drawing.Point(199, 330);
            this.cmbFactory.Name = "cmbFactory";
            this.cmbFactory.Size = new System.Drawing.Size(275, 32);
            this.cmbFactory.TabIndex = 14;
            this.cmbFactory.Tag = "Factories.IdFactory";
            // 
            // logsTimer
            // 
            this.logsTimer.Interval = 2000;
            this.logsTimer.Tick += new System.EventHandler(this.logsTimer_Tick);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.ClientSize = new System.Drawing.Size(1650, 1010);
            this.Controls.Add(this.cmbFactory);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.txtFactory);
            this.Controls.Add(this.lblFactory);
            this.Controls.Add(this.txtPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.txtDateOrder);
            this.Controls.Add(this.lblDateOrder);
            this.Controls.Add(this.txtCodeOrder);
            this.Controls.Add(this.lblCodeOrder);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmOrders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnCreate, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblLog, 0);
            this.Controls.SetChildIndex(this.lblCodeOrder, 0);
            this.Controls.SetChildIndex(this.txtCodeOrder, 0);
            this.Controls.SetChildIndex(this.lblDateOrder, 0);
            this.Controls.SetChildIndex(this.txtDateOrder, 0);
            this.Controls.SetChildIndex(this.lblPriority, 0);
            this.Controls.SetChildIndex(this.txtPriority, 0);
            this.Controls.SetChildIndex(this.lblFactory, 0);
            this.Controls.SetChildIndex(this.txtFactory, 0);
            this.Controls.SetChildIndex(this.cmbPriority, 0);
            this.Controls.SetChildIndex(this.cmbFactory, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeOrder;
        private System.Windows.Forms.TextBox txtCodeOrder;
        private System.Windows.Forms.TextBox txtDateOrder;
        private System.Windows.Forms.Label lblDateOrder;
        private System.Windows.Forms.TextBox txtFactory;
        private System.Windows.Forms.Label lblFactory;
        private System.Windows.Forms.TextBox txtPriority;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.ComboBox cmbFactory;
        private System.Windows.Forms.Timer logsTimer;
    }
}
