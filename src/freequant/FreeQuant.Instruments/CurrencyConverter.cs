using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
	public class CurrencyConverter : ICurrencyConverter
	{
		public virtual double Convert(double amount, Currency fromCurrency, Currency toCurrency)
		{
			return amount;
		}

		public virtual double Convert(double amount, Currency fromCurrency, Currency toCurrency, DateTime dateTime)
		{
			return amount;
		}
	}
}
