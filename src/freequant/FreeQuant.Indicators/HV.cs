using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  public class HV : Indicator
  {
    protected int fLength;
    protected double fSpan;
    protected BarData fOption;

    [Category("Parameters")]
    [Description("")]
    [IndicatorParameter(2)]
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
    [Category("Parameters")]
    [IndicatorParameter(0)]
    public int Length
    {
       get
      {
        return this.fLength;
      }
       set
      {
        this.fLength = value;
        this.Init();
      }
    }

    [Description("")]
    [Category("Parameters")]
    [IndicatorParameter(1)]
    public double Span
    {
       get
      {
        return this.fSpan;
      }
       set
      {
        this.fSpan = value;
        this.Init();
      }
    }

    
		public HV(): base()
    {
      this.fLength = 14;
      this.fSpan = 20.0;
      this.Init();
    }

    
		public HV(TimeSeries input, int length, double span, BarData option)	: base(input) 
    {
      this.fLength = 14;
      this.fSpan = 20.0;
      this.fLength = length;
      this.fSpan = span;
      this.fOption = option;
      this.Init();
    }

    
    public HV(TimeSeries input, int length, double span, BarData option, Color color)
			: base(input) {
      this.fLength = 14;
      this.fSpan = 20.0;
      this.fLength = length;
      this.fSpan = span;
      this.fOption = option;
      this.Init();
      this.Color = color;
    }

    
    public HV(TimeSeries input, int length, double span, BarData option, Color color, EDrawStyle drawStyle)
			: base(input)  {
      this.fLength = 14;
      this.fSpan = 20.0;
      this.fLength = length;
      this.fSpan = span;
      this.fOption = option;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    public HV(TimeSeries input, int length, double span)
			: base(input)   {
      this.fLength = 14;
      this.fSpan = 20.0;
      this.fLength = length;
      this.fSpan = span;
      this.Init();
    }

    
    public HV(TimeSeries input, int length, double span, Color color)
			: base(input)  {
      this.fLength = 14;
      this.fSpan = 20.0;
      this.fLength = length;
      this.fSpan = span;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name = "HV" + (object) this.fLength + (string) (object) this.fSpan;
			this.Title = "HV";
      this.fType = EIndicatorType.Price;
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
				this.Name ="HV" + (object) this.fLength + (string) (object) this.fSpan + (string) (object) this.fOption;
			if (TimeSeries.nameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = HV.Value(this.fInput, index, this.fLength, this.fSpan, this.fOption);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length, double span, BarData option)
    {
      if (index < length + input.FirstIndex)
        return double.NaN;
      double[] numArray = new double[length];
      double num1 = 0.0;
      for (int index1 = index; index1 > index - length; --index1)
      {
        double num2 = Math.Log(input[index1, option] / input[index1 - 1, option]);
        num1 += num2;
        numArray[index1 - index + length - 1] = num2;
      }
      double num3 = num1 / (double) length;
      double num4 = 0.0;
      for (int index1 = 0; index1 < numArray.Length; ++index1)
        num4 += Math.Pow(numArray[index1] - num3, 2.0);
      return Math.Sqrt(num4 / (double) (length - 1)) * 100.0 * Math.Sqrt(span);
    }

    
    public static double Value(DoubleSeries input, int index, int length, double span)
    {
      return HV.Value((TimeSeries) input, index, length, span, BarData.Close);
    }

    
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.Monitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + this.fLength - 1); ++Index)
        this.Calculate(Index);
    }
  }
}
