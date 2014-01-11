// Type: SmartQuant.Indicators.TRIX
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
  public class TRIX : Indicator
  {
    protected EMA fEMA;
    protected EMA fEMA_2;
    protected EMA fEMA_3;
    protected int fLength;
    protected BarData fOption;

    [Category("Parameters")]
    [IndicatorParameter(1)]
    [Description("")]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TRIX()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TRIX(TimeSeries input, int length, BarData option)
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
    public TRIX(TimeSeries input, int length, BarData option, Color color)
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
    public TRIX(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle)
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
    public TRIX(TimeSeries input, int length)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TRIX(TimeSeries input, int length, Color color)
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
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(1230) + (object) this.fLength + GXPBSPblRhtUOANrS4.LSuAVoYjy(1246);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(1254);
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (this.fInput is BarSeries)
        this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(1278) + (object) this.fLength + GXPBSPblRhtUOANrS4.LSuAVoYjy(1294) + (string) (object) this.fOption + GXPBSPblRhtUOANrS4.LSuAVoYjy(1302);
      if (TimeSeries.fNameOption == ENameOption.Long)
        this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(1308) + this.fName;
      this.Disconnect();
      if (this.fEMA != null)
        this.fEMA.Detach();
      if (this.fEMA_2 != null)
        this.fEMA_2.Detach();
      if (this.fEMA_3 != null)
        this.fEMA_3.Detach();
      this.fEMA = new EMA(this.fInput, this.fLength, this.fOption);
      this.Connect();
      this.fEMA_2 = new EMA((TimeSeries) this.fEMA, this.fLength, this.fOption);
      this.fEMA_3 = new EMA((TimeSeries) this.fEMA_2, this.fLength, this.fOption);
      this.fEMA.DrawEnabled = false;
      this.fEMA_2.DrawEnabled = false;
      this.fEMA_3.DrawEnabled = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      double Data = double.NaN;
      if (index >= 1 + this.fInput.FirstIndex)
        Data = (this.fEMA_3[index] - this.fEMA_3[index - 1]) / this.fEMA_3[index - 1] * 100.0;
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length, BarData option)
    {
      if (index < 1 + input.FirstIndex)
        return double.NaN;
      DoubleSeries doubleSeries = new DoubleSeries();
      for (int firstIndex = input.FirstIndex; firstIndex <= index; ++firstIndex)
        doubleSeries.Add(input.GetDateTime(firstIndex), input[firstIndex, option]);
      EMA ema = new EMA((TimeSeries) new EMA((TimeSeries) new EMA((TimeSeries) doubleSeries, length, option), length, option), length, option);
      return (ema[index - input.FirstIndex] - ema[index - 1 - input.FirstIndex]) / ema[index - 1 - input.FirstIndex] * 100.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(DoubleSeries input, int index, int length)
    {
      return TRIX.Value((TimeSeries) input, index, length, BarData.Close);
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
      this.fEMA.Detach();
      base.Detach();
    }
  }
}
