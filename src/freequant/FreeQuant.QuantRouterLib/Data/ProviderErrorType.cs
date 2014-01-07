// Type: SmartQuant.QuantRouterLib.Data.ProviderErrorType
// Assembly: SmartQuant.QuantRouterLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: FDF277D6-C8FB-45C3-A0BD-1C1035F3B027
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantRouterLib.dll

using System;

namespace SmartQuant.QuantRouterLib.Data
{
  [Flags]
  public enum ProviderErrorType : byte
  {
    Error = (byte) 0,
    Warning = (byte) 1,
    Information = (byte) 2,
  }
}
