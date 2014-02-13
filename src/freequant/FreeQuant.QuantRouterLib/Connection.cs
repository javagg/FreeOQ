using FreeQuant.QuantRouterLib.Messages;
using System;
using System.Threading;

namespace FreeQuant.QuantRouterLib
{
	public abstract class Connection : IConnection
	{
		private ManualResetEventSlim pr5mw3rRZ;

		public string ConnectionString { get; set; }

		public bool RaiseEvents
		{
			get
			{
				return this.pr5mw3rRZ.IsSet;
			}
			set
			{
				if (value)
					this.pr5mw3rRZ.Set();
				else
					this.pr5mw3rRZ.Reset();
			}
		}

		public event EventHandler Closed;
		public event EventHandler<ExceptionEventArgs> Error;
		public event EventHandler<MessageEventArgs> MessageReceived;

		protected Connection() : base()
		{
			this.pr5mw3rRZ = new ManualResetEventSlim(false);
		}

		public abstract void Open();

		public abstract void Close();

		public abstract void Send(Message message);

		public abstract void Send(Message[] message);

		protected void OnClosed()
		{
			this.pr5mw3rRZ.Wait();
			if (this.Closed != null)
			this.Closed(this, EventArgs.Empty);
		}

		protected void OnError(Exception exception)
		{
			this.pr5mw3rRZ.Wait();
			if (this.Error != null)
			this.Error(this, new ExceptionEventArgs(exception));
		}

		protected void OnMessageReceived(Message message)
		{
			this.pr5mw3rRZ.Wait();
			if (this.MessageReceived != null)
			this.MessageReceived(this, new MessageEventArgs(message));
		}

		protected Message CreateMessage(int type)
		{
			Message message;
			switch (type)
			{
				case 1100:
					message = new MsgCommand();
					break;
				case 1101:
					message = new MsgReport();
					break;
				case 1102:
					message = new MsgOrderCancelReject();
					break;
				case 2001:
					message = new MsgBrokerInfo();
					break;
				case 1:
					message = new MsgLogon();
					break;
				case 2:
					message = new MsgLogonStatus();
					break;
				case 3:
					message = new MsgHeartbeat();
					break;
				case 10:
					message = new MsgSubscribe();
					break;
				case 11:
					message = new MsgUnsubscribe();
					break;
				case 12:
					message = new MsgProviderError();
					break;
				case 13:
					message = new MsgSubscriptionStatus();
					break;
				case 1000:
					message = new MsgTick();
					break;
				case 1001:
					message = new MsgLevel2();
					break;
				default:
					message = new MsgUnknown(type);
					break;
			}
			return message;
		}
	}
}
