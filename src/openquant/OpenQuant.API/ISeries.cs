using System;

namespace OpenQuant.API
{

	public interface ISeries
	{
		///<summary>
		///  Gets the name of this series
		///</summary>
		string Name { get; }

		///<summary>
		///  Gets the number of values in this series
		///</summary>
		int Count { get; }

		///<summary>
		///  Gets value with specified time stamp and bar data in the series 
		///</summary>
		double this[DateTime dateTime, BarData barData] { get; }

		///<summary>
		///  Gets value with specified index and bar data in the series
		///</summary>
		double this[int index, BarData barData] { get; }

		///<summary>
		///  Checks if this series contains a value with specified time stamp
		///</summary>
		bool Contains(DateTime dateTime);

		///<summary>
		///  Returns date time by specified index
		///</summary>
		DateTime GetDateTime(int index);

		///<summary>
		///  Returns index by specified date time
		///</summary>
		int GetIndex(DateTime dateTime);

		///<summary>
		///  Returns n-item-ago value
		///</summary>
		double Ago(int n);
	}
}
