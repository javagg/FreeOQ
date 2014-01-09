using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
  [Serializable]
  public class TText : IDrawable
  {
    protected double fX;
    protected double fY;
    protected double fZ;
    protected string fText;
    protected ETextPosition fPosition;
    protected Font fFont;
    protected Color fColor;
    private bool Lqfh3BySh;
    private string UL8VcPCS3;

    [Description("")]
    [Category("ToolTip")]
    public bool ToolTipEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Lqfh3BySh;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Lqfh3BySh = value;
      }
    }

    [Description("")]
    [Category("ToolTip")]
    public string ToolTipFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.UL8VcPCS3;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.UL8VcPCS3 = value;
      }
    }

    [Category("Position")]
    [Description("")]
    public double X
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fX;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fX = value;
      }
    }

    [Description("")]
    [Category("Position")]
    public double Y
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fY = value;
      }
    }

    [Browsable(false)]
    public double Z
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fZ;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fZ = value;
      }
    }

    [Category("Text")]
    [Description("")]
    public string Text
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fText;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fText = value;
      }
    }

    [Category("Text")]
    [Description("")]
    public ETextPosition Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fPosition;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fPosition = value;
      }
    }

    [Category("Text")]
    [Description("")]
    public Font Font
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fFont;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fFont = value;
      }
    }

    [Description("")]
    [Category("Text")]
    public Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fColor = value;
      }
    }

    public TText(string Text, double X, double Y):base()
    {
      this.fX = X;
      this.fY = Y;
      this.fZ = 0.0;
      this.fText = Text;
      this.aBfTaltcp();
    }


    public TText(string Text, double X, double Y, Color Color):base()
    {

      this.fX = X;
      this.fY = Y;
      this.fZ = 0.0;
      this.fText = Text;
      this.aBfTaltcp();
      this.fColor = Color;
    }

    public TText(string Text, DateTime X, double Y):base()
    {
      this.fX = (double) X.Ticks;
      this.fY = Y;
      this.fZ = 0.0;
      this.fText = Text;
      this.aBfTaltcp();
    }

    public TText(string Text, DateTime X, double Y, Color Color):base()
    {
      this.fX = (double) X.Ticks;
      this.fY = Y;
      this.fZ = 0.0;
      this.fText = Text;
      this.aBfTaltcp();
      this.fColor = Color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void aBfTaltcp()
    {
      this.fPosition = ETextPosition.RightBottom;
      this.fFont = new Font(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(106), 8f);
      this.fColor = Color.Black;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Draw()
    {
      if (Chart.Pad == null)
      {
        Canvas canvas = new Canvas(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(120), RA7k7APgXK5aSsnmA9.qBCYFXVOKp(136));
      }
      Chart.Pad.Add((IDrawable) this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
    {
      if (this.fText == null)
        return;
      int num1 = (int) Pad.Graphics.MeasureString(this.fText, this.fFont).Width;
      double num2 = (double) Pad.Graphics.MeasureString(this.fText, this.fFont).Height;
      switch (this.fPosition)
      {
        case ETextPosition.RightBottom:
          Pad.Graphics.DrawString(this.fText, this.fFont, (Brush) new SolidBrush(this.fColor), (float) Pad.ClientX(this.fX), (float) Pad.ClientY(this.fY));
          break;
        case ETextPosition.LeftBottom:
          Pad.Graphics.DrawString(this.fText, this.fFont, (Brush) new SolidBrush(this.fColor), (float) (Pad.ClientX(this.fX) - num1), (float) Pad.ClientY(this.fY));
          break;
        case ETextPosition.CentreBottom:
          Pad.Graphics.DrawString(this.fText, this.fFont, (Brush) new SolidBrush(this.fColor), (float) (Pad.ClientX(this.fX) - num1 / 2), (float) Pad.ClientY(this.fY));
          break;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TDistance Distance(double X, double Y)
    {
      return (TDistance) null;
    }
  }
}
