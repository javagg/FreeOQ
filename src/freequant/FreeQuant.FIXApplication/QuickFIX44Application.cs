using System;
using QuickFix;
using FreeQuant.FIX;

namespace FreeQuant.FIXApplication
{
	public class QuickFIX44Application : MessageCracker, IFIXApplication, IApplication
    {
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

		public QuickFIX44Application() : base()
        {
        }

		public virtual void Send(FIXMarketDataRequest request)
		{
		}

		public virtual void Send(FIXMarketDataSnapshot snapshot)
		{
		}

		public virtual void Send(FIXMarketDataIncrementalRefresh refresh)
		{
		}

		public virtual void Send(FIXMarketDataRequestReject reject)
		{
		}

		public virtual void Send(FIXNewOrderSingle order)
		{
		}

		public virtual void Send(FIXExecutionReport report)
		{
		}

		public virtual void Send(FIXOrderCancelRequest request)
		{
		}

		public virtual void Send(FIXOrderCancelReplaceRequest request)
		{
		}

		public virtual void Send(FIXSecurityDefinitionRequest request)
		{
		}

		public virtual void Send(FIXTestRequest request)
		{
		}


		public virtual void Send(FIXResendRequest resuest)
		{
		}

		public virtual void ToAdmin(Message message, SessionID sessionID)
		{
		}

		public virtual void FromAdmin(Message message, SessionID sessionID) 
		{
		}

		public virtual void ToApp(Message message, SessionID sessionId)
		{
		}

		public virtual void FromApp(Message message, SessionID sessionID)
		{
		}

		public virtual void OnCreate(SessionID sessionID)
		{
		}

		public virtual void OnLogout(SessionID sessionID)
		{
		}

		public virtual void OnLogon(SessionID sessionID)
		{
		}
    }
}

