// Type: SmartQuant.Trading.MetaStrategyBaseComponent
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SmartQuant.Instruments;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
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
