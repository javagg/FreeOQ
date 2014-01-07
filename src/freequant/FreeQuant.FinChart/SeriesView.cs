// Type: SmartQuant.FinChart.SeriesView
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using SmartQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using yHueqhRH1sS5jNKgDq;

namespace SmartQuant.FinChart
{
  public abstract class SeriesView : IChartDrawable, IAxesMarked, IZoomable
  {
    protected Pad pad;
    protected DateTime firstDate;
    protected DateTime lastDate;
    protected bool isMarkEnable;
    protected bool toolTipEnabled;
    protected string toolTipFormat;
    protected bool selected;
    protected bool displayNameEnabled;

    public virtual string DisplayName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.MainSeries.Name;
      }
    }

    public virtual bool DisplayNameEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.displayNameEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.displayNameEnabled = value;
      }
    }

    public bool IsMarkEnable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.isMarkEnable;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.isMarkEnable = value;
      }
    }

    public virtual int LabelDigitsCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.pad.Chart.LabelDigitsCount;
      }
    }

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

    public abstract Color Color { get; set; }

    [Browsable(false)]
    public abstract double LastValue { get; }

    [Browsable(false)]
    public abstract TimeSeries MainSeries { get; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SeriesView(Pad pad)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.isMarkEnable = true;
      this.toolTipEnabled = true;
      this.toolTipFormat = "";
      this.displayNameEnabled = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.pad = pad;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetInterval(DateTime minDate, DateTime maxDate)
    {
      this.firstDate = minDate;
      this.lastDate = maxDate;
    }

    public abstract PadRange GetPadRangeY(Pad Pad);

    public abstract void Paint();

    public abstract Distance Distance(int x, double y);

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Select()
    {
      this.selected = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnSelect()
    {
      this.selected = false;
    }
  }
}
