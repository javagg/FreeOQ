// Type: SmartQuant.Neural.TOutputNeuralLayer
// Assembly: SmartQuant.Neural, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: E5DFC29A-4534-4F54-827A-AC305F5F2864
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Neural.dll

using aq250XLTtWVBJufbvY;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Neural
{
  [Serializable]
  public class TOutputNeuralLayer : TNeuralLayer
  {
    private double[] DLIlOx3mN;
    private EActivationMode AGFR7NSDt;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TOutputNeuralLayer()
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.AGFR7NSDt = EActivationMode.Approximation;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TOutputNeuralLayer(int NNeuron, EActivationMode Mode)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.AGFR7NSDt = Mode;
      for (int index = 0; index < NNeuron; ++index)
        this.fNeuron.Add((object) new TOutputNeuron(this.AGFR7NSDt));
      this.DLIlOx3mN = new double[NNeuron];
      this.fNNeuron = NNeuron;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double[] GetOutput()
    {
      for (int index = 0; index < this.fNNeuron; ++index)
        this.DLIlOx3mN[index] = ((TNeuron) this.fNeuron[index]).Output;
      return this.DLIlOx3mN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FeedError(double[] Error)
    {
      for (int index = 0; index < this.fNNeuron; ++index)
        ((TNeuron) this.fNeuron[index]).Error = Error[index];
    }
  }
}
