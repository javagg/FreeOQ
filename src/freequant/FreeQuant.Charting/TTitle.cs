using System;
using System.Collections;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
  [Serializable]
  public class TTitle
  {
    private Pad zeN3moyxtg;
    private ArrayList rZ630y2ajd;
    private bool RsC3aSxwHb;
    private string keq3T1dEAX;
    private Font OcB3h59UM9;
    private Color mrl3VHn0gx;
    private ETitlePosition qiA358ZZi0;
    private int f5e3L6gA5t;
    private int GYu3Ak0B6x;
    private ETitleStrategy GT83QjlMJ1;

    public ArrayList Items
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.rZ630y2ajd;
      }
    }

    public bool ItemsEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.RsC3aSxwHb;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.RsC3aSxwHb = value;
      }
    }

    public string Text
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.keq3T1dEAX;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.keq3T1dEAX = value;
      }
    }

    public Font Font
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OcB3h59UM9;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.OcB3h59UM9 = value;
      }
    }

    public Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mrl3VHn0gx;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.mrl3VHn0gx = value;
      }
    }

    public ETitlePosition Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.qiA358ZZi0;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.qiA358ZZi0 = value;
      }
    }

    public int X
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.f5e3L6gA5t;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.f5e3L6gA5t = value;
      }
    }

    public int Y
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GYu3Ak0B6x;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.GYu3Ak0B6x = value;
      }
    }

    public int Width
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (int) this.zeN3moyxtg.Graphics.MeasureString(this.vsC3u6p1dQ(), this.OcB3h59UM9).Width;
      }
    }

    public int Height
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (int) this.zeN3moyxtg.Graphics.MeasureString(this.vsC3u6p1dQ(), this.OcB3h59UM9).Height;
      }
    }

    public ETitleStrategy Strategy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GT83QjlMJ1;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.GT83QjlMJ1 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TTitle(Pad Pad)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.zeN3moyxtg = Pad;
      this.keq3T1dEAX = "";
      this.Rgq3k0SxCt();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TTitle(Pad Pad, string Text)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.zeN3moyxtg = Pad;
      this.keq3T1dEAX = Text;
      this.Rgq3k0SxCt();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Rgq3k0SxCt()
    {
      this.rZ630y2ajd = new ArrayList();
      this.RsC3aSxwHb = false;
      this.keq3T1dEAX = "";
      this.OcB3h59UM9 = new Font(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(616), 8f);
      this.mrl3VHn0gx = Color.Black;
      this.qiA358ZZi0 = ETitlePosition.Left;
      this.GT83QjlMJ1 = ETitleStrategy.Smart;
      this.f5e3L6gA5t = 0;
      this.GYu3Ak0B6x = 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(string Text, Color Color)
    {
      this.rZ630y2ajd.Add((object) new TTitleItem(Text, Color));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string vsC3u6p1dQ()
    {
      string str = this.keq3T1dEAX;
      foreach (TTitleItem ttitleItem in this.rZ630y2ajd)
        str = str + RA7k7APgXK5aSsnmA9.qBCYFXVOKp(630) + ttitleItem.Text;
      return str;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Paint()
    {
      SolidBrush solidBrush1 = new SolidBrush(this.mrl3VHn0gx);
      if (this.keq3T1dEAX != "")
        this.zeN3moyxtg.Graphics.DrawString(this.keq3T1dEAX, this.OcB3h59UM9, (Brush) solidBrush1, (float) this.f5e3L6gA5t, (float) this.GYu3Ak0B6x);
      if (this.GT83QjlMJ1 == ETitleStrategy.Smart && this.keq3T1dEAX == "" && (!this.RsC3aSxwHb && this.rZ630y2ajd.Count != 0))
        this.zeN3moyxtg.Graphics.DrawString(((TTitleItem) this.rZ630y2ajd[0]).Text, this.OcB3h59UM9, (Brush) new SolidBrush(this.mrl3VHn0gx), (float) this.f5e3L6gA5t, (float) this.GYu3Ak0B6x);
      if (!this.RsC3aSxwHb)
        return;
      string str = this.keq3T1dEAX;
      foreach (TTitleItem ttitleItem in this.rZ630y2ajd)
      {
        SolidBrush solidBrush2 = new SolidBrush(ttitleItem.Color);
        string text = str + RA7k7APgXK5aSsnmA9.qBCYFXVOKp(636);
        int num = this.f5e3L6gA5t + (int) this.zeN3moyxtg.Graphics.MeasureString(text, this.OcB3h59UM9).Width;
        this.zeN3moyxtg.Graphics.DrawString(ttitleItem.Text, this.OcB3h59UM9, (Brush) solidBrush2, (float) num, (float) this.GYu3Ak0B6x);
        str = text + ttitleItem.Text;
      }
    }
  }
}
