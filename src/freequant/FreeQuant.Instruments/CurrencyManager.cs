using FreeQuant;
using System;

namespace FreeQuant.Instruments
{
	public class CurrencyManager : MarshalByRefObject
	{
 		public static CurrencyList Currencies { get; private set; }

		public static Currency DefaultCurrency
		{
			get
			{
				return CurrencyManager.Currencies[Framework.Configuration.DefaultCurrency];
			}
		}

		static CurrencyManager()
		{
			CurrencyManager.Currencies = new CurrencyList();
		}
	}
}
