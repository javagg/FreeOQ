using System;

namespace OpenQuant.Trading
{
  public class StrategyErrorEventArgs : EventArgs
  {
    private StrategyError error;

    public StrategyError Error
    {
      get
      {
        return this.error;
      }
    }

    public StrategyErrorEventArgs(StrategyError error)
    {
      this.error = error;
    }
  }
}
