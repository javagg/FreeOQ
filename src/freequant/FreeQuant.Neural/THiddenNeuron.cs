using System;

namespace FreeQuant.Neural
{
  [Serializable]
  public class THiddenNeuron : TNeuron
  {
    public override double Activation(double x)
    {
      return Math.Tanh(x);
    }

    public override double Gradient(double x)
    {
      double num = Math.Tanh(x);
      return 1.0 - num * num;
    }
  }
}
