// Type: SmartQuant.Indicators.ADXR
// Assembly: SmartQuant.Indicators, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 31E147DE-EF63-4F0C-B049-23C3662CE212
// Assembly location: E:\OpenQuant\Framework\bin\SmartQuant.Indicators.dll

using JgR8Nw4Dcm7J7u8IfB;
using ko1tl8f5ZvqOYr69tl;
using SmartQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace SmartQuant.Indicators
{
  [Serializable]
  public class ADXR : Indicator
  {
    protected EIndicatorStyle fStyle;
    protected int fLength;
    protected ADX fADX;

    [Description("")]
    [IndicatorParameter(0)]
    [Category("Parameters")]
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
    public EIndicatorStyle Style
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fStyle;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fStyle = value;
        this.Init();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ADXR()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ADXR(TimeSeries input, int length, EIndicatorStyle style)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.fStyle = style;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ADXR(TimeSeries input, int length, EIndicatorStyle style, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.fStyle = style;
      this.Init();
      this.Color = color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ADXR(TimeSeries input, int length, EIndicatorStyle style, Color color, EDrawStyle drawStyle)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.fStyle = style;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ADXR(TimeSeries input, int length)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ADXR(TimeSeries input, int length, Color color)
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
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(2890) + (object) this.fLength + GXPBSPblRhtUOANrS4.LSuAVoYjy(2906);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(2912);
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (TimeSeries.fNameOption == ENameOption.Long)
        this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(2980) + this.fName;
      this.Disconnect();
      if (this.fADX != null)
        this.fADX.Detach();
      this.fADX = new ADX(this.fInput, this.fLength, this.fStyle);
      this.fADX.DrawEnabled = false;
      this.Connect();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      if (index >= 3 * this.fLength - 1 + this.fInput.FirstIndex)
      {
        int num = -(Indicator.SyncIndex ? 0 : 1) * 2 * this.fLength;
        double Data = (this.fADX[index + num] + this.fADX[index - this.fLength + 1 + num]) / 2.0;
        this.Add(this.fInput.GetDateTime(index), Data);
      }
      else
        this.Add(this.fInput.GetDateTime(index), double.NaN);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length, EIndicatorStyle style)
    {
      if (index >= 3 * length - 1 + input.FirstIndex)
        return (ADX.Value(input, index, length, style) + ADX.Value(input, index - length + 1, length, style)) / 2.0;
      else
        return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length)
    {
      return ADXR.Value(input, index, length, EIndicatorStyle.QuantStudio);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.fMonitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      if (this.fStyle == EIndicatorStyle.QuantStudio)
      {
        for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + 3 * this.fLength - 1); ++Index)
          this.Calculate(Index);
      }
      else
      {
        for (int Index = index; Index <= this.fInput.Count - 1; ++Index)
          this.Calculate(Index);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Detach()
    {
      this.fADX.Detach();
      base.Detach();
    }
  }
}
