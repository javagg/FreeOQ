using FreeQuant.Data;
using FreeQuant.Series;
using System.Runtime.CompilerServices;
using System.Text;

namespace FreeQuant.FinChart
{
  public abstract class BSView : SeriesView
  {
		public BSView(Pad pad) : base(pad)
    {
    }

    
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
			stringBuilder.AppendFormat(this.ToolTipFormat, this.MainSeries.Name, (object) this.MainSeries.Title, (object) bar.DateTime.ToString((this.MainSeries as BarSeries).ToolTipDateTimeFormat), (object) bar.High, (object) bar.Low, (object) bar.Open, (object) bar.Close, (object) bar.Volume);
      distance.ToolTipText = stringBuilder.ToString();
      return distance;
    }
  }
}
