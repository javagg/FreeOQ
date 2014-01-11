// Type: SmartQuant.Indicators.CAD
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
  public class CAD : Indicator
  {
    protected EMA fEMA1;
    protected EMA fEMA2;
    protected AD fAD;
    protected int fLength1;
    protected int fLength2;

    [Description("")]
    [IndicatorParameter(0)]
    [Category("Parameters")]
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
    public CAD()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength1 = 3;
      this.fLength2 = 10;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CAD(TimeSeries input, int length1, int length2)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength1 = 3;
      this.fLength2 = 10;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CAD(TimeSeries input, int length1, int length2, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength1 = 3;
      this.fLength2 = 10;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength1 = length1;
      this.fLength2 = length2;
      this.Init();
      this.Color = color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CAD(TimeSeries input, int length1, int length2, Color color, EDrawStyle drawStyle)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength1 = 3;
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
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(2706) + (object) this.fLength1 + GXPBSPblRhtUOANrS4.LSuAVoYjy(2720) + (string) (object) this.fLength2 + GXPBSPblRhtUOANrS4.LSuAVoYjy(2728);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(2736);
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (TimeSeries.fNameOption == ENameOption.Long)
        this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(2784) + this.fName;
      this.Disconnect();
      if (this.fAD != null)
        this.fAD.Detach();
      if (this.fEMA1 != null)
        this.fEMA1.Detach();
      if (this.fEMA2 != null)
        this.fEMA2.Detach();
      this.fAD = new AD(this.fInput);
      this.Connect();
      this.fEMA1 = new EMA((TimeSeries) this.fAD, this.fLength1);
      this.fEMA2 = new EMA((TimeSeries) this.fAD, this.fLength2);
      this.fAD.DrawEnabled = false;
      this.fEMA1.DrawEnabled = false;
      this.fEMA1.DrawEnabled = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      if (index >= Math.Max(this.fLength1, this.fLength2) + this.fInput.FirstIndex)
      {
        double Data = this.fEMA1[index] - this.fEMA2[index];
        this.Add(this.fInput.GetDateTime(index), Data);
      }
      else
        this.Add(this.fInput.GetDateTime(index), double.NaN);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length1, int length2)
    {
      if (index < Math.Max(length1, length2) + input.FirstIndex)
        return double.NaN;
      AD ad = new AD(input);
      EMA ema1 = new EMA((TimeSeries) ad, length1);
      EMA ema2 = new EMA((TimeSeries) ad, length2);
      return ema1[index] - ema2[index];
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
      this.fAD.Detach();
      base.Detach();
    }
  }
}
