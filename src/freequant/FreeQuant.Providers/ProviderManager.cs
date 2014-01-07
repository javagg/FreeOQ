using dW79p7NPlS6ZxObcx3;
using GUBX1u5sgj9bjojYlR;
using i0eSeRYRAl7LvcyCmM;
using i6Ws9TSsrEw5WGORfa;
using nZi7vTcQmWAr4x9X4G;
using Obgh2s3A3GOOarwj6c;
using FreeQuant;
using FreeQuant.FIX;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using YS2DsgRiCe1qDb6nZV;

namespace FreeQuant.Providers
{
  public class ProviderManager
  {
    private const string GbBtlEIZy6 = "provider.properties.xml";
    private static object Qcht7lAgti;
    private static bool XwWte6RY39;
    private static ProviderList rVCt6TF5nk;
    private static ExecutionProviderList KGXtmeVerO;
    private static MarketDataProviderList nOmtoMmG6Q;
    private static InstrumentProviderList ljbtMTjldy;
    private static HistoricalDataProviderList rlMtpT1jXx;
    private static IMarketDataProvider mi7tNm4m7F;
    private static IExecutionProvider KmPtyC3sWf;
    private static ProviderErrorCollection cIXt1Sv2ZR;

    public static ProviderList Providers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return ProviderManager.rVCt6TF5nk;
      }
    }

    public static ExecutionProviderList ExecutionProviders
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return ProviderManager.KGXtmeVerO;
      }
    }

    public static MarketDataProviderList MarketDataProviders
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return ProviderManager.nOmtoMmG6Q;
      }
    }

    public static InstrumentProviderList InstrumentProviders
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return ProviderManager.ljbtMTjldy;
      }
    }

    public static HistoricalDataProviderList HistoricalDataProviders
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return ProviderManager.rlMtpT1jXx;
      }
    }

    public static IExecutionProvider DefaultExecutionProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return ProviderManager.KGXtmeVerO[Framework.Configuration.DefaultExecutionProvider];
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (value == null)
          Framework.Configuration.DefaultExecutionProvider = "";
        else
          Framework.Configuration.DefaultExecutionProvider = value.Name;
      }
    }

    public static IMarketDataProvider DefaultMarketDataProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return ProviderManager.nOmtoMmG6Q[Framework.Configuration.DefaultMarketDataProvider];
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (value == null)
          Framework.Configuration.DefaultMarketDataProvider = "";
        else
          Framework.Configuration.DefaultMarketDataProvider = value.Name;
      }
    }

    public static IMarketDataProvider MarketDataSimulator
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return ProviderManager.mi7tNm4m7F;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        ProviderManager.mi7tNm4m7F = value;
      }
    }

    public static IExecutionProvider ExecutionSimulator
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return ProviderManager.KmPtyC3sWf;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        ProviderManager.KmPtyC3sWf = value;
      }
    }

    public static ProviderErrorCollection Errors
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return ProviderManager.cIXt1Sv2ZR;
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ProviderManager()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      ProviderManager.Qcht7lAgti = new object();
      ProviderManager.XwWte6RY39 = false;
      ProviderManager.rVCt6TF5nk = new ProviderList();
      ProviderManager.KGXtmeVerO = new ExecutionProviderList();
      ProviderManager.nOmtoMmG6Q = new MarketDataProviderList();
      ProviderManager.ljbtMTjldy = new InstrumentProviderList();
      ProviderManager.rlMtpT1jXx = new HistoricalDataProviderList();
      ProviderManager.mi7tNm4m7F = (IMarketDataProvider) null;
      ProviderManager.KmPtyC3sWf = (IExecutionProvider) null;
      ProviderManager.cIXt1Sv2ZR = new ProviderErrorCollection();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProviderManager()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Add(IProvider provider)
    {
      if (Framework.Installation.Edition == Edition.Research)
      {
        switch (provider.Id)
        {
          case (byte) 1:
          case (byte) 2:
          case (byte) 17:
          case (byte) 19:
          case (byte) 25:
            break;
          case (byte) 18:
            return;
          default:
            return;
        }
      }
      ProviderManager.rVCt6TF5nk.HH8tS7bFw(provider);
      if (provider is IExecutionProvider)
        ProviderManager.KGXtmeVerO.HH8tS7bFw(provider);
      if (provider is IMarketDataProvider)
        ProviderManager.nOmtoMmG6Q.HH8tS7bFw(provider);
      if (provider is IInstrumentProvider)
        ProviderManager.ljbtMTjldy.HH8tS7bFw(provider);
      if (provider is IHistoricalDataProvider)
        ProviderManager.rlMtpT1jXx.HH8tS7bFw(provider);
      provider.Connected += new EventHandler(ProviderManager.HZ5tYOBVvY);
      provider.Disconnected += new EventHandler(ProviderManager.gaItsrWC8h);
      provider.StatusChanged += new EventHandler(ProviderManager.IGntb6qhyP);
      provider.Error += new ProviderErrorEventHandler(ProviderManager.lT2tdDDwWW);
      ProviderManager.BKTt94mLeK(provider);
      IMarketDataProvider marketDataProvider = provider as IMarketDataProvider;
      if (marketDataProvider != null)
      {
        marketDataProvider.NewQuote += new QuoteEventHandler(ProviderManager.sNEtZMdMtX);
        marketDataProvider.NewTrade += new TradeEventHandler(ProviderManager.Xayt8ev6DF);
        marketDataProvider.NewBar += new BarEventHandler(ProviderManager.vxOtKbcx3K);
        marketDataProvider.NewBarOpen += new BarEventHandler(ProviderManager.x7ptud5DXG);
        marketDataProvider.NewBarSlice += new BarSliceEventHandler(ProviderManager.rcRtiseEP5);
        marketDataProvider.NewMarketDepth += new MarketDepthEventHandler(ProviderManager.DS3tXKrAL8);
        marketDataProvider.NewFundamental += new FundamentalEventHandler(ProviderManager.eSctT3jM8B);
        marketDataProvider.NewCorporateAction += new CorporateActionEventHandler(ProviderManager.Ev1tGOgRhf);
        marketDataProvider.MarketDataRequestReject += new MarketDataRequestRejectEventHandler(ProviderManager.A9ptr7PlS6);
      }
      IExecutionProvider executionProvider = provider as IExecutionProvider;
      if (executionProvider != null)
      {
        executionProvider.ExecutionReport += new ExecutionReportEventHandler(ProviderManager.w6qtfBxe26);
        executionProvider.OrderCancelReject += new OrderCancelRejectEventHandler(ProviderManager.SLKt3RqewM);
      }
      ProviderManager.LoadProviderProperties(provider);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Disconnect()
    {
      foreach (IProvider provider in ProviderManager.rVCt6TF5nk)
        provider.Disconnect();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Shutdown()
    {
      foreach (IProvider provider in ProviderManager.rVCt6TF5nk)
        provider.Shutdown();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void WaitConnected(IProvider provider, int timeout)
    {
      long ticks = DateTime.Now.Ticks;
      while (!provider.IsConnected)
      {
        Thread.Sleep(1);
        if (TimeSpan.FromTicks(DateTime.Now.Ticks - ticks).TotalMilliseconds >= (double) timeout)
          break;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SaveProviderProperties()
    {
      CUsHnTDPJW7M4WgDtf cusHnTdpjW7M4WgDtf = new CUsHnTDPJW7M4WgDtf();
      foreach (IProvider provider in ProviderManager.rVCt6TF5nk)
      {
        t7qr3PW9BqfEC7uE03 t7qr3Pw9BqfEc7uE03 = cusHnTdpjW7M4WgDtf.UyAg6fUFwm();
        t7qr3Pw9BqfEc7uE03.X9BcqfEC7(provider.Name);
        foreach (PropertyInfo propertyInfo in provider.GetType().GetProperties())
        {
          if (propertyInfo.CanRead && propertyInfo.CanWrite && (propertyInfo.PropertyType.IsValueType || propertyInfo.PropertyType == typeof (string)))
          {
            object obj = propertyInfo.GetValue((object) provider, (object[]) null);
            if (obj != null)
              t7qr3Pw9BqfEc7uE03.mTsjrEw5W().kGvLO8MRnR(propertyInfo.Name, propertyInfo.PropertyType, obj.ToString());
          }
        }
        if (provider is IMarketDataProvider)
        {
          IBarFactory barFactory = (provider as IMarketDataProvider).BarFactory;
          if (barFactory != null)
          {
            r0Hb6IvhG2qUmE6ALG hb6IvhG2qUmE6Alg = t7qr3Pw9BqfEc7uE03.oFCn3DIZM();
            hb6IvhG2qUmE6Alg.WSMQ7NAan(barFactory.GetType());
            hb6IvhG2qUmE6Alg.FvwPGCHwF(barFactory.Enabled);
            hb6IvhG2qUmE6Alg.rtkz5NMi1(barFactory.Input);
            foreach (BarFactoryItem barFactoryItem in barFactory.Items)
              hb6IvhG2qUmE6Alg.S2sttA3GOO().pkKLYFc0JS(barFactoryItem);
            foreach (PropertyInfo propertyInfo in barFactory.GetType().GetProperties())
            {
              if (propertyInfo.DeclaringType != typeof (BarFactory) && propertyInfo.CanRead && propertyInfo.CanWrite && (propertyInfo.PropertyType.IsValueType || propertyInfo.PropertyType == typeof (string)))
              {
                object obj = propertyInfo.GetValue((object) barFactory, (object[]) null);
                if (obj != null)
                  hb6IvhG2qUmE6Alg.O8xtLSXFit().kGvLO8MRnR(propertyInfo.Name, propertyInfo.PropertyType, obj.ToString());
              }
            }
          }
        }
      }
      cusHnTdpjW7M4WgDtf.Save(Framework.Installation.IniDir.FullName + GojrKtfk5NMi1fou68.a17L2Y7Wnd(614));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LoadProviderProperties(IProvider provider)
    {
      FileInfo fileInfo = new FileInfo(Framework.Installation.IniDir.FullName + GojrKtfk5NMi1fou68.a17L2Y7Wnd(666));
      if (!fileInfo.Exists)
        return;
      CUsHnTDPJW7M4WgDtf cusHnTdpjW7M4WgDtf = new CUsHnTDPJW7M4WgDtf();
      cusHnTdpjW7M4WgDtf.Load(fileInfo.FullName);
      foreach (t7qr3PW9BqfEC7uE03 t7qr3Pw9BqfEc7uE03 in cusHnTdpjW7M4WgDtf.fmKgml3fJH())
      {
        if (provider.Name == t7qr3Pw9BqfEc7uE03.wyivi7qr3())
        {
          Type type = provider.GetType();
          foreach (FqMNl096LmbQ0W7l8l mnl096LmbQ0W7l8l in t7qr3Pw9BqfEc7uE03.mTsjrEw5W())
          {
            if (!(mnl096LmbQ0W7l8l.aPUgPIGAXC() == (Type) null))
            {
              PropertyInfo property = type.GetProperty(mnl096LmbQ0W7l8l.AdkgQLdHu2(), mnl096LmbQ0W7l8l.aPUgPIGAXC());
              if (!(property == (PropertyInfo) null))
              {
                object obj = !property.PropertyType.IsEnum ? (!(property.PropertyType == typeof (string)) ? (!(property.PropertyType == typeof (TimeSpan)) ? Convert.ChangeType((object) mnl096LmbQ0W7l8l.nqJgzNBgWA(), property.PropertyType) : (object) TimeSpan.Parse(mnl096LmbQ0W7l8l.nqJgzNBgWA())) : (object) mnl096LmbQ0W7l8l.nqJgzNBgWA()) : Enum.Parse(property.PropertyType, mnl096LmbQ0W7l8l.nqJgzNBgWA());
                property.SetValue((object) provider, obj, (object[]) null);
              }
            }
          }
          if (!(provider is IMarketDataProvider))
            break;
          r0Hb6IvhG2qUmE6ALG hb6IvhG2qUmE6Alg = t7qr3Pw9BqfEc7uE03.guM56TQoR();
          if (hb6IvhG2qUmE6Alg == null)
            break;
          IBarFactory barFactory;
          try
          {
            barFactory = (IBarFactory) Activator.CreateInstance(hb6IvhG2qUmE6Alg.D3NVxuFsh());
          }
          catch
          {
            barFactory = (IBarFactory) new BarFactory();
          }
          barFactory.Enabled = hb6IvhG2qUmE6Alg.RPMqsubaw();
          barFactory.Input = hb6IvhG2qUmE6Alg.WZc2Vpojr();
          barFactory.Items.Clear();
          foreach (avKSegOiKf5gQH28qE ksegOiKf5gQh28qE in hb6IvhG2qUmE6Alg.S2sttA3GOO())
            barFactory.Items.Add(ksegOiKf5gQh28qE.AEygMoHbVt(), ksegOiKf5gQh28qE.cqngy8uVoP(), ksegOiKf5gQh28qE.IiZgxh90BE());
          foreach (FqMNl096LmbQ0W7l8l mnl096LmbQ0W7l8l in hb6IvhG2qUmE6Alg.O8xtLSXFit())
          {
            PropertyInfo property = barFactory.GetType().GetProperty(mnl096LmbQ0W7l8l.AdkgQLdHu2(), mnl096LmbQ0W7l8l.aPUgPIGAXC());
            if (!(property == (PropertyInfo) null))
            {
              object obj = !property.PropertyType.IsEnum ? (!(property.PropertyType == typeof (string)) ? (!(property.PropertyType == typeof (TimeSpan)) ? Convert.ChangeType((object) mnl096LmbQ0W7l8l.nqJgzNBgWA(), property.PropertyType) : (object) TimeSpan.Parse(mnl096LmbQ0W7l8l.nqJgzNBgWA())) : (object) mnl096LmbQ0W7l8l.nqJgzNBgWA()) : Enum.Parse(property.PropertyType, mnl096LmbQ0W7l8l.nqJgzNBgWA());
              property.SetValue((object) barFactory, obj, (object[]) null);
            }
          }
          (provider as IMarketDataProvider).BarFactory = barFactory;
          break;
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void BKTt94mLeK([In] IProvider obj0)
    {
      if (ProviderManager.XhMtIJlEEx == null)
        return;
      ProviderManager.XhMtIJlEEx(new ProviderEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void HZ5tYOBVvY([In] object obj0, [In] EventArgs obj1)
    {
      if (ProviderManager.XwWte6RY39)
        Monitor.Enter(ProviderManager.Qcht7lAgti);
      try
      {
        if (ProviderManager.QXQtxyUxBN == null)
          return;
        ProviderManager.QXQtxyUxBN(new ProviderEventArgs(obj0 as IProvider));
      }
      finally
      {
        if (ProviderManager.XwWte6RY39)
          Monitor.Exit(ProviderManager.Qcht7lAgti);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void gaItsrWC8h([In] object obj0, [In] EventArgs obj1)
    {
      if (ProviderManager.XwWte6RY39)
        Monitor.Enter(ProviderManager.Qcht7lAgti);
      try
      {
        if (ProviderManager.RmUtEXhlly == null)
          return;
        ProviderManager.RmUtEXhlly(new ProviderEventArgs(obj0 as IProvider));
      }
      finally
      {
        if (ProviderManager.XwWte6RY39)
          Monitor.Exit(ProviderManager.Qcht7lAgti);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void IGntb6qhyP([In] object obj0, [In] EventArgs obj1)
    {
      if (ProviderManager.XwWte6RY39)
        Monitor.Enter(ProviderManager.Qcht7lAgti);
      try
      {
        if (ProviderManager.pH0tHXFheO == null)
          return;
        ProviderManager.pH0tHXFheO(new ProviderEventArgs(obj0 as IProvider));
      }
      finally
      {
        if (ProviderManager.XwWte6RY39)
          Monitor.Exit(ProviderManager.Qcht7lAgti);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void lT2tdDDwWW([In] ProviderErrorEventArgs obj0)
    {
      if (ProviderManager.XwWte6RY39)
        Monitor.Enter(ProviderManager.Qcht7lAgti);
      try
      {
        if (Trace.IsLevelEnabled(TraceLevel.Error))
          Trace.WriteLine(obj0.ToString() + Environment.NewLine);
        ProviderManager.cIXt1Sv2ZR.VruWdmvdd(obj0.Error);
        if (ProviderManager.RYJtAso3kD == null)
          return;
        ProviderManager.RYJtAso3kD(obj0);
      }
      finally
      {
        if (ProviderManager.XwWte6RY39)
          Monitor.Exit(ProviderManager.Qcht7lAgti);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void A9ptr7PlS6([In] object obj0, [In] MarketDataRequestRejectEventArgs obj1)
    {
      if (ProviderManager.XwWte6RY39)
        Monitor.Enter(ProviderManager.Qcht7lAgti);
      try
      {
        if (ProviderManager.wWktaqhsHZ == null)
          return;
        ProviderManager.wWktaqhsHZ(obj0, obj1);
      }
      finally
      {
        if (ProviderManager.XwWte6RY39)
          Monitor.Exit(ProviderManager.Qcht7lAgti);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void vxOtKbcx3K([In] object obj0, [In] BarEventArgs obj1)
    {
      if (ProviderManager.XwWte6RY39)
        Monitor.Enter(ProviderManager.Qcht7lAgti);
      try
      {
        if (ProviderManager.CPqtUx1Rin == null)
          return;
        ProviderManager.CPqtUx1Rin(obj0, obj1);
      }
      finally
      {
        if (ProviderManager.XwWte6RY39)
          Monitor.Exit(ProviderManager.Qcht7lAgti);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void x7ptud5DXG([In] object obj0, [In] BarEventArgs obj1)
    {
      if (ProviderManager.XwWte6RY39)
        Monitor.Enter(ProviderManager.Qcht7lAgti);
      try
      {
        if (ProviderManager.OKTtkXx2kt == null)
          return;
        ProviderManager.OKTtkXx2kt(obj0, obj1);
      }
      finally
      {
        if (ProviderManager.XwWte6RY39)
          Monitor.Exit(ProviderManager.Qcht7lAgti);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void rcRtiseEP5([In] object obj0, [In] BarSliceEventArgs obj1)
    {
      if (ProviderManager.XwWte6RY39)
        Monitor.Enter(ProviderManager.Qcht7lAgti);
      try
      {
        if (ProviderManager.vcut0PDfWK == null)
          return;
        ProviderManager.vcut0PDfWK(obj0, obj1);
      }
      finally
      {
        if (ProviderManager.XwWte6RY39)
          Monitor.Exit(ProviderManager.Qcht7lAgti);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void Xayt8ev6DF([In] object obj0, [In] TradeEventArgs obj1)
    {
      if (ProviderManager.XwWte6RY39)
        Monitor.Enter(ProviderManager.Qcht7lAgti);
      try
      {
        if (ProviderManager.iDpt4vrp08 == null)
          return;
        ProviderManager.iDpt4vrp08(obj0, obj1);
      }
      finally
      {
        if (ProviderManager.XwWte6RY39)
          Monitor.Exit(ProviderManager.Qcht7lAgti);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void sNEtZMdMtX([In] object obj0, [In] QuoteEventArgs obj1)
    {
      if (ProviderManager.XwWte6RY39)
        Monitor.Enter(ProviderManager.Qcht7lAgti);
      try
      {
        if (ProviderManager.xPktFOhWM3 == null)
          return;
        ProviderManager.xPktFOhWM3(obj0, obj1);
      }
      finally
      {
        if (ProviderManager.XwWte6RY39)
          Monitor.Exit(ProviderManager.Qcht7lAgti);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void DS3tXKrAL8([In] object obj0, [In] MarketDepthEventArgs obj1)
    {
      if (ProviderManager.XwWte6RY39)
        Monitor.Enter(ProviderManager.Qcht7lAgti);
      try
      {
        if (ProviderManager.kPtthrnQkI == null)
          return;
        ProviderManager.kPtthrnQkI(obj0, obj1);
      }
      finally
      {
        if (ProviderManager.XwWte6RY39)
          Monitor.Exit(ProviderManager.Qcht7lAgti);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void eSctT3jM8B([In] object obj0, [In] FundamentalEventArgs obj1)
    {
      if (ProviderManager.XwWte6RY39)
        Monitor.Enter(ProviderManager.Qcht7lAgti);
      try
      {
        if (ProviderManager.JKltVo0glF == null)
          return;
        ProviderManager.JKltVo0glF(obj0, obj1);
      }
      finally
      {
        if (ProviderManager.XwWte6RY39)
          Monitor.Exit(ProviderManager.Qcht7lAgti);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void Ev1tGOgRhf([In] object obj0, [In] CorporateActionEventArgs obj1)
    {
      if (ProviderManager.XwWte6RY39)
        Monitor.Enter(ProviderManager.Qcht7lAgti);
      try
      {
        if (ProviderManager.v2ntQp7o2t == null)
          return;
        ProviderManager.v2ntQp7o2t(obj0, obj1);
      }
      finally
      {
        if (ProviderManager.XwWte6RY39)
          Monitor.Exit(ProviderManager.Qcht7lAgti);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void w6qtfBxe26([In] object obj0, [In] ExecutionReportEventArgs obj1)
    {
      if (ProviderManager.XwWte6RY39)
        Monitor.Enter(ProviderManager.Qcht7lAgti);
      try
      {
        if (ProviderManager.ziitJV2bE4 == null)
          return;
        ProviderManager.ziitJV2bE4(obj0, obj1);
      }
      finally
      {
        if (ProviderManager.XwWte6RY39)
          Monitor.Exit(ProviderManager.Qcht7lAgti);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SLKt3RqewM([In] object obj0, [In] OrderCancelRejectEventArgs obj1)
    {
      if (ProviderManager.XwWte6RY39)
        Monitor.Enter(ProviderManager.Qcht7lAgti);
      try
      {
        if (ProviderManager.yXltqUFnJY == null)
          return;
        ProviderManager.yXltqUFnJY(obj0, obj1);
      }
      finally
      {
        if (ProviderManager.XwWte6RY39)
          Monitor.Exit(ProviderManager.Qcht7lAgti);
      }
    }
  }
}
