using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  [StrategyComponent("{2DBD0B38-8399-4d0b-9FAA-7C29FC1462BC}", ComponentType.MetaExposureManager, Description = "", Name = "Default_MetaExposureManager")]
  public class MetaExposureManager : MetaStrategyComponent
  {
    public const string GUID = "{2DBD0B38-8399-4d0b-9FAA-7C29FC1462BC}";


    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool Validate(Signal signal)
    {
      return true;
    }
  }
}
