using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class RSI : Indicator
  {
    protected EIndicatorStyle fStyle;
    protected int fLength;
    protected BarData fOption;
    protected DoubleSeries fUp;
    protected DoubleSeries fDown;

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

    [Category("Parameters")]
    [Description("")]
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

    [Category("Parameters")]
    [Description("")]
    [IndicatorParameter(2)]
    public EIndicatorStyle Style
    {
       get
      {
        return this.fStyle;
      }
       set
      {
        this.fStyle = value;
        this.Init();
      }
    }

    
		public RSI(): base()
    {
      this.fLength = 14;
      this.Init();
    }

    
    public RSI(TimeSeries input, int length, BarData option, EIndicatorStyle style)
			: base(input){
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.fStyle = style;
      this.Init();
    }

    
    public RSI(TimeSeries input, int length, BarData option, EIndicatorStyle style, Color color)
			: base(input) {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.fStyle = style;
      this.Init();
      this.Color = color;
    }

    
    public RSI(TimeSeries input, int length, BarData option, EIndicatorStyle style, Color color, EDrawStyle drawStyle)
			: base(input)  {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.fStyle = style;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
		public RSI(TimeSeries input, int length, BarData option)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
    }

    
		public RSI(TimeSeries input, int length, EIndicatorStyle style)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.fStyle = style;
      this.Init();
    }

    
		public RSI(TimeSeries input, int length)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

    
		public RSI(TimeSeries input, int length, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name = "RSI"+ this.fLength.ToString();
			this.Title = "RSI";
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
				this.Name = "RSI" + (object) this.fLength + (string) (object) this.fOption;
			if (TimeSeries.nameOption == ENameOption.Long)
        this.Name = this.fInput.Name + this.Name;
      this.fUp = new DoubleSeries();
      this.fDown = new DoubleSeries();
    }

    
    protected override void Calculate(int index)
    {
      double Data1 = 0.0;
      double Data2 = 0.0;
      double Data3 = double.NaN;
      if (index >= this.fLength + this.fInput.FirstIndex)
      {
        if (this.fStyle == EIndicatorStyle.QuantStudio)
        {
          if (index == this.fLength + this.fInput.FirstIndex)
          {
            double num1 = this.fInput[index - this.fLength, this.fOption];
            for (int index1 = index - this.fLength + 1; index1 <= index; ++index1)
            {
              double num2 = this.fInput[index1, this.fOption];
              if (num2 > num1)
                Data1 += num2 - num1;
              else
                Data2 += num1 - num2;
              num1 = num2;
            }
          }
          else
          {
            Data1 = this.fUp[index - 1] * (double) this.fLength;
            Data2 = this.fDown[index - 1] * (double) this.fLength;
            double num1 = this.fInput[index, this.fOption];
            double num2 = this.fInput[index - 1, this.fOption];
            if (num1 > num2)
              Data1 += num1 - num2;
            else
              Data2 += num2 - num1;
            double num3 = this.fInput[index - this.fLength, this.fOption];
            double num4 = this.fInput[index - this.fLength - 1, this.fOption];
            if (num3 > num4)
              Data1 -= num3 - num4;
            else
              Data2 -= num4 - num3;
          }
        }
        else if (index == this.fLength + this.fInput.FirstIndex)
        {
          double num1 = this.fInput[index - this.fLength, this.fOption];
          for (int index1 = index - this.fLength + 1; index1 <= index; ++index1)
          {
            double num2 = this.fInput[index1, this.fOption];
            if (num2 > num1)
              Data1 += num2 - num1;
            else
              Data2 += num1 - num2;
            num1 = num2;
          }
        }
        else
        {
          Data1 = this.fUp[index - 1] * (double) (this.fLength - 1);
          Data2 = this.fDown[index - 1] * (double) (this.fLength - 1);
          double num1 = this.fInput[index, this.fOption];
          double num2 = this.fInput[index - 1, this.fOption];
          if (num1 > num2)
            Data1 += num1 - num2;
          else
            Data2 += num2 - num1;
        }
        Data3 = 100.0 - 100.0 / (1.0 + Data1 / Data2);
        Data1 /= (double) this.fLength;
        Data2 /= (double) this.fLength;
      }
      this.Add(this.fInput.GetDateTime(index), Data3);
      this.fUp.Add(this.fInput.GetDateTime(index), Data1);
      this.fDown.Add(this.fInput.GetDateTime(index), Data2);
    }

    
    public static double Value(TimeSeries input, int index, int length, BarData option, EIndicatorStyle style)
    {
      double num1 = 0.0;
      double num2 = 0.0;
      if (index < length + input.FirstIndex)
        return double.NaN;
      if (style == EIndicatorStyle.QuantStudio)
      {
        double num3 = input[index - length, option];
        for (int index1 = index - length + 1; index1 <= index; ++index1)
        {
          double num4 = input[index1, option];
          if (num4 > num3)
            num1 += num4 - num3;
          else
            num2 += num3 - num4;
          num3 = num4;
        }
      }
      else
      {
        double num3 = input[input.FirstIndex, option];
        for (int index1 = 1 + input.FirstIndex; index1 <= length + input.FirstIndex; ++index1)
        {
          double num4 = input[index1, option];
          if (num4 > num3)
            num1 += num4 - num3;
          else
            num2 += num3 - num4;
          num3 = num4;
        }
        num1 /= (double) length;
        num2 /= (double) length;
        double num5 = input[length + input.FirstIndex, option];
        for (int index1 = length + 1 + input.FirstIndex; index1 <= index; ++index1)
        {
          double num4 = num1 * (double) (length - 1);
          double num6 = num2 * (double) (length - 1);
          double num7 = input[index1, option];
          if (num7 > num5)
            num4 += num7 - num5;
          else
            num6 += num5 - num7;
          num5 = num7;
          num1 = num4 / (double) length;
          num2 = num6 / (double) length;
        }
      }
      return 100.0 - 100.0 / (1.0 + num1 / num2);
    }

    
    public static double Value(DoubleSeries input, int index, int length, EIndicatorStyle style)
    {
      return RSI.Value((TimeSeries) input, index, length, BarData.Close, style);
    }

    
    public static double Value(TimeSeries input, int index, int length, BarData option)
    {
      return RSI.Value(input, index, length, option, EIndicatorStyle.QuantStudio);
    }

    
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.Monitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      if (this.fStyle == EIndicatorStyle.QuantStudio)
      {
        for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + this.fLength); ++Index)
          this.Calculate(Index);
      }
      else
      {
        for (int Index = index; Index <= this.fInput.Count - 1; ++Index)
          this.Calculate(Index);
      }
    }
  }
}
