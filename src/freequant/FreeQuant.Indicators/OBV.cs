using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class OBV : Indicator
  {
    
		public OBV(): base()
    {
      this.Init();
    }

    
		public OBV(TimeSeries input)	: base(input) 
    {
      this.Init();
    }

    
		public OBV(TimeSeries input, Color color)	: base(input) 
    {
      this.Init();
      this.Color = color;
    }

    
		public OBV(TimeSeries input, Color color, EDrawStyle drawStyle)	: base(input) 
    {
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
			this.Name = "OBV";
			this.Title ="OBV";
      this.fType = EIndicatorType.Volume;
      this.Clear();
      this.fCalculate = true;
			if (this.fInput == null || TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = double.NaN;
      if (index >= 1 + this.fInput.FirstIndex)
      {
        double num1 = this.fInput[index, BarData.Close];
        double num2 = this.fInput[index - 1, BarData.Close];
        double num3 = this.fInput[index, BarData.Volume];
        int num4 = -(Indicator.SyncIndex ? 0 : 1);
        if (index > 1 + this.fInput.FirstIndex)
        {
          if (num1 > num2)
            Data = this[index - 1 + num4] + num3;
          if (num1 < num2)
            Data = this[index - 1 + num4] - num3;
          if (num1 == num2)
            Data = this[index - 1 + num4];
        }
        else
        {
          if (num1 > num2)
            Data = num3;
          if (num1 < num2)
            Data = -num3;
          if (num1 == num2)
            Data = 0.0;
        }
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
      double num4 = 0.0;
      if (index > 1 + input.FirstIndex)
      {
        if (num1 > num2)
          num4 = OBV.Value(input, index - 1) + num3;
        if (num1 < num2)
          num4 = OBV.Value(input, index - 1) - num3;
        if (num1 == num2)
          num4 = OBV.Value(input, index - 1);
      }
      else
      {
        if (num1 > num2)
          num4 = num3;
        if (num1 < num2)
          num4 = -num3;
        if (num1 == num2)
          num4 = 0.0;
      }
      return num4;
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
