// Type: SmartQuant.Indicators.ADX
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
  public class ADX : Indicator
  {
    protected EIndicatorStyle fStyle;
    protected int fLength;
    protected DX fDX;

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
    public ADX()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ADX(TimeSeries input, int length, EIndicatorStyle style)
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
    public ADX(TimeSeries input, int length, EIndicatorStyle style, Color color)
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
    public ADX(TimeSeries input, int length, EIndicatorStyle style, Color color, EDrawStyle drawStyle)
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
    public ADX(TimeSeries input, int length)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ADX(TimeSeries input, int length, Color color)
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
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(3808) + (object) this.fLength + GXPBSPblRhtUOANrS4.LSuAVoYjy(3822);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(3828);
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (TimeSeries.fNameOption == ENameOption.Long)
        this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(3882) + this.fName;
      this.Disconnect();
      if (this.fDX != null)
        this.fDX.Detach();
      this.fDX = new DX(this.fInput, this.fLength, this.fStyle);
      this.fDX.DrawEnabled = false;
      this.Connect();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      if (index >= 2 * this.fLength + this.fInput.FirstIndex)
      {
        double num1 = 0.0;
        int num2 = -(Indicator.SyncIndex ? 0 : 1) * 2 * this.fLength;
        int num3 = -(Indicator.SyncIndex ? 0 : 1) * this.fLength;
        if (index == 2 * this.fLength + this.fInput.FirstIndex)
        {
          for (int index1 = index; index1 > index - this.fLength; --index1)
            num1 += this.fDX[index1 + num3];
        }
        else
          num1 = this.fStyle != EIndicatorStyle.QuantStudio ? this[index - 1 + num2] * (double) (this.fLength - 1) + this.fDX[index + num3] : this[index - 1 + num2] * (double) this.fLength - this.fDX[index - this.fLength + num3] + this.fDX[index + num3];
        double Data = num1 / (double) this.fLength;
        this.Add(this.fInput.GetDateTime(index), Data);
      }
      else
        this.Add(this.fInput.GetDateTime(index), double.NaN);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length, EIndicatorStyle style)
    {
      if (index < 2 * length + input.FirstIndex)
        return double.NaN;
      double num1 = 0.0;
      double num2;
      if (style == EIndicatorStyle.QuantStudio)
      {
        for (int index1 = index; index1 > index - length; --index1)
          num1 += DX.Value(input, index1, length);
        num2 = num1 / (double) length;
      }
      else
      {
        for (int index1 = 2 * length + input.FirstIndex; index1 > length + input.FirstIndex; --index1)
          num1 += DX.Value(input, index1, length, style);
        double num3 = num1 / (double) length;
        for (int index1 = 2 * length + 1 + input.FirstIndex; index1 <= index; ++index1)
          num3 = (num3 * (double) (length - 1) + DX.Value(input, index1, length, style)) / (double) length;
        num2 = num3;
      }
      return num2;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length)
    {
      return ADX.Value(input, index, length, EIndicatorStyle.QuantStudio);
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
        for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + 2 * this.fLength); ++Index)
          this.Calculate(Index);
      }
      else
      {
        for (int Index = index; Index <= this.fInput.Count - 1; ++Index)
          this.Calculate(Index);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Detach()
    {
      this.fDX.Detach();
      base.Detach();
    }
  }
}
