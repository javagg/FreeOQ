// Type: SmartQuant.Optimization.Optimizer
using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Optimization
{
  public abstract class Optimizer : ParamSet
  {
    protected bool stopped;
    protected IOptimizable fOptimizable;
    protected EOptimizerType fType;
    protected int fNParamSubset;
    protected int fNObjectiveCalls;
    protected EVerboseMode fVerboseMode;
    protected double fLastObjective;
    protected SortedList[] optimal1DList;
    protected Hashtable[,] optimal2DList;

    [Browsable(false)]
    public SortedList[] Optimal1DList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.optimal1DList;
      }
    }

    [Browsable(false)]
    public Hashtable[,] Optimal2DList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.optimal2DList;
      }
    }

    [Browsable(false)]
    public double LastObjective
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fLastObjective;
      }
    }

    [Browsable(false)]
    public virtual int NObjectiveCalls
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fNObjectiveCalls;
      }
    }

    [Browsable(false)]
    public IOptimizable Object
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fOptimizable;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fOptimizable = value;
        this.fOptimizable.Init((ParamSet) this);
      }
    }

    [Browsable(false)]
    public int NParamSubset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fNParamSubset;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fNParamSubset = value;
      }
    }

    [Category("Description")]
    [Description("Optimizer type")]
    public EOptimizerType OptimizerType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fType;
      }
    }

    [Description("Console output mode")]
    [Category("Output")]
    public EVerboseMode VerboseMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fVerboseMode;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fVerboseMode = value;
      }
    }

    public event EventHandler Inited;

    public event EventHandler CircleCalled;

    public event EventHandler StepCalled;

    public event EventHandler UpdateCalled;

    public event EventHandler ObjectiveCalled;

    public event EventHandler OptimizationCompleted;

    public event EventHandler BestObjectiveReceived;

	public Optimizer(IOptimizable Object) : base()
    {

      this.fOptimizable = Object;
      this.a6dDUjNQ6();
    }

    private void a6dDUjNQ6()
    {
      this.fType = EOptimizerType.Optimizer;
      this.fNParamSubset = 0;
      this.fNObjectiveCalls = 0;
      this.fVerboseMode = EVerboseMode.Quiet;
      this.fLastObjective = 0.0;
    }

    public int GetNParamSubset()
    {
      return this.fNParamSubset;
    }

    public void SetNParamSubset(int NParamSubset)
    {
      this.fNParamSubset = NParamSubset;
    }

    public virtual void Optimize()
    {
      this.stopped = false;
      this.fOptimizable.Init((ParamSet) this);
      this.fNParamSubset = this.GetNParam();
      this.fNObjectiveCalls = 0;
      this.optimal1DList = new SortedList[this.fNParamSubset];
      this.optimal2DList = new Hashtable[this.fNParamSubset, this.fNParamSubset];
      for (int index = 0; index < this.fNParamSubset; ++index)
        this.optimal1DList[index] = new SortedList();
      for (int index1 = 0; index1 < this.fNParamSubset; ++index1)
      {
        for (int index2 = 0; index2 < this.fNParamSubset; ++index2)
          this.optimal2DList[index1, index2] = new Hashtable();
      }
      if (this.YE5X4qsts == null)
        return;
      this.YE5X4qsts((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Objective()
    {
      ++this.fNObjectiveCalls;
      if (this.fOptimizable == null)
        return double.NaN;
      double num = this.fOptimizable.Objective();
      this.fLastObjective = num;
      if (this.ewWNFr3xJ != null)
        this.ewWNFr3xJ((object) this, EventArgs.Empty);
      for (int index1 = 0; index1 < this.fNParamSubset; ++index1)
      {
        double d1 = this[index1];
        if (!double.IsNaN(d1))
        {
          if (!this.optimal1DList[index1].ContainsKey((object) d1) || (double) this.optimal1DList[index1][(object) d1] > num)
            this.optimal1DList[index1][(object) d1] = (object) num;
          for (int index2 = index1 + 1; index2 < this.fNParamSubset; ++index2)
          {
            double d2 = this[index2];
            if (!double.IsNaN(d2) && (!this.optimal2DList[index1, index2].ContainsKey((object) new TwoParams(d1, d2)) || (double) this.optimal2DList[index1, index2][(object) new TwoParams(d1, d2)] > num))
              this.optimal2DList[index1, index2][(object) new TwoParams(d1, d2)] = (object) num;
          }
        }
      }
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnStep()
    {
      if (this.fOptimizable == null)
        return;
      this.fOptimizable.OnStep();
      if (this.Ragi6Xbmw == null)
        return;
      this.Ragi6Xbmw((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnCircle()
    {
      if (this.fOptimizable == null)
        return;
      this.fOptimizable.OnCircle();
      if (this.kWMpbkyoR == null)
        return;
      this.kWMpbkyoR((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Update()
    {
      if (this.fOptimizable == null)
        return;
      this.fOptimizable.Update((ParamSet) this);
      if (this.uCrgfMwL4 == null)
        return;
      this.uCrgfMwL4((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Stop()
    {
      this.stopped = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitCompleted()
    {
      if (this.dljHVKBFX == null)
        return;
      this.dljHVKBFX((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitBestObjectiveReceived()
    {
      if (this.UrKFYUM7X == null)
        return;
      this.UrKFYUM7X((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Print()
    {
      Console.WriteLine(oEMkdBNOWhfqbwWYwp.AvLDN5sEpR(76) + ((object) this.fType).ToString());
      Console.WriteLine(oEMkdBNOWhfqbwWYwp.AvLDN5sEpR(118) + ((object) this.fVerboseMode).ToString());
      Console.WriteLine(oEMkdBNOWhfqbwWYwp.AvLDN5sEpR(160) + (object) this.fNObjectiveCalls);
      Console.WriteLine(oEMkdBNOWhfqbwWYwp.AvLDN5sEpR(202) + (object) this.fNParamSubset);
    }
  }
}
