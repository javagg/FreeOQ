using System;

namespace FreeQuant.QuantRouterLib.Data
{
  [Flags]
  public enum ProviderErrorType : byte
  {
    Error = (byte) 0,
    Warning = (byte) 1,
    Information = (byte) 2,
  }
}
