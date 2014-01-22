using FreeQuant.Testing.TesterItems;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Testing.MathStatistics
{
  public class Median : SeriesTesterItem
  {
    protected ArrayList sortedSeries;
    protected double lastInsertedValue;

   
    public Median(string name, SeriesTesterItem parentSeriesItem)
			: base(name, parentSeriesItem, name + parentSeriesItem.Series.Title)
		 {
      this.sortedSeries = new ArrayList();
      this.lastInsertedValue = double.NaN;
    }

   
		public Median(string name):    base(name)
    {
      this.sortedSeries = new ArrayList();
      this.lastInsertedValue = double.NaN;
    }

   
    private void M7hyIivSUJ([In] double obj0)
    {
      int index = 0;
      while (index < this.sortedSeries.Count && (double) this.sortedSeries[index] < obj0)
        ++index;
      this.sortedSeries.Insert(index, (object) obj0);
    }

   
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      if (firstIndex > lastIndex)
        return;
      if (this.series.Contains(this.parentSeries.GetDateTime(lastIndex)))
        this.sortedSeries.Remove((object) this.lastInsertedValue);
      for (int index = firstIndex; index <= lastIndex; ++index)
      {
        DateTime dateTime = this.parentSeries.GetDateTime(index);
        this.M7hyIivSUJ(this.parentSeries[index]);
        double Data = this.sortedSeries.Count % 2 != 0 ? (double) this.sortedSeries[this.sortedSeries.Count / 2] : ((double) this.sortedSeries[this.sortedSeries.Count / 2 - 1] + (double) this.sortedSeries[this.sortedSeries.Count / 2]) / 2.0;
        this.series.Add(dateTime, Data);
      }
      this.lastInsertedValue = this.parentSeries[lastIndex];
    }

   
    protected override double GetValue(DateTime date)
    {
      ArrayList arrayList = new ArrayList();
      int index1 = this.parentSeries.GetIndex(date);
      for (int index2 = 0; index2 <= index1; ++index2)
      {
        int index3 = 0;
        while (index3 < arrayList.Count && (double) arrayList[index3] < this.parentSeries[index2])
          ++index3;
        arrayList.Insert(index3, (object) this.parentSeries[index2]);
      }
      return arrayList.Count % 2 != 0 ? (double) arrayList[arrayList.Count / 2] : ((double) arrayList[arrayList.Count / 2 - 1] + (double) arrayList[arrayList.Count / 2]) / 2.0;
    }

   
    public override void Reset()
    {
      base.Reset();
      this.sortedSeries = new ArrayList();
      this.lastInsertedValue = double.NaN;
    }
  }
}
