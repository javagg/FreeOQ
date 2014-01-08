using FreeQuant.QuantRouterLib.Data;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Messages
{
  public class MsgTick : Message
  {
    public Tick Data { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

	public MsgTick(Tick tick) : base(1000)
    {
      this.Data = tick;
    }

	public MsgTick() : base(1000)
    {
      this.Data = new Tick();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnGetData(BinaryWriter writer)
    {
      writer.Write(this.Data.RequestId);
      writer.Write(this.Data.SourceId);
      writer.Write((byte) this.Data.TickType);
      writer.Write(this.Data.DateTime.Ticks);
      writer.Write(this.Data.Price);
      writer.Write(this.Data.Size);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnSetData(BinaryReader reader)
    {
      this.Data.RequestId = reader.ReadInt32();
      this.Data.SourceId = reader.ReadInt32();
      this.Data.TickType = (TickType) reader.ReadByte();
      this.Data.DateTime = new DateTime(reader.ReadInt64());
      this.Data.Price = reader.ReadDouble();
      this.Data.Size = reader.ReadInt32();
    }
  }
}
