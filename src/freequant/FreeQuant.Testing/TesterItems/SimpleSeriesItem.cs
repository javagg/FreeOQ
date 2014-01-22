using FreeQuant.Series;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.TesterItems
{
  public class SimpleSeriesItem : SeriesTesterItem
  {
    [Browsable(false)]
    public override SeriesTesterItem ParentComponent
    {
       get
      {
        return (SeriesTesterItem) null;
      }
    }

    [Browsable(false)]
    public override bool FillSeries
    {
       get
      {
        return this.fillSeries;
      }
    }

    [Browsable(false)]
    public override bool Enabled
    {
       get
      {
        return this.enabled;
      }
       set
      {
      }
    }

    public override double LastValue
    {
       get
      {
        if (this.series.Count > 0)
          return this.series.Last;
        else
          return double.NaN;
      }
    }

    
		public SimpleSeriesItem(string name, DoubleSeries parentSeries):  base()
    {
      this.enabled = true;
      this.parentSeries = parentSeries;
      this.name = name;
      this.series = parentSeries;
      this.fillSeries = true;
    }

    
		public SimpleSeriesItem(string name):  base(name)
    {
      this.enabled = true;
    }
  }
}
