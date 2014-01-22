using FreeQuant.Business;
using FreeQuant.Testing.TesterItems;
using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.Pertrac
{
  public class VaR : SeriesTesterItem
  {
    protected double level;
    protected ArrayList sortedSeries;

    [Category("Parameters")]
    public double Level
    {
       get
      {
        return this.level;
      }
       set
      {
        this.level = value;
        this.EmitPropertyChanged();
      }
    }

    
    public VaR(string name, SeriesTesterItem parentSeriesItem, double level)
			:  base(name, parentSeriesItem, parentSeriesItem.Series.Title)
		 {
    this.level = level;
      this.sortedSeries = new ArrayList();
    }

    
		public VaR(string name) : base(name)
    {

    }

    
    protected override double GetValue(DateTime date)
    {
      int index1 = this.parentSeries.GetIndex(date);
      ArrayList arrayList = new ArrayList();
      for (int index2 = 0; index2 <= index1; ++index2)
      {
        DateTime dateTime = this.parentSeries.GetDateTime(index2);
        if (!Calendar.IsWeekend(dateTime))
          arrayList.Add((object) this.parentSeries[dateTime]);
      }
      arrayList.Sort();
      int index3 = arrayList.Count - (int) (this.level * (double) arrayList.Count / 100.0) - 1;
      if (index3 > arrayList.Count - 1 || index3 < 0)
        return double.NaN;
      else
        return (double) arrayList[index3];
    }

    
    public override void Reset()
    {
      base.Reset();
      this.sortedSeries = new ArrayList();
    }
  }
}
