using System;
using System.Collections;

namespace FreeQuant.Instruments
{
	public class PortfolioList : IEnumerable
	{
		private SortedList portfolios;
		private Hashtable portfoliosById;

		public int Count
		{
			get
			{
				return this.portfolios.Count;
			}
		}

		public Portfolio this[string name]
		{
			get
			{
				return this.portfolios[name] as Portfolio;
			}
		}

		internal PortfolioList()
		{
			this.portfolios = new SortedList();
			this.portfoliosById = new Hashtable();
		}

		public static implicit operator Portfolio[](PortfolioList list)
		{
			return new ArrayList(list.portfolios.Values).ToArray(typeof(Portfolio)) as Portfolio[];
		}

		internal void Add(Portfolio portfolio)
		{
			if (this.portfolios.Contains(portfolio.Name))
				throw new ApplicationException("" + portfolio.Name);
			this.portfolios.Add(portfolio.Name, portfolio);
			if (portfolio.Id == -1)
				return;
			if (this.portfoliosById.Contains(portfolio.Id))
				throw new ApplicationException("" + portfolio.Id);
			this.portfoliosById.Add(portfolio.Id, portfolio);
		}

		internal void Remove(Portfolio portfolio)
		{
			this.portfolios.Remove(portfolio.Name);
			this.portfoliosById.Remove(portfolio.Id);
		}

		public Portfolio GetById(int id)
		{
			return this.portfoliosById[id] as Portfolio;
		}

		public bool Contains(string name)
		{
			return this.portfolios.ContainsKey(name);
		}

		public void Rename(string oldName, string newName)
		{
			Portfolio portfolio = this[oldName];
			portfolio.Name = newName;
			this.portfolios.Remove(oldName);
			this.portfolios.Add(newName, portfolio);
		}

		public IEnumerator GetEnumerator()
		{
			return this.portfolios.Values.GetEnumerator();
		}
	}
}