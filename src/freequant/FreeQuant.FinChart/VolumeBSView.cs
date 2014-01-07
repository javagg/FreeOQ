// Type: SmartQuant.FinChart.VolumeBSView
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using cY9o6QKnveiK0L5ffy;
using SmartQuant.Data;
using SmartQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using yHueqhRH1sS5jNKgDq;

namespace SmartQuant.FinChart
{
  public class VolumeBSView : SeriesView
  {
    private DoubleSeries cNQwO6AHR;
    private Color sxtcYpgtQ;

    [Category("Drawing Style")]
    public override Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.sxtcYpgtQ;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.sxtcYpgtQ = value;
      }
    }

    public override int LabelDigitsCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return 0;
      }
    }

    public override string DisplayName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.MainSeries.Name + FJDHryrxb1WIq5jBAt.mT707pbkgT(50);
      }
    }

    public override TimeSeries MainSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (TimeSeries) this.cNQwO6AHR;
      }
    }

    public override double LastValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return ((TimeSeries) this.cNQwO6AHR)[this.cNQwO6AHR.GetIndex(this.lastDate, EIndexOption.Prev), BarData.Volume];
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VolumeBSView(Pad pad, DoubleSeries series)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.sxtcYpgtQ = Color.SteelBlue;
      // ISSUE: explicit constructor call
      base.\u002Ector(pad);
      this.cNQwO6AHR = series;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override PadRange GetPadRangeY(Pad Pad)
    {
      double min = this.cNQwO6AHR.GetMin(this.firstDate, this.lastDate, BarData.Volume);
      double max = this.cNQwO6AHR.GetMax(this.firstDate, this.lastDate, BarData.Volume);
      if (min >= max)
      {
        double num = min / 10.0;
        min -= num;
        max += num;
      }
      return new PadRange(min, max);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Paint()
    {
      SolidBrush solidBrush = new SolidBrush(this.sxtcYpgtQ);
      int index1 = this.cNQwO6AHR.GetIndex(this.firstDate);
      int index2 = this.cNQwO6AHR.GetIndex(this.lastDate);
      if (index1 == -1 || index2 == -1)
        return;
      int val2_1 = this.pad.ClientY(0.0);
      int val2_2 = this.pad.ClientY(this.pad.MaxValue);
      int val2_3 = this.pad.ClientY(this.pad.MinValue);
      int num1 = (int) Math.Max(2.0, (double) (int) this.pad.IntervalWidth / 1.2);
      for (int index3 = index1; index3 <= index2; ++index3)
      {
        int num2 = this.pad.ClientX(this.cNQwO6AHR.GetDateTime(index3));
        int val1 = this.pad.ClientY(((TimeSeries) this.cNQwO6AHR)[index3, BarData.Volume]);
        float y = (float) Math.Max(Math.Min(val1, val2_1), val2_2);
        float num3 = (float) Math.Min(Math.Max(val1, val2_1), val2_3);
        if ((double) num3 - (double) y < 1.0)
          y = num3 - 1f;
        this.pad.Graphics.FillRectangle((Brush) new SolidBrush(this.sxtcYpgtQ), (float) (num2 - num1 / 2), y, (float) num1, Math.Abs(y - num3));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Distance Distance(int x, double y)
    {
      Distance distance = new Distance();
      DateTime dateTime = this.pad.GetDateTime(x);
      int index = this.cNQwO6AHR.GetIndex(dateTime);
      distance.DX = 0.0;
      if (y <= ((TimeSeries) this.cNQwO6AHR)[index, BarData.Volume])
        distance.DY = 0.0;
      if (distance.DX == double.MaxValue || distance.DY == double.MaxValue)
        return (Distance) null;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(this.toolTipFormat, (object) this.cNQwO6AHR.Name, (object) this.cNQwO6AHR.Title, (object) dateTime.ToString(this.cNQwO6AHR.ToolTipDateTimeFormat), (object) ((TimeSeries) this.cNQwO6AHR)[index, BarData.Volume]);
      distance.ToolTipText = ((object) stringBuilder).ToString();
      return distance;
    }
  }
}
