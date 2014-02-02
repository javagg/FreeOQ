using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class Range : Indicator
  {
    protected int length;

    [Category("Parameters")]
    [Description("")]
    [IndicatorParameter(0)]
    public int Length
    {
       get
      {
        return this.length;
      }
       set
      {
        this.length = value;
        this.Init();
      }
    }

    
		public Range(): base()
    {
      this.length = 14;
      this.Init();
    }

    
		public Range(TimeSeries input, int length)	: base(input) 
    {
      this.length = 14;
      this.length = length;
      this.Init();
    }

    
		public Range(TimeSeries input, int length, Color color)	: base(input) 
    {
      this.length = 14;
      this.length = length;
      this.Init();
			this.color = color;
    }

    
    public Range(TimeSeries input, int length, Color color, EDrawStyle drawStyle)
			: base(input)  {
      this.length = 14;
      this.length = length;
      this.Init();
			this.color = color;
      this.fDrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
			this.Name = "Range" + (object) this.length;
			this.Title ="Range";
      this.Clear();
      this.fCalculate = true;
			if (this.fInput == null || TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = Range.Value(this.fInput, index, this.length);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length)
    {
      if (index < length - 1 + input.FirstIndex)
        return double.NaN;
      double min = input.GetMin(index - length + 1, index, BarData.Low);
      return Math.Log(input.GetMax(index - length + 1, index, BarData.High) / min);
    }

    
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.Monitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + this.length - 1); ++Index)
        this.Calculate(Index);
    }
  }
}
