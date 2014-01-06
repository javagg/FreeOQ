// Type: SmartQuant.Trading.StrategyBaseSingleComponent
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SmartQuant.Charting;
using SmartQuant.Instruments;
using SmartQuant.Series;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
{
  public abstract class StrategyBaseSingleComponent : SingleInstrumentComponent, IStrategyComponent
  {
    private StrategyBase U8ZSiZE1f;

    [Browsable(false)]
    public StrategyBase StrategyBase
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.U8ZSiZE1f;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] internal set
      {
        if (this.U8ZSiZE1f != null)
          this.Disconnect();
        this.U8ZSiZE1f = value;
        if (this.U8ZSiZE1f == null)
          return;
        this.Connect();
      }
    }

    [Browsable(false)]
    public Portfolio Portfolio
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.U8ZSiZE1f.Portfolio;
      }
    }

    [Browsable(false)]
    public BarSeriesList Bars
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.U8ZSiZE1f.Bars;
      }
    }

    [Browsable(false)]
    public BarSeries Bar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.U8ZSiZE1f.Bars[this.instrument];
      }
    }

    [Browsable(false)]
    public Position Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.U8ZSiZE1f.Portfolio.Positions[this.instrument];
      }
    }

    [Browsable(false)]
    public bool HasPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Position != null;
      }
    }

    [Browsable(false)]
    public NamedOrderTable Orders
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.U8ZSiZE1f.Orders[this.instrument];
      }
    }

    [Browsable(false)]
    public Hashtable Global
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.U8ZSiZE1f.Global;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StrategyBaseSingleComponent()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Draw(IDrawable primitive, int padNumber)
    {
      this.U8ZSiZE1f.MetaStrategyBase.zeFW20hc2d(this.instrument, primitive, padNumber);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Draw(IDrawable primitive, int padNumber, Color color)
    {
      if (primitive is TimeSeries)
        (primitive as TimeSeries).Color = color;
      this.Draw(primitive, padNumber);
    }
  }
}
