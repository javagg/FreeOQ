using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Neural
{
  [Serializable]
  public class TInputNeuralLayer : TNeuralLayer
  {
    private bool oEXc819xw;

    public bool IsThreshold
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.oEXc819xw;
      }
    }

    public TInputNeuralLayer(int NNeuron, bool AddThreshold)
    {
      if (AddThreshold)
      {
        this.fNeuron.Add((object) new TThresholdNeuron());
        TInputNeuralLayer tinputNeuralLayer = this;
        int num = tinputNeuralLayer.fNNeuron + 1;
        tinputNeuralLayer.fNNeuron = num;
        this.oEXc819xw = true;
      }
      else
        this.oEXc819xw = false;
      for (int index = 0; index < NNeuron; ++index)
        this.fNeuron.Add((object) new TInputNeuron());
      TInputNeuralLayer tinputNeuralLayer1 = this;
      int num1 = tinputNeuralLayer1.fNNeuron + NNeuron;
      tinputNeuralLayer1.fNNeuron = num1;
    }

    public void Connect(TInputNeuralLayer InputLayer)
    {
      int num1 = 0;
      int num2 = 0;
      if (this.IsThreshold)
        num1 = 1;
      if (InputLayer.IsThreshold)
        num2 = 1;
      int num3 = Math.Min(this.GetNNeuron() - num1, InputLayer.GetNNeuron() - num2);
      for (int i = num1; i < num3; ++i)
        this.GetNeuron(i).Connect(InputLayer.GetNeuron(i - num2));
    }

    public void Connect(TOutputNeuralLayer OutputLayer)
    {
      int num1 = 0;
      if (this.IsThreshold)
        num1 = 1;
      int num2 = Math.Min(this.GetNNeuron() - num1, OutputLayer.GetNNeuron());
      for (int i = num1; i < num2; ++i)
        this.GetNeuron(i).Connect(OutputLayer.GetNeuron(i));
    }

    public void FeedInput(double[] InputPattern)
    {
      for (int index = 1; index < this.fNNeuron; ++index)
        ((TNeuron) this.fNeuron[index]).Input = InputPattern[index - 1];
    }
  }
}
