using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  [StrategyComponent("{0449D7E3-2016-47f6-9B80-C787B3E0F18F}", ComponentType.ExposureManager, Description = "", Name = "Default_ExposureManager")]
  public class ExposureManager : StrategyMultiComponent
  {
    public const string GUID = "{0449D7E3-2016-47f6-9B80-C787B3E0F18F}";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool Validate(Signal signal)
    {
      return true;
    }
  }
}
