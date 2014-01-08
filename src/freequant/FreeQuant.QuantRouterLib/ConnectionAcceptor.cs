using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib
{
  public abstract class ConnectionAcceptor : IConnectionAcceptor
  {
    public ConnectionAcceptorState State { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] protected set; }

    public event EventHandler<ConnectionEventArgs> ConnectionAccepted;

    public event EventHandler StateChanged;

    [MethodImpl(MethodImplOptions.NoInlining)]
		protected ConnectionAcceptor() : base()
    {

      this.State = ConnectionAcceptorState.Stopped;
    }

    public abstract void Start(string connectionString);

    public abstract void Stop();

    protected void SetState(ConnectionAcceptorState newState)
    {
      ConnectionAcceptorState state = this.State;
      this.State = newState;
      if (state == newState || this.UPlPFm0Ko == null)
        return;
      this.UPlPFm0Ko((object) this, EventArgs.Empty);
    }


    protected void OnConnectionAccepted(IConnection connection)
    {
      if (this.rqTTQg3nv == null)
        return;
      this.rqTTQg3nv((object) this, new ConnectionEventArgs(connection));
    }
  }
}
