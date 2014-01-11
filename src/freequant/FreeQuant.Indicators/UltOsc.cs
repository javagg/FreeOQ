// Type: SmartQuant.Indicators.UltOsc
// Assembly: SmartQuant.Indicators, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 31E147DE-EF63-4F0C-B049-23C3662CE212
// Assembly location: E:\OpenQuant\Framework\bin\SmartQuant.Indicators.dll

using JgR8Nw4Dcm7J7u8IfB;
using ko1tl8f5ZvqOYr69tl;
using SmartQuant.Data;
using SmartQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace SmartQuant.Indicators
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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fN1;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fN2;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fN3;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fN3 = value;
        this.Init();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UltOsc()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fN1 = 14;
      this.fN2 = 10;
      this.fN3 = 5;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UltOsc(TimeSeries input, int n1, int n2, int n3)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fN1 = 14;
      this.fN2 = 10;
      this.fN3 = 5;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fN1 = n1;
      this.fN2 = n2;
      this.fN3 = n3;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UltOsc(TimeSeries input, int n1, int n2, int n3, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fN1 = 14;
      this.fN2 = 10;
      this.fN3 = 5;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fN1 = n1;
      this.fN2 = n2;
      this.fN3 = n3;
      this.Init();
      this.Color = color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UltOsc(TimeSeries input, int n1, int n2, int n3, Color color, EDrawStyle drawStyle)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fN1 = 14;
      this.fN2 = 10;
      this.fN3 = 5;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fN1 = n1;
      this.fN2 = n2;
      this.fN3 = n3;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Init()
    {
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(5210) + (object) this.fN1 + GXPBSPblRhtUOANrS4.LSuAVoYjy(5226) + (string) (object) this.fN2 + GXPBSPblRhtUOANrS4.LSuAVoYjy(5234) + (string) (object) this.fN3 + GXPBSPblRhtUOANrS4.LSuAVoYjy(5242);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(5248);
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null || TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(5290) + this.fName;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      double Data = UltOsc.Value(this.fInput, index, this.fN1, this.fN2, this.fN3);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.fMonitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + Math.Max(this.fN1, Math.Max(this.fN2, this.fN3))); ++Index)
        this.Calculate(Index);
    }
  }
}
