// Type: SmartQuant.Optimization.BruteForce
// Assembly: SmartQuant.Optimization, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 1C417731-0514-4808-9329-6B635F19637E
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Optimization.dll

using E32I8CMPFnk6XwkgnC;
using oCwfgZHxO2ybCWH66L;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartQuant.Optimization
{
  public class BruteForce : Optimizer
  {
    private double veCMCTH5O;
    private double Acwl1WFnU;
    private double[] KN0nVxPcU;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BruteForce(IOptimizable Optimizable)
    {
      C7bjlF4Ph208kGmVJO.IHdBTbCzDaa6o();
      // ISSUE: explicit constructor call
      base.\u002Ector(Optimizable);
      this.fType = EOptimizerType.BruteForce;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BCW4H66LP([In] int obj0)
    {
      if (this.stopped)
        return;
      if (obj0 < this.fNParam)
      {
        if (this.fIsParamFixed[obj0])
        {
          this.BCW4H66LP(obj0++);
        }
        else
        {
          double num = this.fLowerBound[obj0];
          while (num <= this.fUpperBound[obj0])
          {
            this.fParam[obj0] = num;
            this.BCW4H66LP(obj0 + 1);
            num += this.fSteps[obj0];
          }
        }
      }
      else
        this.Step();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Step()
    {
      this.Update();
      this.Acwl1WFnU = this.Objective();
      if (this.Acwl1WFnU < this.veCMCTH5O)
      {
        this.veCMCTH5O = this.Acwl1WFnU;
        for (int index = 0; index < this.fNParam; ++index)
          this.KN0nVxPcU[index] = this.fParam[index];
      }
      this.OnStep();
      Application.DoEvents();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Optimize()
    {
      base.Optimize();
      this.KN0nVxPcU = new double[this.fNParam];
      this.veCMCTH5O = double.MaxValue;
      this.BCW4H66LP(0);
      for (int index = 0; index < this.fNParam; ++index)
        this.fParam[index] = this.KN0nVxPcU[index];
      this.Update();
      this.EmitBestObjectiveReceived();
      this.Acwl1WFnU = this.Objective();
      this.Update();
      if (this.fVerboseMode == EVerboseMode.Debug)
      {
        for (int index = 0; index < this.fNParam; ++index)
          Console.WriteLine(oEMkdBNOWhfqbwWYwp.AvLDN5sEpR(286), (object) index, (object) this.fParam[index]);
        base.Print();
      }
      this.EmitCompleted();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Print()
    {
      base.Print();
    }
  }
}
