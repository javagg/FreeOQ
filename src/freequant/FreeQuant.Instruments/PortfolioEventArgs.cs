using System;

namespace FreeQuant.Instruments
{
	public class PortfolioEventArgs : EventArgs
	{
		public Portfolio Portfolio { get; private set; }

		public PortfolioEventArgs(Portfolio portfolio) : base()
		{
			this.Portfolio = portfolio;
		}
	}
}
