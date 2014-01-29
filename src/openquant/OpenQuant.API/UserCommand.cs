using System;

namespace OpenQuant.API
{
	public class UserCommand
	{
		public DateTime DateTime { get; private set; }
		public string Text { get; private set; }

		public UserCommand(DateTime datetime, string text)
		{
			this.DateTime = datetime;
			this.Text = text;
		}
	}
}
