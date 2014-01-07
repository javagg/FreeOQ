// Type: SmartQuant.Instruments.Transaction
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using FreeQuant.Charting;
using FreeQuant.FIX;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using VFUvY5knK01pUIalDo;

namespace FreeQuant.Instruments
{
  public class Transaction : IComparable, IDrawable, ICloneable
  {
    private int tpgWxTxbUx;
    private string YFUWI9uVAQ;
    private int dWoWLjDAbj;
    private DateTime KnHWb2IyJi;
    private Instrument jwQWRdknYf;
    private Side WmYWatsLPN;
    private double H6NWnmMPUB;
    private double rNSWiO01n4;
    private string PelWhgIvuE;
    private Currency XshWtUZb9l;
    private TransactionCost gfpWwu4u0E;
    private double QhGWTusWV7;
    private double p3yWzxO0RX;
    private string a8SBQvDcvb;
    private bool U4OBWs7Tou;
    private string oGFBB6lesr;
    private Color DKqB6yjVMs;
    private Color LXaBERCEPT;
    private Color iQ0BslhRx9;
    private bool SKSBd03paG;

    [ReadOnly(true)]
    [Description("")]
    [Category("Order")]
    public string ClOrdID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.YFUWI9uVAQ;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.YFUWI9uVAQ = value;
      }
    }

    [Category("Order")]
    [Description("")]
    [ReadOnly(true)]
    public int ReportId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.dWoWLjDAbj;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.dWoWLjDAbj = value;
      }
    }

    [Description("")]
    [ReadOnly(true)]
    [Category("Transaction")]
    public DateTime DateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.KnHWb2IyJi;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.KnHWb2IyJi = value;
      }
    }

    [Description("")]
    [Category("Transaction")]
    public Instrument Instrument
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jwQWRdknYf;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.jwQWRdknYf = value;
      }
    }

    [Description("")]
    [Category("Transaction")]
    [ReadOnly(true)]
    public Side Side
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WmYWatsLPN;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.WmYWatsLPN = value;
      }
    }

    [Category("Transaction")]
    [ReadOnly(true)]
    [Description("")]
    public double Price
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.H6NWnmMPUB;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.H6NWnmMPUB = value;
      }
    }

    [Category("Transaction")]
    [ReadOnly(true)]
    [Description("")]
    public double Qty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.rNSWiO01n4;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.rNSWiO01n4 = Math.Abs(value);
      }
    }

    [Category("Transaction")]
    [Description("")]
    public double Amount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        switch (this.WmYWatsLPN)
        {
          case Side.Buy:
          case Side.BuyMinus:
            return this.Qty;
          case Side.Sell:
          case Side.SellPlus:
          case Side.SellShort:
          case Side.SellShortExempt:
            return -this.Qty;
          default:
            throw new NotSupportedException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(1956) + (object) this.WmYWatsLPN);
        }
      }
    }

    [Category("Transaction")]
    [Description("")]
    public Currency Currency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.XshWtUZb9l;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.XshWtUZb9l = value;
      }
    }

    [Browsable(false)]
    public TransactionCost TransactionCost
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.gfpWwu4u0E;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.gfpWwu4u0E = value;
      }
    }

    [Description("")]
    [Category("Transaction")]
    public double Cost
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.gfpWwu4u0E == null)
          return 0.0;
        else
          return this.gfpWwu4u0E.GetCost(this);
      }
    }

    [Category("Value")]
    [Description("")]
    public virtual double Value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.jwQWRdknYf.Factor != 0.0)
          return this.H6NWnmMPUB * this.rNSWiO01n4 * this.jwQWRdknYf.Factor;
        else
          return this.H6NWnmMPUB * this.rNSWiO01n4;
      }
    }

    [Category("Value")]
    [Description("")]
    public virtual double NetCashFlow
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.jwQWRdknYf.Factor != 0.0)
          return -(this.Amount * this.H6NWnmMPUB * this.jwQWRdknYf.Factor);
        else
          return -(this.Amount * this.H6NWnmMPUB);
      }
    }

    [Category("Value")]
    [Description("")]
    public virtual double CashFlow
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.NetCashFlow - this.Cost;
      }
    }

    [ReadOnly(true)]
    public string Strategy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.a8SBQvDcvb;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.a8SBQvDcvb = value;
      }
    }

    [Description("")]
    [Category("Text")]
    public string Text
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.PelWhgIvuE;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.PelWhgIvuE = value;
      }
    }

    [Category("Drawing Style")]
    [Browsable(false)]
    public Color BuyColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.DKqB6yjVMs;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.DKqB6yjVMs = value;
      }
    }

    [Category("Drawing Style")]
    [Browsable(false)]
    public Color SellColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.LXaBERCEPT;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.LXaBERCEPT = value;
      }
    }

    [Category("Drawing Style")]
    [Browsable(false)]
    public Color SellShortColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.iQ0BslhRx9;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.iQ0BslhRx9 = value;
      }
    }

    [Category("Drawing Style")]
    [Browsable(false)]
    public bool TextEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.SKSBd03paG;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SKSBd03paG = value;
      }
    }

    [ReadOnly(true)]
    [Category("Transaction")]
    [Description("")]
    public double PnL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QhGWTusWV7;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] internal set
      {
        this.QhGWTusWV7 = value;
      }
    }

    [Description("")]
    [ReadOnly(true)]
    [Category("Transaction")]
    public double RealizedPnL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.p3yWzxO0RX;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] internal set
      {
        this.p3yWzxO0RX = value;
      }
    }

    [ReadOnly(true)]
    [Description("Transaction margin")]
    [Category("Margin")]
    public double Margin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jwQWRdknYf.Margin * this.rNSWiO01n4;
      }
    }

    [Description("Transaction debt")]
    [ReadOnly(true)]
    [Category("Margin")]
    public double Debt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        double num = this.jwQWRdknYf.Margin * this.rNSWiO01n4;
        if (num == 0.0)
          return 0.0;
        else
          return this.Value - num;
      }
    }

    [Description("Enable or disable tooltip appearance for this marker.")]
    [Category("ToolTip")]
    public bool ToolTipEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.U4OBWs7Tou;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.U4OBWs7Tou = value;
      }
    }

    [Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
    [Category("ToolTip")]
    public string ToolTipFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.oGFBB6lesr;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.oGFBB6lesr = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Transaction()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.tpgWxTxbUx = -1;
      this.YFUWI9uVAQ = "";
      this.dWoWLjDAbj = -1;
      this.PelWhgIvuE = "";
      this.XshWtUZb9l = CurrencyManager.DefaultCurrency;
      this.gfpWwu4u0E = new TransactionCost();
      this.U4OBWs7Tou = true;
      this.oGFBB6lesr = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2028);
      this.DKqB6yjVMs = Color.Blue;
      this.LXaBERCEPT = Color.Red;
      this.iQ0BslhRx9 = Color.Yellow;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Transaction(DateTime dateTime, Side side, double qty, Instrument instrument, double price)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.tpgWxTxbUx = -1;
      this.YFUWI9uVAQ = "";
      this.dWoWLjDAbj = -1;
      this.PelWhgIvuE = "";
      this.XshWtUZb9l = CurrencyManager.DefaultCurrency;
      this.gfpWwu4u0E = new TransactionCost();
      this.U4OBWs7Tou = true;
      this.oGFBB6lesr = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2074);
      this.DKqB6yjVMs = Color.Blue;
      this.LXaBERCEPT = Color.Red;
      this.iQ0BslhRx9 = Color.Yellow;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.KnHWb2IyJi = dateTime;
      this.jwQWRdknYf = instrument;
      this.WmYWatsLPN = side;
      this.H6NWnmMPUB = price;
      this.rNSWiO01n4 = Math.Abs(qty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Transaction(DateTime dateTime, Side side, double qty, Instrument instrument, double price, double commission, CommType commType)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      this.\u002Ector(dateTime, side, qty, instrument, price);
      this.gfpWwu4u0E.Commission = commission;
      this.gfpWwu4u0E.CommType = commType;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal int AumWZ22XK3()
    {
      return this.tpgWxTxbUx;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void nx8WA03O1L(int value)
    {
      this.tpgWxTxbUx = value;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Draw(string option)
    {
      if (option.IndexOf(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2120)) != -1)
        this.SKSBd03paG = true;
      if (Chart.Pad == null)
      {
        Canvas canvas = new Canvas(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2126), gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2142));
      }
      Chart.Pad.Add((IDrawable) this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Draw()
    {
      this.Draw(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2158));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return (string) (object) this.KnHWb2IyJi + (object) gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2164) + ((object) this.WmYWatsLPN).ToString() + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2170) + (string) (object) this.rNSWiO01n4 + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2176) + this.jwQWRdknYf.Symbol + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2182) + (string) (object) this.H6NWnmMPUB;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int CompareTo(object obj)
    {
      Transaction transaction = obj as Transaction;
      if (this.KnHWb2IyJi > transaction.DateTime)
        return 1;
      return this.KnHWb2IyJi < transaction.DateTime ? -1 : 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
    {
      if ((double) this.DateTime.Ticks > MaxX || (double) this.DateTime.Ticks < MinX)
        return;
      int x = Pad.ClientX((double) this.DateTime.Ticks);
      int y = Pad.ClientY(this.Price);
      float num1 = 12f;
      string str = ((object) this.Side).ToString() + (object) gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2190) + (string) (object) this.Qty + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2196) + this.Instrument.Symbol + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2202) + this.Price.ToString(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2212));
      Font font = new Font(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2220), 8f);
      switch (this.Side)
      {
        case Side.Buy:
          Color color1 = this.DKqB6yjVMs;
          PointF[] points1 = new PointF[3]
          {
            (PointF) new Point(x, y),
            (PointF) new Point((int) ((double) x - (double) num1 / 2.0), (int) ((double) y + (double) num1 / 2.0)),
            (PointF) new Point((int) ((double) x + (double) num1 / 2.0), (int) ((double) y + (double) num1 / 2.0))
          };
          Pad.Graphics.DrawPolygon(new Pen(Color.Black), points1);
          Pad.Graphics.DrawRectangle(new Pen(Color.Black), (float) x - num1 / 4f, (float) y + num1 / 2f, num1 / 2f, num1 / 2f);
          Pad.Graphics.FillPolygon((Brush) new SolidBrush(color1), points1);
          Pad.Graphics.FillRectangle((Brush) new SolidBrush(color1), (float) x - num1 / 4f, (float) ((double) y + (double) num1 / 2.0 - 1.0), num1 / 2f, (float) ((double) num1 / 2.0 + 1.0));
          break;
        case Side.Sell:
          Color color2 = this.LXaBERCEPT;
          Point[] points2 = new Point[3]
          {
            new Point(x, y),
            new Point((int) ((double) x - (double) num1 / 2.0), (int) ((double) y - (double) num1 / 2.0)),
            new Point((int) ((double) x + (double) num1 / 2.0), (int) ((double) y - (double) num1 / 2.0))
          };
          Pad.Graphics.DrawPolygon(new Pen(Color.Black), points2);
          Pad.Graphics.DrawRectangle(new Pen(Color.Black), (float) x - num1 / 4f, (float) y - num1, num1 / 2f, (float) ((double) num1 / 2.0 + 1.0));
          Pad.Graphics.FillPolygon((Brush) new SolidBrush(color2), points2);
          Pad.Graphics.FillRectangle((Brush) new SolidBrush(color2), (float) x - num1 / 4f, (float) y - num1, num1 / 2f, (float) ((double) num1 / 2.0 + 1.0));
          break;
        case Side.SellShort:
          Color color3 = this.iQ0BslhRx9;
          Point[] points3 = new Point[3]
          {
            new Point(x, y),
            new Point((int) ((double) x - (double) num1 / 2.0), (int) ((double) y - (double) num1 / 2.0)),
            new Point((int) ((double) x + (double) num1 / 2.0), (int) ((double) y - (double) num1 / 2.0))
          };
          Pad.Graphics.DrawPolygon(new Pen(Color.Black), points3);
          Pad.Graphics.DrawRectangle(new Pen(Color.Black), (float) x - num1 / 4f, (float) y - num1, num1 / 2f, (float) ((double) num1 / 2.0 + 1.0));
          Pad.Graphics.FillPolygon((Brush) new SolidBrush(color3), points3);
          Pad.Graphics.FillRectangle((Brush) new SolidBrush(color3), (float) x - num1 / 4f, (float) y - num1, num1 / 2f, (float) ((double) num1 / 2.0 + 1.0));
          break;
      }
      if (!this.SKSBd03paG)
        return;
      int num2 = (int) Pad.Graphics.MeasureString(str, font).Width;
      int num3 = (int) Pad.Graphics.MeasureString(str, font).Height;
      switch (this.Side)
      {
        case Side.Buy:
          Pad.Graphics.DrawString(str, font, (Brush) new SolidBrush(Color.Black), (float) (x - num2 / 2), (float) ((double) y + (double) num1 + 2.0));
          break;
        case Side.Sell:
          Pad.Graphics.DrawString(str, font, (Brush) new SolidBrush(Color.Black), (float) (x - num2 / 2), (float) ((double) y - (double) num1 - 2.0) - (float) num3);
          break;
        case Side.SellShort:
          Pad.Graphics.DrawString(str, font, (Brush) new SolidBrush(Color.Black), (float) (x - num2 / 2), (float) ((double) y + (double) num1 + 2.0));
          break;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TDistance Distance(double X, double Y)
    {
      TDistance tdistance = new TDistance();
      tdistance.X = (double) this.DateTime.Ticks;
      tdistance.Y = this.Price;
      tdistance.dX = Math.Abs(X - tdistance.X);
      tdistance.dY = Math.Abs(Y - tdistance.Y);
      StringBuilder stringBuilder = new StringBuilder();
      if (this.DateTime.Second != 0 || this.DateTime.Minute != 0 || this.DateTime.Hour != 0)
        stringBuilder.AppendFormat(this.oGFBB6lesr, (object) ((object) this.Side).ToString(), (object) this.Instrument.Symbol, (object) this.Qty, (object) this.Price, (object) this.DateTime);
      else
        stringBuilder.AppendFormat(this.oGFBB6lesr, (object) ((object) this.Side).ToString(), (object) this.Instrument.Symbol, (object) this.Qty, (object) this.Price, (object) this.DateTime.ToShortDateString());
      tdistance.ToolTipText = ((object) stringBuilder).ToString();
      return tdistance;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object Clone()
    {
      return (object) new Transaction()
      {
        YFUWI9uVAQ = this.YFUWI9uVAQ,
        XshWtUZb9l = this.XshWtUZb9l,
        KnHWb2IyJi = this.KnHWb2IyJi,
        tpgWxTxbUx = this.tpgWxTxbUx,
        jwQWRdknYf = this.jwQWRdknYf,
        QhGWTusWV7 = this.QhGWTusWV7,
        H6NWnmMPUB = this.H6NWnmMPUB,
        rNSWiO01n4 = this.rNSWiO01n4,
        p3yWzxO0RX = this.p3yWzxO0RX,
        dWoWLjDAbj = this.dWoWLjDAbj,
        WmYWatsLPN = this.WmYWatsLPN,
        a8SBQvDcvb = this.a8SBQvDcvb,
        PelWhgIvuE = this.PelWhgIvuE,
        gfpWwu4u0E = this.gfpWwu4u0E
      };
    }
  }
}
