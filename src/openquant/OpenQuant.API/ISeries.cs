using System;

namespace OpenQuant.API
{
	public interface ISeries
	{
		string Name { get; }

		int Count { get; }

		double this [DateTime dateTime, BarData barData] { get; }

		double this [int index, BarData barData] { get; }

		bool Contains(DateTime dateTime);

		DateTime GetDateTime(int index);

		int GetIndex(DateTime dateTime);

		double Ago(int n);
	}
}
