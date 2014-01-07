// Type: OpenQuant.Projects.UI.BarSeriesObjectItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Instruments;
using SmartQuant.Series;

namespace OpenQuant.Projects.UI
{
  public class BarSeriesObjectItem
  {
    private Instrument instrument;
    private BarSeries series;

    public Instrument Instrument
    {
      get
      {
        return this.instrument;
      }
    }

    public BarSeries Series
    {
      get
      {
        return this.series;
      }
    }

    public BarSeriesObjectItem(Instrument instrument, BarSeries series)
    {
      this.instrument = instrument;
      this.series = series;
    }

    public override string ToString()
    {
      return this.series.Name;
    }
  }
}
