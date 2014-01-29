using FreeQuant.Series;
using FreeQuant.Trading;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace FreeQuant.FinChart
{
  public class SignalView : IChartDrawable, IDateDrawable
  {
		private Signal signal; 
    private Color JVpy8D2xUR;
    private Color zMOyBnpkt3;
    private Color tHoyjarrU1;
    private Color XNayo9fgOU;
    protected Pad pad;
    protected DateTime firstDate;
    protected DateTime lastDate;
    protected bool toolTipEnabled;
    protected string toolTipFormat;
    protected bool selected;

    [Category("Drawing Style")]
    public Color BuyColor
    {
      get
      {
        return this.JVpy8D2xUR;
      }
      set
      {
        this.JVpy8D2xUR = value;
      }
    }

    [Category("Drawing Style")]
    public Color BuyCoverColor
    {
      get
      {
        return this.zMOyBnpkt3;
      }
      set
      {
        this.zMOyBnpkt3 = value;
      }
    }

    [Category("Drawing Style")]
    public Color SellColor
    {
      get
      {
        return this.tHoyjarrU1;
      }
      set
      {
        this.tHoyjarrU1 = value;
      }
    }

    [Category("Drawing Style")]
    public Color SellShortColor
    {
      get
      {
        return this.XNayo9fgOU;
      }
      set
      {
        this.XNayo9fgOU = value;
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

    [Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
    [Category("ToolTip")]
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
        return this.signal.DateTime;
      }
    }

    
		public SignalView(Signal signal, Pad pad) : base()
    {
      this.JVpy8D2xUR = Color.SkyBlue;
      this.zMOyBnpkt3 = Color.SkyBlue;
      this.tHoyjarrU1 = Color.Pink;
      this.XNayo9fgOU = Color.Red;
      this.signal = signal;
      this.pad = pad;
			this.ToolTipEnabled = true;
			this.ToolTipFormat = "dfdfs";
    }

    
    public void Paint()
    {
      if (this.signal.DateTime < this.firstDate || this.signal.DateTime > this.lastDate)
        return;
      int num1 = this.pad.ClientX(this.pad.MainSeries.GetDateTime(this.pad.MainSeries.GetIndex(this.signal.DateTime, EIndexOption.Next)));
      int num2 = this.pad.ClientY(this.signal.Price);
			Font font = new Font("Arial", 8);
      Color color = this.JVpy8D2xUR;
      switch (this.signal.Side)
      {
        case SignalSide.Buy:
          color = this.JVpy8D2xUR;
          break;
        case SignalSide.BuyCover:
          color = this.zMOyBnpkt3;
          break;
        case SignalSide.Sell:
          color = this.tHoyjarrU1;
          break;
        case SignalSide.SellShort:
          color = this.XNayo9fgOU;
          break;
      }
      Pen pen = new Pen(color, 2f);
      int num3 = 8;
      this.pad.Graphics.DrawEllipse(pen, num1 - num3 / 2, num2 - num3 / 2, num3, num3);
    }

    
    public void SetInterval(DateTime minDate, DateTime maxDate)
    {
      this.firstDate = minDate;
      this.lastDate = maxDate;
    }

    
    public Distance Distance(int x, double y)
    {
      if (this.signal.DateTime < this.firstDate || this.signal.DateTime > this.lastDate)
        return (Distance) null;
      Distance distance = new Distance();
      int index = this.pad.MainSeries.GetIndex(this.signal.DateTime, EIndexOption.Next);
      distance.X = (double) this.pad.ClientX(this.pad.MainSeries.GetDateTime(index));
      distance.Y = this.signal.Price;
      distance.DX = Math.Abs((double) x - distance.X);
      distance.DY = Math.Abs(y - distance.Y);
      StringBuilder stringBuilder = new StringBuilder();
      if (this.signal.DateTime.Second != 0 || this.signal.DateTime.Minute != 0 || this.signal.DateTime.Hour != 0)
				stringBuilder.AppendFormat(this.ToolTipFormat, "",  this.signal.Side.ToString(), this.signal.Instrument.Symbol, (object) this.signal.Price, (object) this.signal.DateTime, (object) ((object) this.signal.Status).ToString());
      else
				stringBuilder.AppendFormat(this.ToolTipFormat, "", this.signal.Side.ToString(), this.signal.Instrument.Symbol, (object) this.signal.Price, (object) this.signal.DateTime.ToShortDateString(), (object) ((object) this.signal.Status).ToString());
      distance.ToolTipText = ((object) stringBuilder).ToString();
      return distance;
    }

    
    public void Select()
    {
    }

    
    public void UnSelect()
    {
    }
  }
}
