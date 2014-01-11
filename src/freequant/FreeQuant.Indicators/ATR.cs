// Type: SmartQuant.Indicators.ATR
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
  public class ATR : Indicator
  {
    protected EIndicatorStyle fStyle;
    protected int fLength;

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

    [Category("Parameters")]
    [IndicatorParameter(1)]
    [Description("")]
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
    public ATR()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ATR(TimeSeries input, int length, EIndicatorStyle style)
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
    public ATR(TimeSeries input, int length, EIndicatorStyle style, Color color)
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
    public ATR(TimeSeries input, int length, EIndicatorStyle style, Color color, EDrawStyle drawStyle)
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
    public ATR(TimeSeries input, int length)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ATR(TimeSeries input, int length, Color color)
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
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(5326) + (object) this.fLength + GXPBSPblRhtUOANrS4.LSuAVoYjy(5340);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(5346);
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null || TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(5386) + this.fName;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      if (index >= this.fLength + this.fInput.FirstIndex)
      {
        int num1 = -(Indicator.SyncIndex ? 0 : 1) * this.fLength;
        double Data;
        if (this.fStyle == EIndicatorStyle.QuantStudio)
        {
          if (index == this.fLength + this.fInput.FirstIndex)
          {
            double num2 = 0.0;
            for (int index1 = index; index1 > index - this.fLength; --index1)
              num2 += TR.Value(this.fInput, index1);
            Data = num2 / (double) this.fLength;
          }
          else
          {
            double num2 = TR.Value(this.fInput, index);
            Data = (this[index - 1 + num1] * (double) this.fLength + num2 - TR.Value(this.fInput, index - this.fLength)) / (double) this.fLength;
          }
        }
        else if (index == this.fLength + this.fInput.FirstIndex)
        {
          double num2 = 0.0;
          for (int index1 = index; index1 > index - this.fLength; --index1)
            num2 += TR.Value(this.fInput, index1);
          Data = num2 / (double) this.fLength;
        }
        else
        {
          double num2 = TR.Value(this.fInput, index);
          Data = (this[this.fInput.GetDateTime(index - 1)] * (double) this.fLength + num2 - TR.Value(this.fInput, index - this.fLength)) / (double) this.fLength;
        }
        this.Add(this.fInput.GetDateTime(index), Data);
      }
      else
        this.Add(this.fInput.GetDateTime(index), double.NaN);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length, EIndicatorStyle style)
    {
      if (index < length + input.FirstIndex)
        return double.NaN;
      double num1 = 0.0;
      double num2;
      if (style == EIndicatorStyle.QuantStudio)
      {
        for (int index1 = index; index1 > index - length; --index1)
          num1 += TR.Value(input, index1);
        num2 = num1 / (double) length;
      }
      else
      {
        for (int index1 = length + input.FirstIndex; index1 > input.FirstIndex; --index1)
          num1 += TR.Value(input, index1);
        double num3 = num1 / (double) length;
        for (int index1 = length + 1 + input.FirstIndex; index1 <= index; ++index1)
          num3 = (num3 * (double) (length - 1) + TR.Value(input, index1)) / (double) length;
        num2 = num3;
      }
      return num2;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length)
    {
      return ATR.Value(input, index, length, EIndicatorStyle.QuantStudio);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int length)
    {
      return ATR.Value(input, input.LastIndex, length);
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
        for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + this.fLength); ++Index)
          this.Calculate(Index);
      }
      else
      {
        for (int Index = index; Index <= this.fInput.Count - 1; ++Index)
          this.Calculate(Index);
      }
    }
  }
}
