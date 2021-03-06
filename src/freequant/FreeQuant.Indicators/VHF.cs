using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class VHF : Indicator
  {
    protected int fLength;
    protected BarData fOption;

    [IndicatorParameter(1)]
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

    
		public VHF(): base()
    {
      this.fLength = 14;
      this.Init();
    }

    
		public VHF(TimeSeries input, int length, BarData option):base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
    }

    
		public VHF(TimeSeries input, int length, BarData option, Color color):base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
    }

    
		public VHF(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle):base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
		public VHF(TimeSeries input, int length):base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

    
		public VHF(TimeSeries input, int length, Color color):base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name =  this.fLength.ToString();
			this.Title = "Title";
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
				this.Name = this.fLength + (string) (object) this.fOption;
			if (TimeSeries.fNameOption != ENameOption.Long)
        return;
			this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = VHF.Value(this.fInput, index, this.fLength, this.fOption);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length, BarData option)
    {
      if (index < length + input.FirstIndex)
        return double.NaN;
      double num1 = Math.Abs(input.GetMax(index - length + 1, index, option) - input.GetMin(index - length + 1, index, option));
      double num2 = 0.0;
      for (int index1 = index; index1 > index - length; --index1)
        num2 += Math.Abs(input[index1, option] - input[index1 - 1, option]);
      return num1 / num2;
    }

    
    public static double Value(DoubleSeries input, int index, int length)
    {
      return VHF.Value((TimeSeries) input, index, length, BarData.Close);
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
