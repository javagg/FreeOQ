// Type: SmartQuant.Neural.TOutputNeuron
// Assembly: SmartQuant.Neural, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: E5DFC29A-4534-4F54-827A-AC305F5F2864
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Neural.dll

using aq250XLTtWVBJufbvY;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Neural
{
  [Serializable]
  public class TOutputNeuron : TNeuron
  {
    private EActivationMode dwvXwyWh8;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TOutputNeuron()
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.dwvXwyWh8 = EActivationMode.Approximation;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TOutputNeuron(EActivationMode Mode)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.dwvXwyWh8 = Mode;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private EActivationMode pC6WUCL6n()
    {
      return this.dwvXwyWh8;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void cXt5bimqX(EActivationMode value)
    {
      this.dwvXwyWh8 = value;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double Activation(double x)
    {
      switch (this.dwvXwyWh8)
      {
        case EActivationMode.Approximation:
          return x;
        case EActivationMode.Classification:
          return 1.0 / (1.0 + Math.Exp(-2.0 * x));
        default:
          return 0.0;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double Gradient(double x)
    {
      switch (this.dwvXwyWh8)
      {
        case EActivationMode.Approximation:
          return 1.0;
        case EActivationMode.Classification:
          double num = Math.Exp(-2.0 * x);
          return 2.0 * num / ((1.0 + num) * (1.0 + num));
        default:
          return 0.0;
      }
    }
  }
}
