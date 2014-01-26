namespace FreeQuant.FIX
{
	public class OrderCancelRequest : FIXOrderCancelRequest
	{
		new public Side Side
		{
			get
			{
				return FIXSide.FromFIX(base.Side);
			}
			set
			{
				base.Side = FIXSide.ToFIX(value);
			}
		}
	}
}
