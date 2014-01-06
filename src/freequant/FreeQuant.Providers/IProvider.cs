// Type: SmartQuant.Providers.IProvider
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using System;

namespace SmartQuant.Providers
{
  public interface IProvider
  {
    byte Id { get; }

    string Name { get; }

    string Title { get; }

    string URL { get; }

    bool IsConnected { get; }

    ProviderStatus Status { get; }

    event EventHandler StatusChanged;

    event EventHandler Connected;

    event EventHandler Disconnected;

    event ProviderErrorEventHandler Error;

    void Connect();

    void Connect(int timeout);

    void Disconnect();

    void Shutdown();
  }
}
