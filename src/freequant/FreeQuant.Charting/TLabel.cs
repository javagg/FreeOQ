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
    private Font EQW3xMCkiW;
    private Color PmN3IBiixN;
    private int ikB3qmd6of;
    private int WrF3tEwXpB;

    [Category("Text")]
    [Description("Text that this label displays")]
    public new string Text
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OFU3pa8K6e;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.OFU3pa8K6e = value;
      }
    }

    [Description("Text position of this label")]
    [Category("Text")]
    public ETextPosition TextPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.q4G3dlxqU0;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.q4G3dlxqU0 = value;
      }
    }

    [Description("Text font of this label")]
    [Category("Text")]
    public new Font TextFont
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.EQW3xMCkiW;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.EQW3xMCkiW = value;
      }
    }

    [Description("Text color of this label")]
    [Category("Text")]
    public new Color TextColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.PmN3IBiixN;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.PmN3IBiixN = value;
      }
    }

    [Description("Text offset in pixels alone X coordinate")]
    [Category("Text")]
    public int TextOffsetX
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ikB3qmd6of;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.ikB3qmd6of = value;
      }
    }

    [Category("Text")]
    [Description("Text offset in pixels alone Y coordinate")]
    public int TextOffsetY
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WrF3tEwXpB;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.WrF3tEwXpB = value;
      }
    }


    public TLabel(string Text, double X, double Y):base(X,Y)
    {

      this.OFU3pa8K6e = Text;
      this.I9m3s0VaOK();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TLabel(string Text, double X, double Y, Color MarkerColor): base(X, Y, MarkerColor)
    {
      this.OFU3pa8K6e = Text;
      this.I9m3s0VaOK();
    }

    public TLabel(string Text, double X, double Y, Color MarkerColor, Color TextColor) :base(X, Y, MarkerColor)
    {
      this.OFU3pa8K6e = Text;
      this.I9m3s0VaOK();
      this.PmN3IBiixN = TextColor;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void I9m3s0VaOK()
    {
      this.EQW3xMCkiW = new Font(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(602), 8f);
      this.q4G3dlxqU0 = ETextPosition.RightBottom;
      this.PmN3IBiixN = Color.Black;
      this.ikB3qmd6of = 0;
      this.WrF3tEwXpB = 2;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
    {
      base.Paint(Pad, MinX, MaxX, MinY, MaxY);
      if (this.OFU3pa8K6e == null)
        return;
      int num1 = (int) Pad.Graphics.MeasureString(this.OFU3pa8K6e, this.EQW3xMCkiW).Width;
      int num2 = (int) Pad.Graphics.MeasureString(this.OFU3pa8K6e, this.EQW3xMCkiW).Height;
      switch (this.q4G3dlxqU0)
      {
        case ETextPosition.RightTop:
          Pad.Graphics.DrawString(this.OFU3pa8K6e, this.EQW3xMCkiW, (Brush) new SolidBrush(this.PmN3IBiixN), (float) (Pad.ClientX(this.fX) + this.ikB3qmd6of), (float) (Pad.ClientY(this.fY) - num2 - this.WrF3tEwXpB));
          break;
        case ETextPosition.LeftTop:
          Pad.Graphics.DrawString(this.OFU3pa8K6e, this.EQW3xMCkiW, (Brush) new SolidBrush(this.PmN3IBiixN), (float) (Pad.ClientX(this.fX) - num1 - this.ikB3qmd6of), (float) (Pad.ClientY(this.fY) - num2 - this.WrF3tEwXpB));
          break;
        case ETextPosition.CentreTop:
          Pad.Graphics.DrawString(this.OFU3pa8K6e, this.EQW3xMCkiW, (Brush) new SolidBrush(this.PmN3IBiixN), (float) (Pad.ClientX(this.fX) - num1 / 2 - this.ikB3qmd6of), (float) (Pad.ClientY(this.fY) - num2 - this.WrF3tEwXpB));
          break;
        case ETextPosition.RightBottom:
          Pad.Graphics.DrawString(this.OFU3pa8K6e, this.EQW3xMCkiW, (Brush) new SolidBrush(this.PmN3IBiixN), (float) (Pad.ClientX(this.fX) + this.ikB3qmd6of), (float) (Pad.ClientY(this.fY) + this.Size / 2 + this.WrF3tEwXpB));
          break;
        case ETextPosition.LeftBottom:
          Pad.Graphics.DrawString(this.OFU3pa8K6e, this.EQW3xMCkiW, (Brush) new SolidBrush(this.PmN3IBiixN), (float) (Pad.ClientX(this.fX) - num1 - this.ikB3qmd6of), (float) (Pad.ClientY(this.fY) + this.Size / 2 + this.WrF3tEwXpB));
          break;
        case ETextPosition.CentreBottom:
          Pad.Graphics.DrawString(this.OFU3pa8K6e, this.EQW3xMCkiW, (Brush) new SolidBrush(this.PmN3IBiixN), (float) (Pad.ClientX(this.fX) - num1 / 2 - this.ikB3qmd6of), (float) (Pad.ClientY(this.fY) + this.Size / 2 + this.WrF3tEwXpB));
          break;
      }
    }
  }
}
