using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class PositionReport : FIXPositionReport
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

    public PosReqResult PosReqResult
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXPosReqResult.FromFIX(base.PosReqResult);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.PosReqResult = FIXPosReqResult.ToFIX(value);
      }
    }

    public PutOrCall PutOrCall
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXPutOrCall.FromFIX(base.PutOrCall);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.PutOrCall = FIXPutOrCall.ToFIX(value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PositionReport()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
