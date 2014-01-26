using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class UltOsc : Indicator
  {
    protected int fN1;
    protected int fN2;
    protected int fN3;

    [Category("Parameters")]
    [Description("")]
    [IndicatorParameter(0)]
    public int N1
    {
       get
      {
        return this.fN1;
      }
       set
      {
        this.fN1 = value;
        this.Init();
      }
    }

    [Category("Parameters")]
    [Description("")]
    [IndicatorParameter(1)]
    public int N2
    {
       get
      {
        return this.fN2;
      }
       set
      {
        this.fN2 = value;
        this.Init();
      }
    }

    [Category("Parameters")]
    [Description("")]
    [IndicatorParameter(2)]
    public int N3
    {
       get
      {
        return this.fN3;
      }
       set
      {
        this.fN3 = value;
        this.Init();
      }
    }

    
		public UltOsc(): base()
    {
      this.fN1 = 14;
      this.fN2 = 10;
      this.fN3 = 5;
      this.Init();
    }

    
		public UltOsc(TimeSeries input, int n1, int n2, int n3):  base(input)
    {
      this.fN1 = 14;
      this.fN2 = 10;
      this.fN3 = 5;
      this.fN1 = n1;
      this.fN2 = n2;
      this.fN3 = n3;
      this.Init();
    }

    
		public UltOsc(TimeSeries input, int n1, int n2, int n3, Color color):  base(input)
    {
      this.fN1 = 14;
      this.fN2 = 10;
      this.fN3 = 5;
      this.fN1 = n1;
      this.fN2 = n2;
      this.fN3 = n3;
      this.Init();
      this.Color = color;
    }

    
    public UltOsc(TimeSeries input, int n1, int n2, int n3, Color color, EDrawStyle drawStyle)
			:  base(input){
      this.fN1 = 14;
      this.fN2 = 10;
      this.fN3 = 5;
      this.fN1 = n1;
      this.fN2 = n2;
      this.fN3 = n3;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
			this.Name =  this.fN1.ToString()  + this.fN2.ToString()  +  this.fN3.ToString();
			this.Title = "UltOsc";
      this.Clear();
      this.fCalculate = true;
			if (this.fInput == null || TimeSeries.nameOption != ENameOption.Long)
        return;
      this.Name = this.fInput.Name + this.Name;
    }

    
    protected override void Calculate(int index)
    {
      double Data = UltOsc.Value(this.fInput, index, this.fN1, this.fN2, this.fN3);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int n1, int n2, int n3)
    {
      if (index < Math.Max(n1, Math.Max(n2, n3)) + input.FirstIndex)
        return double.NaN;
      double num1 = 0.0;
      double num2 = 0.0;
      for (int index1 = index; index1 > index - n1; --index1)
      {
        double num3 = input[index1, BarData.Close];
        double val2 = input[index1 - 1, BarData.Close];
        double val1 = input[index1, BarData.Low];
        num1 += num3 - Math.Min(val1, val2);
        num2 += TR.Value(input, index1);
      }
      double num4 = (double) (n3 / n1) * (num1 / num2);
      double num5 = 0.0;
      double num6 = 0.0;
      for (int index1 = index; index1 > index - n2; --index1)
      {
        double num3 = input[index1, BarData.Close];
        double val2 = input[index1 - 1, BarData.Close];
        double val1 = input[index1, BarData.Low];
        num5 += num3 - Math.Min(val1, val2);
        num6 += TR.Value(input, index1);
      }
      double num7 = (double) (n3 / n2) * (num5 / num6);
      double num8 = 0.0;
      double num9 = 0.0;
      for (int index1 = index; index1 > index - n3; --index1)
      {
        double num3 = input[index1, BarData.Close];
        double val2 = input[index1 - 1, BarData.Close];
        double val1 = input[index1, BarData.Low];
        num8 += num3 - Math.Min(val1, val2);
        num9 += TR.Value(input, index1);
      }
      double num10 = num8 / num9;
      return (num4 + num7 + num10) / (double) (n3 / n1 + n3 / n2 + 1) * 100.0;
    }

    
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.Monitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + Math.Max(this.fN1, Math.Max(this.fN2, this.fN3))); ++Index)
        this.Calculate(Index);
    }
  }
}
