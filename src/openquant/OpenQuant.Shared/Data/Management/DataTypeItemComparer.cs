// Type: OpenQuant.Shared.Data.Management.DataTypeItemComparer
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using OpenQuant.Shared.Data;
using System.Collections.Generic;

namespace OpenQuant.Shared.Data.Management
{
  internal class DataTypeItemComparer : IComparer<DataTypeItem>
  {
    private Dictionary<DataType, int> sortOrders;

    public DataTypeItemComparer()
    {
      this.sortOrders = new Dictionary<DataType, int>();
      this.sortOrders.Add(DataType.Trade, 1);
      this.sortOrders.Add(DataType.Quote, 2);
      this.sortOrders.Add(DataType.Daily, 3);
      this.sortOrders.Add(DataType.Bar, 4);
      this.sortOrders.Add(DataType.MarketDepth, 5);
    }

    public int Compare(DataTypeItem x, DataTypeItem y)
    {
      if (x.DataType != DataType.Bar || y.DataType != DataType.Bar)
        return this.sortOrders[x.DataType].CompareTo(this.sortOrders[y.DataType]);
      BarDataTypeItem barDataTypeItem1 = (BarDataTypeItem) x;
      BarDataTypeItem barDataTypeItem2 = (BarDataTypeItem) y;
      if (barDataTypeItem1.BarType == barDataTypeItem2.BarType)
        return barDataTypeItem1.BarSize.CompareTo(barDataTypeItem2.BarSize);
      else
        return string.Compare(((object) barDataTypeItem1.BarType).ToString(), ((object) barDataTypeItem2.BarType).ToString());
    }
  }
}
