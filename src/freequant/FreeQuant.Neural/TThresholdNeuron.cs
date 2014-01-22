using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Neural
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
      this.output = 1.0;
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
      this.output = 1.0;
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
