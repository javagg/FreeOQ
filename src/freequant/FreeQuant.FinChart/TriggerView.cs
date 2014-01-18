using FreeQuant.Trading;
using System;
using System.ComponentModel;
using System.Drawing;

namespace FreeQuant.FinChart
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
       get
      {
        return this.qnUJJpYMIR;
      }
       set
      {
        this.qnUJJpYMIR = value;
      }
    }

    [Category("Drawing Style")]
    public Color ActiveColor
    {
       get
      {
        return this.CIgJcNZb02;
      }
       set
      {
        this.CIgJcNZb02 = value;
      }
    }

    [Category("Drawing Style")]
    public Color CanceledColor
    {
       get
      {
        return this.l5sJyliEEW;
      }
       set
      {
        this.l5sJyliEEW = value;
      }
    }

    [Category("Drawing Style")]
    public bool TextEnabled
    {
       get
      {
        return this.FKIJS1tv9T;
      }
       set
      {
        this.FKIJS1tv9T = value;
      }
    }

    [Description("Enable or disable tooltip appearance for this marker.")]
    [Category("ToolTip")]
    public bool ToolTipEnabled
    {
       get
      {
        return this.toolTipEnabled;
      }
       set
      {
        this.toolTipEnabled = value;
      }
    }

    [Category("ToolTip")]
    [Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
    public string ToolTipFormat
    {
       get
      {
        return this.toolTipFormat;
      }
       set
      {
        this.toolTipFormat = value;
      }
    }

    public DateTime DateTime
    {
       get
      {
        return DateTime.Now;
      }
    }

    
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

    
    public void Paint()
    {
    }

    
    public void SetInterval(DateTime minDate, DateTime maxDate)
    {
      this.firstDate = minDate;
      this.lastDate = maxDate;
    }

    
    public Distance Distance(int x, double y)
    {
      return (Distance) null;
    }

    
    public void Select()
    {
    }

    
    public void UnSelect()
    {
    }
  }
}
