using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class ATR : Indicator
  {
    protected EIndicatorStyle fStyle;
    protected int fLength;

    [Description("")]
    [IndicatorParameter(0)]
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

    [Category("Parameters")]
    [IndicatorParameter(1)]
    [Description("")]
    public EIndicatorStyle Style
    {
       get
      {
        return this.fStyle;
      }
       set
      {
        this.fStyle = value;
        this.Init();
      }
    }

    
		public ATR(): base()
    {
      this.fLength = 14;
      this.Init();
    }

    
		public ATR(TimeSeries input, int length, EIndicatorStyle style)	: base(input) 
    {
      this.fLength = 14;
       this.fLength = length;
      this.fStyle = style;
      this.Init();
    }

    
		public ATR(TimeSeries input, int length, EIndicatorStyle style, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.fStyle = style;
      this.Init();
      this.Color = color;
    }

    
    public ATR(TimeSeries input, int length, EIndicatorStyle style, Color color, EDrawStyle drawStyle)
			: base(input)  {
      this.fLength = 14;
      this.fLength = length;
      this.fStyle = style;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
		public ATR(TimeSeries input, int length)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

    
		public ATR(TimeSeries input, int length, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name = "ATR" + (object) this.fLength;
			this.Title = "ATR";
      this.Clear();
      this.fCalculate = true;
			if (this.fInput == null || TimeSeries.nameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name  + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      if (index >= this.fLength + this.fInput.FirstIndex)
      {
        int num1 = -(Indicator.SyncIndex ? 0 : 1) * this.fLength;
        double Data;
        if (this.fStyle == EIndicatorStyle.QuantStudio)
        {
          if (index == this.fLength + this.fInput.FirstIndex)
          {
            double num2 = 0.0;
            for (int index1 = index; index1 > index - this.fLength; --index1)
              num2 += TR.Value(this.fInput, index1);
            Data = num2 / (double) this.fLength;
          }
          else
          {
            double num2 = TR.Value(this.fInput, index);
            Data = (this[index - 1 + num1] * (double) this.fLength + num2 - TR.Value(this.fInput, index - this.fLength)) / (double) this.fLength;
          }
        }
        else if (index == this.fLength + this.fInput.FirstIndex)
        {
          double num2 = 0.0;
          for (int index1 = index; index1 > index - this.fLength; --index1)
            num2 += TR.Value(this.fInput, index1);
          Data = num2 / (double) this.fLength;
        }
        else
        {
          double num2 = TR.Value(this.fInput, index);
          Data = (this[this.fInput.GetDateTime(index - 1)] * (double) this.fLength + num2 - TR.Value(this.fInput, index - this.fLength)) / (double) this.fLength;
        }
        this.Add(this.fInput.GetDateTime(index), Data);
      }
      else
        this.Add(this.fInput.GetDateTime(index), double.NaN);
    }

    
    public static double Value(TimeSeries input, int index, int length, EIndicatorStyle style)
    {
      if (index < length + input.FirstIndex)
        return double.NaN;
      double num1 = 0.0;
      double num2;
      if (style == EIndicatorStyle.QuantStudio)
      {
        for (int index1 = index; index1 > index - length; --index1)
          num1 += TR.Value(input, index1);
        num2 = num1 / (double) length;
      }
      else
      {
        for (int index1 = length + input.FirstIndex; index1 > input.FirstIndex; --index1)
          num1 += TR.Value(input, index1);
        double num3 = num1 / (double) length;
        for (int index1 = length + 1 + input.FirstIndex; index1 <= index; ++index1)
          num3 = (num3 * (double) (length - 1) + TR.Value(input, index1)) / (double) length;
        num2 = num3;
      }
      return num2;
    }

    
    public static double Value(TimeSeries input, int index, int length)
    {
      return ATR.Value(input, index, length, EIndicatorStyle.QuantStudio);
    }

    
    public static double Value(TimeSeries input, int length)
    {
      return ATR.Value(input, input.LastIndex, length);
    }

    
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.Monitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      if (this.fStyle == EIndicatorStyle.QuantStudio)
      {
        for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + this.fLength); ++Index)
          this.Calculate(Index);
      }
      else
      {
        for (int Index = index; Index <= this.fInput.Count - 1; ++Index)
          this.Calculate(Index);
      }
    }
  }
}
