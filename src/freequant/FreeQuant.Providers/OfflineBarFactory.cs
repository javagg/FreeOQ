using FreeQuant.Data;
using FreeQuant.FIX;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace FreeQuant.Providers
{
	public class OfflineBarFactory : IBarFactory
	{
		private Dictionary<IFIXInstrument, Dictionary<BarType, SortedList<long, OfflineBarFactory.BarSizeCounter>>> ReSeeRRAl;
		private Dictionary<IFIXInstrument, Quote> ALv6cyCmM;

		[DefaultValue(true)]
		public bool Enabled { get; set; }

		[DefaultValue(BarFactoryInput.Trade)]
		public BarFactoryInput Input { get; set; }

		public BarFactoryItemList Items { get; private set; }

		public event BarEventHandler NewBar;
		public event BarEventHandler NewBarOpen;
		public event BarSliceEventHandler NewBarSlice;

		public OfflineBarFactory()
		{
			this.Enabled = true;
			this.Input = BarFactoryInput.Trade;
			this.Items = new BarFactoryItemList();
			this.ReSeeRRAl = new Dictionary<IFIXInstrument, Dictionary<BarType, SortedList<long, OfflineBarFactory.BarSizeCounter>>>();
			this.ALv6cyCmM = new Dictionary<IFIXInstrument, Quote>();
		}

		public void OnNewTrade(IFIXInstrument instrument, Trade trade)
		{
			if (this.Enabled && this.Input == BarFactoryInput.Trade)
			{
				this.AddTrade(instrument, trade.DateTime, trade.Price, trade.Size);
			}
		}

		public void OnNewQuote(IFIXInstrument instrument, Quote quote)
		{
			if (!this.Enabled)
				return;
			Quote quote1;
			if (!this.ALv6cyCmM.TryGetValue(instrument, out quote1))
			{
				quote1 = new Quote();
				this.ALv6cyCmM.Add(instrument, quote1);
			}
			switch (this.Input)
			{
				case BarFactoryInput.Bid:
					if (quote.Bid != quote1.Bid || quote.BidSize != quote1.BidSize)
					{
						this.AddTrade(instrument, quote.DateTime, quote.Bid, quote.BidSize);
					}
					break;
				case BarFactoryInput.Ask:
					if (quote.Ask != quote1.Ask || quote.AskSize != quote1.AskSize)
					{
						this.AddTrade(instrument, quote.DateTime, quote.Ask, quote.AskSize);
					}
					break;
				case BarFactoryInput.BidAsk:
					if (quote.Ask != quote1.Ask || quote.AskSize != quote1.AskSize)
						this.AddTrade(instrument, quote.DateTime, quote.Ask, quote.AskSize);
					if (quote.Bid != quote1.Bid || quote.BidSize != quote1.BidSize)
					{
						this.AddTrade(instrument, quote.DateTime, quote.Bid, quote.BidSize);
					}
					break;
				case BarFactoryInput.Middle:
					if (quote.Ask != quote1.Ask || quote.AskSize != quote1.AskSize || (quote.Bid != quote1.Bid || quote.BidSize != quote1.BidSize))
					{
						this.AddTrade(instrument, quote.DateTime, (quote.Ask + quote.Bid) / 2.0, (quote.AskSize + quote.BidSize) / 2);
					}
					break;
				case BarFactoryInput.Spread:
					if (quote.Ask != quote1.Ask || quote.AskSize != quote1.AskSize || (quote.Bid != quote1.Bid || quote.BidSize != quote1.BidSize))
					{
						this.AddTrade(instrument, quote.DateTime, quote.Ask - quote.Bid, 0);
					}
					break;
			}
			quote1.Ask = quote.Ask;
			quote1.Bid = quote.Bid;
			quote1.AskSize = quote.AskSize;
			quote1.BidSize = quote.BidSize;
		}

		public void Reset()
		{
			this.ReSeeRRAl.Clear();
			this.ALv6cyCmM.Clear();
		}

		private void AddTrade(IFIXInstrument instrument, DateTime datetime, double price, int size)
		{
			foreach (BarFactoryItem barFactoryItem in this.Items)
			{
				if (barFactoryItem.Enabled)
				{
					Dictionary<BarType, SortedList<long, OfflineBarFactory.BarSizeCounter>> dictionary;
					if (!this.ReSeeRRAl.TryGetValue(instrument, out dictionary))
					{
						dictionary = new Dictionary<BarType, SortedList<long, OfflineBarFactory.BarSizeCounter>>();
						this.ReSeeRRAl.Add(instrument, dictionary);
					}
					SortedList<long, OfflineBarFactory.BarSizeCounter> sortedList;
					if (!dictionary.TryGetValue(barFactoryItem.BarType, out sortedList))
					{
						sortedList = new SortedList<long, OfflineBarFactory.BarSizeCounter>();
						dictionary.Add(barFactoryItem.BarType, sortedList);
					}
					OfflineBarFactory.BarSizeCounter gcuMn6TqoRuEfhwr;
					if (!sortedList.TryGetValue(barFactoryItem.BarSize, out gcuMn6TqoRuEfhwr))
					{
						gcuMn6TqoRuEfhwr = new OfflineBarFactory.BarSizeCounter();
						sortedList.Add(barFactoryItem.BarSize, gcuMn6TqoRuEfhwr);
					}
					switch (barFactoryItem.BarType)
					{
						case BarType.Time:
							if (gcuMn6TqoRuEfhwr.bar == null || gcuMn6TqoRuEfhwr.bar.EndTime <= datetime)
							{
								if (gcuMn6TqoRuEfhwr.bar != null)
									this.M28GqE2S2(instrument, gcuMn6TqoRuEfhwr.bar);
								DateTime dateTime1;
								DateTime dateTime2;
								this.iYlXRwvKS(datetime, barFactoryItem.BarSize, out dateTime1, out dateTime2);
								gcuMn6TqoRuEfhwr.bar = this.ssgZj9bjo(BarType.Time, barFactoryItem.BarSize, dateTime1, dateTime2, price);
							}
							this.jtf8pUBX1(gcuMn6TqoRuEfhwr.bar, price, size);
							continue;
						case BarType.Tick:
							if (gcuMn6TqoRuEfhwr.bar == null)
								gcuMn6TqoRuEfhwr.bar = this.ssgZj9bjo(BarType.Tick, barFactoryItem.BarSize, datetime, datetime, price);
							this.jtf8pUBX1(gcuMn6TqoRuEfhwr.bar, price, size);
							gcuMn6TqoRuEfhwr.bar.EndTime = datetime;
							if ((long)++gcuMn6TqoRuEfhwr.counter == barFactoryItem.BarSize)
							{
								this.M28GqE2S2(instrument, gcuMn6TqoRuEfhwr.bar);
								gcuMn6TqoRuEfhwr.bar = null;
								gcuMn6TqoRuEfhwr.counter = 0;
								continue;
							}
							else
								continue;
						case BarType.Volume:
							if (gcuMn6TqoRuEfhwr.bar == null)
								gcuMn6TqoRuEfhwr.bar = this.ssgZj9bjo(BarType.Volume, barFactoryItem.BarSize, datetime, datetime, price);
							this.jtf8pUBX1(gcuMn6TqoRuEfhwr.bar, price, size);
							gcuMn6TqoRuEfhwr.bar.EndTime = datetime;
							if (gcuMn6TqoRuEfhwr.bar.Volume >= barFactoryItem.BarSize)
							{
								this.M28GqE2S2(instrument, gcuMn6TqoRuEfhwr.bar);
								gcuMn6TqoRuEfhwr.bar = null;
								continue;
							}
							else
								continue;
						default:
							continue;
					}
				}
			}
		}

		private void jtf8pUBX1(Bar bar, double price, int size)
		{
			if (price > bar.High)
				bar.High = price;
			if (price < bar.Low)
				bar.Low = price;
			bar.Close = price;
			bar.Volume += size;
		}

		private Bar ssgZj9bjo(BarType obj0, long obj1, DateTime obj2, DateTime obj3, double obj4)
		{
			return new Bar(obj0, obj1, obj2, obj3, obj4, obj4, obj4, obj4, 0, 0);
		}

		private void iYlXRwvKS(DateTime obj0, long obj1, out DateTime _param3, out DateTime _param4)
		{
			long num = (long)obj0.TimeOfDay.TotalSeconds / obj1 * obj1;
			_param3 = obj0.Date.AddSeconds((double)num);
			_param4 = _param3.AddSeconds((double)obj1);
		}

		private void CgiTKf5gQ(IFIXInstrument instrument, Bar bar)
		{
//      if (this.JL8oPByHO != null)
//      this.JL8oPByHO(this, new BarEventArgs(bar, instrument, null));
		}

		private void M28GqE2S2(IFIXInstrument instrument, Bar bar)
		{
//      if (this.CSbm1wLhQ != null)
//      this.CSbm1wLhQ(this, new BarEventArgs(bar, instrument, null));
		}

		private void jsgfiCe1q(IFIXInstrument instrument, long size)
		{
			if (this.NewBarSlice != null)
				this.NewBarSlice(this, new BarSliceEventArgs(size, null));
		}

		public override string ToString()
		{
			return "OfflineBarFactory";
		}

		private class BarSizeCounter
		{
			public Bar bar;
			public int counter;

			public BarSizeCounter()
			{
				this.bar = null;
				this.counter = 0;
			}
		}
	}
}
