// Type: SmartQuant.Services.IService
// Assembly: SmartQuant.Services, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: BBD4879A-0902-4B9F-9A9A-214E03CD2FAE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Services.dll

using System;

namespace SmartQuant.Services
{
  public interface IService
  {
    byte Id { get; }

    string Name { get; }

    string Description { get; }

    ServiceStatus Status { get; }

    event EventHandler StatusChanged;

    event ServiceErrorEventHandler Error;

    void Start();

    void Stop();
  }
}
