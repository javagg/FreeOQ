using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Neural
{
  [Serializable]
  public class TThresholdNeuron : TNeuron
  {
    
		public TThresholdNeuron():base()
    {
      this.output = 1.0;
    }

    
    public override void Connect(TNeuron Neuron)
    {
    }

    
    public override void Disconnect(TNeuron Neuron)
    {
    }

    
    public override void ProcessInput(int Option)
    {
      this.output = 1.0;
    }

    
    public override void ProcessError(int Option)
    {
    }

    
    public override void Update()
    {
    }
  }
}
