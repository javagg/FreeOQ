using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class KRI : Indicator
  {
    protected int fLength;
    protected BarData fOption;

    [Category("Parameters")]
    [IndicatorParameter(1)]
    [Description("")]
    public BarData Option
    {
       get
      {
        return this.fOption;
      }
       set
      {
        this.fOption = value;
        this.Init();
      }
    }

    [IndicatorParameter(0)]
    [Description("")]
    [Category("Parameters")]
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

    
		public KRI(): base()
    {
     this.fLength = 14;
      this.Init();
    }

    
		public KRI(TimeSeries input, int length, BarData option)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
    }

    
		public KRI(TimeSeries input, int length, BarData option, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
    }

    
    public KRI(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle)
			: base(input)   {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    public KRI(TimeSeries input, int length)
			: base(input)  {
      this.fLength = 14;

      this.fLength = length;
      this.Init();
    }

    
    public KRI(TimeSeries input, int length, Color color)
			: base(input)    {
      this.fLength = 14;

      this.fLength = length;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name = "KRI" + (object) this.fLength;
			this.Title =  "KRI";
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
				this.Name =  "KRI" + (object) this.fLength + (string) (object) this.fOption;
			if (TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = KRI.Value(this.fInput, index, this.fLength, this.fOption);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length, BarData option)
    {
      if (index < length - 1 + input.FirstIndex)
        return double.NaN;
      double num = SMA.Value(input, index, length, option);
      return (input[index, option] - num) / num * 100.0;
    }

    
    public static double Value(DoubleSeries input, int index, int length)
    {
      return KRI.Value((TimeSeries) input, index, length, BarData.Close);
    }

    
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.Monitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + this.fLength - 1); ++Index)
        this.Calculate(Index);
    }
  }
}
