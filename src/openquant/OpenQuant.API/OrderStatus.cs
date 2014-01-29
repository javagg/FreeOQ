namespace OpenQuant.API
{
	/// <summary>
	/// Order status
	/// </summary>
	public enum OrderStatus
	{
		PendingNew,
		New,
		PartiallyFilled,
		Filled,
		PendingCancel,
		Cancelled,
		Expired,
		PendingReplace,
		Replaced,
		Rejected
	}
}
