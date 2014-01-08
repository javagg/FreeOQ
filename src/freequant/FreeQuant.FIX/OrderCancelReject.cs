using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class OrderCancelReject : FIXOrderCancelReject
  {
    public OrdStatus OrdStatus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXOrdStatus.FromFIX(base.OrdStatus);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.OrdStatus = FIXOrdStatus.ToFIX(value);
      }
    }

    public CxlRejResponseTo CxlRejResponseTo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXCxlRejResponseTo.FromFIX(base.CxlRejResponseTo);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.CxlRejResponseTo = FIXCxlRejResponseTo.ToFIX(value);
      }
    }

    public CxlRejReason CxlRejReason
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXCxlRejReason.FromFIX(base.CxlRejReason);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.CxlRejReason = FIXCxlRejReason.ToFIX(value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrderCancelReject()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
