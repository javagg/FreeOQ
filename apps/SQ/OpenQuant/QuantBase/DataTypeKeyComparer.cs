// Type: OpenQuant.QuantBase.DataTypeKeyComparer
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared.Data;
using System.Collections.Generic;

namespace OpenQuant.QuantBase
{
  internal class DataTypeKeyComparer : IComparer<DataTypeKey>
  {
    private Dictionary<DataType, int> order;

    public DataTypeKeyComparer()
    {
      this.order = new Dictionary<DataType, int>();
      this.order.Add((DataType) 1, 1);
      this.order.Add((DataType) 2, 2);
      this.order.Add((DataType) 5, 3);
      this.order.Add((DataType) 4, 4);
      this.order.Add((DataType) 3, 5);
    }

    public int Compare(DataTypeKey x, DataTypeKey y)
    {
      if (x.Info.get_DataType() != y.Info.get_DataType() || x.Info.get_DataType() != 3)
        return this.order[x.Info.get_DataType()].CompareTo(this.order[y.Info.get_DataType()]);
      if (x.Info.get_BarType() == y.Info.get_BarType())
        return x.Info.get_BarSize().CompareTo(y.Info.get_BarSize());
      else
        return string.Compare(((object) x.Info.get_BarType()).ToString(), ((object) y.Info.get_BarType()).ToString());
    }
  }
}
