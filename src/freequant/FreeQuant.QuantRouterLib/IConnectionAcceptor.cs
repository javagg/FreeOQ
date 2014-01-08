using System;

namespace FreeQuant.QuantRouterLib
{
  public interface IConnectionAcceptor
  {
    ConnectionAcceptorState State { get; }

    event EventHandler<ConnectionEventArgs> ConnectionAccepted;

    event EventHandler StateChanged;

    void Start(string connectionString);

    void Stop();
  }
}
