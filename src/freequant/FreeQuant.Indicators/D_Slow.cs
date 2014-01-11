// Type: SmartQuant.Indicators.D_Slow
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
  public class D_Slow : Indicator
  {
    protected int fLength;
    protected int fOrder1;
    protected int fOrder2;
    protected K_Fast fK;

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
    [IndicatorParameter(1)]
    [Description("")]
    public int Order1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fOrder1;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fOrder1 = value;
        this.Init();
      }
    }

    [IndicatorParameter(2)]
    [Category("Parameters")]
    [Description("")]
    public int Order2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fOrder2;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fOrder2 = value;
        this.Init();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public D_Slow()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      this.fOrder1 = 10;
      this.fOrder2 = 5;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public D_Slow(TimeSeries input, int length, int order1, int order2)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      this.fOrder1 = 10;
      this.fOrder2 = 5;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.fOrder1 = order1;
      this.fOrder2 = order2;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public D_Slow(TimeSeries input, int length, int order1, int order2, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      this.fOrder1 = 10;
      this.fOrder2 = 5;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.fOrder1 = order1;
      this.fOrder2 = order2;
      this.Init();
      this.Color = color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public D_Slow(TimeSeries input, int length, int order1, int order2, Color color, EDrawStyle drawStyle)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      this.fOrder1 = 10;
      this.fOrder2 = 5;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.fOrder1 = order1;
      this.fOrder2 = order2;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Init()
    {
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(2454) + (object) this.fLength + GXPBSPblRhtUOANrS4.LSuAVoYjy(2476) + (string) (object) this.fOrder1 + GXPBSPblRhtUOANrS4.LSuAVoYjy(2484) + (string) (object) this.fOrder2 + GXPBSPblRhtUOANrS4.LSuAVoYjy(2492);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(2498);
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (TimeSeries.fNameOption == ENameOption.Long)
        this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(2516) + this.fName;
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
      double Data = D_Slow.Value(this.fInput, index, this.fLength, this.fOrder1, this.fOrder2);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length, int order1, int order2)
    {
      if (index < length + order1 + order2 - 1 + input.FirstIndex)
        return double.NaN;
      double num = 0.0;
      for (int index1 = index; index1 > index - order2; --index1)
        num += K_Slow.Value(input, index1, length, order1);
      return num / (double) order2;
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
      this.fK.Detach();
      base.Detach();
    }
  }
}
