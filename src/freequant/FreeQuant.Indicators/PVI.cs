using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class PVI : Indicator
  {
   
		public PVI(): base()
    {

      this.Init();
    }

   
		public PVI(TimeSeries input)	: base(input) 
    {
      this.Init();
    }

   
		public PVI(TimeSeries input, Color color)	: base(input) 
    {
      this.Init();
      this.Color = color;
    }

   
		public PVI(TimeSeries input, Color color, EDrawStyle drawStyle)	: base(input) 
    {
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

   
    protected override void Init()
    {
			this.Name = "PVI";
			this.Title =  "PVI";
      this.fType = EIndicatorType.Volume;
      this.Clear();
      this.fCalculate = true;
			if (this.fInput == null || TimeSeries.nameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name  + this.Name;
    }

   
    protected override void Calculate(int index)
    {
      double Data = double.NaN;
      if (index >= 1 + this.fInput.FirstIndex)
      {
        double num1 = this.fInput[index, BarData.Close];
        double num2 = this.fInput[index - 1, BarData.Close];
        double num3 = this.fInput[index, BarData.Volume];
        double num4 = this.fInput[index - 1, BarData.Volume];
        double num5 = this[index - 1];
        Data = num3 <= num4 ? num5 : num5 + num5 * (num1 - num2) / num2;
      }
      if (index == this.fInput.FirstIndex)
        Data = 10000.0;
      this.Add(this.fInput.GetDateTime(index), Data);
    }

   
    public static double Value(TimeSeries input, int index)
    {
      if (index >= 1 + input.FirstIndex)
      {
        double num1 = input[index, BarData.Close];
        double num2 = input[index - 1, BarData.Close];
        double num3 = input[index, BarData.Volume];
        double num4 = input[index - 1, BarData.Volume];
        double num5 = PVI.Value(input, index - 1);
        return num3 <= num4 ? num5 : num5 + num5 * (num1 - num2) / num2;
      }
      else
        return index == input.FirstIndex ? 10000.0 : double.NaN;
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
