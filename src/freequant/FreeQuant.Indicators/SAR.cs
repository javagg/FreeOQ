using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class SAR : Indicator
  {
    private double gIJjAXMOV;
    private double Djw8iRPrM;
    private double GtJLCOFS9;
    private double tMtMPtD61;
    private double VinhNnWht;
    private double ldFP3UIhI;
    private double uvVHKyCq9;
    private double K0Eorrg5q;
    private double f6lZ8JJ5j;
    private double oLNK1rgos;
    private double yYp9Zvu1F;
    private int BYn58ng5P;
    private bool XeyFHvyep;

    [Category("Parameters")]
    [IndicatorParameter(1)]
    [Description("The maximum possible value of the Acceleration Factor")]
    public double UpperBound
    {
       get
      {
        return this.gIJjAXMOV;
      }
       set
      {
        this.gIJjAXMOV = value;
        this.Init();
      }
    }

    [IndicatorParameter(2)]
    [Category("Parameters")]
    [Description("Step that is used to increment the Acceleration Factor")]
    public double Step
    {
       get
      {
        return this.Djw8iRPrM;
      }
       set
      {
        this.Djw8iRPrM = value;
        this.Init();
      }
    }

    [Description("Initial value of the Acceleration Factor")]
    [Category("Parameters")]
    [IndicatorParameter(3)]
    public double InitialAcc
    {
       get
      {
        return this.GtJLCOFS9;
      }
       set
      {
        this.GtJLCOFS9 = value;
        this.Init();
      }
    }

    
		public SAR(): base()
    {
      this.gIJjAXMOV = 0.2;
      this.Djw8iRPrM = 0.001;
      this.GtJLCOFS9 = 0.02;
      this.Init();
    }

    
		public SAR(TimeSeries input, double upperBound, double step, double initialAcc):base(input)
    {
      this.gIJjAXMOV = 0.2;
      this.Djw8iRPrM = 0.001;
      this.GtJLCOFS9 = 0.02;
      this.gIJjAXMOV = upperBound;
      this.Djw8iRPrM = step;
      this.GtJLCOFS9 = initialAcc;
      this.Init();
    }

    
    public SAR(TimeSeries input, double upperBound, double step, double initialAcc, Color color)
			:base(input) {
      this.Color = color;
    }

    
    protected override void Init()
    {
      this.Name = (object) this.gIJjAXMOV  + (string) (object) this.Djw8iRPrM + (string) (object) this.GtJLCOFS9;
			this.Title = "SAR";
      this.fType = EIndicatorType.Price;
      this.Clear();
      this.rDfv3IEXe();
      this.fCalculate = true;
			if (this.fInput == null || TimeSeries.nameOption != ENameOption.Long)
        return;
			this.Name = this.fInput.Name + this.Name;
    }

    
    private void rDfv3IEXe()
    {
      this.tMtMPtD61 = 0.0;
      this.VinhNnWht = 0.0;
      this.ldFP3UIhI = 0.0;
      this.uvVHKyCq9 = 0.0;
      this.K0Eorrg5q = 0.0;
      this.f6lZ8JJ5j = 0.0;
      this.oLNK1rgos = 0.0;
      this.yYp9Zvu1F = double.MaxValue;
      this.BYn58ng5P = 0;
      this.XeyFHvyep = false;
    }

    
    protected override void Calculate(int index)
    {
      Bar bar = this.Input[index] as Bar;
      if (this.BYn58ng5P > 20)
      {
        this.tMtMPtD61 = this.VinhNnWht;
        if (this.XeyFHvyep)
        {
          if (bar.High > this.ldFP3UIhI)
          {
            this.ldFP3UIhI = bar.High;
            if (this.uvVHKyCq9 < this.gIJjAXMOV)
              this.uvVHKyCq9 += this.Djw8iRPrM;
          }
          if (bar.Low < this.VinhNnWht)
            this.XeyFHvyep = false;
          if (this.XeyFHvyep)
          {
            this.K0Eorrg5q = this.ldFP3UIhI - this.VinhNnWht;
            this.VinhNnWht = this.VinhNnWht + this.K0Eorrg5q * this.uvVHKyCq9;
            if (this.VinhNnWht > bar.Low || this.VinhNnWht > this.f6lZ8JJ5j)
              this.VinhNnWht = bar.Low >= this.f6lZ8JJ5j ? this.f6lZ8JJ5j : bar.Low;
            if (this.VinhNnWht < this.tMtMPtD61)
              this.VinhNnWht = this.tMtMPtD61;
            this.Add(bar.DateTime, this.VinhNnWht);
          }
          else
          {
            this.VinhNnWht = this.ldFP3UIhI;
            this.uvVHKyCq9 = this.GtJLCOFS9;
            this.Add(bar.DateTime, this.VinhNnWht);
          }
        }
        else
        {
          if (this.f6lZ8JJ5j < this.ldFP3UIhI)
          {
            this.ldFP3UIhI = this.f6lZ8JJ5j;
            if (this.uvVHKyCq9 < this.gIJjAXMOV)
              this.uvVHKyCq9 += this.Djw8iRPrM;
          }
          if (bar.High > this.VinhNnWht)
            this.XeyFHvyep = true;
          if (!this.XeyFHvyep)
          {
            this.K0Eorrg5q = this.VinhNnWht - this.ldFP3UIhI;
            this.VinhNnWht = this.VinhNnWht - this.K0Eorrg5q * this.uvVHKyCq9;
            if (this.VinhNnWht < bar.High || this.VinhNnWht < this.oLNK1rgos)
              this.VinhNnWht = bar.High <= this.oLNK1rgos ? this.oLNK1rgos : bar.High;
            if (this.VinhNnWht > this.tMtMPtD61)
              this.VinhNnWht = this.tMtMPtD61;
            this.Add(bar.DateTime, this.VinhNnWht);
          }
          else
          {
            this.VinhNnWht = this.ldFP3UIhI;
            this.uvVHKyCq9 = this.GtJLCOFS9;
            this.Add(bar.DateTime, this.VinhNnWht);
          }
        }
      }
      else if (this.BYn58ng5P == 20)
      {
        this.XeyFHvyep = true;
        this.ldFP3UIhI = this.yYp9Zvu1F;
        this.VinhNnWht = this.ldFP3UIhI;
      }
      else
        this.yYp9Zvu1F = Math.Min(this.yYp9Zvu1F, bar.Close);
      ++this.BYn58ng5P;
      this.oLNK1rgos = bar.High;
      this.f6lZ8JJ5j = bar.Low;
    }

    
    public static double Value(BarSeries input, int index, double upperBound, double step, double initialAcc)
    {
      if (index >= input.FirstIndex)
        return new SAR((TimeSeries) input, upperBound, step, initialAcc)[index];
      else
        return double.NaN;
    }

    
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.Monitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      if (index == this.fInput.Count - 1)
      {
        this.Calculate(index);
      }
      else
      {
        this.rDfv3IEXe();
        this.Clear();
        for (int Index = 0; Index <= this.fInput.Count - 1; ++Index)
          this.Calculate(Index);
      }
    }
  }
}
