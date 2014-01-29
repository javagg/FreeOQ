using System;
using System.Runtime.InteropServices;

namespace FreeQuant.Optimization
{
  public class CoordinateDescent : Optimizer
  {
    private double descentStepSize;
    private double PjEutIlEM;
    private double kdBSOWhfq;

		public double DescentStepSize { get; set; }

	public CoordinateDescent(IOptimizable Optimizable) : base(Optimizable)
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

    private bool ytt95IRFu([In] int obj0)
    {
      double num1 = this.fParam[obj0];
			double num2 = this.fSteps[obj0] == 0.0 ? this.DescentStepSize : this.fSteps[obj0];
      bool flag1 = false;
      bool flag2 = false;
      this.Update();
      this.PjEutIlEM = this.Objective();
      while (true)
      {
        this.fParam[obj0] += num2;
        if (this.fParam[obj0] < this.fLowerBound[obj0])
          this.fParam[obj0] = this.fLowerBound[obj0];
        if (this.fParam[obj0] > this.fUpperBound[obj0])
          this.fParam[obj0] = this.fUpperBound[obj0];
        this.Update();
        this.kdBSOWhfq = this.Objective();
        if (this.kdBSOWhfq < this.PjEutIlEM)
        {
          this.PjEutIlEM = this.kdBSOWhfq;
          num1 = this.fParam[obj0];
          flag2 = true;
        }
        else
        {
          this.fParam[obj0] = num1;
          this.Update();
          if (!flag2 && !flag1)
          {
            num2 = -num2;
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
      bool flag = true;
      do
      {
        for (int index = 0; index < this.fNParam; ++index)
        {
          if (!this.ytt95IRFu(index))
            flag = false;
        }
      }
      while (!flag);
    }

    public override void Print()
    {
      base.Print();
			Console.WriteLine(this.DescentStepSize);
    }
  }
}
