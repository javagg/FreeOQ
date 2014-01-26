using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class TRIX : Indicator
  {
    protected EMA fEMA;
    protected EMA fEMA_2;
    protected EMA fEMA_3;
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

    
		public TRIX(): base()
    {
      this.fLength = 14;
      this.Init();
    }

    
		public TRIX(TimeSeries input, int length, BarData option):  base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
    }

    
		public TRIX(TimeSeries input, int length, BarData option, Color color):  base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
    }

    
    public TRIX(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle)
			:  base(input){
      this.fLength = 14;
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
		public TRIX(TimeSeries input, int length):  base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

    
		public TRIX(TimeSeries input, int length, Color color):  base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name =  this.fLength.ToString();
			this.Title = "TRIX";
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
        this.Name = this.fLength + (string) (object) this.fOption;
			if (TimeSeries.nameOption == ENameOption.Long)
        this.Name = this.fInput.Name + this.Name;
      this.Disconnect();
      if (this.fEMA != null)
        this.fEMA.Detach();
      if (this.fEMA_2 != null)
        this.fEMA_2.Detach();
      if (this.fEMA_3 != null)
        this.fEMA_3.Detach();
      this.fEMA = new EMA(this.fInput, this.fLength, this.fOption);
      this.Connect();
      this.fEMA_2 = new EMA((TimeSeries) this.fEMA, this.fLength, this.fOption);
      this.fEMA_3 = new EMA((TimeSeries) this.fEMA_2, this.fLength, this.fOption);
      this.fEMA.DrawEnabled = false;
      this.fEMA_2.DrawEnabled = false;
      this.fEMA_3.DrawEnabled = false;
    }

    
    protected override void Calculate(int index)
    {
      double Data = double.NaN;
      if (index >= 1 + this.fInput.FirstIndex)
        Data = (this.fEMA_3[index] - this.fEMA_3[index - 1]) / this.fEMA_3[index - 1] * 100.0;
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length, BarData option)
    {
      if (index < 1 + input.FirstIndex)
        return double.NaN;
      DoubleSeries doubleSeries = new DoubleSeries();
      for (int firstIndex = input.FirstIndex; firstIndex <= index; ++firstIndex)
        doubleSeries.Add(input.GetDateTime(firstIndex), input[firstIndex, option]);
      EMA ema = new EMA((TimeSeries) new EMA((TimeSeries) new EMA((TimeSeries) doubleSeries, length, option), length, option), length, option);
      return (ema[index - input.FirstIndex] - ema[index - 1 - input.FirstIndex]) / ema[index - 1 - input.FirstIndex] * 100.0;
    }

    
    public static double Value(DoubleSeries input, int index, int length)
    {
      return TRIX.Value((TimeSeries) input, index, length, BarData.Close);
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
      this.fEMA.Detach();
      base.Detach();
    }
  }
}
