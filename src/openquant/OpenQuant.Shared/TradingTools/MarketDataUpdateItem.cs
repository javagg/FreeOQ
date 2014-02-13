using FreeQuant.Data;

namespace OpenQuant.Shared.TradingTools
{
	class MarketDataUpdateItem
	{
		public MarketDataViewRow Row { get; private set; }

		public Quote Quote { get; private set; }

		public Trade Trade { get; private set; }

		public Bar Bar { get; private set; }

		public MarketDataUpdateItem(MarketDataViewRow row, Quote quote, Trade trade, Bar bar)
		{
			this.Row = row;
			this.Quote = quote;
			this.Trade = trade;
			this.Bar = bar;
		}
	}
}
