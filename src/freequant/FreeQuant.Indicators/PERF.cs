// Type: SmartQuant.Indicators.PERF
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
  public class PERF : Indicator
  {
    protected double fK;
    protected BarData fOption;

    [Description("")]
    [Category("Parameters")]
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

    [Description("")]
    [IndicatorParameter(0)]
    [Category("Parameters")]
    public double K
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fK;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fK = value;
        this.Init();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PERF()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fK = 14.0;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PERF(TimeSeries input, double k, BarData option)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fK = 14.0;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fOption = option;
      this.fK = k;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PERF(TimeSeries input, double k, BarData option, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fK = 14.0;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fOption = option;
      this.fK = k;
      this.Init();
      this.Color = color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PERF(TimeSeries input, double k, BarData option, Color color, EDrawStyle drawStyle)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fK = 14.0;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fOption = option;
      this.fK = k;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PERF(TimeSeries input, double k)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fK = 14.0;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fK = k;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PERF(TimeSeries input, double k, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fK = 14.0;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fK = k;
      this.Color = color;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Init()
    {
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(2214) + (object) this.fK + GXPBSPblRhtUOANrS4.LSuAVoYjy(2230);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(2236);
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
        this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(2282) + (object) this.fK + GXPBSPblRhtUOANrS4.LSuAVoYjy(2298) + (string) (object) this.fOption + GXPBSPblRhtUOANrS4.LSuAVoYjy(2306);
      if (TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(2312) + this.fName;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      double Data = PERF.Value(this.fInput, index, this.fK, this.fOption);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, double k, BarData option)
    {
      if (index >= input.FirstIndex)
        return 100.0 * (input[index, option] - k) / k;
      else
        return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(DoubleSeries input, int index, double k)
    {
      return PERF.Value((TimeSeries) input, index, k, BarData.Close);
    }
  }
}
