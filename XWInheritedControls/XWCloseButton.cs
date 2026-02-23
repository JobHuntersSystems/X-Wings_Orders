using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace XWInheritedControls
{
    public class XWCloseButton : PictureBox
    {
        private string _HoverIconPath;
        public string HoverIconPath
        {
            get { return _HoverIconPath; }
            set { _HoverIconPath = value; }
        }
        private string _MainIconPath;
        public string MainIconPath
        {
            get { return _MainIconPath; }
            set
            {
                _MainIconPath = value;
                if (!string.IsNullOrEmpty(_MainIconPath))
                {
                    this.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + value;
                }
            }
        }
        public XWCloseButton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // SWCloseButton
            // 
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Click += new System.EventHandler(this.SWCloseButton_Click);
            this.MouseEnter += new System.EventHandler(this.SWCloseButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.SWCloseButton_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        private void SWCloseButton_MouseEnter(object sender, EventArgs e)
        {
            this.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + _HoverIconPath;
        }

        private void SWCloseButton_MouseLeave(object sender, EventArgs e)
        {
            this.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + _MainIconPath;
        }

        private void SWCloseButton_Click(object sender, EventArgs e)
        {
            Form frm = this.FindForm();
            frm.Close();
        }
    }
}
