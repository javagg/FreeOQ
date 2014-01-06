// Type: SmartQuant.Trading.PortfolioStop
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SlN8f6pWyHStvuMgWbM;
using SmartQuant;
using SmartQuant.Instruments;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.Trading
{
  public class PortfolioStop : IStop
  {
    private StrategyBase sKmRoRmeN5;
    private Portfolio ElNRan0isi;
    private StopType dUqRtBdT71;
    private StopMode Wa9RdDJEOa;
    private StopStatus sCBRwgCW8P;
    private DateTime XoERmcoQ62;
    private DateTime xTNRf1TvWo;
    private double QqtReC8Evy;
    private double cbLRgVrenR;
    private double oURRNWOggg;
    private double FuNRz16ilo;
    private double agAikbNDtv;
    private double uLLipPWdua;
    private StopFillMode rfci6isjj5;
    private bool RUQiAxBBaC;

    public StopFillMode FillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.rfci6isjj5;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.rfci6isjj5 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PortfolioStop(StrategyBase strategy, double level, StopType type, StopMode mode, bool stopStrategy)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      this.dUqRtBdT71 = StopType.Trailing;
      this.Wa9RdDJEOa = StopMode.Percent;
      this.rfci6isjj5 = StopFillMode.Stop;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.sKmRoRmeN5 = strategy;
      this.ElNRan0isi = strategy.Portfolio;
      this.QqtReC8Evy = level;
      this.dUqRtBdT71 = type;
      this.Wa9RdDJEOa = mode;
      this.RUQiAxBBaC = stopStrategy;
      this.oURRNWOggg = this.ElNRan0isi.GetValue();
      this.uLLipPWdua = this.oURRNWOggg;
      this.FuNRz16ilo = this.aIZRlrvLwJ();
      this.XoERmcoQ62 = Clock.Now;
      this.xTNRf1TvWo = DateTime.MinValue;
      this.i7uRq8Sj1g();
      this.agAikbNDtv = this.oURRNWOggg;
      this.uLLipPWdua = this.oURRNWOggg;
      this.QJSRn03JW5();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PortfolioStop(StrategyBase strategy, DateTime time, bool stopStrategy)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      this.dUqRtBdT71 = StopType.Trailing;
      this.Wa9RdDJEOa = StopMode.Percent;
      this.rfci6isjj5 = StopFillMode.Stop;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.sKmRoRmeN5 = strategy;
      this.ElNRan0isi = strategy.Portfolio;
      this.RUQiAxBBaC = stopStrategy;
      this.dUqRtBdT71 = StopType.Time;
      this.XoERmcoQ62 = Clock.Now;
      this.xTNRf1TvWo = time;
      this.FuNRz16ilo = this.ElNRan0isi.GetValue();
      if (!(this.xTNRf1TvWo > this.XoERmcoQ62))
        return;
      Clock.AddReminder(new ReminderEventHandler(this.AaPRYK2epA), this.xTNRf1TvWo, (object) null);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double aIZRlrvLwJ()
    {
      this.cbLRgVrenR = this.uLLipPWdua;
      switch (this.Wa9RdDJEOa)
      {
        case StopMode.Absolute:
          return this.uLLipPWdua - Math.Abs(this.QqtReC8Evy);
        case StopMode.Percent:
          return this.uLLipPWdua - Math.Abs(this.uLLipPWdua * this.QqtReC8Evy);
        default:
          throw new ArgumentException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(16170) + (object) this.Wa9RdDJEOa);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void i7uRq8Sj1g()
    {
      this.ElNRan0isi.ValueChanged += new PositionEventHandler(this.hk5RZyVTx9);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Disconnect()
    {
      this.ElNRan0isi.ValueChanged -= new PositionEventHandler(this.hk5RZyVTx9);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void hk5RZyVTx9([In] object obj0, [In] PositionEventArgs obj1)
    {
      this.oURRNWOggg = this.ElNRan0isi.GetValue();
      this.agAikbNDtv = this.ElNRan0isi.GetValue();
      this.uLLipPWdua = this.ElNRan0isi.GetValue();
      this.QJSRn03JW5();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void QJSRn03JW5()
    {
      if (this.oURRNWOggg == 0.0)
        return;
      lock (this)
      {
        if (this.oURRNWOggg <= this.FuNRz16ilo)
        {
          this.sKmRoRmeN5.ClosePortfolio();
          if (this.RUQiAxBBaC)
            this.sKmRoRmeN5.IsActive = false;
          this.Disconnect();
          this.aH7RuF48ZR(StopStatus.Executed);
        }
        else
        {
          if (this.dUqRtBdT71 != StopType.Trailing || this.oURRNWOggg <= this.cbLRgVrenR)
            return;
          this.FuNRz16ilo = this.aIZRlrvLwJ();
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void aH7RuF48ZR([In] StopStatus obj0)
    {
      this.sCBRwgCW8P = obj0;
      this.xTNRf1TvWo = Clock.Now;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AaPRYK2epA([In] ReminderEventArgs obj0)
    {
      if (obj0.SignalTime > Clock.Now)
        return;
      this.FuNRz16ilo = this.ElNRan0isi.GetValue();
      this.sKmRoRmeN5.ClosePortfolio();
      if (this.RUQiAxBBaC)
        this.sKmRoRmeN5.IsActive = false;
      this.aH7RuF48ZR(StopStatus.Executed);
    }
  }
}
