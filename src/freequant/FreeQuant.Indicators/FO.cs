using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class FO : Indicator
  {
    protected int fLength;
    protected BarData fOption;
    protected RegressionDistanceMode distanceMode;

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

    [Category("Parameters")]
    [Description("")]
    [IndicatorParameter(2)]
    public RegressionDistanceMode DistanceMode
    {
       get
      {
        return this.distanceMode;
      }
       set
      {
        this.distanceMode = value;
        this.Init();
      }
    }

    
		public FO(): base()
    {
      this.fLength = 14;
      this.Init();
    }

    
		public FO(TimeSeries input, int length, BarData option)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
    }

    
		public FO(TimeSeries input, int length, BarData option, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
    }

    
    public FO(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle)
			: base(input)   {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
		public FO(TimeSeries input, int length)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

    
		public FO(TimeSeries input, int length, Color color)	: base(input) 
    {
      this.fLength = 14;
          this.fLength = length;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name = "FO" + (object) this.fLength;
			this.Title ="FO";
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
				this.Name = "FO" + (object) this.fLength + (string) (object) this.fOption;
			if (TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name  + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = FO.Value(this.fInput, index, this.fLength, this.fOption, this.distanceMode);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length, BarData option, RegressionDistanceMode distanceMode)
    {
      if (index < length - 1 + input.FirstIndex)
        return double.NaN;
      double num1 = input[index, option];
      double num2 = LRI.Value(input, index, length, option, distanceMode);
      return 100.0 * (num1 - num2) / num2;
    }

    
    public static double Value(DoubleSeries input, int index, int length, RegressionDistanceMode distanceMode)
    {
      return FO.Value((TimeSeries) input, index, length, BarData.Close, distanceMode);
    }

    
    public static double Value(DoubleSeries input, int index, int length)
    {
      return FO.Value((TimeSeries) input, index, length, BarData.Close, RegressionDistanceMode.Time);
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
