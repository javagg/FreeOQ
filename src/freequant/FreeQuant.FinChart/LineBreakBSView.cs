using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Drawing;
using System.Text;

namespace FreeQuant.FinChart
{
  public class LineBreakBSView : SeriesView
  {
		private BarSeries barSeries; 
		private LineBreak lineBreak; 

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
        return (TimeSeries) this.lineBreak;
      }
    }

    
		public LineBreakBSView(Pad pad, BarSeries series) : base(pad)
    {
      this.barSeries = series;
      this.pad = pad;
			this.ToolTipFormat = "toooll";
      this.lineBreak = new LineBreak(series, 3);
      this.lineBreak.Calculate();
    }

    
    public override PadRange GetPadRangeY(Pad Pad)
    {
      return new PadRange(this.lineBreak.LowestLow(this.firstDate, this.lastDate), this.lineBreak.HighestHigh(this.firstDate, this.lastDate));
    }

    
    public override void Paint()
    {
      Pen pen1 = new Pen(Color.Black);
      Pen pen2 = new Pen(Color.Brown);
      Pen pen3 = new Pen(Color.Yellow);
      SolidBrush solidBrush1 = new SolidBrush(Color.White);
      SolidBrush solidBrush2 = new SolidBrush(Color.Black);
      int index1 = this.lineBreak.GetIndex(this.firstDate);
      int index2 = this.lineBreak.GetIndex(this.lastDate);
      if (index2 == -1 || index2 == -1)
        return;
      int width = Math.Max(2, (int) this.pad.IntervalWidth);
      if (index1 == -1)
        return;
      for (int index3 = index1; index3 <= index2; ++index3)
      {
        int num = this.pad.ClientX(this.lineBreak.GetDateTime(index3));
        double open = this.lineBreak[index3].Open;
        double close = this.lineBreak[index3].Close;
        int height = Math.Abs(this.pad.ClientY(open) - this.pad.ClientY(close));
        if (open > close)
        {
          Pen pen4 = pen2;
          this.pad.Graphics.DrawRectangle(new Pen(Color.Black, 1f), num - width / 2, this.pad.ClientY(open), width, height);
          this.pad.Graphics.FillRectangle((Brush) new SolidBrush(pen4.Color), num - width / 2, this.pad.ClientY(open) + 1, width, height);
        }
        else
        {
          Pen pen4 = pen3;
          this.pad.Graphics.DrawRectangle(new Pen(Color.Black, 1f), num - width / 2, this.pad.ClientY(close), width, height);
          this.pad.Graphics.FillRectangle((Brush) new SolidBrush(pen4.Color), num - width / 2, this.pad.ClientY(close) + 1, width, height);
        }
      }
    }

    
    public override Distance Distance(int x, double y)
    {
      Distance distance = new Distance();
      Bar bar = this.lineBreak[this.pad.GetDateTime(x)];
      distance.DX = 0.0;
      if (y >= bar.Low && y <= bar.High)
        distance.DY = 0.0;
      if (distance.DX == double.MaxValue || distance.DY == double.MaxValue)
        return (Distance) null;
      StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat(this.ToolTipFormat, this.barSeries.Name, (object) this.barSeries.Title, (object) bar.DateTime.ToString(this.barSeries.ToolTipDateTimeFormat), (object) bar.High, (object) bar.Low, (object) bar.Open, (object) bar.Close, (object) bar.Volume);
			distance.ToolTipText =  stringBuilder.ToString();
      return distance;
    }
  }
}
