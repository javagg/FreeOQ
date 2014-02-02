using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class CMO : Indicator
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

    
		public CMO(): base()
    {
      this.fLength = 14;
      this.Init();
    }

    
    public CMO(TimeSeries input, int length, BarData option)
			: base(input)  {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
    }

    
    public CMO(TimeSeries input, int length, BarData option, Color color)
			: base(input) {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
    }

    
    public CMO(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle)
			: base(input)   {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
		public CMO(TimeSeries input, int length)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

    
		public CMO(TimeSeries input, int length, Color color)	: base(input) 
    {
      this.fLength = 14;
         this.fLength = length;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name = "CMO"+ (object) this.fLength;
			this.Title = "CMO";
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
				this.Name = "CMO" + (object) this.fLength + (string) (object) this.fOption;
			if (TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = CMO.Value(this.fInput, index, this.fLength, this.fOption);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length, BarData option)
    {
      double num1 = 0.0;
      double num2 = 0.0;
      if (index < length + input.FirstIndex)
        return double.NaN;
      for (int index1 = index; index1 > index - length; --index1)
      {
        double num3 = input[index1, option] - input[index1 - 1, option];
        if (num3 > 0.0)
          num1 += num3;
        else
          num2 -= num3;
      }
      return 100.0 * (num1 - num2) / (num1 + num2);
    }

    
    public static double Value(DoubleSeries input, int index, int length)
    {
      return CMO.Value((TimeSeries) input, index, length, BarData.Close);
    }

    
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.Monitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + this.fLength); ++Index)
        this.Calculate(Index);
    }
  }
}
