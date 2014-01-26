using FreeQuant.FIX;
using System;

namespace FreeQuant.Providers
{
	public class NewsEventArgs : EventArgs
	{
		public FIXNews News { get; private set; }

		public NewsEventArgs(FIXNews news) : base()
		{
			this.News = news;
		}
	}
}
