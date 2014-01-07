// Type: SmartQuant.Neural.TNeuralWeight
// Assembly: SmartQuant.Neural, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: E5DFC29A-4534-4F54-827A-AC305F5F2864
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Neural.dll

using aq250XLTtWVBJufbvY;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Neural
{
  [Serializable]
  public class TNeuralWeight
  {
    private TNeuron vW0jGfkno;
    private int RlTATm4JD;
    private double NN8J3LC7E;
    private double rYdS9wvbM;
    private double SQmiIFQhZ;
    private double juuH7yMX2;
    private double uOXtaamso;
    private double iwqhxvM4s;
    private double fIoOrFPcr;
    private double UvZNU7mk8;

    public TNeuron Neuron
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.vW0jGfkno;
      }
    }

    public double Weight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.NN8J3LC7E;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.NN8J3LC7E = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralWeight()
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      TNeuralNetwork.Network.AddWeight(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralWeight(TNeuron Neuron, double Weight)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.vW0jGfkno = Neuron;
      this.RlTATm4JD = Neuron.ID;
      if (TNeuralNetwork.Network.InitMode == EWeightInitMode.Random)
        this.Randomize();
      else
        this.NN8J3LC7E = Weight;
      this.rYdS9wvbM = this.NN8J3LC7E;
      this.uOXtaamso = 0.0;
      this.iwqhxvM4s = 0.0;
      this.fIoOrFPcr = TNeuralNetwork.Network.RpropDeltaInit;
      this.UvZNU7mk8 = this.fIoOrFPcr;
      TNeuralNetwork.Network.AddWeight(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralWeight(TNeuron Neuron)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.vW0jGfkno = Neuron;
      this.RlTATm4JD = Neuron.ID;
      if (TNeuralNetwork.Network.InitMode == EWeightInitMode.Random)
        this.Randomize();
      else
        this.NN8J3LC7E = 0.0;
      this.rYdS9wvbM = this.NN8J3LC7E;
      this.uOXtaamso = 0.0;
      this.iwqhxvM4s = 0.0;
      this.fIoOrFPcr = TNeuralNetwork.Network.RpropDeltaInit;
      this.UvZNU7mk8 = this.fIoOrFPcr;
      TNeuralNetwork.Network.AddWeight(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Randomize()
    {
      this.NN8J3LC7E = SmartQuant.Quant.Random.Rndm() - 0.5;
      this.rYdS9wvbM = this.NN8J3LC7E;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetInput()
    {
      return this.vW0jGfkno.GetOutput();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double PropagateInput()
    {
      return this.NN8J3LC7E * this.GetInput();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PropagateError(double Error)
    {
      this.vW0jGfkno.AddError(this.NN8J3LC7E * Error);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update(double Error)
    {
      this.uOXtaamso = -Error * this.vW0jGfkno.GetOutput();
      double num1 = this.NN8J3LC7E;
      double num2 = this.NN8J3LC7E - this.rYdS9wvbM;
      double num3 = 0.0;
      if (TNeuralNetwork.Network.LearningMethod == ELearningMethod.BackProp)
      {
        this.NN8J3LC7E += -TNeuralNetwork.Network.LearningRate * this.uOXtaamso / (double) TNeuralNetwork.Network.NBatch + TNeuralNetwork.Network.Momentum * num2 - TNeuralNetwork.Network.WeightDecay * this.NN8J3LC7E;
        this.iwqhxvM4s = this.uOXtaamso;
      }
      if (TNeuralNetwork.Network.LearningMethod == ELearningMethod.QuickProp)
      {
        if (num2 > 0.0)
        {
          if (this.uOXtaamso < 0.0)
          {
            num3 = -TNeuralNetwork.Network.LearningRate * this.uOXtaamso + TNeuralNetwork.Network.Momentum * num2;
          }
          else
          {
            num3 = this.uOXtaamso / (this.iwqhxvM4s - this.uOXtaamso) * num2;
            if (num3 > TNeuralNetwork.Network.MaximumGrowth * num2)
              num3 = TNeuralNetwork.Network.MaximumGrowth * num2;
          }
        }
        if (num2 < 0.0)
        {
          if (this.uOXtaamso > 0.0)
          {
            num3 = -TNeuralNetwork.Network.LearningRate * this.uOXtaamso + TNeuralNetwork.Network.Momentum * num2;
          }
          else
          {
            num3 = this.uOXtaamso / (this.iwqhxvM4s - this.uOXtaamso) * num2;
            if (num3 < TNeuralNetwork.Network.MaximumGrowth * num2)
              num3 = TNeuralNetwork.Network.MaximumGrowth * num2;
          }
        }
        if (num2 == 0.0)
          num3 = -TNeuralNetwork.Network.LearningRate * this.uOXtaamso + TNeuralNetwork.Network.Momentum * num2;
        this.NN8J3LC7E += num3 - TNeuralNetwork.Network.WeightDecay * this.NN8J3LC7E;
        this.iwqhxvM4s = this.uOXtaamso;
      }
      if (TNeuralNetwork.Network.LearningMethod == ELearningMethod.Rprop)
      {
        if (this.uOXtaamso * this.iwqhxvM4s > 0.0)
        {
          this.fIoOrFPcr = Math.Min(TNeuralNetwork.Network.RpropIncrease * this.UvZNU7mk8, TNeuralNetwork.Network.RpropDeltaMax);
          this.NN8J3LC7E += this.uOXtaamso != 0.0 ? (this.uOXtaamso <= 0.0 ? this.fIoOrFPcr : -this.fIoOrFPcr) : 0.0;
          this.iwqhxvM4s = this.uOXtaamso;
        }
        if (this.uOXtaamso * this.iwqhxvM4s < 0.0)
        {
          this.fIoOrFPcr = Math.Max(TNeuralNetwork.Network.RpropDecrease * this.UvZNU7mk8, TNeuralNetwork.Network.RpropDeltaMin);
          this.NN8J3LC7E += this.uOXtaamso != 0.0 ? (this.uOXtaamso <= 0.0 ? this.fIoOrFPcr : -this.fIoOrFPcr) : 0.0;
          this.iwqhxvM4s = 0.0;
        }
        if (this.uOXtaamso * this.iwqhxvM4s == 0.0)
        {
          this.fIoOrFPcr = this.UvZNU7mk8;
          this.NN8J3LC7E += this.uOXtaamso != 0.0 ? (this.uOXtaamso <= 0.0 ? this.fIoOrFPcr : -this.fIoOrFPcr) : 0.0;
          this.iwqhxvM4s = this.uOXtaamso;
        }
        this.UvZNU7mk8 = this.fIoOrFPcr;
      }
      this.rYdS9wvbM = num1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Store()
    {
      this.SQmiIFQhZ = this.NN8J3LC7E;
      this.juuH7yMX2 = this.rYdS9wvbM;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Restore()
    {
      this.NN8J3LC7E = this.SQmiIFQhZ;
      this.rYdS9wvbM = this.juuH7yMX2;
      this.uOXtaamso = 0.0;
      this.iwqhxvM4s = 0.0;
    }
  }
}
