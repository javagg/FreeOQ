using FreeQuant.QuantRouterLib.Data;
using FreeQuant.QuantRouterLib.Messages;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.QuantRouterLib
{
  public class Client
  {
    private IConnection Nfth4l1wDN;
    private int poehyR6pN0;

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
      this.poehyR6pN0 = 1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetNextRequestId()
    {
      lock (this)
        return this.poehyR6pN0++;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Logon(IConnection connection, string username, string password)
    {
      this.Nfth4l1wDN = connection;
      connection.Closed += new EventHandler(this.TD6hRMPEQL);
      connection.Error += new EventHandler<ExceptionEventArgs>(this.zKKhfpYRJc);
      connection.MessageReceived += new EventHandler<MessageEventArgs>(this.nSCh0Xk10a);
      connection.RaiseEvents = true;
      try
      {
        connection.Open();
      }
      catch (Exception ex)
      {
        this.DAPhUsKCGx(ex);
        this.SZ1h9kcG47((string) null);
        return;
      }
      this.Yt1h37vmGL((Message) new MsgLogon()
      {
        Data = {
          Username = username,
          Password = password
        }
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Logout()
    {
      this.Nfth4l1wDN.Close();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Subscribe(int requestId, string symbol, string formula)
    {
      MsgSubscribe msgSubscribe = new MsgSubscribe();
      msgSubscribe.Data.RequestId = requestId;
      msgSubscribe.Data.Symbol = symbol;
      msgSubscribe.Data.Formula = formula;
      this.Yt1h37vmGL((Message) msgSubscribe);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Unsubscribe(int requestId)
    {
      MsgUnsubscribe msgUnsubscribe = new MsgUnsubscribe();
      msgUnsubscribe.Data.RequestId = requestId;
      this.Yt1h37vmGL((Message) msgUnsubscribe);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SendCommand(Command command)
    {
      this.Yt1h37vmGL((Message) new MsgCommand(command));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SendHearbeat(Heartbeat heartbeat)
    {
      this.Yt1h37vmGL((Message) new MsgHeartbeat(heartbeat));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Yt1h37vmGL([In] Message obj0)
    {
      try
      {
        if (this.YcRhnQT4C8 != null)
          this.YcRhnQT4C8((object) this, new MessageEventArgs(obj0));
        this.Nfth4l1wDN.Send(obj0);
      }
      catch (Exception ex)
      {
        this.DAPhUsKCGx(ex);
        this.SZ1h9kcG47((string) null);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TD6hRMPEQL([In] object obj0, [In] EventArgs obj1)
    {
      this.SZ1h9kcG47((string) null);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void zKKhfpYRJc([In] object obj0, [In] ExceptionEventArgs obj1)
    {
      this.DAPhUsKCGx(obj1.Exception);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void nSCh0Xk10a([In] object obj0, [In] MessageEventArgs obj1)
    {
      Message message = obj1.Message;
      if (this.GtVhj477Q0 != null)
        this.GtVhj477Q0((object) this, new MessageEventArgs(message));
      switch (message.Type)
      {
        case 1000:
          if (this.wtyhYSRuD5 == null)
            break;
          this.wtyhYSRuD5((object) this, new TickEventArgs(((MsgTick) message).Data));
          break;
        case 1001:
          if (this.wtyhYSRuD5 == null)
            break;
          this.wtyhYSRuD5((object) this, new TickEventArgs((Tick) ((MsgLevel2) message).Data));
          break;
        case 1101:
          if (this.fbXhstGSMq == null)
            break;
          this.fbXhstGSMq((object) this, new ExecutionReportEventArgs(((MsgReport) message).Data));
          break;
        case 1102:
          if (this.VdChD8FYWq == null)
            break;
          this.VdChD8FYWq((object) this, new OrderCancelRejectEventArgs(((MsgOrderCancelReject) message).Data));
          break;
        case 2001:
          if (this.PyWhbGS8KF == null)
            break;
          this.PyWhbGS8KF((object) this, new BrokerInfoEventArgs(((MsgBrokerInfo) message).Data));
          break;
        case 2:
          LogonStatus data1 = ((MsgLogonStatus) message).Data;
          if (data1.IsLoggedIn)
          {
            this.TMghOXRuZ9(data1.Text);
            break;
          }
          else
          {
            this.SZ1h9kcG47(data1.Text);
            break;
          }
        case 3:
          Heartbeat data2 = ((MsgHeartbeat) message).Data;
          if (this.NZRhe7OETV == null)
            break;
          this.NZRhe7OETV((object) this, new HeartbeatEventArgs(data2));
          break;
        case 12:
          if (this.oibhgwaX0m == null)
            break;
          this.oibhgwaX0m((object) this, new ProviderErrorEventArgs(((MsgProviderError) message).Data));
          break;
        case 13:
          if (this.q2rhIouTkA == null)
            break;
          this.q2rhIouTkA((object) this, new SubscriptionStatusEventArgs(((MsgSubscriptionStatus) message).Data));
          break;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DAPhUsKCGx([In] Exception obj0)
    {
      if (this.pwphSCWZOX == null)
        return;
      this.pwphSCWZOX((object) this, new ExceptionEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TMghOXRuZ9([In] string obj0)
    {
      if (this.JP9hW8Heyy == null)
        return;
      this.JP9hW8Heyy((object) this, new LogonEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SZ1h9kcG47([In] string obj0)
    {
      if (this.nPWhtUCW0t == null)
        return;
      this.nPWhtUCW0t((object) this, new LogoutEventArgs(obj0));
    }
  }
}
