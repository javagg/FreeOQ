using System;

namespace FreeQuant.Providers
{
	[Flags]
	public enum HistoricalDataType : byte
	{
		Trade = 1,
		Quote = 2,
		Bar = 4,
		Daily = 8,
		MarketDepth = 16,
	}
}
