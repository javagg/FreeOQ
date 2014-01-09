using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class OrderCancelReplaceRequest : FIXOrderCancelReplaceRequest
  {
    public Side Side
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXSide.FromFIX(base.Side);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.Side = FIXSide.ToFIX(value);
      }
    }

    public OrdType OrdType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXOrdType.FromFIX(base.OrdType);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.OrdType = FIXOrdType.ToFIX(value);
      }
    }

    public TimeInForce TimeInForce
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXTimeInForce.FromFIX(base.TimeInForce);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.TimeInForce = FIXTimeInForce.ToFIX(value);
      }
    }

 
  }
}
