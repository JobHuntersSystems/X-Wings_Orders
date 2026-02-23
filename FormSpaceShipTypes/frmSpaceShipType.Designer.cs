
namespace FormSpaceShipTypes
{
    partial class frmSpaceShipType
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
            this.txtcodeSpaceShipType = new System.Windows.Forms.TextBox();
            this.txtDescSpaceShipType = new System.Windows.Forms.TextBox();
            this.pnlData = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dvgSpaceShip = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFilliations = new System.Windows.Forms.ComboBox();
            this.cbSpaceShipCategory = new System.Windows.Forms.ComboBox();
            this.pnlData.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSpaceShip)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcodeSpaceShipType
            // 
            this.txtcodeSpaceShipType.Location = new System.Drawing.Point(149, 53);
            this.txtcodeSpaceShipType.Name = "txtcodeSpaceShipType";
            this.txtcodeSpaceShipType.Size = new System.Drawing.Size(446, 20);
            this.txtcodeSpaceShipType.TabIndex = 0;
            this.txtcodeSpaceShipType.Tag = "CodeSpaceShipType";
            // 
            // txtDescSpaceShipType
            // 
            this.txtDescSpaceShipType.Location = new System.Drawing.Point(149, 79);
            this.txtDescSpaceShipType.Name = "txtDescSpaceShipType";
            this.txtDescSpaceShipType.Size = new System.Drawing.Size(446, 20);
            this.txtDescSpaceShipType.TabIndex = 1;
            this.txtDescSpaceShipType.Tag = "DescSpaceShipType";
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.cbSpaceShipCategory);
            this.pnlData.Controls.Add(this.cbFilliations);
            this.pnlData.Controls.Add(this.txtcodeSpaceShipType);
            this.pnlData.Controls.Add(this.txtDescSpaceShipType);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(1277, 166);
            this.pnlData.TabIndex = 4;
            this.pnlData.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlData_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 166);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(1277, 477);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnCreate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1237, 30);
            this.panel3.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(531, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(355, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Save Changes";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(179, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(3, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(155, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dvgSpaceShip
            // 
            this.dvgSpaceShip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSpaceShip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgSpaceShip.Location = new System.Drawing.Point(0, 0);
            this.dvgSpaceShip.Name = "dvgSpaceShip";
            this.dvgSpaceShip.Size = new System.Drawing.Size(1237, 407);
            this.dvgSpaceShip.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dvgSpaceShip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 407);
            this.panel1.TabIndex = 2;
            // 
            // cbFilliations
            // 
            this.cbFilliations.FormattingEnabled = true;
            this.cbFilliations.Location = new System.Drawing.Point(149, 105);
            this.cbFilliations.Name = "cbFilliations";
            this.cbFilliations.Size = new System.Drawing.Size(446, 21);
            this.cbFilliations.TabIndex = 4;
            this.cbFilliations.Tag = "idFiliation";
            // 
            // cbSpaceShipCategory
            // 
            this.cbSpaceShipCategory.FormattingEnabled = true;
            this.cbSpaceShipCategory.Location = new System.Drawing.Point(149, 130);
            this.cbSpaceShipCategory.Name = "cbSpaceShipCategory";
            this.cbSpaceShipCategory.Size = new System.Drawing.Size(446, 21);
            this.cbSpaceShipCategory.TabIndex = 5;
            this.cbSpaceShipCategory.Tag = "idSpaceShipCategory";
            // 
            // frmSpaceShipType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 643);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlData);
            this.Name = "frmSpaceShipType";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSpaceShipType_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgSpaceShip)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodeSpaceShipType;
        private System.Windows.Forms.TextBox txtDescSpaceShipType;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dvgSpaceShip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSpaceShipCategory;
        private System.Windows.Forms.ComboBox cbFilliations;
    }
}

