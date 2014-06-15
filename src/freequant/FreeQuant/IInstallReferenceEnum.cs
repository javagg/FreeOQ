using System.Runtime.InteropServices;
using System;

namespace FreeQuant
{
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("56b1a988-7c0c-4aa2-8639-c3eb5a90226f")]
    [ComImport]
    internal interface IInstallReferenceEnum
    {
        int GetNextInstallReferenceItem(out IInstallReferenceItem ppRefItem, uint dwFlags, IntPtr pvReserved);
    }
}
