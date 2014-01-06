using System;

namespace OpenQuant.Trading
{
  public class StrategyError
  {
    private DateTime datetime;
    private Exception exception;

    public DateTime DateTime
    {
      get
      {
        return this.datetime;
      }
    }

    public Exception Exception
    {
      get
      {
        return this.exception;
      }
    }

    public StrategyError(DateTime datetime, Exception exception)
    {
      this.datetime = datetime;
      this.exception = exception;
    }
  }
}
