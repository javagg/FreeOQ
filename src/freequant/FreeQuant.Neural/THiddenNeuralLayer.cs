// Type: SmartQuant.Neural.THiddenNeuralLayer
// Assembly: SmartQuant.Neural, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: E5DFC29A-4534-4F54-827A-AC305F5F2864
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Neural.dll

using aq250XLTtWVBJufbvY;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Neural
{
  [Serializable]
  public class THiddenNeuralLayer : TNeuralLayer
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public THiddenNeuralLayer()
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public THiddenNeuralLayer(int NNeuron)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fNeuron.Add((object) new TThresholdNeuron());
      for (int index = 0; index < NNeuron; ++index)
        this.fNeuron.Add((object) new THiddenNeuron());
      this.fNNeuron = NNeuron + 1;
    }
  }
}
