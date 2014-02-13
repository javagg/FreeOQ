using System;

namespace FreeQuant.NxCoreLib
{
	public interface IMessageReceiver
	{
		void OnStatus(DateTime datetime);
		void OnTrade(string symbol, DateTime datetime, double price, uint size);
		void OnQuote(string symbol, DateTime datetime, double bidPrice, int bidSize, double askPrice, int askSize);
	}
}
