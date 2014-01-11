// Type: SmartQuant.Indicators.Range
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
  public class Range : Indicator
  {
    protected int length;

    [Category("Parameters")]
    [Description("")]
    [IndicatorParameter(0)]
    public int Length
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.length;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.length = value;
        this.Init();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Range()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.length = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Range(TimeSeries input, int length)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.length = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.length = length;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Range(TimeSeries input, int length, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.length = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.length = length;
      this.Init();
      this.fColor = color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Range(TimeSeries input, int length, Color color, EDrawStyle drawStyle)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.length = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.length = length;
      this.Init();
      this.fColor = color;
      this.fDrawStyle = drawStyle;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Init()
    {
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(4544) + (object) this.length + GXPBSPblRhtUOANrS4.LSuAVoYjy(4562);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(4568);
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null || TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(4582) + this.fName;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      double Data = Range.Value(this.fInput, index, this.length);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length)
    {
      if (index < length - 1 + input.FirstIndex)
        return double.NaN;
      double min = input.GetMin(index - length + 1, index, BarData.Low);
      return Math.Log(input.GetMax(index - length + 1, index, BarData.High) / min);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.fMonitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + this.length - 1); ++Index)
        this.Calculate(Index);
    }
  }
}
