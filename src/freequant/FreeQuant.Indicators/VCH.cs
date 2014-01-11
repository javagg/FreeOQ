// Type: SmartQuant.Indicators.VCH
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
  public class VCH : Indicator
  {
    protected int fLength1;
    protected int fLength2;
    protected EMA fEMA;
    protected DoubleSeries fHL_array;

    [Description("")]
    [Category("Parameters")]
    [IndicatorParameter(0)]
    public int Length1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fLength1;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fLength1 = value;
        this.Init();
      }
    }

    [Description("")]
    [IndicatorParameter(1)]
    [Category("Parameters")]
    public int Length2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fLength2;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fLength2 = value;
        this.Init();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VCH()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength1 = 14;
      this.fLength2 = 10;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VCH(TimeSeries input, int length1, int length2)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength1 = 14;
      this.fLength2 = 10;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VCH(TimeSeries input, int length1, int length2, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength1 = 14;
      this.fLength2 = 10;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.Init();
      this.Color = color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VCH(TimeSeries input, int length1, int length2, Color color, EDrawStyle drawStyle)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength1 = 14;
      this.fLength2 = 10;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Init()
    {
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(1154) + (object) this.fLength1 + GXPBSPblRhtUOANrS4.LSuAVoYjy(1168) + (string) (object) this.fLength2 + GXPBSPblRhtUOANrS4.LSuAVoYjy(1176);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(1184);
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (TimeSeries.fNameOption == ENameOption.Long)
        this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(1224) + this.fName;
      this.fHL_array = new DoubleSeries();
      for (int index = 0; index < this.fInput.Count; ++index)
        this.fHL_array.Add(this.fInput.GetDateTime(index), this.fInput[index, BarData.High] - this.fInput[index, BarData.Low]);
      this.fEMA = new EMA((TimeSeries) this.fHL_array, this.fLength1);
      this.fEMA.DrawEnabled = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      double Data = double.NaN;
      if (index >= this.fLength2 - 1 + this.fInput.FirstIndex)
      {
        int index1 = this.fEMA.GetIndex(this.fInput.GetDateTime(index));
        Data = (this.fEMA[index1] - this.fEMA[index1 - this.fLength2 + 1]) / this.fEMA[index1 - this.fLength2 + 1] * 100.0;
      }
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length1, int length2)
    {
      if (index < length2 - 1 + input.FirstIndex)
        return double.NaN;
      DoubleSeries doubleSeries = new DoubleSeries();
      for (int index1 = 0; index1 <= index; ++index1)
        doubleSeries.Add(input.GetDateTime(index1), input[index1, BarData.High] - input[index1, BarData.Low]);
      EMA ema = new EMA((TimeSeries) doubleSeries, length1, BarData.Close);
      return (ema[index] - ema[index - length2 + 1]) / ema[index - length2 + 1] * 100.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1 || !this.fMonitored)
        return;
      for (int Index = index; Index <= this.fInput.Count - 1; ++Index)
        this.Calculate(Index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInputItemAdded2(object sender, DateTimeEventArgs EventArgs)
    {
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index != -1)
        this.fHL_array.Add(this.fInput.GetDateTime(index), this.fInput[index, BarData.High] - this.fInput[index, BarData.Low]);
      base.OnInputItemAdded2(sender, EventArgs);
    }
  }
}
