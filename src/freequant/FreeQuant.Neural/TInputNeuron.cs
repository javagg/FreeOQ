using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Neural
{
  [Serializable]
  public class TInputNeuron : TNeuron
  {
    public override void ProcessInput(int Option)
    {
      this.output = this.Activation(this.input);
    }
  }
}
