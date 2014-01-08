using FreeQuant.Instruments;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class IntParam
  {
    private Hashtable Whi61bRdZC;

    public int this[Instrument instrument]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        object obj = this.Whi61bRdZC[(object) instrument];
        if (obj != null)
          return (int) obj;
        else
          return 0;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Whi61bRdZC[(object) instrument] = (object) value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntParam()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      this.Whi61bRdZC = new Hashtable();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
