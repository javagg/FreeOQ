// Type: SmartQuant.Providers.HistoricalDataErrorEventArgs
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using dW79p7NPlS6ZxObcx3;
using SmartQuant.FIX;
using System.Runtime.CompilerServices;

namespace SmartQuant.Providers
{
  public class HistoricalDataErrorEventArgs : HistoricalDataEventArgs
  {
    private string gmVtz3N4KF;

    public string Message
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.gmVtz3N4KF;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HistoricalDataErrorEventArgs(string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength, string message)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector(requestId, instrument, provider, dataLength);
      this.gmVtz3N4KF = message;
    }
  }
}
