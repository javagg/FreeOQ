// Type: SmartQuant.QuantRouterLib.Data.TickType
// Assembly: SmartQuant.QuantRouterLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: FDF277D6-C8FB-45C3-A0BD-1C1035F3B027
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantRouterLib.dll

using System;

namespace SmartQuant.QuantRouterLib.Data
{
  [Flags]
  public enum TickType : byte
  {
    Unknown = (byte) 0,
    Bid = (byte) 1,
    Ask = (byte) 2,
    Trade = (byte) 4,
    Level2 = (byte) 8,
  }
}
