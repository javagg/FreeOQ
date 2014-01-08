using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Optimization
{
  public class CoordinateDescent : Optimizer
  {
    private double rMbL3XWM4;
    private double PjEutIlEM;
    private double kdBSOWhfq;

    public double DescentStepSize
    {
       get
      {
        return this.rMbL3XWM4;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.rMbL3XWM4 = value;
      }
    }

	public CoordinateDescent(IOptimizable Optimizable) : base(Optimizable)
    {

      this.fType = EOptimizerType.CoordinateDescent;
      this.rMbL3XWM4 = 0.01;
    }

    public double GetDescentStepSize()
    {
      return this.rMbL3XWM4;
    }

    public void SetDescentStepSize(double DescentStepSize)
    {
      this.rMbL3XWM4 = DescentStepSize;
    }

    private bool ytt95IRFu([In] int obj0)
    {
      double num1 = this.fParam[obj0];
      double num2 = this.fSteps[obj0] == 0.0 ? this.rMbL3XWM4 : this.fSteps[obj0];
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
      Console.WriteLine(oEMkdBNOWhfqbwWYwp.AvLDN5sEpR(244) + (object) this.rMbL3XWM4);
    }
  }
}
