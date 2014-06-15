using System;
using System.Runtime.InteropServices;
using System.Text;

namespace FreeQuant
{
    [ComImport()]
    [ Guid("1D23DF4D-A1E2-4B8B-93D6-6EA3DC285A54")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IHistoryReader
    {
        int GetFilePath([MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzFilePath, ref uint pdwSize);
        int GetApplicationName([MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzAppName, ref uint pdwSize);
        int GetEXEModulePath([MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzExePath, ref uint pdwSize);
        void GetNumActivations(out uint pdwNumActivations);
        void GetActivationDate(uint dwIdx, out long pftDate);
        int GetRunTimeVersion(ref long pftActivationDate, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzRunTimeVersion, ref uint pdwSize);
        void GetNumAssemblies(ref long pftActivationDate, out uint pdwNumAsms);
        void GetHistoryAssembly(ref long pftActivationDate, uint dwIdx, [MarshalAs(UnmanagedType.IUnknown)] out object ppHistAsm);
    }
}

