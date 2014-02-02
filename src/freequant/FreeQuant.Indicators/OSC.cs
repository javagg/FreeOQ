using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class OSC : Indicator
  {
    protected int fLength1;
    protected int fLength2;
    protected BarData fOption;

    [IndicatorParameter(2)]
    [Description("")]
    [Category("Parameters")]
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
    public int Length1
    {
       get
      {
        return this.fLength1;
      }
       set
      {
        this.fLength1 = value;
        this.Init();
      }
    }

    [Description("")]
    [IndicatorParameter(1)]
    [Category("Parameters")]
    public int Length2
    {
       get
      {
        return this.fLength2;
      }
       set
      {
        this.fLength2 = value;
        this.Init();
      }
    }

    
		public OSC(): base()
    {
      this.fLength1 = 14;
      this.fLength2 = 20;
      this.Init();
    }

    
		public OSC(TimeSeries input, int length1, int length2, BarData option)	: base(input) 
    {
      this.fLength1 = 14;
      this.fLength2 = 20;
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.fOption = option;
      this.Init();
    }

    
    public OSC(TimeSeries input, int length1, int length2, BarData option, Color color)
			: base(input) {
      this.fLength1 = 14;
      this.fLength2 = 20;
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.fOption = option;
      this.Init();
      this.Color = color;
    }

    
    public OSC(TimeSeries input, int length1, int length2, BarData option, Color color, EDrawStyle drawStyle)
			: base(input)  {
      this.fLength1 = 14;
      this.fLength2 = 20;
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.fOption = option;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
		public OSC(TimeSeries input, int length1, int length2)	: base(input) 
    {
      this.fLength1 = 14;
      this.fLength2 = 20;
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.Init();
    }

    
		public OSC(TimeSeries input, int length1, int length2, Color color)	: base(input) 
    {
      this.fLength1 = 14;
      this.fLength2 = 20;
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name = "OSC"+ (object) this.fLength1 + (string) (object) this.fLength2;
			this.Title = "OSC";
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
				this.Name = "OSC"+ (object) this.fLength1 + (string) (object) this.fLength2 + (string) (object) this.fOption;
			if (TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = OSC.Value(this.fInput, index, this.fLength1, this.fLength2, this.fOption);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length1, int length2, BarData option)
    {
      if (index >= length1 - 1 + input.FirstIndex && index >= length2 - 1 + input.FirstIndex)
        return SMA.Value(input, index, length1, option) - SMA.Value(input, index, length2, option);
      else
        return double.NaN;
    }

    
    public static double Value(DoubleSeries input, int index, int length1, int length2)
    {
      return OSC.Value((TimeSeries) input, index, length1, length2, BarData.Close);
    }

    
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.Monitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + Math.Max(this.fLength1, this.fLength2) - 1); ++Index)
        this.Calculate(Index);
    }
  }
}
