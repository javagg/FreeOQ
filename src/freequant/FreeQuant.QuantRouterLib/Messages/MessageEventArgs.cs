using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Messages
{
  public class MessageEventArgs : EventArgs
  {
    public Message Message { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public MessageEventArgs(Message message)
    {
      this.Message = message;
    }
  }
}
