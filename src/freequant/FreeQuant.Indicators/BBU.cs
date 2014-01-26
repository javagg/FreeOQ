using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class BBU : Indicator
  {
    protected int fLength;
    protected double fK;
    protected BarData fOption;

    [Description("")]
    [Category("Parameters")]
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
    [IndicatorParameter(1)]
    [Description("")]
    public double K
    {
       get
      {
        return this.fK;
      }
       set
      {
        this.fK = value;
        this.Init();
      }
    }

    
		public BBU(): base()
    {
      this.fLength = 14;
      this.fK = 3.0;
      this.Init();
    }

    
    public BBU(TimeSeries input, int length, double k, BarData option)
			: base(input)   {
      this.fLength = 14;
      this.fK = 3.0;
      this.fLength = length;
      this.fOption = option;
      this.fK = k;
      this.Init();
    }

    
    public BBU(TimeSeries input, int length, double k, BarData option, Color color)
			: base(input)  {
      this.fLength = 14;
      this.fK = 3.0;
      this.fLength = length;
      this.fOption = option;
      this.fK = k;
      this.Init();
      this.Color = color;
    }

    
    public BBU(TimeSeries input, int length, double k, BarData option, Color color, EDrawStyle drawStyle)
			: base(input)  {
      this.fLength = 14;
      this.fK = 3.0;
      this.fLength = length;
      this.fOption = option;
      this.fK = k;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    public BBU(TimeSeries input, int length, double k)
			: base(input)  {
      this.fLength = 14;
      this.fK = 3.0;
      this.fLength = length;
      this.fK = k;
      this.Init();
    }

    
    public BBU(TimeSeries input, int length, double k, Color color)
			: base(input)   {
      this.fLength = 14;
      this.fK = 3.0;
      this.fLength = length;
      this.fK = k;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name = "BBU" + (object) this.fLength + (string) (object) this.fK;
			this.Title = "BBU";
      this.fType = EIndicatorType.Price;
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
        this.Name =  (object) this.fLength + (string) (object) this.fK + (string) (object) this.fOption;
			if (TimeSeries.nameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = BBU.Value(this.fInput, index, this.fLength, this.fK, this.fOption);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length, double k, BarData option)
    {
      if (index >= length - 1 + input.FirstIndex)
        return SMA.Value(input, index, length, option) + k * SMD.Value(input, index, length, option);
      else
        return double.NaN;
    }

    
    public static double Value(DoubleSeries input, int index, int length, double k)
    {
      return BBU.Value((TimeSeries) input, index, length, k, BarData.Close);
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
