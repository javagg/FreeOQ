using FreeQuant.FIX;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
	public class NewsEventArgs : EventArgs
	{
		private FIXNews news;

		public FIXNews News
		{
			get
			{
				return this.news; 
			}
		}

		public NewsEventArgs(FIXNews news) : base()
		{
			this.news = news;
		}
	}
}
