// Type: SmartQuant.Trading.Strategy
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using a1JAgr58v9OgtrX9D5;
using Fqtc0KHy5NLRPTwTIw;
using knqFOoGoM9moIgF7SQ;
using l3Z5ZAp2dkqyZZDck9P;
using SlN8f6pWyHStvuMgWbM;
using SmartQuant;
using SmartQuant.Data;
using SmartQuant.Execution;
using SmartQuant.FIX;
using SmartQuant.FIXData;
using SmartQuant.Instruments;
using SmartQuant.Providers;
using SmartQuant.Trading.Design;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using VLk0XAhdb78hoZ5ihL;
using xj9GXbzGIDqCpWOvNE;
using xyiX9NOFSDytBhTyS5;
using z1XvlSppemmSS8yfVsd;

namespace SmartQuant.Trading
{
  public class Strategy : StrategyBase
  {
    private CrossEntry CX2pXhZQGN;
    private CrossExit hP7pPwnfQ7;
    private CrossEntry HeHpDewVKD;
    private CrossExit A6MpF2380O;
    private Entry iTOpL59SMK;
    private Exit KpSp3MfDuQ;
    private MoneyManager vicpsU5DyG;
    private RiskManager m8Hp4wyAlm;
    private ExposureManager ayRpJCTRPY;
    private Dictionary<Instrument, Entry> jmsp03fjcW;
    private Dictionary<Instrument, Exit> oqypvRmD9v;
    private Dictionary<Instrument, MoneyManager> dJypEOsaUc;
    private Dictionary<Instrument, RiskManager> OirpVoEMJx;

