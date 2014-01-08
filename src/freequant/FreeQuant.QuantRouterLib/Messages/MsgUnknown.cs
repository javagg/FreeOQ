using System.IO;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Messages
{
  public class MsgUnknown : Message
  {
    public byte[] Data { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

	public MsgUnknown(int type) : base(type)
    {
      this.Data = new byte[0];
    }

    protected override void OnSetData(BinaryReader reader)
    {
      int count = (int) (reader.BaseStream.Length - reader.BaseStream.Position);
      this.Data = reader.ReadBytes(count);
    }
  }
}
