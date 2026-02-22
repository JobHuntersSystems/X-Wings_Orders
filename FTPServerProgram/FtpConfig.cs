using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTPServerProgram
{
	public class FtpConfig
	{
		public string Host { get; set; }
		public string User { get; set; }
		public string Pass { get; set; }
		public string RemoteRoot { get; set; }
		public string ProcessedFolder { get; set; }
		public string LocalFolder { get; set; }
	}
}
