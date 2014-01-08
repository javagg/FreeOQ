using FreeQuant.Instruments;
using FreeQuant.Series;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class SeriesParam
  {
    private Hashtable BxPphSSHW;

    public TimeSeries this[Instrument instrument]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (TimeSeries) this.BxPphSSHW[(object) instrument];
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.BxPphSSHW[(object) instrument] = (object) value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SeriesParam()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      this.BxPphSSHW = new Hashtable();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
