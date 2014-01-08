
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  [StrategyComponent("{A4D510F9-13DB-4b4c-9557-BC6A48A25D0B}", ComponentType.OptimizationManager, Description = "", Name = "Default_OptimizationManager")]
  public class OptimizationManager : MetaStrategyBaseComponent
  {
    public const string GUID = "{A4D510F9-13DB-4b4c-9557-BC6A48A25D0B}";


    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Objective()
    {
      return 0.0;
    }
  }
}
