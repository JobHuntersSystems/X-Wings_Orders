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
using Routes;
using Filiations;

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

		private void xwLauchFrmFiliations_ButtonClick(object sender, EventArgs e)
		{
			FrmFiliations frm = new FrmFiliations("Filliations");
			frm.Show();
		}
	}
}
