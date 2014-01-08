
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class StrategySingleComponent : StrategyBaseSingleComponent
  {
    [Browsable(false)]
    public Strategy Strategy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.StrategyBase as Strategy;
      }
    }

  }
}
