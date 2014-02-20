using System;

namespace FreeQuant.Instruments
{
    class PortfolioFileServer : IPortfolioServer
    {
        public PortfolioFileServer()
        {
        }

        public void Open(Type connectionType, string connectionString)
        {
        }

        public void Close()
        {
        }

        public PortfolioList Load()
        {
            return new PortfolioList();
        }

        public void Save(Portfolio portfolio)
        {
        }

        public void Remove(Portfolio portfolio)
        {
        }

        public void Update(Portfolio portfolio)
        {
        }

        public void Clear(Portfolio portfolio)
        {
        }

        public void Add(Portfolio portfolio, Transaction transaction)
        {
        }

        public void Add(Portfolio portfolio, AccountTransaction transaction)
        {
        }
    }
}

