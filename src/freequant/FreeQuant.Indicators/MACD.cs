// Type: SmartQuant.Indicators.MACD
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
  public class MACD : Indicator
  {
    protected int fLength1;
    protected int fLength2;
    protected BarData fOption;
    protected EMA fEMA1;
    protected EMA fEMA2;

    [Category("Parameters")]
    [Description("")]
    [IndicatorParameter(2)]
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
    [Category("Parameters")]
    [IndicatorParameter(1)]
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
    public MACD()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength1 = 14;
      this.fLength2 = 10;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MACD(TimeSeries input, int length1, int length2, BarData option)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength1 = 14;
      this.fLength2 = 10;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.fOption = option;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MACD(TimeSeries input, int length1, int length2, BarData option, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength1 = 14;
      this.fLength2 = 10;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.fOption = option;
      this.Init();
      this.Color = color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MACD(TimeSeries input, int length1, int length2, BarData option, Color color, EDrawStyle drawStyle)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength1 = 14;
      this.fLength2 = 10;
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
    public MACD(TimeSeries input, int length1, int length2)
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
    public MACD(TimeSeries input, int length1, int length2, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength1 = 14;
      this.fLength2 = 10;
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
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(4358) + (object) this.fLength1 + GXPBSPblRhtUOANrS4.LSuAVoYjy(4374) + (string) (object) this.fLength2 + GXPBSPblRhtUOANrS4.LSuAVoYjy(4382);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(4388);
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
        this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(4466) + (object) this.fLength1 + GXPBSPblRhtUOANrS4.LSuAVoYjy(4482) + (string) (object) this.fLength2 + GXPBSPblRhtUOANrS4.LSuAVoYjy(4490) + (string) (object) this.fOption + GXPBSPblRhtUOANrS4.LSuAVoYjy(4498);
      if (TimeSeries.fNameOption == ENameOption.Long)
        this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(4504) + this.fName;
      this.Disconnect();
      if (this.fEMA1 != null)
        this.fEMA1.Detach();
      if (this.fEMA2 != null)
        this.fEMA2.Detach();
      this.fEMA1 = new EMA(this.fInput, this.fLength1, this.fOption);
      this.fEMA2 = new EMA(this.fInput, this.fLength2, this.fOption);
      this.Connect();
      this.fEMA1.DrawEnabled = false;
      this.fEMA2.DrawEnabled = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      if (index >= this.fInput.FirstIndex)
      {
        double Data = this.fEMA1[index] - this.fEMA2[index];
        this.Add(this.fInput.GetDateTime(index), Data);
      }
      else
        this.Add(this.fInput.GetDateTime(index), double.NaN);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length1, int length2, BarData option)
    {
      if (index >= input.FirstIndex)
        return EMA.Value(input, index, length1, option) - EMA.Value(input, index, length2, option);
      else
        return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(DoubleSeries input, int index, int length1, int length2)
    {
      return MACD.Value((TimeSeries) input, index, length1, length2, BarData.Close);
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Detach()
    {
      this.fEMA1.Detach();
      this.fEMA2.Detach();
      base.Detach();
    }
  }
}
