using FreeQuant;
using FreeQuant.FIX;
using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Diagnostics;
using System.Xml;
using System.Text;
using System.Collections;

namespace FreeQuant.Providers
{
	public class ProviderManager
	{
		private const string GbBtlEIZy6 = "provider.properties.xml";
		private static object dataLock;
		private static bool threadSafe;
		private static ProviderList providers;
		private static ExecutionProviderList executionProviders;
		private static MarketDataProviderList marketDataProviders;
		private static InstrumentProviderList instrumentProviders;
		private static HistoricalDataProviderList historicalDataProviders;
		private static IMarketDataProvider marketDataProvider;
		private static IExecutionProvider executionProvider;
		private static ProviderErrorCollection errors;

		public static ProviderList Providers
		{
			get
			{
				return ProviderManager.providers;
			}
		}

		public static ExecutionProviderList ExecutionProviders
		{
			get
			{
				return ProviderManager.executionProviders;
			}
		}

		public static MarketDataProviderList MarketDataProviders
		{
			get
			{
				return ProviderManager.marketDataProviders;
			}
		}

		public static InstrumentProviderList InstrumentProviders
		{
			get
			{
				return ProviderManager.instrumentProviders; 
			}
		}

		public static HistoricalDataProviderList HistoricalDataProviders
		{
			get
			{
				return ProviderManager.historicalDataProviders; 
			}
		}

		public static IExecutionProvider DefaultExecutionProvider
		{
			get
			{
				return ProviderManager.executionProviders[Framework.Configuration.DefaultExecutionProvider];
			}
			set
			{
				if (value == null)
					Framework.Configuration.DefaultExecutionProvider = "";
				else
					Framework.Configuration.DefaultExecutionProvider = value.Name;
			}
		}

		public static IMarketDataProvider DefaultMarketDataProvider
		{
			get
			{
				return ProviderManager.marketDataProviders[Framework.Configuration.DefaultMarketDataProvider];
			}
			set
			{
				if (value == null)
					Framework.Configuration.DefaultMarketDataProvider = "";
				else
					Framework.Configuration.DefaultMarketDataProvider = value.Name;
			}
		}

		public static IMarketDataProvider MarketDataSimulator
		{
			get
			{
				return ProviderManager.marketDataProvider;
			}
			set
			{
				ProviderManager.marketDataProvider = value;
			}
		}

		public static IExecutionProvider ExecutionSimulator
		{
			get
			{
				return ProviderManager.executionProvider;
			}
			set
			{
				ProviderManager.executionProvider = value;
			}
		}

		public static ProviderErrorCollection Errors
		{
			get
			{
				return ProviderManager.errors;
			}
		}

		public static event ProviderEventHandler Added;
		public static event ProviderEventHandler Connected;
		public static event ProviderEventHandler Disconnected;
		public static event ProviderEventHandler StatusChanged;
		public static event ProviderErrorEventHandler Error;
		public static event MarketDataRequestRejectEventHandler MarketDataRequestReject;
		public static event TradeEventHandler NewTrade;
		public static event QuoteEventHandler NewQuote;
		public static event BarEventHandler NewBar;
		public static event BarEventHandler NewBarOpen;
		public static event BarSliceEventHandler NewBarSlice;
		public static event MarketDepthEventHandler NewMarketDepth;
		public static event FundamentalEventHandler NewFundamental;
		public static event CorporateActionEventHandler NewCorporateAction;
		public static event ExecutionReportEventHandler ExecutionReport;
		public static event OrderCancelRejectEventHandler OrderCancelReject;

		static ProviderManager()
		{
			ProviderManager.dataLock = new object();
			ProviderManager.executionProviders = new ExecutionProviderList();
			ProviderManager.marketDataProviders = new MarketDataProviderList();
			ProviderManager.instrumentProviders = new InstrumentProviderList();
			ProviderManager.historicalDataProviders = new HistoricalDataProviderList();   
			ProviderManager.marketDataProvider = null;  
			ProviderManager.executionProvider = null; 
			ProviderManager.errors = new ProviderErrorCollection();
		}

