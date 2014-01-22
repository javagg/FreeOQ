using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace FreeQuant
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
//  [Guid("582dac66-e678-449f-aba6-6faaec8a9394")]
//  [ComImport]
  internal interface IInstallReferenceItem
  {
		int GetReference([MarshalAs(UnmanagedType.LPArray)] out string[] ppRefData, uint dwFlags, IntPtr pvReserved);
  }
}
