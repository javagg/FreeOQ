using System;
using System.Windows.Forms;

namespace FreeQuant.Optimization
{
	public class BruteForce : Optimizer
	{
		private double veCMCTH5O;
		private double Acwl1WFnU;
		private double[] KN0nVxPcU;

		public BruteForce(IOptimizable optimizable) : base(optimizable)
		{
			this.fType = EOptimizerType.BruteForce;
		}

		private void BCW4H66LP(int index)
		{
			if (this.stopped)
				return;
			if (index < this.fNParam)
			{
				if (this.fIsParamFixed[index])
				{
					this.BCW4H66LP(index++);
				}
				else
				{
					double num = this.fLowerBound[index];
					while (num <= this.fUpperBound[index])
					{
						this.fParam[index] = num;
						this.BCW4H66LP(index + 1);
						num += this.fSteps[index];
					}
				}
			}
			else
				this.Step();
		}

		public void Step()
		{
			this.Update();
			this.Acwl1WFnU = this.Objective();
			if (this.Acwl1WFnU < this.veCMCTH5O)
			{
				this.veCMCTH5O = this.Acwl1WFnU;
				for (int i = 0; i < this.fNParam; ++i)
					this.KN0nVxPcU[i] = this.fParam[i];
			}
			this.OnStep();
			Application.DoEvents();
		}

		public override void Optimize()
		{
			base.Optimize();
			this.KN0nVxPcU = new double[this.fNParam];
			this.veCMCTH5O = double.MaxValue;
			this.BCW4H66LP(0);
			for (int i = 0; i < this.fNParam; ++i)
				this.fParam[i] = this.KN0nVxPcU[i];
			this.Update();
			this.EmitBestObjectiveReceived();
			this.Acwl1WFnU = this.Objective();
			this.Update();
			if (this.fVerboseMode == EVerboseMode.Debug)
			{
				for (int i = 0; i < this.fNParam; ++i)
					Console.WriteLine("sd", i, this.fParam[i]);
				base.Print();
			}
			this.EmitCompleted();
		}

		
		public override void Print()
		{
			base.Print();
		}
	}
}
