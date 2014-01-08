using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXYieldDataEventArgs : EventArgs
  {
    private FIXYieldData sCTtTxqwjN;

    public FIXYieldData YieldData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.sCTtTxqwjN;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.sCTtTxqwjN = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXYieldDataEventArgs(FIXYieldData YieldData)
    {
      this.sCTtTxqwjN = YieldData;
    }
  }
}
