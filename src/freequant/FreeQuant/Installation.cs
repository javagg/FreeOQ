//using Microsoft.Win32;
//using System;
//using System.ComponentModel;
//using System.IO;
//using System.Runtime.CompilerServices;
//using System.Runtime.InteropServices;
using System.Reflection;
using System.IO;
using System.ComponentModel;
using System;

namespace FreeQuant
{
	public class Installation
	{
		private const string OsEB10mv7f = "QUANTSYS";
		private const string eVRBoveg7a = "QUANTDAT";
		private const string hgMBLxQl6m = "QUANTAPP";
		private const string TqrBFoqdfv = "Version";
		private const string RwEB7FGGnP = "{CDD416EC-BA43-47f9-BEE8-89125652118F}";
		private const string WI2BekVjWs = "{A7834A40-B64B-4efe-B697-DE670034DE0B}";
		private const string LIHBKqc3F3 = "solutions";
		private const string mUCBuH2sAx = "bin";
		private const string knDBOHiue0 = "objects";
		private const string vieBA7nEIb = "ini";
		private const string lS2BJNYjZr = "components";
		private const string i77BQIL7Kg = "templates";
		private const string ws5Ba4t27i = "help";
		private const string qFdBjQYUWm = "logs";
		private const string MZuBqYY2PX = "fix";
		private const string a4BBXpGGSs = "temp";
		private const string Q3eB3KSxo8 = "Main";
		private const string as1BzPVKYp = "Other";
		private const int ObTrn8HleO = 14;
		private DirectoryInfo oPMrmf3G9r;
		private DirectoryInfo T4Wr4Fk6P5;
		private DirectoryInfo rrmrBhZYP6;
		private DirectoryInfo EdPrrVSRQ8;
		private DirectoryInfo gEgrYJNnEK;
		private Version BABrSjmqdm;
		private bool mHQrkRnDmx;
		private bool krqrifGoPr;
		private bool TqSrDicxx6;
		private bool X4vrP8Ly4E;

		[Category("Main")]
		public Version Version
		{
			get
			{
				return (Version)null;
			}
		}

		[Browsable(false)]
		public Edition Edition
		{
			get
			{
				return Edition.OpenSource;
			}
		}

		[Browsable(false)]
		public string MainProduct
		{
			get
			{
				return (string)null;
			}
		}

		[Category("Main")]
		public DirectoryInfo QUANTSYS
		{
			get
			{
                return new DirectoryInfo(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().FullName), ".."));
//                return Path.GetDirectoryName(Assembly.GetExecutingAssembly().FullName);

//                return (DirectoryInfo)null;
			}
		}

		[Category("Main")]
		[ReadOnly(true)]
		public DirectoryInfo QUANTDAT
		{
			get
			{
				return (DirectoryInfo)null;
			}
			set
			{
			}
		}

		[Category("Main")]
		public DirectoryInfo QUANTAPP
		{
			get
			{
				return (DirectoryInfo)null;
			}
		}

		[Category("Other")]
		public DirectoryInfo DataDir
		{
			get
			{
                return new DirectoryInfo(Path.Combine(this.QUANTSYS.FullName, "data"));
			}
		}

		[Category("Other")]
		[ReadOnly(true)]
		public DirectoryInfo BinDir
		{
			get
			{
                return new DirectoryInfo(Path.Combine(this.QUANTSYS.FullName, "bin"));
			}
//			set
//			{
//			}
		}

		[Category("Other")]
		public DirectoryInfo IniDir
		{
			get
			{
                return new DirectoryInfo(Path.Combine(this.QUANTSYS.FullName, "ini"));
			}
		}

		[Category("Other")]
		public DirectoryInfo SolutionDir
		{
			get
			{
                return new DirectoryInfo(Path.Combine(this.QUANTSYS.FullName, "solutions"));
			}
		}

		[Category("Other")]
		public DirectoryInfo ComponentDir
		{
			get
			{
                return new DirectoryInfo(Path.Combine(this.QUANTSYS.FullName, "components"));
			}
		}

		[Category("Other")]
		public DirectoryInfo TemplateDir
		{
			get
			{
                return new DirectoryInfo(Path.Combine(this.QUANTSYS.FullName, "templates"));
			}
		}

		[Category("Other")]
		public DirectoryInfo HelpDir
		{
			get
			{
                return new DirectoryInfo(Path.Combine(this.QUANTSYS.FullName, "help"));
			}
		}

		[Category("Other")]
		public DirectoryInfo LogDir
		{
			get
			{
                return new DirectoryInfo(Path.Combine(this.QUANTSYS.FullName, "logs"));
			}
		}

		[Category("Other")]
		public DirectoryInfo FIXDir
		{
			get
			{
                return new DirectoryInfo(Path.Combine(this.QUANTSYS.FullName, "fix"));
			}
		}

		[Category("Other")]
		public DirectoryInfo TempDir
		{
			get
			{
                return new DirectoryInfo(Path.Combine(this.QUANTSYS.FullName, "temp"));
			}
		}

		internal Installation()
		{
		}

		internal void k9JB9fI5oq()
		{
		}

		public LicenseInfo GetLicense()
		{
            return new LicenseInfo() { Licensed = true };
		}

		internal bool tnABvXFOOP()
		{
			return true;
		}

		internal bool c7kBpxixDa()
		{
			return true;
		}

		internal bool i94BcvgC0K()
		{
			return true;
		}

//		private string MR4BVNrLnA(RegistryKey obj0, string obj1)
//		{
//			return null;
//		}
//
//		private bool H3jBgrTW1C(RegistryKey obj0, string obj1)
//		{
//			return true;
//		}
//
//		private void XoMBb3l1md(RegistryKey obj0, string obj1, string obj2)
//		{
//		}
	}
}
