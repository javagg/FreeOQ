using System;
using System.Collections;

namespace FreeQuant.Neural
{
  [Serializable]
  public class TNeuron
  {
    protected int id;
    protected ArrayList weights;
    protected double input;
    protected double output;
    protected double error;
    protected bool enabled;
    protected string name;

    public int ID
    {
      get
      {
        return this.id;
      }
      set
      {
        this.id = value;
      }
    }

    public double Input
    {
       get
      {
        return this.input;
      }
       set
      {
        this.input = value;
      }
    }

    public double Output
    {
      get
      {
        return this.output;
      }
       set
      {
        this.output = value;
      }
    }

    public double Error
    {
        get
      {
        return this.error;
      }
       set
      {
        this.error = value;
      }
    }

    public bool Enabled
    {
        get
      {
        return this.enabled;
      }
       set
      {
        this.enabled = value;
      }
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.name;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.name = value;
      }
    }

    public TNeuron()
    {
      this.id = -1;
      this.weights = new ArrayList();
      this.input = 0.0;
      this.output = 0.0;
      this.error = 0.0;
      this.enabled = true;
      TNeuralNetwork.Network.AddNeuron(this);
    }

    public virtual void Connect(TNeuron Neuron)
    {
      this.weights.Add((object) new TNeuralWeight(Neuron));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Disconnect(TNeuron Neuron)
    {
      foreach (TNeuralWeight tneuralWeight in this.weights)
      {
        if (tneuralWeight.Neuron == Neuron)
        {
          this.weights.Remove((object) tneuralWeight);
          break;
        }
      }
    }

    public virtual double GetOutput()
    {
      if (this.enabled)
        return this.output;
      else
        return 0.0;
    }

    public virtual void ProcessInput(int Option)
    {
      this.input = 0.0;
      foreach (TNeuralWeight tneuralWeight in this.weights)
        this.input += tneuralWeight.PropagateInput();
      this.output = this.Activation(this.input);
    }

    public virtual void ProcessInput()
    {
      this.ProcessInput(0);
    }

    public virtual void ProcessError(int Option)
    {
      this.error *= this.Gradient(this.input);
      foreach (TNeuralWeight tneuralWeight in this.weights)
        tneuralWeight.PropagateError(this.error);
    }

    public virtual void ProcessError()
    {
      this.ProcessError(0);
    }

    public virtual void Update()
    {
      foreach (TNeuralWeight tneuralWeight in this.weights)
        tneuralWeight.Update(this.error);
      this.error = 0.0;
    }

    public TNeuralWeight GetMinWeight()
    {
      if (this.weights.Count == 0)
        return (TNeuralWeight) null;
      TNeuralWeight tneuralWeight1 = (TNeuralWeight) this.weights[0];
      double weight = tneuralWeight1.Weight;
      foreach (TNeuralWeight tneuralWeight2 in this.weights)
      {
        if (tneuralWeight2.Weight < weight)
        {
          tneuralWeight1 = tneuralWeight2;
          weight = tneuralWeight2.Weight;
        }
      }
      return tneuralWeight1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralWeight GetMaxWeight()
    {
      if (this.weights.Count == 0)
        return (TNeuralWeight) null;
      TNeuralWeight tneuralWeight1 = (TNeuralWeight) this.weights[0];
      double weight = tneuralWeight1.Weight;
      foreach (TNeuralWeight tneuralWeight2 in this.weights)
      {
        if (tneuralWeight2.Weight > weight)
        {
          tneuralWeight1 = tneuralWeight2;
          weight = tneuralWeight2.Weight;
        }
      }
      return tneuralWeight1;
    }

    public void RandomizeWeights()
    {
      foreach (TNeuralWeight tneuralWeight in this.weights)
        tneuralWeight.Randomize();
    }

    public void NormalizeWeights()
    {
      double d = 0.0;
      foreach (TNeuralWeight tneuralWeight in this.weights)
        d += tneuralWeight.Weight * tneuralWeight.Weight;
      double num = Math.Sqrt(d);
      if (num != 0.0)
      {
        foreach (TNeuralWeight tneuralWeight in this.weights)
          tneuralWeight.Weight = tneuralWeight.Weight / num;
      }
      else
      {
        this.RandomizeWeights();
        this.NormalizeWeights();
      }
    }

    public void StoreWeights()
    {
      foreach (TNeuralWeight tneuralWeight in this.weights)
        tneuralWeight.Store();
    }

    public void RestoreWeights()
    {
      foreach (TNeuralWeight tneuralWeight in this.weights)
        tneuralWeight.Restore();
    }

    public void SetError(double Error)
    {
      this.error = Error;
    }

    public void AddError(double Error)
    {
      this.error += Error;
    }

    public int GetNWeights()
    {
      return this.weights.Count;
    }

    public TNeuralWeight GetWeight(int i)
    {
      return (TNeuralWeight) this.weights[i];
    }

    public virtual double Activation(double x)
    {
      return x;
    }

    public virtual double Gradient(double x)
    {
      return 1.0;
    }
  }
}