		public static void Add(IProvider provider)
		{
//			if (Framework.Installation.Edition == Edition.Research)
//			{
//				switch (provider.Id)
//				{
//					case (byte) 1:
//					case (byte) 2:
//					case (byte) 17:
//					case (byte) 19:
//					case (byte) 25:
//						break;
//					case (byte) 18:
//						return;
//					default:
//						return;
//				}
//			}
			ProviderManager.providers.AddProvider(provider);
			if (provider is IExecutionProvider)
				ProviderManager.executionProviders.AddProvider(provider);
			if (provider is IMarketDataProvider)
				ProviderManager.marketDataProviders.AddProvider(provider);
			if (provider is IInstrumentProvider)
				ProviderManager.instrumentProviders.AddProvider(provider);
			if (provider is IHistoricalDataProvider)
				ProviderManager.historicalDataProviders.AddProvider(provider);
			provider.Connected += new EventHandler(ProviderManager.EmitConnected);
			provider.Disconnected += new EventHandler(ProviderManager.EmitDisconnected);
			provider.StatusChanged += new EventHandler(ProviderManager.EmitStatusChanged);
			provider.Error += new ProviderErrorEventHandler(ProviderManager.OnProviderError);
			ProviderManager.EmitAdded(provider);
			IMarketDataProvider marketDataProvider = provider as IMarketDataProvider;
			if (marketDataProvider != null)
			{
				marketDataProvider.NewQuote += new QuoteEventHandler(ProviderManager.EmitNewQuote);
				marketDataProvider.NewTrade += new TradeEventHandler(ProviderManager.EmitNewTrade);
				marketDataProvider.NewBar += new BarEventHandler(ProviderManager.EmitNewBar);
				marketDataProvider.NewBarOpen += new BarEventHandler(ProviderManager.EmitNewBarOpen);
				marketDataProvider.NewBarSlice += new BarSliceEventHandler(ProviderManager.EmitNewBarSlice);
				marketDataProvider.NewMarketDepth += new MarketDepthEventHandler(ProviderManager.EmitNewMarketDepth);
				marketDataProvider.NewFundamental += new FundamentalEventHandler(ProviderManager.EmitNewFundamental);
				marketDataProvider.NewCorporateAction += new CorporateActionEventHandler(ProviderManager.EmitNewCorporateAction);
				marketDataProvider.MarketDataRequestReject += new MarketDataRequestRejectEventHandler(ProviderManager.EmitMarketDataRequestReject);
			}
			IExecutionProvider executionProvider = provider as IExecutionProvider;
			if (executionProvider != null)
			{
				executionProvider.ExecutionReport += new ExecutionReportEventHandler(ProviderManager.EmitExecutionReport);
				executionProvider.OrderCancelReject += new OrderCancelRejectEventHandler(ProviderManager.EmitOrderCancelReject);
			}
			ProviderManager.LoadProviderProperties(provider);
		}

		public static void Disconnect()
		{
			foreach (IProvider provider in ProviderManager.providers)
				provider.Disconnect();
		}

		public static void Shutdown()
		{
			foreach (IProvider provider in ProviderManager.providers)
				provider.Shutdown();
		}

		public static void WaitConnected(IProvider provider, int timeout)
		{
			long ticks = DateTime.Now.Ticks;
			while (!provider.IsConnected)
			{
				Thread.Sleep(1);
				if (TimeSpan.FromTicks(DateTime.Now.Ticks - ticks).TotalMilliseconds >= timeout)
					break;
			}
		}

