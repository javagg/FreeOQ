using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class PERF : Indicator
  {
    protected double fK;
    protected BarData fOption;

    [Description("")]
    [Category("Parameters")]
    [IndicatorParameter(1)]
    public BarData Option
    {
       get
      {
        return this.fOption;
      }
       set
      {
        this.fOption = value;
        this.Init();
      }
    }

    [Description("")]
    [IndicatorParameter(0)]
    [Category("Parameters")]
    public double K
    {
       get
      {
        return this.fK;
      }
       set
      {
        this.fK = value;
        this.Init();
      }
    }

    
		public PERF(): base()
    {
      this.fK = 14.0;
       this.Init();
    }

    
		public PERF(TimeSeries input, double k, BarData option)	: base(input) 
    {
      this.fK = 14.0;
      this.fOption = option;
      this.fK = k;
      this.Init();
    }

    
		public PERF(TimeSeries input, double k, BarData option, Color color)	: base(input) 
    {
      this.fK = 14.0;
      this.fOption = option;
      this.fK = k;
      this.Init();
      this.Color = color;
    }

    
    public PERF(TimeSeries input, double k, BarData option, Color color, EDrawStyle drawStyle)
			: base(input) {
      this.fK = 14.0;
      this.fOption = option;
      this.fK = k;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
		public PERF(TimeSeries input, double k)	: base(input) 
    {
      this.fK = 14.0;
      this.fK = k;
      this.Init();
    }

    
		public PERF(TimeSeries input, double k, Color color)	: base(input) 
    {
      this.fK = 14.0;
      this.fK = k;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name = "PERF"+ (object) this.fK;
			this.Title = "PERF";
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
				this.Name = "PERF" + (object) this.fK  + (string) (object) this.fOption;
			if (TimeSeries.nameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = PERF.Value(this.fInput, index, this.fK, this.fOption);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, double k, BarData option)
    {
      if (index >= input.FirstIndex)
        return 100.0 * (input[index, option] - k) / k;
      else
        return double.NaN;
    }

    
    public static double Value(DoubleSeries input, int index, double k)
    {
      return PERF.Value((TimeSeries) input, index, k, BarData.Close);
    }
  }
}
