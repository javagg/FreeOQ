using FreeQuant.QuantRouterLib.Data;
using System.IO;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Messages
{
  public class MsgSubscriptionStatus : Message
  {
    public SubscriptionStatus Data { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
		public MsgSubscriptionStatus() :  base(13)
    {
      this.Data = new SubscriptionStatus();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnGetData(BinaryWriter writer)
    {
      writer.Write(this.Data.Status);
      writer.Write(this.Data.Text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnSetData(BinaryReader reader)
    {
      this.Data.Status = reader.ReadByte();
      this.Data.Text = reader.ReadString();
    }
  }
}
