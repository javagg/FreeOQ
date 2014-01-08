using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Charting
{
  [Serializable]
  public class TTextBox : IDrawable
  {
    private ArrayList MiCo0cVdT4;
    private int S0doaOsoSA;
    private int itEoTyggr4;
    private int FCtohwnDhn;
    private int LsdoV2Ci3r;
    private ETextBoxPosition Dx9o5oDbau;
    private bool GcooLeuTP3;
    private Color ansoA5YErY;
    private Color WTnoQQ66Ib;
    private bool JHRowdiilF;
    private string g4boSZRHqq;

    [Category("ToolTip")]
    [Description("")]
    public bool ToolTipEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.JHRowdiilF;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.JHRowdiilF = value;
      }
    }

    [Category("ToolTip")]
    [Description("")]
    public string ToolTipFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.g4boSZRHqq;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.g4boSZRHqq = value;
      }
    }

    public ETextBoxPosition Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Dx9o5oDbau;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Dx9o5oDbau = value;
      }
    }

    public int X
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.S0doaOsoSA;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.S0doaOsoSA = value;
      }
    }

    public int Y
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.itEoTyggr4;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.itEoTyggr4 = value;
      }
    }

    public int Width
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.FCtohwnDhn;
      }
    }

    public int Height
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.LsdoV2Ci3r;
      }
    }

    public bool BorderEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GcooLeuTP3;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.GcooLeuTP3 = value;
      }
    }

    public Color BorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ansoA5YErY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.ansoA5YErY = value;
      }
    }

    public Color BackColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WTnoQQ66Ib;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.WTnoQQ66Ib = value;
      }
    }

    public ArrayList Items
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.MiCo0cVdT4;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TTextBox()
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.S0doaOsoSA = 10;
      this.itEoTyggr4 = 10;
      this.xehokEEu0B();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TTextBox(int X, int Y)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.S0doaOsoSA = X;
      this.itEoTyggr4 = Y;
      this.xehokEEu0B();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void xehokEEu0B()
    {
      this.FCtohwnDhn = -1;
      this.LsdoV2Ci3r = -1;
      this.Dx9o5oDbau = ETextBoxPosition.TopRight;
      this.GcooLeuTP3 = true;
      this.ansoA5YErY = Color.Black;
      this.WTnoQQ66Ib = Color.LightYellow;
      this.MiCo0cVdT4 = new ArrayList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(string Text, Color Color)
    {
      this.MiCo0cVdT4.Add((object) new TTextBoxItem(Text, Color));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(string Text, Color Color, Font Font)
    {
      this.MiCo0cVdT4.Add((object) new TTextBoxItem(Text, Color, Font));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(TTextBoxItem Item)
    {
      this.MiCo0cVdT4.Add((object) Item);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.MiCo0cVdT4.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Draw()
    {
      if (Chart.Pad == null)
      {
        Canvas canvas = new Canvas(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(224), RA7k7APgXK5aSsnmA9.qBCYFXVOKp(240));
      }
      Chart.Pad.Add((IDrawable) this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float MhmouvgBhg([In] Pad obj0)
    {
      this.FCtohwnDhn = 0;
      foreach (TTextBoxItem ttextBoxItem in this.MiCo0cVdT4)
      {
        int num = (int) obj0.Graphics.MeasureString(ttextBoxItem.Text, ttextBoxItem.Font).Width;
        if (num > this.FCtohwnDhn)
          this.FCtohwnDhn = num;
      }
      this.FCtohwnDhn += 12;
      return (float) this.FCtohwnDhn;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float qUZomVYuoh([In] Pad obj0)
    {
      this.LsdoV2Ci3r = 0;
      foreach (TTextBoxItem ttextBoxItem in this.MiCo0cVdT4)
        this.LsdoV2Ci3r += (int) obj0.Graphics.MeasureString(ttextBoxItem.Text, ttextBoxItem.Font).Height + 2;
      this.LsdoV2Ci3r += 2;
      return (float) this.LsdoV2Ci3r;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
    {
      float height = this.qUZomVYuoh(Pad);
      float width = this.MhmouvgBhg(Pad);
      float x = 0.0f;
      float y = 0.0f;
      switch (this.Dx9o5oDbau)
      {
        case ETextBoxPosition.TopRight:
          x = (float) (Pad.ClientX() + Pad.ClientWidth() - this.S0doaOsoSA) - width;
          y = (float) (Pad.ClientY() + this.itEoTyggr4);
          break;
        case ETextBoxPosition.TopLeft:
          x = (float) (Pad.ClientX() + this.S0doaOsoSA);
          y = (float) (Pad.ClientY() + this.itEoTyggr4);
          break;
        case ETextBoxPosition.BottomRight:
          x = (float) (Pad.ClientX() + Pad.ClientWidth() - this.S0doaOsoSA) - width;
          y = (float) (Pad.ClientY() + Pad.ClientHeight() - this.itEoTyggr4) - height;
          break;
        case ETextBoxPosition.BottomLeft:
          x = (float) (Pad.ClientX() + this.S0doaOsoSA);
          y = (float) (Pad.ClientY() + Pad.ClientHeight() - this.itEoTyggr4) - height;
          break;
      }
      Pad.Graphics.FillRectangle((Brush) new SolidBrush(this.WTnoQQ66Ib), x, y, width, height);
      if (this.GcooLeuTP3)
        Pad.Graphics.DrawRectangle(new Pen(this.ansoA5YErY), x, y, width, height);
      foreach (TTextBoxItem ttextBoxItem in this.MiCo0cVdT4)
      {
        int num = (int) Pad.Graphics.MeasureString(ttextBoxItem.Text, ttextBoxItem.Font).Height;
        Pad.Graphics.DrawString(ttextBoxItem.Text, ttextBoxItem.Font, (Brush) new SolidBrush(ttextBoxItem.Color), x + 5f, y);
        y += (float) (2 + num);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TDistance Distance(double X, double Y)
    {
      return (TDistance) null;
    }
  }
}
