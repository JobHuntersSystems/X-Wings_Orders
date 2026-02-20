using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace CrystalReport
{
    public partial class frmCrystalReport : Form
    {
        private List<int> _idOrder;
        public frmCrystalReport(List<int> idOrder)
        {
            InitializeComponent();
            _idOrder = idOrder;
        }

        private void frmCrystalReport_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument cryRpt = new ReportDocument();
                string pathReport = System.IO.Path.Combine(Application.StartupPath, "JobHuntersReport.rpt");
                cryRpt.Load(pathReport);

                Credentials(cryRpt);

                if (_idOrder != null && _idOrder.Count > 0)
                {
                    string ids = string.Join(",", _idOrder);
                    cryRpt.RecordSelectionFormula = "{Orders.idOrder} IN [" + ids + "]";
                }

                crvJobHunters.ReportSource = cryRpt;
                crvJobHunters.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Credentials(ReportDocument cryRpt)
        {
            string cnx;
            ConnectionStringSettings conf = ConfigurationManager.ConnectionStrings["SecureCoreG2Configuration"];

            if (conf == null) return;
            cnx = conf.ConnectionString;

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cnx);
            string server = builder.DataSource;
            string database = builder.InitialCatalog;
            string user = builder.UserID;
            string passwd = builder.Password;

            ConnectionInfo ci = new ConnectionInfo
            {
                ServerName = server,
                DatabaseName = database,
                UserID = user,
                Password = passwd
            };

            ApplyConn(cryRpt, ci);
        }

        private void ApplyConn(ReportDocument cryRpt, ConnectionInfo connectionInfo)
        {
            foreach (Table table in cryRpt.Database.Tables)
            {
                TableLogOnInfo tableLogOnInfo = table.LogOnInfo;
                tableLogOnInfo.ConnectionInfo = connectionInfo;
                table.ApplyLogOnInfo(tableLogOnInfo);
            }
        }
    }
}
