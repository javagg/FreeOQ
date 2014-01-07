// Type: SmartQuant.FinChart.KagiBaView
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
  public class KagiBaView : SeriesView
  {
    private BarSeries Itiy9gS5Yd;
    private Kagi RCUyO2wSvi;

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
        return this.Itiy9gS5Yd[this.lastDate, EIndexOption.Prev].Close;
      }
    }

    public override TimeSeries MainSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (TimeSeries) this.RCUyO2wSvi;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KagiBaView(Pad pad, BarSeries series)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector(pad);
      this.Itiy9gS5Yd = series;
      this.pad = pad;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(3020);
      this.RCUyO2wSvi = new Kagi(series, EKagiStyle.Percent, 1.0);
      this.RCUyO2wSvi.Calculate();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override PadRange GetPadRangeY(Pad Pad)
    {
      return new PadRange(this.RCUyO2wSvi.LowestLow(this.firstDate, this.lastDate), this.RCUyO2wSvi.HighestHigh(this.firstDate, this.lastDate));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Calculate()
    {
      this.RCUyO2wSvi.Calculate();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Paint()
    {
      Pen pen1 = new Pen(Color.Black);
      Pen pen2 = new Pen(Color.Pink);
      Pen pen3 = new Pen(Color.LightBlue);
      SolidBrush solidBrush1 = new SolidBrush(Color.White);
      SolidBrush solidBrush2 = new SolidBrush(Color.Black);
      int index1 = this.RCUyO2wSvi.GetIndex(this.firstDate);
      int index2 = this.RCUyO2wSvi.GetIndex(this.lastDate);
      if (index2 == -1 || index2 == -1)
        return;
      int num1 = Math.Max(2, (int) this.pad.IntervalWidth);
      for (int index3 = index1; index3 <= index2; ++index3)
      {
        int num2 = this.pad.ClientX(this.RCUyO2wSvi.GetDateTime(index3));
        Bar bar = this.RCUyO2wSvi[index3];
        double open = this.RCUyO2wSvi[index3].Open;
        double close = this.RCUyO2wSvi[index3].Close;
        Pen pen4 = this.RCUyO2wSvi[index3].Open >= this.RCUyO2wSvi[index3].Close ? pen3 : pen2;
        this.pad.Graphics.DrawLine(pen4, num2 - num1 / 2, this.pad.ClientY(open), num2 + num1 / 2, this.pad.ClientY(open));
        this.pad.Graphics.DrawLine(pen4, num2 + num1 / 2, this.pad.ClientY(open), num2 + num1 / 2, this.pad.ClientY(close));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Distance Distance(int x, double y)
    {
      Distance distance = new Distance();
      Bar bar = this.RCUyO2wSvi[this.pad.GetDateTime(x)];
      distance.DX = 0.0;
      if (y >= bar.Low && y <= bar.High)
        distance.DY = 0.0;
      if (distance.DX == double.MaxValue || distance.DY == double.MaxValue)
        return (Distance) null;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(this.toolTipFormat, (object) this.Itiy9gS5Yd.Name, (object) this.Itiy9gS5Yd.Title, (object) bar.DateTime.ToString(this.Itiy9gS5Yd.ToolTipDateTimeFormat), (object) bar.High, (object) bar.Low, (object) bar.Open, (object) bar.Close, (object) bar.Volume);
      distance.ToolTipText = ((object) stringBuilder).ToString();
      return distance;
    }
  }
}
