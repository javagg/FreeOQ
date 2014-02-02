using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class LRS : Indicator
  {
    protected int fLength;
    protected BarData fOption;
    private RegressionDistanceMode Kr2Tm3VVG;

    [Category("Parameters")]
    [Description("")]
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
    [IndicatorParameter(0)]
    [Description("")]
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
    [IndicatorParameter(2)]
    public RegressionDistanceMode DistanceMode
    {
      get
      {
        return this.Kr2Tm3VVG;
      }
      set
      {
        this.Kr2Tm3VVG = value;
        this.Init();
      }
    }

    
		public LRS(): base()
    {
      this.fLength = 14;
      this.Init();
    }

    
		public LRS(TimeSeries input, int length, BarData option)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
    }

    
		public LRS(TimeSeries input, int length, BarData option, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
    }

    
    public LRS(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle)
			: base(input) {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
		public LRS(TimeSeries input, int length)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

    
		public LRS(TimeSeries input, int length, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name = "LRS" + (object) this.fLength;
			this.Title = "LRS";
      this.fType = EIndicatorType.Oscillator;
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
				this.Name = "LRS"+ (object) this.fLength + (string) (object) this.fOption;
			if (TimeSeries.fNameOption != ENameOption.Long)
        return;
			this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = LRS.Value(this.fInput, index, this.fLength, this.fOption, this.Kr2Tm3VVG);
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
      if (distanceMode == RegressionDistanceMode.Time)
      {
        double num4 = (double) input.GetDateTime(index).Subtract(input.GetDateTime(index - 1)).Ticks;
        for (int index1 = index; index1 > index - length; --index1)
        {
          x += (double) input.GetDateTime(index1).Subtract(input.GetDateTime(index - length + 1)).Ticks / num4;
          num1 += (double) input.GetDateTime(index1).Subtract(input.GetDateTime(index - length + 1)).Ticks / num4 * input[index1, option];
          num2 += input[index1, option];
          num3 += (double) input.GetDateTime(index1).Subtract(input.GetDateTime(index - length + 1)).Ticks / num4 * (double) input.GetDateTime(index1).Subtract(input.GetDateTime(index - length + 1)).Ticks / num4;
        }
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
      }
      return ((double) length * num1 - x * num2) / ((double) length * num3 - Math.Pow(x, 2.0));
    }

    
    public static double Value(DoubleSeries input, int index, int length, RegressionDistanceMode distanceMode)
    {
      return LRS.Value((TimeSeries) input, index, length, BarData.Close, distanceMode);
    }

    
    public static double Value(DoubleSeries input, int index, int length)
    {
      return LRS.Value((TimeSeries) input, index, length, BarData.Close, RegressionDistanceMode.Time);
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
