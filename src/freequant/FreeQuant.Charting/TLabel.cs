using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
  [Serializable]
  public class TLabel : TMarker
  {
    private string OFU3pa8K6e;
    private ETextPosition q4G3dlxqU0;
		private Font font; 
		private Color color; 
    private int ikB3qmd6of;
    private int WrF3tEwXpB;

    [Category("Text")]
    [Description("Text that this label displays")]
    public new string Text
    {
       get
      {
        return this.OFU3pa8K6e;
      }
       set
      {
        this.OFU3pa8K6e = value;
      }
    }

    [Description("Text position of this label")]
    [Category("Text")]
    public ETextPosition TextPosition
    {
       get
      {
        return this.q4G3dlxqU0;
      }
       set
      {
        this.q4G3dlxqU0 = value;
      }
    }

    [Description("Text font of this label")]
    [Category("Text")]
    public new Font TextFont
    {
       get
      {
        return this.font;
      }
       set
      {
        this.font = value;
      }
    }

    [Description("Text color of this label")]
    [Category("Text")]
    public new Color TextColor
    {
       get
      {
        return this.color;
      }
       set
      {
        this.color = value;
      }
    }

    [Description("Text offset in pixels alone X coordinate")]
    [Category("Text")]
    public int TextOffsetX
    {
       get
      {
        return this.ikB3qmd6of;
      }
       set
      {
        this.ikB3qmd6of = value;
      }
    }

    [Category("Text")]
    [Description("Text offset in pixels alone Y coordinate")]
    public int TextOffsetY
    {
       get
      {
        return this.WrF3tEwXpB;
      }
       set
      {
        this.WrF3tEwXpB = value;
      }
    }


    public TLabel(string Text, double X, double Y):base(X,Y)
    {

      this.OFU3pa8K6e = Text;
      this.I9m3s0VaOK();
    }

    
    public TLabel(string Text, double X, double Y, Color MarkerColor): base(X, Y, MarkerColor)
    {
      this.OFU3pa8K6e = Text;
      this.I9m3s0VaOK();
    }

    public TLabel(string Text, double X, double Y, Color MarkerColor, Color TextColor) :base(X, Y, MarkerColor)
    {
      this.OFU3pa8K6e = Text;
      this.I9m3s0VaOK();
      this.color = TextColor;
    }

    
    private void I9m3s0VaOK()
    {
			this.font = new Font("Arial", 8);
      this.q4G3dlxqU0 = ETextPosition.RightBottom;
      this.color = Color.Black;
      this.ikB3qmd6of = 0;
      this.WrF3tEwXpB = 2;
    }

    
    public override void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
    {
      base.Paint(Pad, MinX, MaxX, MinY, MaxY);
      if (this.OFU3pa8K6e == null)
        return;
      int num1 = (int) Pad.Graphics.MeasureString(this.OFU3pa8K6e, this.font).Width;
      int num2 = (int) Pad.Graphics.MeasureString(this.OFU3pa8K6e, this.font).Height;
      switch (this.q4G3dlxqU0)
      {
        case ETextPosition.RightTop:
          Pad.Graphics.DrawString(this.OFU3pa8K6e, this.font, (Brush) new SolidBrush(this.color), (float) (Pad.ClientX(this.fX) + this.ikB3qmd6of), (float) (Pad.ClientY(this.fY) - num2 - this.WrF3tEwXpB));
          break;
        case ETextPosition.LeftTop:
          Pad.Graphics.DrawString(this.OFU3pa8K6e, this.font, (Brush) new SolidBrush(this.color), (float) (Pad.ClientX(this.fX) - num1 - this.ikB3qmd6of), (float) (Pad.ClientY(this.fY) - num2 - this.WrF3tEwXpB));
          break;
        case ETextPosition.CentreTop:
          Pad.Graphics.DrawString(this.OFU3pa8K6e, this.font, (Brush) new SolidBrush(this.color), (float) (Pad.ClientX(this.fX) - num1 / 2 - this.ikB3qmd6of), (float) (Pad.ClientY(this.fY) - num2 - this.WrF3tEwXpB));
          break;
        case ETextPosition.RightBottom:
          Pad.Graphics.DrawString(this.OFU3pa8K6e, this.font, (Brush) new SolidBrush(this.color), (float) (Pad.ClientX(this.fX) + this.ikB3qmd6of), (float) (Pad.ClientY(this.fY) + this.Size / 2 + this.WrF3tEwXpB));
          break;
        case ETextPosition.LeftBottom:
          Pad.Graphics.DrawString(this.OFU3pa8K6e, this.font, (Brush) new SolidBrush(this.color), (float) (Pad.ClientX(this.fX) - num1 - this.ikB3qmd6of), (float) (Pad.ClientY(this.fY) + this.Size / 2 + this.WrF3tEwXpB));
          break;
        case ETextPosition.CentreBottom:
          Pad.Graphics.DrawString(this.OFU3pa8K6e, this.font, (Brush) new SolidBrush(this.color), (float) (Pad.ClientX(this.fX) - num1 / 2 - this.ikB3qmd6of), (float) (Pad.ClientY(this.fY) + this.Size / 2 + this.WrF3tEwXpB));
          break;
      }
    }
  }
}
