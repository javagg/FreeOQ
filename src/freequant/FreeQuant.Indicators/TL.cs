using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class TL : Indicator
  {
    
		public TL(): base()
    {
      this.Init();
    }

    
	public TL(TimeSeries input):base(input)
    {
      this.Init();
    }

    
	public TL(TimeSeries input, Color color): base(input)
    {
      this.Init();
      this.Color = color;
    }

    
		public TL(TimeSeries input, Color color, EDrawStyle drawStyle) : base(input)
    {
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
			this.Name = "TL";
			this.Title = "tL";
      this.Clear();
      this.fCalculate = true;
			if (this.fInput == null || TimeSeries.nameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = TL.Value(this.fInput, index);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index)
    {
      if (index >= 1 + input.FirstIndex)
        return Math.Min(input[index, BarData.Low], input[index - 1, BarData.Close]);
      else
        return double.NaN;
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
