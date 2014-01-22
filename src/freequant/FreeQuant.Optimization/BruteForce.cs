using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FreeQuant.Optimization
{
  public class BruteForce : Optimizer
  {
    private double veCMCTH5O;
    private double Acwl1WFnU;
    private double[] KN0nVxPcU;

	public BruteForce(IOptimizable Optimizable) : base(Optimizable)
    {
      this.fType = EOptimizerType.BruteForce;
    }

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
					Console.WriteLine("sd", index, this.fParam[index]);
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
