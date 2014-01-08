using OpenQuant.API;

namespace OpenQuant.Finam
{
	public class OpenBookReturn
	{
		public BidAsk Side { get; set; }

		public OrderBookAction Action { get; set; }

		public double Price { get; set; }

		public int Size { get; set; }

		public int Position { get; set; }

		public OpenBookReturn(TransaqOpenBook tq, int position, int type)
		{
			if (tq.Sell > 0 || tq.Sell == -1)
			{
				this.Side = BidAsk.Ask;
				this.Size = tq.Sell;
			}
			if (tq.Buy > 0 || tq.Buy == -1)
			{
				this.Side = BidAsk.Bid;
				this.Size = tq.Buy;
			}
			switch (type)
			{
				case 1:
					this.Action = OrderBookAction.Delete;
					break;
				case 2:
					this.Action = OrderBookAction.Insert;
					break;
				case 3:
					this.Action = OrderBookAction.Update;
					break;
				default:
					this.Action = OrderBookAction.Undefined;
					break;
			}
			this.Price = tq.Price;
			this.Position = position;
		}
	}
}
