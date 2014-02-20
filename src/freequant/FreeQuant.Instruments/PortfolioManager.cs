using FreeQuant;
using System;
using System.IO;

namespace FreeQuant.Instruments
{
	public class PortfolioManager
	{
		private static IPortfolioServer server;
		private static PortfolioList portfolios;
		private static IPortfolioPricer pricer;

		public static Portfolio DefaultPortfolio
		{
			get
			{
				return PortfolioManager.portfolios[Framework.Configuration.DefaultPortfolio];
			}
			set
			{
				Framework.Configuration.DefaultPortfolio = value.Name;
			}
		}

		public static PortfolioList Portfolios
		{
			get
			{
				return PortfolioManager.portfolios; 
			}
		}

		public static IPortfolioServer Server
		{
			get
			{
				return PortfolioManager.server; 
			}
			set
			{
				PortfolioManager.server = value;
			}
		}

		public static IPortfolioPricer Pricer
		{
			get
			{
				return PortfolioManager.pricer; 
			}
			set
			{
				PortfolioManager.pricer = value;
			}
		}

		public static event PortfolioEventHandler PortfolioAdded;
		public static event PortfolioEventHandler PortfolioRemoved;

		static PortfolioManager()
		{
			PortfolioManager.pricer = new PortfolioPricer();

			Type connectionType = null;
			string connectionString = string.Empty;
			switch (Framework.Storage.ServerType)
			{
                case DbServerType.SQLITE:
                    connectionType = Type.GetType("SQLiteConnection");
                    connectionString = string.Format("Data Source={0};Pooling=true;FailIfMissing=false;", Path.Combine(Framework.Installation.DataDir.FullName, "freequant.db"));
                    break;
                default:
                    throw new NotSupportedException("This db is not support yet.");
            }

//            PortfolioManager.server = new PortfolioDbServer();
            PortfolioManager.server = new PortfolioFileServer();
			PortfolioManager.server.Open(connectionType, connectionString);
			PortfolioManager.portfolios = PortfolioManager.server.Load();
		}

		public PortfolioManager()
		{
		}

		public static void Init()
		{
		}

		internal static void Add(Portfolio portfolio)
		{
			PortfolioManager.portfolios.Add(portfolio);
			PortfolioManager.EmitPortfolioAdded(portfolio);
		}

		public static void Remove(Portfolio portfolio)
		{
			PortfolioManager.server.Remove(portfolio);
			PortfolioManager.portfolios.Remove(portfolio);
			PortfolioManager.EmitPortfolioRemoved(portfolio);
		}

		internal static void Save(Portfolio portfolio)
		{
			PortfolioManager.server.Save(portfolio);
		}

		internal static void Update(Portfolio portfolio)
		{
			PortfolioManager.server.Update(portfolio);
		}

		internal static void Add(Portfolio portfolio, Transaction transaction)
		{
			PortfolioManager.server.Add(portfolio, transaction);
		}

		internal static void vwIs2WhnRQ(Portfolio position, AccountTransaction transaction)
		{
			PortfolioManager.server.Add(position, transaction);
		}

		internal static void Clear(Portfolio portfolio)
		{
			PortfolioManager.server.Clear(portfolio);
		}

		private static void EmitPortfolioAdded(Portfolio portfolio)
		{
			if (PortfolioManager.PortfolioAdded != null)
				PortfolioManager.PortfolioAdded(new PortfolioEventArgs(portfolio));
		}

		private static void EmitPortfolioRemoved(Portfolio portfolio)
		{
			if (PortfolioManager.PortfolioRemoved != null)
				PortfolioManager.PortfolioRemoved(new PortfolioEventArgs(portfolio));
		}
	}
}
