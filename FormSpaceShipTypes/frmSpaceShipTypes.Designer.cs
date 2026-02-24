
namespace FormSpaceShipTypes
{
    partial class frmSpaceShipTypes
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
            this.cbSpaceShipCategory = new System.Windows.Forms.ComboBox();
            this.cbFilliations = new System.Windows.Forms.ComboBox();
            this.txtcodeSpaceShipType = new System.Windows.Forms.TextBox();
            this.txtDescSpaceShipType = new System.Windows.Forms.TextBox();
            this.logsTimer = new System.Windows.Forms.Timer(this.components);
            this.lblPriority = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // cbSpaceShipCategory
            // 
            this.cbSpaceShipCategory.FormattingEnabled = true;
            this.cbSpaceShipCategory.Location = new System.Drawing.Point(206, 312);
            this.cbSpaceShipCategory.Name = "cbSpaceShipCategory";
            this.cbSpaceShipCategory.Size = new System.Drawing.Size(409, 31);
            this.cbSpaceShipCategory.TabIndex = 9;
            this.cbSpaceShipCategory.Tag = "idSpaceShipCategory";
            // 
            // cbFilliations
            // 
            this.cbFilliations.FormattingEnabled = true;
            this.cbFilliations.Location = new System.Drawing.Point(206, 265);
            this.cbFilliations.Name = "cbFilliations";
            this.cbFilliations.Size = new System.Drawing.Size(409, 31);
            this.cbFilliations.TabIndex = 8;
            this.cbFilliations.Tag = "idFiliation";
            // 
            // txtcodeSpaceShipType
            // 
            this.txtcodeSpaceShipType.Location = new System.Drawing.Point(206, 173);
            this.txtcodeSpaceShipType.Name = "txtcodeSpaceShipType";
            this.txtcodeSpaceShipType.Size = new System.Drawing.Size(409, 31);
            this.txtcodeSpaceShipType.TabIndex = 6;
            this.txtcodeSpaceShipType.Tag = "CodeSpaceShipType";
            // 
            // txtDescSpaceShipType
            // 
            this.txtDescSpaceShipType.Location = new System.Drawing.Point(206, 218);
            this.txtDescSpaceShipType.Name = "txtDescSpaceShipType";
            this.txtDescSpaceShipType.Size = new System.Drawing.Size(409, 31);
            this.txtDescSpaceShipType.TabIndex = 7;
            this.txtDescSpaceShipType.Tag = "DescSpaceShipType";
            // 
            // logsTimer
            // 
            this.logsTimer.Interval = 2000;
            this.logsTimer.Tick += new System.EventHandler(this.logsTimer_Tick);
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(138, 181);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(62, 23);
            this.lblPriority.TabIndex = 10;
            this.lblPriority.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filiation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Category";
            // 
            // frmSpaceShipTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.ClientSize = new System.Drawing.Size(1513, 968);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.cbSpaceShipCategory);
            this.Controls.Add(this.cbFilliations);
            this.Controls.Add(this.txtcodeSpaceShipType);
            this.Controls.Add(this.txtDescSpaceShipType);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmSpaceShipTypes";
            this.Load += new System.EventHandler(this.frmSpaceShipTypes_Load);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnCreate, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblLog, 0);
            this.Controls.SetChildIndex(this.txtDescSpaceShipType, 0);
            this.Controls.SetChildIndex(this.txtcodeSpaceShipType, 0);
            this.Controls.SetChildIndex(this.cbFilliations, 0);
            this.Controls.SetChildIndex(this.cbSpaceShipCategory, 0);
            this.Controls.SetChildIndex(this.lblPriority, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSpaceShipCategory;
        private System.Windows.Forms.ComboBox cbFilliations;
        private System.Windows.Forms.TextBox txtcodeSpaceShipType;
        private System.Windows.Forms.TextBox txtDescSpaceShipType;
        private System.Windows.Forms.Timer logsTimer;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
