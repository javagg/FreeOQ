using System;

namespace OpenQuant.API.Logs
{
  public interface IStrategyLogList
  {
    IStrategyLog this[string logName] { get; }

    [Obsolete("Use this[string logName]", false)]
    IStrategyLog this[string logName, string logCategory] { get; }
  }
}
