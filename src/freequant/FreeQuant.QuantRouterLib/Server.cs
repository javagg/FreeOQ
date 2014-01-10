using System;
using System.Runtime.InteropServices;

namespace FreeQuant.QuantRouterLib
{
  public class Server
  {
    private IConnectionAcceptor acceptor;

    public ConnectionAcceptorState AcceptorState
    {
       get
      {
        return this.acceptor.State;
      }
    }

    public event EventHandler AcceptorStateChanged;

    public event EventHandler<ConnectionEventArgs> ConnectionAccepted;

		public Server(IConnectionAcceptor acceptor)
    {
			this.acceptor = acceptor; 
      acceptor.StateChanged += new EventHandler(this.vPChQclbed);
      acceptor.ConnectionAccepted += new EventHandler<ConnectionEventArgs>(this.eakhiQJEUE);
    }

    public void Start(string connectionString)
    {
      this.acceptor.Start(connectionString);
    }

    public void Stop()
    {
      this.acceptor.Stop();
    }

    private void vPChQclbed([In] object obj0, [In] EventArgs obj1)
    {
      if (this.sTPhXSa4kI == null)
        return;
      this.sTPhXSa4kI((object) this, EventArgs.Empty);
    }

    private void eakhiQJEUE([In] object obj0, [In] ConnectionEventArgs obj1)
    {
      if (this.LonhJIL5Gh == null)
        return;
      this.LonhJIL5Gh((object) this, obj1);
    }
  }
}
