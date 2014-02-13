using OpenQuant.Shared.Data;
using FreeQuant.Data;

namespace OpenQuant.Shared.Data.Management
{
  internal class BarDataTypeItem : DataTypeItem
  {
    private BarType barType;
    private long barSize;
    private string key;

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

    public BarDataTypeItem(BarType barType, long barSize)
      : base(DataType.Bar)
    {
      this.barType = barType;
      this.barSize = barSize;
      this.key = string.Format("{0}{1}", (object) barType, (object) barSize);
    }

    public override string ToString()
    {
      return string.Format("Bar {0}", (object) DataSeriesHelper.BarTypeSizeToString(this.barType, this.barSize));
    }
  }
}
