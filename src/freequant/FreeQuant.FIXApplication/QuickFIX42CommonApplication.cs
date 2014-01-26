using FreeQuant;
using FreeQuant.FIX;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using QuickFix;

namespace FreeQuant.FIXApplication
{
  public class QuickFIX42CommonApplication : QuickFIX42Application
  {
    protected QuickFIX42CommonProvider provider;
    protected SessionID priceSessionID;
    protected SessionID orderSessionID;
		private FileLog fileLog; 

		protected QuickFIX42CommonApplication(QuickFIX42CommonProvider provider, string logFilePreffix) :base()
    {
      this.provider = provider;
			this.fileLog = new FileLog(logFilePreffix);
    }

    internal void adf1ZbrcY([In] SessionID obj0, [In] SessionID obj1)
    {
      this.priceSessionID = obj0;
      this.orderSessionID = obj1;
    }

    public override void onCreate(SessionID sessionID)
    {
    }

    public override void onLogon(SessionID sessionID)
    {
      bool flag1;
      if (this.priceSessionID == null)
      {
        flag1 = true;
      }
      else
      {
        Session session = Session.lookupSession(this.priceSessionID);
        flag1 = session != null && session.isLoggedOn();
      }
      bool flag2;
      if (this.orderSessionID == null)
      {
        flag2 = true;
      }
      else
      {
        Session session = Session.lookupSession(this.orderSessionID);
        flag2 = session != null && session.isLoggedOn();
      }
      if (!flag1 || !flag2)
        return;
      this.EmitLogon((SessionID) null);
    }

    public override void onLogout(SessionID sessionID)
    {
      bool flag1;
      if (this.priceSessionID == null)
      {
        flag1 = true;
      }
      else
      {
        Session session = Session.lookupSession(this.priceSessionID);
        flag1 = session != null && !session.isLoggedOn();
      }
      bool flag2;
      if (this.orderSessionID == null)
      {
        flag2 = true;
      }
      else
      {
        Session session = Session.lookupSession(this.orderSessionID);
        flag2 = session != null && !session.isLoggedOn();
      }
      if (!flag1 || !flag2)
        return;
      this.EmitLogout((SessionID) null);
    }

    public override void fromAdmin(QuickFix.Message message, SessionID sessionID)
    {
      if (!(message is QuickFix42.Reject))
        return;
      this.crack(message, sessionID);
    }

    public override void toAdmin(QuickFix.Message message, SessionID sessionID)
    {
      if (!(message is QuickFix42.Reject))
        return;
      this.crack(message, sessionID);
    }

    public override void fromApp(QuickFix.Message message, SessionID sessionID)
    {
      this.crack(message, sessionID);
      message.Dispose();
    }

    public override void toApp(QuickFix.Message message, SessionID sessionID)
    {
    }

    public override void Connect()
    {
      if (this.priceSessionID != null)
      {
        Session session = Session.lookupSession(this.priceSessionID);
        if (session != null && !session.isLoggedOn())
          session.logon();
      }
      if (this.orderSessionID == null)
        return;
      Session session1 = Session.lookupSession(this.orderSessionID);
      if (session1 == null || session1.isLoggedOn())
        return;
      session1.logon();
    }

    public override void Disconnect()
    {
      if (this.priceSessionID != null)
      {
        Session session = Session.lookupSession(this.priceSessionID);
        if (session != null && session.isLoggedOn())
          session.logout();
      }
      if (this.orderSessionID == null)
        return;
      Session session1 = Session.lookupSession(this.orderSessionID);
      if (session1 == null || !session1.isLoggedOn())
        return;
      session1.logout();
    }

//		public void onMessage(QuickFix.FIX42.MarketDataSnapshotFullRefresh message, SessionID sessionID)
//    {
//    }

		public void onMessage(QuickFix.FIX42.MarketDataIncrementalRefresh message, SessionID sessionID)
    {
    }

		new public void onMessage(QuickFix.FIX42.MarketDataRequestReject reject, SessionID sessionID)
    {
      string str = reject.isSetText() ? reject.getText().getValue() : "";
      this.provider.EmitError(string.Format(BeAEwTZGlZaeOmY5cm.J00weU3cM6(1356), (object) reject.getMDReqID().getValue(), (object) str));
    }

