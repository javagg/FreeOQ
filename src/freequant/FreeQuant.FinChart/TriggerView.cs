using FreeQuant.Trading;
using System;
using System.ComponentModel;
using System.Drawing;

namespace FreeQuant.FinChart
{
  public class TriggerView : IChartDrawable, IDateDrawable
  {
		private Trigger trigger; 
    protected Pad pad;
    protected DateTime firstDate;
    protected DateTime lastDate;
    protected bool toolTipEnabled;
    protected string toolTipFormat;
    protected bool selected;

    [Category("Drawing Style")]
		public Color ExecutedColor { get; set; }

    [Category("Drawing Style")]
		public Color ActiveColor { get; set; }
	
    [Category("Drawing Style")]
		public Color CanceledColor { get; set; }
   
    [Category("Drawing Style")]
		public bool TextEnabled { get; set; }
 
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

    
		public TriggerView(Trigger trigger, Pad pad) : base()
    {
			this.ActiveColor = Color.Brown;
			this.ExecutedColor = Color.Green;
			this.CanceledColor = Color.DarkGray;
			this.TextEnabled = true;
      this.toolTipEnabled = true;
      this.toolTipFormat = "";
      this.trigger = trigger;
      this.pad = pad;
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
      return null;
    }

    
    public void Select()
    {
    }

    
    public void UnSelect()
    {
    }
  }
}
