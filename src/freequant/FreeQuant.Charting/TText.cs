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
       get
      {
        return this.Lqfh3BySh;
      }
       set
      {
        this.Lqfh3BySh = value;
      }
    }

    [Description("")]
    [Category("ToolTip")]
    public string ToolTipFormat
    {
       get
      {
        return this.UL8VcPCS3;
      }
       set
      {
        this.UL8VcPCS3 = value;
      }
    }

    [Category("Position")]
    [Description("")]
    public double X
    {
       get
      {
        return this.fX;
      }
       set
      {
        this.fX = value;
      }
    }

    [Description("")]
    [Category("Position")]
    public double Y
    {
       get
      {
        return this.fY;
      }
       set
      {
        this.fY = value;
      }
    }

    [Browsable(false)]
    public double Z
    {
       get
      {
        return this.fZ;
      }
       set
      {
        this.fZ = value;
      }
    }

    [Category("Text")]
    [Description("")]
    public string Text
    {
       get
      {
        return this.fText;
      }
       set
      {
        this.fText = value;
      }
    }

    [Category("Text")]
    [Description("")]
    public ETextPosition Position
    {
       get
      {
        return this.fPosition;
      }
       set
      {
        this.fPosition = value;
      }
    }

    [Category("Text")]
    [Description("")]
    public Font Font
    {
       get
      {
        return this.fFont;
      }
       set
      {
        this.fFont = value;
      }
    }

    [Description("")]
    [Category("Text")]
    public Color Color
    {
       get
      {
        return this.fColor;
      }
       set
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

    
    private void aBfTaltcp()
    {
      this.fPosition = ETextPosition.RightBottom;
	this.fFont = new Font("Times New Roman", 8);
      this.fColor = Color.Black;
    }

    
    public virtual void Draw()
    {
      if (Chart.Pad == null)
      {
				Canvas canvas = new Canvas("CName", "CTEXt");
      }
      Chart.Pad.Add((IDrawable) this);
    }

    
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

    
    public TDistance Distance(double X, double Y)
    {
      return (TDistance) null;
    }
  }
}
