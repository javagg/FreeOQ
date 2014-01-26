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
      get
      {
        return this.kwrpUuwg4i;
      }
      internal set
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
      get
      {
        return this.kwrpUuwg4i.Portfolio;
      }
    }

   
		public MetaStrategyBaseComponent():base()
    {
    }

   
    public virtual void OnPortfolioValueChanged(Portfolio portfolio)
    {
    }
  }
}
