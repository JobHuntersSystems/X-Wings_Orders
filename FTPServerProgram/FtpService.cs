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
			FtpWebRequest request = (FtpWebRequest)
				WebRequest.Create($"ftp://{Config.Host}{Config.RemoteRoot}");

			request.Method = WebRequestMethods.Ftp.ListDirectory;
			request.Credentials = new NetworkCredential(Config.User, Config.Pass);

			FtpWebResponse response = (FtpWebResponse)request.GetResponse();

			Stream responseStream = response.GetResponseStream();
			StreamReader reader = new StreamReader(responseStream);

			string data = reader.ReadToEnd();

			reader.Close();
			response.Close();

			return data.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
		}

		public void DownloadFile(string fileName)
		{
			string ftpUrl = $"ftp://{Config.Host}{Config.RemoteRoot}/{fileName}";

			FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl);

			request.Method = WebRequestMethods.Ftp.DownloadFile;
			request.Credentials = new NetworkCredential(Config.User, Config.Pass);

			FtpWebResponse response = (FtpWebResponse)request.GetResponse();
			Stream responseStream = response.GetResponseStream();

			if (!Directory.Exists(Config.LocalFolder))
				Directory.CreateDirectory(Config.LocalFolder);

			string localPath = Path.Combine(Config.LocalFolder, fileName);

			using (FileStream fs = new FileStream(localPath, FileMode.Create))
			{
				responseStream.CopyTo(fs);
			}

			response.Close();
		}

		public void MoveToProcessed(string fileName)
		{
			string ftpUrl = $"ftp://{Config.Host}{Config.RemoteRoot}/{fileName}";

			FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl);

			request.Method = WebRequestMethods.Ftp.Rename;
			request.Credentials = new NetworkCredential(Config.User, Config.Pass);

			request.RenameTo = $"{Config.ProcessedFolder}/{fileName}";

			FtpWebResponse response = (FtpWebResponse)request.GetResponse();
			response.Close();
		}

	}
}
