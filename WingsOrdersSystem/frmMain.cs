using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Factories;
using OperationalAreas;
using Orders;
using Routes;
using FormsEDI;



namespace WingsOrdersSystem
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();

			string timeFrame = DateTime.Now.ToString("HH:mm:ss");
			lblTime.Text = timeFrame;
			timerTime.Start();
		}
		private void xwLauchFrmFactories_ButtonClick(object sender, EventArgs e)
		{
			frmFactories frm = new frmFactories("Factories");
			frm.Show();
		}

        private void xwLauchFrmOpeArea_ButtonClick(object sender, EventArgs e)
        {
			frmOperationalAreas exist = Application.OpenForms.OfType<frmOperationalAreas>().FirstOrDefault();
			if(exist != null)
            {
				exist.BringToFront();
            }
            else
            {
				frmOperationalAreas frm = new frmOperationalAreas("OperationalAreas");
				frm.Show();
			}			
        }

        private void xwLauchFrmOrders_ButtonClick(object sender, EventArgs e)
        {
            frmOrders frm = new frmOrders("Orders");
            frm.Show();
        }
		
		private void xwLauchFrmRouts_ButtonClick(object sender, EventArgs e)
		{
			frmRoutes exist = Application.OpenForms.OfType<frmRoutes>().FirstOrDefault();
            if (exist != null)
            {
				exist.BringToFront();
            }
            else
            {
				frmRoutes frm = new frmRoutes("Routes");
				frm.Show();
			}			
		}
		private void timerTime_Tick(object sender, EventArgs e)
		{
			string timeFrame = DateTime.Now.ToString("HH:mm:ss");
			lblTime.Text = timeFrame;
		}
    }
}
