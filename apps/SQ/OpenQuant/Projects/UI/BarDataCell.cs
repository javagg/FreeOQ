// Type: OpenQuant.Projects.UI.BarDataCell
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.API;

namespace OpenQuant.Projects.UI
{
  internal class BarDataCell : MarketScannerCell
  {
    private Instrument instrument;
    private BarData barData;

    public BarDataCell(Instrument instrument, BarData barData)
    {
      this.barData = barData;
      this.instrument = instrument;
    }

    public override double GetValue()
    {
      if (this.instrument.get_Bar() != null)
        return this.instrument.get_Bar().get_Item(this.barData);
      else
        return double.NaN;
    }
  }
}
