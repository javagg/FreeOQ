using FreeQuant.Series;
using FreeQuant.Testing.TesterItems;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.Pertrac
{
  public class MARRatio : SeriesTesterItem
  {
    protected SeriesTesterItem maxDrawDown;

   
    public MARRatio(string name, SeriesTesterItem parentSeriesItem, SeriesTesterItem maxDrawDownSeriesItem)
			:      base(name, parentSeriesItem,  parentSeriesItem.Series.Title)
		 {
      this.maxDrawDown = maxDrawDownSeriesItem;
      this.maxDrawDown.FillSeries = true;
      this.parentList.Add((object) this.maxDrawDown);
    }

   
		public MARRatio(string name) : base(name)
    {

    }

   
    protected override double GetValue(DateTime date)
    {
      double num1 = double.NaN;
      int index1 = this.parentSeries.GetIndex(date);
      if (this.maxDrawDown.Series.Count == 0 || date < this.maxDrawDown.Series.FirstDateTime)
        return num1;
      double num2 = 1.0;
      int num3 = 0;
      for (int index2 = 0; index2 <= index1; ++index2)
      {
        if (this.parentSeries[index2] != 0.0)
        {
          num2 *= this.parentSeries[index2];
          ++num3;
        }
      }
      return Math.Pow(Math.Abs(num2), 1.0 / (double) num3) / -this.maxDrawDown.Series[date, EIndexOption.Prev];
    }

   
    public override void Reset()
    {
      base.Reset();
    }
  }
}
