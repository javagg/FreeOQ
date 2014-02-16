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

		internal static void Clear()
		{
			UserCommandManager.commands.Clear();
            if (UserCommandManager.Cleared != null)
    			UserCommandManager.Cleared(typeof(UserCommandManager), EventArgs.Empty);
		}

		public static void Send(string strategy, string text)
		{
            UserCommand command = new UserCommand(strategy, new OpenQuant.API.UserCommand(DateTime.Now, text));
			UserCommandManager.commands.Add(command);
            if (UserCommandManager.NewCommand != null)
    			UserCommandManager.NewCommand(typeof(UserCommandManager), new UserCommandEventArgs(command));
		}
	}
}
