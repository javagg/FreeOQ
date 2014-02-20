using System;
using System.Collections;

namespace FreeQuant.Instruments
{
	public class CurrencyList : IEnumerable
	{
		private SortedList currencies;

		public int Count
		{
			get
			{
				return this.currencies.Count;
			}
		}

		public Currency this[int index]
		{
			get
			{
				return this.currencies.GetByIndex(index) as Currency;
			}
		}

		public Currency this[string code]
		{
			get
			{
				return this.currencies[code] as Currency;
			}
		}

		public CurrencyList()
		{
			this.currencies = new SortedList();
		}

		public void Add(Currency currency)
		{
			if (this.currencies.Contains(currency.Code))
                throw new ApplicationException("Already Added. {0}" + currency.Code);
			this.currencies.Add(currency.Code, currency);
		}

		public void Remove(Currency currency)
		{
			this.currencies.Remove(currency.Code);
		}

		public void RemoveAt(int index)
		{
			this.Remove(this[index]);
		}

		public void Clear()
		{
			this.currencies.Clear();
		}

		public bool Contains(string code)
		{
			return this.currencies.Contains(code);
		}

		public bool Contains(Currency currency)
		{
			return this.currencies.ContainsValue(currency);
		}

		public IEnumerator GetEnumerator()
		{
			return this.currencies.Values.GetEnumerator();
		}
	}
}
