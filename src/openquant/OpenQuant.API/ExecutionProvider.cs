//using SmartQuant.Providers;
using FreeQuant.Providers;

namespace OpenQuant.API
{
  public class ExecutionProvider : Provider
  {
    internal ExecutionProvider(IExecutionProvider provider)
      : base((IProvider) provider)
    {
      this.provider = (IProvider) provider;
    }
  }
}
