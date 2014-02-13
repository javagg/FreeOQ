using FreeQuant.Data;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Management
{
  internal class TradeViewer : DataObjectViewer
  {
    private string dateTimeFormat;

    public TradeViewer()
    {
      this.dateTimeFormat = Regex.Replace(DateTimeFormatInfo.CurrentInfo.ShortDatePattern + " " + DateTimeFormatInfo.CurrentInfo.LongTimePattern, "(:ss|:s)", "$1.fff");
    }

    protected override ColumnHeader[] GetCustomColumnHeaders()
    {
      return new List<ColumnHeader>()
      {
        this.CreateColumnHeader("DateTime", 128, HorizontalAlignment.Right),
        this.CreateColumnHeader("Price", 64, HorizontalAlignment.Right),
        this.CreateColumnHeader("Size", 64, HorizontalAlignment.Right)
      }.ToArray();
    }

    protected override string[] GetCustomSubItems(int index)
    {
			Trade trade = (Trade) this.dataSeries[index];
      return new string[]
      {
        trade.DateTime.ToString(this.dateTimeFormat),
        trade.Price.ToString(this.priceFormat),
        trade.Size.ToString("n0")
      };
    }

    public override DataObjectEditor GetEditor()
    {
      return (DataObjectEditor) new TradeEditor();
    }
  }
}
