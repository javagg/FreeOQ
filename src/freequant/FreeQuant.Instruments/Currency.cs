using System;

namespace FreeQuant.Instruments
{
	public class Currency
	{
		public static Currency ARS;
		public static Currency ATS;
		public static Currency AUD;
		public static Currency BEF;
		public static Currency BRL;
		public static Currency CAD;
		public static Currency CHF;
		public static Currency DEM;
		public static Currency ESP;
		public static Currency EUR;
		public static Currency FRF;
		public static Currency GBP;
		public static Currency HKD;
		public static Currency INR;
		public static Currency ITL;
		public static Currency JPY;
		public static Currency KRW;
		public static Currency NLG;
		public static Currency PTE;
		public static Currency RUR;
		public static Currency SGD;
		public static Currency USD;
		public static Currency XBA;
		public static Currency XEU;
		public static Currency PLN;
		public static Currency NOK;
		public static Currency DKK;
		public static Currency SEK;
		public static Currency CNY;

		public string Code { get; private set; }
		public string Description { get; set; }
		public static ICurrencyConverter Converter { get; set; }

		static Currency()
		{
			Currency.Converter = new CurrencyConverter();
			Currency.ARS = new Currency("ARS", "Argentine peso");
			Currency.ATS = new Currency("ATS", "Austrian Schilling");
			Currency.AUD = new Currency("AUD", "Australian dollar");
			Currency.BEF = new Currency("BEF", "Belgian Francs");
			Currency.BRL = new Currency("BRL", "Brazilian real");
			Currency.CAD = new Currency("CAD", "Canadian dollar");
			Currency.CHF = new Currency("CHF", "Swiss franc");
			Currency.DEM = new Currency("DEM", "German Mark");
			Currency.ESP = new Currency("ESP", "Spanish Peseta");
			Currency.EUR = new Currency("EUR", "EU euro");
			Currency.FRF = new Currency("FRF", "French Franc");
			Currency.GBP = new Currency("GBP", "British pound");
			Currency.HKD = new Currency("HKD", "Hong Kong SAR dollar");
			Currency.INR = new Currency("INR", "Indian rupee");
			Currency.ITL = new Currency("ITL", "Italian Lira");
			Currency.JPY = new Currency("JPY", "Japanese yen");
			Currency.KRW = new Currency("KRW", "South Korean won");
			Currency.NLG = new Currency("NLG", "Dutch Guilder");
			Currency.PTE = new Currency("PTE", "Portuguese Escudo");
			Currency.RUR = new Currency("RUR", "Russian Ruble");
			Currency.SGD = new Currency("SGD", "Singapore dollar");
			Currency.USD = new Currency("USD", "US dollar");
			Currency.XBA = new Currency("XBA", "European Composite Unit");
			Currency.XEU = new Currency("XEU", "European Currency Unit");
			Currency.PLN = new Currency("PLN", "Polish zloty");
			Currency.NOK = new Currency("NOK", "Norwegian krone");
			Currency.DKK = new Currency("DKK", "Danish krone");
			Currency.SEK = new Currency("SEK", "Swedish krona");
			Currency.CNY = new Currency("CNY", "Chinese yuan renminbi");
		}

		public Currency(string code) : this(code, String.Empty)
		{
		}

		public Currency(string code, string description)
		{
			this.Code = code;
			this.Description = description;
			CurrencyManager.Currencies.Add(this);
		}

		public static double Convert(double amount, Currency fromCurrency, Currency toCurrency)
		{
			return Currency.Converter.Convert(amount, fromCurrency, toCurrency);
		}

		public static double Convert(double amount, Currency fromCurrency, Currency toCurrency, DateTime dateTime)
		{
			return Currency.Converter.Convert(amount, fromCurrency, toCurrency, dateTime);
		}

		public double Convert(double amount, Currency toCurrency)
		{
			return Currency.Converter.Convert(amount, this, toCurrency);
		}

		public double Convert(double amount, Currency toCurrency, DateTime dateTime)
		{
			return Currency.Converter.Convert(amount, this, toCurrency, dateTime);
		}

		public override string ToString()
		{
			return this.Code;
		}
	}
}
