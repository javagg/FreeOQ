using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant
{
	[Guid("e707dcde-d1cd-11d2-bab9-00c04f8eceae")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	internal interface IAssemblyCache
	{
		int UninstallAssembly(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, [MarshalAs(UnmanagedType.LPArray)] string[] pRefData, out uint pulDisposition);

		int QueryAssemblyInfo(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, ref string pAsmInfo);

		int CreateAssemblyCacheItem(uint dwFlags, IntPtr pvReserved, out IAssemblyCacheItem ppAsmItem, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName);

		int CreateAssemblyScavenger([MarshalAs(UnmanagedType.IUnknown)] out object ppAsmScavenger);

		int InstallAssembly(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszManifestFilePath, [MarshalAs(UnmanagedType.LPArray)] byte[] pRefData);
	}
}
