// Type: SmartQuant.IAssemblyCache
// Assembly: SmartQuant, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=null
// MVID: BC86C0EF-576E-453D-8BFD-FAB33B893C15
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.dll

using aPqI2kmeVjWsoIHqc3F;
using i70DujbVjpffM3DCuy;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using yXeUG5VDxytLVYLZ1M;

namespace SmartQuant
{
  [Guid("e707dcde-d1cd-11d2-bab9-00c04f8eceae")]
  [LicenseProvider(typeof (A6mJqrm7oqdfvuwEFGG))]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  internal interface IAssemblyCache
  {
    [MethodImpl(MethodImplOptions.PreserveSig)]
    int UninstallAssembly(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, [MarshalAs(UnmanagedType.LPArray)] fRtwTI9Pe2aLeaESY6[] pRefData, out uint pulDisposition);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int QueryAssemblyInfo(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, ref DM9M05gSo8Rw9lxJhy pAsmInfo);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int CreateAssemblyCacheItem(uint dwFlags, IntPtr pvReserved, out IAssemblyCacheItem ppAsmItem, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int CreateAssemblyScavenger([MarshalAs(UnmanagedType.IUnknown)] out object ppAsmScavenger);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int InstallAssembly(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszManifestFilePath, [MarshalAs(UnmanagedType.LPArray)] fRtwTI9Pe2aLeaESY6[] pRefData);
  }
}
