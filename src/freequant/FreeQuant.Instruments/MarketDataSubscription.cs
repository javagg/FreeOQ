// Type: SmartQuant.Instruments.MarketDataSubscription
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using FreeQuant.Providers;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
  public class MarketDataSubscription
  {
    public IMarketDataProvider Provider { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public Instrument Instrument { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public MarketDataType MDType { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public int Count { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal MarketDataSubscription(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType, int count)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Provider = provider;
      this.Instrument = instrument;
      this.MDType = mdType;
      this.Count = count;
    }
  }
}
