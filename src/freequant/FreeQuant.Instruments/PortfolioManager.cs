using FreeQuant;
using System;
using System.Runtime.InteropServices;

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
  
			PortfolioManager.pricer = (IPortfolioPricer)new PortfolioPricer();
			PortfolioManager.server = (IPortfolioServer)new PortfolioDbServer();
			Type connectionType = (Type)null;
			string connectionString = string.Empty;
			switch (Framework.Storage.ServerType)
			{
				case DbServerType.MS_ACCESS:
					connectionType = Type.GetType("");
					connectionString = string.Format("dfs", (object)Framework.Installation.DataDir.FullName);
					break;
				case DbServerType.SQL_SERVER_COMPACT_EDITION_35:
					connectionType = Type.GetType("");
					connectionString = string.Format("fsfs", Framework.Installation.DataDir.FullName);
					break;
			}
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

		internal static void LfnseafCc7(Portfolio portfolio, Transaction transaction)
		{
			PortfolioManager.server.Add(portfolio, transaction);
		}

		internal static void vwIs2WhnRQ([In] Portfolio obj0, [In] AccountTransaction obj1)
		{
			PortfolioManager.server.Add(obj0, obj1);
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
