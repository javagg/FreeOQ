using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXMultilegOrderCancelReplaceEventArgs : EventArgs
  {
    private FIXMultilegOrderCancelReplace tyaUGMrlAB;

    public FIXMultilegOrderCancelReplace MultilegOrderCancelReplace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.tyaUGMrlAB;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.tyaUGMrlAB = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXMultilegOrderCancelReplaceEventArgs(FIXMultilegOrderCancelReplace MultilegOrderCancelReplace)
    {
      this.tyaUGMrlAB = MultilegOrderCancelReplace;
    }
  }
}
