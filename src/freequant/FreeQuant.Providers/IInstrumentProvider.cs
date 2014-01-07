using FreeQuant.FIX;

namespace FreeQuant.Providers
{
  public interface IInstrumentProvider : IProvider
  {
    event SecurityDefinitionEventHandler SecurityDefinition;

    void SendSecurityDefinitionRequest(FIXSecurityDefinitionRequest request);
  }
}
