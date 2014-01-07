// Type: SmartQuant.FinChart.Objects.EllipseView
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using cY9o6QKnveiK0L5ffy;
using SmartQuant.FinChart;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using yHueqhRH1sS5jNKgDq;

namespace SmartQuant.FinChart.Objects
{
  public class EllipseView : IChartDrawable, IZoomable
  {
    private DrawingEllipse yVLScw9Zgj;
    protected DateTime firstDate;
    protected DateTime lastDate;
    protected bool toolTipEnabled;
    protected string toolTipFormat;
    protected bool selected;
    protected DateTime chartFirstDate;
    protected DateTime chartLastDate;

    public Pad Pad { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("ToolTip")]
    [Description("Enable or disable tooltip appearance for this marker.")]
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

    [Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
    [Category("ToolTip")]
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
    public EllipseView(DrawingEllipse rect, Pad pad)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.toolTipEnabled = true;
      this.toolTipFormat = "";
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.yVLScw9Zgj = rect;
      this.Pad = pad;
      this.toolTipEnabled = true;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(3292);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Paint()
    {
      this.nxXStT7oM2();
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
      return this.GiuSwaHmrU(x, y);
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
    private void nxXStT7oM2()
    {
      int val1_1 = this.Pad.ClientX(this.yVLScw9Zgj.X1);
      int val2_1 = this.Pad.ClientX(this.yVLScw9Zgj.X2);
      int val1_2 = this.Pad.ClientY(this.yVLScw9Zgj.Y1);
      int val2_2 = this.Pad.ClientY(this.yVLScw9Zgj.Y2);
      this.Pad.Graphics.DrawEllipse(new Pen(this.yVLScw9Zgj.Color, (float) this.yVLScw9Zgj.Width), Math.Min(val1_1, val2_1), Math.Min(val1_2, val2_2), Math.Abs(val2_1 - val1_1), Math.Abs(val2_2 - val1_2));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Distance GiuSwaHmrU([In] int obj0, [In] double obj1)
    {
      return (Distance) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PadRange GetPadRangeY(Pad pad)
    {
      return new PadRange(0.0, 0.0);
    }
  }
}
