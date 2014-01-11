// Type: SmartQuant.Indicators.LRI
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
  public class LRI : Indicator
  {
    protected int fLength;
    protected BarData fOption;
    private RegressionDistanceMode aKF3Bglmd;

    [Category("Parameters")]
    [IndicatorParameter(1)]
    [Description("")]
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

    [Category("Parameters")]
    [Description("")]
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
    [IndicatorParameter(2)]
    [Category("Parameters")]
    public RegressionDistanceMode DistanceMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aKF3Bglmd;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.aKF3Bglmd = value;
        this.Init();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LRI()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LRI(TimeSeries input, int length, BarData option)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.fOption = option;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LRI(TimeSeries input, int length, BarData option, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LRI(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.fOption = option;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LRI(TimeSeries input, int length)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LRI(TimeSeries input, int length, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.Color = color;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Init()
    {
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(3510) + (object) this.fLength + GXPBSPblRhtUOANrS4.LSuAVoYjy(3524);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(3530);
      this.fType = EIndicatorType.Price;
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
        this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(3588) + (object) this.fLength + GXPBSPblRhtUOANrS4.LSuAVoYjy(3602) + (string) (object) this.fOption + GXPBSPblRhtUOANrS4.LSuAVoYjy(3610);
      if (TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(3616) + this.fName;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      double Data = LRI.Value(this.fInput, index, this.fLength, this.fOption, this.aKF3Bglmd);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length, BarData option, RegressionDistanceMode distanceMode)
    {
      if (index < length - 1)
        return double.NaN;
      double x = 0.0;
      double num1 = 0.0;
      double num2 = 0.0;
      double num3 = 0.0;
      double num4;
      if (distanceMode == RegressionDistanceMode.Time)
      {
        double num5 = (double) input.GetDateTime(index).Subtract(input.GetDateTime(index - 1)).Ticks;
        for (int index1 = index; index1 > index - length; --index1)
        {
          x += (double) input.GetDateTime(index1).Subtract(input.GetDateTime(index - length + 1)).Ticks / num5;
          num1 += (double) input.GetDateTime(index1).Subtract(input.GetDateTime(index - length + 1)).Ticks / num5 * input[index1, option];
          num2 += input[index1, option];
          num3 += (double) input.GetDateTime(index1).Subtract(input.GetDateTime(index - length + 1)).Ticks / num5 * (double) input.GetDateTime(index1).Subtract(input.GetDateTime(index - length + 1)).Ticks / num5;
        }
        num4 = (double) input.GetDateTime(index).Subtract(input.GetDateTime(index - length + 1)).Ticks / num5;
      }
      else
      {
        for (int index1 = index; index1 > index - length; --index1)
        {
          x += (double) (index1 - index + length - 1);
          num1 += (double) (index1 - index + length - 1) * input[index1, option];
          num2 += input[index1, option];
          num3 += (double) ((index1 - index + length - 1) * (index1 - index + length - 1));
        }
        num4 = (double) (length - 1);
      }
      double num6 = ((double) length * num1 - x * num2) / ((double) length * num3 - Math.Pow(x, 2.0));
      double num7 = (num2 - num6 * x) / (double) length;
      return num6 * num4 + num7;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(DoubleSeries input, int index, int length, RegressionDistanceMode distanceMode)
    {
      return LRI.Value((TimeSeries) input, index, length, BarData.Close, distanceMode);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(DoubleSeries input, int index, int length)
    {
      return LRI.Value((TimeSeries) input, index, length, BarData.Close, RegressionDistanceMode.Time);
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
