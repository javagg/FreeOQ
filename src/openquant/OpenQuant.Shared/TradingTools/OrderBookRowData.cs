namespace OpenQuant.Shared.TradingTools
{
	class OrderBookRowData
	{
		public double Price { get; set; }
		public int? BidSize { get; set; }
		public int? AskSize { get; set; }

		public OrderBookRowData(double price, int? bidSize, int? askSize)
		{
			this.Price = price;
			this.BidSize = bidSize;
			this.AskSize = askSize;
		}
	}
}