		public static void SaveProviderProperties()
		{
//      CUsHnTDPJW7M4WgDtf cusHnTdpjW7M4WgDtf = new CUsHnTDPJW7M4WgDtf();
//      foreach (IProvider provider in ProviderManager.rVCt6TF5nk)
//      {
//        t7qr3PW9BqfEC7uE03 t7qr3Pw9BqfEc7uE03 = cusHnTdpjW7M4WgDtf.UyAg6fUFwm();
//        t7qr3Pw9BqfEc7uE03.X9BcqfEC7(provider.Name);
//        foreach (PropertyInfo propertyInfo in provider.GetType().GetProperties())
//        {
//          if (propertyInfo.CanRead && propertyInfo.CanWrite && (propertyInfo.PropertyType.IsValueType || propertyInfo.PropertyType == typeof (string)))
//          {
//            object obj = propertyInfo.GetValue((object) provider, (object[]) null);
//            if (obj != null)
//              t7qr3Pw9BqfEc7uE03.mTsjrEw5W().kGvLO8MRnR(propertyInfo.Name, propertyInfo.PropertyType, obj.ToString());
//          }
//        }
//        if (provider is IMarketDataProvider)
//        {
//          IBarFactory barFactory = (provider as IMarketDataProvider).BarFactory;
//          if (barFactory != null)
//          {
//            r0Hb6IvhG2qUmE6ALG hb6IvhG2qUmE6Alg = t7qr3Pw9BqfEc7uE03.oFCn3DIZM();
//            hb6IvhG2qUmE6Alg.WSMQ7NAan(barFactory.GetType());
//            hb6IvhG2qUmE6Alg.FvwPGCHwF(barFactory.Enabled);
//            hb6IvhG2qUmE6Alg.rtkz5NMi1(barFactory.Input);
//            foreach (BarFactoryItem barFactoryItem in barFactory.Items)
//              hb6IvhG2qUmE6Alg.S2sttA3GOO().pkKLYFc0JS(barFactoryItem);
//            foreach (PropertyInfo propertyInfo in barFactory.GetType().GetProperties())
//            {
//              if (propertyInfo.DeclaringType != typeof (BarFactory) && propertyInfo.CanRead && propertyInfo.CanWrite && (propertyInfo.PropertyType.IsValueType || propertyInfo.PropertyType == typeof (string)))
//              {
//                object obj = propertyInfo.GetValue((object) barFactory, (object[]) null);
//                if (obj != null)
//                  hb6IvhG2qUmE6Alg.O8xtLSXFit().kGvLO8MRnR(propertyInfo.Name, propertyInfo.PropertyType, obj.ToString());
//              }
//            }
//          }
//        }
//      }
//      cusHnTdpjW7M4WgDtf.Save(Framework.Installation.IniDir.FullName + GojrKtfk5NMi1fou68.a17L2Y7Wnd(614));
		}

		public static void LoadProviderProperties(IProvider provider)
		{
			FileInfo fileInfo = new FileInfo(Framework.Installation.IniDir.FullName + "");
      if (!fileInfo.Exists)
        return;
//      CUsHnTDPJW7M4WgDtf cusHnTdpjW7M4WgDtf = new CUsHnTDPJW7M4WgDtf();
//      cusHnTdpjW7M4WgDtf.Load(fileInfo.FullName);
//      foreach (t7qr3PW9BqfEC7uE03 t7qr3Pw9BqfEc7uE03 in cusHnTdpjW7M4WgDtf.fmKgml3fJH())
//      {
//        if (provider.Name == t7qr3Pw9BqfEc7uE03.wyivi7qr3())
//        {
//          Type type = provider.GetType();
//          foreach (FqMNl096LmbQ0W7l8l mnl096LmbQ0W7l8l in t7qr3Pw9BqfEc7uE03.mTsjrEw5W())
//          {
//            if (!(mnl096LmbQ0W7l8l.aPUgPIGAXC() == (Type) null))
//            {
//              PropertyInfo property = type.GetProperty(mnl096LmbQ0W7l8l.AdkgQLdHu2(), mnl096LmbQ0W7l8l.aPUgPIGAXC());
//              if (!(property == (PropertyInfo) null))
//              {
//                object obj = !property.PropertyType.IsEnum ? (!(property.PropertyType == typeof (string)) ? (!(property.PropertyType == typeof (TimeSpan)) ? Convert.ChangeType((object) mnl096LmbQ0W7l8l.nqJgzNBgWA(), property.PropertyType) : (object) TimeSpan.Parse(mnl096LmbQ0W7l8l.nqJgzNBgWA())) : (object) mnl096LmbQ0W7l8l.nqJgzNBgWA()) : Enum.Parse(property.PropertyType, mnl096LmbQ0W7l8l.nqJgzNBgWA());
//                property.SetValue((object) provider, obj, (object[]) null);
//              }
//            }
//          }
//          if (!(provider is IMarketDataProvider))
//            break;
//          r0Hb6IvhG2qUmE6ALG hb6IvhG2qUmE6Alg = t7qr3Pw9BqfEc7uE03.guM56TQoR();
//          if (hb6IvhG2qUmE6Alg == null)
//            break;
//          IBarFactory barFactory;
//          try
//          {
//            barFactory = (IBarFactory) Activator.CreateInstance(hb6IvhG2qUmE6Alg.D3NVxuFsh());
//          }
//          catch
//          {
//            barFactory = (IBarFactory) new BarFactory();
//          }
//          barFactory.Enabled = hb6IvhG2qUmE6Alg.RPMqsubaw();
//          barFactory.Input = hb6IvhG2qUmE6Alg.WZc2Vpojr();
//          barFactory.Items.Clear();
//          foreach (avKSegOiKf5gQH28qE ksegOiKf5gQh28qE in hb6IvhG2qUmE6Alg.S2sttA3GOO())
//            barFactory.Items.Add(ksegOiKf5gQh28qE.AEygMoHbVt(), ksegOiKf5gQh28qE.cqngy8uVoP(), ksegOiKf5gQh28qE.IiZgxh90BE());
//          foreach (FqMNl096LmbQ0W7l8l mnl096LmbQ0W7l8l in hb6IvhG2qUmE6Alg.O8xtLSXFit())
//          {
//            PropertyInfo property = barFactory.GetType().GetProperty(mnl096LmbQ0W7l8l.AdkgQLdHu2(), mnl096LmbQ0W7l8l.aPUgPIGAXC());
//            if (!(property == (PropertyInfo) null))
//            {
//              object obj = !property.PropertyType.IsEnum ? (!(property.PropertyType == typeof (string)) ? (!(property.PropertyType == typeof (TimeSpan)) ? Convert.ChangeType((object) mnl096LmbQ0W7l8l.nqJgzNBgWA(), property.PropertyType) : (object) TimeSpan.Parse(mnl096LmbQ0W7l8l.nqJgzNBgWA())) : (object) mnl096LmbQ0W7l8l.nqJgzNBgWA()) : Enum.Parse(property.PropertyType, mnl096LmbQ0W7l8l.nqJgzNBgWA());
//              property.SetValue((object) barFactory, obj, (object[]) null);
//            }
//          }
//          (provider as IMarketDataProvider).BarFactory = barFactory;
//          break;
//        }
//      }
		}

