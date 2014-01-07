// Type: SmartQuant.IAssemblyEnum
// Assembly: SmartQuant, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=null
// MVID: BC86C0EF-576E-453D-8BFD-FAB33B893C15
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.dll

using aPqI2kmeVjWsoIHqc3F;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant
{
  [Guid("21b8916c-f28e-11d2-a473-00c04f8ef448")]
  [LicenseProvider(typeof (A6mJqrm7oqdfvuwEFGG))]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  internal interface IAssemblyEnum
  {
    [MethodImpl(MethodImplOptions.PreserveSig)]
    int GetNextAssembly(IntPtr pvReserved, out IAssemblyName ppName, uint dwFlags);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int Reset();

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int Clone(out IAssemblyEnum ppEnum);
  }
}
