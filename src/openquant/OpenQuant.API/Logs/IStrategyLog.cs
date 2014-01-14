using System;

namespace OpenQuant.API.Logs
{
	///<summary>
	///  IStrategyLog interface
	///</summary>
	public interface IStrategyLog
	{
		///<summary>
		///
		///</summary>
		void Add(DateTime datetime, object value);

		///<summary>
		///
		///</summary>
		void Add(object value);
	}
}
