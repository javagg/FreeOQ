// Type: SmartQuant.Indicators.LRS
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
  public class LRS : Indicator
  {
    protected int fLength;
    protected BarData fOption;
    private RegressionDistanceMode Kr2Tm3VVG;

    [Category("Parameters")]
    [Description("")]
    [IndicatorParameter(1)]
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
    [IndicatorParameter(0)]
    [Description("")]
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
    [IndicatorParameter(2)]
    public RegressionDistanceMode DistanceMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Kr2Tm3VVG;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Kr2Tm3VVG = value;
        this.Init();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LRS()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LRS(TimeSeries input, int length, BarData option)
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
    public LRS(TimeSeries input, int length, BarData option, Color color)
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
    public LRS(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle)
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
    public LRS(TimeSeries input, int length)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LRS(TimeSeries input, int length, Color color)
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
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(5672) + (object) this.fLength + GXPBSPblRhtUOANrS4.LSuAVoYjy(5686);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(5692);
      this.fType = EIndicatorType.Oscillator;
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
        this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(5742) + (object) this.fLength + GXPBSPblRhtUOANrS4.LSuAVoYjy(5756) + (string) (object) this.fOption + GXPBSPblRhtUOANrS4.LSuAVoYjy(5764);
      if (TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(5770) + this.fName;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      double Data = LRS.Value(this.fInput, index, this.fLength, this.fOption, this.Kr2Tm3VVG);
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
      if (distanceMode == RegressionDistanceMode.Time)
      {
        double num4 = (double) input.GetDateTime(index).Subtract(input.GetDateTime(index - 1)).Ticks;
        for (int index1 = index; index1 > index - length; --index1)
        {
          x += (double) input.GetDateTime(index1).Subtract(input.GetDateTime(index - length + 1)).Ticks / num4;
          num1 += (double) input.GetDateTime(index1).Subtract(input.GetDateTime(index - length + 1)).Ticks / num4 * input[index1, option];
          num2 += input[index1, option];
          num3 += (double) input.GetDateTime(index1).Subtract(input.GetDateTime(index - length + 1)).Ticks / num4 * (double) input.GetDateTime(index1).Subtract(input.GetDateTime(index - length + 1)).Ticks / num4;
        }
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
      }
      return ((double) length * num1 - x * num2) / ((double) length * num3 - Math.Pow(x, 2.0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(DoubleSeries input, int index, int length, RegressionDistanceMode distanceMode)
    {
      return LRS.Value((TimeSeries) input, index, length, BarData.Close, distanceMode);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(DoubleSeries input, int index, int length)
    {
      return LRS.Value((TimeSeries) input, index, length, BarData.Close, RegressionDistanceMode.Time);
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
