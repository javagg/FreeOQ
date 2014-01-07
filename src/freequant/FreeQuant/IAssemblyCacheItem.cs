// Type: SmartQuant.IAssemblyCacheItem
// Assembly: SmartQuant, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=null
// MVID: BC86C0EF-576E-453D-8BFD-FAB33B893C15
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.dll

using aPqI2kmeVjWsoIHqc3F;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace SmartQuant
{
  [LicenseProvider(typeof (A6mJqrm7oqdfvuwEFGG))]
  [Guid("9E3AAEB4-D1CD-11D2-BAB9-00C04F8ECEAE")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  internal interface IAssemblyCacheItem
  {
    void CreateStream(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszStreamName, uint dwFormat, uint dwFormatFlags, out IStream ppIStream, ref long puliMaxSize);

    void Commit(uint dwFlags, out long pulDisposition);

    void AbortItem();
  }
}
