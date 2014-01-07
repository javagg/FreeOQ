// Type: SmartQuant.Charting.Draw3D.TColor
// Assembly: SmartQuant.Charting, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: 31D4C736-04FD-420E-87A7-219DB548155F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Charting.dll

using cPAIWng0kq1SUTh6h4;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.Charting.Draw3D
{
  public struct TColor
  {
    private double pG5C3Nf7gJ;
    private double onVCC2Wok1;
    private double X31C6Jhc1X;

    public Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return Color.FromArgb((int) ((double) byte.MaxValue * this.pG5C3Nf7gJ), (int) ((double) byte.MaxValue * this.onVCC2Wok1), (int) ((double) byte.MaxValue * this.X31C6Jhc1X));
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this = new TColor(value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TColor(double R, double G, double B)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      this.pG5C3Nf7gJ = R;
      this.onVCC2Wok1 = G;
      this.X31C6Jhc1X = B;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TColor(double Gray)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      this.pG5C3Nf7gJ = this.onVCC2Wok1 = this.X31C6Jhc1X = Gray;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TColor(Color c)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      this.pG5C3Nf7gJ = 1.0 / (double) byte.MaxValue * (double) c.R;
      this.onVCC2Wok1 = 1.0 / (double) byte.MaxValue * (double) c.G;
      this.X31C6Jhc1X = 1.0 / (double) byte.MaxValue * (double) c.B;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator TColor(Color c)
    {
      return new TColor(c);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TColor operator +(TColor a, TColor b)
    {
      return new TColor(a.pG5C3Nf7gJ + b.pG5C3Nf7gJ, a.onVCC2Wok1 + b.onVCC2Wok1, a.X31C6Jhc1X + b.X31C6Jhc1X);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TColor operator *(TColor a, TColor b)
    {
      return new TColor(a.pG5C3Nf7gJ * b.pG5C3Nf7gJ, a.onVCC2Wok1 * b.onVCC2Wok1, a.X31C6Jhc1X * b.X31C6Jhc1X);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TColor operator *(double k, TColor c)
    {
      return new TColor(k * c.pG5C3Nf7gJ, k * c.onVCC2Wok1, k * c.X31C6Jhc1X);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TColor operator *(TColor c, double k)
    {
      return k * c;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Get888()
    {
      return ((int) ((double) byte.MaxValue * this.pG5C3Nf7gJ) << 16) + ((int) ((double) byte.MaxValue * this.onVCC2Wok1) << 8) + (int) ((double) byte.MaxValue * this.X31C6Jhc1X);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void K7ICoOhHGw([In] ref double obj0)
    {
      if (obj0 < 1.0 / 254.0)
        obj0 = 1.0 / 254.0;
      if (obj0 <= 1.0)
        return;
      obj0 = 1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clip()
    {
      this.K7ICoOhHGw(ref this.pG5C3Nf7gJ);
      this.K7ICoOhHGw(ref this.onVCC2Wok1);
      this.K7ICoOhHGw(ref this.X31C6Jhc1X);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TColor Clip(TColor c)
    {
      TColor tcolor = c;
      tcolor.Clip();
      return tcolor;
    }
  }
}
