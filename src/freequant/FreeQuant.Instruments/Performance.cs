// Type: SmartQuant.Instruments.Performance
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using SmartQuant;
using SmartQuant.Series;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using VFUvY5knK01pUIalDo;

namespace SmartQuant.Instruments
{
  public class Performance
  {
    private Portfolio NPSBOUwFDk;
    private bool QKEBKpYxOj;
    private DoubleSeries kwuB9pCYms;
    private DoubleSeries GxxBC3VDvh;
    private DoubleSeries QlUBMCgZct;
    private DoubleSeries V03BmvEDCW;
    private DoubleSeries s2mBUXprxR;
    private double YMfB7h2Hrs;
    private double jrkBj5BwCg;
    private double XN7Bk4NMYL;
    private double KcnBDlRCyB;
    private double O1gB0VTS3X;
    private double B4LBHyMafx;
    private double xvBBcSNnMs;
    private double RqgBVpPUJn;
    private double fnBBFqgONw;
    private double InjBy1lkoo;
    private double MrYBqYV87G;

    [Browsable(false)]
    public Portfolio Portfolio
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.NPSBOUwFDk;
      }
    }

    public bool Enabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QKEBKpYxOj;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.QKEBKpYxOj = value;
      }
    }

    public bool CalculatePnL { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public bool CalculateDrawdown { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public TimeSpan UpdateInterval { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public bool UpdateOnIntervalEnabled { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Browsable(false)]
    public DoubleSeries EquitySeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.kwuB9pCYms;
      }
    }

    [Browsable(false)]
    public DoubleSeries CoreEquitySeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GxxBC3VDvh;
      }
    }

    [Browsable(false)]
    public DoubleSeries PnLSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QlUBMCgZct;
      }
    }

    [Browsable(false)]
    public DoubleSeries DrawdownSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.V03BmvEDCW;
      }
    }

    [Browsable(false)]
    public DoubleSeries DrawdownPercentSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.s2mBUXprxR;
      }
    }

    [Browsable(false)]
    public double Equity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.YMfB7h2Hrs;
      }
    }

    [Browsable(false)]
    public double CoreEquity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jrkBj5BwCg;
      }
    }

    [Browsable(false)]
    public double PnL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.O1gB0VTS3X;
      }
    }

    [Browsable(false)]
    public double HighEquity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.KcnBDlRCyB;
      }
    }

    [Browsable(false)]
    public double LowEquity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.XN7Bk4NMYL;
      }
    }

    [Browsable(false)]
    public double Drawdown
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.B4LBHyMafx;
      }
    }

    [Browsable(false)]
    public double DrawdownPercent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.xvBBcSNnMs;
      }
    }

    [Browsable(false)]
    public double CurrentDrawdown
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.RqgBVpPUJn;
      }
    }

    [Browsable(false)]
    public double CurrentRunUp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fnBBFqgONw;
      }
    }

    public event EventHandler EquityChanged;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Performance(Portfolio portfolio)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.QKEBKpYxOj = true;
      this.kwuB9pCYms = new DoubleSeries(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2378));
      this.GxxBC3VDvh = new DoubleSeries(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2394));
      this.QlUBMCgZct = new DoubleSeries(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2420));
      this.V03BmvEDCW = new DoubleSeries(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2430));
      this.s2mBUXprxR = new DoubleSeries(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2450));
      this.InjBy1lkoo = double.NaN;
      this.MrYBqYV87G = double.NaN;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.NPSBOUwFDk = portfolio;
      this.CalculatePnL = true;
      this.CalculateDrawdown = true;
      this.NPSBOUwFDk.ValueChanged += new PositionEventHandler(this.RLrBXT2waX);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void GcxBG7nv0L()
    {
      this.kwuB9pCYms.Clear();
      this.GxxBC3VDvh.Clear();
      this.QlUBMCgZct.Clear();
      this.V03BmvEDCW.Clear();
      this.s2mBUXprxR.Clear();
      this.YMfB7h2Hrs = 0.0;
      this.jrkBj5BwCg = 0.0;
      this.XN7Bk4NMYL = 0.0;
      this.KcnBDlRCyB = 0.0;
      this.O1gB0VTS3X = 0.0;
      this.B4LBHyMafx = 0.0;
      this.xvBBcSNnMs = 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RLrBXT2waX([In] object obj0, [In] PositionEventArgs obj1)
    {
      if (!this.QKEBKpYxOj)
        return;
      DateTime dateTime = Clock.Now;
      if (this.UpdateOnIntervalEnabled)
        dateTime = new DateTime(dateTime.Ticks / this.UpdateInterval.Ticks * this.UpdateInterval.Ticks);
      this.FZABJ7ZbGj(dateTime);
      this.SijB3EsC7m(dateTime);
      this.PSxBNlvv0d(dateTime);
      if (this.VIABfp2hVw == null)
        return;
      this.VIABfp2hVw((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void faxB4aWy0q([In] object obj0, [In] EventArgs obj1)
    {
      this.GcxBG7nv0L();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FZABJ7ZbGj([In] DateTime obj0)
    {
      if (!double.IsNaN(this.MrYBqYV87G))
      {
        this.FnhBrkOUJ3(obj0.AddTicks(-1L), this.InjBy1lkoo, this.MrYBqYV87G);
        this.InjBy1lkoo = double.NaN;
        this.MrYBqYV87G = double.NaN;
      }
      this.jrkBj5BwCg = this.NPSBOUwFDk.GetCoreEquity();
      this.YMfB7h2Hrs = this.NPSBOUwFDk.GetTotalEquity();
      this.FnhBrkOUJ3(obj0, this.YMfB7h2Hrs, this.jrkBj5BwCg);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FnhBrkOUJ3([In] DateTime obj0, [In] double obj1, [In] double obj2)
    {
      this.GxxBC3VDvh[obj0] = obj2;
      this.kwuB9pCYms[obj0] = obj1;
      if (this.kwuB9pCYms.Count == 1)
      {
        this.XN7Bk4NMYL = obj1;
        this.KcnBDlRCyB = obj1;
      }
      else
      {
        if (this.YMfB7h2Hrs > this.KcnBDlRCyB)
        {
          this.KcnBDlRCyB = obj1;
          this.XN7Bk4NMYL = obj1;
          this.RqgBVpPUJn = 0.0;
        }
        if (this.YMfB7h2Hrs < this.XN7Bk4NMYL)
        {
          this.XN7Bk4NMYL = obj1;
          this.fnBBFqgONw = 0.0;
        }
        if (obj1 <= this.XN7Bk4NMYL || obj1 >= this.KcnBDlRCyB)
          return;
        this.RqgBVpPUJn = 1.0 - obj1 / this.KcnBDlRCyB;
        this.fnBBFqgONw = obj1 / this.XN7Bk4NMYL - 1.0;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SijB3EsC7m([In] DateTime obj0)
    {
      if (!this.CalculatePnL || this.kwuB9pCYms.Count < 2)
        return;
      int lastIndex = this.kwuB9pCYms.LastIndex;
      int index = lastIndex - 1;
      this.O1gB0VTS3X = this.kwuB9pCYms[lastIndex] - this.kwuB9pCYms[index];
      this.QlUBMCgZct[obj0] = this.O1gB0VTS3X;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PSxBNlvv0d([In] DateTime obj0)
    {
      if (!this.CalculateDrawdown || this.kwuB9pCYms.Count < 2)
        return;
      this.B4LBHyMafx = this.YMfB7h2Hrs - this.KcnBDlRCyB;
      this.V03BmvEDCW[obj0] = this.B4LBHyMafx;
      if (this.KcnBDlRCyB == 0.0)
        return;
      this.xvBBcSNnMs = Math.Abs(this.B4LBHyMafx / this.KcnBDlRCyB);
      this.s2mBUXprxR[obj0] = this.xvBBcSNnMs;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init()
    {
      this.MrYBqYV87G = this.Portfolio.GetCoreEquity();
      this.InjBy1lkoo = this.Portfolio.GetTotalEquity();
    }
  }
}
