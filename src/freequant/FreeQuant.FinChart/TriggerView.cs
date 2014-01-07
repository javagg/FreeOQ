// Type: SmartQuant.FinChart.TriggerView
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using cY9o6QKnveiK0L5ffy;
using SmartQuant.Trading;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using yHueqhRH1sS5jNKgDq;

namespace SmartQuant.FinChart
{
  public class TriggerView : IChartDrawable, IDateDrawable
  {
    private Trigger dyOJwmc3nS;
    private Color CIgJcNZb02;
    private Color qnUJJpYMIR;
    private Color l5sJyliEEW;
    private bool FKIJS1tv9T;
    protected Pad pad;
    protected DateTime firstDate;
    protected DateTime lastDate;
    protected bool toolTipEnabled;
    protected string toolTipFormat;
    protected bool selected;

    [Category("Drawing Style")]
    public Color ExecutedColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.qnUJJpYMIR;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.qnUJJpYMIR = value;
      }
    }

    [Category("Drawing Style")]
    public Color ActiveColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.CIgJcNZb02;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.CIgJcNZb02 = value;
      }
    }

    [Category("Drawing Style")]
    public Color CanceledColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.l5sJyliEEW;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.l5sJyliEEW = value;
      }
    }

    [Category("Drawing Style")]
    public bool TextEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.FKIJS1tv9T;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.FKIJS1tv9T = value;
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

    public DateTime DateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return DateTime.Now;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TriggerView(Trigger trigger, Pad pad)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.CIgJcNZb02 = Color.Brown;
      this.qnUJJpYMIR = Color.Green;
      this.l5sJyliEEW = Color.DarkGray;
      this.FKIJS1tv9T = true;
      this.toolTipEnabled = true;
      this.toolTipFormat = "";
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.dyOJwmc3nS = trigger;
      this.pad = pad;
      this.toolTipEnabled = true;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(2260);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Paint()
    {
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
      return (Distance) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Select()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnSelect()
    {
    }
  }
}
