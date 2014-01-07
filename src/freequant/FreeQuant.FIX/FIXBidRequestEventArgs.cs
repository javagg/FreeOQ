using QjaKfQ9Jr3AV8F2T87;
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXBidRequestEventArgs(FIXBidRequest BidRequest)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.qNgZXQL5bo = BidRequest;
    }
  }
}
