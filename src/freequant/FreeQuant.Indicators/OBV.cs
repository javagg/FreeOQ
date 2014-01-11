// Type: SmartQuant.Indicators.OBV
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
  public class OBV : Indicator
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public OBV()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OBV(TimeSeries input)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OBV(TimeSeries input, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.Init();
      this.Color = color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OBV(TimeSeries input, Color color, EDrawStyle drawStyle)
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
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(4158);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(4168);
      this.fType = EIndicatorType.Volume;
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null || TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(4206) + this.fName;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      double Data = double.NaN;
      if (index >= 1 + this.fInput.FirstIndex)
      {
        double num1 = this.fInput[index, BarData.Close];
        double num2 = this.fInput[index - 1, BarData.Close];
        double num3 = this.fInput[index, BarData.Volume];
        int num4 = -(Indicator.SyncIndex ? 0 : 1);
        if (index > 1 + this.fInput.FirstIndex)
        {
          if (num1 > num2)
            Data = this[index - 1 + num4] + num3;
          if (num1 < num2)
            Data = this[index - 1 + num4] - num3;
          if (num1 == num2)
            Data = this[index - 1 + num4];
        }
        else
        {
          if (num1 > num2)
            Data = num3;
          if (num1 < num2)
            Data = -num3;
          if (num1 == num2)
            Data = 0.0;
        }
      }
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index)
    {
      if (index < 1 + input.FirstIndex)
        return double.NaN;
      double num1 = input[index, BarData.Close];
      double num2 = input[index - 1, BarData.Close];
      double num3 = input[index, BarData.Volume];
      double num4 = 0.0;
      if (index > 1 + input.FirstIndex)
      {
        if (num1 > num2)
          num4 = OBV.Value(input, index - 1) + num3;
        if (num1 < num2)
          num4 = OBV.Value(input, index - 1) - num3;
        if (num1 == num2)
          num4 = OBV.Value(input, index - 1);
      }
      else
      {
        if (num1 > num2)
          num4 = num3;
        if (num1 < num2)
          num4 = -num3;
        if (num1 == num2)
          num4 = 0.0;
      }
      return num4;
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
