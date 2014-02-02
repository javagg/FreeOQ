using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant
{
	public class SystemInfo
	{
		private static SystemInfo systemInfo;

		public static SystemInfo CurrentSystem
		{
			get
			{
				return systemInfo;
			}
		}

		public OperatingSystem OperatingSystem
		{
			get
			{
				return (OperatingSystem)null;
			}
		}

		public CPUInfo CPU
		{
			get
			{
				return (CPUInfo)null;
			}
			private set
			{
			}
		}

		public RAMInfo RAM
		{
			get
			{
				return (RAMInfo)null;
			}
			private set
			{
			}
		}

		public Version RuntimeVersion
		{
			get
			{
				return (Version)null;
			}
		}

		static SystemInfo()
		{
			SystemInfo.systemInfo = (SystemInfo)null;
		}

		private SystemInfo()
		{
		}
	}
}
