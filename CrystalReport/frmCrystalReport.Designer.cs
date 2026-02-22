
namespace CrystalReport
{
    partial class frmCrystalReport
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
            this.crvJobHunters = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.JobHuntersReport1 = new CrystalReport.JobHuntersReport();
            this.SuspendLayout();
            // 
            // crvJobHunters
            // 
            this.crvJobHunters.ActiveViewIndex = 0;
            this.crvJobHunters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvJobHunters.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvJobHunters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvJobHunters.Location = new System.Drawing.Point(0, 0);
            this.crvJobHunters.Margin = new System.Windows.Forms.Padding(2);
            this.crvJobHunters.Name = "crvJobHunters";
            this.crvJobHunters.ReportSource = this.JobHuntersReport1;
            this.crvJobHunters.Size = new System.Drawing.Size(711, 674);
            this.crvJobHunters.TabIndex = 0;
            this.crvJobHunters.ToolPanelWidth = 133;
            // 
            // frmCrystalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 674);
            this.Controls.Add(this.crvJobHunters);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCrystalReport";
            this.Text = "Crystal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCrystalReport_FormClosing);
            this.Load += new System.EventHandler(this.frmCrystalReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvJobHunters;
        private JobHuntersReport JobHuntersReport1;
    }
}

