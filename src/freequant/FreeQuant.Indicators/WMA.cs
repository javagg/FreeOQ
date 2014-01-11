// Type: SmartQuant.Indicators.WMA
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
  public class WMA : Indicator
  {
    protected int fLength;
    protected BarData fOption;

    [Category("Parameters")]
    [IndicatorParameter(0)]
    [Description("Length of Weighted Moving Average")]
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

    [IndicatorParameter(1)]
    [Category("Parameters")]
    [Description("Which type of data to average")]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WMA()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WMA(TimeSeries input, int length, BarData option)
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
    public WMA(TimeSeries input, int length, BarData option, Color color)
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
    public WMA(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle)
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
    public WMA(TimeSeries input, int length)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Init()
    {
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(588) + (object) this.fLength + GXPBSPblRhtUOANrS4.LSuAVoYjy(602);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(608);
      this.fType = EIndicatorType.Price;
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
        this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(658) + (object) this.Length + GXPBSPblRhtUOANrS4.LSuAVoYjy(672) + (string) (object) this.fOption + GXPBSPblRhtUOANrS4.LSuAVoYjy(680);
      if (TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(686) + this.fName;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      if (index < this.Length - 1 + this.Input.FirstIndex)
      {
        this.Add(this.fInput.GetDateTime(index), double.NaN);
      }
      else
      {
        double num1 = 0.0;
        for (int index1 = 1; index1 != this.Length + 1; ++index1)
          num1 += (double) index1;
        double num2 = 0.0;
        int index2 = index;
        int length = this.Length;
        while (index - (this.Length - 1) <= index2)
        {
          num2 += this.Input[index2, this.fOption] * (double) length;
          --index2;
          --length;
        }
        double Data = num2 / num1;
        this.Add(this.fInput.GetDateTime(index), Data);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length, BarData option)
    {
      double num1 = 0.0;
      double num2;
      if (index < length - 1 + input.FirstIndex)
      {
        num2 = double.NaN;
      }
      else
      {
        double num3 = 0.0;
        for (int index1 = 1; index1 != length + 1; ++index1)
          num3 += (double) index1;
        int index2 = index;
        int num4 = length;
        while (index - (length - 1) <= index2)
        {
          num1 += input[index2, option] * (double) num4;
          --index2;
          --num4;
        }
        num2 = num1 / num3;
      }
      return num2;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(DoubleSeries input, int index, int length)
    {
      return WMA.Value((TimeSeries) input, index, length, BarData.Close);
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