		public void onMessage(QuickFix.FIX42.Reject message, SessionID session)
    {
      this.provider.EmitError(string.Format(BeAEwTZGlZaeOmY5cm.J00weU3cM6(1450), (object) message.ToString()));
    }

		new public void onMessage(QuickFix.FIX42.SecurityDefinition definition, SessionID sessionID)
    {
      FIXSecurityDefinition definition1 = new FIXSecurityDefinition();
      this.ConvertMessage((QuickFix.Message) definition, (FIXMessage) definition1);
      this.EmitSecurityDefinition(definition1);
    }

//		public void onMessage(QuickFix.FIX42.ExecutionReport message, SessionID sessionID)
//    {
//    }

		public void onMessage(QuickFix.FIX42.OrderCancelReject message, SessionID sessionID)
    {
    }

		public void onMessage(QuickFix.FIX42.BusinessMessageReject message, SessionID sessionID)
    {
      this.provider.EmitError(string.Format(BeAEwTZGlZaeOmY5cm.J00weU3cM6(1476), (object) message.ToString()));
    }

		public void onMessage(QuickFix.FIX42.TradingSessionStatus message, SessionID sessionID)
    {
      List<string> list = new List<string>();
      list.Add(BeAEwTZGlZaeOmY5cm.J00weU3cM6(1532));
      if (this.SessionEquals(sessionID, this.priceSessionID))
        list.Add(BeAEwTZGlZaeOmY5cm.J00weU3cM6(1578));
      if (this.SessionEquals(sessionID, this.orderSessionID))
        list.Add(BeAEwTZGlZaeOmY5cm.J00weU3cM6(1592));
      if (message.isSetTradSesStatus())
      {
        int num = message.getTradSesStatus().getValue();
        list.Add(string.Format(BeAEwTZGlZaeOmY5cm.J00weU3cM6(1606), (object) num, (object) FIXTradSesStatus.ToString(num)));
      }
      if (message.isSetText())
        list.Add(string.Format(BeAEwTZGlZaeOmY5cm.J00weU3cM6(1654), (object) message.getText().getValue()));
      this.provider.EmitError(string.Join(BeAEwTZGlZaeOmY5cm.J00weU3cM6(1674), (IEnumerable<string>) list));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool SessionEquals(SessionID sessionID1, SessionID sessionID2)
    {
      if (sessionID1 == null || sessionID2 == null)
        return false;
      else
        return sessionID1.ToString() == sessionID2.ToString();
    }

   protected void ConvertMessage(QuickFix.Message srcMessage, FIXMessage dstMessage)
    {
      foreach (Field field1 in srcMessage)
      {
        int field2 = field1.getField();
        switch (EFIXFieldTypes.GetFIXType(field2))
        {
          case FIXType.Bool:
            dstMessage.SetBoolValue(field2, srcMessage.getBoolean(field2));
            continue;
          case FIXType.Int:
            dstMessage.SetIntValue(field2, srcMessage.getInt(field2));
            continue;
          case FIXType.Double:
            dstMessage.SetDoubleValue(field2, srcMessage.getDouble(field2));
            continue;
          case FIXType.Char:
            dstMessage.SetCharValue(field2, srcMessage.getChar(field2));
            continue;
          case FIXType.String:
            dstMessage.SetStringValue(field2, srcMessage.getString(field2));
            continue;
          case FIXType.DateTime:
            DateTime? nullable = new DateTime?();
            if (!nullable.HasValue)
            {
              try
              {
                nullable = new DateTime?(srcMessage.getUtcTimeStamp(field2));
              }
              catch
              {
              }
            }
            if (!nullable.HasValue)
            {
              try
              {
                nullable = new DateTime?(srcMessage.getUtcDateOnly(field2));
              }
              catch
              {
              }
            }
            if (!nullable.HasValue)
            {
              try
              {
                nullable = new DateTime?(srcMessage.getUtcTimeOnly(field2));
              }
              catch
              {
              }
            }
            if (nullable.HasValue)
            {
              dstMessage.SetDateTimeValue(field2, nullable.Value);
              continue;
            }
            else
              continue;
          default:
            continue;
        }
      }
    }
  }
}
