// Type: SmartQuant.Providers.HistoricalTradeEventArgs
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using dW79p7NPlS6ZxObcx3;
using SmartQuant.Data;
using SmartQuant.FIX;
using System.Runtime.CompilerServices;

namespace SmartQuant.Providers
{
  public class HistoricalTradeEventArgs : HistoricalDataEventArgs
  {
    private Trade lehtRHhNfe;

    public Trade Trade
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.lehtRHhNfe;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HistoricalTradeEventArgs(Trade trade, string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector(requestId, instrument, provider, dataLength);
      this.lehtRHhNfe = trade;
    }
  }
}
