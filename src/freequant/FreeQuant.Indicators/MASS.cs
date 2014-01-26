using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class MASS : Indicator
  {
    protected int fLength;
    protected int fOrder;
    protected EMA fEMA;
    protected EMA fEMA_ema;
    protected DoubleSeries fHL_array;

    [Description("")]
    [Category("Parameters")]
    [IndicatorParameter(0)]
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
    [Description("")]
    [IndicatorParameter(1)]
    public int Order
    {
       get
      {
        return this.fOrder;
      }
       set
      {
        this.fOrder = value;
        this.Init();
      }
    }

    
		public MASS(): base()
    {
      this.fLength = 14;
      this.fOrder = 10;
      this.Init();
    }

    
		public MASS(TimeSeries input, int length, int order)	: base(input) 
    {
      this.fLength = 14;
      this.fOrder = 10;
      this.fLength = length;
      this.fOrder = order;
      this.Init();
    }

    
		public MASS(TimeSeries input, int length, int order, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fOrder = 10;
      this.fLength = length;
      this.fOrder = order;
      this.Init();
      this.Color = color;
    }

    
    public MASS(TimeSeries input, int length, int order, Color color, EDrawStyle drawStyle)
			: base(input)   {
      this.fLength = 14;
      this.fOrder = 10;
      this.fLength = length;
      this.fOrder = order;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
			this.Name = "MASS" + (object) this.fLength  + (string) (object) this.fOrder;
			this.Title =  "MASS";
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
			if (TimeSeries.nameOption == ENameOption.Long)
        this.Name = this.fInput.Name + this.Name;
      this.fHL_array = new DoubleSeries();
      for (int index = 0; index < this.fInput.Count; ++index)
        this.fHL_array.Add(this.fInput.GetDateTime(index), this.fInput[index, BarData.High] - this.fInput[index, BarData.Low]);
      this.fEMA = new EMA((TimeSeries) this.fHL_array, this.fOrder);
      this.fEMA_ema = new EMA((TimeSeries) this.fEMA, this.fOrder);
      this.fEMA.DrawEnabled = false;
      this.fEMA_ema.DrawEnabled = false;
    }

    
    protected override void Calculate(int index)
    {
      double Data = 0.0;
      if (index >= this.fLength - 1 + this.fInput.FirstIndex)
      {
        for (int index1 = index; index1 > index - this.fLength; --index1)
          Data += this.fEMA[index1] / this.fEMA_ema[index1];
        this.Add(this.fInput.GetDateTime(index), Data);
      }
      else
        this.Add(this.fInput.GetDateTime(index), double.NaN);
    }

    
    public static double Value(TimeSeries input, int index, int length, int order)
    {
      if (index < length - 1 + input.FirstIndex)
        return double.NaN;
      DoubleSeries doubleSeries = new DoubleSeries();
      double num = 0.0;
      for (int index1 = 0; index1 <= index; ++index1)
        doubleSeries.Add(input.GetDateTime(index1), input[index1, BarData.High] - input[index1, BarData.Low]);
      EMA ema1 = new EMA((TimeSeries) doubleSeries, order, BarData.Close);
      EMA ema2 = new EMA((TimeSeries) ema1, order, BarData.Close);
      for (int index1 = index; index1 > index - length; --index1)
        num += ema1[index1] / ema2[index1];
      return num;
    }

    
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      this.fHL_array.Add(this.fInput.GetDateTime(index), this.fInput[index, BarData.High] - this.fInput[index, BarData.Low]);
      if (!this.Monitored)
        return;
      for (int Index = index; Index <= this.fInput.Count - 1; ++Index)
        this.Calculate(Index);
    }
  }
}
