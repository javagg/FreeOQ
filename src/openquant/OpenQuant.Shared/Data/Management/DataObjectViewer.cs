using OpenQuant.Shared.Data;
using FreeQuant.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Management
{
  internal abstract class DataObjectViewer
  {
    protected IDataSeries dataSeries;
    protected string priceFormat;
    protected ListViewItem lastItem;

    protected DataObjectViewer()
    {
      this.lastItem = (ListViewItem) null;
    }

    protected abstract ColumnHeader[] GetCustomColumnHeaders();

    protected abstract string[] GetCustomSubItems(int index);

    public abstract DataObjectEditor GetEditor();

    public static DataObjectViewer GetViewer(IDataSeries dataSeries)
    {
      if (dataSeries == null)
        return (DataObjectViewer) null;
      switch (DataSeriesHelper.GetDataSeriesInfo(dataSeries.Name).DataType)
      {
        case DataType.Trade:
          return (DataObjectViewer) new TradeViewer();
        case DataType.Quote:
          return (DataObjectViewer) new QuoteViewer();
        case DataType.Bar:
          return (DataObjectViewer) new BarViewer();
        case DataType.Daily:
          return (DataObjectViewer) new DailyViewer();
        case DataType.MarketDepth:
          return (DataObjectViewer) new MarketDepthViewer();
        default:
          return (DataObjectViewer) null;
      }
    }

    public void SetDataSeries(IDataSeries dataSeries)
    {
      this.dataSeries = dataSeries;
    }

    public void SetPriceFormat(string priceFormat)
    {
      this.priceFormat = priceFormat;
    }

    public ColumnHeader[] GetColumnHeaders()
    {
      List<ColumnHeader> list = new List<ColumnHeader>();
      list.Add(this.CreateColumnHeader("#", 0, HorizontalAlignment.Left));
      list.AddRange((IEnumerable<ColumnHeader>) this.GetCustomColumnHeaders());
      return list.ToArray();
    }

    public void ResetLastItem()
    {
      this.lastItem = (ListViewItem) null;
    }

    public ListViewItem GetListViewItem(int index)
    {
      if (index == this.dataSeries.Count - 1)
      {
        if (this.lastItem == null)
        {
          this.lastItem = new ListViewItem(index.ToString("n0"));
          this.lastItem.SubItems.AddRange(this.GetCustomSubItems(index));
        }
        return this.lastItem;
      }
      else
      {
        ListViewItem listViewItem = new ListViewItem(index.ToString("n0"));
        listViewItem.SubItems.AddRange(this.GetCustomSubItems(index));
        return listViewItem;
      }
    }

    protected ColumnHeader CreateColumnHeader(string text, int width, HorizontalAlignment alignment)
    {
      return new ColumnHeader()
      {
        Text = text,
        Width = width,
        TextAlign = alignment
      };
    }
  }
}
