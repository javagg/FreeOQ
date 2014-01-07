using NI8YCE6tH4BIeIEcEy;
using SmartQuant.QuantRouterLib.Messages;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace SmartQuant.QuantRouterLib
{
  public abstract class Connection : IConnection
  {
    private ManualResetEventSlim pr5mw3rRZ;

    public string ConnectionString { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public bool RaiseEvents
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.pr5mw3rRZ.IsSet;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Connection()
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.pr5mw3rRZ = new ManualResetEventSlim(false);
    }

    public abstract void Open();

    public abstract void Close();

    public abstract void Send(Message message);

    public abstract void Send(Message[] message);

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnClosed()
    {
      this.pr5mw3rRZ.Wait();
      if (this.NLrcRQrxc == null)
        return;
      this.NLrcRQrxc((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnError(Exception exception)
    {
      this.pr5mw3rRZ.Wait();
      if (this.qCL1jQUQt == null)
        return;
      this.qCL1jQUQt((object) this, new ExceptionEventArgs(exception));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnMessageReceived(Message message)
    {
      this.pr5mw3rRZ.Wait();
      if (this.pJeLILmmI == null)
        return;
      this.pJeLILmmI((object) this, new MessageEventArgs(message));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Message CreateMessage(int type)
    {
      Message message;
      switch (type)
      {
        case 1100:
          message = (Message) new MsgCommand();
          break;
        case 1101:
          message = (Message) new MsgReport();
          break;
        case 1102:
          message = (Message) new MsgOrderCancelReject();
          break;
        case 2001:
          message = (Message) new MsgBrokerInfo();
          break;
        case 1:
          message = (Message) new MsgLogon();
          break;
        case 2:
          message = (Message) new MsgLogonStatus();
          break;
        case 3:
          message = (Message) new MsgHeartbeat();
          break;
        case 10:
          message = (Message) new MsgSubscribe();
          break;
        case 11:
          message = (Message) new MsgUnsubscribe();
          break;
        case 12:
          message = (Message) new MsgProviderError();
          break;
        case 13:
          message = (Message) new MsgSubscriptionStatus();
          break;
        case 1000:
          message = (Message) new MsgTick();
          break;
        case 1001:
          message = (Message) new MsgLevel2();
          break;
        default:
          message = (Message) new MsgUnknown(type);
          break;
      }
      return message;
    }
  }
}