		private static void EmitAdded(IProvider provider)
		{
      if (ProviderManager.Added != null)
      	ProviderManager.Added(new ProviderEventArgs(provider));
		}

		private static void EmitConnected(object sender, EventArgs e)
		{
			if (ProviderManager.threadSafe)
				Monitor.Enter(ProviderManager.dataLock);
			try
			{
				if (ProviderManager.Connected != null)
					ProviderManager.Connected(new ProviderEventArgs(sender as IProvider));
			}
			finally
			{
				if (ProviderManager.threadSafe)
					Monitor.Exit(ProviderManager.dataLock);
			}
		}

		private static void EmitDisconnected(object sender, EventArgs e)
		{
			if (ProviderManager.threadSafe)
				Monitor.Enter(ProviderManager.dataLock);
			try
			{
				if (ProviderManager.Disconnected != null)
					ProviderManager.Disconnected(new ProviderEventArgs(sender as IProvider));
			}
			finally
			{
				if (ProviderManager.threadSafe)
					Monitor.Exit(ProviderManager.dataLock);
			}
		}

		private static void EmitStatusChanged(object sender, EventArgs e)
		{
			if (ProviderManager.threadSafe)
				Monitor.Enter(ProviderManager.dataLock);
			try
			{
				if (ProviderManager.StatusChanged != null)
					ProviderManager.StatusChanged(new ProviderEventArgs(sender as IProvider));
			}
			finally
			{
				if (ProviderManager.threadSafe)
					Monitor.Exit(ProviderManager.dataLock);
			}
		}

		private static void OnProviderError(ProviderErrorEventArgs e)
		{
			if (ProviderManager.threadSafe)
				Monitor.Enter(ProviderManager.dataLock);
			try
			{
				if (Trace.IsLevelEnabled(TraceLevel.Error))
					Trace.WriteLine(e.ToString() + Environment.NewLine);
				ProviderManager.errors.Add(e.Error);
	        if (ProviderManager.Error != null)
	       	 ProviderManager.Error(e);
			}
			finally
			{
				if (ProviderManager.threadSafe)
					Monitor.Exit(ProviderManager.dataLock);
			}
		}

		private static void EmitMarketDataRequestReject(object sender, MarketDataRequestRejectEventArgs e)
		{
			if (ProviderManager.threadSafe)
				Monitor.Enter(ProviderManager.dataLock);
			try
			{
				if (ProviderManager.MarketDataRequestReject == null)
          return;
				ProviderManager.MarketDataRequestReject(sender, e);
			}
			finally
			{
				if (ProviderManager.threadSafe)
					Monitor.Exit(ProviderManager.dataLock);
			}
		}

