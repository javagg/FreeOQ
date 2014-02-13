using FreeQuant.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Management
{
  internal class DailyViewer : DataObjectViewer
  {
    protected override ColumnHeader[] GetCustomColumnHeaders()
    {
      return new List<ColumnHeader>()
      {
        this.CreateColumnHeader("Date", 80, HorizontalAlignment.Right),
        this.CreateColumnHeader("Open", 80, HorizontalAlignment.Right),
        this.CreateColumnHeader("High", 80, HorizontalAlignment.Right),
        this.CreateColumnHeader("Low", 80, HorizontalAlignment.Right),
        this.CreateColumnHeader("Close", 80, HorizontalAlignment.Right),
        this.CreateColumnHeader("Volume", 80, HorizontalAlignment.Right),
        this.CreateColumnHeader("OpenInt", 80, HorizontalAlignment.Right)
      }.ToArray();
    }

    protected override string[] GetCustomSubItems(int index)
    {
			Daily daily = (Daily) this.dataSeries[index];
      return new string[7]
      {
        ((Bar) daily).DateTime.ToShortDateString(),
        ((Bar) daily).Open.ToString(this.priceFormat),
        ((Bar) daily).High.ToString(this.priceFormat),
        ((Bar) daily).Low.ToString(this.priceFormat),
        ((Bar) daily).Close.ToString(this.priceFormat),
        ((Bar) daily).Volume.ToString("n0"),
        ((Bar) daily).OpenInt.ToString("n0")
      };
    }

    public override DataObjectEditor GetEditor()
    {
      return (DataObjectEditor) new DailyEditor();
    }
  }
}
