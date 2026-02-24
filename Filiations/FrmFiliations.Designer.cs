
namespace Filiations
{
	partial class FrmFiliations
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
			this.lblCode = new System.Windows.Forms.Label();
			this.lblDesc = new System.Windows.Forms.Label();
			this.LogsTimer = new System.Windows.Forms.Timer();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(1278, 468);
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(1101, 468);
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.Location = new System.Drawing.Point(511, 66);
			this.lblTitle.Size = new System.Drawing.Size(433, 50);
			this.lblTitle.Text = "";
			// 
			// lblLog
			// 
			this.lblLog.Location = new System.Drawing.Point(134, 468);
			// 
			// lblCode
			// 
			this.lblCode.AutoSize = true;
			this.lblCode.Location = new System.Drawing.Point(233, 311);
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size(77, 28);
			this.lblCode.TabIndex = 6;
			this.lblCode.Text = "Code";
			// 
			// lblDesc
			// 
			this.lblDesc.AutoSize = true;
			this.lblDesc.Location = new System.Drawing.Point(168, 375);
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.Size = new System.Drawing.Size(142, 28);
			this.lblDesc.TabIndex = 7;
			this.lblDesc.Text = "Description";
			// 
			// LogsTimer
			// 
			this.LogsTimer.Tick += new System.EventHandler(this.LogsTimer_Tick);
			// 
			// txtDesc
			// 
			this.txtDesc.Location = new System.Drawing.Point(379, 372);
			this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.txtDesc.MaxLength = 100;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(508, 37);
			this.txtDesc.TabIndex = 14;
			this.txtDesc.Tag = "DescFiliations";
			// 
			// txtCode
			// 
			this.txtCode.Location = new System.Drawing.Point(379, 302);
			this.txtCode.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.txtCode.MaxLength = 12;
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(271, 37);
			this.txtCode.TabIndex = 15;
			this.txtCode.Tag = "CodeFiliation";
			// 
			// FrmFiliations
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1452, 898);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.txtDesc);
			this.Controls.Add(this.lblDesc);
			this.Controls.Add(this.lblCode);
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "FrmFiliations";
			this.Text = "FrmFiliations";
			this.Load += new System.EventHandler(this.FrmFiliations_Load);
			this.Controls.SetChildIndex(this.btnUpdate, 0);
			this.Controls.SetChildIndex(this.btnCreate, 0);
			this.Controls.SetChildIndex(this.lblTitle, 0);
			this.Controls.SetChildIndex(this.lblLog, 0);
			this.Controls.SetChildIndex(this.lblCode, 0);
			this.Controls.SetChildIndex(this.lblDesc, 0);
			this.Controls.SetChildIndex(this.txtDesc, 0);
			this.Controls.SetChildIndex(this.txtCode, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCode;
		private System.Windows.Forms.Label lblDesc;
		private System.Windows.Forms.Timer LogsTimer;
		private System.Windows.Forms.TextBox txtDesc;
		private System.Windows.Forms.TextBox txtCode;
	}
}