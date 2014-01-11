// Type: SmartQuant.Indicators.PointAndFigure
// Assembly: SmartQuant.Indicators, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 31E147DE-EF63-4F0C-B049-23C3662CE212
// Assembly location: E:\OpenQuant\Framework\bin\SmartQuant.Indicators.dll

using JgR8Nw4Dcm7J7u8IfB;
using ko1tl8f5ZvqOYr69tl;
using SmartQuant.Data;
using SmartQuant.Series;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.Indicators
{
  public class PointAndFigure : PnFSeries
  {
    private BarSeries a5BWZ0TPe;
    private long F5gS2UINc;
    private double SiVbpEJDu;
    private int k5AClw2Ik;
    private DateTime guZEVulqj;
    public PnFKind state;
    private double NHwmBddO3;
    private double OZFqJkkIQ;
    private double Y71QdMqsk;
    private double OhYiMwkUQ;
    private bool CQL4xfZp7;

    public double BoxSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.SiVbpEJDu;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SiVbpEJDu = value;
        this.RlvRSAa6O();
      }
    }

    public int ReversalSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.k5AClw2Ik;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.k5AClw2Ik = value;
        this.RlvRSAa6O();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PointAndFigure(BarSeries barSeries, double boxSize, int reversalSize)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.guZEVulqj = DateTime.MaxValue;
      this.Y71QdMqsk = double.MaxValue;
      this.OhYiMwkUQ = double.MinValue;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.a5BWZ0TPe = barSeries;
      this.Name = barSeries.Name;
      this.SiVbpEJDu = boxSize;
      this.k5AClw2Ik = reversalSize;
      barSeries.ItemAdded += new ItemAddedEventHandler(this.w52rn1bfi);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RlvRSAa6O()
    {
      this.Clear();
      this.F5gS2UINc = 0L;
      this.NHwmBddO3 = 0.0;
      this.OZFqJkkIQ = 0.0;
      this.Y71QdMqsk = double.MaxValue;
      this.OhYiMwkUQ = double.MinValue;
      this.CQL4xfZp7 = false;
      this.guZEVulqj = DateTime.MaxValue;
      for (int index = 0; index < this.a5BWZ0TPe.Count; ++index)
        this.Q0UfuAEmP(this.a5BWZ0TPe[index]);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Q0UfuAEmP([In] Bar obj0)
    {
      this.F5gS2UINc += obj0.Volume;
      if (!this.CQL4xfZp7)
      {
        if (this.guZEVulqj == DateTime.MaxValue)
          this.guZEVulqj = obj0.DateTime;
        if (this.Y71QdMqsk > obj0.Low)
          this.NHwmBddO3 = Math.Floor(obj0.Low / this.SiVbpEJDu) * this.SiVbpEJDu;
        if (this.OhYiMwkUQ < obj0.High)
          this.OZFqJkkIQ = Math.Ceiling(obj0.High / this.SiVbpEJDu) * this.SiVbpEJDu;
        bool flag = false;
        if (this.Y71QdMqsk > obj0.Low)
        {
          this.Y71QdMqsk = obj0.Low;
          this.Add(new PnF(this.SiVbpEJDu, this.guZEVulqj, obj0.EndTime, this.OZFqJkkIQ, this.OZFqJkkIQ, this.NHwmBddO3, this.NHwmBddO3, this.F5gS2UINc, 1L));
          flag = true;
        }
        else if (this.OhYiMwkUQ < obj0.High)
        {
          this.OhYiMwkUQ = obj0.High;
          this.Add(new PnF(this.SiVbpEJDu, this.guZEVulqj, obj0.EndTime, this.NHwmBddO3, this.OZFqJkkIQ, this.NHwmBddO3, this.OZFqJkkIQ, this.F5gS2UINc, 1L));
          flag = false;
        }
        if (this.OZFqJkkIQ - this.NHwmBddO3 < this.SiVbpEJDu)
          return;
        if (flag)
        {
          this.Add(new PnF(this.SiVbpEJDu, this.guZEVulqj, obj0.EndTime, this.OZFqJkkIQ, this.OZFqJkkIQ, this.NHwmBddO3, this.NHwmBddO3, this.F5gS2UINc, 1L));
          this.CQL4xfZp7 = true;
          this.F5gS2UINc = 0L;
          this.state = PnFKind.Down;
        }
        else
        {
          this.Add(new PnF(this.SiVbpEJDu, this.guZEVulqj, obj0.EndTime, this.NHwmBddO3, this.OZFqJkkIQ, this.NHwmBddO3, this.OZFqJkkIQ, this.F5gS2UINc, 1L));
          this.CQL4xfZp7 = true;
          this.F5gS2UINc = 0L;
          this.state = PnFKind.Up;
        }
        this.Y71QdMqsk = double.MaxValue;
        this.OhYiMwkUQ = double.MinValue;
      }
      else
      {
        if (this.OhYiMwkUQ == double.MinValue && this.Y71QdMqsk == double.MaxValue)
          this.guZEVulqj = obj0.BeginTime;
        this.Y71QdMqsk = Math.Min(this.Y71QdMqsk, obj0.Low);
        this.OhYiMwkUQ = Math.Max(this.OhYiMwkUQ, obj0.High);
        if (this.state == PnFKind.Up)
        {
          if (this.OhYiMwkUQ >= this.OZFqJkkIQ)
          {
            this.OZFqJkkIQ = Math.Ceiling(this.OhYiMwkUQ / this.SiVbpEJDu) * this.SiVbpEJDu;
            this.Add(new PnF(this.SiVbpEJDu, this.Last.BeginTime, obj0.EndTime, this.NHwmBddO3, this.OZFqJkkIQ, this.NHwmBddO3, this.OZFqJkkIQ, this.F5gS2UINc, 1L));
          }
          if (this.Y71QdMqsk >= this.OZFqJkkIQ - this.SiVbpEJDu * (double) this.k5AClw2Ik)
            return;
          this.state = PnFKind.Down;
          this.OZFqJkkIQ = this.OZFqJkkIQ - this.SiVbpEJDu;
          this.NHwmBddO3 = Math.Floor(this.Y71QdMqsk / this.SiVbpEJDu) * this.SiVbpEJDu;
          if (this.OZFqJkkIQ == this.NHwmBddO3)
            Console.WriteLine(GXPBSPblRhtUOANrS4.LSuAVoYjy(5296));
          this.Y71QdMqsk = double.MaxValue;
          this.OhYiMwkUQ = double.MinValue;
          if (this.OZFqJkkIQ == this.NHwmBddO3)
            Console.WriteLine(GXPBSPblRhtUOANrS4.LSuAVoYjy(5306));
          this.Add(new PnF(this.SiVbpEJDu, this.guZEVulqj, obj0.EndTime, this.OZFqJkkIQ, this.OZFqJkkIQ, this.NHwmBddO3, this.NHwmBddO3, this.F5gS2UINc, 1L));
          this.F5gS2UINc = 0L;
        }
        else
        {
          if (this.Y71QdMqsk <= this.NHwmBddO3)
          {
            this.NHwmBddO3 = Math.Floor(this.Y71QdMqsk / this.SiVbpEJDu) * this.SiVbpEJDu;
            this.Add(new PnF(this.SiVbpEJDu, this.Last.BeginTime, obj0.EndTime, this.OZFqJkkIQ, this.OZFqJkkIQ, this.NHwmBddO3, this.NHwmBddO3, this.F5gS2UINc, 1L));
          }
          if (this.OhYiMwkUQ <= this.NHwmBddO3 + this.SiVbpEJDu * (double) this.k5AClw2Ik)
            return;
          this.state = PnFKind.Up;
          this.NHwmBddO3 = this.NHwmBddO3 + this.SiVbpEJDu;
          this.OZFqJkkIQ = Math.Ceiling(this.OhYiMwkUQ / this.SiVbpEJDu) * this.SiVbpEJDu;
          if (this.OZFqJkkIQ == this.NHwmBddO3)
            Console.WriteLine(GXPBSPblRhtUOANrS4.LSuAVoYjy(5316));
          this.Y71QdMqsk = double.MaxValue;
          this.OhYiMwkUQ = double.MinValue;
          this.Add(new PnF(this.SiVbpEJDu, this.guZEVulqj, obj0.EndTime, this.NHwmBddO3, this.OZFqJkkIQ, this.NHwmBddO3, this.OZFqJkkIQ, this.F5gS2UINc, 1L));
          this.F5gS2UINc = 0L;
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Calculate()
    {
      foreach (Bar bar in (TimeSeries) this.a5BWZ0TPe)
        this.Q0UfuAEmP(bar);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void w52rn1bfi([In] object obj0, [In] DateTimeEventArgs obj1)
    {
      this.Q0UfuAEmP(this.a5BWZ0TPe[obj1.DateTime]);
    }
  }
}
