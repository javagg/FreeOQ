using FreeQuant.QuantRouterLib.Data;
using FreeQuant.QuantRouterLib.Messages;
using System;

namespace FreeQuant.QuantRouterLib
{
	public class Client
	{
		private IConnection connection;
		private int requiestId;

		public event EventHandler<MessageEventArgs> MessageOut;
		public event EventHandler<MessageEventArgs> MessageIn;
		public event EventHandler<ExceptionEventArgs> Error;
		public event EventHandler<LogonEventArgs> LoggedIn;
		public event EventHandler<LogoutEventArgs> LoggedOut;
		public event EventHandler<HeartbeatEventArgs> Heartbeat;
		public event EventHandler<TickEventArgs> Tick;
		public event EventHandler<ExecutionReportEventArgs> Report;
		public event EventHandler<OrderCancelRejectEventArgs> OrderCancelReject;
		public event EventHandler<ProviderErrorEventArgs> ProviderError;
		public event EventHandler<SubscriptionStatusEventArgs> SubscriptionStatus;
		public event EventHandler<BrokerInfoEventArgs> BrokerInfo;

		public Client()
		{
			this.requiestId = 1;
		}

		public int GetNextRequestId()
		{
			lock (this)
				return this.requiestId++;
		}

		public void Logon(IConnection connection, string username, string password)
		{
			this.connection = connection; 
			connection.Closed += (sender, e) =>
			{
				this.EmitLoggedOut(null);
			};
			connection.Error += (sender, e) =>
			{
				this.EmitError(e.Exception);
			};
			connection.MessageReceived += new EventHandler<MessageEventArgs>(this.OnMessageReceived);
			connection.RaiseEvents = true;
			try
			{
				connection.Open();
			}
			catch (Exception ex)
			{
				this.EmitError(ex);
				this.EmitLoggedOut(null);
				return;
			}
			this.SendMessage(new MsgLogon()
			{
				Data =
				{
					Username = username,
					Password = password
				}
			});
		}

		public void Logout()
		{
			this.connection.Close();
		}

		public void Subscribe(int requestId, string symbol, string formula)
		{
			MsgSubscribe msgSubscribe = new MsgSubscribe();
			msgSubscribe.Data.RequestId = requestId;
			msgSubscribe.Data.Symbol = symbol;
			msgSubscribe.Data.Formula = formula;
			this.SendMessage(msgSubscribe);
		}

		public void Unsubscribe(int requestId)
		{
			MsgUnsubscribe msgUnsubscribe = new MsgUnsubscribe();
			msgUnsubscribe.Data.RequestId = requestId;
			this.SendMessage(msgUnsubscribe);
		}

		public void SendCommand(Command command)
		{
			this.SendMessage((Message)new MsgCommand(command));
		}

		public void SendHearbeat(Heartbeat heartbeat)
		{
			this.SendMessage(new MsgHeartbeat(heartbeat));
		}

		private void SendMessage(Message message)
		{
			try
			{
				if (this.MessageOut != null)
					this.MessageOut(this, new MessageEventArgs(message));
				this.connection.Send(message);
			}
			catch (Exception ex)
			{
				this.EmitError(ex);
				this.EmitLoggedOut(null);
			}
		}

		private void OnMessageReceived(object sender, MessageEventArgs e)
		{
			Message message = e.Message;
			if (this.MessageIn != null)
				this.MessageIn(this, new MessageEventArgs(message));
			switch (message.Type)
			{
				case 1000:
					if (this.Tick != null)
								this.Tick(this, new TickEventArgs(((MsgTick)message).Data));
					break;
				case 1001:
					if (this.Tick != null)
							this.Tick(this, new TickEventArgs((Tick)((MsgLevel2)message).Data));
					break;
				case 1101:
					if (this.Report != null)
						this.Report(this, new ExecutionReportEventArgs(((MsgReport)message).Data));
					break;
				case 1102:
					if (this.OrderCancelReject != null)
						this.OrderCancelReject(this, new OrderCancelRejectEventArgs(((MsgOrderCancelReject)message).Data));
					break;
				case 2001:
					if (this.BrokerInfo != null)
						this.BrokerInfo(this, new BrokerInfoEventArgs(((MsgBrokerInfo)message).Data));
					break;
				case 2:
					LogonStatus data1 = ((MsgLogonStatus)message).Data;
					if (data1.IsLoggedIn)
					{
						this.EmitLoggedIn(data1.Text);
						break;
					}
					else
					{
						this.EmitLoggedOut(data1.Text);
						break;
					}
				case 3:
					Heartbeat data2 = ((MsgHeartbeat)message).Data;
					if (this.Heartbeat != null)
						this.Heartbeat(this, new HeartbeatEventArgs(data2));
					break;
				case 12:
					if (this.ProviderError != null)
						this.ProviderError(this, new ProviderErrorEventArgs(((MsgProviderError)message).Data));
					break;
				case 13:
					if (this.SubscriptionStatus != null)
						this.SubscriptionStatus(this, new SubscriptionStatusEventArgs(((MsgSubscriptionStatus)message).Data));
					break;
			}
		}

		private void EmitError(Exception ex)
		{
			if (this.Error != null)
			this.Error(this, new ExceptionEventArgs(ex));
		}

		private void EmitLoggedIn(string text)
		{
			if (this.LoggedIn != null)
			this.LoggedIn(this, new LogonEventArgs(text));
		}

		private void EmitLoggedOut(string text)
		{
			if (this.LoggedOut == null)
				return;
			this.LoggedOut(this, new LogoutEventArgs(text));
		}
	}
}
