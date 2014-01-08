using FreeQuant.QuantRouterLib.Messages;
using System;

namespace FreeQuant.QuantRouterLib
{
  public interface IConnection
  {
    string ConnectionString { get; set; }

    bool RaiseEvents { get; set; }

    event EventHandler Closed;

    event EventHandler<ExceptionEventArgs> Error;

    event EventHandler<MessageEventArgs> MessageReceived;

    void Open();

    void Close();

    void Send(Message message);

    void Send(Message[] message);
  }
}
