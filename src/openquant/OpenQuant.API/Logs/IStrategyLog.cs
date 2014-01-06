using System;

namespace OpenQuant.API.Logs
{
  public interface IStrategyLog
  {
    void Add(DateTime datetime, object value);

    void Add(object value);
  }
}
