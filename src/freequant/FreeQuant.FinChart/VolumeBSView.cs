using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace FreeQuant.FinChart
{
  public class VolumeBSView : SeriesView
  {
		private DoubleSeries series; 
    private Color color;

    [Category("Drawing Style")]
    public override Color Color
    {
      get
      {
				return this.color; 
      }
      set
      {
        this.color = value;
      }
    }

    public override int LabelDigitsCount
    {
      get
      {
        return 0;
      }
    }

    public override string DisplayName
    {
      get
      {
				return this.MainSeries.Name + "";
      }
    }

    public override TimeSeries MainSeries
    {
      get
      {
        return this.series;
      }
    }

    public override double LastValue
    {
      get
      {
        return ((TimeSeries) this.series)[this.series.GetIndex(this.lastDate, EIndexOption.Prev), BarData.Volume];
      }
    }

    
		public VolumeBSView(Pad pad, DoubleSeries series) : base(pad)
    {
		this.Color = Color.SteelBlue;
      this.series = series;
		this.ToolTipFormat = "";
    }

    
    public override PadRange GetPadRangeY(Pad Pad)
    {
      double min = this.series.GetMin(this.firstDate, this.lastDate, BarData.Volume);
      double max = this.series.GetMax(this.firstDate, this.lastDate, BarData.Volume);
      if (min >= max)
      {
        double num = min / 10.0;
        min -= num;
        max += num;
      }
      return new PadRange(min, max);
    }

    
    public override void Paint()
    {
      SolidBrush solidBrush = new SolidBrush(this.color);
      int index1 = this.series.GetIndex(this.firstDate);
      int index2 = this.series.GetIndex(this.lastDate);
      if (index1 == -1 || index2 == -1)
        return;
      int val2_1 = this.pad.ClientY(0.0);
      int val2_2 = this.pad.ClientY(this.pad.MaxValue);
      int val2_3 = this.pad.ClientY(this.pad.MinValue);
      int num1 = (int) Math.Max(2.0, (double) (int) this.pad.IntervalWidth / 1.2);
      for (int index3 = index1; index3 <= index2; ++index3)
      {
        int num2 = this.pad.ClientX(this.series.GetDateTime(index3));
        int val1 = this.pad.ClientY(((TimeSeries) this.series)[index3, BarData.Volume]);
        float y = (float) Math.Max(Math.Min(val1, val2_1), val2_2);
        float num3 = (float) Math.Min(Math.Max(val1, val2_1), val2_3);
        if ((double) num3 - (double) y < 1.0)
          y = num3 - 1f;
        this.pad.Graphics.FillRectangle((Brush) new SolidBrush(this.color), (float) (num2 - num1 / 2), y, (float) num1, Math.Abs(y - num3));
      }
    }

    
    public override Distance Distance(int x, double y)
    {
      Distance distance = new Distance();
      DateTime dateTime = this.pad.GetDateTime(x);
      int index = this.series.GetIndex(dateTime);
      distance.DX = 0.0;
      if (y <= ((TimeSeries) this.series)[index, BarData.Volume])
        distance.DY = 0.0;
      if (distance.DX == double.MaxValue || distance.DY == double.MaxValue)
        return (Distance) null;
      StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat(this.ToolTipFormat, this.series.Name, (object) this.series.Title, (object) dateTime.ToString(this.series.ToolTipDateTimeFormat), (object) ((TimeSeries) this.series)[index, BarData.Volume]);
			distance.ToolTipText =  stringBuilder.ToString();
      return distance;
    }
  }
}
