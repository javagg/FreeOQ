using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class SMV : Indicator
  {
    protected int fLength;
    protected BarData fOption;

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

    
		public SMV(): base()
    {
     this.fLength = 14;
      this.Init();
    }

    
		public SMV(TimeSeries input, int length, BarData option):base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
    }

    
		public SMV(TimeSeries input, int length, BarData option, Color color):base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
    }

    
    public SMV(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle)
			:base(input){
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
		public SMV(TimeSeries input, int length):base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name =   (object) this.fLength +"";
			this.Title = "SMV";
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
        this.Name =  (object) this.fLength + (string) (object) this.fOption;
			if (TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name  + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = SMV.Value(this.fInput, index, this.fLength, this.fOption);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length, BarData option)
    {
      if (index < length - 1 + input.FirstIndex)
        return double.NaN;
      double num1 = 0.0;
      double num2 = SMA.Value(input, index, length, option);
      for (int index1 = index; index1 > index - length; --index1)
        num1 += (num2 - input[index1, option]) * (num2 - input[index1, option]);
      return num1 / (double) length;
    }

    
    public static double Value(DoubleSeries input, int index, int length)
    {
      return SMV.Value((TimeSeries) input, index, length, BarData.Close);
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
