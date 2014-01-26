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
       get
      {
        return TNeuralNetwork.cBJeufbvY;
      }
    }

    public EWeightInitMode InitMode
    {
       get
      {
        return this.fInitMode;
      }
       set
      {
        this.fInitMode = value;
      }
    }

    public ELearningMethod LearningMethod
    {
       get
      {
        return this.fLearningMethod;
      }
       set
      {
        this.fLearningMethod = value;
      }
    }

    public double[] Input
    {
       get
      {
        return this.fInput;
      }
       set
      {
        this.fInput = value;
      }
    }

    public double[] Output
    {
       get
      {
        return this.fOutput;
      }
       set
      {
        this.fOutput = value;
      }
    }

    public double[] Target
    {
       get
      {
        return this.fTarget;
      }
       set
      {
        this.fTarget = value;
      }
    }

    public int NBatch
    {
       get
      {
        return this.fNBatch;
      }
       set
      {
        this.fNBatch = value;
      }
    }

    public int NPattern
    {
       get
      {
        return this.fNPattern;
      }
       set
      {
        this.fNPattern = value;
      }
    }

    public double LearningRate
    {
       get
      {
        return this.fLearningRate;
      }
       set
      {
        this.fLearningRate = value;
      }
    }

    public double Momentum
    {
       get
      {
        return this.fMomentum;
      }
       set
      {
        this.fMomentum = value;
      }
    }

    public double WeightDecay
    {
       get
      {
        return this.fWeightDecay;
      }
       set
      {
        this.fWeightDecay = value;
      }
    }

    public double MaximumGrowth
    {
       get
      {
        return this.fMaximumGrowth;
      }
       set
      {
        this.fMaximumGrowth = value;
      }
    }

    public double RpropDeltaInit
    {
       get
      {
        return this.fRpropDeltaInit;
      }
       set
      {
        this.fRpropDeltaInit = value;
      }
    }

    public double RpropDeltaMin
    {
       get
      {
        return this.fRpropDeltaMin;
      }
       set
      {
        this.fRpropDeltaMin = value;
      }
    }

    public double RpropDeltaMax
    {
       get
      {
        return this.fRpropDeltaMax;
      }
       set
      {
        this.fRpropDeltaMax = value;
      }
    }

    public double RpropDecrease
    {
       get
      {
        return this.fRpropDecrease;
      }
       set
      {
        this.fRpropDecrease = value;
      }
    }

    public double RpropIncrease
    {
       get
      {
        return this.fRpropIncrease;
      }
       set
      {
        this.fRpropIncrease = value;
      }
    }

    public TNeuralLayer InputLayer
    {
       get
      {
        return this.fInputLayer;
      }
       set
      {
        this.fInputLayer = value;
      }
    }

    public TNeuralLayer OutputLayer
    {
       get
      {
        return this.fOutputLayer;
      }
       set
      {
        this.fOutputLayer = value;
      }
    }

    
    public TNeuralNetwork()
    {
      this.fNInput = 0;
      this.fNOutput = 0;
      this.OhqpGGWfa();
      TNeuralNetwork.cBJeufbvY = this;
    }

    
    public TNeuralNetwork(string Name, string Title)
    {
      this.fName = Name;
      this.fTitle = Title;
      this.fNInput = 0;
      this.fNOutput = 0;
      this.OhqpGGWfa();
      TNeuralNetwork.cBJeufbvY = this;
    }

    
    public TNeuralNetwork(string Name)
    {
      this.fName = Name;
      this.fNInput = 0;
      this.fNOutput = 0;
      this.OhqpGGWfa();
      TNeuralNetwork.cBJeufbvY = this;
    }

    
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

    
    public void AddNeuron(TNeuron Neuron)
    {
      if (Neuron.ID != -1)
        return;
      int num = this.fNeuron.Add((object) Neuron);
      Neuron.ID = num;
    }

    
    public void AddWeight(TNeuralWeight Weight)
    {
      if (this.fWeight.IndexOf((object) Weight) == -1)
        return;
      this.fWeight.Add((object) Weight);
    }

    
    public virtual void Reset()
    {
      this.ResetWeights();
    }

    
    public void ResetWeights()
    {
      this.RandomizeWeights();
    }

    
    public void RandomizeWeights(int Option)
    {
      if (Option != 0)
      {
        FreeQuant.Quant.Random.Seed1 = this.DFX6Ht5lO;
        FreeQuant.Quant.Random.Seed2 = this.HOaZ3SwNl;
      }
      else
      {
        this.DFX6Ht5lO = FreeQuant.Quant.Random.Seed1;
        this.HOaZ3SwNl = FreeQuant.Quant.Random.Seed2;
      }
      foreach (TNeuron tneuron in this.fNeuron)
        tneuron.RandomizeWeights();
    }

    
    public void RandomizeWeights()
    {
      this.RandomizeWeights(0);
    }

    
    public void StoreWeights()
    {
      foreach (TNeuron tneuron in this.fNeuron)
        tneuron.StoreWeights();
    }

    
    public void RestoreWeights()
    {
      foreach (TNeuron tneuron in this.fNeuron)
        tneuron.RestoreWeights();
    }

    
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

    
    public TNeuron GetMinWeightNeuron()
    {
      this.GetMinWeight();
      return this.ahkE1lI8Y;
    }

    
    public TNeuron GetMaxWeightNeuron()
    {
      this.GetMaxWeight();
      return this.Vlon5OFCQ;
    }

    
    public void Prune()
    {
      this.ahkE1lI8Y.Disconnect(this.GetMinWeight().Neuron);
    }

    
    public void Connect(TNeuralNetwork Network)
    {
      this.fInputLayer.Connect(Network.OutputLayer);
    }

    
    public void cd()
    {
      TNeuralNetwork.cBJeufbvY = this;
    }

    
    public void SetStopping(EStoppingMethod SCriterion, double SParameter)
    {
      this.fSMethod = SCriterion;
      this.fSParameter = SParameter;
    }

    
    public virtual void Update(int Param)
    {
      this.KCL7WIToG = true;
      this.u25o0XTtW = true;
    }
  }
}
