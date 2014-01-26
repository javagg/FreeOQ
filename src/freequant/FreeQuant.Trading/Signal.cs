using FreeQuant.Charting;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Simulation;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace FreeQuant.Trading
{
  public class Signal : IDrawable
  {
    private Strategy uUCAoxT2nM;
    private DateTime BHmAafFWq5;
    private ComponentType PZ8AtJFoSI;
    private ComponentType k6uAd2ekch;
    private string yMlAw2S8C2;
    private SignalType Ug8AmpN6Lv;
    private SignalSide lFNAfw2jk5;
    private double RxjAeNd9om;
    private double S1QAg2wH2p;
    private double iSpANxwsjn;
    private double Gm2AzcSQf0;
    private TimeInForce mjpjkJ4sSV;
    private bool gDjjpRmweK;
    private double xPdj6rLiI5;
    private Instrument cWTjA2ythk;
    private string Y5wjj7NwTb;
    private SignalStatus nLojWnvefB;
    private Color w8ejRbHlLp;
    private Color xnfji3BmDC;
    private Color Dguj7ca8kH;
    private Color mrTjHmKfbk;
    private bool NwWjUvU0CL;
    private string eXjjOqHWe9;
    internal FillOnBarMode R2djQy947W;
    internal bool Fuwj5CvMiW;
    internal bool QvSj2cjRxv;

    public Strategy Strategy
    {
       get
      {
        return this.uUCAoxT2nM;
      }
       set
      {
        this.uUCAoxT2nM = value;
      }
    }

    public DateTime DateTime
    {
       get
      {
        return this.BHmAafFWq5;
      }
    }

    public ComponentType Sender
    {
       get
      {
        return this.PZ8AtJFoSI;
      }
       set
      {
        this.PZ8AtJFoSI = value;
      }
    }

    public ComponentType Rejecter
    {
       get
      {
        return this.k6uAd2ekch;
      }
       set
      {
        this.k6uAd2ekch = value;
      }
    }

    public string RejectReason
    {
       get
      {
        return this.yMlAw2S8C2;
      }
       set
      {
        this.yMlAw2S8C2 = value;
      }
    }

    public SignalType Type
    {
       get
      {
        return this.Ug8AmpN6Lv;
      }
       set
      {
        this.Ug8AmpN6Lv = value;
      }
    }

    public SignalSide Side
    {
       get
      {
        return this.lFNAfw2jk5;
      }
       set
      {
        this.lFNAfw2jk5 = value;
      }
    }

    public double Price
    {
       get
      {
        return this.RxjAeNd9om;
      }
       set
      {
        this.RxjAeNd9om = value;
      }
    }

    public double StopPrice
    {
       get
      {
        return this.S1QAg2wH2p;
      }
       set
      {
        this.S1QAg2wH2p = value;
      }
    }

    public double LimitPrice
    {
       get
      {
        return this.iSpANxwsjn;
      }
       set
      {
        this.iSpANxwsjn = value;
      }
    }

    public double Qty
    {
       get
      {
        return this.Gm2AzcSQf0;
      }
       set
      {
        this.Gm2AzcSQf0 = value;
      }
    }

    public TimeInForce TimeInForce
    {
       get
      {
        return this.mjpjkJ4sSV;
      }
       set
      {
        this.mjpjkJ4sSV = value;
      }
    }

    public double StrategyPrice
    {
       get
      {
        return this.xPdj6rLiI5;
      }
       set
      {
        this.xPdj6rLiI5 = value;
      }
    }

    public bool StrategyFill
    {
       get
      {
        return this.gDjjpRmweK;
      }
       set
      {
        this.gDjjpRmweK = value;
      }
    }

    public Instrument Instrument
    {
       get
      {
        return this.cWTjA2ythk;
      }
       set
      {
        this.cWTjA2ythk = value;
      }
    }

    public string Text
    {
       get
      {
        return this.Y5wjj7NwTb;
      }
       set
      {
        this.Y5wjj7NwTb = value;
      }
    }

    public SignalStatus Status
    {
       get
      {
        return this.nLojWnvefB;
      }
       set
      {
        this.nLojWnvefB = value;
      }
    }

    [Category("Drawing Style")]
    public Color BuyColor
    {
       get
      {
        return this.w8ejRbHlLp;
      }
       set
      {
        this.w8ejRbHlLp = value;
      }
    }

    [Category("Drawing Style")]
    public Color BuyCoverColor
    {
       get
      {
        return this.xnfji3BmDC;
      }
       set
      {
        this.xnfji3BmDC = value;
      }
    }

    [Category("Drawing Style")]
    public Color SellColor
    {
       get
      {
        return this.Dguj7ca8kH;
      }
       set
      {
        this.Dguj7ca8kH = value;
      }
    }

    [Category("Drawing Style")]
    public Color SellShortColor
    {
       get
      {
        return this.mrTjHmKfbk;
      }
       set
      {
        this.mrTjHmKfbk = value;
      }
    }

    [Description("Enable or disable tooltip appearance for this marker.")]
    [Category("ToolTip")]
    public bool ToolTipEnabled
    {
       get
      {
        return this.NwWjUvU0CL;
      }
       set
      {
        this.NwWjUvU0CL = value;
      }
    }

    [Category("ToolTip")]
    [Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
    public string ToolTipFormat
    {
       get
      {
        return this.eXjjOqHWe9;
      }
       set
      {
        this.eXjjOqHWe9 = value;
      }
    }

    
    public Signal(DateTime datetime, ComponentType sender, SignalType type, SignalSide side, double qty, double strategyPrice, Instrument instrument, string text)
			:base(){
      this.w8ejRbHlLp = Color.Blue;
      this.xnfji3BmDC = Color.SkyBlue;
      this.Dguj7ca8kH = Color.Pink;
      this.mrTjHmKfbk = Color.Red;
      this.NwWjUvU0CL = true;
			this.eXjjOqHWe9 ="dfdfs";

      this.BHmAafFWq5 = datetime;
      this.PZ8AtJFoSI = sender;
      this.Ug8AmpN6Lv = type;
      this.lFNAfw2jk5 = side;
      this.Gm2AzcSQf0 = qty;
      this.xPdj6rLiI5 = strategyPrice;
      this.cWTjA2ythk = instrument;
      this.RxjAeNd9om = this.cWTjA2ythk.Price();
      this.mjpjkJ4sSV = TimeInForce.GTC;
      this.Y5wjj7NwTb = text;
      this.uUCAoxT2nM = (Strategy) null;
      this.k6uAd2ekch = ComponentType.Unknown;
      this.S1QAg2wH2p = 0.0;
      this.iSpANxwsjn = 0.0;
      this.nLojWnvefB = SignalStatus.New;
    }

    
    public Signal(DateTime datetime, ComponentType sender, SignalType type, SignalSide side, Instrument instrument, string text)
			: this(datetime, sender, type, side, 0.0, 0.0, instrument, text) {

    }

    
    public void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
    {
      int num1 = Pad.ClientX((double) this.DateTime.Ticks);
      int num2 = Pad.ClientY(this.RxjAeNd9om);
//      USaG3GpjZagj1iVdv4u.Y4misFk9D9(11044) + this.RxjAeNd9om.ToString(USaG3GpjZagj1iVdv4u.Y4misFk9D9(11064)) + USaG3GpjZagj1iVdv4u.Y4misFk9D9(11072) + ((object) this.Status).ToString() + USaG3GpjZagj1iVdv4u.Y4misFk9D9(11080);
			Font font = new Font("Arial", 8f);
      Color color = this.w8ejRbHlLp;
      switch (this.Side)
      {
        case SignalSide.Buy:
          color = this.w8ejRbHlLp;
          break;
        case SignalSide.BuyCover:
          color = this.xnfji3BmDC;
          break;
        case SignalSide.Sell:
          color = this.Dguj7ca8kH;
          break;
        case SignalSide.SellShort:
          color = this.mrTjHmKfbk;
          break;
      }
      Pen pen = new Pen(color, 2f);
      int num3 = 8;
      double num4 = (double) Pad.ClientX(MinX);
      double num5 = (double) Pad.ClientX(MaxX);
      if ((double) (num1 - num3 / 2) > num5 || (double) (num1 + num3 / 2) < num4)
        return;
      Pad.Graphics.DrawEllipse(pen, num1 - num3 / 2, num2 - num3 / 2, num3, num3);
    }

    
    public TDistance Distance(double X, double Y)
    {
      TDistance tdistance = new TDistance();
      tdistance.X = (double) this.DateTime.Ticks;
      tdistance.Y = this.RxjAeNd9om;
      tdistance.dX = Math.Abs(X - tdistance.X);
      tdistance.dY = Math.Abs(Y - tdistance.Y);
      StringBuilder stringBuilder = new StringBuilder();
      if (this.DateTime.Second != 0 || this.DateTime.Minute != 0 || this.DateTime.Hour != 0)
				stringBuilder.AppendFormat(this.eXjjOqHWe9, (object) "ffs", (object) ((object) this.Side).ToString(), (object) this.Instrument.Symbol, (object) this.Price, (object) this.DateTime, (object) ((object) this.Status).ToString());
      else
				stringBuilder.AppendFormat(this.eXjjOqHWe9, (object)"fddsf", (object) ((object) this.Side).ToString(), (object) this.Instrument.Symbol, (object) this.Price, (object) this.DateTime.ToShortDateString(), (object) ((object) this.Status).ToString());
      tdistance.ToolTipText = ((object) stringBuilder).ToString();
      return tdistance;
    }

    
    public void Draw()
    {
      Chart.Pad.Add((IDrawable) this);
    }
  }
}
