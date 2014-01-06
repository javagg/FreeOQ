// Type: SmartQuant.Optimization.CoordinateDescent
// Assembly: SmartQuant.Optimization, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 1C417731-0514-4808-9329-6B635F19637E
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Optimization.dll

using E32I8CMPFnk6XwkgnC;
using oCwfgZHxO2ybCWH66L;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.Optimization
{
  public class CoordinateDescent : Optimizer
  {
    private double rMbL3XWM4;
    private double PjEutIlEM;
    private double kdBSOWhfq;

    public double DescentStepSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.rMbL3XWM4;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.rMbL3XWM4 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CoordinateDescent(IOptimizable Optimizable)
    {
      C7bjlF4Ph208kGmVJO.IHdBTbCzDaa6o();
      // ISSUE: explicit constructor call
      base.\u002Ector(Optimizable);
      this.fType = EOptimizerType.CoordinateDescent;
      this.rMbL3XWM4 = 0.01;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetDescentStepSize()
    {
      return this.rMbL3XWM4;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDescentStepSize(double DescentStepSize)
    {
      this.rMbL3XWM4 = DescentStepSize;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Print()
    {
      base.Print();
      Console.WriteLine(oEMkdBNOWhfqbwWYwp.AvLDN5sEpR(244) + (object) this.rMbL3XWM4);
    }
  }
}
