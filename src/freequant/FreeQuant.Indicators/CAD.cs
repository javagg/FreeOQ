using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class CAD : Indicator
  {
    protected EMA fEMA1;
    protected EMA fEMA2;
    protected AD fAD;
    protected int fLength1;
    protected int fLength2;

    [Description("")]
    [IndicatorParameter(0)]
    [Category("Parameters")]
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
    [IndicatorParameter(1)]
    [Category("Parameters")]
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

    
		public CAD(): base()
    {
      this.fLength1 = 3;
      this.fLength2 = 10;
      this.Init();
    }

    
		public CAD(TimeSeries input, int length1, int length2)	: base(input) 
    {
      this.fLength1 = 3;
      this.fLength2 = 10;
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.Init();
    }

    
		public CAD(TimeSeries input, int length1, int length2, Color color)	: base(input) 
    {
      this.fLength1 = 3;
      this.fLength2 = 10;
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.Init();
      this.Color = color;
    }

    
    public CAD(TimeSeries input, int length1, int length2, Color color, EDrawStyle drawStyle)
			: base(input)  {
      this.fLength1 = 3;
      this.fLength2 = 10;
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
			this.Name = "CAD" + (object) this.fLength1 + (string) (object) this.fLength2;
			this.Title ="CAD";
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
			if (TimeSeries.nameOption == ENameOption.Long)
				this.Name = this.fInput.Name + this.Name;
      this.Disconnect();
      if (this.fAD != null)
        this.fAD.Detach();
      if (this.fEMA1 != null)
        this.fEMA1.Detach();
      if (this.fEMA2 != null)
        this.fEMA2.Detach();
      this.fAD = new AD(this.fInput);
      this.Connect();
      this.fEMA1 = new EMA((TimeSeries) this.fAD, this.fLength1);
      this.fEMA2 = new EMA((TimeSeries) this.fAD, this.fLength2);
      this.fAD.DrawEnabled = false;
      this.fEMA1.DrawEnabled = false;
      this.fEMA1.DrawEnabled = false;
    }

    
    protected override void Calculate(int index)
    {
      if (index >= Math.Max(this.fLength1, this.fLength2) + this.fInput.FirstIndex)
      {
        double Data = this.fEMA1[index] - this.fEMA2[index];
        this.Add(this.fInput.GetDateTime(index), Data);
      }
      else
        this.Add(this.fInput.GetDateTime(index), double.NaN);
    }

    
    public static double Value(TimeSeries input, int index, int length1, int length2)
    {
      if (index < Math.Max(length1, length2) + input.FirstIndex)
        return double.NaN;
      AD ad = new AD(input);
      EMA ema1 = new EMA((TimeSeries) ad, length1);
      EMA ema2 = new EMA((TimeSeries) ad, length2);
      return ema1[index] - ema2[index];
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
      this.fAD.Detach();
      base.Detach();
    }
  }
}
