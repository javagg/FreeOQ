// Type: SmartQuant.Indicators.TL
// Assembly: SmartQuant.Indicators, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 31E147DE-EF63-4F0C-B049-23C3662CE212
// Assembly location: E:\OpenQuant\Framework\bin\SmartQuant.Indicators.dll

using JgR8Nw4Dcm7J7u8IfB;
using ko1tl8f5ZvqOYr69tl;
using SmartQuant.Data;
using SmartQuant.Series;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace SmartQuant.Indicators
{
  [Serializable]
  public class TL : Indicator
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TL()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TL(TimeSeries input)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TL(TimeSeries input, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.Init();
      this.Color = color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TL(TimeSeries input, Color color, EDrawStyle drawStyle)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Init()
    {
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(4510);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(4518);
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null || TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(4538) + this.fName;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      double Data = TL.Value(this.fInput, index);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index)
    {
      if (index >= 1 + input.FirstIndex)
        return Math.Min(input[index, BarData.Low], input[index - 1, BarData.Close]);
      else
        return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.fMonitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + 1); ++Index)
        this.Calculate(Index);
    }
  }
}
