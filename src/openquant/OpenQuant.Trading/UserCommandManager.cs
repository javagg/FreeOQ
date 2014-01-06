using System;
using System.Collections.Generic;

namespace OpenQuant.Trading
{
  public static class UserCommandManager
  {
    private static List<UserCommand> commands = new List<UserCommand>();

    public static UserCommand[] Commands
    {
      get
      {
        return UserCommandManager.commands.ToArray();
      }
    }

    public static event EventHandler<UserCommandEventArgs> NewCommand;

    public static event EventHandler Cleared;

    static UserCommandManager()
    {
    }

    internal static void Clear()
    {
      UserCommandManager.commands.Clear();
      if (UserCommandManager.Cleared == null)
        return;
      UserCommandManager.Cleared((object) typeof (UserCommandManager), EventArgs.Empty);
    }

    public static void Send(string strategy, string text)
    {
      UserCommand command = new UserCommand(strategy, new OpenQuant.API.UserCommand(SmartQuant.Clock.Now, text));
      UserCommandManager.commands.Add(command);
      if (UserCommandManager.NewCommand == null)
        return;
      UserCommandManager.NewCommand((object) typeof (UserCommandManager), new UserCommandEventArgs(command));
    }
  }
}
