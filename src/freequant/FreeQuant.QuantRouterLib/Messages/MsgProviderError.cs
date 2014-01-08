using FreeQuant.QuantRouterLib.Data;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Messages
{
  public class MsgProviderError : Message
  {
	public ProviderError Data {   get;   private set; }

	public MsgProviderError() : base(12)
    {

      this.Data = new ProviderError();
    }

    protected override void OnGetData(BinaryWriter writer)
    {
      writer.Write(this.Data.Code);
      writer.Write(this.Data.DateTime.Ticks);
      writer.Write(this.Data.Description);
      writer.Write((byte) this.Data.ErrorType);
      writer.Write(this.Data.Id);
      writer.Write(this.Data.ProviderId);
    }

    protected override void OnSetData(BinaryReader reader)
    {
      this.Data.Code = reader.ReadInt32();
      this.Data.DateTime = new DateTime(reader.ReadInt64());
      this.Data.Description = reader.ReadString();
      this.Data.ErrorType = (ProviderErrorType) reader.ReadByte();
      this.Data.Id = reader.ReadInt32();
      this.Data.ProviderId = reader.ReadByte();
    }
  }
}
