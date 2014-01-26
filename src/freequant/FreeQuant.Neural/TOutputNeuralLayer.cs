using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Neural
{
  [Serializable]
  public class TOutputNeuralLayer : TNeuralLayer
  {
    private double[] DLIlOx3mN;
    private EActivationMode AGFR7NSDt;

    
		public TOutputNeuralLayer():base()
    {
      this.AGFR7NSDt = EActivationMode.Approximation;
    }

    
		public TOutputNeuralLayer(int NNeuron, EActivationMode Mode):base()
    {
      this.AGFR7NSDt = Mode;
      for (int index = 0; index < NNeuron; ++index)
        this.fNeuron.Add((object) new TOutputNeuron(this.AGFR7NSDt));
      this.DLIlOx3mN = new double[NNeuron];
      this.fNNeuron = NNeuron;
    }

    
    public double[] GetOutput()
    {
      for (int index = 0; index < this.fNNeuron; ++index)
        this.DLIlOx3mN[index] = ((TNeuron) this.fNeuron[index]).Output;
      return this.DLIlOx3mN;
    }

    
    public void FeedError(double[] Error)
    {
      for (int index = 0; index < this.fNNeuron; ++index)
        ((TNeuron) this.fNeuron[index]).Error = Error[index];
    }
  }
}