    [Browsable(false)]
    public MetaStrategy MetaStrategy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.MetaStrategyBase as MetaStrategy;
      }
    }

    [Editor(typeof (Tk9X5M9uphPQxcsRCM), typeof (UITypeEditor))]
    [TypeConverter(typeof (ComponentTypeConverter))]
    [Category("Components")]
    public CrossEntry CrossEntry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.metaStrategyBase == null || !this.metaStrategyBase.ahdWYv7joQ)
          return this.CX2pXhZQGN;
        else
          return this.HeHpDewVKD;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(3566));
        if (this.CX2pXhZQGN != null)
        {
          this.CX2pXhZQGN.Disconnect();
          this.CX2pXhZQGN.StrategyBase = (StrategyBase) null;
        }
        this.CX2pXhZQGN = value;
        if (this.CX2pXhZQGN != null)
        {
          this.CX2pXhZQGN.StrategyBase = (StrategyBase) this;
          this.CX2pXhZQGN.Connect();
        }
        this.EmitComponentChanged(ComponentType.CrossEntry);
      }
    }

    [Editor(typeof (jsfU1gQFmKSovu57Rq), typeof (UITypeEditor))]
    [TypeConverter(typeof (ComponentTypeConverter))]
    [Category("Components")]
    public CrossExit CrossExit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.metaStrategyBase == null || !this.metaStrategyBase.ahdWYv7joQ)
          return this.hP7pPwnfQ7;
        else
          return this.A6MpF2380O;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(3638));
        if (this.hP7pPwnfQ7 != null)
        {
          this.hP7pPwnfQ7.Disconnect();
          this.hP7pPwnfQ7.StrategyBase = (StrategyBase) null;
        }
        this.hP7pPwnfQ7 = value;
        if (this.hP7pPwnfQ7 != null)
        {
          this.hP7pPwnfQ7.StrategyBase = (StrategyBase) this;
          this.hP7pPwnfQ7.Connect();
        }
        this.EmitComponentChanged(ComponentType.CrossExit);
      }
    }

    [TypeConverter(typeof (ComponentTypeConverter))]
    [Category("Components")]
    [Editor(typeof (KZiZE1UfPtfe4jp4N9), typeof (UITypeEditor))]
    public Entry Entry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.iTOpL59SMK;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(3710));
        if (this.iTOpL59SMK != null)
        {
          this.iTOpL59SMK.Disconnect();
          this.iTOpL59SMK.StrategyBase = (StrategyBase) null;
        }
        this.iTOpL59SMK = value;
        if (this.iTOpL59SMK != null)
        {
          this.iTOpL59SMK.StrategyBase = (StrategyBase) this;
          this.iTOpL59SMK.Connect();
        }
        this.EmitComponentChanged(ComponentType.Entry);
      }
    }

    [Editor(typeof (EDRqyRpkyAnMCaEZHgV), typeof (UITypeEditor))]
    [TypeConverter(typeof (ComponentTypeConverter))]
    [Category("Components")]
    public Exit Exit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.KpSp3MfDuQ;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(3782));
        if (this.KpSp3MfDuQ != null)
        {
          this.KpSp3MfDuQ.Disconnect();
          this.KpSp3MfDuQ.StrategyBase = (StrategyBase) null;
        }
        this.KpSp3MfDuQ = value;
        if (this.KpSp3MfDuQ != null)
        {
          this.KpSp3MfDuQ.StrategyBase = (StrategyBase) this;
          this.KpSp3MfDuQ.Connect();
        }
        this.EmitComponentChanged(ComponentType.Exit);
      }
    }

    [TypeConverter(typeof (ComponentTypeConverter))]
    [Category("Components")]
    [Editor(typeof (PrSe967mJKFdDx0JCT), typeof (UITypeEditor))]
    public MoneyManager MoneyManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.vicpsU5DyG;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(3854));
        if (this.vicpsU5DyG != null)
        {
          this.vicpsU5DyG.Disconnect();
          this.vicpsU5DyG.StrategyBase = (StrategyBase) null;
        }
        this.vicpsU5DyG = value;
        if (this.vicpsU5DyG != null)
        {
          this.vicpsU5DyG.StrategyBase = (StrategyBase) this;
          this.vicpsU5DyG.Connect();
        }
        this.EmitComponentChanged(ComponentType.MoneyManager);
      }
    }

    [Category("Components")]
    [TypeConverter(typeof (ComponentTypeConverter))]
    [Editor(typeof (HsWgP7ySF3VurrUYpc), typeof (UITypeEditor))]
    public RiskManager RiskManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.m8Hp4wyAlm;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(3926));
        if (this.m8Hp4wyAlm != null)
        {
          this.m8Hp4wyAlm.Disconnect();
          this.m8Hp4wyAlm.StrategyBase = (StrategyBase) null;
        }
        this.m8Hp4wyAlm = value;
        if (this.m8Hp4wyAlm != null)
        {
          this.m8Hp4wyAlm.StrategyBase = (StrategyBase) this;
          this.m8Hp4wyAlm.Connect();
        }
        this.EmitComponentChanged(ComponentType.RiskManager);
      }
    }

    [Category("Components")]
    [Editor(typeof (mb1BObNwTRA0TfMY5S), typeof (UITypeEditor))]
    [TypeConverter(typeof (ComponentTypeConverter))]
    public ExposureManager ExposureManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ayRpJCTRPY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(3998));
        if (this.ayRpJCTRPY != null)
        {
          this.ayRpJCTRPY.Disconnect();
          this.ayRpJCTRPY.StrategyBase = (StrategyBase) null;
        }
        this.ayRpJCTRPY = value;
        if (this.ayRpJCTRPY != null)
        {
          this.ayRpJCTRPY.StrategyBase = (StrategyBase) this;
          this.ayRpJCTRPY.Connect();
        }
        this.EmitComponentChanged(ComponentType.ExposureManager);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Strategy(string name, string description)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector(name, description);
      this.CrossExit = StrategyComponentManager.GetComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(3006), (object) this) as CrossExit;
      this.CrossEntry = StrategyComponentManager.GetComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(3086), (object) this) as CrossEntry;
      this.Entry = StrategyComponentManager.GetComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(3166), (object) this) as Entry;
      this.Exit = StrategyComponentManager.GetComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(3246), (object) this) as Exit;
      this.MoneyManager = StrategyComponentManager.GetComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(3326), (object) this) as MoneyManager;
      this.RiskManager = StrategyComponentManager.GetComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(3406), (object) this) as RiskManager;
      this.ExposureManager = StrategyComponentManager.GetComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(3486), (object) this) as ExposureManager;
      this.jmsp03fjcW = new Dictionary<Instrument, Entry>();
      this.oqypvRmD9v = new Dictionary<Instrument, Exit>();
      this.dJypEOsaUc = new Dictionary<Instrument, MoneyManager>();
      this.OirpVoEMJx = new Dictionary<Instrument, RiskManager>();
      this.componentTypeList.Add(ComponentType.Entry);
      this.componentTypeList.Add(ComponentType.Exit);
      this.componentTypeList.Add(ComponentType.CrossEntry);
      this.componentTypeList.Add(ComponentType.CrossExit);
      this.componentTypeList.Add(ComponentType.RiskManager);
      this.componentTypeList.Add(ComponentType.MoneyManager);
      this.componentTypeList.Add(ComponentType.ExposureManager);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Strategy(string name)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      this.\u002Ector(name, "");
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Dictionary<Instrument, Entry> IagpTj6FwB()
    {
      return this.jmsp03fjcW;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Dictionary<Instrument, Exit> AGBpIpCa2Y()
    {
      return this.oqypvRmD9v;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Dictionary<Instrument, MoneyManager> VmmphY7grH()
    {
      return this.dJypEOsaUc;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Dictionary<Instrument, RiskManager> kEApCnqU3X()
    {
      return this.OirpVoEMJx;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInit()
    {
      this.jmsp03fjcW.Clear();
      this.oqypvRmD9v.Clear();
      this.dJypEOsaUc.Clear();
      this.OirpVoEMJx.Clear();
      this.HeHpDewVKD = Activator.CreateInstance(this.CX2pXhZQGN.GetType()) as CrossEntry;
      this.A6MpF2380O = Activator.CreateInstance(this.hP7pPwnfQ7.GetType()) as CrossExit;
      this.HeHpDewVKD.StrategyBase = (StrategyBase) this;
      this.A6MpF2380O.StrategyBase = (StrategyBase) this;
      this.SetProxyProperties((object) this.HeHpDewVKD, (object) this.CX2pXhZQGN);
      this.SetProxyProperties((object) this.A6MpF2380O, (object) this.hP7pPwnfQ7);
      this.HeHpDewVKD.Init();
      this.A6MpF2380O.Init();
      this.ayRpJCTRPY.Init();
      foreach (Instrument instrument in (FIXGroupList) this.marketManager.Instruments)
      {
        this.activeInstruments.Add(instrument);
        Entry entry = Activator.CreateInstance(this.iTOpL59SMK.GetType()) as Entry;
        Exit exit = Activator.CreateInstance(this.KpSp3MfDuQ.GetType()) as Exit;
        MoneyManager moneyManager = Activator.CreateInstance(this.vicpsU5DyG.GetType()) as MoneyManager;
        RiskManager riskManager = Activator.CreateInstance(this.m8Hp4wyAlm.GetType()) as RiskManager;
        entry.StrategyBase = (StrategyBase) this;
        exit.StrategyBase = (StrategyBase) this;
        moneyManager.StrategyBase = (StrategyBase) this;
        riskManager.StrategyBase = (StrategyBase) this;
        entry.Instrument = instrument;
        exit.Instrument = instrument;
        moneyManager.Instrument = instrument;
        riskManager.Instrument = instrument;
        this.SetProxyProperties((object) entry, (object) this.iTOpL59SMK);
        this.SetProxyProperties((object) exit, (object) this.KpSp3MfDuQ);
        this.SetProxyProperties((object) moneyManager, (object) this.vicpsU5DyG);
        this.SetProxyProperties((object) riskManager, (object) this.m8Hp4wyAlm);
        entry.Init();
        exit.Init();
        moneyManager.Init();
        riskManager.Init();
        this.jmsp03fjcW.Add(instrument, entry);
        this.oqypvRmD9v.Add(instrument, exit);
        this.dJypEOsaUc.Add(instrument, moneyManager);
        this.OirpVoEMJx.Add(instrument, riskManager);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnStrategyStop()
    {
      this.HeHpDewVKD.OnStrategyStop();
      this.A6MpF2380O.OnStrategyStop();
      foreach (ComponentBase componentBase in this.jmsp03fjcW.Values)
        componentBase.OnStrategyStop();
      foreach (ComponentBase componentBase in this.oqypvRmD9v.Values)
        componentBase.OnStrategyStop();
      foreach (ComponentBase componentBase in this.dJypEOsaUc.Values)
        componentBase.OnStrategyStop();
      foreach (ComponentBase componentBase in this.OirpVoEMJx.Values)
        componentBase.OnStrategyStop();
      this.ayRpJCTRPY.OnStrategyStop();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal SingleOrder BgvpSPpUAD([In] Signal obj0)
    {
      obj0.Strategy = this;
      double positionSize = this.dJypEOsaUc[obj0.Instrument].GetPositionSize(obj0);
      if (positionSize > 0.0)
      {
        obj0.Qty = positionSize;
        if (!this.OirpVoEMJx[obj0.Instrument].Validate(obj0))
        {
          obj0.Status = SignalStatus.Rejected;
          obj0.Rejecter = ComponentType.RiskManager;
        }
        if (!this.ayRpJCTRPY.Validate(obj0))
        {
          obj0.Status = SignalStatus.Rejected;
          obj0.Rejecter = ComponentType.ExposureManager;
        }
      }
      else
      {
        obj0.Status = SignalStatus.Rejected;
        obj0.Rejecter = ComponentType.MoneyManager;
      }
      return this.MetaStrategy.PFARUMnUwZ(obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnNewTrade(Instrument instrument, Trade trade)
    {
      foreach (Stop stop in new ArrayList((ICollection) this.activeStops[instrument]))
      {
        if (stop.Connected)
          stop.yu56453Z5Z(trade);
      }
      this.A6MpF2380O.OnTrade(instrument, trade);
      this.HeHpDewVKD.OnTrade(instrument, trade);
      this.marketManager.OnTrade(instrument, trade);
      this.oqypvRmD9v[instrument].OnTrade(trade);
      this.jmsp03fjcW[instrument].OnTrade(trade);
      this.dJypEOsaUc[instrument].OnTrade(trade);
      this.OirpVoEMJx[instrument].OnTrade(trade);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnNewQuote(Instrument instrument, Quote quote)
    {
      foreach (Stop stop in new ArrayList((ICollection) this.activeStops[instrument]))
      {
        if (stop.Connected)
          stop.ddk6JqyZZD(quote);
      }
      this.A6MpF2380O.OnQuote(instrument, quote);
      this.HeHpDewVKD.OnQuote(instrument, quote);
      this.marketManager.OnQuote(instrument, quote);
      this.oqypvRmD9v[instrument].OnQuote(quote);
      this.jmsp03fjcW[instrument].OnQuote(quote);
      this.dJypEOsaUc[instrument].OnQuote(quote);
      this.OirpVoEMJx[instrument].OnQuote(quote);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnNewMarketDepth(Instrument instrument, MarketDepth marketDepth)
    {
      this.A6MpF2380O.OnMarketDepth(instrument, marketDepth);
      this.HeHpDewVKD.OnMarketDepth(instrument, marketDepth);
      this.marketManager.OnMarketDepth(instrument, marketDepth);
      this.oqypvRmD9v[instrument].OnMarketDepth(marketDepth);
      this.jmsp03fjcW[instrument].OnMarketDepth(marketDepth);
      this.dJypEOsaUc[instrument].OnMarketDepth(marketDepth);
      this.OirpVoEMJx[instrument].OnMarketDepth(marketDepth);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnNewFundamental(Instrument instrument, Fundamental fundamental)
    {
      this.A6MpF2380O.OnFundamental(instrument, fundamental);
      this.HeHpDewVKD.OnFundamental(instrument, fundamental);
      this.oqypvRmD9v[instrument].OnFundamental(fundamental);
      this.jmsp03fjcW[instrument].OnFundamental(fundamental);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnNewCorporateAction(Instrument instrument, CorporateAction corporateAction)
    {
      this.A6MpF2380O.OnCorporateAction(instrument, corporateAction);
      this.HeHpDewVKD.OnCorporateAction(instrument, corporateAction);
      this.marketManager.OnCorporateAction(instrument, corporateAction);
      this.ayRpJCTRPY.OnCorporateAction(instrument, corporateAction);
      this.oqypvRmD9v[instrument].OnCorporateAction(corporateAction);
      this.jmsp03fjcW[instrument].OnCorporateAction(corporateAction);
      this.dJypEOsaUc[instrument].OnCorporateAction(corporateAction);
      this.OirpVoEMJx[instrument].OnCorporateAction(corporateAction);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnNewBarOpen(Instrument instrument, Bar bar)
    {
      foreach (Stop stop in new ArrayList((ICollection) this.activeStops[instrument]))
      {
        if (stop.Connected)
          stop.M2g6st8BRD(bar);
      }
      this.A6MpF2380O.OnBarOpen(instrument, bar);
      this.HeHpDewVKD.OnBarOpen(instrument, bar);
      this.marketManager.OnBarOpen(instrument, bar);
      this.oqypvRmD9v[instrument].OnBarOpen(bar);
      this.jmsp03fjcW[instrument].OnBarOpen(bar);
      this.dJypEOsaUc[instrument].OnBarOpen(bar);
      this.OirpVoEMJx[instrument].OnBarOpen(bar);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnNewBar(Instrument instrument, Bar bar)
    {
      foreach (Stop stop in new ArrayList((ICollection) this.activeStops[instrument]))
      {
        if (stop.Connected)
          stop.t2b63VoTkG(bar);
      }
      this.A6MpF2380O.OnBar(instrument, bar);
      this.HeHpDewVKD.OnBar(instrument, bar);
      this.marketManager.OnBar(instrument, bar);
      this.oqypvRmD9v[instrument].OnBar(bar);
      this.jmsp03fjcW[instrument].OnBar(bar);
      this.dJypEOsaUc[instrument].OnBar(bar);
      this.OirpVoEMJx[instrument].OnBar(bar);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnNewBarSlice(long barSize)
    {
      this.A6MpF2380O.OnBarSlice(barSize);
      this.HeHpDewVKD.OnBarSlice(barSize);
      this.marketManager.OnBarSlice(barSize);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnProviderConnected(IProvider provider)
    {
      this.A6MpF2380O.OnProviderConnected(provider);
      this.HeHpDewVKD.OnProviderConnected(provider);
      this.marketManager.OnProviderConnected(provider);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnProviderDisconnected(IProvider provider)
    {
      this.A6MpF2380O.OnProviderDisconnected(provider);
      this.HeHpDewVKD.OnProviderDisconnected(provider);
      this.marketManager.OnProviderDisconnected(provider);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnProviderError(IProvider provider, int id, int code, string message)
    {
      this.A6MpF2380O.OnProviderError(provider, id, code, message);
      this.HeHpDewVKD.OnProviderError(provider, id, code, message);
      this.marketManager.OnProviderError(provider, id, code, message);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnPositionOpened(Position position)
    {
      this.A6MpF2380O.OnPositionOpened(position);
      this.HeHpDewVKD.OnPositionOpened(position);
      this.ayRpJCTRPY.OnPositionOpened(position);
      Instrument instrument = position.Instrument;
      this.oqypvRmD9v[instrument].OnPositionOpened();
      this.jmsp03fjcW[instrument].OnPositionOpened();
      this.dJypEOsaUc[instrument].OnPositionOpened();
      this.OirpVoEMJx[instrument].OnPositionOpened();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnPositionChanged(Position position)
    {
      this.A6MpF2380O.OnPositionChanged(position);
      this.HeHpDewVKD.OnPositionChanged(position);
      this.ayRpJCTRPY.OnPositionChanged(position);
      Instrument instrument = position.Instrument;
      this.oqypvRmD9v[instrument].OnPositionChanged();
      this.jmsp03fjcW[instrument].OnPositionChanged();
      this.dJypEOsaUc[instrument].OnPositionChanged();
      this.OirpVoEMJx[instrument].OnPositionChanged();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnPositionClosed(Position position)
    {
      foreach (Stop stop in new ArrayList((ICollection) this.activeStops[position.Instrument]))
      {
        if (stop.Type == StopType.Time && stop.Status == StopStatus.Active || stop.Connected)
          stop.xbx6LKbgmx(position);
      }
      this.A6MpF2380O.OnPositionClosed(position);
      this.HeHpDewVKD.OnPositionClosed(position);
      this.ayRpJCTRPY.OnPositionClosed(position);
      Instrument instrument = position.Instrument;
      this.oqypvRmD9v[instrument].OnPositionClosed();
      this.jmsp03fjcW[instrument].OnPositionClosed();
      this.dJypEOsaUc[instrument].OnPositionClosed();
      this.OirpVoEMJx[instrument].OnPositionClosed();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnPortfolioValueChanged(Position position)
    {
      this.MetaStrategy.MetaRiskManager.OnStrategyPortfolioValueChanged(this);
      if (!this.isActive)
        return;
      this.A6MpF2380O.OnPortfolioValueChanged(position);
      this.HeHpDewVKD.OnPortfolioValueChanged(position);
      this.ayRpJCTRPY.OnPortfolioValueChanged(position);
      Instrument instrument = position.Instrument;
      this.oqypvRmD9v[instrument].OnPositionValueChanged();
      this.jmsp03fjcW[instrument].OnPositionValueChanged();
      this.dJypEOsaUc[instrument].OnPositionValueChanged();
      this.OirpVoEMJx[instrument].OnPositionValueChanged();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void ClosePosition(Instrument instrument, double price, ComponentType component, string text)
    {
      Position position = this.portfolio.Positions[instrument];
      if (position == null)
        return;
      switch (position.Side)
      {
        case PositionSide.Long:
          this.BgvpSPpUAD(new Signal(Clock.Now, component, SignalType.Market, SignalSide.Sell, position.Qty, price, instrument, text));
          break;
        case PositionSide.Short:
          this.BgvpSPpUAD(new Signal(Clock.Now, component, SignalType.Market, SignalSide.BuyCover, position.Qty, price, instrument, text));
          break;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnNewOrder(SingleOrder order)
    {
      Instrument instrument = order.Instrument;
      this.HeHpDewVKD.OnNewOrder(order);
      this.A6MpF2380O.OnNewOrder(order);
      this.jmsp03fjcW[instrument].OnNewOrder(order);
      this.oqypvRmD9v[instrument].OnNewOrder(order);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnExecutionReport(SingleOrder order, ExecutionReport report)
    {
      Instrument instrument = order.Instrument;
      this.HeHpDewVKD.OnExecutionReport(order, report);
      this.A6MpF2380O.OnExecutionReport(order, report);
      this.jmsp03fjcW[instrument].OnExecutionReport(order, report);
      this.oqypvRmD9v[instrument].OnExecutionReport(order, report);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnOrderPartiallyFilled(SingleOrder order)
    {
      Instrument instrument = order.Instrument;
      this.HeHpDewVKD.OnOrderPartiallyFilled(order);
      this.A6MpF2380O.OnOrderPartiallyFilled(order);
      this.jmsp03fjcW[instrument].OnOrderPartiallyFilled(order);
      this.oqypvRmD9v[instrument].OnOrderPartiallyFilled(order);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnOrderStatusChanged(SingleOrder order)
    {
      Instrument instrument = order.Instrument;
      this.HeHpDewVKD.OnOrderStatusChanged(order);
      this.A6MpF2380O.OnOrderStatusChanged(order);
      this.jmsp03fjcW[instrument].OnOrderStatusChanged(order);
      this.oqypvRmD9v[instrument].OnOrderStatusChanged(order);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnOrderFilled(SingleOrder order)
    {
      Instrument instrument = order.Instrument;
      this.HeHpDewVKD.OnOrderFilled(order);
      this.A6MpF2380O.OnOrderFilled(order);
      this.jmsp03fjcW[instrument].OnOrderFilled(order);
      this.oqypvRmD9v[instrument].OnOrderFilled(order);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnOrderCancelled(SingleOrder order)
    {
      Instrument instrument = order.Instrument;
      this.HeHpDewVKD.OnOrderCancelled(order);
      this.A6MpF2380O.OnOrderCancelled(order);
      this.jmsp03fjcW[instrument].OnOrderCancelled(order);
      this.oqypvRmD9v[instrument].OnOrderCancelled(order);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnOrderRejected(SingleOrder order)
    {
      Instrument instrument = order.Instrument;
      this.HeHpDewVKD.OnOrderRejected(order);
      this.A6MpF2380O.OnOrderRejected(order);
      this.jmsp03fjcW[instrument].OnOrderRejected(order);
      this.oqypvRmD9v[instrument].OnOrderRejected(order);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnOrderDone(SingleOrder order)
    {
      Instrument instrument = order.Instrument;
      this.HeHpDewVKD.OnOrderDone(order);
      this.A6MpF2380O.OnOrderDone(order);
      this.jmsp03fjcW[instrument].OnOrderDone(order);
      this.oqypvRmD9v[instrument].OnOrderDone(order);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComponentBase GetComponent(ComponentType type)
    {
      switch (type)
      {
        case ComponentType.CrossEntry:
          return (IComponentBase) this.CrossEntry;
        case ComponentType.CrossExit:
          return (IComponentBase) this.CrossExit;
        case ComponentType.MarketManager:
          return (IComponentBase) this.MarketManager;
        case ComponentType.ReportManager:
          return (IComponentBase) this.ReportManager;
        case ComponentType.MoneyManager:
          return (IComponentBase) this.MoneyManager;
        case ComponentType.RiskManager:
          return (IComponentBase) this.RiskManager;
        case ComponentType.Entry:
          return (IComponentBase) this.Entry;
        case ComponentType.Exit:
          return (IComponentBase) this.Exit;
        case ComponentType.ExposureManager:
          return (IComponentBase) this.ExposureManager;
        default:
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(4070));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetComponent(ComponentType type, IComponentBase component)
    {
      switch (type)
      {
        case ComponentType.CrossEntry:
          this.CrossEntry = component as CrossEntry;
          break;
        case ComponentType.CrossExit:
          this.CrossExit = component as CrossExit;
          break;
        case ComponentType.MarketManager:
          this.MarketManager = component as MarketManager;
          break;
        case ComponentType.ReportManager:
          this.ReportManager = component as ReportManager;
          break;
        case ComponentType.MoneyManager:
          this.MoneyManager = component as MoneyManager;
          break;
        case ComponentType.RiskManager:
          this.RiskManager = component as RiskManager;
          break;
        case ComponentType.Entry:
          this.Entry = component as Entry;
          break;
        case ComponentType.Exit:
          this.Exit = component as Exit;
          break;
        case ComponentType.ExposureManager:
          this.ExposureManager = component as ExposureManager;
          break;
        default:
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(4138));
      }
    }
  }
}
