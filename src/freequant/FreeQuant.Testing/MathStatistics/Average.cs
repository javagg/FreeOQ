using FreeQuant.Testing.TesterItems;
using System;

namespace FreeQuant.Testing.MathStatistics
{
  public class Average : SeriesTesterItem
  {
    
		public Average(string name, SeriesTesterItem parentSeriesItem): base(name, parentSeriesItem, name + parentSeriesItem.Series.Title)
    {
    }

    
		public Average(string name): base(name)
    {

    }

    
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      if (firstIndex > lastIndex)
        return;
      DateTime dateTime1 = this.parentSeries.GetDateTime(lastIndex);
      if (this.series.Contains(dateTime1))
      {
        if (this.series.Count == 1)
          this.series.Add(dateTime1, this.parentSeries[dateTime1]);
        else
          this.series.Add(dateTime1, (this.series[this.series.Count - 2] * (double) (this.series.Count - 1) + this.parentSeries[dateTime1]) / (double) this.series.Count);
      }
      else
      {
        for (int index = firstIndex; index <= lastIndex; ++index)
        {
          DateTime dateTime2 = this.parentSeries.GetDateTime(index);
          if (this.series.Count == 0)
            this.series.Add(dateTime2, this.parentSeries[dateTime2]);
          else
            this.series.Add(dateTime2, ((double) this.series.Count * this.series.Last + this.parentSeries[dateTime2]) / (double) (this.series.Count + 1));
        }
      }
    }

    
    protected override double GetValue(DateTime date)
    {
      double num1 = 0.0;
      int index1 = this.parentSeries.GetIndex(date);
      int num2 = 0;
      for (int index2 = 0; index2 <= index1; ++index2)
      {
        this.parentSeries.GetDateTime(index2);
        num1 += this.parentSeries[index2];
        ++num2;
      }
      return num1 / (double) num2;
    }
  }
}
