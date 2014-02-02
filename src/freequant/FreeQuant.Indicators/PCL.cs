using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class PCL : Indicator
  {
    protected int fLength;

    [IndicatorParameter(0)]
    [Category("Parameters")]
    [Description("")]
    public int Length
    {
       get
      {
        return this.fLength;
      }
       set
      {
        this.fLength = value;
        this.Init();
      }
    }

    
		public PCL(): base()
    {
      this.fLength = 14;
      this.Init();
    }

    
		public PCL(TimeSeries input, int length) 	: base(input) 
		   {
			this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

    
		public PCL(TimeSeries input, int length, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
      this.Color = color;
    }

    
		public PCL(TimeSeries input, int length, Color color, EDrawStyle drawStyle)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
			this.Name = "PCL" + this.fLength.ToString();
			this.Title ="PCL";
      this.fType = EIndicatorType.Price;
      this.Clear();
      this.fCalculate = true;
			if (this.fInput == null || TimeSeries.fNameOption != ENameOption.Long)
        return;
			this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = PCL.Value(this.fInput, index, this.fLength);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length)
    {
      if (index >= length + input.FirstIndex)
        return input.GetMin(index - length, index - 1, BarData.Low);
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
      for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + this.fLength); ++Index)
        this.Calculate(Index);
    }
  }
}
