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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fEnabled = value;
        foreach (TNeuron tneuron in this.fNeuron)
          tneuron.Enabled = this.fEnabled;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralLayer()
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fNeuron = new ArrayList();
      this.fNNeuron = 0;
      this.fEnabled = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetNNeuron()
    {
      return this.fNNeuron;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuron GetNeuron(int i)
    {
      return (TNeuron) this.fNeuron[i];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Connect(TNeuralLayer Layer)
    {
      foreach (TNeuron tneuron in this.fNeuron)
      {
        foreach (TNeuron Neuron in Layer.fNeuron)
          tneuron.Connect(Neuron);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Disconnect(TNeuralLayer Layer)
    {
      foreach (TNeuron tneuron in this.fNeuron)
      {
        foreach (TNeuron Neuron in Layer.fNeuron)
          tneuron.Disconnect(Neuron);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ProcessInput(int Option)
    {
      foreach (TNeuron tneuron in this.fNeuron)
        tneuron.ProcessInput(Option);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ProcessInput()
    {
      this.ProcessInput(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ProcessError(int Option)
    {
      foreach (TNeuron tneuron in this.fNeuron)
        tneuron.ProcessError(Option);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ProcessError()
    {
      this.ProcessError(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetName(int i, string Name)
    {
      this.GetNeuron(i).Name = Name;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetName(int i)
    {
      return this.GetNeuron(i).Name;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Update()
    {
      foreach (TNeuron tneuron in this.fNeuron)
        tneuron.Update();
    }
  }
}
