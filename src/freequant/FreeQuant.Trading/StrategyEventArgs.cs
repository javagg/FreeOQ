
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class StrategyEventArgs : EventArgs
  {
    private StrategyBase sOgRcFoa0f;

    public StrategyBase Strategy
    {
       get
      {
        return this.sOgRcFoa0f;
      }
    }

    
		public StrategyEventArgs(StrategyBase strategy):base()
    {
      this.sOgRcFoa0f = strategy;
    }
  }
}
