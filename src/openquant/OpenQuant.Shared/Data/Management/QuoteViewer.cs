using FreeQuant.Data;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Management
{
  internal class QuoteViewer : DataObjectViewer
  {
    private string dateTimeFormat;

    public QuoteViewer()
    {
      this.dateTimeFormat = Regex.Replace(DateTimeFormatInfo.CurrentInfo.ShortDatePattern + " " + DateTimeFormatInfo.CurrentInfo.LongTimePattern, "(:ss|:s)", "$1.fff");
    }

    protected override ColumnHeader[] GetCustomColumnHeaders()
    {
      return new List<ColumnHeader>()
      {
        this.CreateColumnHeader("DateTime", 128, HorizontalAlignment.Right),
        this.CreateColumnHeader("Bid", 64, HorizontalAlignment.Right),
        this.CreateColumnHeader("BidSize", 64, HorizontalAlignment.Right),
        this.CreateColumnHeader("Ask", 64, HorizontalAlignment.Right),
        this.CreateColumnHeader("AskSize", 64, HorizontalAlignment.Right)
      }.ToArray();
    }

    protected override string[] GetCustomSubItems(int index)
    {
			Quote quote = (Quote) this.dataSeries[index];
      return new string[5]
      {
        quote.DateTime.ToString(this.dateTimeFormat),
        quote.Bid.ToString(this.priceFormat),
        quote.BidSize.ToString("n0"),
        quote.Ask.ToString(this.priceFormat),
        quote.AskSize.ToString("n0")
      };
    }

    public override DataObjectEditor GetEditor()
    {
      return (DataObjectEditor) new QuoteEditor();
    }
  }
}
