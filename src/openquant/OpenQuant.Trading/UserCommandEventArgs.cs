using System;

namespace OpenQuant.Trading
{
  public class UserCommandEventArgs : EventArgs
  {
    public UserCommand Command { get; private set; }

    public UserCommandEventArgs(UserCommand command)
    {
      this.Command = command;
    }
  }
}
