using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class KCU : Indicator
  {
    protected int fLength;

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

    
		public KCU(): base()
    {
      this.fLength = 14;
      this.Init();
    }

    
		public KCU(TimeSeries input, int length)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

    
		public KCU(TimeSeries input, int length, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
      this.Color = color;
    }

    
		public KCU(TimeSeries input, int length, Color color, EDrawStyle drawStyle)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
			this.Name = "KCU" + (object) this.fLength;
			this.Title = "KCU";
      this.Clear();
      this.fCalculate = true;
			if (this.fInput == null || TimeSeries.nameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = KCU.Value(this.fInput, index, this.fLength);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length)
    {
      if (index < length + input.FirstIndex)
        return double.NaN;
      double num1 = 0.0;
      for (int index1 = index - length + 1; index1 <= index; ++index1)
        num1 += TR.Value(input, index1);
      double num2 = num1 / (double) length;
      return SMA.Value(input, index, length, BarData.Typical) + num2;
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
