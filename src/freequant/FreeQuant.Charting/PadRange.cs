// Type: SmartQuant.Charting.PadRange
// Assembly: SmartQuant.Charting, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: 31D4C736-04FD-420E-87A7-219DB548155F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Charting.dll

using cPAIWng0kq1SUTh6h4;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Charting
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
