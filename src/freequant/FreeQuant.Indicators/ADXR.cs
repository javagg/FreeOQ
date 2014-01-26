using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class ADXR : Indicator
  {
    protected EIndicatorStyle fStyle;
    protected int fLength;
    protected ADX fADX;

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

    [Description("")]
    [Category("Parameters")]
    [IndicatorParameter(1)]
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

    
		public ADXR(): base()
    {
      this.fLength = 14;
      this.Init();
    }

    
		public ADXR(TimeSeries input, int length, EIndicatorStyle style)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.fStyle = style;
      this.Init();
    }

    
		public ADXR(TimeSeries input, int length, EIndicatorStyle style, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.fStyle = style;
      this.Init();
      this.Color = color;
    }

    
    public ADXR(TimeSeries input, int length, EIndicatorStyle style, Color color, EDrawStyle drawStyle)
			: base(input)  {
      this.fLength = 14;
      this.fLength = length;
      this.fStyle = style;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
		public ADXR(TimeSeries input, int length):base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

    
		public ADXR(TimeSeries input, int length, Color color) : base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name = "ADXR" + (object) this.fLength;
			this.Title = "ADXR" ;
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
			if (TimeSeries.nameOption == ENameOption.Long)
        this.Name = this.fInput.Name + this.Name;
      this.Disconnect();
      if (this.fADX != null)
        this.fADX.Detach();
      this.fADX = new ADX(this.fInput, this.fLength, this.fStyle);
      this.fADX.DrawEnabled = false;
      this.Connect();
    }

    
    protected override void Calculate(int index)
    {
      if (index >= 3 * this.fLength - 1 + this.fInput.FirstIndex)
      {
        int num = -(Indicator.SyncIndex ? 0 : 1) * 2 * this.fLength;
        double Data = (this.fADX[index + num] + this.fADX[index - this.fLength + 1 + num]) / 2.0;
        this.Add(this.fInput.GetDateTime(index), Data);
      }
      else
        this.Add(this.fInput.GetDateTime(index), double.NaN);
    }

    
    public static double Value(TimeSeries input, int index, int length, EIndicatorStyle style)
    {
      if (index >= 3 * length - 1 + input.FirstIndex)
        return (ADX.Value(input, index, length, style) + ADX.Value(input, index - length + 1, length, style)) / 2.0;
      else
        return double.NaN;
    }

    
    public static double Value(TimeSeries input, int index, int length)
    {
      return ADXR.Value(input, index, length, EIndicatorStyle.QuantStudio);
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
        for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + 3 * this.fLength - 1); ++Index)
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
      this.fADX.Detach();
      base.Detach();
    }
  }
}
