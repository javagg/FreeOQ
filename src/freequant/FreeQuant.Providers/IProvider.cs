using System;

namespace FreeQuant.Providers
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
