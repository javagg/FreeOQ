using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class MOM : Indicator
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

    
		public MOM(): base()
    {
     this.fLength = 14;
      this.Init();
    }

    
		public MOM(TimeSeries input, int length, BarData option)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
    }

    
		public MOM(TimeSeries input, int length, BarData option, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
    }

    
    public MOM(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle)
			: base(input)  {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
		public MOM(TimeSeries input, int length)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

    
		public MOM(TimeSeries input, int length, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name = "MOM"+ (object) this.fLength;
			this.Title = "MOM";
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
				this.Name = "MOM" + (object) this.fLength + (string) (object) this.fOption;
			if (TimeSeries.nameOption != ENameOption.Long)
        return;
			this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = MOM.Value(this.fInput, index, this.fLength, this.fOption);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length, BarData option)
    {
      if (index >= length - 1 + input.FirstIndex)
        return input[index, option] - input[index - length + 1, option];
      else
        return double.NaN;
    }

    
    public static double Value(DoubleSeries input, int index, int length)
    {
      return MOM.Value(input, index, length);
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
