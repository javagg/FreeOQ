using FreeQuant.Instruments;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class DoubleParam
  {
    private Hashtable yvNRbXLeMW;

    public double this[Instrument instrument]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        object obj = this.yvNRbXLeMW[(object) instrument];
        if (obj != null)
          return (double) obj;
        else
          return 0.0;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.yvNRbXLeMW[(object) instrument] = (object) value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleParam()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      this.yvNRbXLeMW = new Hashtable();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
