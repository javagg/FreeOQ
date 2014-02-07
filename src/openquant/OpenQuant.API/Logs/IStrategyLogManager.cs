namespace OpenQuant.API.Logs
{
	/// <summary>
	/// IStrategyLogManager interface
	/// </summary>
	public interface IStrategyLogManager
	{
		///<summary>
		///
		///</summary>
		void Clear();

		///<summary>
		///
		///</summary>
		IStrategyLogList GetLogList(string strategyName, string symbol);
	}
}
