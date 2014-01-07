using dW79p7NPlS6ZxObcx3;
using FreeQuant.FIX;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  public class HistoricalDataEventArgs : EventArgs
  {
    private string H9ltj3TryK;
    private IFIXInstrument NButDmKUgp;
    private IHistoricalDataProvider vout5BdExI;
    private int DTstOgqTvw;

    public string RequestId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.H9ltj3TryK;
      }
    }

    public IFIXInstrument Instrument
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.NButDmKUgp;
      }
    }

    public IHistoricalDataProvider Provider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.vout5BdExI;
      }
    }

    public int DataLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.DTstOgqTvw;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HistoricalDataEventArgs(string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.H9ltj3TryK = requestId;
      this.NButDmKUgp = instrument;
      this.vout5BdExI = provider;
      this.DTstOgqTvw = dataLength;
    }
  }
}
