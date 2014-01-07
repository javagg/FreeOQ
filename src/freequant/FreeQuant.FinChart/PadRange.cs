// Type: SmartQuant.FinChart.PadRange
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using System;
using System.Runtime.CompilerServices;
using yHueqhRH1sS5jNKgDq;

namespace SmartQuant.FinChart
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
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Min = min;
      this.Max = max;
      this.isValid = max - min > 4.94065645841247E-324;
    }
  }
}
