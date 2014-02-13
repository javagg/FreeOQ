using FreeQuant.Data;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Management
{
  internal class MarketDepthViewer : DataObjectViewer
  {
    private string dateTimeFormat;

    public MarketDepthViewer()
    {
      this.dateTimeFormat = Regex.Replace(string.Format("{0} {1}", (object) DateTimeFormatInfo.CurrentInfo.ShortDatePattern, (object) DateTimeFormatInfo.CurrentInfo.LongTimePattern), "(:ss|:s)", "$1.fff");
    }

    protected override ColumnHeader[] GetCustomColumnHeaders()
    {
      return new List<ColumnHeader>()
      {
        this.CreateColumnHeader("DateTime", 128, HorizontalAlignment.Right),
        this.CreateColumnHeader("Side", 64, HorizontalAlignment.Right),
        this.CreateColumnHeader("Action", 64, HorizontalAlignment.Right),
        this.CreateColumnHeader("Price", 64, HorizontalAlignment.Right),
        this.CreateColumnHeader("Size", 64, HorizontalAlignment.Right),
        this.CreateColumnHeader("Position", 64, HorizontalAlignment.Right)
      }.ToArray();
    }

    protected override string[] GetCustomSubItems(int index)
    {
			MarketDepth marketDepth = (MarketDepth) this.dataSeries[index];
      return new string[6]
      {
        marketDepth.DateTime.ToString(this.dateTimeFormat),
        ((object) marketDepth.Side).ToString(),
        ((object) marketDepth.Operation).ToString(),
        marketDepth.Price.ToString(this.priceFormat),
        marketDepth.Size.ToString("n0"),
        marketDepth.Position.ToString()
      };
    }

    public override DataObjectEditor GetEditor()
    {
      return (DataObjectEditor) null;
    }
  }
}
