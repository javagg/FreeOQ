using aX1YwCE8tvUgZCyfib;
using QuickFix;
using QuickFix42;
using FreeQuant.FIX;
using System;
using System.Runtime.CompilerServices;
using System.Threading;
using zWmpDbtlldCIky2Q1f;

namespace FreeQuant.FIXApplication
{
  public class QuickFIX42Application : QuickFix42.MessageCracker, IFIXApplication, Application
  {
    protected SessionID fSessionID;
    protected bool fIsRunning;

    public event FIXLogonEventHandler Logon;

    public event FIXLogoutEventHandler Logout;

    public event FIXMarketDataRequestEventHandler MarketDataRequest;

    public event FIXMarketDataSnapshotEventHandler MarketDataSnapshot;

    public event FIXMarketDataIncrementalRefreshEventHandler MarketDataIncrementalRefresh;

    public event FIXMarketDataRequestRejectEventHandler MarketDataRequestReject;

    public event FIXNewOrderSingleEventHandler NewOrderSingle;

    public event ExecutionReportEventHandler ExecutionReport;

    public event OrderCancelRejectEventHandler OrderCancelReject;

    public event FIXSecurityDefinitionRequestEventHandler SecurityDefinitionRequest;

    public event FIXSecurityDefinitionEventHandler SecurityDefinition;

