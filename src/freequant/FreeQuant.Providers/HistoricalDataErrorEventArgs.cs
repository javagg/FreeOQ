using dW79p7NPlS6ZxObcx3;
using FreeQuant.FIX;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
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
