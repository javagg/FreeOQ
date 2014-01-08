using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class Reject : FIXReject
  {
    public SessionRejectReason SessionRejectReason
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXSessionRejectReason.FromFIX(base.SessionRejectReason);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.SessionRejectReason = FIXSessionRejectReason.ToFIX(value);
      }
    }
  }
}
