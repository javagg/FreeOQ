// Type: SmartQuant.QuantRouterLib.ConnectionAcceptor
// Assembly: SmartQuant.QuantRouterLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: FDF277D6-C8FB-45C3-A0BD-1C1035F3B027
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantRouterLib.dll

using NI8YCE6tH4BIeIEcEy;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.QuantRouterLib
{
  public abstract class ConnectionAcceptor : IConnectionAcceptor
  {
    public ConnectionAcceptorState State { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] protected set; }

    public event EventHandler<ConnectionEventArgs> ConnectionAccepted;

    public event EventHandler StateChanged;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ConnectionAcceptor()
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.State = ConnectionAcceptorState.Stopped;
    }

    public abstract void Start(string connectionString);

    public abstract void Stop();

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetState(ConnectionAcceptorState newState)
    {
      ConnectionAcceptorState state = this.State;
      this.State = newState;
      if (state == newState || this.UPlPFm0Ko == null)
        return;
      this.UPlPFm0Ko((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnConnectionAccepted(IConnection connection)
    {
      if (this.rqTTQg3nv == null)
        return;
      this.rqTTQg3nv((object) this, new ConnectionEventArgs(connection));
    }
  }
}
