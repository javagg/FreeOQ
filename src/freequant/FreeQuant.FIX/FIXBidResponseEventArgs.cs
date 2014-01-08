
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXBidResponseEventArgs : EventArgs
  {
    private FIXBidResponse tGwyy1CtAC;

    public FIXBidResponse BidResponse
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.tGwyy1CtAC;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.tGwyy1CtAC = value;
      }
    }

    public FIXBidResponseEventArgs(FIXBidResponse BidResponse)
    {
      this.tGwyy1CtAC = BidResponse;
    }
  }
}
