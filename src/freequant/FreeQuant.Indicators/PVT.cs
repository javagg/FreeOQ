using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class PVT : Indicator
  {
    
		public PVT(): base()
    {
      this.Init();
    }

    
		public PVT(TimeSeries input)	: base(input) 
    {
      this.Init();
    }

    
		public PVT(TimeSeries input, Color color)	: base(input) 
    {
      this.Init();
      this.Color = color;
    }

    
		public PVT(TimeSeries input, Color color, EDrawStyle drawStyle)	: base(input) 
    {
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
			this.Name = "PVT";
			this.Title = "PVT";
      this.fType = EIndicatorType.Volume;
      this.Clear();
      this.fCalculate = true;
			if (this.fInput == null || TimeSeries.nameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name +  this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = double.NaN;
      if (index >= 1 + this.fInput.FirstIndex)
      {
        double num1 = this.fInput[index, BarData.Close];
        double num2 = this.fInput[index - 1, BarData.Close];
        double num3 = this.fInput[index, BarData.Volume];
        if (index >= 2 + this.fInput.FirstIndex)
        {
          int num4 = -(Indicator.SyncIndex ? 0 : 1);
          Data = (num1 - num2) / num2 * num3 + this[index - 1 + num4];
          this.Add(this.fInput.GetDateTime(index), Data);
        }
        else
          Data = (num1 - num2) / num2 * num3;
      }
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index)
    {
      if (index < 1 + input.FirstIndex)
        return double.NaN;
      double num1 = input[index, BarData.Close];
      double num2 = input[index - 1, BarData.Close];
      double num3 = input[index, BarData.Volume];
      return index < 2 + input.FirstIndex ? (num1 - num2) / num2 * num3 : (num1 - num2) / num2 * num3 + PVT.Value(input, index - 1);
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
