using FreeQuant.Indicators;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API
{
	///<summary>
	///  A technical indicator
	///</summary>
	public class Indicator : ISeries
	{
		internal FreeQuant.Indicators.Indicator indicator;

		///<summary>
		///  Initializes a new instance of the Indicator class
		///</summary>
		public Indicator() {}

		///<summary>
		///  Gets or sets indicator name 
		///</summary>
		[Browsable(false)]
		public string Name
		{
			get
			{
				return ((FreeQuant.Series.TimeSeries)this.indicator).Name;
			}
			set
			{
				((FreeQuant.Series.TimeSeries)this.indicator).Name = value;
			}
		}

		///<summary>
		///  Gets or sets indicator description 
		///</summary>
		[Browsable(false)]
		public string Description
		{
			get
			{
				return ((FreeQuant.Series.TimeSeries)this.indicator).Title;
			}
			set
			{
				((FreeQuant.Series.TimeSeries)this.indicator).Title = value;
			}
		}

		///<summary>
		///  Gets or sets indicator color
		///</summary>
		[Category("Drawing")]
		[Description("Gets or sets indicator color")]
		public Color Color
		{
			get
			{
				return ((FreeQuant.Series.TimeSeries)this.indicator).Color;
			}
			set
			{
				((FreeQuant.Series.TimeSeries)this.indicator).Color = value;
			}
		}

		///<summary>
		///  Gets or sets indicator width
		///</summary>
      [Description("Gets or sets indicator width")]
		[Category("Drawing")]
		public int Width
		{
			get
			{
				return ((DoubleSeries)this.indicator).DrawWidth;
			}
			set
			{
				((DoubleSeries)this.indicator).DrawWidth = value;
			}
		}

		///<summary>
		///  Gets indicator value at specified index
		///</summary>
		public virtual double this[int index]
		{
			get
			{
				return this.indicator.get_Item(index);
			}
		}

		///<summary>
		///  Gets indicator value at specified time stamp
		///</summary>
		public virtual double this[DateTime dateTime]
		{
			get
			{
				return this.indicator.get_Item(dateTime);
			}
		}

		///<summary>
		///  Gets the number of items in this indicator
		///</summary>
		[Browsable(false)]
		public virtual int Count
		{
			get
			{
				return ((FreeQuant.Series.TimeSeries)this.indicator).Count;
			}
		}

		///<summary>
		///  Gets indicator value at specified bar
		///</summary>
		public virtual double this[Bar bar]
		{
			get
			{
				return this.indicator.get_Item(bar.DateTime);
			}
		}

		///<summary>
		///  Gets last value of this indicator
		///</summary>
		[Browsable(false)]
		public virtual double Last
		{
			get
			{
				return ((DoubleSeries)this.indicator).Last;
			}
		}

		///<summary>
		///  Gets first date-time 
		///</summary>
		[Browsable(false)]
		public virtual DateTime FirstDateTime
		{
			get
			{
				return ((FreeQuant.Series.TimeSeries)this.indicator).FirstDateTime;
			}
		}

		///<summary>
		///  Gets last date-time
		///</summary>
		[Browsable(false)]
		public virtual DateTime LastDateTime
		{
			get
			{
				return ((FreeQuant.Series.TimeSeries)this.indicator).LastDateTime;
			}
		}

		///<summary>
		///  Gets value with specified time stamp in the series
		///</summary>
		public virtual double this[DateTime dateTime, BarData barData]
		{
			get
			{
				return this.indicator.get_Item(dateTime);
			}
		}

		///<summary>
		///  Gets value with specified time stamp in the series
		///</summary>
		public virtual double this[int index, BarData barData]
		{
			get
			{
				return this.indicator.get_Item(index);
			}
		}

   	///<summary>
		///  Returns n-bars-ago indicator value
		///</summary>
		public virtual double Ago(int n)
		{
			return ((DoubleSeries)this.indicator).Ago(n);
		}

		///<summary>
		///  Checks if this indicator contains an entry with specified time stamp 
		///</summary>
		public virtual bool Contains(DateTime dateTime)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).Contains(dateTime);
		}

		///<summary>
		///  Checks if this indicator contains an entry with specified time stamp
		///</summary>
		public virtual bool Contains(Bar bar)
		{
			return this.Contains(bar.DateTime);
		}

		///<summary>
		///  Checks if this indicator crosses a bar series above at specified dateTime
		///</summary>
		public virtual Cross Crosses(TimeSeries series, DateTime dateTime)
		{
			return EnumConverter.Convert(((FreeQuant.Series.TimeSeries)this.indicator).Crosses((FreeQuant.Series.TimeSeries)series.series, dateTime));
		}

		public virtual bool CrossesBelow(TimeSeries series, DateTime dateTime)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).CrossesBelow((FreeQuant.Series.TimeSeries)series.series, dateTime);
		}

		public virtual bool CrossesAbove(TimeSeries series, DateTime dateTime)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).CrossesAbove((FreeQuant.Series.TimeSeries)series.series, dateTime);
		}

		public virtual bool CrossesBelow(BarSeries series, Bar bar)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).CrossesBelow((FreeQuant.Series.TimeSeries)series.series, bar.bar);
		}

		public virtual bool CrossesAbove(BarSeries series, Bar bar)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).CrossesAbove((FreeQuant.Series.TimeSeries)series.series, bar.bar);
		}

		public virtual bool CrossesBelow(Indicator indicator, Bar bar)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).CrossesBelow((FreeQuant.Series.TimeSeries)indicator.indicator, bar.bar);
		}

		public virtual bool CrossesAbove(Indicator indicator, Bar bar)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).CrossesAbove((FreeQuant.Series.TimeSeries)indicator.indicator, bar.bar);
		}

		public virtual Cross Crosses(Indicator indicator, Bar bar)
		{
			return EnumConverter.Convert(((FreeQuant.Series.TimeSeries)this.indicator).Crosses((FreeQuant.Series.TimeSeries)indicator.indicator, bar.bar));
		}

		public virtual Cross Crosses(BarSeries series, Bar bar)
		{
			return EnumConverter.Convert(((FreeQuant.Series.TimeSeries)this.indicator).Crosses((FreeQuant.Series.TimeSeries)series.series, bar.bar));
		}

		public virtual bool CrossesBelow(BarSeries series, Bar bar, BarData barData)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).CrossesBelow((FreeQuant.Series.TimeSeries)series.series, bar.bar, (int)barData);
		}

		public virtual bool CrossesAbove(BarSeries series, Bar bar, BarData barData)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).CrossesAbove((FreeQuant.Series.TimeSeries)series.series, bar.bar, (int)barData);
		}

		public virtual Cross Crosses(BarSeries series, Bar bar, BarData barData)
		{
			return EnumConverter.Convert(((FreeQuant.Series.TimeSeries)this.indicator).Crosses((FreeQuant.Series.TimeSeries)series.series, bar.bar, (int)barData));
		}

		public virtual bool CrossesBelow(double level, Bar bar)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).CrossesBelow(level, ((FreeQuant.Series.TimeSeries)this.indicator).GetIndex(bar.DateTime));
		}

		public virtual bool CrossesAbove(double level, Bar bar)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).CrossesAbove(level, ((FreeQuant.Series.TimeSeries)this.indicator).GetIndex(bar.DateTime));
		}

		public virtual Cross Crosses(double level, Bar bar)
		{
			return EnumConverter.Convert(((FreeQuant.Series.TimeSeries)this.indicator).Crosses(level, ((FreeQuant.Series.TimeSeries)this.indicator).GetIndex(bar.DateTime)));
		}

		public virtual DateTime GetDateTime(int index)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetDateTime(index);
		}

		public int GetIndex(DateTime dateTime)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetIndex(dateTime);
		}

		public double GetMax(int index1, int index2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetMax(index1, index2);
		}

		public double GetMax(DateTime dateTime1, DateTime dateTime2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetMax(dateTime1, dateTime2);
		}

		public double GetMin(int index1, int index2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetMin(index1, index2);
		}

		public double GetMin(DateTime dateTime1, DateTime dateTime2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetMin(dateTime1, dateTime2);
		}

		public double GetAsymmetry(int index1, int index2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetAsymmetry(index1, index2);
		}

		public double GetAsymmetry(DateTime dateTime1, DateTime dateTime2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetAsymmetry(dateTime1, dateTime2);
		}

		public double GetAutoCorrelation(int lag)
		{
			return ((DoubleSeries)this.indicator).GetAutoCorrelation(lag);
		}

		public double GetAutoCovariance(int lag)
		{
			return ((DoubleSeries)this.indicator).GetAutoCovariance(lag);
		}

		public double GetCorrelation(TimeSeries timeSeries)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetCorrelation((FreeQuant.Series.TimeSeries)timeSeries.series);
		}

		public double GetCovariance(TimeSeries timeSeries)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetCovariance((FreeQuant.Series.TimeSeries)timeSeries.series);
		}

		public double GetExcess(int index1, int index2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetExcess(index1, index2);
		}

		public double GetExcess(DateTime dateTime1, DateTime dateTime2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetExcess(dateTime1, dateTime2);
		}

		public double GetMean(int index1, int index2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetMean(index1, index2);
		}

		public double GetMean(DateTime dateTime1, DateTime dateTime2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetMean(dateTime1, dateTime2);
		}

		public double GetMedian(int index1, int index2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetMedian(index1, index2);
		}

		public double GetMedian(DateTime dateTime1, DateTime dateTime2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetMedian(dateTime1, dateTime2);
		}

		public double GetMoment(int k, int index1, int index2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetMoment(k, index1, index2);
		}

		public double GetMoment(int k, DateTime dateTime1, DateTime dateTime2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetMoment(k, dateTime1, dateTime2);
		}

		public double GetNegativeStdDev(int index1, int index2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetNegativeStdDev(index1, index2);
		}

		public double GetNegativeStdDev(DateTime dateTime1, DateTime dateTime2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetNegativeStdDev(dateTime1, dateTime2);
		}

		public double GetNegativeVariance(int index1, int index2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetNegativeVariance(index1, index2);
		}

		public double GetNegativeVariance(DateTime dateTime1, DateTime dateTime2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetNegativeVariance(dateTime1, dateTime2);
		}

		public double GetPositiveStdDev(int index1, int index2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetPositiveStdDev(index1, index2);
		}

		public double GetPositiveStdDev(DateTime dateTime1, DateTime dateTime2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetPositiveStdDev(dateTime1, dateTime2);
		}

		public double GetPositiveVariance(int index1, int index2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetPositiveVariance(index1, index2);
		}

		public double GetPositiveVariance(DateTime dateTime1, DateTime dateTime2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetPositiveVariance(dateTime1, dateTime2);
		}

		public double GetStdDev(int index1, int index2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetStdDev(index1, index2);
		}

		public double GetStdDev(DateTime dateTime1, DateTime dateTime2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetStdDev(dateTime1, dateTime2);
		}

		public double GetSum(int index1, int index2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetSum(index1, index2);
		}

		public double GetSum(DateTime dateTime1, DateTime dateTime2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetSum(dateTime1, dateTime2);
		}

		public double GetVariance(int index1, int index2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetVariance(index1, index2);
		}

		public double GetVariance(DateTime dateTime1, DateTime dateTime2)
		{
			return ((FreeQuant.Series.TimeSeries)this.indicator).GetVariance(dateTime1, dateTime2);
		}
	}
}