		private static void EmitNewBar(object sender, BarEventArgs e)
		{
			if (ProviderManager.threadSafe)
				Monitor.Enter(ProviderManager.dataLock);
			try
			{
        if (ProviderManager.NewBar != null)
					ProviderManager.NewBar(sender, e); 
			}
			finally
			{
				if (ProviderManager.threadSafe)
					Monitor.Exit(ProviderManager.dataLock);
			}
		}

		private static void EmitNewBarOpen(object sender, BarEventArgs e)
		{
			if (ProviderManager.threadSafe)
				Monitor.Enter(ProviderManager.dataLock);
			try
			{
				if (ProviderManager.NewBarOpen != null)
					ProviderManager.NewBarOpen(sender, e);
			}
			finally
			{
				if (ProviderManager.threadSafe)
					Monitor.Exit(ProviderManager.dataLock);
			}
		}

		private static void EmitNewBarSlice(object sender, BarSliceEventArgs e)
		{
			if (ProviderManager.threadSafe)
				Monitor.Enter(ProviderManager.dataLock);
			try
			{
        if (ProviderManager.NewBarSlice != null)
					ProviderManager.NewBarSlice(sender, e); 
			}
			finally
			{
				if (ProviderManager.threadSafe)
					Monitor.Exit(ProviderManager.dataLock);
			}
		}

		private static void EmitNewTrade(object sender, TradeEventArgs e)
		{
			if (ProviderManager.threadSafe)
				Monitor.Enter(ProviderManager.dataLock);
			try
			{
				if (ProviderManager.NewTrade != null)
					ProviderManager.NewTrade(sender, e);
			}
			finally
			{
				if (ProviderManager.threadSafe)
					Monitor.Exit(ProviderManager.dataLock);
			}
		}

		private static void EmitNewQuote(object sender, QuoteEventArgs e)
		{
			if (ProviderManager.threadSafe)
				Monitor.Enter(ProviderManager.dataLock);
			try
			{
				if (ProviderManager.NewQuote != null)
					ProviderManager.NewQuote(sender, e);
			}
			finally
			{
				if (ProviderManager.threadSafe)
					Monitor.Exit(ProviderManager.dataLock);
			}
		}

		private static void EmitNewMarketDepth(object sender, MarketDepthEventArgs e)
		{
			if (ProviderManager.threadSafe)
				Monitor.Enter(ProviderManager.dataLock);
			try
			{
        if (ProviderManager.NewMarketDepth != null)
					ProviderManager.NewMarketDepth(sender, e);
			}
			finally
			{
				if (ProviderManager.threadSafe)
					Monitor.Exit(ProviderManager.dataLock);
			}
		}

		private static void EmitNewFundamental(object sender, FundamentalEventArgs e)
		{
			if (ProviderManager.threadSafe)
				Monitor.Enter(ProviderManager.dataLock);
			try
			{
				if (ProviderManager.NewFundamental != null)
					ProviderManager.NewFundamental(sender, e);
			}
			finally
			{
				if (ProviderManager.threadSafe)
					Monitor.Exit(ProviderManager.dataLock);
			}
		}

		private static void EmitNewCorporateAction(object sender, CorporateActionEventArgs e)
		{
			if (ProviderManager.threadSafe)
				Monitor.Enter(ProviderManager.dataLock);
			try
			{
				if (ProviderManager.NewCorporateAction != null)
					ProviderManager.NewCorporateAction(sender, e);
			}
			finally
			{
				if (ProviderManager.threadSafe)
					Monitor.Exit(ProviderManager.dataLock);
			}
		}

		private static void EmitExecutionReport(object sender, ExecutionReportEventArgs e)
		{
			if (ProviderManager.threadSafe)
				Monitor.Enter(ProviderManager.dataLock);
			try
			{
				if (ProviderManager.ExecutionReport != null)
					ProviderManager.ExecutionReport(sender, e);
			}
			finally
			{
				if (ProviderManager.threadSafe)
					Monitor.Exit(ProviderManager.dataLock);
			}
		}

		private static void EmitOrderCancelReject(object sender, OrderCancelRejectEventArgs e)
		{
			if (ProviderManager.threadSafe)
				Monitor.Enter(ProviderManager.dataLock);
			try
			{
				if (ProviderManager.OrderCancelReject != null)
					ProviderManager.OrderCancelReject(sender, e);
			}
			finally
			{
				if (ProviderManager.threadSafe)
					Monitor.Exit(ProviderManager.dataLock);
			}
		}

