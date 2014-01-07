// Type: SmartQuant.Neural.THiddenNeuron
// Assembly: SmartQuant.Neural, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: E5DFC29A-4534-4F54-827A-AC305F5F2864
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Neural.dll

using aq250XLTtWVBJufbvY;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Neural
{
  [Serializable]
  public class THiddenNeuron : TNeuron
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public THiddenNeuron()
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double Activation(double x)
    {
      return Math.Tanh(x);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double Gradient(double x)
    {
      double num = Math.Tanh(x);
      return 1.0 - num * num;
    }
  }
}
