using System;

namespace FreeQuant.QuantRouterLib
{
	public class TextEventArgs : EventArgs
	{
		public string Text { get; private set; }

		protected TextEventArgs(string text)
		{
			this.Text = text;
		}
	}
}
