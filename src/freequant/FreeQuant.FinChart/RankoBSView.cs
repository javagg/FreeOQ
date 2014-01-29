using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace FreeQuant.FinChart
{
  public class RankoBSView : SeriesView
  {
		private BarSeries  barSeries;
		private Ranko ranko; 

    public override Color Color
    {
      get
      {
        return Color.FromArgb(0, (int) byte.MaxValue, 0);
      }
      set
      {
      }
    }

    public override double LastValue
    {
      get
      {
        return this.barSeries[this.lastDate, EIndexOption.Prev].Close;
      }
    }

    public override TimeSeries MainSeries
    {
      get
      {
        return this.ranko;
      }
    }

    
		public RankoBSView(Pad pad, BarSeries series) : base(pad)
    {
      this.barSeries = series;
      this.pad = pad;
			this.ToolTipFormat = "dfsfdfs";
      this.ranko = new Ranko(series, 0.3);
      this.ranko.Calculate();
    }

    
    public override PadRange GetPadRangeY(Pad Pad)
    {
      return new PadRange(this.ranko.LowestLow(this.firstDate, this.lastDate), this.ranko.HighestHigh(this.firstDate, this.lastDate));
    }

    
    public override void Paint()
    {
      Pen pen1 = new Pen(Color.Black);
      Pen pen2 = new Pen(Color.Brown);
      Pen pen3 = new Pen(Color.White);
      SolidBrush solidBrush1 = new SolidBrush(Color.White);
      SolidBrush solidBrush2 = new SolidBrush(Color.Black);
      int index1 = this.ranko.GetIndex(this.firstDate);
      int index2 = this.ranko.GetIndex(this.lastDate);
      if (index2 == -1 || index2 == -1)
        return;
      int width = Math.Max(2, (int) this.pad.IntervalWidth);
      if (index1 == -1)
        return;
      int height = this.pad.ClientY(0.0) - this.pad.ClientY(this.ranko.BoxSize);
      for (int index3 = index1; index3 <= index2; ++index3)
      {
        int num1 = this.pad.ClientX(this.ranko.GetDateTime(index3));
        Bar bar = this.ranko[index3];
        double open = this.ranko[index3].Open;
        double close = this.ranko[index3].Close;
        int num2 = (int) Math.Floor(Math.Abs(close - open) / this.ranko.BoxSize);
        if (open > close)
        {
          Pen pen4 = pen2;
          for (int index4 = 0; index4 < num2; ++index4)
          {
            this.pad.Graphics.DrawRectangle(new Pen(Color.Black, 1f), num1 + width * index4 - width / 2, this.pad.ClientY(open - this.ranko.BoxSize * (double) index4), width, height);
            this.pad.Graphics.FillRectangle((Brush) new SolidBrush(pen4.Color), num1 + width * index4 - width / 2, this.pad.ClientY(open - this.ranko.BoxSize * (double) index4) + 1, width, height);
          }
        }
        else
        {
          pen1 = pen3;
          if (num2 == 2)
            pen1 = pen3;
          for (int index4 = 0; index4 < num2; ++index4)
            this.pad.Graphics.DrawRectangle(new Pen(Color.Black, 1f), num1 + width * index4 - width / 2, this.pad.ClientY(close - this.ranko.BoxSize * (double) (num2 - 1 - index4)), width, height);
        }
      }
    }

    
    public override Distance Distance(int x, double y)
    {
      Distance distance = new Distance();
      Bar bar = this.ranko[this.pad.GetDateTime(x)];
      distance.DX = 0.0;
      if (y >= bar.Low && y <= bar.High)
        distance.DY = 0.0;
      if (distance.DX == double.MaxValue || distance.DY == double.MaxValue)
        return (Distance) null;
      StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat(this.ToolTipFormat, this.barSeries.Name, (object) this.barSeries.Title, (object) bar.DateTime.ToString(this.barSeries.ToolTipDateTimeFormat), (object) bar.High, (object) bar.Low, (object) bar.Open, (object) bar.Close, (object) bar.Volume);
      distance.ToolTipText = ((object) stringBuilder).ToString();
      return distance;
    }
  }
}
