// Type: SmartQuant.Indicators.K_Slow
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
  public class K_Slow : Indicator
  {
    protected int fLength;
    protected int fOrder;
    protected K_Fast fK;

    [IndicatorParameter(0)]
    [Category("Parameters")]
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

    [IndicatorParameter(1)]
    [Category("Parameters")]
    [Description("")]
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
    public K_Slow()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      this.fOrder = 10;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public K_Slow(TimeSeries input, int length, int order)
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
    public K_Slow(TimeSeries input, int length, int order, Color color)
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
    public K_Slow(TimeSeries input, int length, int order, Color color, EDrawStyle drawStyle)
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
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(5776) + (object) this.fLength + GXPBSPblRhtUOANrS4.LSuAVoYjy(5798) + (string) (object) this.fOrder + GXPBSPblRhtUOANrS4.LSuAVoYjy(5806);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(5812);
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (TimeSeries.fNameOption == ENameOption.Long)
        this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(5830) + this.fName;
      this.Disconnect();
      if (this.fK != null)
        this.fK.Detach();
      this.fK = new K_Fast(this.fInput, this.fLength);
      this.fK.DrawEnabled = false;
      this.Connect();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      double Data = K_Slow.Value(this.fInput, index, this.fLength, this.fOrder);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length, int order)
    {
      if (index < length + order - 1 + input.FirstIndex)
        return double.NaN;
      double num1 = 0.0;
      for (int index2 = index; index2 > index - order; --index2)
      {
        double min = input.GetMin(index2 - length + 1, index2, BarData.Low);
        double max = input.GetMax(index2 - length + 1, index2, BarData.High);
        double num2 = input[index2, BarData.Close];
        double num3 = max - min;
        double num4 = num2 - min;
        num1 += 100.0 * num4 / num3;
      }
      return num1 / (double) order;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.fMonitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + this.fLength + this.fOrder - 1); ++Index)
        this.Calculate(Index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Detach()
    {
      this.fK.Detach();
      base.Detach();
    }
  }
}
