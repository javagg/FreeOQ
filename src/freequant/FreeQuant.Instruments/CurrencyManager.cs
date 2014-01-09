using FreeQuant;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
	public class CurrencyManager : MarshalByRefObject
	{
		private static CurrencyList currencies;

		public static CurrencyList Currencies
		{
			get
			{
				return CurrencyManager.currencies;
			}
		}

		public static Currency DefaultCurrency
		{
			get
			{
				return CurrencyManager.currencies[Framework.Configuration.DefaultCurrency];
			}
		}

		static CurrencyManager()
		{
			CurrencyManager.currencies = new CurrencyList();
			Currency.vTnE26EIAD();
		}
	}
}
