// Type: SmartQuant.Indicators.OSC
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
  public class OSC : Indicator
  {
    protected int fLength1;
    protected int fLength2;
    protected BarData fOption;

    [IndicatorParameter(2)]
    [Description("")]
    [Category("Parameters")]
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

    [Category("Parameters")]
    [IndicatorParameter(0)]
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
    public OSC()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength1 = 14;
      this.fLength2 = 20;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OSC(TimeSeries input, int length1, int length2, BarData option)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength1 = 14;
      this.fLength2 = 20;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.fOption = option;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OSC(TimeSeries input, int length1, int length2, BarData option, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength1 = 14;
      this.fLength2 = 20;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.fOption = option;
      this.Init();
      this.Color = color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OSC(TimeSeries input, int length1, int length2, BarData option, Color color, EDrawStyle drawStyle)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength1 = 14;
      this.fLength2 = 20;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.fOption = option;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OSC(TimeSeries input, int length1, int length2)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength1 = 14;
      this.fLength2 = 20;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OSC(TimeSeries input, int length1, int length2, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength1 = 14;
      this.fLength2 = 20;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.Color = color;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Init()
    {
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(4988) + (object) this.fLength1 + GXPBSPblRhtUOANrS4.LSuAVoYjy(5002) + (string) (object) this.fLength2 + GXPBSPblRhtUOANrS4.LSuAVoYjy(5010);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(5016);
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
        this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(5040) + (object) this.fLength1 + GXPBSPblRhtUOANrS4.LSuAVoYjy(5054) + (string) (object) this.fLength2 + GXPBSPblRhtUOANrS4.LSuAVoYjy(5062) + (string) (object) this.fOption + GXPBSPblRhtUOANrS4.LSuAVoYjy(5070);
      if (TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(5076) + this.fName;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      double Data = OSC.Value(this.fInput, index, this.fLength1, this.fLength2, this.fOption);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length1, int length2, BarData option)
    {
      if (index >= length1 - 1 + input.FirstIndex && index >= length2 - 1 + input.FirstIndex)
        return SMA.Value(input, index, length1, option) - SMA.Value(input, index, length2, option);
      else
        return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(DoubleSeries input, int index, int length1, int length2)
    {
      return OSC.Value((TimeSeries) input, index, length1, length2, BarData.Close);
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
