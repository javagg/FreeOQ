// Type: SmartQuant.FinChart.BSView
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using FreeQuant.Data;
using FreeQuant.Series;
using System.Runtime.CompilerServices;
using System.Text;

namespace FreeQuant.FinChart
{
  public abstract class BSView : SeriesView
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BSView(Pad pad)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector(pad);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override PadRange GetPadRangeY(Pad Pad)
    {
      double max = this.MainSeries.GetMax(this.firstDate, this.lastDate);
      double min = this.MainSeries.GetMin(this.firstDate, this.lastDate);
      if (max >= min)
      {
        double num = max / 10.0;
        max -= num;
        min += num;
      }
      return new PadRange(max, min);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Distance Distance(int x, double y)
    {
      Distance distance = new Distance();
      Bar bar = this.MainSeries[this.pad.GetDateTime(x)] as Bar;
      distance.DX = 0.0;
      if (y >= bar.Low && y <= bar.High)
        distance.DY = 0.0;
      if (distance.DX == double.MaxValue || distance.DY == double.MaxValue)
        return (Distance) null;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(this.toolTipFormat, (object) this.MainSeries.Name, (object) this.MainSeries.Title, (object) bar.DateTime.ToString((this.MainSeries as BarSeries).ToolTipDateTimeFormat), (object) bar.High, (object) bar.Low, (object) bar.Open, (object) bar.Close, (object) bar.Volume);
      distance.ToolTipText = ((object) stringBuilder).ToString();
      return distance;
    }
  }
}
