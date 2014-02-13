using OpenQuant.Shared.Data;
using FreeQuant.Data;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Management
{
  internal class DataSeriesViewItem : ListViewItem
  {
    private int objectsCount = -1;
    private IDataSeries dataSeries;

    public IDataSeries DataSeries
    {
      get
      {
        return this.dataSeries;
      }
    }

    public DataSeriesViewItem(IDataSeries dataSeries)
      : base(new string[4], 0)
    {
      this.dataSeries = dataSeries;
      this.Update();
    }

    public void Update()
    {
      if (this.dataSeries.Count == this.objectsCount)
        return;
      this.objectsCount = this.dataSeries.Count;
      this.SubItems[0].Text = DataSeriesHelper.SeriesNameToString(this.dataSeries.Name);
      this.SubItems[1].Text = this.dataSeries.Count.ToString("n0");
      if (this.dataSeries.Count > 0)
      {
        this.SubItems[2].Text = this.dataSeries.FirstDateTime.ToString();
        this.SubItems[3].Text = this.dataSeries.LastDateTime.ToString();
      }
      else
      {
        this.SubItems[2].Text = "-";
        this.SubItems[3].Text = "-";
      }
    }
  }
}
