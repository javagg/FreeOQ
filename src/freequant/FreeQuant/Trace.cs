using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant
{
  public class Trace
  {
    private const string awU4pgv4HD = "Framework";
    private static TraceSwitch e7F4dsWbmw;

    public static TraceListenerCollection Listeners
    {
       get
      {
        return (TraceListenerCollection) null;
      }
    }

    static Trace()
    {
			Trace.e7F4dsWbmw = new TraceSwitch("", "");
      Trace.e7F4dsWbmw.Level = System.Diagnostics.TraceLevel.Error;
      Trace.Listeners.Clear();
    }

    public Trace()
    {
    }

    public static bool IsLevelEnabled(System.Diagnostics.TraceLevel level)
    {
      return true;
    }

    public static void WriteLine(string message)
    {
    }

    internal static void Bin4gt8pGp([In] System.Diagnostics.TraceLevel obj0)
    {
    }

    [SpecialName]
    internal static bool G5l4bxXPvB()
    {
      return true;
    }

    [SpecialName]
    internal static void xIP4v5HAgN(bool value)
    {
    }
  }
}
