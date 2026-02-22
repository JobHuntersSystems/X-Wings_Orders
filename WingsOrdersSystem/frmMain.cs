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
using Filliations;
using OperationalAreas;
using Routes;

namespace WingsOrdersSystem
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}
		private void xwLauchFrmFactories_ButtonClick(object sender, EventArgs e)
		{
			frmFactories frm = new frmFactories("Factories");
			frm.Show();
		}

		private void xwLauchFrmOpeArea_ButtonClick(object sender, EventArgs e)
		{            
			frmOperationalAreas frm = new frmOperationalAreas("OperationalAreas");
			frm.Show();
		}

		private void xwLauchFrmRutas_ButtonClick(object sender, EventArgs e)
		{
			frmRoutes frm = new frmRoutes("Routes");
			frm.Show();
		}

		private void xwLauchFrmFilliations_ButtonClick(object sender, EventArgs e)
		{
			frmFilliations frm = new frmFilliations("Filliations");
			frm.Show();
		}
	}
}
