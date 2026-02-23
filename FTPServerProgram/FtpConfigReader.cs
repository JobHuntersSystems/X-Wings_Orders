using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Windows.Forms;

namespace FTPServerProgram
{
	public static class FtpConfigReader
	{
		public static FtpConfig Load(string path)
		{
			XDocument doc = XDocument.Load(path);

			XElement root = doc.Element("FtpConfig");

			string relativeLocal = root.Element("Folders").Element("Local").Value;

			string absoluteLocal = Path.Combine(Application.StartupPath, relativeLocal);

			return new FtpConfig
			{
				Host = root.Element("ip").Value,
				User = root.Element("Credentials").Element("UserName").Value,
				Pass = root.Element("Credentials").Element("Password").Value,
				RemoteRoot = root.Element("Folders").Element("RemoteRoot").Value,
				ProcessedFolder = root.Element("Folders").Element("Processed").Value,
				LocalFolder = root.Element("Folders").Element("Local").Value
			};
		}
	}
}
