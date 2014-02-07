using FreeQuant;
using FreeQuant.Data;
using FreeQuant.FIX;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace FreeQuant.Providers
{
	public class BarFactory : IBarFactory
	{
		private BarFactoryItemList items;
		private Hashtable A3ELH6L4QJ;
		private Hashtable NJNLAPvWPO;
		private Hashtable cqyLFWMOvs;

		[DefaultValue(true)]
		[Category("Status")]
		public bool Enabled { get; set; }

		[DefaultValue(BarFactoryInput.Trade)]
		public BarFactoryInput Input { get; set; }

		[Category("Items")]
		public BarFactoryItemList Items 
		{
			get
			{
				return this.items; 
			}
		}

		public event BarEventHandler NewBar;
		public event BarEventHandler NewBarOpen;
		public event BarSliceEventHandler NewBarSlice;

		public BarFactory() : this(true)
		{
		}

		public BarFactory(bool enabled)
		{
			this.Enabled = enabled;
			this.Input = BarFactoryInput.Trade;
			this.cqyLFWMOvs = new Hashtable();
			this.items = new BarFactoryItemList();
			this.items.Add(new BarFactoryItem());
			this.A3ELH6L4QJ = new Hashtable();
			this.NJNLAPvWPO = Hashtable.Synchronized(new Hashtable());
		}

		public void OnNewTrade(IFIXInstrument instrument, Trade trade)
		{
			if (!this.Enabled || this.Input != BarFactoryInput.Trade)
				return;
			this.AddTrade(instrument, DateTime.Now, trade.Price, trade.Size);
		}

		public void OnNewQuote(IFIXInstrument instrument, Quote quote)
		{
			if (!this.Enabled)
				return;
			double price;
			int size;
			switch (this.Input)
			{
				case BarFactoryInput.Bid:
					price = quote.Bid;
					size = quote.BidSize;
					break;
				case BarFactoryInput.Ask:
					price = quote.Ask;
					size = quote.AskSize;
					break;
				case BarFactoryInput.BidAsk:
					this.AddTrade(instrument, DateTime.Now, quote.Bid, quote.BidSize);
					this.AddTrade(instrument, DateTime.Now, quote.Ask, quote.AskSize);
					return;
				case BarFactoryInput.Middle:
					this.AddTrade(instrument, DateTime.Now, (quote.Ask + quote.Bid) / 2.0, (quote.AskSize + quote.BidSize) / 2);
					return;
				case BarFactoryInput.Spread:
					price = quote.Ask - quote.Bid;
					size = 0;
					break;
				default:
					return;
			}
			BarFactory.mU5OEr88NSmCpsBxeD u5Oer88NsmCpsBxeD = this.cqyLFWMOvs[instrument] as BarFactory.mU5OEr88NSmCpsBxeD;
			if (u5Oer88NsmCpsBxeD == null)
			{
				u5Oer88NsmCpsBxeD = new BarFactory.mU5OEr88NSmCpsBxeD();
				this.cqyLFWMOvs.Add(instrument, u5Oer88NsmCpsBxeD);
			}
			if (price == u5Oer88NsmCpsBxeD.price && size == u5Oer88NsmCpsBxeD.size)
				return;
			this.AddTrade(instrument, DateTime.Now, price, size);
			u5Oer88NsmCpsBxeD.price = price;
			u5Oer88NsmCpsBxeD.size = size;
		}

		public void Reset()
		{
			this.A3ELH6L4QJ.Clear();
			this.NJNLAPvWPO.Clear();
			this.cqyLFWMOvs.Clear();
		}

		private void AddTrade(IFIXInstrument instrument, DateTime datetime, double price, int size)
		{
			var list = new List<BarFactory.zNxuFsXhPSM7NAan2D>();
			lock (this)
			{
				foreach (BarFactoryItem item in this.items)
				{
					if (item.Enabled)
					{
						Hashtable local_2 = this.A3ELH6L4QJ[instrument] as Hashtable;
						if (local_2 == null)
						{
							local_2 = new Hashtable();
							this.A3ELH6L4QJ.Add(instrument, local_2);
						}
						SortedList local_3 = local_2[item.BarType] as SortedList;
						if (local_3 == null)
						{
							local_3 = new SortedList();
							local_2.Add(item.BarType, local_3);
						}
						switch (item.BarType)
						{
							case BarType.Time:
								Bar bar = local_3[item.BarSize] as Bar;
								if (bar == null)
								{
									DateTime local_5 = this.qJpLNA6Aiq(datetime, item.BarSize);
									Bar local_4_1 = new Bar(BarType.Time, item.BarSize, local_5, local_5, price, price, price, price, size, 0);
									local_3.Add(item.BarSize, local_4_1);
									list.Add(new BarFactory.zNxuFsXhPSM7NAan2D((BarFactory.yPiBmEZIjD7IoCdXp6)0, local_4_1));
									goto case BarType.Dynamic;
								}
								else
								{
									bar.EndTime = datetime;
									if (price > bar.High)
										bar.High = price;
									if (price < bar.Low)
										bar.Low = price;
									bar.Close = price;
									bar.Volume += size;
									goto case BarType.Dynamic;
								}
							case BarType.Tick:
								BarFactory.l9JS6GiROvEy77Co1R local_6 = local_3[item.BarSize] as BarFactory.l9JS6GiROvEy77Co1R;
								if (local_6 == null)
								{
									local_6 = new BarFactory.l9JS6GiROvEy77Co1R();
									local_6.bar = new Bar(BarType.Tick, item.BarSize, datetime, datetime, price, price, price, price, (long)size, 0);
									local_3.Add(item.BarSize, local_6);
									list.Add(new BarFactory.zNxuFsXhPSM7NAan2D((BarFactory.yPiBmEZIjD7IoCdXp6)0, local_6.bar));
								}
								else
								{
									local_6.bar.EndTime = datetime;
									if (price > local_6.bar.High)
										local_6.bar.High = price;
									if (price < local_6.bar.Low)
										local_6.bar.Low = price;
									local_6.bar.Close = price;
									local_6.bar.Volume += size;
									++local_6.VMmLV7HilK;
								}
								if (local_6.VMmLV7HilK == item.BarSize)
								{
									list.Add(new BarFactory.zNxuFsXhPSM7NAan2D((BarFactory.yPiBmEZIjD7IoCdXp6)1, local_6.bar));
									local_3.Remove(item.BarSize);
									goto case BarType.Dynamic;
								}
								else
									goto case BarType.Dynamic;
							case BarType.Volume:
								Bar local_7 = local_3[item.BarSize] as Bar;
								if (local_7 == null)
								{
									local_7 = new Bar(BarType.Volume, item.BarSize, datetime, datetime, price, price, price, price, size, 0);
									local_3.Add(item.BarSize, local_7);
									list.Add(new BarFactory.zNxuFsXhPSM7NAan2D((BarFactory.yPiBmEZIjD7IoCdXp6)0, local_7));
								}
								else
								{
									local_7.EndTime = datetime;
									if (price > local_7.High)
										local_7.High = price;
									if (price < local_7.Low)
										local_7.Low = price;
									local_7.Close = price;
									local_7.Volume += size;
								}
								if (local_7.Volume >= item.BarSize)
								{
									list.Add(new BarFactory.zNxuFsXhPSM7NAan2D((BarFactory.yPiBmEZIjD7IoCdXp6)1, local_7));
									local_3.Remove(item.BarSize);
									goto case BarType.Dynamic;
								}
								else
									goto case BarType.Dynamic;
							case BarType.Range:
								Bar local_8 = local_3[item.BarSize] as Bar;
								if (local_8 == null)
								{
									Bar local_8_1 = new Bar(BarType.Range, item.BarSize, datetime, datetime, price, price, price, price, size, 0);
									local_3.Add(item.BarSize, local_8_1);
									list.Add(new BarFactory.zNxuFsXhPSM7NAan2D((BarFactory.yPiBmEZIjD7IoCdXp6)0, local_8_1));
									goto case BarType.Dynamic;
								}
								else
								{
									local_8.EndTime = datetime;
									if (price > local_8.High)
										local_8.High = price;
									if (price < local_8.Low)
										local_8.Low = price;
									local_8.Volume += size;
									bool local_9 = false;
									while (!local_9)
									{
										if (10000.0 * (local_8.High - local_8.Low) >= item.BarSize)
										{
											Bar local_10 = new Bar(BarType.Range, item.BarSize, datetime, datetime, price, price, price, price, 0, 0);
											if (local_8.High == price)
											{
												local_8.High = local_8.Low + item.BarSize / 10000.0;
												local_8.Close = local_8.High;
												local_10.Low = local_8.High;
											}
											if (local_8.Low == price)
											{
												local_8.Low = local_8.High - item.BarSize / 10000.0;
												local_8.Close = local_8.Low;
												local_10.High = local_8.Low;
											}
											list.Add(new BarFactory.zNxuFsXhPSM7NAan2D((BarFactory.yPiBmEZIjD7IoCdXp6)1, local_8));
											list.Add(new BarFactory.zNxuFsXhPSM7NAan2D((BarFactory.yPiBmEZIjD7IoCdXp6)0, local_10));
											local_3[item.BarSize] = local_10;
											if (10000.0 * (local_10.High - local_10.Low) >= item.BarSize)
											{
												local_8 = local_10;
												local_9 = false;
											}
											else
												local_9 = true;
										}
										else
											local_9 = true;
									}
									goto case BarType.Dynamic;
								}
							case BarType.Dynamic:
								if (local_3.Count == 0)
								{
									local_2.Remove(item.BarType);
									if (local_2.Count == 0)
									{
										this.A3ELH6L4QJ.Remove(instrument);
										continue;
									}
									else
										continue;
								}
								else
									continue;
							default:
								throw new NotSupportedException("NotSupported: " + item.BarType);
						}
					}
				}
			}

			foreach (BarFactory.zNxuFsXhPSM7NAan2D nxuFsXhPsM7Naan2D in list)
			{
				switch (nxuFsXhPsM7Naan2D.XUfLqKE3Ac)
				{
					case (BarFactory.yPiBmEZIjD7IoCdXp6) 0:
						Bar bar = nxuFsXhPsM7Naan2D.bar;
						this.EmitNewBarOpen(bar, instrument);
						if (bar.BarType == BarType.Time)
						{
							this.nxZL6NXVXL(bar.BeginTime.AddSeconds(bar.Size));
							continue;
						}
						else
							continue;
					case (BarFactory.yPiBmEZIjD7IoCdXp6) 1:
						this.EmitNewBar(nxuFsXhPsM7Naan2D.bar, instrument);
						continue;
					default:
						continue;
				}
			}
		}

		private void nxZL6NXVXL(DateTime datetime)
		{
			if (!this.NJNLAPvWPO.Contains(datetime))
			{
				Clock.AddReminder(new ReminderEventHandler(this.nAMLprxZKC), datetime, null);
				this.NJNLAPvWPO.Add(datetime, null);
			}
		}

		private void EmitNewBar(Bar bar, IFIXInstrument instrument)
		{
			bar.IsComplete = true;
			if (this.NewBar != null)
			{
				this.NewBar(null, new BarEventArgs(bar, instrument, null));
			}
		}

		private void EmitNewBarOpen(Bar bar, IFIXInstrument instrument)
		{
			if (this.NewBarOpen != null)
			{
				this.NewBarOpen(null, new BarEventArgs(bar, instrument, null));
			}
		}

		private void EmitNewBarSlice(long size)
		{
			if (this.NewBarSlice != null)
			{
				this.NewBarSlice(null, new BarSliceEventArgs(size, null));
			}
		}

		private void nAMLprxZKC(ReminderEventArgs obj0)
		{
			SortedList sortedList = new SortedList();
			lock (this)
			{
				foreach (DictionaryEntry item_1 in new Hashtable(this.A3ELH6L4QJ))
				{
					IFIXInstrument local_2 = (IFIXInstrument)item_1.Key;
					Hashtable local_3 = (Hashtable)item_1.Value;
					SortedList local_4 = local_3[BarType.Time] as SortedList;
					if (local_4 != null)
					{
						foreach (DictionaryEntry item_0 in new SortedList(local_4))
						{
							long local_6 = (long)item_0.Key;
							Bar local_7 = (Bar)item_0.Value;
							if (local_7.BeginTime.AddSeconds(local_6) == obj0.SignalTime)
							{
								local_7.EndTime = obj0.SignalTime;
								ArrayList local_8 = sortedList[local_6] as ArrayList;
								if (local_8 == null)
								{
									local_8 = new ArrayList();
									sortedList.Add(local_6, local_8);
								}
								local_8.Add(new KeyValuePair<IFIXInstrument, Bar>(local_2, local_7));
								local_4.Remove(local_6);
							}
						}
						if (local_4.Count == 0)
							local_3.Remove(BarType.Time);
						if (local_3.Count == 0)
							this.A3ELH6L4QJ.Remove(local_2);
					}
				}
			}
			foreach (DictionaryEntry dictionaryEntry in sortedList)
			{
				long num = (long)dictionaryEntry.Key;
				foreach (KeyValuePair<IFIXInstrument, Bar> keyValuePair in (ArrayList) dictionaryEntry.Value)
					this.EmitNewBar(keyValuePair.Value, keyValuePair.Key);
				this.EmitNewBarSlice(num);
			}
			this.NJNLAPvWPO.Remove(obj0.SignalTime);
		}

		private DateTime qJpLNA6Aiq(DateTime datetime, long obj1)
		{
			long num = (long)datetime.TimeOfDay.TotalSeconds / obj1 * obj1;
			return datetime.Date.AddSeconds(num);
		}

		private class l9JS6GiROvEy77Co1R
		{
			public Bar bar;
			public long VMmLV7HilK;

			public l9JS6GiROvEy77Co1R()
			{
				this.VMmLV7HilK = 1;
			}
		}

		private class mU5OEr88NSmCpsBxeD
		{
			public double price;
			public int size;
		}

		private enum yPiBmEZIjD7IoCdXp6
		{
		}

		private class zNxuFsXhPSM7NAan2D
		{
			public BarFactory.yPiBmEZIjD7IoCdXp6 XUfLqKE3Ac;
			public Bar bar;

			public zNxuFsXhPSM7NAan2D(BarFactory.yPiBmEZIjD7IoCdXp6 obj0, Bar bar)
			{
				this.XUfLqKE3Ac = obj0;
				this.bar = bar;
			}
		}
	}
}
