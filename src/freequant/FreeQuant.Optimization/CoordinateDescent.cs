using System;

namespace FreeQuant.Optimization
{
	public class CoordinateDescent : Optimizer
	{
		private double objective;
		private double kdBSOWhfq;

		public double DescentStepSize { get; set; }

		public CoordinateDescent(IOptimizable optimizable) : base(optimizable)
		{
			this.fType = EOptimizerType.CoordinateDescent;
			this.DescentStepSize = 0.01;
		}

		public double GetDescentStepSize()
		{
			return this.DescentStepSize;
		}

		public void SetDescentStepSize(double descentStepSize)
		{
			this.DescentStepSize = descentStepSize;
		}

		private bool ytt95IRFu(int index)
		{
			double param = this.fParam[index];
			double step = this.fSteps[index] == 0.0 ? this.DescentStepSize : this.fSteps[index];
			bool flag1 = false;
			bool flag2 = false;
			this.Update();
			this.objective = this.Objective();
			while (true)
			{
				this.fParam[index] += step;
				if (this.fParam[index] < this.fLowerBound[index])
					this.fParam[index] = this.fLowerBound[index];
				if (this.fParam[index] > this.fUpperBound[index])
					this.fParam[index] = this.fUpperBound[index];
				this.Update();
				this.kdBSOWhfq = this.Objective();
				if (this.kdBSOWhfq < this.objective)
				{
					this.objective = this.kdBSOWhfq;
					param = this.fParam[index];
					flag2 = true;
				}
				else
				{
					this.fParam[index] = param;
					this.Update();
					if (!flag2 && !flag1)
					{
						step = -step;
						flag1 = true;
					}
					else
						break;
				}
			}
			return flag2;
		}

		public override void Optimize()
		{
			base.Optimize();
			bool doing = true;
			do
			{
				for (int i = 0; i < this.fNParam; ++i)
				{
					if (!this.ytt95IRFu(i))
						doing = false;
				}
			}
			while (!doing);
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine(this.DescentStepSize);
		}
	}
}
