// Type: SmartQuant.QuantRouterLib.IConnection
// Assembly: SmartQuant.QuantRouterLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: FDF277D6-C8FB-45C3-A0BD-1C1035F3B027
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantRouterLib.dll

using SmartQuant.QuantRouterLib.Messages;
using System;

namespace SmartQuant.QuantRouterLib
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
