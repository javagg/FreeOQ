namespace FreeQuant.FIX
{
	public class RequestForPositions : FIXRequestForPositions
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
	}
}
