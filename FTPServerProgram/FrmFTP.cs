using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FTPServerProgram
{
	public partial class FrmFTP : Form
	{
		public FrmFTP()
		{
			InitializeComponent();
		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
            try
            {
                var config = FtpConfigReader.Load("FTP_XML.xml");
                var ftpService = new FtpService(config);

                string[] remoteFiles = ftpService.ListFiles();

                foreach (var file in remoteFiles)
                {
                    if (!file.EndsWith(".edi", StringComparison.OrdinalIgnoreCase))
                        continue;

                    string localPath = Path.Combine(config.LocalFolder, file);

                    if (!File.Exists(localPath))
                    {
                        ftpService.DownloadFile(file);
                        txtLog.AppendText($"Descargado: {file}\r\n");
                    }
                }

                txtLog.AppendText("Proceso finalizado.\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
	}
}
