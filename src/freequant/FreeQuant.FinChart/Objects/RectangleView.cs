// Type: SmartQuant.FinChart.Objects.RectangleView
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
  public class RectangleView : IChartDrawable, IZoomable
  {
    private DrawingRectangle nQNSrDsxti;
    protected DateTime firstDate;
    protected DateTime lastDate;
    protected bool toolTipEnabled;
    protected string toolTipFormat;
    protected bool selected;
    protected DateTime chartFirstDate;
    protected DateTime chartLastDate;

    public Pad Pad { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

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
    public RectangleView(DrawingRectangle rect, Pad pad)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.toolTipEnabled = true;
      this.toolTipFormat = "";
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.nQNSrDsxti = rect;
      this.Pad = pad;
      this.toolTipEnabled = true;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(3336);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Paint()
    {
      this.dCxSSqbBBj();
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
      return this.hoRS0fZTTW(x, y);
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
    private void dCxSSqbBBj()
    {
      int val1_1 = this.Pad.ClientX(this.nQNSrDsxti.X1);
      int val2_1 = this.Pad.ClientX(this.nQNSrDsxti.X2);
      int val1_2 = this.Pad.ClientY(this.nQNSrDsxti.Y1);
      int val2_2 = this.Pad.ClientY(this.nQNSrDsxti.Y2);
      this.Pad.Graphics.DrawRectangle(new Pen(this.nQNSrDsxti.Color, (float) this.nQNSrDsxti.Width), Math.Min(val1_1, val2_1), Math.Min(val1_2, val2_2), Math.Abs(val2_1 - val1_1), Math.Abs(val2_2 - val1_2));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Distance hoRS0fZTTW([In] int obj0, [In] double obj1)
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
