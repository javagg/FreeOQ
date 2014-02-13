using FreeQuant.QuantRouterLib;
using System;
using System.Net;
using System.Net.Sockets;

namespace FreeQuant.QuantRouterLib.Tcp
{
	public class TcpConnectionAcceptor : ConnectionAcceptor
	{
		public const int DEFAULT_PORT = 8883;
		private TcpListener listener;

		public override void Start(string connectionString)
		{
			int port;
			if (!new ConnectionStringParser(connectionString).TryGetValue("port", out port))
				port = DEFAULT_PORT;
			this.listener = new TcpListener(IPAddress.Any, port);
			try
			{
				this.SetState(ConnectionAcceptorState.Starting);
				this.listener.Start();
				this.KauryJhJr();
				this.SetState(ConnectionAcceptorState.Started);
			}
			catch (Exception ex)
			{
				this.listener = null;
				this.SetState(ConnectionAcceptorState.Stopped);
				throw ex;
			}
		}

		public override void Stop()
		{
			this.listener.Stop();
		}

		private void KauryJhJr()
		{
			this.listener.BeginAcceptTcpClient(new AsyncCallback(this.c2Q2JKuqw), this.listener);
		}

		private void c2Q2JKuqw(IAsyncResult result)
		{
			TcpListener tcpListener = (TcpListener)result.AsyncState;
			try
			{
				TcpClient tcpClient = tcpListener.EndAcceptTcpClient(result);
				TcpConnection tcpConnection = new TcpConnection();
				tcpConnection.AOfaXfDTg(tcpClient);
				this.OnConnectionAccepted(tcpConnection);
				this.KauryJhJr();
			}
			catch
			{
			}
		}
	}
}
