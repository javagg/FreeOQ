using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class EMA : Indicator
  {
    protected int fLength;
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

    [IndicatorParameter(0)]
    [Description("")]
    [Category("Parameters")]
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

    
    public EMA()
    {
      this.fLength = 14;
      this.Init();
    }

    
		public EMA(TimeSeries input, int length, BarData option)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
    }

    
		public EMA(TimeSeries input, int length, BarData option, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
    }

    
    public EMA(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle)
			: base(input) {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
		public EMA(TimeSeries input, int length)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

    
		public EMA(TimeSeries input, int length, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name = "EMA" + (object) this.fLength ;
			this.Title = "EMA";
      this.fType = EIndicatorType.Price;
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
				this.Name = "EMA" + (object) this.fLength +  (string) (object) this.fOption;
			if (TimeSeries.nameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = double.NaN;
      if (index >= this.fInput.FirstIndex + 1)
      {
        double num = 2.0 / (double) (this.fLength + 1);
        double last = this.Last;
        Data = last + num * (this.fInput[index, this.fOption] - last);
      }
      if (index == this.fInput.FirstIndex)
        Data = this.fInput[this.fInput.FirstIndex, this.fOption];
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length, BarData option)
    {
      if (index >= input.FirstIndex + 1)
      {
        double num1 = 2.0 / (double) (length + 1);
        double num2 = EMA.Value(input, index - 1, length, option);
        return num2 + num1 * (input[index, option] - num2);
      }
      else if (index == input.FirstIndex)
        return input[input.FirstIndex, option];
      else
        return double.NaN;
    }

    
    public static double Value(DoubleSeries input, int index, int length)
    {
      return EMA.Value((TimeSeries) input, index, length, BarData.Close);
    }

    
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= this.fInput.Count - 1; ++Index)
        this.Calculate(Index);
    }
  }
}
