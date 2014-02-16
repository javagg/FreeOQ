using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace FreeQuant
{
	public class Framework
	{
		private static Configuration configuration;
		private static Installation installation;
		private static Storage storage;
		private static Runtime runtime; 
		private static Mutex mutex; 
		private static bool isAlreadyRunning; 

		public static bool IsAlreadyRunning
		{
			get
			{
				return isAlreadyRunning; 
			}
		}

		public static Configuration Configuration
		{
			get
			{
				return configuration;
			}
		}

		public static Installation Installation
		{
			get
			{
				return installation;
			}
		}

		public static Storage Storage
		{
			get
			{
				return storage;
			}
		}

		public static Runtime Runtime
		{
			get
			{
				return runtime;
			}
		}

		static Framework()
		{
			Framework.mutex = new Mutex(false, Framework.Installation.QUANTAPP.FullName.Replace('\\', ':').Replace('/', ':'));
			Framework.isAlreadyRunning = !Framework.mutex.WaitOne(0);
			if (Framework.isAlreadyRunning)
				return;
//			switch (Framework.Installation.Edition)
//			{
//				case Edition.OpenSource:
//				case Edition.Demo:
//					if (!Framework.Installation.tnABvXFOOP() && !Framework.Installation.c7kBpxixDa())
//						break;
//					if (Trace.IsLevelEnabled(TraceLevel.Info))
//						Trace.WriteLine("TraceLevel.Info");
//					if (Environment.UserInteractive)
//					{
//						int num1 = (int)MessageBox.Show(string.Format("{0}", Framework.Installation.MainProduct), "dfs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
//					}
//					Environment.Exit(-1);
//					break;
//				case Edition.Research:
//				case Edition.Professional:
//					if (Framework.Installation.i94BcvgC0K())
//						break;
//					if (Trace.IsLevelEnabled(TraceLevel.Info))
//						Trace.WriteLine("TraceLevel.Info");
//					if (Environment.UserInteractive)
//					{
//						MessageBox.Show("ddf", "fddd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
//					}
//					Environment.Exit(-1);
//					break;
//			}
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
