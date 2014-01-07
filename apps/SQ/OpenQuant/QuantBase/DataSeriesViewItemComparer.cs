// Type: OpenQuant.QuantBase.DataSeriesViewItemComparer
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System;
using System.Collections;

namespace OpenQuant.QuantBase
{
  internal class DataSeriesViewItemComparer : IComparer
  {
    private int[] sortOrders;
    private int column;

    public DataSeriesViewItemComparer()
    {
      this.sortOrders = new int[4]
      {
        1,
        -1,
        -1,
        -1
      };
      this.column = 0;
    }

    public void SetSortColumn(int column)
    {
      this.column = column;
      this.sortOrders[column] *= -1;
    }

    public int Compare(object x, object y)
    {
      DataSeriesItem dataSeriesItem1 = ((DataSeriesViewItem) x).Item;
      DataSeriesItem dataSeriesItem2 = ((DataSeriesViewItem) y).Item;
      int num = 0;
      switch (this.column)
      {
        case 0:
          num = string.Compare(dataSeriesItem1.SH_Info.get_Symbol(), dataSeriesItem2.SH_Info.get_Symbol());
          break;
        case 1:
          num = dataSeriesItem1.QB_Info.Count.CompareTo(dataSeriesItem2.QB_Info.Count);
          break;
        case 2:
          num = DateTime.Compare(!dataSeriesItem1.QB_Info.Begin.HasValue ? DateTime.MinValue : dataSeriesItem1.QB_Info.Begin.Value, !dataSeriesItem2.QB_Info.Begin.HasValue ? DateTime.MinValue : dataSeriesItem2.QB_Info.Begin.Value);
          break;
        case 3:
          num = DateTime.Compare(!dataSeriesItem1.QB_Info.End.HasValue ? DateTime.MinValue : dataSeriesItem1.QB_Info.End.Value, !dataSeriesItem2.QB_Info.End.HasValue ? DateTime.MinValue : dataSeriesItem2.QB_Info.End.Value);
          break;
      }
      return num * this.sortOrders[this.column];
    }
  }
}
