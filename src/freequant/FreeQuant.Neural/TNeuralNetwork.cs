// Type: SmartQuant.Neural.TNeuralNetwork
// Assembly: SmartQuant.Neural, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: E5DFC29A-4534-4F54-827A-AC305F5F2864
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Neural.dll

using aq250XLTtWVBJufbvY;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Neural
{
  [Serializable]
  public class TNeuralNetwork
  {
    protected string fName;
    protected string fTitle;
    protected int fNInput;
    protected int fNOutput;
    protected bool fIsEnabled;
    protected ELearningMethod fLearningMethod;
    protected int fNBatch;
    protected int fNPattern;
    protected EWeightInitMode fInitMode;
    protected bool fDebugMode;
    protected EStoppingMethod fSMethod;
    protected double fSParameter;
    protected int fNGraphUpdate;
    protected int fMaxNX;
    protected int fMaxNY;
    private double DFX6Ht5lO;
    private double HOaZ3SwNl;
    private TNeuralWeight EGtFBCxEX;
    private TNeuralWeight hG4PgBLCK;
    private TNeuron ahkE1lI8Y;
    private TNeuron Vlon5OFCQ;
    private bool KCL7WIToG;
    private bool u25o0XTtW;
    protected EViewMode fViewMode;
    protected double[] fInput;
    protected double[] fOutput;
    protected double[] fTarget;
    protected ArrayList fNeuron;
    protected ArrayList fWeight;
    protected TNeuralLayer fInputLayer;
    protected TNeuralLayer fOutputLayer;
    private static TNeuralNetwork cBJeufbvY;
    protected double fLearningRate;
    protected double fMomentum;
    protected double fWeightDecay;
    protected double fMaximumGrowth;
    protected double fRpropDeltaInit;
    protected double fRpropDeltaMin;
    protected double fRpropDeltaMax;
    protected double fRpropDecrease;
    protected double fRpropIncrease;

    public static TNeuralNetwork Network
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return TNeuralNetwork.cBJeufbvY;
      }
    }

    public EWeightInitMode InitMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fInitMode;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fInitMode = value;
      }
    }

    public ELearningMethod LearningMethod
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fLearningMethod;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fLearningMethod = value;
      }
    }

    public double[] Input
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

    public double[] Output
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

    public double[] Target
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTarget;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTarget = value;
      }
    }

    public int NBatch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fNBatch;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fNBatch = value;
      }
    }

    public int NPattern
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fNPattern;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fNPattern = value;
      }
    }

    public double LearningRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fLearningRate;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fLearningRate = value;
      }
    }

    public double Momentum
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMomentum;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMomentum = value;
      }
    }

    public double WeightDecay
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fWeightDecay;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fWeightDecay = value;
      }
    }

    public double MaximumGrowth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMaximumGrowth;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMaximumGrowth = value;
      }
    }

    public double RpropDeltaInit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fRpropDeltaInit;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fRpropDeltaInit = value;
      }
    }

    public double RpropDeltaMin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fRpropDeltaMin;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fRpropDeltaMin = value;
      }
    }

    public double RpropDeltaMax
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fRpropDeltaMax;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fRpropDeltaMax = value;
      }
    }

    public double RpropDecrease
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fRpropDecrease;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fRpropDecrease = value;
      }
    }

    public double RpropIncrease
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fRpropIncrease;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fRpropIncrease = value;
      }
    }

    public TNeuralLayer InputLayer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fInputLayer;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fInputLayer = value;
      }
    }

    public TNeuralLayer OutputLayer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fOutputLayer;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fOutputLayer = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralNetwork()
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fNInput = 0;
      this.fNOutput = 0;
      this.OhqpGGWfa();
      TNeuralNetwork.cBJeufbvY = this;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralNetwork(string Name, string Title)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fName = Name;
      this.fTitle = Title;
      this.fNInput = 0;
      this.fNOutput = 0;
      this.OhqpGGWfa();
      TNeuralNetwork.cBJeufbvY = this;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralNetwork(string Name)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fName = Name;
      this.fNInput = 0;
      this.fNOutput = 0;
      this.OhqpGGWfa();
      TNeuralNetwork.cBJeufbvY = this;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OhqpGGWfa()
    {
      this.fNeuron = new ArrayList();
      this.fWeight = new ArrayList();
      this.fLearningRate = 0.01;
      this.fMomentum = 0.01;
      this.fMaximumGrowth = 1.75;
      this.fWeightDecay = 0.0;
      this.fRpropDeltaInit = 0.1;
      this.fRpropDeltaMin = 1E-06;
      this.fRpropDeltaMax = 50.0;
      this.fRpropDecrease = 0.5;
      this.fRpropIncrease = 1.2;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNeuron(TNeuron Neuron)
    {
      if (Neuron.ID != -1)
        return;
      int num = this.fNeuron.Add((object) Neuron);
      Neuron.ID = num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddWeight(TNeuralWeight Weight)
    {
      if (this.fWeight.IndexOf((object) Weight) == -1)
        return;
      this.fWeight.Add((object) Weight);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Reset()
    {
      this.ResetWeights();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetWeights()
    {
      this.RandomizeWeights();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RandomizeWeights(int Option)
    {
      if (Option != 0)
      {
        SmartQuant.Quant.Random.Seed1 = this.DFX6Ht5lO;
        SmartQuant.Quant.Random.Seed2 = this.HOaZ3SwNl;
      }
      else
      {
        this.DFX6Ht5lO = SmartQuant.Quant.Random.Seed1;
        this.HOaZ3SwNl = SmartQuant.Quant.Random.Seed2;
      }
      foreach (TNeuron tneuron in this.fNeuron)
        tneuron.RandomizeWeights();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RandomizeWeights()
    {
      this.RandomizeWeights(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StoreWeights()
    {
      foreach (TNeuron tneuron in this.fNeuron)
        tneuron.StoreWeights();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RestoreWeights()
    {
      foreach (TNeuron tneuron in this.fNeuron)
        tneuron.RestoreWeights();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralWeight GetMinWeight()
    {
      if (this.KCL7WIToG)
      {
        double num = 10000000000.0;
        foreach (TNeuron tneuron in this.fNeuron)
        {
          TNeuralWeight minWeight = tneuron.GetMinWeight();
          if (minWeight != null && minWeight.Weight < num)
          {
            this.ahkE1lI8Y = tneuron;
            this.EGtFBCxEX = minWeight;
            num = minWeight.Weight;
          }
        }
        this.KCL7WIToG = false;
      }
      return this.EGtFBCxEX;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralWeight GetMaxWeight()
    {
      if (this.u25o0XTtW)
      {
        double num = -10000000000.0;
        foreach (TNeuron tneuron in this.fNeuron)
        {
          TNeuralWeight maxWeight = tneuron.GetMaxWeight();
          if (maxWeight != null && maxWeight.Weight > num)
          {
            this.Vlon5OFCQ = tneuron;
            this.hG4PgBLCK = maxWeight;
            num = maxWeight.Weight;
          }
        }
        this.u25o0XTtW = false;
      }
      return this.hG4PgBLCK;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuron GetMinWeightNeuron()
    {
      this.GetMinWeight();
      return this.ahkE1lI8Y;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuron GetMaxWeightNeuron()
    {
      this.GetMaxWeight();
      return this.Vlon5OFCQ;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Prune()
    {
      this.ahkE1lI8Y.Disconnect(this.GetMinWeight().Neuron);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Connect(TNeuralNetwork Network)
    {
      this.fInputLayer.Connect(Network.OutputLayer);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void cd()
    {
      TNeuralNetwork.cBJeufbvY = this;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetStopping(EStoppingMethod SCriterion, double SParameter)
    {
      this.fSMethod = SCriterion;
      this.fSParameter = SParameter;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Update(int Param)
    {
      this.KCL7WIToG = true;
      this.u25o0XTtW = true;
    }
  }
}
