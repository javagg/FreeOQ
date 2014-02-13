using System;

namespace FreeQuant.QuantRouterLib
{
  public abstract class ConnectionAcceptor : IConnectionAcceptor
  {
    public ConnectionAcceptorState State {  get;  protected set; }

    public event EventHandler<ConnectionEventArgs> ConnectionAccepted;

    public event EventHandler StateChanged;

    
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
      if (state == newState || this.StateChanged == null)
        return;
      this.StateChanged(this, EventArgs.Empty);
    }


    protected void OnConnectionAccepted(IConnection connection)
    {
      if (this.ConnectionAccepted != null)
	      this.ConnectionAccepted(this, new ConnectionEventArgs(connection));
    }
  }
}
