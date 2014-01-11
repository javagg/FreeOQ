// Type: SmartQuant.Indicators.AD
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
  public class AD : Indicator
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AD()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AD(TimeSeries input)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AD(TimeSeries input, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.Init();
      this.Color = color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AD(TimeSeries input, Color color, EDrawStyle drawStyle)
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
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(1084);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(1094);
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null || TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(1148) + this.fName;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      double num1 = this.fInput[index, BarData.High];
      double num2 = this.fInput[index, BarData.Low];
      double num3 = this.fInput[index, BarData.Close];
      double num4 = this.fInput[index, BarData.Open];
      double num5 = this.fInput[index, BarData.Volume];
      double Data = double.NaN;
      if (index >= this.fInput.FirstIndex + 1)
      {
        int num6 = -(Indicator.SyncIndex ? 0 : 1);
        Data = num1 == num2 ? this[index - 1 + num6] : num5 * (num3 - num2 - (num1 - num3)) / (num1 - num2) + this[index - 1];
      }
      if (index == this.fInput.FirstIndex && num1 != num2)
        Data = num5 * (num3 - num2 - (num1 - num3)) / (num1 - num2);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index)
    {
      double num1 = 0.0;
      if (index >= input.FirstIndex)
      {
        double num2 = input[index, BarData.High];
        double num3 = input[index, BarData.Low];
        double num4 = input[index, BarData.Close];
        double num5 = input[index, BarData.Open];
        double num6 = input[index, BarData.Volume];
        if (index >= input.FirstIndex + 1)
          num1 = num2 == num3 ? AD.Value(input, index - 1) : num6 * (num4 - num3 - (num2 - num4)) / (num2 - num3) + AD.Value(input, index - 1);
        if (index == input.FirstIndex && num2 != num3)
          num1 = num6 * (num4 - num3 - (num2 - num4)) / (num2 - num3);
      }
      else
        num1 = double.NaN;
      return num1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= this.fInput.Count - 1; ++Index)
        this.Calculate(Index);
    }
  }
}
