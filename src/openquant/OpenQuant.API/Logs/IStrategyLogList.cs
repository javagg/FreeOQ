using System;

namespace OpenQuant.API.Logs
{
	///<summary>
	///  IStrategyLogList interface
	///</summary>
	public interface IStrategyLogList
	{
		///<summary>
		///
		///</summary>
		IStrategyLog this [string logName] { get; }

		///<summary>
		///
		///</summary>
		[Obsolete("Use this[string logName]", false)]
		IStrategyLog this [string logName, string logCategory] { get; }
	}
}
