using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace FTPServerProgram
{
	class FtpService
	{

		readonly FtpConfig Config;

		public FtpService(FtpConfig config)
		{
			Config = config;
		}

		// 🔹 Listar archivos del FTP
		public string[] ListFiles()
		{
			var request = (FtpWebRequest)
				WebRequest.Create($"ftp://{Config.Host}{Config.RemoteRoot}");

			request.Method = WebRequestMethods.Ftp.ListDirectory;
			request.Credentials = new NetworkCredential(Config.User, Config.Pass);

			using (var response = (FtpWebResponse)request.GetResponse())
			using (var reader = new StreamReader(response.GetResponseStream()))
			{
				string data = reader.ReadToEnd();
				return data.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
			}
		}

		public void DownloadFile(string fileName)
		{
			string ftpUrl = $"ftp://{Config.Host}{Config.RemoteRoot}/{fileName}";

			var request = (FtpWebRequest)WebRequest.Create(ftpUrl);
			request.Method = WebRequestMethods.Ftp.DownloadFile;
			request.Credentials = new NetworkCredential(Config.User, Config.Pass);

			using (var response = (FtpWebResponse)request.GetResponse())
			using (var responseStream = response.GetResponseStream())
			{
				// Crear carpeta FTP si no existe
				if (!Directory.Exists(Config.LocalFolder))
					Directory.CreateDirectory(Config.LocalFolder);

				// Crear carpeta Tractats dentro de FTP
				string tractatsPath = Path.Combine(Config.LocalFolder, "Tractats");

				if (!Directory.Exists(tractatsPath))
					Directory.CreateDirectory(tractatsPath);

				string localPath = Path.Combine(Config.LocalFolder, fileName);

				using (var fs = new FileStream(localPath, FileMode.Create))
				{
					responseStream.CopyTo(fs);
				}
			}
		}

	}
}
