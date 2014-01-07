// Type: SmartQuant.IInstallReferenceEnum
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
  [LicenseProvider(typeof (A6mJqrm7oqdfvuwEFGG))]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("56b1a988-7c0c-4aa2-8639-c3eb5a90226f")]
  [ComImport]
  internal interface IInstallReferenceEnum
  {
    [MethodImpl(MethodImplOptions.PreserveSig)]
    int GetNextInstallReferenceItem(out IInstallReferenceItem ppRefItem, uint dwFlags, IntPtr pvReserved);
  }
}
