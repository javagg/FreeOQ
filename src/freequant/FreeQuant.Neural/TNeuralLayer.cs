using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Neural
{
  [Serializable]
  public class TNeuralLayer
  {
    protected int fNNeuron;
    protected ArrayList fNeuron;
    protected bool fEnabled;

    public bool Enabled
    {
       get
      {
        return this.fEnabled;
      }
       set
      {
        this.fEnabled = value;
        foreach (TNeuron tneuron in this.fNeuron)
          tneuron.Enabled = this.fEnabled;
      }
    }

    
    public TNeuralLayer()
    {
      this.fNeuron = new ArrayList();
      this.fNNeuron = 0;
      this.fEnabled = true;
    }

    
    public int GetNNeuron()
    {
      return this.fNNeuron;
    }

    
    public TNeuron GetNeuron(int i)
    {
      return (TNeuron) this.fNeuron[i];
    }

    
    public void Connect(TNeuralLayer Layer)
    {
      foreach (TNeuron tneuron in this.fNeuron)
      {
        foreach (TNeuron Neuron in Layer.fNeuron)
          tneuron.Connect(Neuron);
      }
    }

    
    public void Disconnect(TNeuralLayer Layer)
    {
      foreach (TNeuron tneuron in this.fNeuron)
      {
        foreach (TNeuron Neuron in Layer.fNeuron)
          tneuron.Disconnect(Neuron);
      }
    }

    
    public virtual void ProcessInput(int Option)
    {
      foreach (TNeuron tneuron in this.fNeuron)
        tneuron.ProcessInput(Option);
    }

    
    public virtual void ProcessInput()
    {
      this.ProcessInput(0);
    }

    
    public virtual void ProcessError(int Option)
    {
      foreach (TNeuron tneuron in this.fNeuron)
        tneuron.ProcessError(Option);
    }

    
    public virtual void ProcessError()
    {
      this.ProcessError(0);
    }

    
    public void SetName(int i, string Name)
    {
      this.GetNeuron(i).Name = Name;
    }

    
    public string GetName(int i)
    {
      return this.GetNeuron(i).Name;
    }

    
    public virtual void Update()
    {
      foreach (TNeuron tneuron in this.fNeuron)
        tneuron.Update();
    }
  }
}
