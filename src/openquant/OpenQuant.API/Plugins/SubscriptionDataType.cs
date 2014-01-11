using System;

namespace OpenQuant.API.Plugins
{
	[Flags]
	public enum SubscriptionDataType
	{
		Trades = 1,
		Quotes = 2,
		OrderBook = 4,
	}
}
