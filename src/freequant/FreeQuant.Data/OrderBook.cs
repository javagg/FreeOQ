using System;
//using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace FreeQuant.Data
{
	public class OrderBook
	{
		private OrderBookEntryList bid;
		private OrderBookEntryList ask;

		public OrderBookEntryList Bid
		{
			 get
			{
				return this.bid; 
			}
		}

		public OrderBookEntryList Ask
		{
			  get
			{
				return this.ask; 
			}
		}

		public event OrderBookEventHandler Changed;

		public OrderBook()
		{
			this.bid = new OrderBookEntryList();
			this.ask = new OrderBookEntryList();
		}

		public void Clear()
		{
			this.bid.Clear();
			this.ask.Clear();
		}

		public void Add(MarketDepth marketDepth)
		{
			try
			{
				OrderBookEntryList orderBookEntryList;
				switch (marketDepth.Side)
				{
					case MDSide.Bid:
						orderBookEntryList = this.bid;
						break;
					case MDSide.Ask:
						orderBookEntryList = this.ask;
						break;
					default:
						throw new ArgumentException("" + ((object)marketDepth.Side).ToString());
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
							this.EmitOrderBookEvent(marketDepth.Side, marketDepth.Operation, index);
							break;
						}
						else
						{
							orderBookEntryList.Insert(marketDepth.Position, new OrderBookEntry(marketDepth.DateTime, marketDepth.Price, marketDepth.Size));
							this.EmitOrderBookEvent(marketDepth.Side, marketDepth.Operation, marketDepth.Position);
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
						this.EmitOrderBookEvent(marketDepth.Side, marketDepth.Operation, marketDepth.Position);
						break;
					case MDOperation.Delete:
						if (marketDepth.Position == -1)
							break;
						orderBookEntryList.RemoveAt(marketDepth.Position);
						this.EmitOrderBookEvent(marketDepth.Side, marketDepth.Operation, marketDepth.Position);
						break;
					case MDOperation.Reset:
						orderBookEntryList.Clear();
						this.EmitOrderBookEvent(marketDepth.Side, marketDepth.Operation, marketDepth.Position);
						break;
					case MDOperation.Undefined:
						break;
					default:
						throw new ArgumentException("" + ((object)marketDepth.Operation).ToString());
				}
			}
			catch (Exception ex)
			{
				Trace.WriteLine(ex);
			}
		}

		public Quote GetQuote(int level)
		{
			DateTime datetime = DateTime.MinValue;
			double bid = 0.0;
			double ask = 0.0;
			int bidSize = 0;
			int askSize = 0;
			if (level < this.bid.Count)
			{
				OrderBookEntry orderBookEntry = this.bid[level];
				bid = orderBookEntry.Price;
				bidSize = orderBookEntry.Size;
				if (orderBookEntry.DateTime > datetime)
					datetime = orderBookEntry.DateTime;
			}
			if (level < this.ask.Count)
			{
				OrderBookEntry orderBookEntry = this.ask[level];
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
			foreach (OrderBookEntry orderBookEntry in this.bid)
				num += orderBookEntry.Size;
			return num;
		}

		public int GetAskVolume()
		{
			int num = 0;
			foreach (OrderBookEntry orderBookEntry in this.ask)
				num += orderBookEntry.Size;
			return num;
		}

		public double GetAvgBidPrice()
		{
			double num1 = 0.0;
			double num2 = 0.0;
			foreach (OrderBookEntry orderBookEntry in this.bid)
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
			foreach (OrderBookEntry orderBookEntry in this.ask)
			{
				num1 += orderBookEntry.Price * (double)orderBookEntry.Size;
				num2 += (double)orderBookEntry.Size;
			}
			return num1 / num2;
		}

		public double GetAvgBidPrice(double qty)
		{
			lock (this.bid.SyncRoot)
			{
				if (this.bid.Count == 0)
					return 0.0;
				double local_0 = 0.0;
				double local_1 = qty;
				foreach (OrderBookEntry item_0 in this.bid)
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
					local_0 += this.bid[this.bid.Count - 1].Price * local_1;
				return local_0 / qty;
			}
		}

		public double GetAvgAskPrice(double qty)
		{
			lock (this.ask.SyncRoot)
			{
				if (this.ask.Count == 0)
					return 0.0;
				double local_0 = 0.0;
				double local_1 = qty;
				foreach (OrderBookEntry item_0 in this.ask)
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
					local_0 += this.ask[this.ask.Count - 1].Price * local_1;
				return local_0 / qty;
			}
		}

		private void EmitOrderBookEvent([In] MDSide obj0, [In] MDOperation obj1, [In] int obj2)
		{
			if (this.Changed == null)
				return;
			this.Changed(this, new OrderBookEventArgs(obj0, obj1, obj2));
		}
	}
}
