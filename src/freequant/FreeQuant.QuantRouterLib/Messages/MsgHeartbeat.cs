using FreeQuant.QuantRouterLib.Data;
using System.IO;

namespace FreeQuant.QuantRouterLib.Messages
{
	public class MsgHeartbeat : Message
	{
		public Heartbeat Data { get; private set; }

		public MsgHeartbeat() : base(3)
		{
		}

		public MsgHeartbeat(Heartbeat hearbeat) : base(3)
		{
			this.Data = hearbeat;
		}

		protected override void OnGetData(BinaryWriter writer)
		{
		}

		protected override void OnSetData(BinaryReader reader)
		{
		}
	}
}
