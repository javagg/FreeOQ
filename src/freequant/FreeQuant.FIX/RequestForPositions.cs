using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class RequestForPositions : FIXRequestForPositions
  {
    public PosReqType PosReqType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXPosReqType.FromFIX(base.PosReqType);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.PosReqType = FIXPosReqType.ToFIX(value);
      }
    }
  }
}
