namespace OpenQuant.API
{
	/// <summary>
	/// Order type (market, limit, stop, stop limit)
	/// </summary>
	public enum OrderType
	{
		Market,
		Limit,
		Stop,
		StopLimit,
		Trail,
		TrailLimit,
		MarketOnClose,
	}
}
