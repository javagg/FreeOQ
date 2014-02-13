using System.Collections.Generic;

namespace OpenQuant.Shared.Data.Bars
{
  internal class BarDataSourceComparer : IComparer<BarDataSource>
  {
    public int Compare(BarDataSource x, BarDataSource y)
    {
      if (x.BarType == y.BarType)
        return x.BarSize.CompareTo(y.BarSize);
      else
        return string.Compare(((object) x.BarType).ToString(), ((object) y.BarType).ToString());
    }
  }
}
