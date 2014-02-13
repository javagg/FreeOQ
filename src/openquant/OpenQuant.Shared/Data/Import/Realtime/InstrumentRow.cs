// Type: OpenQuant.Shared.Data.Import.Realtime.InstrumentRow
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using FreeQuant.FIX;
using FreeQuant.Instruments;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.Realtime
{
  internal class InstrumentRow : DataGridViewRow
  {
    public Instrument Instrument { get; private set; }

    public int Trades { get; set; }

    public int Quotes { get; set; }

    public int Bars { get; set; }

    public int MarketDepths { get; set; }

    public InstrumentRow(Instrument instrument)
    {
      this.Instrument = instrument;
      this.Trades = 0;
      this.Quotes = 0;
      this.Bars = 0;
      this.MarketDepths = 0;
      this.Cells[0].Value = (object) ((FIXInstrument) instrument).Symbol;
      this.UpdateValues();
    }

    protected override DataGridViewCellCollection CreateCellsInstance()
    {
      DataGridViewCellCollection viewCellCollection = new DataGridViewCellCollection((DataGridViewRow) this);
      for (int index = 0; index < 5; ++index)
        viewCellCollection.Add((DataGridViewCell) new DataGridViewTextBoxCell());
      return viewCellCollection;
    }

    public void UpdateValues()
    {
      this.Cells[1].Value = (object) this.Trades;
      this.Cells[2].Value = (object) this.Quotes;
      this.Cells[3].Value = (object) this.Bars;
      this.Cells[4].Value = (object) this.MarketDepths;
    }
  }
}
