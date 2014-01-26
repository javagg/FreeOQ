namespace FreeQuant.FIX
{
	public enum ExecType
	{
		Undefined,
		New,
		PartialFill,
		Fill,
		DoneForDay,
		Cancelled,
		Replace,
		PendingCancel,
		Stopped,
		Rejected,
		Suspended,
		PendingNew,
		Calculated,
		Expired,
		Restarted,
		PendingReplace,
		Trade,
		TradeCorrect,
		TradeCancel,
		OrderStatus
	}
}
