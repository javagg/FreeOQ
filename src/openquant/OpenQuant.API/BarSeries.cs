using FreeQuant.Series;
using System;
using System.Collections;

namespace OpenQuant.API
{
	public class BarSeries : IEnumerable, ISeries
	{
		internal FreeQuant.Series.BarSeries series;

		///<summary>
		///  Gets the name of this series   
		///</summary>
		public string Name
		{
			get
			{
				return this.series.Name;
			}
		}

		///<summary>
		///  Gets the number of bars in this series  
		///</summary>
		public int Count
		{
			get
			{
				return this.series.Count;
			}
		}

		///<summary>
		///  Gets the first bar of this series   
		///</summary>
		public Bar First
		{
			get
			{
				return new Bar(this.series.First);
			}
		}

		///<summary>
		///  Gets the last bar of this series  
		///</summary>
		public Bar Last
		{
			get
			{
				return new Bar(this.series.Last);
			}
		}

		///<summary>
		///  Gets bar at specified index in the series 
		///</summary>
		public Bar this[int index]
		{
			get
			{
				return new Bar(this.series[index]);
			}
		}

		///<summary>
		///  Gets bar with specified time stamp in the series
		///</summary>
		public Bar this[DateTime dateTime]
		{
			get
			{
				FreeQuant.Data.Bar bar = this.series[dateTime];
				if (bar == null)
					return null;
				else
					return new Bar(bar);
			}
		}

		///<summary>
		///  Gets value with specified time stamp and bar data in the series 
		///</summary>
		public double this[DateTime dateTime, BarData barData]
		{
			get
			{
				Bar bar = this[dateTime];
				switch (barData)
				{
					case BarData.Close:
						return bar.Close;
					case BarData.Open:
						return bar.Open;
					case BarData.High:
						return bar.High;
					case BarData.Low:
						return bar.Low;
					case BarData.Median:
						return bar.Median;
					case BarData.Typical:
						return bar.Typical;
					case BarData.Weighted:
						return bar.Weighted;
					case BarData.Average:
						return bar.Average;
					case BarData.Volume:
						return (double)bar.Volume;
					case BarData.OpenInt:
						return (double)bar.OpenInt;
					default:
						throw new NotSupportedException("BarData " + barData + " is not supported");
				}
			}
		}

		///<summary>
		///  Gets value with specified index and bar data in the series  
		///</summary>
		public double this[int index, BarData barData]
		{
			get
			{
				return this[this.series.GetDateTime(index), barData];
			}
		}

		///<summary>
		///  Gets value with specified time stamp and search option  
		///</summary>
		public Bar this[DateTime dateTime, SearchOption searchOption]
		{
			get
			{
				if (searchOption == SearchOption.Next)
					return new Bar(this.series[dateTime, EIndexOption.Next]);
				else
					return new Bar(this.series[dateTime, EIndexOption.Prev]);
			}
		}

		internal BarSeries(FreeQuant.Series.BarSeries series)
		{
			this.series = series;
		}

		///<summary>
		///  Creates an instance of BarSeries class   
		///</summary>
		public BarSeries(string name, string title)
		{
			this.series = new FreeQuant.Series.BarSeries(name, title);
		}

		///<summary>
		///  Creates an instance of BarSeries class   
		///</summary>
		public BarSeries(string name) : this(name, String.Empty)
		{
		}

		///<summary>
		///  Creates an instance of BarSeries class   
		///</summary>
		public BarSeries() : this(String.Empty, String.Empty)
		{
		}

		///<summary>
		///  Adds a bar to this series   
		///</summary>
		public void Add(Bar bar)
		{
			this.series.Add(bar.bar);
		}

		///<summary>
		///  Adds a bar to this series   
		///</summary>
		public void Add(DateTime datetime, double open, double high, double low, double close, long volume, long size)
		{
			this.series.Add(new FreeQuant.Data.Bar(datetime, open, high, low, close, volume, size));
		}

		///<summary>
		///  Adds a bar to this series   
		///</summary>
		public void Add(BarType barType, long size, DateTime beginTime, DateTime endTime, double open, double high, double low, double close, long volume, long openInt)
		{
			this.series.Add(new FreeQuant.Data.Bar(EnumConverter.Convert(barType), size, beginTime, endTime, open, high, low, close, volume, openInt));
		}

		///<summary>
		///  Removes the bar with specified time stamp from this series 
		///</summary>
		public void Remove(DateTime dateTime)
		{
			((FreeQuant.Series.TimeSeries)this.series).Remove(dateTime);
		}

		///<summary>
		///  Removes the bar with specified index from this series 
		///</summary>
		public void Remove(int index)
		{
			((FreeQuant.Series.TimeSeries)this.series).Remove(index);
		}

		///<summary>
		///  Checks if this series contains a bar with specified time stamp  
		///</summary>
		public bool Contains(DateTime dateTime)
		{
			return ((FreeQuant.Series.TimeSeries)this.series).Contains(dateTime);
		}

		///<summary>
		///  Checks if this series contains a bar with specified time stamp  
		///</summary>
		public bool Contains(Bar bar)
		{
			return ((FreeQuant.Series.TimeSeries)this.series).Contains(bar.DateTime);
		}

		///<summary>
		///  Returns date time by specified index  
		///</summary>
		public DateTime GetDateTime(int index)
		{
			return this.series.GetDateTime(index);
		}

