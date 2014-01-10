using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace FreeQuant
{
	public class Framework
	{
		private static Configuration Jmtw8dmK6;
		private static Installation DGghk9Nln;
		private static Storage HhVs2ITrn;
		private static Runtime DVVyxKgnL;
		private static Mutex mDOEiS9EL;
		private static bool mY0TnM837;

		public static bool IsAlreadyRunning
		{
			get
			{
				return true;
			}
		}

		public static Configuration Configuration
		{
			get
			{
				return (Configuration)null;
			}
		}

		public static Installation Installation
		{
			get
			{
				return (Installation)null;
			}
		}

		public static Storage Storage
		{
			get
			{
				return (Storage)null;
			}
		}

		public static Runtime Runtime
		{
			get
			{
				return (Runtime)null;
			}
		}

		static Framework()
		{
			Framework.mDOEiS9EL = new Mutex(false, Framework.Installation.QUANTAPP.FullName.Replace('\\', ':').Replace('/', ':'));
			Framework.mY0TnM837 = !Framework.mDOEiS9EL.WaitOne(0);
			if (Framework.mY0TnM837)
				return;
			switch (Framework.Installation.Edition)
			{
				case Edition.Demo:
					if (!Framework.Installation.tnABvXFOOP() && !Framework.Installation.c7kBpxixDa())
						break;
					if (Trace.IsLevelEnabled(TraceLevel.Info))
						Trace.WriteLine(GItcYDqSxj5aE60JeS.GFmrbXlIxf(76));
					if (Environment.UserInteractive)
					{
						int num1 = (int)MessageBox.Show(string.Format(GItcYDqSxj5aE60JeS.GFmrbXlIxf(140), (object)Framework.Installation.MainProduct), GItcYDqSxj5aE60JeS.GFmrbXlIxf(368), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					Environment.Exit(-1);
					break;
				case Edition.Research:
				case Edition.Professional:
					if (Framework.Installation.i94BcvgC0K())
						break;
					if (Trace.IsLevelEnabled(TraceLevel.Info))
						Trace.WriteLine(GItcYDqSxj5aE60JeS.GFmrbXlIxf(392));
					if (Environment.UserInteractive)
					{
						int num2 = (int)MessageBox.Show(GItcYDqSxj5aE60JeS.GFmrbXlIxf(462), GItcYDqSxj5aE60JeS.GFmrbXlIxf(532), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					Environment.Exit(-1);
					break;
			}
		}

		private Framework()
		{
		}

		public static void Init()
		{
		}

		public static void LoadPlugins()
		{
		}

		public static void LoadPlugin(Plugin plugin)
		{
		}
	}
}
