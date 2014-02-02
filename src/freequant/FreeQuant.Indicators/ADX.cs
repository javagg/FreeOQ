using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class ADX : Indicator
  {
    protected EIndicatorStyle fStyle;
    protected int fLength;
    protected DX fDX;

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

    
		public ADX(): base()
    {
      this.fLength = 14;
      this.Init();
    }

    
    public ADX(TimeSeries input, int length, EIndicatorStyle style)
			: base(input)  {
      this.fLength = 14;
      this.fLength = length;
      this.fStyle = style;
      this.Init();
    }

    
    public ADX(TimeSeries input, int length, EIndicatorStyle style, Color color)
			: base(input)    {
      this.fLength = 14;
      this.fLength = length;
      this.fStyle = style;
      this.Init();
      this.Color = color;
    }

    
    public ADX(TimeSeries input, int length, EIndicatorStyle style, Color color, EDrawStyle drawStyle)
			: base(input)    {
      this.fLength = 14;
      this.fLength = length;
      this.fStyle = style;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
		public ADX(TimeSeries input, int length)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

    
		public ADX(TimeSeries input, int length, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name = "ADX" + (object) this.fLength;
			this.Title = "ADX";
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
			if (TimeSeries.fNameOption == ENameOption.Long)
        this.Name = this.fInput.Name + this.Name;
      this.Disconnect();
      if (this.fDX != null)
        this.fDX.Detach();
      this.fDX = new DX(this.fInput, this.fLength, this.fStyle);
      this.fDX.DrawEnabled = false;
      this.Connect();
    }

    
    protected override void Calculate(int index)
    {
      if (index >= 2 * this.fLength + this.fInput.FirstIndex)
      {
        double num1 = 0.0;
        int num2 = -(Indicator.SyncIndex ? 0 : 1) * 2 * this.fLength;
        int num3 = -(Indicator.SyncIndex ? 0 : 1) * this.fLength;
        if (index == 2 * this.fLength + this.fInput.FirstIndex)
        {
          for (int index1 = index; index1 > index - this.fLength; --index1)
            num1 += this.fDX[index1 + num3];
        }
        else
          num1 = this.fStyle != EIndicatorStyle.QuantStudio ? this[index - 1 + num2] * (double) (this.fLength - 1) + this.fDX[index + num3] : this[index - 1 + num2] * (double) this.fLength - this.fDX[index - this.fLength + num3] + this.fDX[index + num3];
        double Data = num1 / (double) this.fLength;
        this.Add(this.fInput.GetDateTime(index), Data);
      }
      else
        this.Add(this.fInput.GetDateTime(index), double.NaN);
    }

    
    public static double Value(TimeSeries input, int index, int length, EIndicatorStyle style)
    {
      if (index < 2 * length + input.FirstIndex)
        return double.NaN;
      double num1 = 0.0;
      double num2;
      if (style == EIndicatorStyle.QuantStudio)
      {
        for (int index1 = index; index1 > index - length; --index1)
          num1 += DX.Value(input, index1, length);
        num2 = num1 / (double) length;
      }
      else
      {
        for (int index1 = 2 * length + input.FirstIndex; index1 > length + input.FirstIndex; --index1)
          num1 += DX.Value(input, index1, length, style);
        double num3 = num1 / (double) length;
        for (int index1 = 2 * length + 1 + input.FirstIndex; index1 <= index; ++index1)
          num3 = (num3 * (double) (length - 1) + DX.Value(input, index1, length, style)) / (double) length;
        num2 = num3;
      }
      return num2;
    }

    
    public static double Value(TimeSeries input, int index, int length)
    {
      return ADX.Value(input, index, length, EIndicatorStyle.QuantStudio);
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
        for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + 2 * this.fLength); ++Index)
          this.Calculate(Index);
      }
      else
      {
        for (int Index = index; Index <= this.fInput.Count - 1; ++Index)
          this.Calculate(Index);
      }
    }

    
    public override void Detach()
    {
      this.fDX.Detach();
      base.Detach();
    }
  }
}
