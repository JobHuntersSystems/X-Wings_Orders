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
				txtLog.AppendText("> Starting connection with the FTP server...\r\n");

				var config = FtpConfigReader.Load("FTP_XML.xml");
				var ftpService = new FtpService(config);

				string[] remoteFiles = ftpService.ListFiles();

				foreach (var file in remoteFiles)
				{
					// Solo procesamos EDI
					if (!file.EndsWith(".edi", StringComparison.OrdinalIgnoreCase))
						continue;

					string localPath = Path.Combine(config.LocalFolder, file);

					// Si no existe localmente → es nuevo
					if (!File.Exists(localPath))
					{
						txtLog.AppendText($"> Downloading new file: {file}...\r\n");
						ftpService.DownloadFile(file);

						txtLog.AppendText($">Moving {file} to Tractats folder...\r\n");
						ftpService.MoveToProcessed(file);

						txtLog.AppendText($"Processed: {file}\r\n");
						txtLog.AppendText("--------------------------------------------------\r\n");
					}
				}

				txtLog.AppendText("Process completed.\r\n");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}
	}
}
