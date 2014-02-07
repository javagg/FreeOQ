using System;
using System.Collections;

namespace FreeQuant.Data
{
	public class BarMaker
	{
		public static void MakeBars(IDataSeries tradeSeries, IDataSeries barSeries, BarType barType, long barSize)
		{
			switch (barType)
			{
				case BarType.Time:
					Bar bar1 = (Bar)null;
					foreach (Trade trade in tradeSeries)
					{
						if (bar1 == null || bar1.EndTime <= trade.DateTime)
						{
							if (bar1 != null)
								barSeries.Add(bar1.DateTime, bar1);
							DateTime beginTime = BarMaker.qtghhEheM(trade.DateTime, barSize);
							bar1 = new Bar(BarType.Time, barSize, beginTime, beginTime.AddSeconds((double)barSize), trade.Price, trade.Price, trade.Price, trade.Price, (long)trade.Size, 0L);
						}
						else
						{
							if (trade.Price > bar1.High)
								bar1.High = trade.Price;
							if (trade.Price < bar1.Low)
								bar1.Low = trade.Price;
							bar1.Close = trade.Price;
							bar1.Volume += (long)trade.Size;
						}
					}
					if (bar1 != null)
						barSeries.Add(bar1.DateTime, bar1);
					barSeries.Flush();
					break;
				case BarType.Tick:
					Bar bar2 = (Bar)null;
					int num = 0;
					foreach (Trade trade in tradeSeries)
					{
						if (bar2 == null)
						{
							bar2 = new Bar(BarType.Tick, barSize, trade.DateTime, trade.DateTime, trade.Price, trade.Price, trade.Price, trade.Price, (long)trade.Size, 0L);
							num = 1;
						}
						else
						{
							bar2.EndTime = trade.DateTime;
							if (trade.Price > bar2.High)
								bar2.High = trade.Price;
							if (trade.Price < bar2.Low)
								bar2.Low = trade.Price;
							bar2.Close = trade.Price;
							bar2.Volume += (long)trade.Size;
							++num;
						}
						if ((long)num == barSize)
						{
							barSeries.Add(bar2.DateTime, bar2);
							bar2 = (Bar)null;
						}
					}
					if (bar2 != null)
						barSeries.Add(bar2.DateTime, bar2);
					barSeries.Flush();
					break;
				case BarType.Volume:
					Bar bar3 = (Bar)null;
					foreach (Trade trade in tradeSeries)
					{
						if (bar3 == null)
						{
							bar3 = new Bar(BarType.Volume, barSize, trade.DateTime, trade.DateTime, trade.Price, trade.Price, trade.Price, trade.Price, (long)trade.Size, 0L);
						}
						else
						{
							bar3.EndTime = trade.DateTime;
							if (trade.Price > bar3.High)
								bar3.High = trade.Price;
							if (trade.Price < bar3.Low)
								bar3.Low = trade.Price;
							bar3.Close = trade.Price;
							bar3.Volume += (long)trade.Size;
						}
						if (bar3.Volume >= barSize)
						{
							barSeries.Add(bar3.DateTime, bar3);
							bar3 = (Bar)null;
						}
					}
					if (bar3 != null)
						barSeries.Add(bar3.DateTime, bar3);
					barSeries.Flush();
					break;
				case BarType.Range:
					Bar bar4 = (Bar)null;
					foreach (Trade trade in tradeSeries)
					{
						DateTime dateTime = trade.DateTime;
						double price = trade.Price;
						long volume = (long)trade.Size;
						if (bar4 == null)
						{
							bar4 = new Bar(BarType.Range, barSize, dateTime, dateTime, price, price, price, price, volume, 0L);
						}
						else
						{
							bar4.EndTime = dateTime;
							if (price > bar4.High)
								bar4.High = price;
							if (price < bar4.Low)
								bar4.Low = price;
							bar4.Volume += volume;
							bool flag = false;
							while (!flag)
							{
								if (10000.0 * (bar4.High - bar4.Low) >= (double)barSize)
								{
									Bar bar5 = new Bar(BarType.Range, barSize, dateTime, dateTime, price, price, price, price, 0L, 0L);
									if (bar4.High == price)
									{
										bar4.High = bar4.Low + barSize / 10000.0;
										bar4.Close = bar4.High;
										bar5.Low = bar4.High;
									}
									if (bar4.Low == price)
									{
										bar4.Low = bar4.High - barSize / 10000.0;
										bar4.Close = bar4.Low;
										bar5.High = bar4.Low;
									}
									barSeries.Add(bar4.DateTime, bar4);
									bar4 = bar5;
									flag = 10000.0 * (bar5.High - bar5.Low) < (double)barSize;
								}
								else
									flag = true;
							}
						}
					}
					if (bar4 != null)
						barSeries.Add(bar4.DateTime, bar4);
					barSeries.Flush();
					break;
				default:
					throw new NotImplementedException("" + barType);
			}
		}

		private static DateTime qtghhEheM(DateTime obj0, long obj1)
		{
			long num = (long)obj0.TimeOfDay.TotalSeconds / obj1 * obj1;
			return obj0.Date.AddSeconds((double)num);
		}
	}
}
