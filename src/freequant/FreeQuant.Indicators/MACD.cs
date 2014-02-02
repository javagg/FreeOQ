using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class MACD : Indicator
  {
    protected int fLength1;
    protected int fLength2;
    protected BarData fOption;
    protected EMA fEMA1;
    protected EMA fEMA2;

    [Category("Parameters")]
    [Description("")]
    [IndicatorParameter(2)]
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

    [Category("Parameters")]
    [IndicatorParameter(0)]
    [Description("")]
    public int Length1
    {
       get
      {
        return this.fLength1;
      }
       set
      {
        this.fLength1 = value;
        this.Init();
      }
    }

    [Description("")]
    [Category("Parameters")]
    [IndicatorParameter(1)]
    public int Length2
    {
       get
      {
        return this.fLength2;
      }
       set
      {
        this.fLength2 = value;
        this.Init();
      }
    }

    
		public MACD(): base()
    {
      this.fLength1 = 14;
      this.fLength2 = 10;
      this.Init();
    }

    
    public MACD(TimeSeries input, int length1, int length2, BarData option)
			: base(input)  {
      this.fLength1 = 14;
      this.fLength2 = 10;
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.fOption = option;
      this.Init();
    }

    
    public MACD(TimeSeries input, int length1, int length2, BarData option, Color color)
			: base(input)    {
      this.fLength1 = 14;
      this.fLength2 = 10;
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.fOption = option;
      this.Init();
      this.Color = color;
    }

    
    public MACD(TimeSeries input, int length1, int length2, BarData option, Color color, EDrawStyle drawStyle)
			: base(input) {
      this.fLength1 = 14;
      this.fLength2 = 10;
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.fOption = option;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    public MACD(TimeSeries input, int length1, int length2)
			: base(input)  {
      this.fLength1 = 14;
      this.fLength2 = 10;
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.Init();
    }

    
    public MACD(TimeSeries input, int length1, int length2, Color color)
			: base(input)   {
      this.fLength1 = 14;
      this.fLength2 = 10;
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name = "MACD"+ (object) this.fLength1 + (string) (object) this.fLength2;
			this.Title = "MACD";
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
				this.Name = "MACD" + (object) this.fLength1 + (string) (object) this.fLength2  + (string) (object) this.fOption;
			if (TimeSeries.fNameOption == ENameOption.Long)
        this.Name = this.fInput.Name +  this.Name;
      this.Disconnect();
      if (this.fEMA1 != null)
        this.fEMA1.Detach();
      if (this.fEMA2 != null)
        this.fEMA2.Detach();
      this.fEMA1 = new EMA(this.fInput, this.fLength1, this.fOption);
      this.fEMA2 = new EMA(this.fInput, this.fLength2, this.fOption);
      this.Connect();
      this.fEMA1.DrawEnabled = false;
      this.fEMA2.DrawEnabled = false;
    }

    
    protected override void Calculate(int index)
    {
      if (index >= this.fInput.FirstIndex)
      {
        double Data = this.fEMA1[index] - this.fEMA2[index];
        this.Add(this.fInput.GetDateTime(index), Data);
      }
      else
        this.Add(this.fInput.GetDateTime(index), double.NaN);
    }

    
    public static double Value(TimeSeries input, int index, int length1, int length2, BarData option)
    {
      if (index >= input.FirstIndex)
        return EMA.Value(input, index, length1, option) - EMA.Value(input, index, length2, option);
      else
        return double.NaN;
    }

    
    public static double Value(DoubleSeries input, int index, int length1, int length2)
    {
      return MACD.Value((TimeSeries) input, index, length1, length2, BarData.Close);
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

    
    public override void Detach()
    {
      this.fEMA1.Detach();
      this.fEMA2.Detach();
      base.Detach();
    }
  }
}
