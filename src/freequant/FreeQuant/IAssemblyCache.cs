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
		int UninstallAssembly(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, [MarshalAs(UnmanagedType.LPArray)] fRtwTI9Pe2aLeaESY6[] pRefData, out uint pulDisposition);

		int QueryAssemblyInfo(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, ref DM9M05gSo8Rw9lxJhy pAsmInfo);

		int CreateAssemblyCacheItem(uint dwFlags, IntPtr pvReserved, out IAssemblyCacheItem ppAsmItem, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName);

		int CreateAssemblyScavenger([MarshalAs(UnmanagedType.IUnknown)] out object ppAsmScavenger);

		int InstallAssembly(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszManifestFilePath, [MarshalAs(UnmanagedType.LPArray)] fRtwTI9Pe2aLeaESY6[] pRefData);
	}
}
