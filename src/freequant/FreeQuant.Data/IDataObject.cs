// Type: SmartQuant.Data.IDataObject
// Assembly: SmartQuant.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=844f265c18b031f9
// MVID: FAB3F3C9-6D4A-4391-AE43-0CE5E1C624DD
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Data.dll

using System;

namespace FreeQuant.Data
{
  public interface IDataObject
  {
    DateTime DateTime { get; set; }

    byte ProviderId { get; set; }
  }
}
