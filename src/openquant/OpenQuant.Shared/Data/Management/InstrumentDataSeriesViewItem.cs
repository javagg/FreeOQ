using FreeQuant.FIX;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Management
{
  internal class InstrumentDataSeriesViewItem : ListViewItem
  {
    private InstrumentDataSeries series;

    public InstrumentDataSeries Series
    {
      get
      {
        return this.series;
      }
    }

    public InstrumentDataSeriesViewItem(InstrumentDataSeries series)
      : base(new string[4], 0)
    {
      this.series = series;
      this.UpdateValues();
    }

    public void UpdateValues()
    {
      this.SubItems[0].Text = ((FIXInstrument) this.series.Instrument).Symbol;
      this.SubItems[1].Text = this.series.DataSeries.Count.ToString("n0");
      if (this.series.DataSeries.Count > 0)
      {
				this.SubItems[2].Text = this.series.DataSeries.FirstDateTime.ToString();
        this.SubItems[3].Text = this.series.DataSeries.LastDateTime.ToString();
      }
      else
      {
        this.SubItems[2].Text = "-";
        this.SubItems[3].Text = "-";
      }
    }
  }
}
