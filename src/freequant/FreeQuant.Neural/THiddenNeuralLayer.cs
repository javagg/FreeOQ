using System;

namespace FreeQuant.Neural
{
  [Serializable]
  public class THiddenNeuralLayer : TNeuralLayer
  {
    public THiddenNeuralLayer(int NNeuron)
    {
      this.fNeuron.Add((object) new TThresholdNeuron());
      for (int index = 0; index < NNeuron; ++index)
        this.fNeuron.Add((object) new THiddenNeuron());
      this.fNNeuron = NNeuron + 1;
    }
  }
}
