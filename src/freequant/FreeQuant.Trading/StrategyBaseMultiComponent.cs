// Type: SmartQuant.Trading.StrategyBaseMultiComponent
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SmartQuant.Charting;
using SmartQuant.Instruments;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
{
  public class StrategyBaseMultiComponent : MultiInstrumentComponent, IStrategyComponent
  {
    private StrategyBase J2mpqllssW;

    [Browsable(false)]
    public StrategyBase StrategyBase
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.J2mpqllssW;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] internal set
      {
        if (this.J2mpqllssW != null)
          this.Disconnect();
        this.J2mpqllssW = value;
        if (this.J2mpqllssW == null)
          return;
        this.Connect();
      }
    }

    [Browsable(false)]
    public Portfolio Portfolio
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.J2mpqllssW.Portfolio;
      }
    }

    [Browsable(false)]
    public BarSeriesList Bars
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.StrategyBase.Bars;
      }
    }

    [Browsable(false)]
    public Hashtable Global
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.J2mpqllssW.Global;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StrategyBaseMultiComponent()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnPortfolioValueChanged(Position position)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnBarSlice(long size)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Draw(Instrument instrument, IDrawable primitive, int padNumber)
    {
      this.J2mpqllssW.MetaStrategyBase.zeFW20hc2d(instrument, primitive, padNumber);
    }
  }
}
