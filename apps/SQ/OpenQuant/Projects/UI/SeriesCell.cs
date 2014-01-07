// Type: OpenQuant.Projects.UI.SeriesCell
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.API;

namespace OpenQuant.Projects.UI
{
  internal class SeriesCell : MarketScannerCell
  {
    private ISeries series;

    public SeriesCell(ISeries series)
    {
      this.series = series;
    }

    public override double GetValue()
    {
      if (this.series.get_Count() > 0)
        return this.series.get_Item(this.series.get_Count() - 1, (BarData) 0);
      else
        return double.NaN;
    }
  }
}
