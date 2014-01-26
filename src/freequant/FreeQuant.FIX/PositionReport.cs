using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class PositionReport : FIXPositionReport
  {
		new public PosReqType PosReqType
    {
      get
      {
        return FIXPosReqType.FromFIX(base.PosReqType);
      }
      set
      {
        base.PosReqType = FIXPosReqType.ToFIX(value);
      }
    }

		new public PosReqResult PosReqResult
    {
      get
      {
        return FIXPosReqResult.FromFIX(base.PosReqResult);
      }
      set
      {
        base.PosReqResult = FIXPosReqResult.ToFIX(value);
      }
    }

		new public PutOrCall PutOrCall
    {
      get
      {
        return FIXPutOrCall.FromFIX(base.PutOrCall);
      }
      set
      {
        base.PutOrCall = FIXPutOrCall.ToFIX(value);
      }
    }

  }
}
