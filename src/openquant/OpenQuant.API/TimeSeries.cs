using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API
{
  public class TimeSeries : ISeries
  {
    internal DoubleSeries series;

    public string Name
    {
      get
      {
        return this.series.Name;
      }
    }

    public int Count
    {
      get
      {
        return this.series.Count;
      }
    }

    public double Last
    {
      get
      {
        return this.series.Last;
      }
    }

    public Color Color
    {
      get
      {
        return this.series.Color;
      }
      set
      {
        this.series.Color = value;
      }
    }

    [Description("Gets or sets series width")]
    [Category("Drawing")]
    public int Width
    {
      get
      {
        return this.series.DrawWidth;
      }
      set
      {
        this.series.DrawWidth = value;
      }
    }

    public double this[int index]
    {
      get
      {
        return this.series[index];
      }
    }

    public double this[DateTime dateTime]
    {
      get
      {
        return this.series[dateTime];
      }
    }

    public double this[DateTime dateTime, BarData barData]
    {
      get
      {
        return this.series[dateTime];
      }
    }

    public double this[int index, BarData barData]
    {
      get
      {
        return this.series[index];
      }
    }

    internal TimeSeries(DoubleSeries series)
    {
      this.series = series;
    }

    public TimeSeries(string name, string title)
    {
      this.series = new DoubleSeries(name, title);
    }

    public TimeSeries(string name, string title, Color color)
      : this(name, title)
    {
      this.series.Color = color;
    }

    public TimeSeries(string name)
      : this(name, "")
    {
    }

    public TimeSeries(string name, Color color)
      : this(name, "", color)
    {
    }

    public TimeSeries()
      : this("", "")
    {
    }

    public bool Contains(DateTime dateTime)
    {
      return this.series.Contains(dateTime);
    }

    public void Add(DateTime dateTime, double data)
    {
      this.series.Add(dateTime, data);
    }

    public void Remove(DateTime dateTime)
    {
      this.series.Remove(dateTime);
    }

    public void Remove(int index)
    {
      this.series.Remove(index);
    }

    public DateTime GetDateTime(int index)
    {
      return this.series.GetDateTime(index);
    }

    public int GetIndex(DateTime dateTime)
    {
      return this.series.GetIndex(dateTime);
    }

    public virtual Cross Crosses(BarSeries series, Bar bar)
    {
      return EnumConverter.Convert(this.series.Crosses((SmartQuant.Series.TimeSeries) series.series, bar.bar));
    }

    public virtual bool CrossesBelow(BarSeries series, Bar bar, BarData barData)
    {
      return this.series.CrossesBelow((SmartQuant.Series.TimeSeries) series.series, bar.bar, (int) barData);
    }

    public virtual bool CrossesAbove(BarSeries series, Bar bar, BarData barData)
    {
      return this.series.CrossesAbove((SmartQuant.Series.TimeSeries) series.series, bar.bar, (int) barData);
    }

    public virtual Cross Crosses(BarSeries series, Bar bar, BarData barData)
    {
      return EnumConverter.Convert(this.series.Crosses((SmartQuant.Series.TimeSeries) series.series, bar.bar, (int) barData));
    }

    public virtual Cross Crosses(Indicator indicator, DateTime dateTime)
    {
      return EnumConverter.Convert(this.series.Crosses((SmartQuant.Series.TimeSeries) indicator.indicator, dateTime));
    }

    public virtual bool CrossesBelow(Indicator indicator, DateTime dateTime)
    {
      return this.series.CrossesBelow((SmartQuant.Series.TimeSeries) indicator.indicator, dateTime);
    }

    public virtual bool CrossesAbove(Indicator indicator, DateTime dateTime)
    {
      return this.series.CrossesAbove((SmartQuant.Series.TimeSeries) indicator.indicator, dateTime);
    }

    public virtual bool CrossesBelow(double level, Bar bar)
    {
      return this.series.CrossesBelow(level, this.series.GetIndex(bar.DateTime));
    }

    public virtual Cross Crosses(TimeSeries series, DateTime dateTime)
    {
      return EnumConverter.Convert(this.series.Crosses((SmartQuant.Series.TimeSeries) series.series, dateTime));
    }

    public virtual bool CrossesBelow(TimeSeries series, DateTime dateTime)
    {
      return this.series.CrossesBelow((SmartQuant.Series.TimeSeries) series.series, dateTime);
    }

    public virtual bool CrossesAbove(TimeSeries series, DateTime dateTime)
    {
      return this.series.CrossesAbove((SmartQuant.Series.TimeSeries) series.series, dateTime);
    }

    public virtual bool CrossesAbove(double level, Bar bar)
    {
      return this.series.CrossesAbove(level, this.series.GetIndex(bar.DateTime));
    }

    public virtual Cross Crosses(double level, Bar bar)
    {
      return EnumConverter.Convert(this.series.Crosses(level, this.series.GetIndex(bar.DateTime)));
    }

    public double Ago(int length)
    {
      return this.series.Ago(length);
    }

    public double GetMax(int index1, int index2)
    {
      return this.series.GetMax(index1, index2);
    }

    public double GetMax(DateTime dateTime1, DateTime dateTime2)
    {
      return this.series.GetMax(dateTime1, dateTime2);
    }

    public double GetMin(int index1, int index2)
    {
      return this.series.GetMin(index1, index2);
    }

    public double GetMin(DateTime dateTime1, DateTime dateTime2)
    {
      return this.series.GetMin(dateTime1, dateTime2);
    }

    public double GetAsymmetry(int index1, int index2)
    {
      return this.series.GetAsymmetry(index1, index2);
    }

    public double GetAsymmetry(DateTime dateTime1, DateTime dateTime2)
    {
      return this.series.GetAsymmetry(dateTime1, dateTime2);
    }

    public double GetAutoCorrelation(int lag)
    {
      return this.series.GetAutoCorrelation(lag);
    }

    public double GetAutoCovariance(int lag)
    {
      return this.series.GetAutoCovariance(lag);
    }

    public double GetCorrelation(TimeSeries timeSeries)
    {
      return this.series.GetCorrelation((SmartQuant.Series.TimeSeries) timeSeries.series);
    }

    public double GetCovariance(TimeSeries timeSeries)
    {
      return this.series.GetCovariance((SmartQuant.Series.TimeSeries) timeSeries.series);
    }

    public double GetExcess(int index1, int index2)
    {
      return this.series.GetExcess(index1, index2);
    }

    public double GetExcess(DateTime dateTime1, DateTime dateTime2)
    {
      return this.series.GetExcess(dateTime1, dateTime2);
    }

    public double GetMean(int index1, int index2)
    {
      return this.series.GetMean(index1, index2);
    }

    public double GetMean(DateTime dateTime1, DateTime dateTime2)
    {
      return this.series.GetMean(dateTime1, dateTime2);
    }

    public double GetMedian(int index1, int index2)
    {
      return this.series.GetMedian(index1, index2);
    }

    public double GetMedian(DateTime dateTime1, DateTime dateTime2)
    {
      return this.series.GetMedian(dateTime1, dateTime2);
    }

    public double GetMoment(int k, int index1, int index2)
    {
      return this.series.GetMoment(k, index1, index2);
    }

    public double GetMoment(int k, DateTime dateTime1, DateTime dateTime2)
    {
      return this.series.GetMoment(k, dateTime1, dateTime2);
    }

    public double GetNegativeStdDev(int index1, int index2)
    {
      return this.series.GetNegativeStdDev(index1, index2);
    }

    public double GetNegativeStdDev(DateTime dateTime1, DateTime dateTime2)
    {
      return this.series.GetNegativeStdDev(dateTime1, dateTime2);
    }

    public double GetNegativeVariance(int index1, int index2)
    {
      return this.series.GetNegativeVariance(index1, index2);
    }

    public double GetNegativeVariance(DateTime dateTime1, DateTime dateTime2)
    {
      return this.series.GetNegativeVariance(dateTime1, dateTime2);
    }

    public double GetPositiveStdDev(int index1, int index2)
    {
      return this.series.GetPositiveStdDev(index1, index2);
    }

    public double GetPositiveStdDev(DateTime dateTime1, DateTime dateTime2)
    {
      return this.series.GetPositiveStdDev(dateTime1, dateTime2);
    }

    public double GetPositiveVariance(int index1, int index2)
    {
      return this.series.GetPositiveVariance(index1, index2);
    }

    public double GetPositiveVariance(DateTime dateTime1, DateTime dateTime2)
    {
      return this.series.GetPositiveVariance(dateTime1, dateTime2);
    }

    public double GetStdDev(int index1, int index2)
    {
      return this.series.GetStdDev(index1, index2);
    }

    public double GetStdDev(DateTime dateTime1, DateTime dateTime2)
    {
      return this.series.GetStdDev(dateTime1, dateTime2);
    }

    public double GetSum(int index1, int index2)
    {
      return this.series.GetSum(index1, index2);
    }

    public double GetSum(DateTime dateTime1, DateTime dateTime2)
    {
      return this.series.GetSum(dateTime1, dateTime2);
    }

    public double GetVariance(int index1, int index2)
    {
      return this.series.GetVariance(index1, index2);
    }

    public double GetVariance(DateTime dateTime1, DateTime dateTime2)
    {
      return this.series.GetVariance(dateTime1, dateTime2);
    }
  }
}
