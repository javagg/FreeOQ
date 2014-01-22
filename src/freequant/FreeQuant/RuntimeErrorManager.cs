using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant
{
  public class RuntimeErrorManager
  {
    internal const bool nA2BGO2KHy = true;
    internal const RuntimeErrorOutputTarget UjMB0H82ml = RuntimeErrorOutputTarget.PopupWindow;
    private static bool WyeBCRQ086;
    private static RuntimeErrorOutputTarget FtUB85klTb;
    private static RuntimeErrorCollection iZZBIw5Gyw;
    private static RuntimeErrorEventHandler YJpBlSg0vn;

    public static bool Enabled
    {
       get
      {
        return true;
      }
      set
      {
      }
    }

    public static RuntimeErrorOutputTarget Target
    {
       get
      {
				return RuntimeErrorOutputTarget.Console;
      }
       set
      {
      }
    }

    public static RuntimeErrorCollection Errors
    {
       get
      {
        return (RuntimeErrorCollection) null;
      }
    }

    public static event RuntimeErrorEventHandler Error
    {
        add
      {
      }
       remove
      {
      }
    }

    static RuntimeErrorManager()
    {
      RuntimeErrorManager.iZZBIw5Gyw = new RuntimeErrorCollection();
      RuntimeErrorManager.WyeBCRQ086 = false;
      RuntimeErrorManager.Enabled = true;
      RuntimeErrorManager.FtUB85klTb = RuntimeErrorOutputTarget.PopupWindow;
    }

    public RuntimeErrorManager()
    {
    }

    public static void ReportError(RuntimeError error)
    {
    }

    internal static void w3hBTZ3rk0()
    {
    }

    private static void JobBWwdwaA([In] object obj0, [In] UnhandledExceptionEventArgs obj1)
    {
    }
  }
}
