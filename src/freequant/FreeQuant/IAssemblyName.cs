// Type: SmartQuant.IAssemblyName
// Assembly: SmartQuant, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=null
// MVID: BC86C0EF-576E-453D-8BFD-FAB33B893C15
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.dll

using aPqI2kmeVjWsoIHqc3F;
using ARCfsqh0wopyUmmhtE;
using gaaHdvx8w4NsLZ2xXO;
using mP5d9DyCVBYmdHOPyl;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SmartQuant
{
  [Guid("CD193BC0-B4BC-11d2-9833-00C04FC31D2E")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [LicenseProvider(typeof (A6mJqrm7oqdfvuwEFGG))]
  [ComImport]
  internal interface IAssemblyName
  {
    [MethodImpl(MethodImplOptions.PreserveSig)]
    int SetProperty(Wim3wFsqei13y08K1U PropertyId, IntPtr pvProperty, uint cbProperty);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int GetProperty(Wim3wFsqei13y08K1U PropertyId, IntPtr pvProperty, ref uint pcbProperty);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int Finalize();

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int GetDisplayName([MarshalAs(UnmanagedType.LPWStr), Out] StringBuilder szDisplayName, ref uint pccDisplayName, mZrfxQHjhOfJWyjsZT dwDisplayFlags);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int BindToObject(ref Guid refIID, [MarshalAs(UnmanagedType.IUnknown)] object pUnkSink, [MarshalAs(UnmanagedType.IUnknown)] object pUnkContext, [MarshalAs(UnmanagedType.LPWStr)] string szCodeBase, long llFlags, IntPtr pvReserved, uint cbReserved, out IntPtr ppv);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int GetName(ref uint lpcwBuffer, [MarshalAs(UnmanagedType.LPWStr), Out] StringBuilder pwzName);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int GetVersion(out uint pdwVersionHi, out uint pdwVersionLow);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int IsEqual(IAssemblyName pName, By9un7wrTLM3ii1rYI dwCmpFlags);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int Clone(out IAssemblyName pName);
  }
}
