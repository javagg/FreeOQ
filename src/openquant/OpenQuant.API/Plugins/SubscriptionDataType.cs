using System;

namespace OpenQuant.API.Plugins
{
	///<summary>
	///  Subscription data type   
	///</summary>
	[Flags]
	public enum SubscriptionDataType
	{
		Trades = 1,
		Quotes = 2,
		OrderBook = 4,
	}
}
