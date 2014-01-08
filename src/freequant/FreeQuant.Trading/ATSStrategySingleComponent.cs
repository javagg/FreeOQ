using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class ATSStrategySingleComponent : StrategyBaseSingleComponent
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
