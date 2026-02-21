
namespace FTPServerProgram
{
	partial class FrmFTP
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
			this.btnCheck = new System.Windows.Forms.Button();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(326, 125);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(75, 23);
			this.btnCheck.TabIndex = 1;
			this.btnCheck.Text = "Check";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// txtLog
			// 
			this.txtLog.Location = new System.Drawing.Point(443, 135);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.Size = new System.Drawing.Size(334, 303);
			this.txtLog.TabIndex = 2;
			// 
			// FrmFTP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtLog);
			this.Controls.Add(this.btnCheck);
			this.Name = "FrmFTP";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.TextBox txtLog;
	}
}

