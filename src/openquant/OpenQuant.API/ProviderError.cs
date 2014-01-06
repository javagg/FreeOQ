using System;

namespace OpenQuant.API
{
  public class ProviderError
  {
    private SmartQuant.Providers.ProviderError error;

    public DateTime DateTime
    {
      get
      {
        return this.error.DateTime;
      }
    }

    public string Provider
    {
      get
      {
        return this.error.Provider.Name;
      }
    }

    public string Message
    {
      get
      {
        return this.error.Message;
      }
    }

    public int Code
    {
      get
      {
        return this.error.Code;
      }
    }

    public int Id
    {
      get
      {
        return this.error.Id;
      }
    }

    internal ProviderError(SmartQuant.Providers.ProviderError error)
    {
      this.error = error;
    }
  }
}
