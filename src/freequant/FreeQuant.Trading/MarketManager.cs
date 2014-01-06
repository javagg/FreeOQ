// Type: SmartQuant.Trading.MarketManager
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SlN8f6pWyHStvuMgWbM;
using SmartQuant.Instruments;
using SmartQuant.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
{
  [StrategyComponent("{849E4CFE-C19E-4d1e-899D-0BB26DB12AAD}", ComponentType.MarketManager, Description = "", Name = "Default_MarketManager")]
  public class MarketManager : StrategyBaseMultiComponent
  {
    public const string GUID = "{849E4CFE-C19E-4d1e-899D-0BB26DB12AAD}";
    private Dictionary<Instrument, IMarketDataProvider> nxTAjlViDK;
    private Dictionary<Instrument, IExecutionProvider> utDAWNS3ic;
    private InstrumentList cYRAR9UWJy;
    protected IMarketDataProvider strategyMarketDataProvider;
    protected IExecutionProvider strategyExecutionProvider;

    [Browsable(false)]
    public InstrumentList Instruments
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.cYRAR9UWJy;
      }
    }

    [Browsable(false)]
    internal IMarketDataProvider OM26eKMfqS
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.strategyMarketDataProvider;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.strategyMarketDataProvider = value;
      }
    }

    [Browsable(false)]
    internal IExecutionProvider TOY6zSGlVT
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.strategyExecutionProvider;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.strategyExecutionProvider = value;
      }
    }

    [Browsable(false)]
    internal Dictionary<Instrument, IMarketDataProvider> jcIApP7GcT
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nxTAjlViDK;
      }
    }

    [Browsable(false)]
    internal Dictionary<Instrument, IExecutionProvider> UyiAAd6ITD
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.utDAWNS3ic;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketManager()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.nxTAjlViDK = new Dictionary<Instrument, IMarketDataProvider>();
      this.utDAWNS3ic = new Dictionary<Instrument, IExecutionProvider>();
      this.cYRAR9UWJy = new InstrumentList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddInstrument(Instrument instrument, IMarketDataProvider marketDataProvider, IExecutionProvider executionProvider)
    {
      if (!this.cYRAR9UWJy.Contains(instrument))
        this.cYRAR9UWJy.Add(instrument);
      this.nxTAjlViDK[instrument] = marketDataProvider == null ? this.strategyMarketDataProvider : marketDataProvider;
      if (executionProvider != null)
        this.utDAWNS3ic[instrument] = executionProvider;
      else
        this.utDAWNS3ic[instrument] = this.strategyExecutionProvider;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddInstrument(Instrument instrument, string marketDataProviderName, string executionProviderName)
    {
      IMarketDataProvider marketDataProvider = ProviderManager.MarketDataProviders[marketDataProviderName];
      IExecutionProvider executionProvider = ProviderManager.ExecutionProviders[executionProviderName];
      if (marketDataProvider == null && marketDataProviderName != "")
        throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(9992) + instrument.Symbol + USaG3GpjZagj1iVdv4u.Y4misFk9D9(10066));
      if (executionProvider == null && executionProviderName != "")
        throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(10100) + instrument.Symbol + USaG3GpjZagj1iVdv4u.Y4misFk9D9(10170));
      this.AddInstrument(instrument, marketDataProvider, executionProvider);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddInstrument(string symbol, string marketDataProviderName, string executionProviderName)
    {
      Instrument instrument = InstrumentManager.Instruments[symbol];
      if (instrument == null)
        return;
      this.AddInstrument(instrument, marketDataProviderName, executionProviderName);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddInstrument(Instrument instrument)
    {
      this.AddInstrument(instrument, this.strategyMarketDataProvider, this.strategyExecutionProvider);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddInstrument(string symbol)
    {
      Instrument instrument = InstrumentManager.Instruments[symbol];
      if (instrument == null)
        return;
      this.AddInstrument(instrument);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveInstrument(Instrument instrument)
    {
      this.cYRAR9UWJy.Remove(instrument);
      this.nxTAjlViDK.Remove(instrument);
      this.utDAWNS3ic.Remove(instrument);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveInstrument(string symbol)
    {
      Instrument instrument = InstrumentManager.Instruments[symbol];
      if (instrument == null)
        return;
      this.RemoveInstrument(instrument);
    }
  }
}
