using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class WAD : Indicator
  {
    
		public WAD() : base()
    {
      this.Init();
    }

    
		public WAD(TimeSeries input):  base(input)
    {
      this.Init();
    }

    
		public WAD(TimeSeries input, Color color) : base(input)
    {
      this.Init();
      this.Color = color;
    }

    
		public WAD(TimeSeries input, Color color, EDrawStyle drawStyle) : base(input)
    {
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
			this.Name = "dfdfs";
			this.Title = "dfdfs";
      this.Clear();
      this.fCalculate = true;
			if (this.fInput == null || TimeSeries.nameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name  + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = 0.0;
      if (index >= this.fInput.FirstIndex + 1)
      {
        double val1_1 = this.fInput[index, BarData.High];
        double val1_2 = this.fInput[index, BarData.Low];
        double num1 = this.fInput[index, BarData.Close];
        double val2 = this.fInput[index - 1, BarData.Close];
        double num2 = this.fInput[index, BarData.Volume];
        if (num1 > val2)
          Data = this[index - 1] + num1 - Math.Min(val1_2, val2);
        if (num1 < val2)
          Data = this[index - 1] + num1 - Math.Max(val1_1, val2);
        if (num1 == val2)
          Data = this[index - 1];
      }
      else
        Data = 0.0;
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index)
    {
      if (index < input.FirstIndex + 1)
        return 0.0;
      double val1_1 = input[index, BarData.High];
      double val1_2 = input[index, BarData.Low];
      double num1 = input[index, BarData.Close];
      double val2 = input[index - 1, BarData.Close];
      double num2 = 0.0;
      double num3 = input[index, BarData.Volume];
      if (num1 > val2)
        num2 = WAD.Value(input, index - 1) + num1 - Math.Min(val1_2, val2);
      if (num1 < val2)
        num2 = WAD.Value(input, index - 1) + num1 - Math.Max(val1_1, val2);
      if (num1 == val2)
        num2 = WAD.Value(input, index - 1);
      return num2;
    }

    
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.Monitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= this.fInput.Count - 1; ++Index)
        this.Calculate(Index);
    }
  }
}
