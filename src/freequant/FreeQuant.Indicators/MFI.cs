using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class MFI : Indicator
  {
    protected int fLength;

    [Category("Parameters")]
    [IndicatorParameter(0)]
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

    
		public MFI(): base()
    {
      this.fLength = 14;
      this.Init();
    }

    
		public MFI(TimeSeries input, int length)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

    
		public MFI(TimeSeries input, int length, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
      this.Color = color;
    }

    
		public MFI(TimeSeries input, int length, Color color, EDrawStyle drawStyle)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
			this.Name = "MFI" + (object) this.fLength;
			this.Title =  "MFI";
      this.Clear();
      this.fCalculate = true;
			if (this.fInput == null || TimeSeries.nameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = MFI.Value(this.fInput, index, this.fLength);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length)
    {
      if (index < length + input.FirstIndex)
        return double.NaN;
      double num1 = 0.0;
      double num2 = 0.0;
      for (int index1 = index; index1 > index - length; --index1)
      {
        double num3 = input[index1, BarData.Typical];
        double num4 = input[index1 - 1, BarData.Typical];
        double num5 = input[index1, BarData.Volume];
        double num6 = input[index1 - 1, BarData.Volume];
        if (num3 > num4)
          num1 += num3 * num5;
        else
          num2 += num3 * num5;
      }
      return 100.0 - 100.0 / (1.0 + num1 / num2);
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
