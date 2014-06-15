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
                return Environment.OSVersion;
			}
		}

		public CPUInfo CPU
		{
			get
			{
				return (CPUInfo)null;
			}
		}

		public RAMInfo RAM
		{
			get
			{
				return (RAMInfo)null;
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
            SystemInfo.systemInfo = new SystemInfo();
		}

		private SystemInfo()
		{
		}
	}
}
