using System;

namespace FreeQuant.Instruments
{
	public interface IPortfolioServer
	{
		void Open(Type connectionType, string connectionString);

		void Close();

		PortfolioList Load();

		void Save(Portfolio portfolio);

		void Remove(Portfolio portfolio);

		void Update(Portfolio portfolio);

		void Clear(Portfolio portfolio);

		void Add(Portfolio portfolio, Transaction transaction);

		void Add(Portfolio portfolio, AccountTransaction transaction);
	}
}
