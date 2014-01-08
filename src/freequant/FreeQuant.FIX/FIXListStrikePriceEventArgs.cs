using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXListStrikePriceEventArgs : EventArgs
  {
    private FIXListStrikePrice aeG77PSKT4;

    public FIXListStrikePrice ListStrikePrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aeG77PSKT4;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.aeG77PSKT4 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXListStrikePriceEventArgs(FIXListStrikePrice ListStrikePrice)
    {
      this.aeG77PSKT4 = ListStrikePrice;
    }
  }
}
