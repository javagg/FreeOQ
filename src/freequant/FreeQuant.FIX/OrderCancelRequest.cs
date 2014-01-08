using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class OrderCancelRequest : FIXOrderCancelRequest
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

  }
}
