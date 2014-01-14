namespace OpenQuant.API.Logs
{
	///<summary>
	///  IStrategyLogManager interface
	///</summary>
	internal interface IStrategyLogManager
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
