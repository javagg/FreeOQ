using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class WMA : Indicator
  {
    protected int fLength;
    protected BarData fOption;

    [Category("Parameters")]
    [IndicatorParameter(0)]
    [Description("Length of Weighted Moving Average")]
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

    [IndicatorParameter(1)]
    [Category("Parameters")]
    [Description("Which type of data to average")]
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

    
		public WMA() : base()
    {
      this.fLength = 14;
      this.Init();
    }

    
		public WMA(TimeSeries input, int length, BarData option):base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
    }

    
		public WMA(TimeSeries input, int length, BarData option, Color color):base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
    }

    
		public WMA(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle):base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
		public WMA(TimeSeries input, int length):base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

    
    protected override void Init()
    {
//      this.fName =  this.fLength;
//			this.fTitle = "title";
      this.fType = EIndicatorType.Price;
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
				this.fName =  this.Length  + (string) (object) this.fOption;
			if (TimeSeries.fNameOption != ENameOption.Long)
        return;
			this.fName = this.fInput.Name + this.fName;
    }

    
    protected override void Calculate(int index)
    {
      if (index < this.Length - 1 + this.Input.FirstIndex)
      {
        this.Add(this.fInput.GetDateTime(index), double.NaN);
      }
      else
      {
        double num1 = 0.0;
        for (int index1 = 1; index1 != this.Length + 1; ++index1)
          num1 += (double) index1;
        double num2 = 0.0;
        int index2 = index;
        int length = this.Length;
        while (index - (this.Length - 1) <= index2)
        {
          num2 += this.Input[index2, this.fOption] * (double) length;
          --index2;
          --length;
        }
        double Data = num2 / num1;
        this.Add(this.fInput.GetDateTime(index), Data);
      }
    }

    
    public static double Value(TimeSeries input, int index, int length, BarData option)
    {
      double num1 = 0.0;
      double num2;
      if (index < length - 1 + input.FirstIndex)
      {
        num2 = double.NaN;
      }
      else
      {
        double num3 = 0.0;
        for (int index1 = 1; index1 != length + 1; ++index1)
          num3 += (double) index1;
        int index2 = index;
        int num4 = length;
        while (index - (length - 1) <= index2)
        {
          num1 += input[index2, option] * (double) num4;
          --index2;
          --num4;
        }
        num2 = num1 / num3;
      }
      return num2;
    }

    
    public static double Value(DoubleSeries input, int index, int length)
    {
      return WMA.Value((TimeSeries) input, index, length, BarData.Close);
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
