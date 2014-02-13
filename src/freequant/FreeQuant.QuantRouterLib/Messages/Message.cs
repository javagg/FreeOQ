using System.IO;

namespace FreeQuant.QuantRouterLib.Messages
{
	public class Message
	{
		public int Type { get; private set; }

		protected Message(int type)
		{
			this.Type = type;
		}

		public void GetData(BinaryWriter writer)
		{
			this.OnGetData(writer);
		}

		public void SetData(BinaryReader reader)
		{
			this.OnSetData(reader);
		}

		protected virtual void OnGetData(BinaryWriter writer)
		{
		}

		protected virtual void OnSetData(BinaryReader reader)
		{
		}
	}
}
