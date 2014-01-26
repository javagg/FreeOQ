using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Neural
{
  [Serializable]
  public class TOutputNeuron : TNeuron
  {
    private EActivationMode dwvXwyWh8;

    
		public TOutputNeuron(): base()
    {

      this.dwvXwyWh8 = EActivationMode.Approximation;
    }

    
		public TOutputNeuron(EActivationMode Mode): base()
    {
      this.dwvXwyWh8 = Mode;
    }

    [SpecialName]
    
    private EActivationMode pC6WUCL6n()
    {
      return this.dwvXwyWh8;
    }

    [SpecialName]
    
    private void cXt5bimqX(EActivationMode value)
    {
      this.dwvXwyWh8 = value;
    }

    
    public override double Activation(double x)
    {
      switch (this.dwvXwyWh8)
      {
        case EActivationMode.Approximation:
          return x;
        case EActivationMode.Classification:
          return 1.0 / (1.0 + Math.Exp(-2.0 * x));
        default:
          return 0.0;
      }
    }

    
    public override double Gradient(double x)
    {
      switch (this.dwvXwyWh8)
      {
        case EActivationMode.Approximation:
          return 1.0;
        case EActivationMode.Classification:
          double num = Math.Exp(-2.0 * x);
          return 2.0 * num / ((1.0 + num) * (1.0 + num));
        default:
          return 0.0;
      }
    }
  }
}
