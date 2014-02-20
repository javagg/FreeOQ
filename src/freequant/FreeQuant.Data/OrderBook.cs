using System;
using System.Diagnostics;

namespace FreeQuant.Data
{
	public class OrderBook
	{
        private OrderBookEntryList bidList; 
        private OrderBookEntryList askList; 

		public OrderBookEntryList Bid
		{
			 get
			{
				return this.bidList; 
			}
		}

		public OrderBookEntryList Ask
		{
			  get
			{
				return this.askList; 
			}
		}

		public event OrderBookEventHandler Changed;

		public OrderBook()
		{
			this.bidList = new OrderBookEntryList();
			this.askList = new OrderBookEntryList();
		}

		public void Clear()
		{
			this.bidList.Clear();
			this.askList.Clear();
		}

		public void Add(MarketDepth marketDepth)
		{
			try
			{
				OrderBookEntryList orderBookEntryList;
				switch (marketDepth.Side)
				{
					case MDSide.Bid:
						orderBookEntryList = this.bidList;
						break;
					case MDSide.Ask:
						orderBookEntryList = this.askList;
						break;
					default:
						throw new ArgumentException("Invalid Side" + marketDepth.Side);
				}

				switch (marketDepth.Operation)
				{
					case MDOperation.Insert:
						if (marketDepth.Position == -1)
						{
							int index = -1;
							switch (marketDepth.Side)
							{
								case MDSide.Bid:
									index = 0;
									while (index < orderBookEntryList.Count && marketDepth.Price <= orderBookEntryList[index].Price)
										++index;
									break;
								case MDSide.Ask:
									index = orderBookEntryList.Count;
									while (index > 0 && marketDepth.Price <= orderBookEntryList[index - 1].Price)
										--index;
									break;
							}
							orderBookEntryList.Insert(index, new OrderBookEntry(marketDepth.DateTime, marketDepth.Price, marketDepth.Size));
							this.EmitChanged(marketDepth.Side, marketDepth.Operation, index);
							break;
						}
						else
						{
							orderBookEntryList.Insert(marketDepth.Position, new OrderBookEntry(marketDepth.DateTime, marketDepth.Price, marketDepth.Size));
							this.EmitChanged(marketDepth.Side, marketDepth.Operation, marketDepth.Position);
							break;
						}
					case MDOperation.Update:
						if (marketDepth.Position == -1 || marketDepth.Position >= orderBookEntryList.Count)
							break;
						OrderBookEntry orderBookEntry = orderBookEntryList[marketDepth.Position];
						orderBookEntry.DateTime = marketDepth.DateTime;
						orderBookEntry.Size = marketDepth.Size;
						if (marketDepth.Price > 0.0)
							orderBookEntry.Price = marketDepth.Price;
						this.EmitChanged(marketDepth.Side, marketDepth.Operation, marketDepth.Position);
						break;
					case MDOperation.Delete:
						if (marketDepth.Position == -1)
							break;
						orderBookEntryList.RemoveAt(marketDepth.Position);
						this.EmitChanged(marketDepth.Side, marketDepth.Operation, marketDepth.Position);
						break;
					case MDOperation.Reset:
						orderBookEntryList.Clear();
						this.EmitChanged(marketDepth.Side, marketDepth.Operation, marketDepth.Position);
						break;
					case MDOperation.Undefined:
						break;
					default:
                        throw new ArgumentException("MDOperation is unknown: " + marketDepth.Operation.ToString());
				}
			}
			catch (Exception ex)
			{
                Trace.WriteLine(ex.ToString());
			}
		}

		public Quote GetQuote(int level)
		{
			DateTime datetime = DateTime.MinValue;
			double bid = 0.0;
			double ask = 0.0;
			int bidSize = 0;
			int askSize = 0;
			if (level < this.bidList.Count)
			{
				OrderBookEntry orderBookEntry = this.bidList[level];
				bid = orderBookEntry.Price;
				bidSize = orderBookEntry.Size;
				if (orderBookEntry.DateTime > datetime)
					datetime = orderBookEntry.DateTime;
			}
			if (level < this.askList.Count)
			{
				OrderBookEntry orderBookEntry = this.askList[level];
				ask = orderBookEntry.Price;
				askSize = orderBookEntry.Size;
				if (orderBookEntry.DateTime > datetime)
					datetime = orderBookEntry.DateTime;
			}
			return new Quote(datetime, bid, bidSize, ask, askSize);
		}

		public int GetBidVolume()
		{
			int num = 0;
			foreach (OrderBookEntry orderBookEntry in this.bidList)
				num += orderBookEntry.Size;
			return num;
		}

		public int GetAskVolume()
		{
			int num = 0;
			foreach (OrderBookEntry orderBookEntry in this.askList)
				num += orderBookEntry.Size;
			return num;
		}

		public double GetAvgBidPrice()
		{
			double num1 = 0.0;
			double num2 = 0.0;
			foreach (OrderBookEntry orderBookEntry in this.bidList)
			{
				num1 += orderBookEntry.Price * (double)orderBookEntry.Size;
				num2 += (double)orderBookEntry.Size;
			}
			return num1 / num2;
		}

		public double GetAvgAskPrice()
		{
			double num1 = 0.0;
			double num2 = 0.0;
			foreach (OrderBookEntry orderBookEntry in this.askList)
			{
				num1 += orderBookEntry.Price * (double)orderBookEntry.Size;
				num2 += (double)orderBookEntry.Size;
			}
			return num1 / num2;
		}

		public double GetAvgBidPrice(double qty)
		{
			lock (this.bidList.SyncRoot)
			{
				if (this.bidList.Count == 0)
					return 0.0;
				double local_0 = 0.0;
				double local_1 = qty;
				foreach (OrderBookEntry item_0 in this.bidList)
				{
					if (local_1 >= (double)item_0.Size)
					{
						local_0 += item_0.Price * (double)item_0.Size;
						local_1 -= (double)item_0.Size;
					}
					else
					{
						local_0 += item_0.Price * local_1;
						local_1 = 0.0;
					}
					if (local_1 <= 0.0)
						break;
				}
				if (local_1 > 0.0)
					local_0 += this.bidList[this.bidList.Count - 1].Price * local_1;
				return local_0 / qty;
			}
		}

		public double GetAvgAskPrice(double qty)
		{
			lock (this.askList.SyncRoot)
			{
				if (this.askList.Count == 0)
					return 0.0;
				double local_0 = 0.0;
				double local_1 = qty;
				foreach (OrderBookEntry item_0 in this.askList)
				{
					if (local_1 >= (double)item_0.Size)
					{
						local_0 += item_0.Price * (double)item_0.Size;
						local_1 -= (double)item_0.Size;
					}
					else
					{
						local_0 += item_0.Price * local_1;
						local_1 = 0.0;
					}
					if (local_1 <= 0.0)
						break;
				}
				if (local_1 > 0.0)
					local_0 += this.askList[this.askList.Count - 1].Price * local_1;
				return local_0 / qty;
			}
		}

		private void EmitChanged(MDSide side, MDOperation operation, int position)
		{
			if (this.Changed != null)
				this.Changed(this, new OrderBookEventArgs(side, operation, position));
		}
	}
}
