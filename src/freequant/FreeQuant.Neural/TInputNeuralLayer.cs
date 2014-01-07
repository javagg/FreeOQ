// Type: SmartQuant.Neural.TInputNeuralLayer
// Assembly: SmartQuant.Neural, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: E5DFC29A-4534-4F54-827A-AC305F5F2864
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Neural.dll

using aq250XLTtWVBJufbvY;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Neural
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TInputNeuralLayer()
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TInputNeuralLayer(int NNeuron, bool AddThreshold)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
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

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Connect(TOutputNeuralLayer OutputLayer)
    {
      int num1 = 0;
      if (this.IsThreshold)
        num1 = 1;
      int num2 = Math.Min(this.GetNNeuron() - num1, OutputLayer.GetNNeuron());
      for (int i = num1; i < num2; ++i)
        this.GetNeuron(i).Connect(OutputLayer.GetNeuron(i));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FeedInput(double[] InputPattern)
    {
      for (int index = 1; index < this.fNNeuron; ++index)
        ((TNeuron) this.fNeuron[index]).Input = InputPattern[index - 1];
    }
  }
}
