using System;
using FreeQuant;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FreeQuant.Optimization
{
  public class SimulatedAnnealing : Optimizer
  {
    private double TQQPjxObY;
    private double GxQxLxogs;
    private double cc0qd97gj;
    private double S1vCXwaLF;
    private double MAxUj4muW;
    private double POtwj3imR;
    private double Po3j7nARl;
    private int Hrooye6Ec;
    private int yoSfWm2GA;
    private double jYoRfARnr;
    private int To5tAj5b7;
    private bool CjlGFPh20;
    private bool EkG2mVJO8;
    private bool I2Ib8CPFn;
    private bool l6XKwkgnC;
    private bool GnTmfc3hq;
    private int[] HtK8IFwMA;
    private int[] dJDvTleCG;
    private double[] LWpePwWbZ;
    private double[] OUbQEgoFk;
    private double[] YtcAXD3F5;
    private double[] fB337oBOq;
    private double[] dKBTAaVeY;
    private double a5kBNxIlj;
    private double Ve059ku8I;
    private double D1WWoNtlO;
    private double yTMrEVXaS;
    private double Ee9ODxaTm;
    private double vRQ0XTqU7;
    private double CKF6FJwQu;
    private double FJI7XR8s5;
    private int dGMJqlOV6;
    private bool nBrYVCBGK;
    private bool qHq1IhVHG;
    private bool SM4sEijmW;
    private int d1gcW8ZAL;
    private int cVWV7h0CD;
    private int wM5hbXEF8;
    private int rgiy3dtVJ;
    private int zafZanEwq;
    private int ff6If9BwL;
    private int olSzmDbB6;
    private int dOmDE200wU;
    private SortedList v1YDDsK8El;

    [Browsable(false)]
    public double Temperature
    {
       get
      {
        return this.a5kBNxIlj;
      }
    }

    [Category("Temperature")]
    [Description("Start temperature in the annealing schedule")]
    public double StartTemperature
    {
       get
      {
        return this.TQQPjxObY;
      }
       set
      {
        this.TQQPjxObY = value;
      }
    }

    [Description("Stop temperature in the annealing schedule")]
    [Category("Temperature")]
    public double StopTemperature
    {
       get
      {
        return this.Po3j7nARl;
      }
       set
      {
        this.Po3j7nARl = value;
      }
    }

    [Description("Temperature reduction factor")]
    [Category("Temperature")]
    public double TemperatureReductionFactor
    {
       get
      {
        return this.GxQxLxogs;
      }
       set
      {
        this.GxQxLxogs = value;
      }
    }

    [Description("Number of steps (tries) per on circle of temperature reduction")]
    [Category("Temperature")]
    public int NTemperatureReductionSteps
    {
       get
      {
        return this.To5tAj5b7;
      }
       set
      {
        this.To5tAj5b7 = value;
      }
    }

    [Browsable(false)]
    public double DisplacementTemperature
    {
       get
      {
        return this.Ve059ku8I;
      }
    }

    [Category("Displacement")]
    [Description("Displacement start temperature in the annealing schedule")]
    public double DisplacementStartTemperature
    {
       get
      {
        return this.MAxUj4muW;
      }
       set
      {
        this.MAxUj4muW = value;
      }
    }

    [Description("Displacement temperature reduction factor")]
    [Category("Displacement")]
    public double DisplacementTemperatureReductionFactor
    {
       get
      {
        return this.S1vCXwaLF;
      }
       set
      {
        this.S1vCXwaLF = value;
      }
    }

    [Category("Displacement")]
    [Description("Displacement distribution parameter")]
    public double DisplacementDistributionParam
    {
       get
      {
        return this.cc0qd97gj;
      }
       set
      {
        this.cc0qd97gj = value;
      }
    }

    [Description("Acceptance probability parameter")]
    [Category("Acceptance")]
    public double AcceptanceProbabilityParam
    {
       get
      {
        return this.POtwj3imR;
      }
       set
      {
        this.POtwj3imR = value;
      }
    }

    [Description("Error tolerance")]
    [Category("Stopping Criterion")]
    public double ErrorTolerance
    {
       get
      {
        return this.jYoRfARnr;
      }
       set
      {
        this.jYoRfARnr = value;
      }
    }

    [Description("Maximum number of objective function calls")]
    [Category("Stopping Criterion")]
    public int MaxObjectiveCalls
    {
       get
      {
        return this.Hrooye6Ec;
      }
       set
      {
        this.Hrooye6Ec = value;
      }
    }

    [Category("Stopping Criterion")]
    [Description("Minimum number of accepted uphill jumps")]
    public int MinAcceptedUphills
    {
       get
      {
        return this.yoSfWm2GA;
      }
       set
      {
        this.yoSfWm2GA = value;
      }
    }

    [Category("Stopping Criterion")]
    [Description("Stop temperature stopping criterion")]
    public bool IsStopTemperatureCriterion
    {
       get
      {
        return this.I2Ib8CPFn;
      }
       set
      {
        this.I2Ib8CPFn = value;
      }
    }

    [Category("Stopping Criterion")]
    [Description("Number of objective calls stopping criterion")]
    public bool IsObjectiveCallsCriterion
    {
       get
      {
        return this.CjlGFPh20;
      }
       set
      {
        this.CjlGFPh20 = value;
      }
    }

    [Description("Error tolerance stopping criterion")]
    [Category("Stopping Criterion")]
    public bool IsErrorToleranceCriterion
    {
       get
      {
        return this.EkG2mVJO8;
      }
       set
      {
        this.EkG2mVJO8 = value;
      }
    }

    [Category("Stopping Criterion")]
    [Description("Number of accepted uphills stopping criterion")]
    public bool IsAcceptedUphillsCriterion
    {
       get
      {
        return this.l6XKwkgnC;
      }
       set
      {
        this.l6XKwkgnC = value;
      }
    }

    [Description("Number of accepted downhill jumps stopping criterion")]
    [Category("Stopping Criterion")]
    public bool IsAcceptedDownhillsCriterion
    {
       get
      {
        return this.GnTmfc3hq;
      }
       set
      {
        this.GnTmfc3hq = value;
      }
    }

	public SimulatedAnnealing(IOptimizable Optimizable) : base(Optimizable)
    {
      this.ieAakAK1q();
    }

    private void ieAakAK1q()
    {
      this.TQQPjxObY = 0.1;
      this.Po3j7nARl = 0.005;
      this.GxQxLxogs = 0.55;
      this.MAxUj4muW = 1.0;
      this.S1vCXwaLF = 0.95;
      this.cc0qd97gj = 2.0;
      this.POtwj3imR = 1.1;
      this.jYoRfARnr = 1E-05;
      this.Hrooye6Ec = 10000000;
      this.yoSfWm2GA = 0;
      this.To5tAj5b7 = 20;
      this.I2Ib8CPFn = true;
      this.CjlGFPh20 = false;
      this.EkG2mVJO8 = false;
      this.l6XKwkgnC = false;
      this.GnTmfc3hq = false;
      this.fType = EOptimizerType.SimulatedAnnealing;
      this.fVerboseMode = EVerboseMode.Quiet;
    }

    
    public void SetScheme(ESimulatedAnnealingScheme Scheme)
    {
      switch (Scheme)
      {
        case ESimulatedAnnealingScheme.Portfolio:
          this.DisableStoppingCriterion(EStoppingCriterion.All);
          this.EnableStoppingCriterion(EStoppingCriterion.StopTemperature, true);
          this.To5tAj5b7 = 250;
          this.GxQxLxogs = 0.1;
          this.POtwj3imR = -20.0;
          this.MAxUj4muW = 1.0;
          this.S1vCXwaLF = 0.85;
          this.TQQPjxObY = 100.0;
          this.Po3j7nARl = 0.0001;
          break;
        case ESimulatedAnnealingScheme.EfficientFrontier:
          this.DisableStoppingCriterion(EStoppingCriterion.All);
          this.EnableStoppingCriterion(EStoppingCriterion.StopTemperature, true);
          this.To5tAj5b7 = 25;
          this.GxQxLxogs = 0.5;
          this.POtwj3imR = -20.0;
          this.MAxUj4muW = 1.0;
          this.S1vCXwaLF = 0.85;
          this.TQQPjxObY = 0.001;
          this.Po3j7nARl = 1E-06;
          break;
        case ESimulatedAnnealingScheme.Perceptron:
          this.DisableStoppingCriterion(EStoppingCriterion.All);
          this.EnableStoppingCriterion(EStoppingCriterion.StopTemperature, true);
          this.To5tAj5b7 = 25;
          this.GxQxLxogs = 0.5;
          this.POtwj3imR = -20.0;
          this.MAxUj4muW = 1.0;
          this.S1vCXwaLF = 0.85;
          this.TQQPjxObY = 0.001;
          this.Po3j7nARl = 1E-06;
          break;
      }
    }

    
    public void EnableStoppingCriterion(EStoppingCriterion Criterion, bool Enable)
    {
      switch (Criterion)
      {
        case EStoppingCriterion.All:
          this.CjlGFPh20 = Enable;
          this.EkG2mVJO8 = Enable;
          this.I2Ib8CPFn = Enable;
          this.l6XKwkgnC = Enable;
          this.GnTmfc3hq = Enable;
          break;
        case EStoppingCriterion.ObjectiveCalls:
          this.CjlGFPh20 = Enable;
          break;
        case EStoppingCriterion.ErrorTolerance:
          this.EkG2mVJO8 = Enable;
          break;
        case EStoppingCriterion.StopTemperature:
          this.I2Ib8CPFn = Enable;
          break;
        case EStoppingCriterion.AcceptedUphills:
          this.l6XKwkgnC = Enable;
          break;
        case EStoppingCriterion.AcceptedDownhills:
          this.GnTmfc3hq = Enable;
          break;
      }
    }

    
    public bool IsStoppingCriterionEnabled(EStoppingCriterion Criterion)
    {
      bool flag = false;
      switch (Criterion)
      {
        case EStoppingCriterion.ObjectiveCalls:
          flag = this.CjlGFPh20;
          break;
        case EStoppingCriterion.ErrorTolerance:
          flag = this.EkG2mVJO8;
          break;
        case EStoppingCriterion.StopTemperature:
          flag = this.I2Ib8CPFn;
          break;
        case EStoppingCriterion.AcceptedUphills:
          flag = this.l6XKwkgnC;
          break;
        case EStoppingCriterion.AcceptedDownhills:
          flag = this.GnTmfc3hq;
          break;
      }
      return flag;
    }

    
    public void DisableStoppingCriterion(EStoppingCriterion Criterion)
    {
      switch (Criterion)
      {
        case EStoppingCriterion.All:
          this.CjlGFPh20 = false;
          this.EkG2mVJO8 = false;
          this.I2Ib8CPFn = false;
          this.l6XKwkgnC = false;
          this.GnTmfc3hq = false;
          break;
        case EStoppingCriterion.ObjectiveCalls:
          this.CjlGFPh20 = false;
          break;
        case EStoppingCriterion.ErrorTolerance:
          this.EkG2mVJO8 = false;
          break;
        case EStoppingCriterion.StopTemperature:
          this.I2Ib8CPFn = false;
          break;
        case EStoppingCriterion.AcceptedUphills:
          this.l6XKwkgnC = false;
          break;
        case EStoppingCriterion.AcceptedDownhills:
          this.GnTmfc3hq = false;
          break;
      }
    }

    
    protected double GetDisplacementDistribution(double dx)
    {
      double x = this.Ve059ku8I;
      double num1 = (double) this.fNParam;
      double num2 = this.cc0qd97gj;
      return Math.Pow(x, -num1 / (3.0 - num2)) / Math.Pow(1.0 + (num2 - 1.0) * Math.Pow(dx, 2.0) / Math.Pow(x, 2.0 / (3.0 - num2)), 1.0 / (num2 - 1.0) + (num1 - 1.0) / 2.0);
    }

    
    protected double GetDisplacement(double MinDisplacement, double MaxDisplacement)
    {
      if (MinDisplacement < -20.0 * this.Ve059ku8I)
        MinDisplacement = -20.0 * this.Ve059ku8I;
      if (MaxDisplacement > 20.0 * this.Ve059ku8I)
        MaxDisplacement = 20.0 * this.Ve059ku8I;
      double displacementDistribution = this.GetDisplacementDistribution(0.0);
      double dx;
      do
      {
        dx = MinDisplacement + (MaxDisplacement - MinDisplacement) * FreeQuant.Quant.Random.Rndm();
      }
      while (displacementDistribution * FreeQuant.Quant.Random.Rndm() > this.GetDisplacementDistribution(dx));
      return dx;
    }

    
    protected double GetNextTemperature()
    {
      return this.TQQPjxObY * (Math.Pow(2.0, this.cc0qd97gj - 1.0) - 1.0) / (Math.Pow((double) (this.ff6If9BwL + 1), this.cc0qd97gj - 1.0) - 1.0);
    }

    
    protected double GetNextDisplacementTemperature()
    {
      return this.MAxUj4muW * (Math.Pow(2.0, this.cc0qd97gj - 1.0) - 1.0) / (Math.Pow((double) (this.ff6If9BwL + 1), this.cc0qd97gj - 1.0) - 1.0);
    }

    
    protected double GetAcceptanceProbability(double dE)
    {
      double x = 1.0 + (this.POtwj3imR - 1.0) * dE / this.a5kBNxIlj;
      return Math.Min(1.0, x <= 0.0 ? 0.0 : Math.Pow(x, 1.0 / (1.0 - this.POtwj3imR)));
    }

    
    public void Step()
    {
      Application.DoEvents();
      ++this.dGMJqlOV6;
      this.nBrYVCBGK = false;
      for (int index = 0; index < this.fNParam; ++index)
        this.fB337oBOq[index] = this.YtcAXD3F5[index];
      for (int index = 0; index < this.fNParamSubset; ++index)
        this.dJDvTleCG[index] = this.HtK8IFwMA[index];
      bool flag;
      do
      {
        int index1 = (int) ((double) this.fNParamSubset * FreeQuant.Quant.Random.Rndm());
        int NParam = this.HtK8IFwMA[index1];
        flag = this.GetParamType(NParam) == EParamType.Float;
        if (!this.IsParamFixed(NParam))
        {
          double MinDisplacement = this.fLowerBound[NParam] - this.YtcAXD3F5[NParam];
          double MaxDisplacement = this.fUpperBound[NParam] - this.YtcAXD3F5[NParam];
          this.YtcAXD3F5[NParam] += this.GetDisplacement(MinDisplacement, MaxDisplacement);
          if (this.fNParamSubset != 0)
          {
            this.YtcAXD3F5[NParam] = this.fLowerBound[NParam] + (this.fUpperBound[NParam] - this.fLowerBound[NParam]) * FreeQuant.Quant.Random.Rndm();
            if (this.fNParamSubset < this.fNParam)
            {
              this.nBrYVCBGK = true;
              int num;
              do
              {
                this.qHq1IhVHG = true;
                num = (int) ((double) this.fNParam * FreeQuant.Quant.Random.Rndm());
                for (int index2 = 0; index2 < this.fNParamSubset; ++index2)
                {
                  if (num == this.HtK8IFwMA[index2])
                    this.qHq1IhVHG = false;
                }
              }
              while (!this.qHq1IhVHG);
              this.HtK8IFwMA[index1] = num;
            }
          }
          else if (this.YtcAXD3F5[NParam] > this.fUpperBound[NParam])
            this.YtcAXD3F5[NParam] = this.fUpperBound[NParam];
          this.qHq1IhVHG = true;
          for (int index2 = 0; index2 < this.fNParam; ++index2)
            this.fParam[index2] = 0.0;
          for (int index2 = 0; index2 < this.fNParamSubset; ++index2)
            this.fParam[this.HtK8IFwMA[index2]] = this.YtcAXD3F5[this.HtK8IFwMA[index2]];
          for (int index2 = 0; index2 < this.fNParamSubset; ++index2)
          {
            if (this.fParam[this.HtK8IFwMA[index2]] < this.fLowerBound[this.HtK8IFwMA[index2]] || this.fParam[this.HtK8IFwMA[index2]] > this.fUpperBound[this.HtK8IFwMA[index2]])
            {
              this.qHq1IhVHG = false;
              for (int index3 = 0; index3 < this.fNParam; ++index3)
                this.YtcAXD3F5[index3] = this.fB337oBOq[index3];
              for (index2 = 0; index2 < this.fNParamSubset; ++index2)
                this.HtK8IFwMA[index2] = this.dJDvTleCG[index2];
            }
          }
        }
      }
      while (!this.qHq1IhVHG);
      this.Update();
      if (this.qHq1IhVHG)
      {
        string str = this.FormatParamsHashCode();
        if (flag)
        {
          this.v1YDDsK8El.Remove((object) str);
          this.Ee9ODxaTm = this.Objective();
          this.v1YDDsK8El[(object) str] = (object) this.Ee9ODxaTm;
        }
        else if (this.v1YDDsK8El.Contains((object) str))
        {
          this.Ee9ODxaTm = (double) this.v1YDDsK8El[(object) str];
        }
        else
        {
          this.Ee9ODxaTm = this.Objective();
          this.v1YDDsK8El[(object) str] = (object) this.Ee9ODxaTm;
        }
      }
      double dE = this.Ee9ODxaTm - this.vRQ0XTqU7;
      if (dE <= 0.0)
      {
        this.SM4sEijmW = true;
        ++this.cVWV7h0CD;
        if (this.Ee9ODxaTm < this.CKF6FJwQu)
        {
          this.CKF6FJwQu = this.Ee9ODxaTm;
          for (int index = 0; index < this.fNParam; ++index)
            this.LWpePwWbZ[index] = this.fParam[index];
        }
      }
      else
      {
        ++this.d1gcW8ZAL;
        if (FreeQuant.Quant.Random.Rndm() < this.GetAcceptanceProbability(dE))
        {
          this.SM4sEijmW = true;
          ++this.wM5hbXEF8;
        }
        else
        {
          this.SM4sEijmW = false;
          ++this.rgiy3dtVJ;
        }
      }
      if (this.SM4sEijmW)
      {
        ++this.zafZanEwq;
        this.vRQ0XTqU7 = this.Ee9ODxaTm;
        this.yTMrEVXaS = this.Ee9ODxaTm;
        if (this.nBrYVCBGK)
          ++this.dOmDE200wU;
      }
      else
      {
        for (int index = 0; index < this.fNParam; ++index)
          this.YtcAXD3F5[index] = this.fB337oBOq[index];
        for (int index = 0; index < this.fNParamSubset; ++index)
          this.HtK8IFwMA[index] = this.dJDvTleCG[index];
        for (int index = 0; index < this.fNParamSubset; ++index)
        {
          if (!this.IsParamFixed(this.dJDvTleCG[index]))
            this.fParam[this.dJDvTleCG[index]] = this.YtcAXD3F5[this.dJDvTleCG[index]];
        }
      }
      this.OnStep();
    }

    
    public void Circle()
    {
      for (int index = 0; index < this.To5tAj5b7 * this.fNParam; ++index)
      {
        if (this.stopped)
          return;
        this.Step();
      }
      this.Update();
      this.OnCircle();
    }

    
    public string FormatParamsHashCode()
    {
      string str = "";
      for (int NParam = 0; NParam < this.fNParam; ++NParam)
      {
        if (this.GetParamType(NParam) == EParamType.Int)
					str = str + this[NParam];
      }
      return str;
    }

    
    public override void Optimize()
    {
      base.Optimize();
      this.HtK8IFwMA = new int[this.fNParam];
      this.dJDvTleCG = new int[this.fNParam];
      this.LWpePwWbZ = new double[this.fNParam];
      this.OUbQEgoFk = new double[this.fNParam];
      this.YtcAXD3F5 = new double[this.fNParam];
      this.fB337oBOq = new double[this.fNParam];
      this.dKBTAaVeY = new double[this.fNParam];
      this.d1gcW8ZAL = 0;
      this.dGMJqlOV6 = 0;
      this.cVWV7h0CD = 0;
      this.wM5hbXEF8 = 0;
      this.rgiy3dtVJ = 0;
      this.zafZanEwq = 0;
      this.ff6If9BwL = 0;
      this.olSzmDbB6 = 0;
      this.nBrYVCBGK = false;
      this.qHq1IhVHG = true;
      this.SM4sEijmW = false;
      this.a5kBNxIlj = this.TQQPjxObY;
      this.Ve059ku8I = this.MAxUj4muW;
      this.v1YDDsK8El = new SortedList();
      for (int index = 0; index < this.fNParam; ++index)
      {
        this.YtcAXD3F5[index] = this.fParam[index];
        this.fParam[index] = this.fLowerBound[index] + (this.fUpperBound[index] - this.fLowerBound[index]) * FreeQuant.Quant.Random.Rndm();
        this.YtcAXD3F5[index] = this.fLowerBound[index] + (this.fUpperBound[index] - this.fLowerBound[index]) * FreeQuant.Quant.Random.Rndm();
        this.dKBTAaVeY[index] = this.fUpperBound[index] - this.fLowerBound[index];
      }
      for (int index = 0; index < this.fNParamSubset; ++index)
        this.HtK8IFwMA[index] = index;
      this.Update();
      this.D1WWoNtlO = this.Objective();
      this.yTMrEVXaS = this.D1WWoNtlO;
      this.vRQ0XTqU7 = this.D1WWoNtlO;
      this.CKF6FJwQu = this.D1WWoNtlO;
      this.FJI7XR8s5 = this.D1WWoNtlO;
      this.v1YDDsK8El.Add((object) this.FormatParamsHashCode(), (object) this.D1WWoNtlO);
      for (int index = 0; index < this.fNParam; ++index)
        this.LWpePwWbZ[index] = this.fParam[index];
      bool flag = false;
      while (!flag)
      {
        this.Circle();
        if (!this.stopped)
        {
          this.a5kBNxIlj *= this.GxQxLxogs;
          this.Ve059ku8I *= this.S1vCXwaLF;
          ++this.ff6If9BwL;
          if (this.fVerboseMode != EVerboseMode.Quiet)
						Console.WriteLine("", (object) this.a5kBNxIlj, (object) this.Ve059ku8I, (object) this.d1gcW8ZAL, (object) this.cVWV7h0CD, (object) this.wM5hbXEF8, (object) this.rgiy3dtVJ, (object) this.vRQ0XTqU7);
          if (this.CjlGFPh20 && this.fNObjectiveCalls > this.Hrooye6Ec)
          {
            if (this.fVerboseMode != EVerboseMode.Quiet)
							Console.WriteLine("");
            flag = true;
          }
          if (this.EkG2mVJO8)
          {
            if (this.ff6If9BwL != 1)
            {
              if (this.FJI7XR8s5 - this.vRQ0XTqU7 < this.jYoRfARnr)
              {
                ++this.olSzmDbB6;
                if (this.olSzmDbB6 == 5)
                  flag = true;
                if (this.fVerboseMode != EVerboseMode.Quiet)
									Console.WriteLine("", (object) this.olSzmDbB6);
              }
              else
              {
                this.FJI7XR8s5 = this.vRQ0XTqU7;
                this.olSzmDbB6 = 0;
              }
            }
            else
              this.FJI7XR8s5 = this.vRQ0XTqU7;
          }
          if (this.I2Ib8CPFn && this.a5kBNxIlj < this.Po3j7nARl)
          {
            if (this.fVerboseMode != EVerboseMode.Quiet)
							Console.WriteLine("");
            flag = true;
          }
          if (this.l6XKwkgnC)
          {
            if (this.d1gcW8ZAL != 0 && this.wM5hbXEF8 <= this.yoSfWm2GA)
            {
              if (this.fVerboseMode != EVerboseMode.Quiet)
								Console.WriteLine("");
              ++this.olSzmDbB6;
              if (this.olSzmDbB6 == 5)
                flag = true;
            }
            else
              this.olSzmDbB6 = 0;
          }
          this.d1gcW8ZAL = 0;
          this.cVWV7h0CD = 0;
          this.wM5hbXEF8 = 0;
          this.rgiy3dtVJ = 0;
          this.dOmDE200wU = 0;
        }
        else
          break;
      }
      for (int NParam = 0; NParam < this.fNParam; ++NParam)
      {
        if (!this.IsParamFixed(NParam))
          this.fParam[NParam] = this.LWpePwWbZ[NParam];
      }
      this.Update();
      this.EmitBestObjectiveReceived();
      this.Ee9ODxaTm = this.Objective();
      this.EmitCompleted();
    }
  }
}
