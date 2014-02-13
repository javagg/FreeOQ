using FreeQuant.QuantRouterLib;
using FreeQuant.QuantRouterLib.Messages;
using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace FreeQuant.QuantRouterLib.Tcp
{
	public class TcpConnection : Connection
	{
		private TcpClient RNl3aLUdD;
		private NetworkStream SlIRVIT0r;

		public TcpConnection() : base()
		{
		}

		public TcpConnection(string connectionString) : this()
		{
			this.ConnectionString = connectionString;
		}

		public override void Open()
		{
			ConnectionStringParser connectionStringParser = new ConnectionStringParser(this.ConnectionString);
			string hostname = string.Empty;
			connectionStringParser.TryGetValue("hostname", out hostname);
			int port = 0;
			connectionStringParser.TryGetValue("port", out port);
			TcpClient tcpClient = new TcpClient();
			try
			{
				tcpClient.Connect(hostname, port);
				this.AOfaXfDTg(tcpClient);
			}
			catch (Exception ex)
			{
				this.SlIRVIT0r = null;
				throw ex;
			}
		}

		public override void Close()
		{
			try
			{
				byte[] bytes = BitConverter.GetBytes(-1);
				this.SlIRVIT0r.Write(bytes, 0, bytes.Length);
				this.SlIRVIT0r.Flush();
				((Stream)this.SlIRVIT0r).Close();
				this.RNl3aLUdD.Close();
			}
			finally
			{
				this.SlIRVIT0r = (NetworkStream)null;
				this.RNl3aLUdD = (TcpClient)null;
			}
		}

		public override void Send(Message message)
		{
			this.Send(new Message[] { message });
		}

		public override void Send(Message[] messages)
		{
			try
			{
				lock (this)
				{
					MemoryStream local_0 = new MemoryStream();
					BinaryWriter local_1 = new BinaryWriter((Stream)local_0);
					foreach (Message item_0 in messages)
					{
						local_1.Write(item_0.Type);
						item_0.GetData(local_1);
					}
					local_1.Flush();
					byte[] local_3 = BitConverter.GetBytes((int)local_0.Length);
					this.SlIRVIT0r.Write(local_3, 0, local_3.Length);
					local_0.Position = 0L;
					local_0.CopyTo((Stream)this.SlIRVIT0r);
				}
			}
			catch (Exception ex)
			{
				this.Close();
				throw ex;
			}
		}

		internal void AOfaXfDTg(TcpClient obj0)
		{
			this.RNl3aLUdD = obj0;
			this.SlIRVIT0r = obj0.GetStream();
			ManualResetEventSlim manualResetEventSlim = new ManualResetEventSlim(false);
			new Thread(new ParameterizedThreadStart(this.u6dkJQEvy))
			{
				Name = "TheWork",
				IsBackground = true
			}.Start((object)manualResetEventSlim);
			manualResetEventSlim.Wait();
		}

		private void Yj7GgARTd(byte[] obj0)
		{
			MemoryStream memoryStream = new MemoryStream(obj0);
			memoryStream.Position = 0L;
			BinaryReader reader = new BinaryReader((Stream)memoryStream);
			while (reader.BaseStream.Position < reader.BaseStream.Length)
			{
				int type = reader.ReadInt32();
				if (type == -1)
					break;
				Message message = this.CreateMessage(type);
				message.SetData(reader);
				this.OnMessageReceived(message);
			}
		}

		private void u6dkJQEvy(object obj0)
		{
			((ManualResetEventSlim)obj0).Set();
			try
			{
				BinaryReader binaryReader = new BinaryReader((Stream)this.SlIRVIT0r);
				while (true)
				{
					int count = binaryReader.ReadInt32();
					this.Yj7GgARTd(binaryReader.ReadBytes(count));
				}
			}
			catch (Exception ex)
			{
				if (ex.InnerException is SocketException && ((SocketException)ex.InnerException).SocketErrorCode == SocketError.Interrupted)
					return;
				this.OnError(ex);
			}
			finally
			{
				this.RNl3aLUdD = (TcpClient)null;
				this.SlIRVIT0r = (NetworkStream)null;
				this.OnClosed();
			}
		}
	}
}
