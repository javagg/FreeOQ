using FreeQuant.QuantRouterLib.Data;
using System.IO;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Messages
{
  public class MsgSubscriptionBase : Message
  {
	public Subscription Data {  get;  private set; }

	protected MsgSubscriptionBase(int type) : base(type) 
    {
      this.Data = new Subscription();
    }

    protected override void OnGetData(BinaryWriter writer)
    {
      writer.Write(this.Data.RequestId);
    }

    protected override void OnSetData(BinaryReader reader)
    {
      this.Data.RequestId = reader.ReadInt32();
    }
  }
}
