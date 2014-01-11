// Type: SmartQuant.Indicators.WAD
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
  public class WAD : Indicator
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WAD()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WAD(TimeSeries input)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WAD(TimeSeries input, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.Init();
      this.Color = color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WAD(TimeSeries input, Color color, EDrawStyle drawStyle)
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
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(1418);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(1428);
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null || TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(1500) + this.fName;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      double Data = 0.0;
      if (index >= this.fInput.FirstIndex + 1)
      {
        double val1_1 = this.fInput[index, BarData.High];
        double val1_2 = this.fInput[index, BarData.Low];
        double num1 = this.fInput[index, BarData.Close];
        double val2 = this.fInput[index - 1, BarData.Close];
        double num2 = this.fInput[index, BarData.Volume];
        if (num1 > val2)
          Data = this[index - 1] + num1 - Math.Min(val1_2, val2);
        if (num1 < val2)
          Data = this[index - 1] + num1 - Math.Max(val1_1, val2);
        if (num1 == val2)
          Data = this[index - 1];
      }
      else
        Data = 0.0;
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index)
    {
      if (index < input.FirstIndex + 1)
        return 0.0;
      double val1_1 = input[index, BarData.High];
      double val1_2 = input[index, BarData.Low];
      double num1 = input[index, BarData.Close];
      double val2 = input[index - 1, BarData.Close];
      double num2 = 0.0;
      double num3 = input[index, BarData.Volume];
      if (num1 > val2)
        num2 = WAD.Value(input, index - 1) + num1 - Math.Min(val1_2, val2);
      if (num1 < val2)
        num2 = WAD.Value(input, index - 1) + num1 - Math.Max(val1_1, val2);
      if (num1 == val2)
        num2 = WAD.Value(input, index - 1);
      return num2;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.fMonitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= this.fInput.Count - 1; ++Index)
        this.Calculate(Index);
    }
  }
}
