using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class EMV : Indicator
  {
    
		public EMV(): base()
    {
      this.Init();
    }

    
		public EMV(TimeSeries input)	: base(input) 
    {
      this.Init();
    }

    
		public EMV(TimeSeries input, Color color)	: base(input) 
    {
      this.Init();
      this.Color = color;
    }

    
		public EMV(TimeSeries input, Color color, EDrawStyle drawStyle)	: base(input) 
    {
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
			this.Name = "EMV";
			this.Title =  "EMV";
      this.Clear();
      this.fCalculate = true;
			if (this.fInput == null || TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = EMV.Value(this.fInput, index);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index)
    {
      if (index < input.FirstIndex + 1)
        return double.NaN;
      double num1 = input[index, BarData.High];
      double num2 = input[index - 1, BarData.High];
      double num3 = input[index, BarData.Low];
      double num4 = input[index - 1, BarData.Low];
      double num5 = input[index, BarData.Volume];
      return ((num1 + num3) / 2.0 - (num2 + num4) / 2.0) / (num5 / 1000000.0 / (num1 - num3));
    }

    
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.Monitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + 1); ++Index)
        this.Calculate(Index);
    }
  }
}
