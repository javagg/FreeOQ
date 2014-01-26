using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class ENVL : Indicator
  {
    protected int fLength;
    protected double fShift;
    protected BarData fOption;

    [Description("")]
    [Category("Parameters")]
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
    [IndicatorParameter(1)]
    [Category("Parameters")]
    public double Shift
    {
       get
      {
        return this.fShift;
      }
       set
      {
        this.fShift = value;
        this.Init();
      }
    }

    
		public ENVL(): base()
    {
      this.fLength = 14;
      this.fShift = 20.0;
      this.Init();
    }

    
		public ENVL(TimeSeries input, int length, double shift, BarData option)	: base(input) 
    {
      this.fLength = 14;
      this.fShift = 20.0;
      this.fLength = length;
      this.fShift = shift;
      this.fOption = option;
      this.Init();
    }

    
    public ENVL(TimeSeries input, int length, double shift, BarData option, Color color)
			: base(input)   {
      this.fLength = 14;
      this.fShift = 20.0;
      this.fLength = length;
      this.fShift = shift;
      this.fOption = option;
      this.Init();
      this.Color = color;
    }

    
    public ENVL(TimeSeries input, int length, double shift, BarData option, Color color, EDrawStyle drawStyle)
			: base(input) {
      this.fLength = 14;
      this.fShift = 20.0;
      this.fLength = length;
      this.fShift = shift;
      this.fOption = option;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
		public ENVL(TimeSeries input, int length, double shift)	: base(input) 
    {
      this.fLength = 14;
      this.fShift = 20.0;
      this.fLength = length;
      this.fShift = shift;
      this.Init();
    }

    
		public ENVL(TimeSeries input, int length, double shift, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fShift = 20.0;
      this.fLength = length;
      this.fShift = shift;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name = "ENVL" + (object) this.fLength + (string) (object) this.fShift;
			this.Title ="ENVL" ;
      this.fType = EIndicatorType.Price;
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
				this.Name = "ENVL" + (object) this.fLength + (string) (object) this.fShift + (string) (object) this.fOption;
			if (TimeSeries.nameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name  + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = ENVL.Value(this.fInput, index, this.fLength, this.fShift, this.fOption);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length, double shift, BarData option)
    {
      if (index < length - 1 + input.FirstIndex)
        return double.NaN;
      double num = SMA.Value(input, index, length, option);
      return num - num * (shift / 100.0);
    }

    
    public static double Value(DoubleSeries input, int index, int length, double shift)
    {
      return ENVL.Value((TimeSeries) input, index, length, shift, BarData.Close);
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
