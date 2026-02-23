
namespace Filliations
{
	partial class frmFilliations
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
			this.lblCode = new System.Windows.Forms.Label();
			this.lblDesc = new System.Windows.Forms.Label();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.logsTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(1422, 442);
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(1286, 442);
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.Size = new System.Drawing.Size(600, 33);
			this.lblTitle.Text = "";
			// 
			// lblLog
			// 
			this.lblLog.Location = new System.Drawing.Point(468, 445);
			// 
			// lblCode
			// 
			this.lblCode.AutoSize = true;
			this.lblCode.Location = new System.Drawing.Point(287, 243);
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size(76, 29);
			this.lblCode.TabIndex = 5;
			this.lblCode.Text = "Code";
			// 
			// lblDesc
			// 
			this.lblDesc.AutoSize = true;
			this.lblDesc.Location = new System.Drawing.Point(217, 302);
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.Size = new System.Drawing.Size(146, 29);
			this.lblDesc.TabIndex = 6;
			this.lblDesc.Text = "Description";
			// 
			// txtCode
			// 
			this.txtCode.Location = new System.Drawing.Point(383, 238);
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(243, 34);
			this.txtCode.TabIndex = 7;
			// 
			// txtDesc
			// 
			this.txtDesc.Location = new System.Drawing.Point(383, 299);
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(442, 34);
			this.txtDesc.TabIndex = 8;
			// 
			// logsTimer
			// 
			this.logsTimer.Tick += new System.EventHandler(this.logsTimer_Tick);
			// 
			// frmFilliations
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.ClientSize = new System.Drawing.Size(1650, 1010);
			this.Controls.Add(this.txtDesc);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.lblDesc);
			this.Controls.Add(this.lblCode);
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "frmFilliations";
			this.Text = "Filliations";
			this.Load += new System.EventHandler(this.frmFilliations_Load);
			this.Controls.SetChildIndex(this.btnUpdate, 0);
			this.Controls.SetChildIndex(this.btnCreate, 0);
			this.Controls.SetChildIndex(this.lblTitle, 0);
			this.Controls.SetChildIndex(this.lblLog, 0);
			this.Controls.SetChildIndex(this.lblCode, 0);
			this.Controls.SetChildIndex(this.lblDesc, 0);
			this.Controls.SetChildIndex(this.txtCode, 0);
			this.Controls.SetChildIndex(this.txtDesc, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCode;
		private System.Windows.Forms.Label lblDesc;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.TextBox txtDesc;
		private System.Windows.Forms.Timer logsTimer;
	}
}

