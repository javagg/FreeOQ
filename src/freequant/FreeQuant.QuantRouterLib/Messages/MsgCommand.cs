using FreeQuant.QuantRouterLib.Data;
using System.IO;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Messages
{
  public class MsgCommand : Message
  {
		public Command Data { get;   private set; }

		public MsgCommand() : base(1100)
    {

    }

	public MsgCommand(Command command) :base(1100)
    {

      this.Data = command;
    }

    protected override void OnGetData(BinaryWriter writer)
    {
      writer.Write(this.Data.CommandId);
      writer.Write(this.Data.CommandType);
      writer.Write(this.Data.ProviderId);
      writer.Write(this.Data.Text);
      writer.Write(this.Data.Instrument.Currency);
      writer.Write(this.Data.Instrument.Exchange);
      writer.Write(this.Data.Instrument.InstrumentType);
      writer.Write(this.Data.Instrument.Symbol);
      writer.Write(this.Data.Order.Account);
      writer.Write(this.Data.Order.ClientId);
      writer.Write((byte) this.Data.Order.Side);
      writer.Write((byte) this.Data.Order.OrdType);
      writer.Write(this.Data.Order.Price);
      writer.Write(this.Data.Order.Qty);
      writer.Write(this.Data.Order.StopPx);
      writer.Write((byte) this.Data.Order.TimeInForce);
    }

    protected override void OnSetData(BinaryReader reader)
    {
      this.Data.CommandId = reader.ReadInt32();
      this.Data.CommandType = reader.ReadByte();
      this.Data.ProviderId = reader.ReadByte();
      this.Data.Text = reader.ReadString();
      this.Data.Instrument.Currency = reader.ReadString();
      this.Data.Instrument.Exchange = reader.ReadString();
      this.Data.Instrument.InstrumentType = reader.ReadString();
      this.Data.Instrument.Symbol = reader.ReadString();
      this.Data.Order.Account = reader.ReadString();
      this.Data.Order.ClientId = reader.ReadString();
      this.Data.Order.Side = (char) reader.ReadByte();
      this.Data.Order.OrdType = (char) reader.ReadByte();
      this.Data.Order.Price = reader.ReadDouble();
      this.Data.Order.Qty = reader.ReadDouble();
      this.Data.Order.StopPx = reader.ReadDouble();
      this.Data.Order.TimeInForce = (char) reader.ReadByte();
    }
  }
}
