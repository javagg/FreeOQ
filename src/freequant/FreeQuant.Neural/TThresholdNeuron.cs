// Type: SmartQuant.Neural.TThresholdNeuron
// Assembly: SmartQuant.Neural, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: E5DFC29A-4534-4F54-827A-AC305F5F2864
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Neural.dll

using aq250XLTtWVBJufbvY;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Neural
{
  [Serializable]
  public class TThresholdNeuron : TNeuron
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TThresholdNeuron()
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fOutput = 1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Connect(TNeuron Neuron)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Disconnect(TNeuron Neuron)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void ProcessInput(int Option)
    {
      this.fOutput = 1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void ProcessError(int Option)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Update()
    {
    }
  }
}
