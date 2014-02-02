using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class VOSC : Indicator
  {
    protected int fLength1;
    protected int fLength2;

    [IndicatorParameter(0)]
    [Category("Parameters")]
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

    [IndicatorParameter(1)]
    [Description("")]
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

    
		public VOSC(): base()
    {
      this.fLength1 = 14;
      this.fLength2 = 10;
      this.Init();
    }

    
		public VOSC(TimeSeries input, int length1, int length2):base(input)
    {
      this.fLength1 = 14;
      this.fLength2 = 10;
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.Init();
    }

    
		public VOSC(TimeSeries input, int length1, int length2, Color color):base(input)
    {
      this.fLength1 = 14;
      this.fLength2 = 10;
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.Init();
      this.Color = color;
    }

    
    public VOSC(TimeSeries input, int length1, int length2, Color color, EDrawStyle drawStyle)
			:base(input){
      this.fLength1 = 14;
      this.fLength2 = 10;
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
      this.Name = this.fLength1 + (string) (object) this.fLength2 ;
			this.Title = "title";
      this.fType = EIndicatorType.Volume;
      this.Clear();
      this.fCalculate = true;
			if (this.fInput == null || TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = VOSC.Value(this.fInput, index, this.fLength1, this.fLength2);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length1, int length2)
    {
      if (index < length1 - 1 + input.FirstIndex || index < length2 - 1 + input.FirstIndex)
        return double.NaN;
      DoubleSeries doubleSeries = new DoubleSeries();
      for (int index1 = index; index1 > index - Math.Max(length1, length2); --index1)
        doubleSeries.Add(input.GetDateTime(index1), input[index1, BarData.Volume]);
      return SMA.Value((TimeSeries) doubleSeries, length1 - 1, length1, BarData.Close) - SMA.Value((TimeSeries) doubleSeries, length2 - 1, length2, BarData.Close);
    }

    
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.Monitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + Math.Max(this.fLength1, this.fLength2) - 1); ++Index)
        this.Calculate(Index);
    }
  }
}
