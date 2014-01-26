using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Neural
{
  [Serializable]
  public class TKohonenNeuron : TNeuron
  {
    private TKohonenMap vOHKkfFcp;
    private int WKXIlHax4;
    private int uiQQufIMH;
    private double WxVfa8WCZ;
    private int pudq36ntP;

    public int Col
    {
       get
      {
        return this.WKXIlHax4;
      }
    }

    public int Row
    {
       get
      {
        return this.uiQQufIMH;
      }
    }

    
		public TKohonenNeuron() : base()
    {
      this.WxVfa8WCZ = 0.0;
      this.pudq36ntP = 0;
    }

    
		public TKohonenNeuron(TKohonenMap Map, int Col, int Row): base()
    {
      this.vOHKkfFcp = Map;
      this.WKXIlHax4 = Col;
      this.uiQQufIMH = Row;
      this.WxVfa8WCZ = 0.0;
      this.pudq36ntP = 0;
    }

    
    public void SetWeightVector(double[] WeightVector)
    {
      for (int i = 0; i < this.GetNWeights(); ++i)
        this.GetWeight(i).Weight = WeightVector[i];
    }

    
    public double[] GetWeightVector()
    {
      double[] numArray = new double[this.GetNWeights()];
      for (int i = 0; i < this.GetNWeights(); ++i)
        numArray[i] = this.GetWeight(i).Weight;
      return numArray;
    }

    
    public override double Activation(double x)
    {
      return x;
    }

    
    public double GetNeighborhoodFunction(TKohonenNeuron Neuron)
    {
      if (Neuron == this)
        return 1.0;
      double distance = this.GetDistance(Neuron);
      double neighborhoodRadius = this.vOHKkfFcp.NeighborhoodRadius;
      switch (this.vOHKkfFcp.Kernel)
      {
        case EKohonenKernel.Bubble:
          return distance <= neighborhoodRadius ? 1.0 : 0.0;
        case EKohonenKernel.Gauss:
          return Math.Exp(-distance * distance / (neighborhoodRadius * neighborhoodRadius));
        default:
          return 0.0;
      }
    }

    
    public double GetDistance(TKohonenNeuron Neuron)
    {
      if (Neuron == this)
        return 0.0;
      else
        return Math.Sqrt((double) ((this.WKXIlHax4 - Neuron.Col) * (this.WKXIlHax4 - Neuron.Col) + (this.uiQQufIMH - Neuron.Row) * (this.uiQQufIMH - Neuron.Row)));
    }

    
    public void Update(TKohonenNeuron Neuron)
    {
      double neighborhoodFunction = this.GetNeighborhoodFunction(Neuron);
      foreach (TNeuralWeight tneuralWeight in this.weights)
        tneuralWeight.Weight = tneuralWeight.Weight + this.vOHKkfFcp.LearningRate * neighborhoodFunction * (tneuralWeight.GetInput() - tneuralWeight.Weight);
    }

    
    public double GetError()
    {
      double d = 0.0;
      foreach (TNeuralWeight tneuralWeight in this.weights)
        d += (tneuralWeight.Weight - tneuralWeight.GetInput()) * (tneuralWeight.Weight - tneuralWeight.GetInput());
      return Math.Sqrt(d);
    }

    
    public void ResetWin()
    {
      this.WxVfa8WCZ = 0.0;
      this.pudq36ntP = 0;
    }

    
    public void SetWin(double Win)
    {
      this.WxVfa8WCZ = Win;
    }

    
    public void SetNWins(int NWins)
    {
      this.pudq36ntP = NWins;
    }

    
    public void AddWin(double Win)
    {
      this.WxVfa8WCZ += Win;
      ++this.pudq36ntP;
    }

    
    public double GetWin()
    {
      return this.WxVfa8WCZ;
    }

    
    public int GetNWins()
    {
      return this.pudq36ntP;
    }
  }
}