    public QuickFIX42Application()
    {
      Ni0n2nNTxpPQwXYoJS.cvl3IaMzFxY5E();
      this.fIsRunning = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    public virtual void Connect()
    {
      Session session = Session.lookupSession(this.fSessionID);
      if (session == null || session.isLoggedOn())
        return;
      session.logon();
    }

    public virtual void Disconnect()
    {
      Session session = Session.lookupSession(this.fSessionID);
      if (session == null || !session.isLoggedOn())
        return;
      session.logout();
    }

    public virtual void onCreate(SessionID sessionID)
    {
      Console.WriteLine(BeAEwTZGlZaeOmY5cm.J00weU3cM6(774) + (object) sessionID + BeAEwTZGlZaeOmY5cm.J00weU3cM6(796));
      this.fSessionID = sessionID;
    }

    public virtual void onLogon(SessionID sessionID)
    {
      Console.WriteLine(BeAEwTZGlZaeOmY5cm.J00weU3cM6(802) + (object) sessionID + BeAEwTZGlZaeOmY5cm.J00weU3cM6(822));
      if (this.lCISky2Q1 == null)
        return;
      this.lCISky2Q1((object) this, new FIXSessionIDEventArgs(sessionID));
    }

    public virtual void onLogout(SessionID sessionID)
    {
      Console.WriteLine(BeAEwTZGlZaeOmY5cm.J00weU3cM6(828) + (object) sessionID + BeAEwTZGlZaeOmY5cm.J00weU3cM6(850));
      if (this.N4PQenDmP == null)
        return;
      this.N4PQenDmP((object) this, new FIXSessionIDEventArgs(sessionID));
    }

    public virtual void toAdmin(QuickFix.Message message, SessionID sessionID)
    {
      Console.WriteLine(BeAEwTZGlZaeOmY5cm.J00weU3cM6(856) + (object) sessionID + BeAEwTZGlZaeOmY5cm.J00weU3cM6(876) + (string) (object) message + BeAEwTZGlZaeOmY5cm.J00weU3cM6(884));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void toApp(QuickFix.Message message, SessionID sessionID)
    {
      Console.WriteLine(BeAEwTZGlZaeOmY5cm.J00weU3cM6(890) + (object) sessionID + BeAEwTZGlZaeOmY5cm.J00weU3cM6(906) + (string) (object) message + BeAEwTZGlZaeOmY5cm.J00weU3cM6(914));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fromAdmin(QuickFix.Message message, SessionID sessionID)
    {
      Console.WriteLine(BeAEwTZGlZaeOmY5cm.J00weU3cM6(920) + (object) sessionID + BeAEwTZGlZaeOmY5cm.J00weU3cM6(944) + (string) (object) message + BeAEwTZGlZaeOmY5cm.J00weU3cM6(952));
      message.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fromApp(QuickFix.Message message, SessionID sessionID)
    {
      Console.WriteLine(BeAEwTZGlZaeOmY5cm.J00weU3cM6(958) + (object) sessionID + BeAEwTZGlZaeOmY5cm.J00weU3cM6(978) + (string) (object) message + BeAEwTZGlZaeOmY5cm.J00weU3cM6(986));
      this.crack(message, sessionID);
      message.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void onRun()
    {
      while (this.fIsRunning)
        Thread.Sleep(1000);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Terminate()
    {
      this.fIsRunning = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetUserDefinedFields(FIXMessage Message, QuickFix42.Message message)
    {
      foreach (FIXField fixField in Message.Fields)
      {
        if (fixField.Tag >= 500)
        {
          switch (fixField.FIXType)
          {
            case FIXType.Bool:
              message.setField(new BooleanField(fixField.Tag, ((FIXBoolField) fixField).Value));
              continue;
            case FIXType.Int:
              message.setField(new IntField(fixField.Tag, ((FIXIntField) fixField).Value));
              continue;
            case FIXType.Double:
              message.setField(new DoubleField(fixField.Tag, ((FIXDoubleField) fixField).Value));
              continue;
            case FIXType.Char:
              message.setField(new CharField(fixField.Tag, ((FIXCharField) fixField).Value));
              continue;
            case FIXType.String:
              message.setField(new StringField(fixField.Tag, ((FIXStringField) fixField).Value));
              continue;
            case FIXType.DateTime:
              message.setField((UtcDateOnlyField) new UtcDateField(fixField.Tag, ((FIXDateTimeField) fixField).Value));
              continue;
            default:
              continue;
          }
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void onMessage(MarketDataSnapshotFullRefresh snapshot, SessionID sessionID)
    {
      FIXMarketDataSnapshot MarketDataSnapshotFullRefresh = new FIXMarketDataSnapshot();
      if (snapshot.isSetContractMultiplier())
        MarketDataSnapshotFullRefresh.ContractMultiplier = snapshot.getContractMultiplier().getValue();
      if (snapshot.isSetCorporateAction())
        MarketDataSnapshotFullRefresh.CorporateAction = snapshot.getCorporateAction().getValue();
      if (snapshot.isSetCouponRate())
        MarketDataSnapshotFullRefresh.CouponRate = snapshot.getCouponRate().getValue();
      if (snapshot.isSetEncodedIssuer())
        MarketDataSnapshotFullRefresh.EncodedIssuer = snapshot.getEncodedIssuer().getValue();
      if (snapshot.isSetEncodedIssuerLen())
        MarketDataSnapshotFullRefresh.EncodedIssuerLen = snapshot.getEncodedIssuerLen().getValue();
      if (snapshot.isSetEncodedSecurityDesc())
        MarketDataSnapshotFullRefresh.EncodedSecurityDesc = snapshot.getEncodedSecurityDesc().getValue();
      if (snapshot.isSetEncodedSecurityDescLen())
        MarketDataSnapshotFullRefresh.EncodedSecurityDescLen = snapshot.getEncodedSecurityDescLen().getValue();
      if (snapshot.isSetFinancialStatus())
        MarketDataSnapshotFullRefresh.FinancialStatus = snapshot.getFinancialStatus().getValue();
      if (snapshot.isSetIssuer())
        MarketDataSnapshotFullRefresh.Issuer = snapshot.getIssuer().getValue();
      if (snapshot.isSetMaturityMonthYear())
        MarketDataSnapshotFullRefresh.MaturityMonthYear = snapshot.getMaturityMonthYear().getValue();
      if (snapshot.isSetMDReqID())
        MarketDataSnapshotFullRefresh.MDReqID = snapshot.getMDReqID().getValue();
      if (snapshot.isSetOptAttribute())
        MarketDataSnapshotFullRefresh.OptAttribute = snapshot.getOptAttribute().getValue();
      if (snapshot.isSetSecurityDesc())
        MarketDataSnapshotFullRefresh.SecurityDesc = snapshot.getSecurityDesc().getValue();
      if (snapshot.isSetSecurityExchange())
        MarketDataSnapshotFullRefresh.SecurityExchange = snapshot.getSecurityExchange().getValue();
      if (snapshot.isSetSecurityID())
        MarketDataSnapshotFullRefresh.SecurityID = snapshot.getSecurityID().getValue();
      if (snapshot.isSetSecurityType())
        MarketDataSnapshotFullRefresh.SecurityType = snapshot.getSecurityType().getValue();
      if (snapshot.isSetStrikePrice())
        MarketDataSnapshotFullRefresh.StrikePrice = snapshot.getStrikePrice().getValue();
      if (snapshot.isSetSymbol())
        MarketDataSnapshotFullRefresh.Symbol = snapshot.getSymbol().getValue();
      if (snapshot.isSetSymbolSfx())
        MarketDataSnapshotFullRefresh.SymbolSfx = snapshot.getSymbolSfx().getValue();
      MarketDataSnapshotFullRefresh.NoMDEntries noMdEntries = new MarketDataSnapshotFullRefresh.NoMDEntries();
      for (uint num = 1U; (long) num <= (long) snapshot.getNoMDEntries().getValue(); ++num)
      {
        snapshot.getGroup(num, (Group) noMdEntries);
        FIXMDEntriesGroup group = new FIXMDEntriesGroup(noMdEntries.get(new MDEntryType()).getValue());
        if (noMdEntries.isSetMDEntryDate())
          group.MDEntryDate = noMdEntries.getMDEntryDate().getValue();
        if (noMdEntries.isSetMDEntryTime())
          group.MDEntryTime = noMdEntries.getMDEntryTime().getValue();
        if (noMdEntries.isSetMDEntryPx())
          group.MDEntryPx = noMdEntries.getMDEntryPx().getValue();
        if (noMdEntries.isSetMDEntrySize())
          group.MDEntrySize = noMdEntries.getMDEntrySize().getValue();
        if (noMdEntries.isSetMDEntryBuyer())
          group.MDEntryBuyer = noMdEntries.getMDEntryBuyer().getValue();
        if (noMdEntries.isSetMDEntrySeller())
          group.MDEntrySeller = noMdEntries.getMDEntrySeller().getValue();
        MarketDataSnapshotFullRefresh.AddGroup(group);
      }
      noMdEntries.Dispose();
      if (this.DHHvj9eQf == null)
        return;
      this.DHHvj9eQf((object) this, new FIXMarketDataSnapshotEventArgs(MarketDataSnapshotFullRefresh));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void onMessage(QuickFix42.MarketDataRequestReject reject, SessionID sessionID)
    {
      FIXMarketDataRequestReject MarketDataRequestReject = new FIXMarketDataRequestReject();
      if (reject.isSetMDReqID())
        MarketDataRequestReject.MDReqID = reject.getMDReqID().getValue();
      if (reject.isSetMDReqRejReason())
        MarketDataRequestReject.MDReqRejReason = reject.getMDReqRejReason().getValue();
      if (reject.isSetText())
        MarketDataRequestReject.Text = reject.getText().getValue();
      if (reject.isSetEncodedTextLen())
        MarketDataRequestReject.EncodedTextLen = reject.getEncodedTextLen().getValue();
      if (reject.isSetEncodedText())
        MarketDataRequestReject.EncodedText = reject.getEncodedText().getValue();
      if (this.tTf2wRuxn == null)
        return;
      this.tTf2wRuxn((object) this, new FIXMarketDataRequestRejectEventArgs(MarketDataRequestReject));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void onMessage(QuickFix42.NewOrderSingle order, SessionID sessionID)
    {
      FIXNewOrderSingle fixNewOrderSingle = new FIXNewOrderSingle();
      if (order.isSetClOrdID())
        fixNewOrderSingle.ClOrdID = order.getClOrdID().getValue();
      if (order.isSetAccount())
        fixNewOrderSingle.Account = order.getAccount().getValue();
      if (order.isSetSettlmntTyp())
        fixNewOrderSingle.SettlType = order.getSettlmntTyp().getValue();
      if (order.isSetHandlInst())
        fixNewOrderSingle.HandlInst = order.getHandlInst().getValue();
      if (order.isSetExecInst())
        fixNewOrderSingle.ExecInst = order.getExecInst().getValue();
      if (order.isSetMinQty())
        fixNewOrderSingle.MinQty = order.getMinQty().getValue();
      if (order.isSetMaxFloor())
        fixNewOrderSingle.MaxFloor = order.getMaxFloor().getValue();
      if (order.isSetExDestination())
        fixNewOrderSingle.ExDestination = order.getExDestination().getValue();
      if (order.isSetProcessCode())
        fixNewOrderSingle.ProcessCode = order.getProcessCode().getValue();
      if (order.isSetSymbol())
        fixNewOrderSingle.Symbol = order.getSymbol().getValue();
      if (order.isSetSymbolSfx())
        fixNewOrderSingle.SymbolSfx = order.getSymbolSfx().getValue();
      if (order.isSetSecurityID())
        fixNewOrderSingle.SecurityID = order.getSecurityID().getValue();
      if (order.isSetIDSource())
        fixNewOrderSingle.SecurityIDSource = order.getIDSource().getValue();
      if (order.isSetSecurityType())
        fixNewOrderSingle.SecurityType = order.getSecurityType().getValue();
      if (order.isSetMaturityMonthYear())
        fixNewOrderSingle.MaturityMonthYear = order.getMaturityMonthYear().getValue();
      if (order.isSetMaturityDay())
        fixNewOrderSingle.MaturityDate = DateTime.Parse(order.getMaturityDay().getValue());
      if (order.isSetStrikePrice())
        fixNewOrderSingle.StrikePrice = order.getStrikePrice().getValue();
      if (order.isSetOptAttribute())
        fixNewOrderSingle.OptAttribute = order.getOptAttribute().getValue();
      if (order.isSetContractMultiplier())
        fixNewOrderSingle.ContractMultiplier = order.getContractMultiplier().getValue();
      if (order.isSetCouponRate())
        fixNewOrderSingle.CouponRate = order.getCouponRate().getValue();
      if (order.isSetSecurityExchange())
        fixNewOrderSingle.SecurityExchange = order.getSecurityExchange().getValue();
      if (order.isSetIssuer())
        fixNewOrderSingle.Issuer = order.getIssuer().getValue();
      if (order.isSetEncodedIssuerLen())
        fixNewOrderSingle.EncodedIssuerLen = order.getEncodedIssuerLen().getValue();
      if (order.isSetEncodedIssuer())
        fixNewOrderSingle.EncodedIssuer = order.getEncodedIssuer().getValue();
      if (order.isSetSecurityDesc())
        fixNewOrderSingle.SecurityDesc = order.getSecurityDesc().getValue();
      if (order.isSetEncodedSecurityDescLen())
        fixNewOrderSingle.EncodedSecurityDescLen = order.getEncodedSecurityDescLen().getValue();
      if (order.isSetEncodedSecurityDesc())
        fixNewOrderSingle.EncodedSecurityDesc = order.getEncodedSecurityDesc().getValue();
      if (order.isSetPrevClosePx())
        fixNewOrderSingle.PrevClosePx = order.getPrevClosePx().getValue();
      if (order.isSetSide())
        fixNewOrderSingle.Side = order.getSide().getValue();
      if (order.isSetTransactTime())
        fixNewOrderSingle.TransactTime = order.getTransactTime().getValue();
      if (order.isSetOrderQty())
        fixNewOrderSingle.OrderQty = order.getOrderQty().getValue();
      if (order.isSetCashOrderQty())
        fixNewOrderSingle.CashOrderQty = order.getCashOrderQty().getValue();
      if (order.isSetOrdType())
        fixNewOrderSingle.OrdType = order.getOrdType().getValue();
      if (order.isSetPrice())
        fixNewOrderSingle.Price = order.getPrice().getValue();
      if (order.isSetStopPx())
        fixNewOrderSingle.StopPx = order.getStopPx().getValue();
      if (order.isSetComplianceID())
        fixNewOrderSingle.ComplianceID = order.getComplianceID().getValue();
      if (order.isSetIOIid())
        fixNewOrderSingle.IOIID = order.getIOIid().getValue();
      if (order.isSetQuoteID())
        fixNewOrderSingle.QuoteID = order.getQuoteID().getValue();
      if (order.isSetTimeInForce())
        fixNewOrderSingle.TimeInForce = order.getTimeInForce().getValue();
      if (order.isSetEffectiveTime())
        fixNewOrderSingle.EffectiveTime = order.getEffectiveTime().getValue();
      if (order.isSetExpireTime())
        fixNewOrderSingle.ExpireTime = order.getExpireTime().getValue();
      if (order.isSetGTBookingInst())
        fixNewOrderSingle.GTBookingInst = order.getGTBookingInst().getValue();
      if (order.isSetCommission())
        fixNewOrderSingle.Commission = order.getCommission().getValue();
      if (order.isSetText())
        fixNewOrderSingle.Text = order.getText().getValue();
      if (order.isSetEncodedTextLen())
        fixNewOrderSingle.EncodedTextLen = order.getEncodedTextLen().getValue();
      if (order.isSetEncodedText())
        fixNewOrderSingle.EncodedText = order.getEncodedText().getValue();
      if (order.isSetOrderQty2())
        fixNewOrderSingle.OrderQty2 = order.getOrderQty2().getValue();
      if (order.isSetCoveredOrUncovered())
        fixNewOrderSingle.CoveredOrUncovered = order.getCoveredOrUncovered().getValue();
      if (order.isSetMaxShow())
        fixNewOrderSingle.MaxShow = order.getMaxShow().getValue();
      if (!order.isSetDiscretionInst())
        return;
      fixNewOrderSingle.DiscretionInst = order.getDiscretionInst().getValue();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void onMessage(QuickFix42.ExecutionReport report, SessionID sessionID)
    {
      SmartQuant.FIX.ExecutionReport report1 = new SmartQuant.FIX.ExecutionReport();
      if (report.isSetOrderID())
        report1.OrderID = report.getOrderID().getValue();
      if (report.isSetSecondaryOrderID())
        report1.SecondaryOrderID = report.getSecondaryOrderID().getValue();
      if (report.isSetClOrdID())
        report1.ClOrdID = report.getClOrdID().getValue();
      if (report.isSetOrigClOrdID())
        report1.OrigClOrdID = report.getOrigClOrdID().getValue();
      if (report.isSetListID())
        report1.ListID = report.getListID().getValue();
      if (report.isSetExecID())
        report1.ExecID = report.getExecID().getValue();
      if (report.isSetExecRefID())
        report1.ExecRefID = report.getExecRefID().getValue();
      if (report.isSetExecType())
        ((FIXExecutionReport) report1).ExecType = report.getExecType().getValue();
      if (report.isSetOrdStatus())
        ((FIXExecutionReport) report1).OrdStatus = report.getOrdStatus().getValue();
      if (report.isSetOrdRejReason())
        report1.OrdRejReason = report.getOrdRejReason().getValue();
      if (report.isSetExecRestatementReason())
        report1.ExecRestatementReason = report.getExecRestatementReason().getValue();
      if (report.isSetAccount())
        report1.Account = report.getAccount().getValue();
      if (report.isSetSettlmntTyp())
        report1.SettlType = report.getSettlmntTyp().getValue();
      if (report.isSetSymbol())
        report1.Symbol = report.getSymbol().getValue();
      if (report.isSetSymbolSfx())
        report1.SymbolSfx = report.getSymbolSfx().getValue();
      if (report.isSetSecurityID())
        report1.SecurityID = report.getSecurityID().getValue();
      if (report.isSetSecurityType())
        report1.SecurityType = report.getSecurityType().getValue();
      if (report.isSetMaturityMonthYear())
        report1.MaturityMonthYear = report.getMaturityMonthYear().getValue();
      if (report.isSetMaturityDay())
        report1.MaturityDate = DateTime.Parse(report.getMaturityDay().getValue());
      if (report.isSetStrikePrice())
        report1.StrikePrice = report.getStrikePrice().getValue();
      if (report.isSetOptAttribute())
        report1.OptAttribute = report.getOptAttribute().getValue();
      if (report.isSetContractMultiplier())
        report1.ContractMultiplier = report.getContractMultiplier().getValue();
      if (report.isSetCouponRate())
        report1.CouponRate = report.getCouponRate().getValue();
      if (report.isSetSecurityExchange())
        report1.SecurityExchange = report.getSecurityExchange().getValue();
      if (report.isSetIssuer())
        report1.Issuer = report.getIssuer().getValue();
      if (report.isSetEncodedIssuerLen())
        report1.EncodedIssuerLen = report.getEncodedIssuerLen().getValue();
      if (report.isSetEncodedIssuer())
        report1.EncodedIssuer = report.getEncodedIssuer().getValue();
      if (report.isSetSecurityDesc())
        report1.SecurityDesc = report.getSecurityDesc().getValue();
      if (report.isSetEncodedSecurityDescLen())
        report1.EncodedSecurityDescLen = report.getEncodedSecurityDescLen().getValue();
      if (report.isSetEncodedSecurityDesc())
        report1.EncodedSecurityDesc = report.getEncodedSecurityDesc().getValue();
      if (report.isSetSide())
        ((FIXExecutionReport) report1).Side = report.getSide().getValue();
      if (report.isSetOrderQty())
        report1.OrderQty = report.getOrderQty().getValue();
      if (report.isSetCashOrderQty())
        report1.CashOrderQty = report.getCashOrderQty().getValue();
      if (report.isSetOrdType())
        ((FIXExecutionReport) report1).OrdType = report.getOrdType().getValue();
      if (report.isSetPrice())
        report1.Price = report.getPrice().getValue();
      if (report.isSetStopPx())
        report1.StopPx = report.getStopPx().getValue();
      if (report.isSetDiscretionInst())
        report1.DiscretionInst = report.getDiscretionInst().getValue();
      if (report.isSetDiscretionOffset())
        report1.DiscretionOffsetValue = report.getDiscretionOffset().getValue();
      if (report.isSetCurrency())
        report1.Currency = report.getCurrency().getValue();
      if (report.isSetComplianceID())
        report1.ComplianceID = report.getComplianceID().getValue();
      if (report.isSetTimeInForce())
        ((FIXExecutionReport) report1).TimeInForce = report.getTimeInForce().getValue();
      if (report.isSetEffectiveTime())
        report1.EffectiveTime = report.getEffectiveTime().getValue();
      if (report.isSetExpireDate())
        report1.ExpireDate = DateTime.Parse(report.getExpireDate().getValue());
      if (report.isSetExpireTime())
        report1.ExpireTime = report.getExpireTime().getValue();
      if (report.isSetExecInst())
        report1.ExecInst = report.getExecInst().getValue();
      if (report.isSetLastShares())
        report1.LastQty = report.getLastShares().getValue();
      if (report.isSetLastPx())
        report1.LastPx = report.getLastPx().getValue();
      if (report.isSetLastSpotRate())
        report1.LastSpotRate = report.getLastSpotRate().getValue();
      if (report.isSetLastForwardPoints())
        report1.LastForwardPoints = report.getLastForwardPoints().getValue();
      if (report.isSetLastMkt())
        report1.LastMkt = report.getLastMkt().getValue();
      if (report.isSetTradingSessionID())
        report1.TradingSessionID = report.getTradingSessionID().getValue();
      if (report.isSetLastCapacity())
        report1.LastCapacity = report.getLastCapacity().getValue();
      if (report.isSetLeavesQty())
        report1.LeavesQty = report.getLeavesQty().getValue();
      if (report.isSetCumQty())
        report1.CumQty = report.getCumQty().getValue();
      if (report.isSetAvgPx())
        report1.AvgPx = report.getAvgPx().getValue();
      if (report.isSetDayOrderQty())
        report1.DayOrderQty = report.getDayOrderQty().getValue();
      if (report.isSetDayCumQty())
        report1.DayCumQty = report.getDayCumQty().getValue();
      if (report.isSetDayAvgPx())
        report1.DayAvgPx = report.getDayAvgPx().getValue();
      if (report.isSetGTBookingInst())
        report1.GTBookingInst = report.getGTBookingInst().getValue();
      if (report.isSetTradeDate())
        report1.TradeDate = DateTime.Parse(report.getTradeDate().getValue());
      if (report.isSetTransactTime())
        report1.TransactTime = report.getTransactTime().getValue();
      if (report.isSetCommission())
        report1.Commission = report.getCommission().getValue();
      if (report.isSetCommType())
        ((FIXExecutionReport) report1).CommType = report.getCommType().getValue();
      if (report.isSetGrossTradeAmt())
        report1.GrossTradeAmt = report.getGrossTradeAmt().getValue();
      if (report.isSetSettlCurrAmt())
        report1.SettlCurrAmt = report.getSettlCurrAmt().getValue();
      if (report.isSetSettlCurrency())
        report1.SettlCurrency = report.getSettlCurrency().getValue();
      if (report.isSetHandlInst())
        report1.HandlInst = report.getHandlInst().getValue();
      if (report.isSetMinQty())
        report1.MinQty = report.getMinQty().getValue();
      if (report.isSetMaxFloor())
        report1.MaxFloor = report.getMaxFloor().getValue();
      if (report.isSetMaxShow())
        report1.MaxShow = report.getMaxShow().getValue();
      if (report.isSetText())
        report1.Text = report.getText().getValue();
      if (report.isSetEncodedTextLen())
        report1.EncodedTextLen = report.getEncodedTextLen().getValue();
      if (report.isSetEncodedText())
        report1.EncodedText = report.getEncodedText().getValue();
      if (report.isSetOrderQty2())
        report1.OrderQty2 = report.getOrderQty2().getValue();
      if (report.isSetMultiLegReportingType())
        report1.MultiLegReportingType = report.getMultiLegReportingType().getValue();
      if (this.dyw7Oec2k == null)
        return;
      this.dyw7Oec2k((object) this, new ExecutionReportEventArgs(report1));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void onMessage(SecurityDefinition definition, SessionID sessionID)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Send(FIXMarketDataRequest Request)
    {
      Console.WriteLine(BeAEwTZGlZaeOmY5cm.J00weU3cM6(992));
      MarketDataRequest marketDataRequest = new MarketDataRequest(new MDReqID(Request.MDReqID), new SubscriptionRequestType(Request.SubscriptionRequestType), new MarketDepth(Request.MarketDepth));
      if (Request.ContainsField(265))
        marketDataRequest.set(new MDUpdateType(Request.MDUpdateType));
      MarketDataRequest.NoMDEntryTypes noMdEntryTypes = new MarketDataRequest.NoMDEntryTypes();
      for (int i = 0; i < Request.NoMDEntryTypes; ++i)
      {
        noMdEntryTypes.set(new MDEntryType(Request.GetMDEntryTypesGroup(i).MDEntryType));
        marketDataRequest.addGroup((Group) noMdEntryTypes);
      }
      noMdEntryTypes.Dispose();
      MarketDataRequest.NoRelatedSym noRelatedSym = new MarketDataRequest.NoRelatedSym();
      for (int i = 0; i < Request.NoRelatedSym; ++i)
      {
        FIXRelatedSymGroup relatedSymGroup = Request.GetRelatedSymGroup(i);
        noRelatedSym.set(new Symbol(relatedSymGroup.Symbol));
        if (relatedSymGroup.ContainsField(65))
          noRelatedSym.set(new SymbolSfx(relatedSymGroup.SymbolSfx));
        if (relatedSymGroup.ContainsField(48))
          noRelatedSym.set(new SecurityID(relatedSymGroup.SecurityID));
        if (relatedSymGroup.ContainsField(22))
          noRelatedSym.set(new IDSource(relatedSymGroup.SecurityIDSource));
        if (relatedSymGroup.ContainsField(167))
          noRelatedSym.set(new QuickFix.SecurityType(relatedSymGroup.SecurityType));
        if (relatedSymGroup.ContainsField(200))
          noRelatedSym.set(new MaturityMonthYear(relatedSymGroup.MaturityMonthYear));
        if (relatedSymGroup.ContainsField(202))
          noRelatedSym.set(new StrikePrice(relatedSymGroup.StrikePrice));
        if (relatedSymGroup.ContainsField(206))
          noRelatedSym.set(new OptAttribute(relatedSymGroup.OptAttribute));
        if (relatedSymGroup.ContainsField(231))
          noRelatedSym.set(new ContractMultiplier(relatedSymGroup.ContractMultiplier));
        if (relatedSymGroup.ContainsField(223))
          noRelatedSym.set(new CouponRate(relatedSymGroup.CouponRate));
        if (relatedSymGroup.ContainsField(207))
          noRelatedSym.set(new SecurityExchange(relatedSymGroup.SecurityExchange));
        if (relatedSymGroup.ContainsField(106))
          noRelatedSym.set(new Issuer(relatedSymGroup.Issuer));
        if (relatedSymGroup.ContainsField(348))
          noRelatedSym.set(new EncodedIssuerLen(relatedSymGroup.EncodedIssuerLen));
        if (relatedSymGroup.ContainsField(349))
          noRelatedSym.set(new EncodedIssuer(relatedSymGroup.EncodedIssuer));
        if (relatedSymGroup.ContainsField(107))
          noRelatedSym.set(new SecurityDesc(relatedSymGroup.SecurityDesc));
        if (relatedSymGroup.ContainsField(350))
          noRelatedSym.set(new EncodedSecurityDescLen(relatedSymGroup.EncodedSecurityDescLen));
        if (relatedSymGroup.ContainsField(351))
          noRelatedSym.set(new EncodedSecurityDesc(relatedSymGroup.EncodedSecurityDesc));
        marketDataRequest.addGroup((Group) noRelatedSym);
      }
      noRelatedSym.Dispose();
      try
      {
        Session.sendToTarget((QuickFix.Message) marketDataRequest, this.fSessionID);
      }
      catch (Exception ex)
      {
        Console.WriteLine(BeAEwTZGlZaeOmY5cm.J00weU3cM6(1096) + ex.Message);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Send(FIXMarketDataSnapshot Snapshot)
    {
      MarketDataSnapshotFullRefresh snapshotFullRefresh = new MarketDataSnapshotFullRefresh(new Symbol(Snapshot.Symbol));
      if (Snapshot.ContainsField(262))
        snapshotFullRefresh.set(new MDReqID(Snapshot.MDReqID));
      if (Snapshot.ContainsField(65))
        snapshotFullRefresh.set(new SymbolSfx(Snapshot.SymbolSfx));
      if (Snapshot.ContainsField(48))
        snapshotFullRefresh.set(new SecurityID(Snapshot.SecurityID));
      if (Snapshot.ContainsField(22))
        snapshotFullRefresh.set(new IDSource(Snapshot.SecurityIDSource));
      if (Snapshot.ContainsField(167))
        snapshotFullRefresh.set(new QuickFix.SecurityType(Snapshot.SecurityType));
      if (Snapshot.ContainsField(200))
        snapshotFullRefresh.set(new MaturityMonthYear(Snapshot.MaturityMonthYear));
      if (Snapshot.ContainsField(202))
        snapshotFullRefresh.set(new StrikePrice(Snapshot.StrikePrice));
      if (Snapshot.ContainsField(206))
        snapshotFullRefresh.set(new OptAttribute(Snapshot.OptAttribute));
      if (Snapshot.ContainsField(231))
        snapshotFullRefresh.set(new ContractMultiplier(Snapshot.ContractMultiplier));
      if (Snapshot.ContainsField(223))
        snapshotFullRefresh.set(new CouponRate(Snapshot.CouponRate));
      if (Snapshot.ContainsField(207))
        snapshotFullRefresh.set(new SecurityExchange(Snapshot.SecurityExchange));
      if (Snapshot.ContainsField(106))
        snapshotFullRefresh.set(new Issuer(Snapshot.Issuer));
      if (Snapshot.ContainsField(348))
        snapshotFullRefresh.set(new EncodedIssuerLen(Snapshot.EncodedIssuerLen));
      if (Snapshot.ContainsField(349))
        snapshotFullRefresh.set(new EncodedIssuer(Snapshot.EncodedIssuer));
      if (Snapshot.ContainsField(107))
        snapshotFullRefresh.set(new SecurityDesc(Snapshot.SecurityDesc));
      if (Snapshot.ContainsField(350))
        snapshotFullRefresh.set(new EncodedSecurityDescLen(Snapshot.EncodedSecurityDescLen));
      if (Snapshot.ContainsField(351))
        snapshotFullRefresh.set(new EncodedSecurityDesc(Snapshot.EncodedSecurityDesc));
      if (Snapshot.ContainsField(291))
        snapshotFullRefresh.set(new FinancialStatus(((object) Snapshot.FinancialStatus).ToString()));
      if (Snapshot.ContainsField(292))
        snapshotFullRefresh.set(new CorporateAction(((object) Snapshot.CorporateAction).ToString()));
      for (int i = 0; i < Snapshot.NoMDEntries; ++i)
      {
        MarketDataSnapshotFullRefresh.NoMDEntries noMdEntries = new MarketDataSnapshotFullRefresh.NoMDEntries();
        FIXMDEntriesGroup mdEntriesGroup = Snapshot.GetMDEntriesGroup(i);
        noMdEntries.set(new MDEntryType(mdEntriesGroup.MDEntryType));
        noMdEntries.set(new MDEntryPx(mdEntriesGroup.MDEntryPx));
        if (mdEntriesGroup.ContainsField(271))
          noMdEntries.set(new MDEntrySize(mdEntriesGroup.MDEntrySize));
        if (mdEntriesGroup.ContainsField(272))
          noMdEntries.set(new MDEntryDate(mdEntriesGroup.MDEntryDate));
        if (mdEntriesGroup.ContainsField(273))
          noMdEntries.set(new MDEntryTime(mdEntriesGroup.MDEntryTime));
        if (mdEntriesGroup.ContainsField(274))
          noMdEntries.set(new TickDirection(mdEntriesGroup.TickDirection));
        if (mdEntriesGroup.ContainsField(275))
          noMdEntries.set(new MDMkt(mdEntriesGroup.MDMkt));
        if (mdEntriesGroup.ContainsField(336))
          noMdEntries.set(new TradingSessionID(mdEntriesGroup.TradingSessionID));
        if (mdEntriesGroup.ContainsField(276))
          noMdEntries.set(new QuoteCondition(mdEntriesGroup.QuoteCondition));
        if (mdEntriesGroup.ContainsField(277))
          noMdEntries.set(new TradeCondition(mdEntriesGroup.TradeCondition));
        if (mdEntriesGroup.ContainsField(282))
          noMdEntries.set(new MDEntryOriginator(mdEntriesGroup.MDEntryOriginator));
        if (mdEntriesGroup.ContainsField(283))
          noMdEntries.set(new LocationID(mdEntriesGroup.LocationID));
        if (mdEntriesGroup.ContainsField(284))
          noMdEntries.set(new DeskID(mdEntriesGroup.DeskID));
        if (mdEntriesGroup.ContainsField(59))
          noMdEntries.set(new QuickFix.TimeInForce(mdEntriesGroup.TimeInForce));
        if (mdEntriesGroup.ContainsField(126))
          noMdEntries.set(new ExpireTime(mdEntriesGroup.ExpireTime));
        if (mdEntriesGroup.ContainsField(110))
          noMdEntries.set(new MinQty(mdEntriesGroup.MinQty));
        if (mdEntriesGroup.ContainsField(18))
          noMdEntries.set(new ExecInst(mdEntriesGroup.ExecInst));
        if (mdEntriesGroup.ContainsField(287))
          noMdEntries.set(new SellerDays(mdEntriesGroup.SellerDays));
        if (mdEntriesGroup.ContainsField(37))
          noMdEntries.set(new OrderID(mdEntriesGroup.OrderID));
        if (mdEntriesGroup.ContainsField(299))
          noMdEntries.set(new QuoteEntryID(mdEntriesGroup.QuoteEntryID));
        if (mdEntriesGroup.ContainsField(288))
          noMdEntries.set(new MDEntryBuyer(mdEntriesGroup.MDEntryBuyer));
        if (mdEntriesGroup.ContainsField(289))
          noMdEntries.set(new MDEntrySeller(mdEntriesGroup.MDEntrySeller));
        if (mdEntriesGroup.ContainsField(346))
          noMdEntries.set(new NumberOfOrders(mdEntriesGroup.NumberOfOrders));
        if (mdEntriesGroup.ContainsField(290))
          noMdEntries.set(new MDEntryPositionNo(mdEntriesGroup.MDEntryPositionNo));
        if (mdEntriesGroup.ContainsField(58))
          noMdEntries.set(new Text(mdEntriesGroup.Text));
        if (mdEntriesGroup.ContainsField(354))
          noMdEntries.set(new EncodedTextLen(mdEntriesGroup.EncodedTextLen));
        if (mdEntriesGroup.ContainsField(355))
          noMdEntries.set(new EncodedText(mdEntriesGroup.EncodedText));
        snapshotFullRefresh.addGroup((Group) noMdEntries);
        noMdEntries.Dispose();
      }
      try
      {
        Session.sendToTarget((QuickFix.Message) snapshotFullRefresh, this.fSessionID);
      }
      catch (Exception ex)
      {
        Console.WriteLine(BeAEwTZGlZaeOmY5cm.J00weU3cM6(1148) + ex.Message);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Send(FIXMarketDataIncrementalRefresh Refresh)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Send(FIXMarketDataRequestReject Reject)
    {
      QuickFix42.MarketDataRequestReject dataRequestReject = new QuickFix42.MarketDataRequestReject(new MDReqID(Reject.MDReqID));
      if (Reject.ContainsField(281))
        dataRequestReject.set(new QuickFix.MDReqRejReason(Reject.MDReqRejReason));
      if (Reject.ContainsField(58))
        dataRequestReject.set(new Text(Reject.Text));
      if (Reject.ContainsField(354))
        dataRequestReject.set(new EncodedTextLen(Reject.EncodedTextLen));
      if (Reject.ContainsField(355))
        dataRequestReject.set(new EncodedText(Reject.EncodedText));
      try
      {
        Session.sendToTarget((QuickFix.Message) dataRequestReject, this.fSessionID);
      }
      catch (Exception ex)
      {
        Console.WriteLine(BeAEwTZGlZaeOmY5cm.J00weU3cM6(1200) + ex.Message);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Send(FIXNewOrderSingle Order)
    {
      QuickFix42.NewOrderSingle newOrderSingle = new QuickFix42.NewOrderSingle(new ClOrdID(Order.ClOrdID), new HandlInst(Order.HandlInst), new Symbol(Order.Symbol), new QuickFix.Side(Order.Side), new TransactTime(Order.TransactTime), new QuickFix.OrdType(Order.OrdType));
      if (Order.ContainsField(1))
        newOrderSingle.set(new Account(Order.Account));
      if (Order.ContainsField(18))
        newOrderSingle.set(new ExecInst(Order.ExecInst));
      if (Order.ContainsField(110))
        newOrderSingle.set(new MinQty(Order.MinQty));
      if (Order.ContainsField(111))
        newOrderSingle.set(new MaxFloor(Order.MaxFloor));
      if (Order.ContainsField(100))
        newOrderSingle.set(new ExDestination(Order.ExDestination));
      if (Order.ContainsField(81))
        newOrderSingle.set(new ProcessCode(Order.ProcessCode));
      if (Order.ContainsField(65))
        newOrderSingle.set(new SymbolSfx(Order.SymbolSfx));
      if (Order.ContainsField(48))
        newOrderSingle.set(new SecurityID(Order.SecurityID));
      if (Order.ContainsField(22))
        newOrderSingle.set(new IDSource(Order.SecurityIDSource));
      if (Order.ContainsField(167))
        newOrderSingle.set(new QuickFix.SecurityType(Order.SecurityType));
      if (Order.ContainsField(200))
        newOrderSingle.set(new MaturityMonthYear(Order.MaturityMonthYear));
      if (Order.ContainsField(202))
        newOrderSingle.set(new StrikePrice(Order.StrikePrice));
      if (Order.ContainsField(206))
        newOrderSingle.set(new OptAttribute(Order.OptAttribute));
      if (Order.ContainsField(231))
        newOrderSingle.set(new ContractMultiplier(Order.ContractMultiplier));
      if (Order.ContainsField(223))
        newOrderSingle.set(new CouponRate(Order.CouponRate));
      if (Order.ContainsField(207))
        newOrderSingle.set(new SecurityExchange(Order.SecurityExchange));
      if (Order.ContainsField(106))
        newOrderSingle.set(new Issuer(Order.Issuer));
      if (Order.ContainsField(348))
        newOrderSingle.set(new EncodedIssuerLen(Order.EncodedIssuerLen));
      if (Order.ContainsField(349))
        newOrderSingle.set(new EncodedIssuer(Order.EncodedIssuer));
      if (Order.ContainsField(107))
        newOrderSingle.set(new SecurityDesc(Order.SecurityDesc));
      if (Order.ContainsField(350))
        newOrderSingle.set(new EncodedSecurityDescLen(Order.EncodedSecurityDescLen));
      if (Order.ContainsField(351))
        newOrderSingle.set(new EncodedSecurityDesc(Order.EncodedSecurityDesc));
      if (Order.ContainsField(140))
        newOrderSingle.set(new PrevClosePx(Order.PrevClosePx));
      if (Order.ContainsField(38))
        newOrderSingle.set(new OrderQty(Order.OrderQty));
      if (Order.ContainsField(152))
        newOrderSingle.set(new CashOrderQty(Order.CashOrderQty));
      if (Order.ContainsField(44))
        newOrderSingle.set(new Price(Order.Price));
      if (Order.ContainsField(99))
        newOrderSingle.set(new StopPx(Order.StopPx));
      if (Order.ContainsField(15))
        newOrderSingle.set(new QuickFix.Currency(Order.Currency));
      if (Order.ContainsField(376))
        newOrderSingle.set(new ComplianceID(Order.ComplianceID));
      if (Order.ContainsField(117))
        newOrderSingle.set(new QuoteID(Order.QuoteID));
      if (Order.ContainsField(59))
        newOrderSingle.set(new QuickFix.TimeInForce(Order.TimeInForce));
      if (Order.ContainsField(168))
        newOrderSingle.set(new EffectiveTime(Order.EffectiveTime));
      if (Order.ContainsField(126))
        newOrderSingle.set(new ExpireTime(Order.ExpireTime));
      if (Order.ContainsField(427))
        newOrderSingle.set(new GTBookingInst(Order.GTBookingInst));
      if (Order.ContainsField(12))
        newOrderSingle.set(new Commission(Order.Commission));
      if (Order.ContainsField(13))
        newOrderSingle.set(new QuickFix.CommType(Order.CommType));
      if (Order.ContainsField(120))
        newOrderSingle.set(new SettlCurrency(Order.SettlCurrency));
      if (Order.ContainsField(58))
        newOrderSingle.set(new Text(Order.Text));
      if (Order.ContainsField(354))
        newOrderSingle.set(new EncodedTextLen(Order.EncodedTextLen));
      if (Order.ContainsField(355))
        newOrderSingle.set(new EncodedText(Order.EncodedText));
      if (Order.ContainsField(192))
        newOrderSingle.set(new OrderQty2(Order.OrderQty2));
      if (Order.ContainsField(203))
        newOrderSingle.set(new CoveredOrUncovered(Order.CoveredOrUncovered));
      if (Order.ContainsField(210))
        newOrderSingle.set(new MaxShow(Order.MaxShow));
      if (Order.ContainsField(388))
        newOrderSingle.set(new DiscretionInst(Order.DiscretionInst));
      try
      {
        Session.sendToTarget((QuickFix.Message) newOrderSingle, this.fSessionID);
      }
      catch (Exception ex)
      {
        Console.WriteLine(BeAEwTZGlZaeOmY5cm.J00weU3cM6(1252) + ex.Message);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Send(FIXExecutionReport Report)
    {
      QuickFix42.ExecutionReport executionReport = new QuickFix42.ExecutionReport(new OrderID(Report.OrderID), new ExecID(Report.ExecID), new QuickFix.ExecTransType('0'), new QuickFix.ExecType(Report.ExecType), new QuickFix.OrdStatus(Report.OrdStatus), new Symbol(Report.Symbol), new QuickFix.Side(Report.Side), new LeavesQty(Report.LeavesQty), new CumQty(Report.CumQty), new AvgPx(Report.AvgPx));
      if (Report.ContainsField(198))
        executionReport.set(new SecondaryOrderID(Report.SecondaryOrderID));
      if (Report.ContainsField(11))
        executionReport.set(new ClOrdID(Report.ClOrdID));
      if (Report.ContainsField(41))
        executionReport.set(new OrigClOrdID(Report.OrigClOrdID));
      if (Report.ContainsField(66))
        executionReport.set(new ListID(Report.ListID));
      if (Report.ContainsField(19))
        executionReport.set(new ExecRefID(Report.ExecRefID));
      if (Report.ContainsField(103))
        executionReport.set(new OrdRejReason(Report.OrdRejReason));
      if (Report.ContainsField(378))
        executionReport.set(new ExecRestatementReason(Report.ExecRestatementReason));
      if (Report.ContainsField(1))
        executionReport.set(new Account(Report.Account));
      if (Report.ContainsField(65))
        executionReport.set(new SymbolSfx(Report.SymbolSfx));
      if (Report.ContainsField(48))
        executionReport.set(new SecurityID(Report.SecurityID));
      if (Report.ContainsField(167))
        executionReport.set(new QuickFix.SecurityType(Report.SecurityType));
      if (Report.ContainsField(200))
        executionReport.set(new MaturityMonthYear(Report.MaturityMonthYear));
      if (Report.ContainsField(202))
        executionReport.set(new StrikePrice(Report.StrikePrice));
      if (Report.ContainsField(206))
        executionReport.set(new OptAttribute(Report.OptAttribute));
      if (Report.ContainsField(231))
        executionReport.set(new ContractMultiplier(Report.ContractMultiplier));
      if (Report.ContainsField(223))
        executionReport.set(new CouponRate(Report.CouponRate));
      if (Report.ContainsField(207))
        executionReport.set(new SecurityExchange(Report.SecurityExchange));
      if (Report.ContainsField(106))
        executionReport.set(new Issuer(Report.Issuer));
      if (Report.ContainsField(348))
        executionReport.set(new EncodedIssuerLen(Report.EncodedIssuerLen));
      if (Report.ContainsField(349))
        executionReport.set(new EncodedIssuer(Report.EncodedIssuer));
      if (Report.ContainsField(107))
        executionReport.set(new SecurityDesc(Report.SecurityDesc));
      if (Report.ContainsField(350))
        executionReport.set(new EncodedSecurityDescLen(Report.EncodedSecurityDescLen));
      if (Report.ContainsField(351))
        executionReport.set(new EncodedSecurityDesc(Report.EncodedSecurityDesc));
      if (Report.ContainsField(38))
        executionReport.set(new OrderQty(Report.OrderQty));
      if (Report.ContainsField(152))
        executionReport.set(new CashOrderQty(Report.CashOrderQty));
      if (Report.ContainsField(40))
        executionReport.set(new QuickFix.OrdType(Report.OrdType));
      if (Report.ContainsField(44))
        executionReport.set(new Price(Report.Price));
      if (Report.ContainsField(99))
        executionReport.set(new StopPx(Report.StopPx));
      if (Report.ContainsField(388))
        executionReport.set(new DiscretionInst(Report.DiscretionInst));
      if (Report.ContainsField(15))
        executionReport.set(new QuickFix.Currency(Report.Currency));
      if (Report.ContainsField(376))
        executionReport.set(new ComplianceID(Report.ComplianceID));
      if (Report.ContainsField(59))
        executionReport.set(new QuickFix.TimeInForce(Report.TimeInForce));
      if (Report.ContainsField(168))
        executionReport.set(new EffectiveTime(Report.EffectiveTime));
      if (Report.ContainsField(126))
        executionReport.set(new ExpireTime(Report.ExpireTime));
      if (Report.ContainsField(18))
        executionReport.set(new ExecInst(Report.ExecInst));
      if (Report.ContainsField(31))
        executionReport.set(new LastPx(Report.LastPx));
      if (Report.ContainsField(194))
        executionReport.set(new LastSpotRate(Report.LastSpotRate));
      if (Report.ContainsField(195))
        executionReport.set(new LastForwardPoints(Report.LastForwardPoints));
      if (Report.ContainsField(30))
        executionReport.set(new LastMkt(Report.LastMkt));
      if (Report.ContainsField(336))
        executionReport.set(new TradingSessionID(Report.TradingSessionID));
      if (Report.ContainsField(29))
        executionReport.set(new LastCapacity(Report.LastCapacity));
      if (Report.ContainsField(424))
        executionReport.set(new DayOrderQty(Report.DayOrderQty));
      if (Report.ContainsField(425))
        executionReport.set(new DayCumQty(Report.DayCumQty));
      if (Report.ContainsField(426))
        executionReport.set(new DayAvgPx(Report.DayAvgPx));
      if (Report.ContainsField(427))
        executionReport.set(new GTBookingInst(Report.GTBookingInst));
      if (Report.ContainsField(60))
        executionReport.set(new TransactTime(Report.TransactTime));
      if (Report.ContainsField(13))
        executionReport.set(new QuickFix.CommType(Report.CommType));
      if (Report.ContainsField(381))
        executionReport.set(new GrossTradeAmt(Report.GrossTradeAmt));
      if (Report.ContainsField(119))
        executionReport.set(new SettlCurrAmt(Report.SettlCurrAmt));
      if (Report.ContainsField(120))
        executionReport.set(new SettlCurrency(Report.SettlCurrency));
      if (Report.ContainsField(21))
        executionReport.set(new HandlInst(Report.HandlInst));
      if (Report.ContainsField(110))
        executionReport.set(new MinQty(Report.MinQty));
      if (Report.ContainsField(111))
        executionReport.set(new MaxFloor(Report.MaxFloor));
      if (Report.ContainsField(210))
        executionReport.set(new MaxShow(Report.MaxShow));
      if (Report.ContainsField(58))
        executionReport.set(new Text(Report.Text));
      if (Report.ContainsField(354))
        executionReport.set(new EncodedTextLen(Report.EncodedTextLen));
      if (Report.ContainsField(355))
        executionReport.set(new EncodedText(Report.EncodedText));
      if (Report.ContainsField(192))
        executionReport.set(new OrderQty2(Report.OrderQty2));
      if (Report.ContainsField(442))
        executionReport.set(new MultiLegReportingType(Report.MultiLegReportingType));
      try
      {
        Session.sendToTarget((QuickFix.Message) executionReport, this.fSessionID);
      }
      catch (Exception ex)
      {
        Console.WriteLine(BeAEwTZGlZaeOmY5cm.J00weU3cM6(1304) + ex.Message);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Send(FIXOrderCancelRequest request)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Send(FIXOrderCancelReplaceRequest request)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Send(FIXSecurityDefinitionRequest request)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Send(FIXTestRequest request)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Send(FIXResendRequest request)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitLogon(SessionID sessionID)
    {
      if (this.lCISky2Q1 == null)
        return;
      this.lCISky2Q1((object) this, new FIXSessionIDEventArgs(sessionID));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitLogout(SessionID sessionID)
    {
      if (this.N4PQenDmP == null)
        return;
      this.N4PQenDmP((object) this, new FIXSessionIDEventArgs(sessionID));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitMarketDataSnapshot(FIXMarketDataSnapshot snapshot)
    {
      if (this.DHHvj9eQf == null)
        return;
      this.DHHvj9eQf((object) this, new FIXMarketDataSnapshotEventArgs(snapshot));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitExecutionReport(SmartQuant.FIX.ExecutionReport report)
    {
      if (this.dyw7Oec2k == null)
        return;
      this.dyw7Oec2k((object) this, new ExecutionReportEventArgs(report));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitOrderCancelReject(SmartQuant.FIX.OrderCancelReject reject)
    {
      if (this.wTFYVh8fA == null)
        return;
      this.wTFYVh8fA((object) this, new OrderCancelRejectEventArgs(reject));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitSecurityDefinition(FIXSecurityDefinition definition)
    {
      if (this.CsYL4u5r6 == null)
        return;
      this.CsYL4u5r6((object) this, new FIXSecurityDefinitionEventArgs(definition));
    }
  }
}
