using System;

namespace FreeQuant.Neural
{
  [Serializable]
  public class TNeuralWeight
  {
    private int RlTATm4JD;
    private double weight;
    private double rYdS9wvbM;
    private double SQmiIFQhZ;
    private double juuH7yMX2;
    private double uOXtaamso;
    private double iwqhxvM4s;
    private double fIoOrFPcr;
    private double UvZNU7mk8;

		public TNeuron Neuron { get; private set; }

    public double Weight
    {
       get
      {
				return this.weight; 
      }
       set
      {
        this.weight = value;
      }
    }

    
    public TNeuralWeight()
    {
      TNeuralNetwork.Network.AddWeight(this);
    }

		public TNeuralWeight(TNeuron neuron, double weight)
    {
			this.Neuron = neuron;
			this.RlTATm4JD = neuron.ID;
      if (TNeuralNetwork.Network.InitMode == EWeightInitMode.Random)
        this.Randomize();
      else
				this.Weight = weight;
			this.rYdS9wvbM = this.Weight;
      this.uOXtaamso = 0.0;
      this.iwqhxvM4s = 0.0;
      this.fIoOrFPcr = TNeuralNetwork.Network.RpropDeltaInit;
      this.UvZNU7mk8 = this.fIoOrFPcr;
      TNeuralNetwork.Network.AddWeight(this);
    }

    
		public TNeuralWeight(TNeuron neuron)
    {
			this.Neuron = neuron;
			this.RlTATm4JD = neuron.ID;
      if (TNeuralNetwork.Network.InitMode == EWeightInitMode.Random)
        this.Randomize();
      else
				this.Weight = 0.0;
			this.rYdS9wvbM = this.Weight;
      this.uOXtaamso = 0.0;
      this.iwqhxvM4s = 0.0;
      this.fIoOrFPcr = TNeuralNetwork.Network.RpropDeltaInit;
      this.UvZNU7mk8 = this.fIoOrFPcr;
      TNeuralNetwork.Network.AddWeight(this);
    }

    
    public void Randomize()
    {
			this.weight = FreeQuant.Quant.Random.Rndm() - 0.5;
      this.rYdS9wvbM = this.weight;
    }

    
    public double GetInput()
    {
			return this.Neuron.GetOutput();
    }

    
    public double PropagateInput()
    {
      return this.weight * this.GetInput();
    }

    
    public void PropagateError(double Error)
    {
			this.Neuron.AddError(this.weight * Error);
    }

    
    public void Update(double Error)
    {
			this.uOXtaamso = -Error * this.Neuron.GetOutput();
      double num1 = this.weight;
      double num2 = this.weight - this.rYdS9wvbM;
      double num3 = 0.0;
      if (TNeuralNetwork.Network.LearningMethod == ELearningMethod.BackProp)
      {
        this.weight += -TNeuralNetwork.Network.LearningRate * this.uOXtaamso / (double) TNeuralNetwork.Network.NBatch + TNeuralNetwork.Network.Momentum * num2 - TNeuralNetwork.Network.WeightDecay * this.weight;
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
        this.weight += num3 - TNeuralNetwork.Network.WeightDecay * this.weight;
        this.iwqhxvM4s = this.uOXtaamso;
      }
      if (TNeuralNetwork.Network.LearningMethod == ELearningMethod.Rprop)
      {
        if (this.uOXtaamso * this.iwqhxvM4s > 0.0)
        {
          this.fIoOrFPcr = Math.Min(TNeuralNetwork.Network.RpropIncrease * this.UvZNU7mk8, TNeuralNetwork.Network.RpropDeltaMax);
          this.weight += this.uOXtaamso != 0.0 ? (this.uOXtaamso <= 0.0 ? this.fIoOrFPcr : -this.fIoOrFPcr) : 0.0;
          this.iwqhxvM4s = this.uOXtaamso;
        }
        if (this.uOXtaamso * this.iwqhxvM4s < 0.0)
        {
          this.fIoOrFPcr = Math.Max(TNeuralNetwork.Network.RpropDecrease * this.UvZNU7mk8, TNeuralNetwork.Network.RpropDeltaMin);
          this.weight += this.uOXtaamso != 0.0 ? (this.uOXtaamso <= 0.0 ? this.fIoOrFPcr : -this.fIoOrFPcr) : 0.0;
          this.iwqhxvM4s = 0.0;
        }
        if (this.uOXtaamso * this.iwqhxvM4s == 0.0)
        {
          this.fIoOrFPcr = this.UvZNU7mk8;
          this.weight += this.uOXtaamso != 0.0 ? (this.uOXtaamso <= 0.0 ? this.fIoOrFPcr : -this.fIoOrFPcr) : 0.0;
          this.iwqhxvM4s = this.uOXtaamso;
        }
        this.UvZNU7mk8 = this.fIoOrFPcr;
      }
      this.rYdS9wvbM = num1;
    }

    
    public void Store()
    {
      this.SQmiIFQhZ = this.weight;
      this.juuH7yMX2 = this.rYdS9wvbM;
    }

    
    public void Restore()
    {
      this.weight = this.SQmiIFQhZ;
      this.rYdS9wvbM = this.juuH7yMX2;
      this.uOXtaamso = 0.0;
      this.iwqhxvM4s = 0.0;
    }
  }
}
