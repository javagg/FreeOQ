// Type: SmartQuant.Trading.SeriesParam
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SmartQuant.Instruments;
using SmartQuant.Series;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
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
