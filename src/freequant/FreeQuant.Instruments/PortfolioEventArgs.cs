using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
  public class PortfolioEventArgs : EventArgs
  {
    private Portfolio portfolio;

    public Portfolio Portfolio
    {
       get
      {
        return this.portfolio;
      }
    }

    
		public PortfolioEventArgs(Portfolio portfolio):base()
		{
       this.portfolio = portfolio;
    }
  }
}
