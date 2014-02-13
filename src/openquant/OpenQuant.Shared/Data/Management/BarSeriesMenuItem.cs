using OpenQuant.Shared.Data;
using FreeQuant.Data;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Management
{
  internal class BarSeriesMenuItem : ToolStripMenuItem
  {
    protected BarType barType;
    protected long barSize;

    public BarType BarType
    {
      get
      {
        return this.barType;
      }
    }

    public long BarSize
    {
      get
      {
        return this.barSize;
      }
    }

    public virtual bool CreateSeries
    {
      get
      {
        return true;
      }
    }

    public BarSeriesMenuItem(BarType barType, long barSize)
    {
      this.barType = barType;
      this.barSize = barSize;
      this.Text = DataSeriesHelper.BarTypeSizeToString(barType, barSize);
    }

    protected BarSeriesMenuItem()
    {
    }
  }
}
