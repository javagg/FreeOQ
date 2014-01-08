using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant
{
  [Guid("21b8916c-f28e-11d2-a473-00c04f8ef448")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  internal interface IAssemblyEnum
  {
    int GetNextAssembly(IntPtr pvReserved, out IAssemblyName ppName, uint dwFlags);

    int Reset();

    int Clone(out IAssemblyEnum ppEnum);
  }
}