		class t7qr3PW9BqfEC7uE03
		{
			internal const string Lb6RIhG2q = "provider";
			private const string PmE96ALG9 = "name";
			private XmlNode vi7YvTQmW;

			internal t7qr3PW9BqfEC7uE03(XmlNode obj0)
			{
				this.vi7YvTQmW = obj0;
			}

			
			public static implicit operator XmlNode(t7qr3PW9BqfEC7uE03 obj0)
			{
				return obj0.vi7YvTQmW;
			}

			
			public static explicit operator t7qr3PW9BqfEC7uE03(XmlNode obj0)
			{
				return new t7qr3PW9BqfEC7uE03(obj0);
			}

			internal string wyivi7qr3()
			{
				return this.vi7YvTQmW.Attributes["dsdfs"].Value;
			}

			internal void X9BcqfEC7(string obj0)
			{
				this.vi7YvTQmW.Attributes.Append(this.vi7YvTQmW.OwnerDocument.CreateAttribute("fsf")).Value = obj0;
			}

//			internal yFGL6nd23hYLVBDrwG mTsjrEw5W()
//			{
//				foreach (XmlNode xmlNode in this.vi7YvTQmW)
//				{
//					if (xmlNode.Name == GojrKtfk5NMi1fou68.a17L2Y7Wnd(304))
//						return xmlNode;
//				}
//				yFGL6nd23hYLVBDrwG fgL6nd23hYlvbDrwG = (yFGL6nd23hYLVBDrwG) ((XmlNode) this.vi7YvTQmW.OwnerDocument.CreateElement(GojrKtfk5NMi1fou68.a17L2Y7Wnd(328)));
//				this.vi7YvTQmW.AppendChild((XmlNode) fgL6nd23hYlvbDrwG);
//				return fgL6nd23hYlvbDrwG;
//			}
//
//			internal r0Hb6IvhG2qUmE6ALG guM56TQoR()
//			{
//				foreach (XmlNode xmlNode in this.vi7YvTQmW)
//				{
//					if (xmlNode.Name == GojrKtfk5NMi1fou68.a17L2Y7Wnd(352))
//						return (r0Hb6IvhG2qUmE6ALG) xmlNode;
//				}
//				return null;
//			}
//
//			
//			internal r0Hb6IvhG2qUmE6ALG oFCn3DIZM()
//			{
//				r0Hb6IvhG2qUmE6ALG hb6IvhG2qUmE6Alg = (r0Hb6IvhG2qUmE6ALG) ((XmlNode) this.vi7YvTQmW.OwnerDocument.CreateElement(GojrKtfk5NMi1fou68.a17L2Y7Wnd(376)));
//				this.vi7YvTQmW.AppendChild((XmlNode) hb6IvhG2qUmE6Alg);
//				return hb6IvhG2qUmE6Alg;
//			}
		}
//
//		class CUsHnTDPJW7M4WgDtf : XmlDocument
//		{
//			private const string EA1gosSErp = "providers";
//
//			
//			internal CUsHnTDPJW7M4WgDtf() : base()
//			{
//				this.LoadXml("xml.name");
//				this.InsertBefore(this.CreateXmlDeclaration("de", Encoding.Unicode.HeaderName, null), this.DocumentElement);
//				this.InsertBefore(this.CreateComment("ddfdf"), this.DocumentElement);
//			}
//
//			internal t7qr3PW9BqfEC7uE03 UyAg6fUFwm()
//			{
//				t7qr3PW9BqfEC7uE03 t7qr3Pw9BqfEc7uE03 = (t7qr3PW9BqfEC7uE03) ((XmlNode) this.CreateElement(GojrKtfk5NMi1fou68.a17L2Y7Wnd(916)));
//				this.DocumentElement.AppendChild((XmlNode) t7qr3Pw9BqfEc7uE03);
//				return t7qr3Pw9BqfEc7uE03;
//			}
//
//			internal t7qr3PW9BqfEC7uE03[] fmKgml3fJH()
//			{
//				ArrayList arrayList = new ArrayList();
//				foreach (XmlNode xmlNode in (XmlNode) this.DocumentElement)
//					arrayList.Add((object) (t7qr3PW9BqfEC7uE03) xmlNode);
//				return arrayList.ToArray(typeof (t7qr3PW9BqfEC7uE03)) as t7qr3PW9BqfEC7uE03[];
//			}
//		}
	}
}
