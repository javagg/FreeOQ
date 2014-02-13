using System;

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
			acceptor.StateChanged += (sender, e) =>
			{
				if (this.AcceptorStateChanged != null)
					this.AcceptorStateChanged(this, EventArgs.Empty);
			};

			acceptor.ConnectionAccepted += (sender, e) =>
			{
				if (this.ConnectionAccepted != null)
					this.ConnectionAccepted(this, e);
			};

		}

		public void Start(string connectionString)
		{
			this.acceptor.Start(connectionString);
		}

		public void Stop()
		{
			this.acceptor.Stop();
		}
	}
}
