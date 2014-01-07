// Type: SmartQuant.Neural.TNeuron
// Assembly: SmartQuant.Neural, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: E5DFC29A-4534-4F54-827A-AC305F5F2864
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Neural.dll

using aq250XLTtWVBJufbvY;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Neural
{
  [Serializable]
  public class TNeuron
  {
    protected int fID;
    protected ArrayList fWeight;
    protected double fInput;
    protected double fOutput;
    protected double fError;
    protected bool fEnabled;
    protected string fName;

    public int ID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fID;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fID = value;
      }
    }

    public double Input
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fInput;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fInput = value;
      }
    }

    public double Output
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fOutput;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fOutput = value;
      }
    }

    public double Error
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fError;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fError = value;
      }
    }

    public bool Enabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fEnabled = value;
      }
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fName;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fName = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuron()
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fID = -1;
      this.fWeight = new ArrayList();
      this.fInput = 0.0;
      this.fOutput = 0.0;
      this.fError = 0.0;
      this.fEnabled = true;
      TNeuralNetwork.Network.AddNeuron(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Connect(TNeuron Neuron)
    {
      this.fWeight.Add((object) new TNeuralWeight(Neuron));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Disconnect(TNeuron Neuron)
    {
      foreach (TNeuralWeight tneuralWeight in this.fWeight)
      {
        if (tneuralWeight.Neuron == Neuron)
        {
          this.fWeight.Remove((object) tneuralWeight);
          break;
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetOutput()
    {
      if (this.fEnabled)
        return this.fOutput;
      else
        return 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ProcessInput(int Option)
    {
      this.fInput = 0.0;
      foreach (TNeuralWeight tneuralWeight in this.fWeight)
        this.fInput += tneuralWeight.PropagateInput();
      this.fOutput = this.Activation(this.fInput);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ProcessInput()
    {
      this.ProcessInput(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ProcessError(int Option)
    {
      this.fError *= this.Gradient(this.fInput);
      foreach (TNeuralWeight tneuralWeight in this.fWeight)
        tneuralWeight.PropagateError(this.fError);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ProcessError()
    {
      this.ProcessError(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Update()
    {
      foreach (TNeuralWeight tneuralWeight in this.fWeight)
        tneuralWeight.Update(this.fError);
      this.fError = 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralWeight GetMinWeight()
    {
      if (this.fWeight.Count == 0)
        return (TNeuralWeight) null;
      TNeuralWeight tneuralWeight1 = (TNeuralWeight) this.fWeight[0];
      double weight = tneuralWeight1.Weight;
      foreach (TNeuralWeight tneuralWeight2 in this.fWeight)
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
      if (this.fWeight.Count == 0)
        return (TNeuralWeight) null;
      TNeuralWeight tneuralWeight1 = (TNeuralWeight) this.fWeight[0];
      double weight = tneuralWeight1.Weight;
      foreach (TNeuralWeight tneuralWeight2 in this.fWeight)
      {
        if (tneuralWeight2.Weight > weight)
        {
          tneuralWeight1 = tneuralWeight2;
          weight = tneuralWeight2.Weight;
        }
      }
      return tneuralWeight1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RandomizeWeights()
    {
      foreach (TNeuralWeight tneuralWeight in this.fWeight)
        tneuralWeight.Randomize();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void NormalizeWeights()
    {
      double d = 0.0;
      foreach (TNeuralWeight tneuralWeight in this.fWeight)
        d += tneuralWeight.Weight * tneuralWeight.Weight;
      double num = Math.Sqrt(d);
      if (num != 0.0)
      {
        foreach (TNeuralWeight tneuralWeight in this.fWeight)
          tneuralWeight.Weight = tneuralWeight.Weight / num;
      }
      else
      {
        this.RandomizeWeights();
        this.NormalizeWeights();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StoreWeights()
    {
      foreach (TNeuralWeight tneuralWeight in this.fWeight)
        tneuralWeight.Store();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RestoreWeights()
    {
      foreach (TNeuralWeight tneuralWeight in this.fWeight)
        tneuralWeight.Restore();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetError(double Error)
    {
      this.fError = Error;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddError(double Error)
    {
      this.fError += Error;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetNWeights()
    {
      return this.fWeight.Count;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralWeight GetWeight(int i)
    {
      return (TNeuralWeight) this.fWeight[i];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Activation(double x)
    {
      return x;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Gradient(double x)
    {
      return 1.0;
    }
  }
}
