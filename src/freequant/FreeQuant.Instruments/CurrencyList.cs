using System;
using System.Collections;
using System.Runtime.CompilerServices;

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

		public Currency this [int index]
		{
			get
			{
				return this.currencies.GetByIndex(index) as Currency;
			}
		}

		public Currency this [string code]
		{
			get
			{
				return this.currencies[(object)code] as Currency;
			}
		}

		public CurrencyList()
		{

			this.currencies = new SortedList();
		}

		public void Add(Currency currency)
		{
			if (this.currencies.Contains((object)currency.Code))
				throw new ApplicationException("" + currency.Code);
			this.currencies.Add((object)currency.Code, (object)currency);
		}

		public void Remove(Currency currency)
		{
			this.currencies.Remove((object)currency.Code);
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
			return this.currencies.Contains((object)code);
		}

		public bool Contains(Currency currency)
		{
			return this.currencies.ContainsValue((object)currency);
		}

		public IEnumerator GetEnumerator()
		{
			return this.currencies.Values.GetEnumerator();
		}
	}
}
