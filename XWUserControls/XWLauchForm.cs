using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace XWUserControls
{
    public partial class XWLauchForm : UserControl
    {
        public XWLauchForm()
        {
            InitializeComponent();
        }
        #region Properties
        Color OriginalBackColor;
        private string _Title= "Option";
        public string Title
        {
            get { return _Title; }
            set
            {
                _Title = value;
                this.lblOptionName.Text = value;
            }
        }

        private string _InitialImagePath;
        public string InitialImagePath
        {
            get { return _InitialImagePath; }
            set
            {
                string path = value;
                _InitialImagePath = path;
                pctOptionIcon.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + _InitialImagePath;
            }
        }
        private string _HoverImagePath;
        public string HoverImagePath
        {
            get { return _HoverImagePath; }
            set
            {
                string path = value;
                _HoverImagePath = path;
            }
        }
        private int[] _HoverFontColor = new int[] { 0, 0, 0 };
        public string HoverFontColor
        {
            get
            {
                return string.Join(";", _HoverFontColor);
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    string[] rgb = value.Split(';');
                    _HoverFontColor = new int[rgb.Length];
                    //Cleaning
                    for (int i = 0; i < rgb.Length; i++)
                    {
                        _HoverFontColor[i] = int.Parse(rgb[i].Trim());
                    }
                }
            }
        }
        private int[] _HoverBackColor = new int[] { 244, 244, 244 };
        public string HoverBackColor
        {
            get
            {
                return string.Join(";", _HoverBackColor);
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    string[] rgb = value.Split(';');
                    _HoverBackColor = new int[rgb.Length];
                    //Cleaning
                    for (int i = 0; i < rgb.Length; i++)
                    {
                        _HoverBackColor[i] = int.Parse(rgb[i].Trim());
                    }
                }
            }
        }
        #endregion

        #region Events
        //Evento Load: del control suscribiremos nuestros controles a los eventos de "MouseEnter y "MouseLeave"
        private void XWLauchForm_Load(object sender, EventArgs e)
        {
            OriginalBackColor = this.BackColor;
            pnlMain.MouseEnter += new EventHandler(Control_MouseEnter);
            pnlMain.MouseLeave += new EventHandler(Control_MouseLeave);
            foreach (Control ctrl in pnlMain.Controls)
            {
                ctrl.MouseEnter += new EventHandler(Control_MouseEnter);
                ctrl.MouseLeave += new EventHandler(Control_MouseLeave);
            }
        }
        //Evento Click: Cuando se haga click sobre cualquier parte del control, este abrira un frm mediante "Reflection"
        private void Control_MouseEnter(object sender, EventArgs e)
        {
            pctOptionIcon.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + _HoverImagePath;
            this.BackColor = Color.FromArgb(_HoverBackColor[0], _HoverBackColor[1], _HoverBackColor[2]);
            this.ForeColor = Color.FromArgb(_HoverFontColor[0], _HoverFontColor[1], _HoverFontColor[2]);
        }
        private void Control_MouseLeave(object sender, EventArgs e)
        {
            pctOptionIcon.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + _InitialImagePath;

            this.ForeColor = this.Parent.ForeColor;
            this.BackColor = OriginalBackColor;

        }
        #endregion
    }
}
