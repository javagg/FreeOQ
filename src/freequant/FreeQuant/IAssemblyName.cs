using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace FreeQuant
{
//  [Guid("CD193BC0-B4BC-11d2-9833-00C04FC31D2E")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
//  [ComImport]
  internal interface IAssemblyName
  {
		int SetProperty(int PropertyId, IntPtr pvProperty, uint cbProperty);

		int GetProperty(int PropertyId, IntPtr pvProperty, ref uint pcbProperty);

    int Finalize();

		int GetDisplayName([MarshalAs(UnmanagedType.LPWStr), Out] StringBuilder szDisplayName, ref uint pccDisplayName, uint dwDisplayFlags);

    int BindToObject(ref Guid refIID, [MarshalAs(UnmanagedType.IUnknown)] object pUnkSink, [MarshalAs(UnmanagedType.IUnknown)] object pUnkContext, [MarshalAs(UnmanagedType.LPWStr)] string szCodeBase, long llFlags, IntPtr pvReserved, uint cbReserved, out IntPtr ppv);

    int GetName(ref uint lpcwBuffer, [MarshalAs(UnmanagedType.LPWStr), Out] StringBuilder pwzName);

    int GetVersion(out uint pdwVersionHi, out uint pdwVersionLow);

		int IsEqual(IAssemblyName pName, uint dwCmpFlags);

    int Clone(out IAssemblyName pName);
  }
}