		///<summary>
		///  Returns index by specified date time 
		///</summary>
		public int GetIndex(DateTime dateTime)
		{
			return this.series.GetIndex(dateTime);
		}

		///<summary>
		///  Returns n-bar-ago bar 
		///</summary>
		public Bar Ago(int n)
		{
			return new Bar(this.series.Ago(n));
		}

		///<summary>
		///  Checks if this bar series crosses a series at specified datetime 
		///</summary>
		public virtual Cross Crosses(TimeSeries series, DateTime dateTime)
		{
			return EnumConverter.Convert(this.series.Crosses(series.series, dateTime));
		}

		///<summary>
		///  Checks if this bar series crosses a bar series below at specified dateTime 
		///</summary>
		public virtual bool CrossesBelow(TimeSeries series, DateTime dateTime)
		{
			return this.series.CrossesBelow(series.series, dateTime);
		}

		///<summary>
		///  Checks if this bar series crosses a bar series above at specified dateTime
		///</summary>
		public virtual bool CrossesAbove(TimeSeries series, DateTime dateTime)
		{
			return this.series.CrossesAbove(series.series, dateTime);
		}

		///<summary>
		///  Checks if this bar series crosses another bar series below at specific bar time 
		///</summary>
		public bool CrossesBelow(BarSeries series, Bar bar)
		{
			return this.series.CrossesBelow(series.series, bar.bar);
		}

		///<summary>
		///  Checks if this bar series crosses another bar series above at specific bar time 
		///</summary>
		public bool CrossesAbove(BarSeries series, Bar bar)
		{
			return this.series.CrossesAbove(series.series, bar.bar);
		}

		///<summary>
		///  Checks if this bar series crosses an indicator below at specific bar time 
		///</summary>
		public bool CrossesBelow(Indicator indicator, Bar bar)
		{
			return this.series.CrossesBelow(indicator.indicator, bar.bar);
		}

		///<summary>
		///  Checks if this bar series crosses an indicator above at specific bar time   
		///</summary>
		public bool CrossesAbove(Indicator indicator, Bar bar)
		{
			return this.series.CrossesAbove(indicator.indicator, bar.bar);
		}

		///<summary>
		///  Checks if this bar series crosses an indicator at specified bar   
		///</summary>
		public Cross Crosses(Indicator indicator, Bar bar)
		{
			return EnumConverter.Convert(this.series.Crosses(indicator.indicator, bar.bar));
		}

		///<summary>
		///  Checks if this bar series crosses another bar series at specified bar  
		///</summary>
		public Cross Crosses(BarSeries series, Bar bar)
		{
			return EnumConverter.Convert(this.series.Crosses(series.series, bar.bar));
		}

		///<summary>
		///  Gets the highest High of bars in this series  
		///</summary>
		public double HighestHigh()
		{
			return this.series.HighestHigh();
		}

		///<summary>
		///  Gets the highest High of last N bars in this series 
		///</summary>
		public double HighestHigh(int nBars)
		{
			return this.series.HighestHigh(nBars);
		}

		///<summary>
		///  Gets the highest High of the bars between specfied dates in this series
		///</summary>
		public double HighestHigh(DateTime dateTime1, DateTime dateTime2)
		{
			return this.series.HighestHigh(dateTime1, dateTime2);
		}

		///<summary>
		///  Gets the highest High of the bars between specfied indicies in this series
		///</summary>
		public double HighestHigh(int index1, int index2)
		{
			return this.series.HighestHigh(index1, index2);
		}

		///<summary>
		///  Gets the lowest Low of bars in this series 
		///</summary>
		public double LowestLow()
		{
			return this.series.LowestLow();
		}

		///<summary>
		///  Gets the lowest Low of last N bars in this series 
		///</summary>
		public double LowestLow(int nBars)
		{
			return this.series.LowestLow(nBars);
		}

		///<summary>
		///  Gets the highest High of the bars between specfied dates in this series 
		///</summary>
		public double LowestLow(DateTime dateTime1, DateTime dateTime2)
		{
			return this.series.LowestLow(dateTime1, dateTime2);
		}

		///<summary>
		///  Gets the highest High of the bars between specfied indicies in this series  
		///</summary>
		public double LowestLow(int index1, int index2)
		{
			return this.series.LowestLow(index1, index2);
		}

		///<summary>
		///  Compresses bar series   
		///</summary>
		public BarSeries Compress(long newBarSize)
		{
			return new BarSeries(this.series.Compress(newBarSize));
		}

		///<summary>
		///  Returns bars from within specified dates interval  
		///</summary>
		public BarSeries GetRange(DateTime dateTime1, DateTime dateTime2)
		{
			BarSeries barSeries = new BarSeries();
			int index1 = this.series.GetIndex(dateTime1, EIndexOption.Next);
			int index2 = this.series.GetIndex(dateTime1, EIndexOption.Prev);
			if (index1 != -1 && index2 != -1)
			{
				for (int index3 = index1; index3 <= index2; ++index3)
					barSeries.Add(new Bar(this.series[index3]));
			}
			return barSeries;
		}

		///<summary>
		///  Clears the bar series  
		///</summary>
		public void Clear()
		{
			this.series.Clear();
		}

		///<summary>
		///  Returns collection enumerator
		///</summary>
		public IEnumerator GetEnumerator()
		{
			return new BarSeriesEnumerator(this.series);
		}

		double ISeries.Ago(int n)
		{
			return this.series.Ago(n).Close;
		}
	}
}
