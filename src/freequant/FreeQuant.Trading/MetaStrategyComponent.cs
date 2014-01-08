using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class MetaStrategyComponent : MetaStrategyBaseComponent
  {
    [Browsable(false)]
    public MetaStrategy MetaStrategy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.MetaStrategyBase as MetaStrategy;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MetaStrategyComponent()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
