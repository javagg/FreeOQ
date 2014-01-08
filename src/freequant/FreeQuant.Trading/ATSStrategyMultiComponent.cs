using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
{
  public class ATSStrategyMultiComponent : StrategyBaseMultiComponent
  {
    [Browsable(false)]
    public ATSStrategy Strategy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.StrategyBase as ATSStrategy;
      }
    }

  }
}
