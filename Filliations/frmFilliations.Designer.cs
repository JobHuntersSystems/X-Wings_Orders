
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
			this.btnUpdate.Location = new System.Drawing.Point(1138, 366);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(1029, 366);
			this.btnCreate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTitle.Size = new System.Drawing.Size(480, 27);
			this.lblTitle.Text = "";
			// 
			// lblLog
			// 
			this.lblLog.Location = new System.Drawing.Point(374, 368);
			this.lblLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			// 
			// lblCode
			// 
			this.lblCode.AutoSize = true;
			this.lblCode.Location = new System.Drawing.Point(230, 201);
			this.lblCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size(60, 24);
			this.lblCode.TabIndex = 5;
			this.lblCode.Text = "Code";
			// 
			// lblDesc
			// 
			this.lblDesc.AutoSize = true;
			this.lblDesc.Location = new System.Drawing.Point(174, 250);
			this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.Size = new System.Drawing.Size(115, 24);
			this.lblDesc.TabIndex = 6;
			this.lblDesc.Text = "Description";
			// 
			// txtCode
			// 
			this.txtCode.Location = new System.Drawing.Point(306, 197);
			this.txtCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(195, 29);
			this.txtCode.TabIndex = 7;
			this.txtCode.Tag = "CodeFiliation";
			// 
			// txtDesc
			// 
			this.txtDesc.Location = new System.Drawing.Point(306, 247);
			this.txtDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(354, 29);
			this.txtDesc.TabIndex = 8;
			this.txtDesc.Tag = "DescFiliations";
			// 
			// logsTimer
			// 
			this.logsTimer.Tick += new System.EventHandler(this.logsTimer_Tick);
			// 
			// frmFilliations
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1232, 699);
			this.Controls.Add(this.txtDesc);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.lblDesc);
			this.Controls.Add(this.lblCode);
			this.Location = new System.Drawing.Point(0, 0);
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "frmFilliations";
			this.Text = "Form1";
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

