using System;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenQuant.Finam
{
  public static class MarshalUTF8
  {
    private static UTF8Encoding utf8 = new UTF8Encoding();

    static MarshalUTF8()
    {
    }

    public static IntPtr StringToHGlobalUTF8(string data)
    {
      byte[] bytes = MarshalUTF8.utf8.GetBytes(data);
      IntPtr destination = Marshal.AllocHGlobal(Marshal.SizeOf((object) bytes[0]) * bytes.Length);
      Marshal.Copy(bytes, 0, destination, bytes.Length);
      return destination;
    }

    public static string PtrToStringUTF8(IntPtr pData)
    {
      int length = Marshal.PtrToStringAnsi(pData).Length;
      byte[] numArray = new byte[length];
      Marshal.Copy(pData, numArray, 0, length);
      return MarshalUTF8.utf8.GetString(numArray);
    }
  }
}
