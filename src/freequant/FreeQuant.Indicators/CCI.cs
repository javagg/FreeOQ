using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class CCI : Indicator
  {
    protected int fLength;

    [Description("")]
    [IndicatorParameter(0)]
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

    
		public CCI(): base()
    {
      this.fLength = 14;
      this.Init();
    }

    
		public CCI(TimeSeries input, int length)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

    
		public CCI(TimeSeries input, int length, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
      this.Color = color;
    }

    
		public CCI(TimeSeries input, int length, Color color, EDrawStyle drawStyle)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
			this.Name = "CCI" + (object) this.fLength ;
			this.Title = "CCI";
      this.Clear();
      this.fCalculate = true;
			if (this.fInput == null || TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = CCI.Value(this.fInput, index, this.fLength);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length)
    {
      if (index < length - 1 + input.FirstIndex)
        return double.NaN;
      double num1 = 0.0;
      for (int index1 = index - length + 1; index1 <= index; ++index1)
        num1 += input[index1, BarData.Typical];
      double num2 = num1 / (double) length;
      double num3 = 0.0;
      for (int index1 = index - length + 1; index1 <= index; ++index1)
        num3 += Math.Abs(input[index1, BarData.Typical] - num2);
      double num4 = num3 / (double) length;
      return (input[index, BarData.Typical] - num2) / (0.015 * num4);
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
