using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class MarketFI : Indicator
  {
    
		public MarketFI(): base()
    {
      this.Init();
    }

    
		public MarketFI(TimeSeries input)	: base(input) 
    {
      this.Init();
    }

    
		public MarketFI(TimeSeries input, Color color)	: base(input) 
    {
      this.Init();
      this.Color = color;
    }

    
		public MarketFI(TimeSeries input, Color color, EDrawStyle drawStyle)	: base(input) 
    {
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
			this.Name = "MarketFI";
			this.Title = "MarketFI";
      this.Clear();
      this.fCalculate = true;
			if (this.fInput == null || TimeSeries.nameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = MarketFI.Value(this.fInput, index);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index)
    {
      if (index < input.FirstIndex)
        return double.NaN;
      double num1 = input[index, BarData.High];
      double num2 = input[index, BarData.Low];
      double num3 = input[index, BarData.Volume];
      return num3 == 0.0 ? 0.0 : (num1 - num2) / num3 * 1000.0;
    }
  }
}
