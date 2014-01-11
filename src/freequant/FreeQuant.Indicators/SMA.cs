// Type: SmartQuant.Indicators.SMA
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
  public class SMA : Indicator
  {
    protected int fLength;
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SMA()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SMA(TimeSeries input, int length, BarData option)
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
    public SMA(TimeSeries input, int length, BarData option, Color color)
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
    public SMA(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle)
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
    public SMA(TimeSeries input, int length)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SMA(TimeSeries input, int length, Color color)
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
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(2114) + (object) this.fLength + GXPBSPblRhtUOANrS4.LSuAVoYjy(2128);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(2134);
      this.fType = EIndicatorType.Price;
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
        this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(2180) + (object) this.fLength + GXPBSPblRhtUOANrS4.LSuAVoYjy(2194) + (string) (object) this.fOption + GXPBSPblRhtUOANrS4.LSuAVoYjy(2202);
      if (TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(2208) + this.fName;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      double Data = double.NaN;
      if (index >= this.fLength - 1 + this.fInput.FirstIndex)
      {
        Data = 0.0;
        int num = Indicator.SyncIndex ? 1 : 0;
        if (index == this.fLength - 1 + this.fInput.FirstIndex)
        {
          for (int index1 = index; index1 >= index - this.fLength + 1; --index1)
            Data += this.fInput[index1, this.fOption] / (double) this.fLength;
        }
        else
          Data = this[this.fInput.GetDateTime(index - 1)] + (this.fInput[index, this.fOption] - this.fInput[index - this.fLength, this.fOption]) / (double) this.fLength;
      }
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length, BarData option)
    {
      if (index < length - 1 + input.FirstIndex)
        return double.NaN;
      double num = 0.0;
      for (int index1 = index; index1 >= index - length + 1; --index1)
        num += input[index1, option];
      return num / (double) length;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(DoubleSeries input, int index, int length)
    {
      return SMA.Value((TimeSeries) input, index, length, BarData.Close);
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
