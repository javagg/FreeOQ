using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class VCH : Indicator
  {
    protected int fLength1;
    protected int fLength2;
    protected EMA fEMA;
    protected DoubleSeries fHL_array;

    [Description("")]
    [Category("Parameters")]
    [IndicatorParameter(0)]
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

    
		public VCH(): base()
    {
      this.fLength1 = 14;
      this.fLength2 = 10;
      this.Init();
    }

    
		public VCH(TimeSeries input, int length1, int length2):base(input)
    {
      this.fLength1 = 14;
      this.fLength2 = 10;
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.Init();
    }

    
		public VCH(TimeSeries input, int length1, int length2, Color color): base(input)
    {
      this.fLength1 = 14;
      this.fLength2 = 10;
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.Init();
      this.Color = color;
    }

    
    public VCH(TimeSeries input, int length1, int length2, Color color, EDrawStyle drawStyle)
			:base(input) {
      this.fLength1 = 14;
      this.fLength2 = 10;
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
			this.Name =  this.fLength1.ToString()  + this.fLength2.ToString();
			this.Title = "VCH";
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
			if (TimeSeries.fNameOption == ENameOption.Long)
        this.Name = this.fInput.Name +  this.Name;
      this.fHL_array = new DoubleSeries();
      for (int index = 0; index < this.fInput.Count; ++index)
        this.fHL_array.Add(this.fInput.GetDateTime(index), this.fInput[index, BarData.High] - this.fInput[index, BarData.Low]);
      this.fEMA = new EMA((TimeSeries) this.fHL_array, this.fLength1);
      this.fEMA.DrawEnabled = false;
    }

    
    protected override void Calculate(int index)
    {
      double Data = double.NaN;
      if (index >= this.fLength2 - 1 + this.fInput.FirstIndex)
      {
        int index1 = this.fEMA.GetIndex(this.fInput.GetDateTime(index));
        Data = (this.fEMA[index1] - this.fEMA[index1 - this.fLength2 + 1]) / this.fEMA[index1 - this.fLength2 + 1] * 100.0;
      }
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length1, int length2)
    {
      if (index < length2 - 1 + input.FirstIndex)
        return double.NaN;
      DoubleSeries doubleSeries = new DoubleSeries();
      for (int index1 = 0; index1 <= index; ++index1)
        doubleSeries.Add(input.GetDateTime(index1), input[index1, BarData.High] - input[index1, BarData.Low]);
      EMA ema = new EMA((TimeSeries) doubleSeries, length1, BarData.Close);
      return (ema[index] - ema[index - length2 + 1]) / ema[index - length2 + 1] * 100.0;
    }

    
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1 || !this.Monitored)
        return;
      for (int Index = index; Index <= this.fInput.Count - 1; ++Index)
        this.Calculate(Index);
    }

    
    protected override void OnInputItemAdded2(object sender, DateTimeEventArgs EventArgs)
    {
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index != -1)
        this.fHL_array.Add(this.fInput.GetDateTime(index), this.fInput[index, BarData.High] - this.fInput[index, BarData.Low]);
      base.OnInputItemAdded2(sender, EventArgs);
    }
  }
}
