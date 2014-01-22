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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WKXIlHax4;
      }
    }

    public int Row
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.uiQQufIMH;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TKohonenNeuron()
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.WxVfa8WCZ = 0.0;
      this.pudq36ntP = 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TKohonenNeuron(TKohonenMap Map, int Col, int Row)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.vOHKkfFcp = Map;
      this.WKXIlHax4 = Col;
      this.uiQQufIMH = Row;
      this.WxVfa8WCZ = 0.0;
      this.pudq36ntP = 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetWeightVector(double[] WeightVector)
    {
      for (int i = 0; i < this.GetNWeights(); ++i)
        this.GetWeight(i).Weight = WeightVector[i];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double[] GetWeightVector()
    {
      double[] numArray = new double[this.GetNWeights()];
      for (int i = 0; i < this.GetNWeights(); ++i)
        numArray[i] = this.GetWeight(i).Weight;
      return numArray;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double Activation(double x)
    {
      return x;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetDistance(TKohonenNeuron Neuron)
    {
      if (Neuron == this)
        return 0.0;
      else
        return Math.Sqrt((double) ((this.WKXIlHax4 - Neuron.Col) * (this.WKXIlHax4 - Neuron.Col) + (this.uiQQufIMH - Neuron.Row) * (this.uiQQufIMH - Neuron.Row)));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update(TKohonenNeuron Neuron)
    {
      double neighborhoodFunction = this.GetNeighborhoodFunction(Neuron);
      foreach (TNeuralWeight tneuralWeight in this.weights)
        tneuralWeight.Weight = tneuralWeight.Weight + this.vOHKkfFcp.LearningRate * neighborhoodFunction * (tneuralWeight.GetInput() - tneuralWeight.Weight);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetError()
    {
      double d = 0.0;
      foreach (TNeuralWeight tneuralWeight in this.weights)
        d += (tneuralWeight.Weight - tneuralWeight.GetInput()) * (tneuralWeight.Weight - tneuralWeight.GetInput());
      return Math.Sqrt(d);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetWin()
    {
      this.WxVfa8WCZ = 0.0;
      this.pudq36ntP = 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetWin(double Win)
    {
      this.WxVfa8WCZ = Win;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNWins(int NWins)
    {
      this.pudq36ntP = NWins;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddWin(double Win)
    {
      this.WxVfa8WCZ += Win;
      ++this.pudq36ntP;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetWin()
    {
      return this.WxVfa8WCZ;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetNWins()
    {
      return this.pudq36ntP;
    }
  }
}
