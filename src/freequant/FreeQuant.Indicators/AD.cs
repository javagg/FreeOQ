using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class AD : Indicator
  {
    
		public AD(): base()
    {
      this.Init();
    }

    
		public AD(TimeSeries input):base(input)
    {
      this.Init();
    }

    
		public AD(TimeSeries input, Color color):base(input)
    {
      this.Init();
      this.Color = color;
    }

    
		public AD(TimeSeries input, Color color, EDrawStyle drawStyle):base(input)
    {
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
			this.Name = "AD";
			this.Title = "AD";
      this.Clear();
      this.fCalculate = true;
			if (this.fInput == null || TimeSeries.nameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name  + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double num1 = this.fInput[index, BarData.High];
      double num2 = this.fInput[index, BarData.Low];
      double num3 = this.fInput[index, BarData.Close];
      double num4 = this.fInput[index, BarData.Open];
      double num5 = this.fInput[index, BarData.Volume];
      double Data = double.NaN;
      if (index >= this.fInput.FirstIndex + 1)
      {
        int num6 = -(Indicator.SyncIndex ? 0 : 1);
        Data = num1 == num2 ? this[index - 1 + num6] : num5 * (num3 - num2 - (num1 - num3)) / (num1 - num2) + this[index - 1];
      }
      if (index == this.fInput.FirstIndex && num1 != num2)
        Data = num5 * (num3 - num2 - (num1 - num3)) / (num1 - num2);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index)
    {
      double num1 = 0.0;
      if (index >= input.FirstIndex)
      {
        double num2 = input[index, BarData.High];
        double num3 = input[index, BarData.Low];
        double num4 = input[index, BarData.Close];
        double num5 = input[index, BarData.Open];
        double num6 = input[index, BarData.Volume];
        if (index >= input.FirstIndex + 1)
          num1 = num2 == num3 ? AD.Value(input, index - 1) : num6 * (num4 - num3 - (num2 - num4)) / (num2 - num3) + AD.Value(input, index - 1);
        if (index == input.FirstIndex && num2 != num3)
          num1 = num6 * (num4 - num3 - (num2 - num4)) / (num2 - num3);
      }
      else
        num1 = double.NaN;
      return num1;
    }

    
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= this.fInput.Count - 1; ++Index)
        this.Calculate(Index);
    }
  }
}
