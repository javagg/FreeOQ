// Type: SmartQuant.Indicators.HV
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
  public class HV : Indicator
  {
    protected int fLength;
    protected double fSpan;
    protected BarData fOption;

    [Category("Parameters")]
    [Description("")]
    [IndicatorParameter(2)]
    public BarData Option
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fOption;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fLength;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fLength = value;
        this.Init();
      }
    }

    [Description("")]
    [Category("Parameters")]
    [IndicatorParameter(1)]
    public double Span
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fSpan;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fSpan = value;
        this.Init();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HV()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      this.fSpan = 20.0;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HV(TimeSeries input, int length, double span, BarData option)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      this.fSpan = 20.0;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.fSpan = span;
      this.fOption = option;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HV(TimeSeries input, int length, double span, BarData option, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      this.fSpan = 20.0;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.fSpan = span;
      this.fOption = option;
      this.Init();
      this.Color = color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HV(TimeSeries input, int length, double span, BarData option, Color color, EDrawStyle drawStyle)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      this.fSpan = 20.0;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.fSpan = span;
      this.fOption = option;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HV(TimeSeries input, int length, double span)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      this.fSpan = 20.0;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.fSpan = span;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HV(TimeSeries input, int length, double span, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      this.fSpan = 20.0;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.fSpan = span;
      this.Color = color;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Init()
    {
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(2594) + (object) this.fLength + GXPBSPblRhtUOANrS4.LSuAVoYjy(2606) + (string) (object) this.fSpan + GXPBSPblRhtUOANrS4.LSuAVoYjy(2614);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(2620);
      this.fType = EIndicatorType.Price;
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
        this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(2666) + (object) this.fLength + GXPBSPblRhtUOANrS4.LSuAVoYjy(2678) + (string) (object) this.fSpan + GXPBSPblRhtUOANrS4.LSuAVoYjy(2686) + (string) (object) this.fOption + GXPBSPblRhtUOANrS4.LSuAVoYjy(2694);
      if (TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(2700) + this.fName;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      double Data = HV.Value(this.fInput, index, this.fLength, this.fSpan, this.fOption);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length, double span, BarData option)
    {
      if (index < length + input.FirstIndex)
        return double.NaN;
      double[] numArray = new double[length];
      double num1 = 0.0;
      for (int index1 = index; index1 > index - length; --index1)
      {
        double num2 = Math.Log(input[index1, option] / input[index1 - 1, option]);
        num1 += num2;
        numArray[index1 - index + length - 1] = num2;
      }
      double num3 = num1 / (double) length;
      double num4 = 0.0;
      for (int index1 = 0; index1 < numArray.Length; ++index1)
        num4 += Math.Pow(numArray[index1] - num3, 2.0);
      return Math.Sqrt(num4 / (double) (length - 1)) * 100.0 * Math.Sqrt(span);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(DoubleSeries input, int index, int length, double span)
    {
      return HV.Value((TimeSeries) input, index, length, span, BarData.Close);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.fMonitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + this.fLength - 1); ++Index)
        this.Calculate(Index);
    }
  }
}
