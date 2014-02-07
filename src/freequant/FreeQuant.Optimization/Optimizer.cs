using System;
using System.Collections;
using System.ComponentModel;

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
			get
			{
				return this.optimal1DList;
			}
		}

		[Browsable(false)]
		public Hashtable[,] Optimal2DList
		{
			get
			{
				return this.optimal2DList;
			}
		}

		[Browsable(false)]
		public double LastObjective
		{
			get
			{
				return this.fLastObjective;
			}
		}

		[Browsable(false)]
		public virtual int NObjectiveCalls
		{
			get
			{
				return this.fNObjectiveCalls;
			}
		}

		[Browsable(false)]
		public IOptimizable Object
		{
			get
			{
				return this.fOptimizable;
			}
			set
			{
				this.fOptimizable = value;
				this.fOptimizable.Init(this);
			}
		}

		[Browsable(false)]
		public int NParamSubset
		{
			get
			{
				return this.fNParamSubset;
			}
			set
			{
				this.fNParamSubset = value;
			}
		}

		[Category("Description")]
		[Description("Optimizer type")]
		public EOptimizerType OptimizerType
		{
			get
			{
				return this.fType;
			}
		}

		[Description("Console output mode")]
		[Category("Output")]
		public EVerboseMode VerboseMode
		{
			get
			{
				return this.fVerboseMode;
			}
			set
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

		public Optimizer(IOptimizable optimizable) : base()
		{
			this.fOptimizable = optimizable;
			this.Init();
		}

		private void Init()
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
			this.fOptimizable.Init(this);
			this.fNParamSubset = this.GetNParam();
			this.fNObjectiveCalls = 0;
			this.optimal1DList = new SortedList[this.fNParamSubset];
			this.optimal2DList = new Hashtable[this.fNParamSubset, this.fNParamSubset];
			for (int i = 0; i < this.fNParamSubset; ++i)
				this.optimal1DList[i] = new SortedList();
			for (int i = 0; i < this.fNParamSubset; ++i)
			{
				for (int j = 0; j < this.fNParamSubset; ++j)
					this.optimal2DList[i, j] = new Hashtable();
			}
			if (this.Inited != null)
				this.Inited(this, EventArgs.Empty);
		}

		public virtual double Objective()
		{
			++this.fNObjectiveCalls;
			if (this.fOptimizable == null)
				return double.NaN;
			double num = this.fOptimizable.Objective();
			this.fLastObjective = num;
			if (this.ObjectiveCalled != null)
				this.ObjectiveCalled(this, EventArgs.Empty);
			for (int i = 0; i < this.fNParamSubset; ++i)
			{
				double d1 = this[i];
				if (!double.IsNaN(d1))
				{
					if (!this.optimal1DList[i].ContainsKey(d1) || (double)this.optimal1DList[i][(object)d1] > num)
						this.optimal1DList[i][d1] = num;
					for (int j = i + 1; j < this.fNParamSubset; ++j)
					{
						double d2 = this[j];
						if (!double.IsNaN(d2) && (!this.optimal2DList[i, j].ContainsKey(new TwoParams(d1, d2)) || (double)this.optimal2DList[i, j][new TwoParams(d1, d2)] > num))
							this.optimal2DList[i, j][new TwoParams(d1, d2)] = num;
					}
				}
			}
			return num;
		}

		public virtual void OnStep()
		{
			if (this.fOptimizable != null)
			{
				this.fOptimizable.OnStep();
				if (this.StepCalled != null)
					this.StepCalled(this, EventArgs.Empty);
			}
		}

		public virtual void OnCircle()
		{
			if (this.fOptimizable != null)
			{
				this.fOptimizable.OnCircle();
				if (this.CircleCalled != null)
					this.CircleCalled(this, EventArgs.Empty);
			}
		}

		public virtual void Update()
		{
			if (this.fOptimizable != null)
			{
				this.fOptimizable.Update(this);
				if (this.UpdateCalled != null)
					this.UpdateCalled(this, EventArgs.Empty);
			}
		}

		public void Stop()
		{
			this.stopped = true;
		}

		protected void EmitCompleted()
		{
			if (this.OptimizationCompleted != null)
				this.OptimizationCompleted(this, EventArgs.Empty);
		}

		protected void EmitBestObjectiveReceived()
		{
			if (this.BestObjectiveReceived != null)
				this.BestObjectiveReceived(this, EventArgs.Empty);
		}

		public virtual void Print()
		{
			Console.WriteLine(this.fType);
			Console.WriteLine(this.fVerboseMode);
			Console.WriteLine(this.fNObjectiveCalls);
			Console.WriteLine(this.fNParamSubset);
		}
	}
}
