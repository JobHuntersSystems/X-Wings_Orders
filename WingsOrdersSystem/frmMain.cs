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
using FormSpaceShipCategory;
using FormsEDI;
using FormSpaceShipTypes;

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
			frmFactories exist = Application.OpenForms.OfType<frmFactories>().FirstOrDefault();
			if (exist != null)
			{
				exist.BringToFront();
			}
			else
			{
				frmFactories frm = new frmFactories("OperationalAreas");
				frm.Show();
				frm.WindowState = FormWindowState.Maximized;
			}
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
				frm.WindowState = FormWindowState.Maximized;
			}			
        }

        private void xwLauchFrmOrders_ButtonClick(object sender, EventArgs e)
        {
			frmOrders exist = Application.OpenForms.OfType<frmOrders>().FirstOrDefault();
			if (exist != null)
			{
				exist.BringToFront();
			}
			else
			{
				frmOrders frm = new frmOrders("OperationalAreas");
				frm.Show();
				frm.WindowState = FormWindowState.Maximized;
			}
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
				frm.WindowState = FormWindowState.Maximized;
			}			
		}
		private void timerTime_Tick(object sender, EventArgs e)
		{
			string timeFrame = DateTime.Now.ToString("HH:mm:ss");
			lblTime.Text = timeFrame;
		}

        private void xwLauchFrmSpaceshipsCategories_ButtonClick(object sender, EventArgs e)
        {
			frmSpaceShipCategory exist = Application.OpenForms.OfType<frmSpaceShipCategory>().FirstOrDefault();
			if (exist != null)
			{
				exist.BringToFront();
			}
			else
			{
				frmSpaceShipCategory frm = new frmSpaceShipCategory("Routes");
				frm.Show();
				frm.WindowState = FormWindowState.Maximized;
			}
		}

        private void xwLauchFrmSpaceshipsSpecies_ButtonClick(object sender, EventArgs e)
        {
			frmSpaceShipTypes exist = Application.OpenForms.OfType<frmSpaceShipTypes>().FirstOrDefault();
			if (exist != null)
			{
				exist.BringToFront();
			}
			else
			{
				frmSpaceShipTypes frm = new frmSpaceShipTypes("Routes");
				frm.Show();
				frm.WindowState = FormWindowState.Maximized;
			}
		}
    }
}
