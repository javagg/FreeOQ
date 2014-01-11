// Type: SmartQuant.Indicators.VOSC
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
  public class VOSC : Indicator
  {
    protected int fLength1;
    protected int fLength2;

    [IndicatorParameter(0)]
    [Category("Parameters")]
    [Description("")]
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

    [IndicatorParameter(1)]
    [Description("")]
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
    public VOSC()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength1 = 14;
      this.fLength2 = 10;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VOSC(TimeSeries input, int length1, int length2)
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
    public VOSC(TimeSeries input, int length1, int length2, Color color)
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
    public VOSC(TimeSeries input, int length1, int length2, Color color, EDrawStyle drawStyle)
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
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(1506) + (object) this.fLength1 + GXPBSPblRhtUOANrS4.LSuAVoYjy(1522) + (string) (object) this.fLength2 + GXPBSPblRhtUOANrS4.LSuAVoYjy(1530);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(1536);
      this.fType = EIndicatorType.Volume;
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null || TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(1574) + this.fName;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      double Data = VOSC.Value(this.fInput, index, this.fLength1, this.fLength2);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length1, int length2)
    {
      if (index < length1 - 1 + input.FirstIndex || index < length2 - 1 + input.FirstIndex)
        return double.NaN;
      DoubleSeries doubleSeries = new DoubleSeries();
      for (int index1 = index; index1 > index - Math.Max(length1, length2); --index1)
        doubleSeries.Add(input.GetDateTime(index1), input[index1, BarData.Volume]);
      return SMA.Value((TimeSeries) doubleSeries, length1 - 1, length1, BarData.Close) - SMA.Value((TimeSeries) doubleSeries, length2 - 1, length2, BarData.Close);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.fMonitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + Math.Max(this.fLength1, this.fLength2) - 1); ++Index)
        this.Calculate(Index);
    }
  }
}
