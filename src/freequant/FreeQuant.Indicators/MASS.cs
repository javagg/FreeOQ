// Type: SmartQuant.Indicators.MASS
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
  public class MASS : Indicator
  {
    protected int fLength;
    protected int fOrder;
    protected EMA fEMA;
    protected EMA fEMA_ema;
    protected DoubleSeries fHL_array;

    [Description("")]
    [Category("Parameters")]
    [IndicatorParameter(0)]
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
    [Description("")]
    [IndicatorParameter(1)]
    public int Order
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fOrder;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fOrder = value;
        this.Init();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MASS()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      this.fOrder = 10;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MASS(TimeSeries input, int length, int order)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      this.fOrder = 10;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.fOrder = order;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MASS(TimeSeries input, int length, int order, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      this.fOrder = 10;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.fOrder = order;
      this.Init();
      this.Color = color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MASS(TimeSeries input, int length, int order, Color color, EDrawStyle drawStyle)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      this.fOrder = 10;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.fOrder = order;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Init()
    {
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(4656) + (object) this.fLength + GXPBSPblRhtUOANrS4.LSuAVoYjy(4672) + (string) (object) this.fOrder + GXPBSPblRhtUOANrS4.LSuAVoYjy(4680);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(4686);
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (TimeSeries.fNameOption == ENameOption.Long)
        this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(4710) + this.fName;
      this.fHL_array = new DoubleSeries();
      for (int index = 0; index < this.fInput.Count; ++index)
        this.fHL_array.Add(this.fInput.GetDateTime(index), this.fInput[index, BarData.High] - this.fInput[index, BarData.Low]);
      this.fEMA = new EMA((TimeSeries) this.fHL_array, this.fOrder);
      this.fEMA_ema = new EMA((TimeSeries) this.fEMA, this.fOrder);
      this.fEMA.DrawEnabled = false;
      this.fEMA_ema.DrawEnabled = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      double Data = 0.0;
      if (index >= this.fLength - 1 + this.fInput.FirstIndex)
      {
        for (int index1 = index; index1 > index - this.fLength; --index1)
          Data += this.fEMA[index1] / this.fEMA_ema[index1];
        this.Add(this.fInput.GetDateTime(index), Data);
      }
      else
        this.Add(this.fInput.GetDateTime(index), double.NaN);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length, int order)
    {
      if (index < length - 1 + input.FirstIndex)
        return double.NaN;
      DoubleSeries doubleSeries = new DoubleSeries();
      double num = 0.0;
      for (int index1 = 0; index1 <= index; ++index1)
        doubleSeries.Add(input.GetDateTime(index1), input[index1, BarData.High] - input[index1, BarData.Low]);
      EMA ema1 = new EMA((TimeSeries) doubleSeries, order, BarData.Close);
      EMA ema2 = new EMA((TimeSeries) ema1, order, BarData.Close);
      for (int index1 = index; index1 > index - length; --index1)
        num += ema1[index1] / ema2[index1];
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      this.fHL_array.Add(this.fInput.GetDateTime(index), this.fInput[index, BarData.High] - this.fInput[index, BarData.Low]);
      if (!this.fMonitored)
        return;
      for (int Index = index; Index <= this.fInput.Count - 1; ++Index)
        this.Calculate(Index);
    }
  }
}
