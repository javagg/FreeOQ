
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class StrategyMultiComponent : StrategyBaseMultiComponent
  {
    [Browsable(false)]
    public Strategy Strategy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.StrategyBase as Strategy;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StrategyMultiComponent()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
