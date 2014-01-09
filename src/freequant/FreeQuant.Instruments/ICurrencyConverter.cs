using System;

namespace FreeQuant.Instruments
{
	public interface ICurrencyConverter
	{
		double Convert(double amount, Currency fromCurrency, Currency toCurrency);
		double Convert(double amount, Currency fromCurrency, Currency toCurrency, DateTime dateTime);
	}
}
