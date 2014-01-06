namespace OpenQuant.API.Logs
{
  public interface IStrategyLogManager
  {
    void Clear();

    IStrategyLogList GetLogList(string strategyName, string symbol);
  }
}
