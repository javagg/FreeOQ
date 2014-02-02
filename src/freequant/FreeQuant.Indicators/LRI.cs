using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class LRI : Indicator
  {
    protected int fLength;
    protected BarData fOption;
    private RegressionDistanceMode aKF3Bglmd;

    [Category("Parameters")]
    [IndicatorParameter(1)]
    [Description("")]
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

    [Description("")]
    [IndicatorParameter(2)]
    [Category("Parameters")]
    public RegressionDistanceMode DistanceMode
    {
       get
      {
        return this.aKF3Bglmd;
      }
       set
      {
        this.aKF3Bglmd = value;
        this.Init();
      }
    }

    
		public LRI(): base()
    {
      this.fLength = 14;
      this.Init();
    }

    
		public LRI(TimeSeries input, int length, BarData option)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
    }

    
		public LRI(TimeSeries input, int length, BarData option, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
    }

    
    public LRI(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle)
			: base(input)   {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    public LRI(TimeSeries input, int length)
			: base(input)  {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

    
		public LRI(TimeSeries input, int length, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name ="LRI" + (object) this.fLength ;
			this.Title = "LRI";
      this.fType = EIndicatorType.Price;
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
				this.Name ="LRI" + (object) this.fLength + (string) (object) this.fOption;
			if (TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = LRI.Value(this.fInput, index, this.fLength, this.fOption, this.aKF3Bglmd);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length, BarData option, RegressionDistanceMode distanceMode)
    {
      if (index < length - 1)
        return double.NaN;
      double x = 0.0;
      double num1 = 0.0;
      double num2 = 0.0;
      double num3 = 0.0;
      double num4;
      if (distanceMode == RegressionDistanceMode.Time)
      {
        double num5 = (double) input.GetDateTime(index).Subtract(input.GetDateTime(index - 1)).Ticks;
        for (int index1 = index; index1 > index - length; --index1)
        {
          x += (double) input.GetDateTime(index1).Subtract(input.GetDateTime(index - length + 1)).Ticks / num5;
          num1 += (double) input.GetDateTime(index1).Subtract(input.GetDateTime(index - length + 1)).Ticks / num5 * input[index1, option];
          num2 += input[index1, option];
          num3 += (double) input.GetDateTime(index1).Subtract(input.GetDateTime(index - length + 1)).Ticks / num5 * (double) input.GetDateTime(index1).Subtract(input.GetDateTime(index - length + 1)).Ticks / num5;
        }
        num4 = (double) input.GetDateTime(index).Subtract(input.GetDateTime(index - length + 1)).Ticks / num5;
      }
      else
      {
        for (int index1 = index; index1 > index - length; --index1)
        {
          x += (double) (index1 - index + length - 1);
          num1 += (double) (index1 - index + length - 1) * input[index1, option];
          num2 += input[index1, option];
          num3 += (double) ((index1 - index + length - 1) * (index1 - index + length - 1));
        }
        num4 = (double) (length - 1);
      }
      double num6 = ((double) length * num1 - x * num2) / ((double) length * num3 - Math.Pow(x, 2.0));
      double num7 = (num2 - num6 * x) / (double) length;
      return num6 * num4 + num7;
    }

    
    public static double Value(DoubleSeries input, int index, int length, RegressionDistanceMode distanceMode)
    {
      return LRI.Value((TimeSeries) input, index, length, BarData.Close, distanceMode);
    }

    
    public static double Value(DoubleSeries input, int index, int length)
    {
      return LRI.Value((TimeSeries) input, index, length, BarData.Close, RegressionDistanceMode.Time);
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
