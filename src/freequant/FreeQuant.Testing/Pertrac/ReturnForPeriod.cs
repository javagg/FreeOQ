using FreeQuant.Series;
using FreeQuant.Testing;
using FreeQuant.Testing.TesterItems;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.Pertrac
{
  public class ReturnForPeriod : SeriesTesterItem
  {
    protected TimeIntervalSize intervalSize;
    protected TimeIntervalSize periodLength;

    public TimeIntervalSize IntervalSize
    {
      get
      {
        return this.intervalSize;
      }
      set
      {
        this.intervalSize = value;
      }
    }

    public TimeIntervalSize PeriodLength
    {
      get
      {
        return this.periodLength;
      }
      set
      {
        this.periodLength = value;
      }
    }

    
    public ReturnForPeriod(string name, SeriesTesterItem parentSeriesItem, TimeIntervalSize intervalSize, TimeIntervalSize periodLength)
			:      base(name, parentSeriesItem,  parentSeriesItem.Series.Title)
		 {
    this.intervalSize = intervalSize;
      this.periodLength = periodLength;
    }

    
		public ReturnForPeriod(string name) : base(name)
    {

    }

    
    public DateTime AddInterval(DateTime dateTime, TimeIntervalSize intervalSize)
    {
      return this.AddInterval(dateTime, intervalSize, 1);
    }

    
    public DateTime SubtractInterval(DateTime dateTime, TimeIntervalSize intervalSize)
    {
      return this.AddInterval(dateTime, intervalSize, -1);
    }

    
    public DateTime AddInterval(DateTime dateTime, TimeIntervalSize intervalSize, int multiplier)
    {
      DateTime dateTime1;
      switch (intervalSize)
      {
        case TimeIntervalSize.year10:
          dateTime1 = dateTime.AddYears(10 * multiplier);
          break;
        case TimeIntervalSize.year20:
          dateTime1 = dateTime.AddYears(20 * multiplier);
          break;
        case TimeIntervalSize.year4:
          dateTime1 = dateTime.AddYears(4 * multiplier);
          break;
        case TimeIntervalSize.year5:
          dateTime1 = dateTime.AddYears(5 * multiplier);
          break;
        case TimeIntervalSize.year1:
          dateTime1 = dateTime.AddYears(multiplier);
          break;
        case TimeIntervalSize.year2:
          dateTime1 = dateTime.AddYears(2 * multiplier);
          break;
        case TimeIntervalSize.year3:
          dateTime1 = dateTime.AddYears(3 * multiplier);
          break;
        case TimeIntervalSize.month4:
          dateTime1 = dateTime.AddMonths(4 * multiplier);
          break;
        case TimeIntervalSize.month6:
          dateTime1 = dateTime.AddMonths(6 * multiplier);
          break;
        case TimeIntervalSize.month9:
          dateTime1 = dateTime.AddMonths(9 * multiplier);
          break;
        case TimeIntervalSize.month1:
          dateTime1 = dateTime.AddMonths(multiplier);
          break;
        case TimeIntervalSize.month2:
          dateTime1 = dateTime.AddMonths(2 * multiplier);
          break;
        case TimeIntervalSize.month3:
          dateTime1 = dateTime.AddMonths(3 * multiplier);
          break;
        default:
          dateTime1 = dateTime.AddTicks((long) intervalSize * (long) multiplier);
          break;
      }
      return dateTime1;
    }

    
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      if (firstIndex > lastIndex)
        return;
      DateTime dateTime1 = this.parentSeries.GetDateTime(lastIndex);
      DateTime dateTime2 = DateTime.MinValue;
      if (this.series.Count == 0)
      {
        if (this.AddInterval(this.parentSeries.FirstDateTime, this.periodLength) <= this.parentSeries.LastDateTime)
          dateTime2 = this.AddInterval(this.parentSeries.FirstDateTime, this.periodLength);
      }
      else
        dateTime2 = this.AddInterval(this.series.LastDateTime, this.intervalSize);
      if (!(dateTime2 != DateTime.MinValue))
        return;
      for (DateTime index1 = dateTime2; index1 <= dateTime1; index1 = this.AddInterval(index1, this.IntervalSize))
      {
        DateTime index2 = !(index1 == dateTime2) ? this.SubtractInterval(index1, this.periodLength) : this.parentSeries.FirstDateTime;
        double num1 = this.parentSeries[index1, EIndexOption.Prev];
        double num2 = this.parentSeries[index2, EIndexOption.Prev];
        this.series.Add(index1, (num1 / num2 - 1.0) * 100.0);
      }
    }

    
    protected override double GetValue(DateTime date)
    {
      if (this.parentSeries.Count <= 1)
        return double.NaN;
      DateTime dateTime1 = this.AddInterval(this.parentSeries.FirstDateTime, this.periodLength);
      this.parentSeries.GetIndex(date);
      while (dateTime1 < date)
        dateTime1 = this.AddInterval(dateTime1, this.intervalSize);
      DateTime dateTime2 = this.SubtractInterval(dateTime1, this.intervalSize);
      DateTime index = this.SubtractInterval(dateTime2, this.periodLength);
      if (index >= this.parentSeries.FirstDateTime)
        return (this.parentSeries[dateTime2, EIndexOption.Prev] / this.parentSeries[index, EIndexOption.Prev] - 1.0) * 100.0;
      else
        return double.NaN;
    }
  }
}
