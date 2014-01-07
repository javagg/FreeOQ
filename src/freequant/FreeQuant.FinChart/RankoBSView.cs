// Type: SmartQuant.FinChart.RankoBSView
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
  public class RankoBSView : SeriesView
  {
    private BarSeries rPoS1WavBw;
    private Ranko SxvSUG7nWo;

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
        return this.rPoS1WavBw[this.lastDate, EIndexOption.Prev].Close;
      }
    }

    public override TimeSeries MainSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (TimeSeries) this.SxvSUG7nWo;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RankoBSView(Pad pad, BarSeries series)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector(pad);
      this.rPoS1WavBw = series;
      this.pad = pad;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(3504);
      this.SxvSUG7nWo = new Ranko(series, 0.3);
      this.SxvSUG7nWo.Calculate();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override PadRange GetPadRangeY(Pad Pad)
    {
      return new PadRange(this.SxvSUG7nWo.LowestLow(this.firstDate, this.lastDate), this.SxvSUG7nWo.HighestHigh(this.firstDate, this.lastDate));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Paint()
    {
      Pen pen1 = new Pen(Color.Black);
      Pen pen2 = new Pen(Color.Brown);
      Pen pen3 = new Pen(Color.White);
      SolidBrush solidBrush1 = new SolidBrush(Color.White);
      SolidBrush solidBrush2 = new SolidBrush(Color.Black);
      int index1 = this.SxvSUG7nWo.GetIndex(this.firstDate);
      int index2 = this.SxvSUG7nWo.GetIndex(this.lastDate);
      if (index2 == -1 || index2 == -1)
        return;
      int width = Math.Max(2, (int) this.pad.IntervalWidth);
      if (index1 == -1)
        return;
      int height = this.pad.ClientY(0.0) - this.pad.ClientY(this.SxvSUG7nWo.BoxSize);
      for (int index3 = index1; index3 <= index2; ++index3)
      {
        int num1 = this.pad.ClientX(this.SxvSUG7nWo.GetDateTime(index3));
        Bar bar = this.SxvSUG7nWo[index3];
        double open = this.SxvSUG7nWo[index3].Open;
        double close = this.SxvSUG7nWo[index3].Close;
        int num2 = (int) Math.Floor(Math.Abs(close - open) / this.SxvSUG7nWo.BoxSize);
        if (open > close)
        {
          Pen pen4 = pen2;
          for (int index4 = 0; index4 < num2; ++index4)
          {
            this.pad.Graphics.DrawRectangle(new Pen(Color.Black, 1f), num1 + width * index4 - width / 2, this.pad.ClientY(open - this.SxvSUG7nWo.BoxSize * (double) index4), width, height);
            this.pad.Graphics.FillRectangle((Brush) new SolidBrush(pen4.Color), num1 + width * index4 - width / 2, this.pad.ClientY(open - this.SxvSUG7nWo.BoxSize * (double) index4) + 1, width, height);
          }
        }
        else
        {
          pen1 = pen3;
          if (num2 == 2)
            pen1 = pen3;
          for (int index4 = 0; index4 < num2; ++index4)
            this.pad.Graphics.DrawRectangle(new Pen(Color.Black, 1f), num1 + width * index4 - width / 2, this.pad.ClientY(close - this.SxvSUG7nWo.BoxSize * (double) (num2 - 1 - index4)), width, height);
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Distance Distance(int x, double y)
    {
      Distance distance = new Distance();
      Bar bar = this.SxvSUG7nWo[this.pad.GetDateTime(x)];
      distance.DX = 0.0;
      if (y >= bar.Low && y <= bar.High)
        distance.DY = 0.0;
      if (distance.DX == double.MaxValue || distance.DY == double.MaxValue)
        return (Distance) null;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(this.toolTipFormat, (object) this.rPoS1WavBw.Name, (object) this.rPoS1WavBw.Title, (object) bar.DateTime.ToString(this.rPoS1WavBw.ToolTipDateTimeFormat), (object) bar.High, (object) bar.Low, (object) bar.Open, (object) bar.Close, (object) bar.Volume);
      distance.ToolTipText = ((object) stringBuilder).ToString();
      return distance;
    }
  }
}
