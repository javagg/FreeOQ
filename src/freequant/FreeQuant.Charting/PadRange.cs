using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
  [Serializable]
  public class PadRange
  {
    public double Min;
    public double Max;
    protected bool isValid;

    public bool IsValid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.isValid;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PadRange(double min, double max)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Min = min;
      this.Max = max;
      this.isValid = max - min > 4.94065645841247E-324;
    }
  }
}
