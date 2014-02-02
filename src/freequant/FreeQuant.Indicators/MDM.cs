using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class MDM : Indicator
  {
    
		public MDM(): base()
    {
      this.Init();
    }

    
		public MDM(TimeSeries input)	: base(input) 
    {
      this.Init();
    }

    
		public MDM(TimeSeries input, Color color)	: base(input) 
    {
      this.Init();
      this.Color = color;
    }

    
		public MDM(TimeSeries input, Color color, EDrawStyle drawStyle)	: base(input) 
    {
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
			this.Name = "MDM";
			this.Title = "MDM";
      this.Clear();
      this.fCalculate = true;
			if (this.fInput == null || TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = MDM.Value(this.fInput, index);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index)
    {
      if (index < input.FirstIndex + 1)
        return double.NaN;
      double num1 = input[index, BarData.High];
      double num2 = input[index, BarData.Low];
      double num3 = input[index - 1, BarData.High];
      double num4 = input[index - 1, BarData.Low];
      double num5 = 0.0;
      double num6 = 0.0;
      if (num1 > num3)
        num5 = num1 - num3;
      if (num2 < num4)
        num6 = num4 - num2;
      if (num6 > num5)
        return num6;
      else
        return 0.0;
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
