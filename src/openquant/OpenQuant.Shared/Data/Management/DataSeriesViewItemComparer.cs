using FreeQuant.FIX;
using System;
using System.Collections;

namespace OpenQuant.Shared.Data.Management
{
  class DataSeriesViewItemComparer : IComparer
  {
    private int[] sortOrders;
    private int column;

    public DataSeriesViewItemComparer()
    {
      this.sortOrders = new int[]
      {
        1,
        -1,
        -1,
        -1
      };
      this.column = 0;
    }

    public void SortByColumn(int column)
    {
      this.column = column;
      this.sortOrders[column] *= -1;
    }

    public int Compare(object x, object y)
    {
      InstrumentDataSeries series1 = ((InstrumentDataSeriesViewItem) x).Series;
      InstrumentDataSeries series2 = ((InstrumentDataSeriesViewItem) y).Series;
      int num = 0;
      switch (this.column)
      {
        case 0:
          num = string.Compare(((FIXInstrument) series1.Instrument).Symbol, ((FIXInstrument) series2.Instrument).Symbol);
          break;
        case 1:
          num = series1.DataSeries.Count.CompareTo(series2.DataSeries.Count);
          break;
        case 2:
					num = DateTime.Compare(series1.DataSeries.Count == 0 ? DateTime.MinValue : series1.DataSeries.FirstDateTime, series2.DataSeries.Count == 0 ? DateTime.MinValue : series2.DataSeries.FirstDateTime);
          break;
        case 3:
          num = DateTime.Compare(series1.DataSeries.Count == 0 ? DateTime.MinValue : series1.DataSeries.LastDateTime, series2.DataSeries.Count == 0 ? DateTime.MinValue : series2.DataSeries.LastDateTime);
          break;
      }
      return num * this.sortOrders[this.column];
    }
  }
}
