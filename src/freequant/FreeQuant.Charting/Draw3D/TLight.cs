// Type: SmartQuant.Charting.Draw3D.TLight
// Assembly: SmartQuant.Charting, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: 31D4C736-04FD-420E-87A7-219DB548155F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Charting.dll

using cPAIWng0kq1SUTh6h4;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace SmartQuant.Charting.Draw3D
{
  public class TLight
  {
    public TColor Ambient;
    public TLight.TSource[] ParallelBeams;
    public TLight.TSource[] NearSources;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TLight()
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      this.Ambient = new TColor(Color.PaleTurquoise);
      this.ParallelBeams = new TLight.TSource[1]
      {
        new TLight.TSource(new TVec3(3.0, -2.0, 2.0), (TColor) Color.LightYellow)
      };
      this.NearSources = new TLight.TSource[0];
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.SetSfumatoDay();
      this.SetShadowSources(0.25);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSfumatoDay()
    {
      this.Ambient = new TColor(0.55, 0.55, 0.7);
      this.ParallelBeams[0].c = 2.05 * new TColor(1.0, 1.0, 0.55);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNormalDay()
    {
      this.SetSfumatoDay();
      this.Ambient *= 1.1;
      this.ParallelBeams[0].c *= 1.1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVeryBrightDay()
    {
      this.SetSfumatoDay();
      this.Ambient *= 1.2;
      this.ParallelBeams[0].c *= 1.2;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShadowSources(double K)
    {
      TLight.TSource[] tsourceArray = new TLight.TSource[2 * this.ParallelBeams.Length];
      for (int index1 = 0; index1 < this.ParallelBeams.Length; ++index1)
      {
        int index2 = 2 * index1;
        tsourceArray[index2] = this.ParallelBeams[index1];
        tsourceArray[index2 + 1].o = -tsourceArray[index2].o;
        tsourceArray[index2 + 1].c = -K * tsourceArray[index2].c;
      }
      this.ParallelBeams = tsourceArray;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TColor Result(TVec3 r, TVec3 n, TColor Diffuse)
    {
      TColor tcolor = this.Ambient;
      foreach (TLight.TSource tsource in this.ParallelBeams)
      {
        double num1 = n * tsource.o;
        if (num1 >= 0.0)
        {
          double num2 = num1 * num1 / (n * n * tsource.o * tsource.o);
          tcolor += num2 * tsource.c;
        }
      }
      foreach (TLight.TSource tsource in this.NearSources)
      {
        TVec3 tvec3 = tsource.o - r;
        double num1 = n * tvec3;
        double num2 = tvec3 * tvec3;
        if (num1 >= 0.0)
        {
          double num3 = num1 * num1 / (n * n * num2 * num2);
          tcolor += num3 * tsource.c;
        }
      }
      return Diffuse * tcolor;
    }

    public struct TSource
    {
      public TVec3 o;
      public TColor c;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public TSource(TVec3 o, TColor c)
      {
        Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
        this.o = o;
        this.c = c;
      }
    }
  }
}
