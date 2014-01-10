namespace FreeQuant.Instruments
{
	public enum MarketDataType : byte
	{
		None = 0,
		Trade = 1,
		Quote = 2,
		MarketDepth = 4,
		All = 255,
	}
}
