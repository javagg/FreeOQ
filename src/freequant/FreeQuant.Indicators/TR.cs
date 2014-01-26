using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class TR : Indicator
  {
    
		public TR(): base()
    {
      this.Init();
    }

    
		public TR(TimeSeries input): base(input)
    {
      this.Init();
    }

    
		public TR(TimeSeries input, Color color): base(input)
    {
      this.Init();
      this.Color = color;
    }

    
		public TR(TimeSeries input, Color color, EDrawStyle drawStyle): base(input)
    {
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
			this.Name ="TR";
			this.Title = "TR";
      this.Clear();
      this.fCalculate = true;
			if (this.fInput == null || TimeSeries.nameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name +  this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = TR.Value(this.fInput, index);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index)
    {
      if (index < input.FirstIndex + 1)
        return double.NaN;
      double num1 = input[index, BarData.High];
      double num2 = input[index, BarData.Low];
      double num3 = input[index - 1, BarData.Close];
      return Math.Max(Math.Abs(num1 - num2), Math.Max(Math.Abs(num1 - num3), Math.Abs(num3 - num2)));
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
