using System;
using System.Runtime.InteropServices;

namespace FreeQuant
{
    [Guid("7C23FF90-33AF-11D3-95DA-00A024A85B51")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    internal interface IApplicationContext
    {
        void SetContextNameObject(IAssemblyName pName);
        void GetContextNameObject(out IAssemblyName ppName);
        void Set([MarshalAs(UnmanagedType.LPWStr)] string szName, int pvValue, uint cbValue, uint dwFlags);
        void Get([MarshalAs(UnmanagedType.LPWStr)] string szName, out int pvValue, ref uint pcbValue, uint dwFlags);
        void GetDynamicDirectory(out int wzDynamicDir, ref uint pdwSize);
    }
}

