// Type: SmartQuant.FinChart.StopView
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using cY9o6QKnveiK0L5ffy;
using SmartQuant.Instruments;
using SmartQuant.Series;
using SmartQuant.Trading;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using yHueqhRH1sS5jNKgDq;

namespace SmartQuant.FinChart
{
  public class StopView : IChartDrawable, IZoomable
  {
    private ATSStop nkbcpi5r41;
    private Color J5OcWhbyeL;
    private Color jxFcFido6J;
    private Color nFpcIDd3Ej;
    private bool KN2czG9J28;
    protected Pad pad;
    protected DateTime firstDate;
    protected DateTime lastDate;
    protected bool toolTipEnabled;
    protected string toolTipFormat;
    protected bool selected;
    protected DateTime chartFirstDate;
    protected DateTime chartLastDate;

    [Category("Drawing Style")]
    public Color ExecutedColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jxFcFido6J;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.jxFcFido6J = value;
      }
    }

    [Category("Drawing Style")]
    public Color ActiveColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.J5OcWhbyeL;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.J5OcWhbyeL = value;
      }
    }

    [Category("Drawing Style")]
    public Color CanceledColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nFpcIDd3Ej;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nFpcIDd3Ej = value;
      }
    }

    [Category("Drawing Style")]
    [Browsable(false)]
    public bool TextEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.KN2czG9J28;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.KN2czG9J28 = value;
      }
    }

    [Description("Enable or disable tooltip appearance for this marker.")]
    [Category("ToolTip")]
    public bool ToolTipEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.toolTipEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.toolTipEnabled = value;
      }
    }

    [Category("ToolTip")]
    [Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
    public string ToolTipFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.toolTipFormat;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.toolTipFormat = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopView(ATSStop stop, Pad pad)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.J5OcWhbyeL = Color.Yellow;
      this.jxFcFido6J = Color.MediumSeaGreen;
      this.nFpcIDd3Ej = Color.Gray;
      this.toolTipEnabled = true;
      this.toolTipFormat = "";
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.nkbcpi5r41 = stop;
      this.pad = pad;
      this.toolTipEnabled = true;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(2144) + stop.Position.Instrument.PriceDisplay + FJDHryrxb1WIq5jBAt.mT707pbkgT(2182);
      int index1 = pad.Series.GetIndex(stop.CreationTime, EIndexOption.Prev);
      if (index1 == -1)
        return;
      this.chartFirstDate = pad.Series.GetDateTime(index1);
      if (stop.Status != StopStatus.Active)
      {
        int index2 = pad.Series.GetIndex(stop.CompletionTime, EIndexOption.Prev);
        this.chartLastDate = pad.Series.GetDateTime(index2);
      }
      else
        this.chartLastDate = DateTime.MaxValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Paint()
    {
      if (this.chartFirstDate > this.lastDate || this.chartLastDate < this.firstDate)
        return;
      if (this.nkbcpi5r41.Type == StopType.Trailing)
        this.kBEcBJMxB0();
      else
        this.YMBcj4pN6K();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetInterval(DateTime minDate, DateTime maxDate)
    {
      this.firstDate = minDate;
      this.lastDate = maxDate;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Distance Distance(int x, double y)
    {
      if (this.chartFirstDate > this.lastDate || this.chartLastDate < this.firstDate)
        return (Distance) null;
      if (this.nkbcpi5r41.Type == StopType.Trailing)
        return this.wCEcoUk0GZ(x, y);
      else
        return this.iZicacow9y(x, y);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Select()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnSelect()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void kBEcBJMxB0()
    {
      Color color = this.nFpcIDd3Ej;
      switch (this.nkbcpi5r41.Status)
      {
        case StopStatus.Active:
          color = this.J5OcWhbyeL;
          break;
        case StopStatus.Executed:
          color = this.jxFcFido6J;
          break;
        case StopStatus.Canceled:
          color = this.nFpcIDd3Ej;
          break;
      }
      Pen pen = new Pen(color, 1f);
      pen.DashStyle = DashStyle.Dash;
      int num1 = 0;
      double num2 = 0.0;
      double worldY1 = 0.0;
      int x1 = 0;
      int x2 = 0;
      int y1 = 0;
      int y2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      int num6 = 0;
      int index1 = this.pad.Series.GetIndex(this.firstDate);
      int index2 = this.pad.Series.GetIndex(this.lastDate);
      for (int index3 = index1; index3 <= index2; ++index3)
      {
        DateTime dateTime = this.pad.Series.GetDateTime(index3);
        double worldY2;
        if (dateTime == this.chartFirstDate)
          worldY2 = this.nkbcpi5r41.Series[0];
        else if (dateTime == this.chartLastDate)
          worldY2 = this.nkbcpi5r41.Series.Last;
        else if (this.nkbcpi5r41.Series.Contains(dateTime))
          worldY2 = this.nkbcpi5r41.Series[dateTime, EIndexOption.Null];
        else
          continue;
        double num7 = (double) dateTime.Ticks;
        if (num1 != 0)
        {
          x1 = this.pad.ClientX(new DateTime((long) num2));
          y1 = this.pad.ClientY(worldY1);
          x2 = this.pad.ClientX(new DateTime((long) num7));
          y2 = this.pad.ClientY(worldY2);
          if (this.pad.IsInRange((double) x1, (double) y1) && this.pad.IsInRange((double) x2, (double) y2) && (x1 != num3 || x2 != num4 || (y1 != num5 || y2 != num6)))
            this.pad.Graphics.DrawLine(pen, x1, y1, x2, y2);
        }
        num3 = x1;
        num5 = y1;
        num4 = x2;
        num6 = y2;
        num2 = num7;
        worldY1 = worldY2;
        ++num1;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void YMBcj4pN6K()
    {
      double worldY = this.nkbcpi5r41.Status != StopStatus.Executed ? Math.Abs(this.nkbcpi5r41.StopPrice) : Math.Abs(this.nkbcpi5r41.FillPrice);
      if (this.nkbcpi5r41.Type == StopType.Time)
        worldY = this.nkbcpi5r41.StopPrice;
      int num1 = this.pad.ClientX(this.chartFirstDate);
      int num2 = this.pad.ClientY(worldY);
      if (num2 > this.pad.Y2)
        return;
      int num3 = (int) Math.Max(2.0, (double) (int) this.pad.IntervalWidth / 1.2);
      string str = FJDHryrxb1WIq5jBAt.mT707pbkgT(2188) + worldY.ToString(this.nkbcpi5r41.Instrument.PriceDisplay) + FJDHryrxb1WIq5jBAt.mT707pbkgT(2208) + ((object) this.nkbcpi5r41.Status).ToString() + FJDHryrxb1WIq5jBAt.mT707pbkgT(2216);
      Font font = new Font(FJDHryrxb1WIq5jBAt.mT707pbkgT(2222), 8f);
      Color color = this.nFpcIDd3Ej;
      switch (this.nkbcpi5r41.Status)
      {
        case StopStatus.Active:
          color = this.J5OcWhbyeL;
          break;
        case StopStatus.Executed:
          color = this.jxFcFido6J;
          break;
        case StopStatus.Canceled:
          color = this.nFpcIDd3Ej;
          break;
      }
      Pen pen = new Pen(color, 1f);
      pen.DashStyle = DashStyle.Dash;
      double val1_1 = (double) this.pad.ClientX(this.firstDate);
      double val1_2 = (double) this.pad.ClientX(this.lastDate);
      double val2 = val1_2;
      if (this.nkbcpi5r41.Status != StopStatus.Active)
      {
        if (this.chartLastDate == DateTime.MaxValue)
          this.chartLastDate = this.pad.Series.GetDateTime(this.pad.Series.GetIndex(this.nkbcpi5r41.CompletionTime, EIndexOption.Prev));
        val2 = (double) this.pad.ClientX(this.chartLastDate);
      }
      float x1 = (float) Math.Max(val1_1, (double) num1);
      float x2 = (float) Math.Min(val1_2, val2);
      if ((double) x1 > (double) x2)
        return;
      this.pad.Graphics.DrawLine(pen, x1, (float) num2, x2, (float) num2);
      if (!this.KN2czG9J28)
        return;
      double num4 = (double) (num1 + 2);
      double num5 = this.nkbcpi5r41.Side != PositionSide.Long ? (double) (num2 + 2) : (double) (num2 - 2 - (int) this.pad.Graphics.MeasureString(str, font).Height);
      this.pad.Graphics.DrawString(str, font, Brushes.Black, (float) num4 + (float) (num3 / 2), (float) num5);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Distance wCEcoUk0GZ([In] int obj0, [In] double obj1)
    {
      Distance distance = new Distance();
      DateTime dateTime = this.pad.GetDateTime(obj0);
      double num;
      if (dateTime == this.chartFirstDate)
        num = this.nkbcpi5r41.Series[0];
      else if (dateTime == this.chartLastDate)
      {
        num = this.nkbcpi5r41.Series.Last;
      }
      else
      {
        if (!this.nkbcpi5r41.Series.Contains(dateTime))
          return (Distance) null;
        num = this.nkbcpi5r41.Series[dateTime];
      }
      distance.X = (double) obj0;
      distance.Y = num;
      distance.DX = 0.0;
      distance.DY = Math.Abs(obj1 - num);
      if (distance.DX == double.MaxValue || distance.DY == double.MaxValue)
        return (Distance) null;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(this.toolTipFormat, (object) ((object) this.nkbcpi5r41.Status).ToString(), (object) FJDHryrxb1WIq5jBAt.mT707pbkgT(2236), (object) dateTime.ToString(), (object) num);
      distance.ToolTipText = ((object) stringBuilder).ToString();
      return distance;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Distance iZicacow9y([In] int obj0, [In] double obj1)
    {
      Distance distance = new Distance();
      distance.X = (double) obj0;
      distance.Y = obj1;
      int num1 = this.pad.ClientX(this.chartFirstDate);
      int num2 = this.pad.X2;
      if (this.nkbcpi5r41.Status != StopStatus.Active)
      {
        if (this.chartLastDate == DateTime.MaxValue)
          this.chartLastDate = this.pad.Series.GetDateTime(this.pad.Series.GetIndex(this.nkbcpi5r41.CompletionTime, EIndexOption.Prev));
        num2 = this.pad.ClientX(this.chartLastDate);
      }
      distance.DX = num1 > obj0 || num2 < obj0 ? double.MaxValue : 0.0;
      double num3 = this.nkbcpi5r41.Status != StopStatus.Executed ? Math.Abs(this.nkbcpi5r41.StopPrice) : Math.Abs(this.nkbcpi5r41.FillPrice);
      if (this.nkbcpi5r41.Type == StopType.Time)
        num3 = this.nkbcpi5r41.StopPrice;
      distance.DY = Math.Abs(obj1 - num3);
      if (distance.DX == double.MaxValue || distance.DY == double.MaxValue)
        return distance;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(this.toolTipFormat, (object) ((object) this.nkbcpi5r41.Status).ToString(), (object) FJDHryrxb1WIq5jBAt.mT707pbkgT(2248), (object) "", (object) num3);
      distance.ToolTipText = ((object) stringBuilder).ToString();
      return distance;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PadRange GetPadRangeY(Pad pad)
    {
      if (this.nkbcpi5r41.Status != StopStatus.Active && this.chartLastDate == DateTime.MaxValue)
      {
        int index = pad.Series.GetIndex(this.nkbcpi5r41.CompletionTime, EIndexOption.Prev);
        this.chartLastDate = pad.Series.GetDateTime(index);
      }
      if (this.chartFirstDate > this.lastDate || this.chartLastDate < this.firstDate)
        return new PadRange(0.0, 0.0);
      if (this.nkbcpi5r41.Status == StopStatus.Canceled)
        return new PadRange(0.0, 0.0);
      double max;
      double min;
      if (this.nkbcpi5r41.Type == StopType.Trailing)
      {
        if (this.nkbcpi5r41.Series.Count == 0)
          return new PadRange(0.0, 0.0);
        DateTime index1 = this.chartFirstDate;
        DateTime index2 = this.chartLastDate;
        if (this.firstDate > index1)
          index1 = this.firstDate;
        if (this.lastDate < index2)
          index2 = this.lastDate;
        double val1 = this.nkbcpi5r41.Series[index1, EIndexOption.Next];
        DateTime firstDateTime = this.nkbcpi5r41.Series.FirstDateTime;
        DateTime lastDateTime = this.nkbcpi5r41.Series.LastDateTime;
        double val2 = !(index2 > this.nkbcpi5r41.Series.LastDateTime) ? this.nkbcpi5r41.Series[index2, EIndexOption.Next] : this.nkbcpi5r41.Series[index2, EIndexOption.Prev];
        max = Math.Max(val1, val2);
        min = Math.Min(val1, val2);
      }
      else
      {
        double num = this.nkbcpi5r41.Status != StopStatus.Executed ? Math.Abs(this.nkbcpi5r41.StopPrice) : Math.Abs(this.nkbcpi5r41.FillPrice);
        if (this.nkbcpi5r41.Type == StopType.Time)
          num = this.nkbcpi5r41.StopPrice;
        max = num;
        min = num;
      }
      if (min >= max)
      {
        double num = min / 1000.0;
        min -= num;
        max += num;
      }
      return new PadRange(min, max);
    }
  }
}
