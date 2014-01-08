using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class MarketDataRequestReject : FIXMarketDataRequestReject
  {
    public MDReqRejReason MDReqRejReason
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXMDReqRejReason.FromFIX(base.MDReqRejReason);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.MDReqRejReason = FIXMDReqRejReason.ToFIX(value);
      }
    }

  }
}
