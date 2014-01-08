using FreeQuant.Instruments;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class MetaStrategyBaseComponent : MultiInstrumentComponent, IMetaStrategyComponent
  {
    private MetaStrategyBase kwrpUuwg4i;

    [Browsable(false)]
    public MetaStrategyBase MetaStrategyBase
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.kwrpUuwg4i;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] internal set
      {
        if (this.kwrpUuwg4i != null)
          this.Disconnect();
        this.kwrpUuwg4i = value;
        if (this.kwrpUuwg4i == null)
          return;
        this.Connect();
      }
    }

    [Browsable(false)]
    public Portfolio Portfolio
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.kwrpUuwg4i.Portfolio;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MetaStrategyBaseComponent()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnPortfolioValueChanged(Portfolio portfolio)
    {
    }
  }
}
