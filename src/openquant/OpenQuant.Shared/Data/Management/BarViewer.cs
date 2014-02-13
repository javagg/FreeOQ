using FreeQuant.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Management
{
  internal class BarViewer : DataObjectViewer
  {
    protected override ColumnHeader[] GetCustomColumnHeaders()
    {
      return new List<ColumnHeader>()
      {
        this.CreateColumnHeader("Date", 80, HorizontalAlignment.Right),
        this.CreateColumnHeader("Time", 160, HorizontalAlignment.Right),
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
			Bar bar = (Bar) this.dataSeries[index];
      string str1;
      string str2;
      if (bar.BeginTime.Date == bar.EndTime.Date)
      {
				str1 = string.Format("{0:d}", bar.DateTime);
        str2 = string.Format("{0:T} - {1:T}", bar.BeginTime, bar.EndTime);
      }
      else
      {
        str1 = "";
        str2 = string.Format("{0} - {1}", (object) bar.BeginTime, bar.EndTime);
      }
      return new string[]
      {
        str1,
        str2,
        bar.Open.ToString(this.priceFormat),
        bar.High.ToString(this.priceFormat),
        bar.Low.ToString(this.priceFormat),
        bar.Close.ToString(this.priceFormat),
        bar.Volume.ToString("n0"),
        bar.OpenInt.ToString("n0")
      };
    }

    public override DataObjectEditor GetEditor()
    {
      BarEditor barEditor = new BarEditor();
			barEditor.InitBarSettings(this.dataSeries.Name);
      return (DataObjectEditor) barEditor;
    }
  }
}
