using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXBidRequestEventArgs : EventArgs
  {
    private FIXBidRequest qNgZXQL5bo;

    public FIXBidRequest BidRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.qNgZXQL5bo;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.qNgZXQL5bo = value;
      }
    }

    public FIXBidRequestEventArgs(FIXBidRequest BidRequest)
    {
      this.qNgZXQL5bo = BidRequest;
    }
  }
}
