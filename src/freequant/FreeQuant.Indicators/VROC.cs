using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class VROC : Indicator
  {
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

   
		public VROC(): base()
    {
      this.fLength = 14;
      this.Init();
    }

   
		public VROC(TimeSeries input, int length): base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

   
		public VROC(TimeSeries input, int length, Color color): base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
      this.Color = color;
    }

   
		public VROC(TimeSeries input, int length, Color color, EDrawStyle drawStyle): base(input)
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

   
    protected override void Init()
    {
			this.Name = this.fLength.ToString() ;
			this.Title = "dfsdf";
      this.fType = EIndicatorType.Volume;
      this.Clear();
      this.fCalculate = true;
			if (this.Input == null || TimeSeries.nameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name + this.Name;
    }

   
    protected override void Calculate(int index)
    {
      double Data = VROC.Value(this.fInput, index, this.fLength);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

   
    public static double Value(TimeSeries input, int index, int length)
    {
      if (index >= length - 1 + input.FirstIndex)
        return (input[index, BarData.Volume] - input[index - length + 1, BarData.Volume]) / input[index - length + 1, BarData.Volume] * 100.0;
      else
        return double.NaN;
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
