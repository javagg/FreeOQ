// Type: SmartQuant.FinChart.LineBreakBSView
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using cY9o6QKnveiK0L5ffy;
using SmartQuant.Data;
using SmartQuant.Series;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using yHueqhRH1sS5jNKgDq;

namespace SmartQuant.FinChart
{
  public class LineBreakBSView : SeriesView
  {
    private BarSeries VD8SifY3I2;
    private LineBreak oeSSXpxoDy;

    public override Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return Color.FromArgb(0, (int) byte.MaxValue, 0);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
      }
    }

    public override double LastValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VD8SifY3I2[this.lastDate, EIndexOption.Prev].Close;
      }
    }

    public override TimeSeries MainSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (TimeSeries) this.oeSSXpxoDy;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LineBreakBSView(Pad pad, BarSeries series)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector(pad);
      this.VD8SifY3I2 = series;
      this.pad = pad;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(3380);
      this.oeSSXpxoDy = new LineBreak(series, 3);
      this.oeSSXpxoDy.Calculate();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override PadRange GetPadRangeY(Pad Pad)
    {
      return new PadRange(this.oeSSXpxoDy.LowestLow(this.firstDate, this.lastDate), this.oeSSXpxoDy.HighestHigh(this.firstDate, this.lastDate));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Paint()
    {
      Pen pen1 = new Pen(Color.Black);
      Pen pen2 = new Pen(Color.Brown);
      Pen pen3 = new Pen(Color.Yellow);
      SolidBrush solidBrush1 = new SolidBrush(Color.White);
      SolidBrush solidBrush2 = new SolidBrush(Color.Black);
      int index1 = this.oeSSXpxoDy.GetIndex(this.firstDate);
      int index2 = this.oeSSXpxoDy.GetIndex(this.lastDate);
      if (index2 == -1 || index2 == -1)
        return;
      int width = Math.Max(2, (int) this.pad.IntervalWidth);
      if (index1 == -1)
        return;
      for (int index3 = index1; index3 <= index2; ++index3)
      {
        int num = this.pad.ClientX(this.oeSSXpxoDy.GetDateTime(index3));
        double open = this.oeSSXpxoDy[index3].Open;
        double close = this.oeSSXpxoDy[index3].Close;
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Distance Distance(int x, double y)
    {
      Distance distance = new Distance();
      Bar bar = this.oeSSXpxoDy[this.pad.GetDateTime(x)];
      distance.DX = 0.0;
      if (y >= bar.Low && y <= bar.High)
        distance.DY = 0.0;
      if (distance.DX == double.MaxValue || distance.DY == double.MaxValue)
        return (Distance) null;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(this.toolTipFormat, (object) this.VD8SifY3I2.Name, (object) this.VD8SifY3I2.Title, (object) bar.DateTime.ToString(this.VD8SifY3I2.ToolTipDateTimeFormat), (object) bar.High, (object) bar.Low, (object) bar.Open, (object) bar.Close, (object) bar.Volume);
      distance.ToolTipText = ((object) stringBuilder).ToString();
      return distance;
    }
  }
}
