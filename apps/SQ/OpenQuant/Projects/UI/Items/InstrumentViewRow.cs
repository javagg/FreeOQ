// Type: OpenQuant.Projects.UI.Items.InstrumentViewRow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.API;
using OpenQuant.Projects.UI;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI.Items
{
  internal class InstrumentViewRow : DataGridViewRow
  {
    private Instrument instrument;
    private List<MarketScannerCell> items;

    public Instrument Instrument
    {
      get
      {
        return this.instrument;
      }
    }

    public InstrumentViewRow(Instrument instrument, List<MarketScannerCell> items)
    {
      this.instrument = instrument;
      this.items = items;
      Color color1 = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 200);
      Color color2 = Color.FromArgb((int) byte.MaxValue, 230, 230);
      this.Cells[0].Value = (object) instrument.get_Symbol();
      this.Cells[0].Style.BackColor = color1;
      this.Cells[1].Style.Format = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern + " " + DateTimeFormatInfo.CurrentInfo.LongTimePattern;
      this.Cells[1].Style.BackColor = color2;
      for (int index = 0; index < items.Count; ++index)
        this.Cells[2 + index].Style.Format = instrument.get_PriceFormat();
      this.Cells[0].Value = (object) this.Instrument.get_Symbol();
      this.Update();
    }

    protected override DataGridViewCellCollection CreateCellsInstance()
    {
      DataGridViewCellCollection viewCellCollection = new DataGridViewCellCollection((DataGridViewRow) this);
      for (int index = 0; index < this.items.Count + 2; ++index)
        viewCellCollection.Add((DataGridViewCell) new DataGridViewTextBoxCell());
      return viewCellCollection;
    }

    public void Update()
    {
      this.Cells[1].Value = (object) this.Instrument.get_Bar().get_DateTime();
      for (int index = 0; index < this.items.Count; ++index)
      {
        double d = this.items[index].GetValue();
        if (!double.IsNaN(d) || this.Cells[index + 2].Value != null)
          this.Cells[index + 2].Value = (object) d;
      }
    }
  }
}
